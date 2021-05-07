using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using CCTVMaskDetection.Detection;

namespace CCTVMaskDetection
{
    public partial class MainMenu : Form
    {

        #region 1. 필드 값들
        const int camera_count = 2;
        //총 카메라 개수 

        double[] counter = new double[camera_count];          
        double[] seconds = new double[camera_count];        
        Stopwatch[] watch = new Stopwatch[camera_count];      
        double[] fps = new double[camera_count];
        //각 화면 fps 측정용

        private Detection.Detection Detection0 = new Detection.Detection();
        //Mask Detector 메서드 -> 해당 클래스에 모두 넣으면 코드가 복잡해지므로 분리

        VideoCapture[] videoCapture = new VideoCapture[camera_count];
        VideoWriter[] videoWriter = new VideoWriter[camera_count];
        //VideoCapture -> 0번 화면 1번화면 카메라 영상
        //VideoWriter -> 영상 저장에 필요한 객체

        INI ini = new INI();
        //ini 파일 생성 객체

        int[] count = new int[camera_count];
        int[] nocount = new int[camera_count];
        //마스크, 노마스크 수 저장 

        public int[] webAddr = new int[camera_count];
        public string[] rtspAddr = new string[camera_count];
        //카메라 주소 저장용. 장치 번호 : int형, 네트워크 주소 : string형 

        Mat[] image = new Mat[camera_count];
        //PictureBox에 들어갈 Mat image

        System.Windows.Forms.Timer[] cam_timer = new System.Windows.Forms.Timer[camera_count];
        //영상처리 및 DNN 로직 동시 구동을 위한 타이머1,2

        private string path = "";
        //저장경로 

        #endregion
        #region 2. Getter Setter
        public string Path { get => path; set => path = value; }
        #endregion
        #region 3. BackgroundWorkers
        BackgroundWorker bgWorker = new BackgroundWorker();
        Thread camera_load_thread;

        #endregion
        public MainMenu()
        {
            InitializeComponent();
            count[0] = 0;
            count[1] = 0;
            nocount[0] = 0;
            nocount[1] = 0;
            cam_timer[0] = timer1;
            cam_timer[1] = timer2;
            //변수 초기화 
        }
        private void path_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();    //저장경로 지정
            if (fbd.ShowDialog() == DialogResult.OK)    //저장경로가 선택되면 
            {
                savePath.Text = fbd.SelectedPath;
                Path = savePath.Text + "\\";
            }
        }
        private void addrSaveBtn_0_Click(object sender, EventArgs e)
        {

            FileInfo IniDel = new FileInfo(System.Windows.Forms.Application.StartupPath + "\\CAM_Log1.ini");
            if (IniDel.Exists)   //ini 파일 존재 확인
            {
                IniDel.Delete();   //기존 ini 파일 삭제
            }

            if (camera0_addr.Text != "")
            {
                if (chk_wc0.Checked == true)
                {
                    ini.WriteValue("CAMinfor", "Address", camera0_addr.Text, System.Windows.Forms.Application.StartupPath + "\\CAM_Log1.ini"); //ini 파일 생성, 기록
                    ini.WriteValue2("TYPE", "type", "web", System.Windows.Forms.Application.StartupPath + "\\CAM_Log1.ini");

                    int ch = Convert.ToInt32(camera0_addr.Text);
                    webAddr[0] = ch;
                }
                else if (chk_Ip0.Checked == true)
                {
                    ini.WriteValue("CAMinfor", "Address", camera0_addr.Text, System.Windows.Forms.Application.StartupPath + "\\CAM_Log1.ini");
                    ini.WriteValue2("TYPE", "type", "ip", System.Windows.Forms.Application.StartupPath + "\\CAM_Log1.ini");

                    rtspAddr[0] = camera0_addr.Text;
                }
                ListViewItem lvi = new ListViewItem();
                lvi.Text = camera0_addr.Text;
                lvi.SubItems.Add("-");
                camera_list.Items.Add(lvi);
                camera0_addr.Text = string.Empty;

            }
        }

        private void addrSaveBtn_1_Click(object sender, EventArgs e)
        {
            FileInfo IniDel = new FileInfo(System.Windows.Forms.Application.StartupPath + "\\CAM_Log2.ini");
            if (IniDel.Exists)   //ini 파일 존재 확인
            {
                IniDel.Delete();   //기존 ini 파일 삭제
            }

            if (camera1_addr.Text != "")
            {
                if (chk_wc1.Checked == true)
                {
                    int ch = Convert.ToInt32(camera1_addr.Text);
                    webAddr[1] = ch;

                    ini.WriteValue("CAMinfor", "Address", camera1_addr.Text, System.Windows.Forms.Application.StartupPath + "\\CAM_Log2.ini");
                    ini.WriteValue2("TYPE", "type", "web", System.Windows.Forms.Application.StartupPath + "\\CAM_Log2.ini");
                }
                else if (chk_Ip1.Checked == true)
                {
                    ini.WriteValue("CAMinfor", "Address", camera1_addr.Text, System.Windows.Forms.Application.StartupPath + "\\CAM_Log2.ini");
                    ini.WriteValue2("TYPE", "type", "ip", System.Windows.Forms.Application.StartupPath + "\\CAM_Log2.ini");

                    rtspAddr[1] = camera1_addr.Text;
                }
                ListViewItem lvi = new ListViewItem();
                lvi.Text = camera1_addr.Text;
                lvi.SubItems.Add("-");
                camera_list.Items.Add(lvi);
                camera1_addr.Text = string.Empty;
            }
        }

        private void IOButton0_Click(object sender, EventArgs e)    //전원버튼 0 
        {
            int camera_num = 0;
            if (videoCapture[camera_num].IsOpened())
            {
                if (cam_timer[camera_num].Enabled == false)
                {
                    IOButton0.Image = Properties.Resources.icons8_shutdown_48__1_;
                    watch[camera_num] = Stopwatch.StartNew();
                    cam_timer[camera_num].Start();
                }
                else
                {
                    //타이머 정지
                    cam_timer[camera_num].Enabled = false;
                    IOButton0.Image = Properties.Resources.icons8_shutdown_48__2_;  //아이콘 원상복귀 
                }
            }
        }

        private void IOButton1_Click(object sender, EventArgs e)    //전원버튼 1 
        {
            int camera_num = 1;
            if (videoCapture[camera_num].IsOpened())
            {
                if (cam_timer[camera_num].Enabled == false)
                {
                    IOButton1.Image = Properties.Resources.icons8_shutdown_48__1_;
                    watch[camera_num] = Stopwatch.StartNew();
                    cam_timer[camera_num].Start();
                }
                else 
                {
                    //타이머 정지
                    cam_timer[camera_num].Enabled = false;
                    IOButton1.Image = Properties.Resources.icons8_shutdown_48__2_;
                }

            }
        }

        private void 프로그램종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "TeamConatus CCTV방역관제시스템", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 만든사람들ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credit credit = new credit();
            credit.Show();
        }

        private void camera_connect_Click(object sender, EventArgs e)
        {
            camera_load_thread = new Thread(new ThreadStart(camera_load));
            camera_load_thread.Start();
        }

        private void camera_load()
        {
            for (int i = 0; i < camera_list.Items.Count; i++)
            {
                videoCapture[i] = new VideoCapture();
                videoWriter[i] = new VideoWriter();

                try
                {
                    if (chk_wc0.Checked == true)
                    {
                        videoCapture[0].Open(webAddr[0]);
                    }
                    else
                    {
                        videoCapture[0].Open(rtspAddr[0]);
                    }

                    if (chk_wc1.Checked == true)
                    {
                        videoCapture[1].Open(webAddr[1]);
                    }
                    else
                    {
                        videoCapture[1].Open(rtspAddr[1]);
                    }

                }
                catch (Exception e)
                {

                }

                if (videoCapture[i].IsOpened())
                {
                    string now_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
                    //카메라 리스트 업데이트

                    camera_list.Items[i].SubItems[1].Text = "연결 성공";
                    if (i == 0)
                        camera0_consol.AppendText("연결 성공 " + now_time + Environment.NewLine);
                    else
                        camera1_consol.AppendText("연결 성공 " + now_time + Environment.NewLine);
                }
                else
                {
                    camera_list.Items[i].SubItems[1].Text = "연결 실패";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //타이머, 0번 카메라 
        {
            int camera_num = 0;
            image[camera_num] = new Mat();
            if (videoCapture[camera_num].Read(image[camera_num]))
            {
                counter[camera_num]++;
                seconds[camera_num] = watch[camera_num].ElapsedMilliseconds / (double)1000;
                fps[camera_num] = (counter[camera_num] / seconds[camera_num]) * 1.1;

                (Mat frame, int mask, int nomask) = Detection0.DetectMask(image[camera_num], count[camera_num], nocount[camera_num]);
                Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                cctvMonitor0.Image = bitmap;

                if (nomask != count[camera_num])    //노마스크일 때만 로그를 출력하기 위해 현 카운트 값과 노마스크 수 값을 비교 
                {
                    Write_nomask_log(camera_num, mask, nomask);   //노마스크 로그 출력 
                    count[camera_num] = 0;
                }

                if (capture_cbtn.Checked == true && camera0_select.Checked == true && camera1_select.Checked == false)   //캡쳐 버튼이 눌리면
                {
                    Capture_image(frame, camera_num);
                    capture_cbtn.Checked = false;
                }

                if (record_cbtn.Checked == true && camera0_select.Checked == true && camera1_select.Checked == false)   //녹화버튼이 눌리면 videowriter객체 생성 
                {
                    Creat_VideoWriter(camera_num, image[camera_num], fps[camera_num]);
                    stop_cbtn.Image = Properties.Resources.icons8_stop_48;
                    record_cbtn.Checked = false;    //비디오 객체 생성 분기 진입 해제를 위한 false 처리 
                    stop_cbtn.Checked = true;       //stop 버튼을 true로 해줌으로서 비디오 녹화 시작 
                }

                if (stop_cbtn.Checked == true)  //녹화 중지 버튼이 눌리지 않는 한 계속 녹화
                {
                    videoWriter[camera_num].Write(image[camera_num]);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e) // 1번 카메라 
        {
            int camera_num = 1;
            image[camera_num] = new Mat();
            if (videoCapture[camera_num].Read(image[camera_num]))
            {
                counter[camera_num]++;
                seconds[camera_num] = watch[camera_num].ElapsedMilliseconds / (double)1000;
                fps[camera_num] = (counter[camera_num] / seconds[camera_num]) * 1.1;
                //result 프레임과 마스크 착용 자 수, 마스크를 착용하지 않은 자 수를 반환 
                (Mat frame, int mask, int nomask) = Detection0.DetectMask(image[camera_num], count[camera_num], nocount[camera_num]);
                Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                cctvMonitor1.Image = bitmap;

                if (nomask != count[camera_num])
                    Write_nomask_log(camera_num, mask, nomask);   //노마스크 로그 출력 
                count[camera_num] = 0;

                if (capture_cbtn.Checked == true && camera0_select.Checked == false && camera1_select.Checked == true)   //캡쳐 버튼이 눌리면
                {
                    Capture_image(frame, camera_num);   //이미지 캡쳐 및 저장
                    capture_cbtn.Checked = false;
                }

                if (record_cbtn.Checked == true && camera0_select.Checked == false && camera1_select.Checked == true)   //녹화버튼이 눌리면 videowriter객체 생성 
                {
                    Creat_VideoWriter(camera_num, image[camera_num], fps[camera_num]);
                    stop_cbtn.Image = Properties.Resources.icons8_stop_48;
                    record_cbtn.Checked = false;    //비디오 객체 생성 분기 진입 해제를 위한 false 처리 
                    stop_cbtn.Checked = true;       //stop 버튼을 true로 해줌으로서 비디오 녹화 시작 
                }

                if (stop_cbtn.Checked == true)  //녹화 중지 버튼이 눌리지 않는 한 계속 녹화
                {
                    videoWriter[camera_num].Write(image[camera_num]);
                }
            }
        }

        private void backup_Click(object sender, EventArgs e)
        {
            // 1번 카메라 백업
            FileInfo filecheck0 = new FileInfo(System.Windows.Forms.Application.StartupPath + "\\CAM_Log1.ini");
            if (filecheck0.Exists)
            {
                string type = ini.ReadValue2("TYPE", "type", System.Windows.Forms.Application.StartupPath + "\\CAM_Log1.ini");

                if (type == "web")
                {
                    chk_wc0.PerformClick();

                    string webaddr = ini.ReadValue("CAMinfor", "Address", System.Windows.Forms.Application.StartupPath + "\\CAM_Log1.ini");

                    camera0_addr.Text = webaddr;
                }
                else
                {
                    chk_Ip0.PerformClick();

                    string rtspaddr = ini.ReadValue("CAMinfor", "Address", System.Windows.Forms.Application.StartupPath + "\\CAM_Log1.ini");

                    camera0_addr.Text = rtspaddr;
                }
                addrSaveBtn_0.PerformClick();
            }

            // 2번 카메라 백업
            FileInfo filecheck1 = new FileInfo(System.Windows.Forms.Application.StartupPath + "\\CAM_Log2.ini");
            if (filecheck1.Exists)
            {
                string type = ini.ReadValue2("TYPE", "type", System.Windows.Forms.Application.StartupPath + "\\CAM_Log2.ini");

                if (type == "web")
                {
                    chk_wc1.PerformClick();

                    string webaddr = ini.ReadValue("CAMinfor", "Address", System.Windows.Forms.Application.StartupPath + "\\CAM_Log2.ini");

                    camera1_addr.Text = webaddr;
                }
                else
                {
                    chk_Ip1.PerformClick();

                    string rtspaddr = ini.ReadValue("CAMinfor", "Address", System.Windows.Forms.Application.StartupPath + "\\CAM_Log2.ini");

                    camera1_addr.Text = rtspaddr;
                }
                addrSaveBtn_1.PerformClick();
            }
            camera_connect.PerformClick();
        }


        private void Write_nomask_log(int camera_num, int maskcnt, int nomaskcnt) //노마스크 탐지시 로그 출력을 위한 함수 
        {
            string date_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");

            if (camera_num == 0)
            {
                camera0_consol.AppendText("탐지된 인원 : " + (maskcnt + nomaskcnt) + " / " + "마스크 : " + maskcnt + " / " + " 노 마스크 : " + nomaskcnt + Environment.NewLine + "시각 : " + date_time + Environment.NewLine);
                count[0] = 0;
            }
            else if (camera_num == 1)
            {
                camera1_consol.AppendText("탐지된 인원 : " + (maskcnt + nomaskcnt) + " / " + "마스크 : " + maskcnt + " / " + " 노 마스크 : " + nomaskcnt + Environment.NewLine + "시각 : " + date_time + Environment.NewLine);
                count[1] = 0;
            }
        }

        private void Creat_VideoWriter(int camera_num, Mat image, double fps) //비디오 녹화 생성 
        {
            string date_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
            videoWriter[camera_num].Open(Path + date_time + camera_num + ".avi", FourCC.XVID, fps, image.Size());

            if (camera_num == 0)
                camera0_consol.AppendText("카메라 : " + camera_num + " / " + "녹화 시각 : " + date_time + " / " + "프레임 : " + fps + Environment.NewLine + "저장 위치 : " + Path + Environment.NewLine);
            else if (camera_num == 1)
                camera1_consol.AppendText("카메라 : " + camera_num + " / " + "녹화 시각 : " + date_time + " / " + "프레임 : " + fps + Environment.NewLine + "저장 위치 : " + Path + Environment.NewLine);
        }

        private void Capture_image(Mat image, int camera_num) //프레임 캡쳐 및 저장 
        {
            string date_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
            if (camera_num == 0)
            {
                camera0_consol.AppendText("카메라 : " + camera_num + " / " + "캡처 시각 : " + date_time + Environment.NewLine + "저장 위치 : " + Path + Environment.NewLine);
                Cv2.ImWrite(Path + date_time + camera_num + ".png", (image));
            }
            else if (camera_num == 1)
            {
                camera1_consol.AppendText("카메라 : " + camera_num + " / " + "캡처 시각 : " + date_time + Environment.NewLine + "저장 위치 : " + Path + Environment.NewLine);
                Cv2.ImWrite(Path + date_time + camera_num + ".png", (image));
            }
        }

        private void stop_cbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (stop_cbtn.Checked == false)
            {
                if (camera0_select.Checked == true && camera1_select.Checked == false)
                {
                    videoWriter[0].Release();    //동영상 녹화 중지 (작업 메모리 할당 해제) 
                    camera0_consol.AppendText("녹화 중지" + Environment.NewLine);

                }
                else if (camera0_select.Checked == false && camera1_select.Checked == true)
                {
                    videoWriter[1].Release();
                    camera1_consol.AppendText("녹화 중지" + Environment.NewLine);

                }
                stop_cbtn.Image = Properties.Resources.icons8_stop_squared_32;
            }
        }

        private void list_reset_Click(object sender, EventArgs e)
        {
            camera_list.Items.Clear(); //리스트 목록 초기화 
        }

        private void log0_clear_Click(object sender, EventArgs e)
        {
            camera0_consol.Clear(); //로그창 지우기
        }

        private void log1_clear_Click(object sender, EventArgs e)
        {
            camera1_consol.Clear(); //로그창 지우기
        }

        private void log0_save_Click(object sender, EventArgs e)
        {
            string logfile_name = "camera0_log.txt";
            System.IO.File.WriteAllText(Path + logfile_name, camera0_consol.Text, Encoding.Default);
            camera0_consol.AppendText("로그 저장됨 " + Path + logfile_name + Environment.NewLine);
        }

        private void log1_save_Click(object sender, EventArgs e)
        {
            string logfile_name = "camera1_log.txt";
            System.IO.File.WriteAllText(Path + logfile_name, camera1_consol.Text, Encoding.Default);
            camera1_consol.AppendText("로그 저장됨 " + Path + logfile_name + Environment.NewLine);
        }
    }
}


using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace CCTVMaskDetection
{
    public partial class MainMenu : Form
    {

        #region 1. 카메라 관련 값들
        const int camera_count = 2;
        //총 카메라 개수 
        double[] counter = new double[camera_count];
        double[] seconds = new double[camera_count];
        Stopwatch[] watch = new Stopwatch[camera_count];
        double[] fps = new double[camera_count];
        //각 화면 fps 측정용
        VideoCapture[] videoCapture = new VideoCapture[camera_count];
        VideoWriter[] videoWriter = new VideoWriter[camera_count];
        //VideoCapture -> 0번 화면 1번화면 카메라 영상
        //VideoWriter -> 영상 저장에 필요한 객체
        INI ini = new INI();
        //ini 파일 생성 객체
        public int[] webAddr = new int[camera_count];
        public string[] rtspAddr = new string[camera_count];
        //카메라 주소 저장용. 장치 번호 : int형, 네트워크 주소 : string형 
        Mat[] image = new Mat[camera_count];
        //PictureBox에 들어갈 Mat image
        private string path = "";
        //저장경로
        #endregion
        #region 2. 마스크 탐지 관련 값들
        private Detection.Detection Detection0 = new Detection.Detection();
        //Mask Detector 메서드 -> 해당 클래스에 모두 넣으면 코드가 복잡해지므로 분리

        int[] count = new int[camera_count];
        int[] nocount = new int[camera_count];
        //마스크, 노마스크 수 저장 
        System.Windows.Forms.Timer[] cam_timer = new System.Windows.Forms.Timer[camera_count];
        //영상처리 및 DNN 로직 동시 구동을 위한 타이머1,2
        #endregion

        #region 3. Getter Setter
        public string Path { get => path; set => path = value; }
        #endregion
        #region 4. Thread
        Thread camera_load_thread;
        #endregion
        #region 5. Constructor
        public MainMenu()
        {
            InitializeComponent();
            count[0] = 0;
            count[1] = 0;
            nocount[0] = 0;
            nocount[1] = 0;
            cam_timer[0] = timer1;
            cam_timer[1] = timer2;
            backUp_camera0();
            backUp_camera1();
            //변수 초기화 
        }
        #endregion
        private void path_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();    //저장경로 지정
            if (fbd.ShowDialog() == DialogResult.OK)    //저장경로가 선택되면 
            {
                savePath.Text = fbd.SelectedPath;//선택 된 경로로 저장 경로 설정
                Path = savePath.Text + "\\";//Path 필드 값 설정
            }
        }
        #region 6. Camera Setting Method
        private void addrSaveBtn_0_Click(object sender, EventArgs e)
        {
            FileInfo IniDel = new FileInfo(Application.StartupPath + "\\CAM_Log1.ini");
            if (IniDel.Exists)   //ini 파일 존재 확인
            {
                IniDel.Delete();   //기존 ini 파일 삭제
            }

            if (camera0_addr.Text != "")
            {
                if (chk_wc0.Checked == true)
                {
                    ini.WriteValue("CAMinfor", "Address", camera0_addr.Text, Application.StartupPath + "\\CAM_Log1.ini"); //ini 파일 생성, 기록
                    ini.WriteValue2("TYPE", "type", "web", Application.StartupPath + "\\CAM_Log1.ini");

                    int ch = Convert.ToInt32(camera0_addr.Text);
                    webAddr[0] = ch;
                }
                else if (chk_Ip0.Checked == true)
                {
                    ini.WriteValue("CAMinfor", "Address", camera0_addr.Text, Application.StartupPath + "\\CAM_Log1.ini");
                    ini.WriteValue2("TYPE", "type", "ip", Application.StartupPath + "\\CAM_Log1.ini");

                    rtspAddr[0] = camera0_addr.Text;
                }
                ListViewItem lvi = new ListViewItem();//카메라 리스트에 들어갈 데이터 값
                lvi.Text = camera0_addr.Text;
                lvi.SubItems.Add("-");
                camera_list.Items.Add(lvi);
                camera0_addr.Text = string.Empty;
                //추가 되는 데이터들
            }
        }

        private void addrSaveBtn_1_Click(object sender, EventArgs e)
        {
            FileInfo IniDel = new FileInfo(Application.StartupPath + "\\CAM_Log2.ini");
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

                    ini.WriteValue("CAMinfor", "Address", camera1_addr.Text, Application.StartupPath + "\\CAM_Log2.ini");
                    ini.WriteValue2("TYPE", "type", "web", Application.StartupPath + "\\CAM_Log2.ini");
                }
                else if (chk_Ip1.Checked == true)
                {
                    ini.WriteValue("CAMinfor", "Address", camera1_addr.Text, Application.StartupPath + "\\CAM_Log2.ini");
                    ini.WriteValue2("TYPE", "type", "ip", Application.StartupPath + "\\CAM_Log2.ini");

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
        private void camera_connect_Click(object sender, EventArgs e)
        {
            camera_load_thread = new Thread(new ThreadStart(camera_load));
            camera_load_thread.Start();
        }
        private void camera0_Check()
        {
            if (chk_wc0.Checked == true)
            {
                videoCapture[0].Open(webAddr[0]);
            }
            else if (chk_Ip0.Checked == true)
            {
                videoCapture[0].Open(rtspAddr[0]);
            }
        }
        private void camera1_Check()
        {
            if (chk_wc1.Checked == true)
            {
                videoCapture[1].Open(webAddr[1]);
            }
            else if (chk_Ip1.Checked == true)
            {
                videoCapture[1].Open(rtspAddr[1]);
            }
        }
        private void camera1_load()
        {
            camera0_Check(); 
            if (videoCapture[0].IsOpened())
            {
                string now_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
                //카메라 리스트 업데이트

                camera_list.Items[0].SubItems[1].Text = "연결 성공";
                camera0_console0.AppendText("연결 성공 " + now_time + Environment.NewLine);
            }
            else
            {
                camera_list.Items[0].SubItems[1].Text = "연결 실패";
            }
        }
        private void camera2_load()
        {
            camera1_Check();
            if (videoCapture[1].IsOpened())
            {
                string now_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
                //카메라 리스트 업데이트

                camera_list.Items[1].SubItems[1].Text = "연결 성공";
                camera1_console0.AppendText("연결 성공 " + now_time + Environment.NewLine);
            }
            else
            {
                camera_list.Items[1].SubItems[1].Text = "연결 실패";
            }
        }

        private void camera_load()
        {
            videoCapture[0] = new VideoCapture();
            videoCapture[1] = new VideoCapture();

            videoWriter[0] = new VideoWriter();
            videoWriter[1] = new VideoWriter();
            try
            {
                camera1_load();
            }
            catch { }
            try
            {
                camera2_load();
            }
            catch { }
        }
        private void backUp_camera0()
        {
            // 1번 카메라 백업
            FileInfo filecheck0 = new FileInfo(Application.StartupPath + "\\CAM_Log1.ini");
            if (filecheck0.Exists)
            {
                string type = ini.ReadValue2("TYPE", "type", Application.StartupPath + "\\CAM_Log1.ini");

                if (type == "web")
                {
                    Console.WriteLine("Web");
                    chk_wc0.Checked = true;
                    string webaddr = ini.ReadValue("CAMinfor", "Address", Application.StartupPath + "\\CAM_Log1.ini");
                    camera0_addr.Text = webaddr;
                    addrSaveBtn_0.PerformClick();
                }
                else
                {
                    chk_Ip0.Checked = true;
                    string rtspaddr = ini.ReadValue("CAMinfor", "Address", Application.StartupPath + "\\CAM_Log1.ini");
                    camera0_addr.Text = rtspaddr;
                    addrSaveBtn_0.PerformClick();
                }
                ListViewItem lvi = new ListViewItem();//카메라 리스트에 들어갈 데이터 값
                lvi.Text = camera0_addr.Text;
                lvi.SubItems.Add("-");
                camera_list.Items.Add(lvi);
                camera0_addr.Text = string.Empty;
            }
        }
        private void backUp_camera1()
        {
            // 2번 카메라 백업
            FileInfo filecheck1 = new FileInfo(Application.StartupPath + "\\CAM_Log2.ini");
            if (filecheck1.Exists)
            {
                string type = ini.ReadValue2("TYPE", "type", Application.StartupPath + "\\CAM_Log2.ini");

                if (type == "web")
                {
                    chk_wc1.Checked = true;
                    string webaddr = ini.ReadValue("CAMinfor", "Address", Application.StartupPath + "\\CAM_Log2.ini");
                    camera1_addr.Text = webaddr;
                    addrSaveBtn_1.PerformClick();
                }
                else
                {
                    chk_Ip1.Checked = true;
                    string rtspaddr = ini.ReadValue("CAMinfor", "Address", Application.StartupPath + "\\CAM_Log2.ini");
                    camera1_addr.Text = rtspaddr;
                    addrSaveBtn_1.PerformClick();
                }
                ListViewItem lvi = new ListViewItem();//카메라 리스트에 들어갈 데이터 값
                lvi.Text = camera1_addr.Text;
                lvi.SubItems.Add("-");
                camera_list.Items.Add(lvi);
                camera1_addr.Text = string.Empty;
            }
        }

        #endregion
        #region 7. Camera Running Method
        private void TimerTick(int camera_num)
        {
            image[camera_num] = new Mat();
            if (videoCapture[camera_num].Read(image[camera_num]))
            {
                counter[camera_num]++;
                seconds[camera_num] = watch[camera_num].ElapsedMilliseconds / (double)1000;
                fps[camera_num] = (counter[camera_num] / seconds[camera_num]) * 1.1;

                (Mat frame, int mask, int nomask) = Detection0.DetectMask(image[camera_num]);
                Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                cctvMonitor0.Image = bitmap;

                Write_nomask_log(camera_num, mask, nomask, fps[camera_num]);   //노마스크 로그 출력 
                count[camera_num] = 0;

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

        private void timer1_Tick(object sender, EventArgs e) //타이머, 0번 카메라 
        {
            TimerTick(0);
        }

        private void timer2_Tick(object sender, EventArgs e) // 1번 카메라 
        {
            TimerTick(1);
        }
        private void Write_nomask_log(int camera_num, int maskcnt, int nomaskcnt, double Fps) //노마스크 탐지시 로그 출력을 위한 함수 
        {
            string date_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");

            if (camera_num == 0)
            {
                camera0_console0.Clear();
                camera0_console0.AppendText("현재 시각 : " + date_time + Environment.NewLine);
                camera0_console0.AppendText("탐지된 인원 : " + (maskcnt + nomaskcnt) + " / " + "마스크 착용자 : " + maskcnt + " / " + " 마스크 미착용자 : " + nomaskcnt + Environment.NewLine);
                camera0_console0.AppendText("초당 프레임 수 : " + Fps);
                count[0] = 0;
            }
            else if (camera_num == 1)
            {
                camera1_console0.Clear();
                camera1_console0.AppendText("현재 시각 : " + date_time + Environment.NewLine);
                camera1_console0.AppendText("탐지된 인원 : " + (maskcnt + nomaskcnt) + " / " + "마스크 착용자 : " + maskcnt + " / " + " 마스크 미착용자 : " + nomaskcnt + Environment.NewLine);
                camera1_console0.AppendText("초당 프레임 수 : " + Fps);
                count[1] = 0;
            }
        }

        #endregion
        #region 8. Capture Method
        private void Creat_VideoWriter(int camera_num, Mat image, double fps) //비디오 녹화 생성 
        {
            string date_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
            videoWriter[camera_num].Open(Path + date_time + camera_num + ".avi", FourCC.XVID, fps, image.Size());

            if (camera_num == 0)
            {
                camera0_console1.AppendText("카메라 : " + camera_num + " / " + "녹화 시각 : " + date_time + " / " + "프레임 : " + fps + Environment.NewLine + "저장 위치 : " + Path + Environment.NewLine);
            }
            else if (camera_num == 1)
            {
                camera1_console1.AppendText("카메라 : " + camera_num + " / " + "녹화 시각 : " + date_time + " / " + "프레임 : " + fps + Environment.NewLine + "저장 위치 : " + Path + Environment.NewLine);
            }
        }

        private void Capture_image(Mat image, int camera_num) //프레임 캡쳐 및 저장 
        {
            string date_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
            if (camera_num == 0)
            {
                camera0_console1.AppendText("카메라 : " + camera_num + " / " + "캡처 시각 : " + date_time + Environment.NewLine + "저장 위치 : " + Path + Environment.NewLine);
                Cv2.ImWrite(Path + date_time + camera_num + ".png", (image));
            }
            else if (camera_num == 1)
            {
                camera1_console1.AppendText("카메라 : " + camera_num + " / " + "캡처 시각 : " + date_time + Environment.NewLine + "저장 위치 : " + Path + Environment.NewLine);
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
                    camera0_console1.AppendText("녹화 중지" + Environment.NewLine);

                }
                else if (camera0_select.Checked == false && camera1_select.Checked == true)
                {
                    videoWriter[1].Release();
                    camera1_console1.AppendText("녹화 중지" + Environment.NewLine);

                }
                stop_cbtn.Image = Properties.Resources.icons8_stop_squared_32;
            }
        }
        #endregion
        private void list_reset_Click(object sender, EventArgs e)
        {
            camera_list.Items.Clear();
            //리스트 목록 초기화 
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
    }
}


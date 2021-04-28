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
        private Stopwatch stopWatch = new Stopwatch(); 
        private double recordSpeed = 0.0;
        private string path = "";
        //카메라 녹화 관련 값들
        
        private Detection.Detection Detection0 =  new Detection.Detection(Program.PrototxtPath, Program.CaffemodelPath, Program.MaskdetectorPath);
        //Mask Detector 메서드 -> 해당 클래스에 모두 넣으면 코드가 복잡해지므로 분리

        VideoCapture[] videoCapture = new VideoCapture[camera_count]; 
        VideoWriter[] videoWriter = new VideoWriter[camera_count];
        //VideoCapture -> 0번 화면 1번화면 카메라 영상
        //VideoWriter -> 영상 저장에 필요한 객체

        INI ini = new INI(); //ini 파일 생성 객체
        
        const int camera_count = 2;

        public int[] webAddr = new int[camera_count];           //웹켐 장치 번호 
        public string[] rtspAddr = new string[camera_count];    //rtsp 주소 
        double[] counter = new double[camera_count];            //fps 측정용 
        double[] seconds = new double[camera_count];            //fps 측정용 
        Stopwatch[] watch = new Stopwatch[camera_count];      //fps 측정용 
        double[] fps = new double[camera_count];
        Mat[] image = new Mat[camera_count];
        Bitmap[] bitmap = new Bitmap[camera_count]; 
        
        System.Windows.Forms.Timer[] cam_timer = new System.Windows.Forms.Timer[camera_count];
        //타이머
        DateTime[] cam_watch = new DateTime[camera_count];
        //???
        #endregion
        #region 2. Getter Setter
        public Stopwatch StopWatch { get => stopWatch; set => stopWatch = value; }
        public string Path { get => path; set => path = value; }
        #endregion
        #region 3. BackgroundWorkers
        BackgroundWorker bgWorker = new BackgroundWorker();
        Thread camera_load_thread;
        Thread[] camera_thread = new Thread[camera_count];
        #endregion
        //public string Path = "";
        public MainMenu()
        {
            InitializeComponent();

            //bgWorker.DoWork += (sender, args) => detectionLoading();
        }
        private void Power_btn_Click(object sender, EventArgs e)    //이미지 캡쳐 중지 
        {
            for (int i = 0; i < camera_list.Items.Count; i++)
            {
                videoCapture[i].Release();
            }
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
        

        private void IOButton0_Click(object sender, EventArgs e)
        {
            int camera_num = 0;
            camera_thread[camera_num] = new Thread(() => cam_thread(camera_num));
            camera_thread[camera_num].Start(); 
        }
        private void IOButton1_Click(object sender, EventArgs e)
        {
            int camera_num = 1;
            camera_thread[camera_num] = new Thread(() => cam_thread(camera_num));
            camera_thread[camera_num].Start();
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

        private void connect_check_Click(object sender, EventArgs e)
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
                    if (i==0)
                        camera0_consol.AppendText("연결 성공 " + now_time+ Environment.NewLine);
                    else
                        camera1_consol.AppendText("연결 성공 " + now_time + Environment.NewLine);
                }
                else
                {
                    camera_list.Items[i].SubItems[1].Text = "연결 실패" ;
                }
            }
        }

        private void cam_thread(int camera_num) //카메라 동시 구동을 위한 스레드 
        {
            watch[camera_num] = Stopwatch.StartNew();
            while (camera_list.Items[camera_num].SubItems[1].Text == "연결 성공")
            {               
                image[camera_num] = new Mat();
                
                if (videoCapture[camera_num].Read(image[camera_num]))
                {
                    counter[camera_num]++;
                    seconds[camera_num] = watch[camera_num].ElapsedMilliseconds / (double)1000;
                    fps[camera_num] = counter[camera_num] / seconds[camera_num];

                    //Mat frame = Detection0.DetectMask(image[camera_num]);
                    bitmap[camera_num] = BitmapConverter.ToBitmap(image[camera_num]);
                    if (camera_num == 0)
                        cctvMonitor0.Image = bitmap[camera_num];
                    else
                        cctvMonitor1.Image = bitmap[camera_num];

                    if (capture_cbtn.Checked == true)   //캡쳐 버튼이 눌리면 Path에 파일 생성
                    {
                        string date_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
                        Cv2.ImWrite(Path + date_time + camera_num + ".png", (image[camera_num]));  //파일 저장
                        Thread.Sleep(10);

                        capture_cbtn.Checked = false;
                        if (camera_num == 0)
                        {       
                            camera0_consol.AppendText("캡처 저장 위치 : " + Path + Environment.NewLine + "캡처 시각 : " + date_time + Environment.NewLine + "캡처 카메라 : " + camera_num + Environment.NewLine);
                        }
                        else
                        { 
                            camera1_consol.AppendText("캡처 저장 위치 : " + Path + Environment.NewLine + "캡처 시각 : " + date_time + Environment.NewLine + "캡처 카메라 : " + camera_num + Environment.NewLine);
                        }
                    }

                    if (record_cbtn.Checked == true)   //녹화버튼이 눌리면 videowriter객체 생성 
                    {
                        string date_time = DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");

                        if (camera0_record.Checked == true && camera1_record.Checked == true)
                        {
                            videoWriter[camera_num].Open(Path + date_time + camera_num + ".avi", FourCC.XVID, fps[camera_num], image[camera_num].Size());
                            if (camera_num == 0)
                                camera0_consol.AppendText("녹화 저장 위치 : " + Path + Environment.NewLine + "녹화 시각 : " + date_time + Environment.NewLine + "프레임 : " + fps[0] + Environment.NewLine + "녹화 카메라 : " + 0 + Environment.NewLine);
                            else
                                camera1_consol.AppendText("녹화 저장 위치 : " + Path + Environment.NewLine + "녹화 시각 : " + date_time + Environment.NewLine + "프레임 : " + fps[1] + Environment.NewLine + "녹화 카메라 : " + 1 + Environment.NewLine);
                        }
                        else if (camera0_record.Checked == true && camera_num == 0)
                        {
                            videoWriter[0].Open(Path + date_time + 0 + ".avi", FourCC.XVID, fps[0], image[0].Size());
                            Thread.Sleep(10);
                            camera0_consol.AppendText("녹화 저장 위치 : " + Path + Environment.NewLine + "녹화 시각 : " + date_time + Environment.NewLine + "프레임 : " + fps[0] + Environment.NewLine + "녹화 카메라 : " + 0 + Environment.NewLine);
                        }
                        else if (camera1_record.Checked == true && camera_num == 1)
                        {
                            videoWriter[1].Open(Path + date_time + 1 + ".avi", FourCC.XVID, fps[1], image[1].Size());
                            Thread.Sleep(10);
                            camera1_consol.AppendText("녹화 저장 위치 : " + Path + Environment.NewLine + "녹화 시각 : " + date_time + Environment.NewLine + "프레임 : " + fps[1] + Environment.NewLine + "녹화 카메라 : " + 1 + Environment.NewLine);
                        }
                        record_cbtn.Checked = false;
                        stop_cbtn.Checked = true;
                    }
                    if (stop_cbtn.Checked == true)
                    {
                        videoWriter[camera_num].Write(image[camera_num]);
                    }
                }
            }
        }

        private void screen0_select_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (screen0_select_btn.Checked == true)
            {
                cctvMonitor0.Visible = false;
            }
            else
            {
                cctvMonitor0.Visible = true;
            }
        }

        private void screen1_select_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (screen1_select_btn.Checked == true)
            {
                cctvMonitor1.Visible = false;
            }
            else
            {
                cctvMonitor1.Visible = true;
            }
        }

        private void stop_cbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (stop_cbtn.Checked == false)
            {
                if (camera0_record.Checked == true && camera1_record.Checked == true)
                {
                    videoWriter[0].Release();
                    videoWriter[1].Release();
                }
                else if (camera0_record.Checked == true && camera1_record.Checked == false)
                    {
                    videoWriter[0].Release();
                }
                else if (camera0_record.Checked == false && camera1_record.Checked == true)
                {
                    videoWriter[1].Release();
                }
            }
        }

        private void connect_delete_Click(object sender, EventArgs e)
        {
            camera_list.Items.Clear();  //리스트 항목 모두 제거 
        }

        private void backUpBtn_Click(object sender, EventArgs e)
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
            connect_check.PerformClick();

            //IOButton0.PerformClick();
            //IOButton1.PerformClick();
        }
    }
}


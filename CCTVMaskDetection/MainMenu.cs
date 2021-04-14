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
        private VideoWriter camera1_video;
        private double recordSpeed = 0.0;
        private string path = "";
        //카메라 녹화 관련 값들
        
        private Detection.Detection Detection0 =  new Detection.Detection();
        //Mask Detector 메서드 -> 해당 클래스에 모두 넣으면 코드가 복잡해지므로 분리

        VideoCapture[] videoCapture = new VideoCapture[camera_count]; 
        VideoWriter[] videoWriter = new VideoWriter[camera_count];
        //VideoCapture -> 0번 화면 1번화면 카메라 영상
        //VideoWriter -> 영상 저장에 필요한 객체

        INI ini = new INI(); //ini 파일 생성 객체
        
        const int camera_count = 2;
        //카매라 개수는 2개
        public int[] webAddr = new int[camera_count];
        public string[] rtspAddr = new string[camera_count];
        
        Mat[] image = new Mat[camera_count];
        //PictureBox에 들어갈 Mat 2개
        System.Windows.Forms.Timer[] cam_timer = new System.Windows.Forms.Timer[camera_count];
        //타이머
        DateTime[] cam_watch = new DateTime[camera_count];
        //???
        #endregion
        #region 2. Getter Setter
        public Stopwatch StopWatch { get => stopWatch; set => stopWatch = value; }
        public VideoWriter Camera1_video { get => camera1_video; set => camera1_video = value; }
        public double RecordSpeed { get => recordSpeed; set => recordSpeed = value; }
        public string Path { get => path; set => path = value; }
        #endregion
        #region 3. BackgroundWorkers
        BackgroundWorker bgWorker = new BackgroundWorker();
        Thread camera_load_thread;

        #endregion


        //public string Path = "";
        public MainMenu()
        {
            InitializeComponent();
            cam_timer[0] = timer1;
            cam_timer[1] = timer2;
        }

        private void ON_btn_Click(object sender, EventArgs e)
        {
            //CCTVMaskDetection.Properties.Resources.icon
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
            using (Mat image0 = new Mat())
            {
                if (IOButton0.Text.Equals("ON"))
                {
                    IOButton0.Text = "OFF";
                    while (IOButton0.Text.Equals("OFF"))
                    {
                        if (!videoCapture[0].Read(image0))
                        {
                            continue;
                            //Cv2.WaitKey();
                        }
                        if (image0.Size().Width > 0 && image0.Size().Height > 0)
                        {
                            Mat frame = Detection0.DetectMask(image0);
                            Bitmap bitmap = BitmapConverter.ToBitmap(frame);

                            cctvMonitor0.Image = bitmap;
                        }
                        if (Cv2.WaitKey(1) >= 27) break;
                    }
                }
                else if (IOButton0.Text.Equals("OFF"))
                {
                    videoCapture[0].Release();
                    IOButton0.Text = "ON";
                }
            }
        }
        private void IOButton1_Click(object sender, EventArgs e)
        {
            using (Mat image1 = new Mat())
            {
                if (IOButton1.Text.Equals("ON"))
                {
                    IOButton1.Text = "OFF";
                    while (IOButton1.Text.Equals("OFF"))
                    {
                        if (!videoCapture[1].Read(image1))
                        {
                            continue;
                            //Cv2.WaitKey();
                        }
                        if (image1.Size().Width > 0 && image1.Size().Height > 0)
                        {
                            //Mat frame = Detection1.DetectMask(image1);
                            Bitmap bitmap = BitmapConverter.ToBitmap(image1);
                            cctvMonitor1.Image = bitmap;
                        }
                        if (Cv2.WaitKey(1) >= 27) break;
                    }
                }
                else if (IOButton1.Text.Equals("OFF"))
                {
                    videoCapture[1].Release();
                    IOButton1.Text = "ON";
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

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
                    //카메라 리스트 업데이트
                    camera_list.Items[i].SubItems[1].Text = "연결 성공";
                    if (i==0)
                        camera0_consol.AppendText("연결 성공");
                    else if (i==1)
                        camera1_consol.AppendText("연결 성공");
                }
                else
                {
                    camera_list.Items[i].SubItems[1].Text = "연결 실패";
                }
            }
        }

        private void test0_Click(object sender, EventArgs e)
        {

            if (videoCapture[0].IsOpened())
            {        
                if (cam_timer[0].Enabled == false)
                {
                    cam_timer[0].Start();
                    cam_watch[0] = DateTime.Now;
                }
            }
            else
            {
                //경고 메시지 
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //카메라 동시 구동을 위한 타이머, 0번 카메라 
        {
            int camera_id = 0;
            image[camera_id] = new Mat();
            if (videoCapture[camera_id].Read(image[camera_id]))
            {
                Mat frame = Detection0.DetectMask(image[camera_id]);
                Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                cctvMonitor0.Image = bitmap;
            }
    
        }

        private void timer2_Tick(object sender, EventArgs e) // 1번 카메라 
        {
            int camera_id = 1;
            image[camera_id] = new Mat();
            if (videoCapture[camera_id].Read(image[camera_id]))
            {
                Mat frame = Detection0.DetectMask(image[camera_id]);
                Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                cctvMonitor1.Image = bitmap;
            }
        }

        private void test1_Click(object sender, EventArgs e)
        {
            if (videoCapture[1].IsOpened())
            {        
                if (cam_timer[1].Enabled == false)
                {
                    cam_timer[1].Start();
                    cam_watch[1] = DateTime.Now;
                }
            }
            else
            {
                //경고 메시지 
            }

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

            IOButton0.PerformClick();
            IOButton1.PerformClick();
        }
    }
}


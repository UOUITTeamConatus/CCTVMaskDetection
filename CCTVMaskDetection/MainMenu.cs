using System;
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
        //private Detection detection;
        private Detection.Detection Detection0;
        private Detection.Detection Detection1;
        VideoCapture[] videoCapture = new VideoCapture[camera_count]; 
        VideoWriter[] videoWriter = new VideoWriter[camera_count];
        const int camera_count = 2;
        public int[] webAddr = new int[camera_count];
        public string[] rtspAddr = new string[camera_count];
        Mat[] image = new Mat[camera_count];
        System.Windows.Forms.Timer[] cam_timer = new System.Windows.Forms.Timer[camera_count];
        DateTime[] cam_watch = new DateTime[camera_count];
        #endregion
        #region 2. Getter Setter
        public Stopwatch StopWatch { get => stopWatch; set => stopWatch = value; }
        public VideoWriter Camera1_video { get => camera1_video; set => camera1_video = value; }
        public double RecordSpeed { get => recordSpeed; set => recordSpeed = value; }
        public string Path { get => path; set => path = value; }
        //public bool Flag { get => flag; set => flag = value; }
        #endregion
        #region 3. BackgroundWorkers
        LoadingWindow loadingWindow = new LoadingWindow();
        BackgroundWorker bgWorker = new BackgroundWorker();
        Thread camera_load_thread;

        #endregion

        //public string Path = "";
        public MainMenu()
        {
            InitializeComponent();
            bgWorker.DoWork += (sender, args) => detectionLoading();
            bgWorker.RunWorkerCompleted += (sender, args) => detectionLoadingComplete();
        }
        void detectionLoading()
        {
            Detection0 = new Detection.Detection(Program.PrototxtPath, Program.CaffemodelPath, Program.MaskdetectorPath);
            Detection1 = new Detection.Detection(Program.PrototxtPath, Program.CaffemodelPath, Program.MaskdetectorPath);
            cam_timer[0] = timer1;
            cam_timer[1] = timer2;
        }
        void detectionLoadingComplete()
        {
            loadingWindow.Close();
        } 
        private void MainMenu_Load(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
            loadingWindow.ShowDialog();
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

            if (camera0_addr.Text != "")
            {
                if (chk_wc0.Checked == true)
                {
                    int ch = Convert.ToInt32(camera0_addr.Text);              
                    webAddr[0] = ch;
                }
                else if (chk_Ip0.Checked == true)
                {
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

            if (camera1_addr.Text != "")
            {
                if (chk_wc1.Checked == true)
                {
                    int ch = Convert.ToInt32(camera1_addr.Text);
                    webAddr[1] = ch;
                }
                else if (chk_Ip1.Checked == true)
                {
                    rtspAddr[1] = camera1_addr.Text;
                    camera_list.Items.Add(camera1_addr.Text);
                }
                ListViewItem lvi = new ListViewItem();
                lvi.Text = camera1_addr.Text;
                lvi.SubItems.Add("-");
                camera_list.Items.Add(lvi);
                camera1_addr.Text = string.Empty;
            }
        }

        /*
        void RunCamera0()
        {
            VideoCapture videoCapture;
            if (chk_wc0.Checked == true)
            {
                videoCapture = new VideoCapture(WEBaddr0);
            }
            else
            {
                videoCapture = new VideoCapture(RtspAddr0);
            }
            using (Mat image = new Mat())
            {
                if (IOButton0.Text.Equals("ON"))
                {
                    IOButton0.Text = "OFF";
                    while (IOButton0.Text.Equals("OFF"))
                    {
                        if (!videoCapture.Read(image))
                        {
                            Cv2.WaitKey();
                        }
                        if (image.Size().Width > 0 && image.Size().Height > 0)
                        {
                            Mat result = Detection0.DetectMask(image);
                            Bitmap bitmap = BitmapConverter.ToBitmap(result);
                            cctvMonitor0.Image = bitmap;
                        }
                        if (Cv2.WaitKey(1) >= 27) break;
                    }
                }
                else
                {
                    videoCapture.Release();
                    IOButton0.Text = "ON";
                }
            }

        }*/
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
                            //Mat frame = Detection0.DetectMask(image0);
                            Bitmap bitmap = BitmapConverter.ToBitmap(image0);

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

        private void test_Click(object sender, EventArgs e)
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
                //Mat frame = Detection0.DetectMask(image[0]);
                Bitmap bitmap = BitmapConverter.ToBitmap(image[camera_id]);
                cctvMonitor0.Image = bitmap;
            }
    
        }

        private void timer2_Tick(object sender, EventArgs e) // 1번 카메라 
        {
            int camera_id = 1;
            image[camera_id] = new Mat();
            if (videoCapture[camera_id].Read(image[camera_id]))
            {
                //Mat frame = Detection0.DetectMask(image[0]);
                Bitmap bitmap = BitmapConverter.ToBitmap(image[camera_id]);
                cctvMonitor0.Image = bitmap;
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
    }
}


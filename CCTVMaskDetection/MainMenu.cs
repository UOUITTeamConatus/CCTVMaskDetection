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
using OpenCvSharp;
using OpenCvSharp.Extensions;
using CCTVMaskDetection.Detection;
using System.Threading;

namespace CCTVMaskDetection
{
    public partial class MainMenu : Form
    {

        #region 1. 필드 값들
        private int wEBaddr0 = 999;
        private int wEBaddr1 = 999;
        private string rtspAddr0 = "";
        private string rtspAddr1 = "";
        private Stopwatch stopWatch = new Stopwatch();
        private VideoWriter camera1_video;
        private double recordSpeed = 0.0;
        private string path = "";
        //private Detection detection;
        private Detection.Detection Detection0;
        private Detection.Detection Detection1;
        private VideoCapture videoCapture0;
        private VideoCapture videoCapture1;
        #endregion
        #region 2. Getter Setter
        public int WEBaddr0 { get => wEBaddr0; set => wEBaddr0 = value; }
        public int WEBaddr1 { get => wEBaddr1; set => wEBaddr1 = value; }
        public string RtspAddr0 { get => rtspAddr0; set => rtspAddr0 = value; }
        public string RtspAddr1 { get => rtspAddr1; set => rtspAddr1 = value; }
        public Stopwatch StopWatch { get => stopWatch; set => stopWatch = value; }
        public VideoWriter Camera1_video { get => camera1_video; set => camera1_video = value; }
        public double RecordSpeed { get => recordSpeed; set => recordSpeed = value; }
        public string Path { get => path; set => path = value; }
        //public bool Flag { get => flag; set => flag = value; }
        #endregion
        #region 3. BackgroundWorkers
        LoadingWindow loadingWindow = new LoadingWindow();
        BackgroundWorker bgWorker = new BackgroundWorker();

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
            videoCapture0 = new VideoCapture(0);
            videoCapture1 = new VideoCapture("rtsp://192.168.0.137/profile2/media.smp");
            //Thread.Sleep(5000);
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
        private void pathSaveBtn_0_Click(object sender, EventArgs e)
        {
            if(chk_wc0.Checked == true)
            {
                int ch = Convert.ToInt32(camera1_add.Text);
                WEBaddr0 = ch;
                camera1_add.Text = string.Empty;
            }
            else if(chk_Ip0.Checked == true)
            {
                RtspAddr0 = camera1_add.Text;
                camera1_add.Text = string.Empty;
            }
        }

        private void pathSaveBtn_1_Click(object sender, EventArgs e)
        {
            if(chk_wc1.Checked == true)
            {
                int ch = Convert.ToInt32(camera2_add.Text);
                WEBaddr1 = ch;
                camera2_add.Text = string.Empty;
            }
            else if(chk_Ip1.Checked == true)
            {
                RtspAddr1 = camera2_add.Text;
                camera2_add.Text = string.Empty;
            }
        }
        void LoadVideoCapture0Web(object sender, DoWorkEventArgs e)
        {
            videoCapture0 = new VideoCapture(WEBaddr0);
            //Thread.Sleep(5000);
        } 
        void LoadVideoCapture0ipAddr(object sender, DoWorkEventArgs e)
        {
            videoCapture0 = new VideoCapture(RtspAddr0);
            //Thread.Sleep(5000);
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
        private void connect_btn0_Click(object sender, EventArgs e)
        {
            if (chk_wc0.Checked == true)
            {
                videoCapture0 = new VideoCapture(WEBaddr0);
            }
            else
            {
                videoCapture0 = new VideoCapture(RtspAddr0);
            }

            using (Mat image0 = new Mat())
            {
                if (IOButton0.Text.Equals("ON"))
                {
                    IOButton0.Text = "OFF";
                    while (IOButton0.Text.Equals("OFF"))
                    {
                        if (!videoCapture0.Read(image0))
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
                    videoCapture0.Release();
                    IOButton0.Text = "ON";
                }
            }
        }
        private void connect_btn1_Click(object sender, EventArgs e)
        {
            if (chk_wc1.Checked == true)
            {
                videoCapture1 = new VideoCapture(WEBaddr1);
            }
            else
            {
                videoCapture1 = new VideoCapture(RtspAddr1);
            }
            using (Mat image1 = new Mat())
            {
                if (IOButton1.Text.Equals("ON"))
                {
                    IOButton1.Text = "OFF";
                    while (IOButton1.Text.Equals("OFF"))
                    {
                        if (!videoCapture1.Read(image1))
                        {
                            continue;
                            //Cv2.WaitKey();
                        }
                        if (image1.Size().Width > 0 && image1.Size().Height > 0)
                        {
                            Mat frame = Detection1.DetectMask(image1);
                            Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                            cctvMonitor1.Image = bitmap;
                        }
                        if (Cv2.WaitKey(1) >= 27) break;
                    }
                }
                else if (IOButton1.Text.Equals("OFF"))
                {
                    videoCapture1.Release();
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

    }
}

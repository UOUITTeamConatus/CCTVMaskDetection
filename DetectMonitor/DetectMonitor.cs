using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keras.Models;
using Keras.Applications.MobileNet;
using Keras.PreProcessing.Image;
using Numpy;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Dnn;


namespace DetectMonitor
{
    public partial class DetectMonitor : PictureBox
    {
        #region 1: 필드 값들
        private static string currentPath = Path.GetDirectoryName(
            Directory.GetParent(Environment.CurrentDirectory).Parent.FullName
        );
        private string prototxtPath = currentPath + "\\models\\deploy.prototxt";
        private string caffemodelPath = currentPath + "\\models\\res10_300x300_ssd_iter_140000.caffemodel";
        private string maskdetectorPath = currentPath + "\\models\\total.model";

        private BaseModel model;
        private Net facenet;
        private MobileNetV2 mobilenetv2;
        #endregion
        public DetectMonitor()
        {
            InitializeComponent();
            facenet = CvDnn.ReadNetFromCaffe(prototxtPath, caffemodelPath);
            model = BaseModel.LoadModel(maskdetectorPath);
            mobilenetv2 = new MobileNetV2();
        }
        private void DetectMask()
        {

        }
    }
}

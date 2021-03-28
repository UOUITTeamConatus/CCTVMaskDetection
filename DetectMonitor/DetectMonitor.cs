using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Keras.Models;
using Keras.Applications.MobileNet;
using OpenCvSharp.Dnn;

namespace DetectMonitor
{
    public partial class DetectMonitor : Panel
    {
        private string currentPath = Path.GetDirectoryName(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName);
    }
}

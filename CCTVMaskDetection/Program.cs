using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTVMaskDetection
{
    static class Program
    {
        //경로정보 -> 필요한 파일들에 대한 경로 정보 test
        private static string currentPath = Environment.CurrentDirectory;
        private static string prototxtPath = currentPath + "\\models\\deploy.prototxt";
        private static string caffemodelPath = currentPath + "\\models\\res10_300x300_ssd_iter_140000.caffemodel";
        private static string maskdetectorPath = currentPath + "\\models\\total.model";

        public static string CurrentPath { get => currentPath; set => currentPath = value; }
        public static string PrototxtPath { get => prototxtPath; set => prototxtPath = value; }
        public static string CaffemodelPath { get => caffemodelPath; set => caffemodelPath = value; }
        public static string MaskdetectorPath { get => maskdetectorPath; set => maskdetectorPath = value; }

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var pythonPath = currentPath + "\\python";
            //Environment.SetEnvironmentVariable("PATH", $@"{pythonPath};" + Environment.GetEnvironmentVariable("PATH"));
            Environment.SetEnvironmentVariable("PYTHONHOME", pythonPath);
            Environment.SetEnvironmentVariable("PYTHONPATH ", $@"{pythonPath}\Lib");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}

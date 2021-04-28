using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CCTVMaskDetection
{
    public class INI
    {
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(String section, String key, String val, String filePath);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(String section, String key, String def, StringBuilder retVal, int size, String filePath);

        public void WriteValue(String strSection, String strkey, String strValue, String iniPath) //ini 파일 기록하고 저장
        {
            WritePrivateProfileString(strSection, strkey, strValue, iniPath);
        }

        public void WriteValue2(String strSection2, String strkey2, String strValue2, String iniPath) //ini 파일 기록하고 저장
        {
            WritePrivateProfileString(strSection2, strkey2, strValue2, iniPath);
        }

        public string ReadValue(string strSection, String key, String iniPath) //ini 파일 기록 불러오기
        {
            StringBuilder strValue = new StringBuilder(255);
            int i = GetPrivateProfileString(strSection, key, "", strValue, 255, iniPath);
            return strValue.ToString();
        }

        public string ReadValue2(string strSection2, String key2, String iniPath) //ini 파일 기록 불러오기
        {
            StringBuilder strValue2 = new StringBuilder(255);
            int j = GetPrivateProfileString(strSection2, key2, "", strValue2, 255, iniPath);
            return strValue2.ToString();
        }
    }
}

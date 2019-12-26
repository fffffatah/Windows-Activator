using Microsoft.Win32;

namespace Windows_Activator
{
    public class OSinfo
    {
        private string ReturnOSver()
        {
            string ProductName = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();
            return ProductName;
        }
        public string GetKey()
        {
            if(ReturnOSver().Equals("Windows 10 Home Single Language"))
            {
                return "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
            }
            else if(ReturnOSver().Equals("Windows 10 Home")) 
            {
                return "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
            }
            else if(ReturnOSver().Equals("Windows 10 Home N"))
            {
                return "3KHY7-WNT83-DGQKR-F7HPR-844BM";
            }
            else if (ReturnOSver().Equals("Windows 10 Home Country Specific"))
            {
                return "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
            }
            else if(ReturnOSver().Equals("Windows 10 Professional"))
            {
                return "W269N-WFGWX-YVC9B-4J6C9-T83GX";
            }
            else if(ReturnOSver().Equals("Windows 10 Professional N"))
            {
                return "MH37W-N47XK-V7XM9-C7227-GCQG9";
            }
            else if(ReturnOSver().Equals("Windows 10 Education"))
            {
                return "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
            }
            else if(ReturnOSver().Equals("Windows 10 Education N"))
            {
                return "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
            }
            else if(ReturnOSver().Equals("Windows 10 Enterprise"))
            {
                return "NPPR9-FWDCX-D2C8J-H872K-2YT43";
            }
            else if(ReturnOSver().Equals("Windows 10 Enterprise N"))
            {
                return "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
            }
            return "notcompatible";
        }
    }
}

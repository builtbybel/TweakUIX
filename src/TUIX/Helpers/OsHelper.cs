using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace TweakUIX.Helpers
{
    public class OsHelper
    {
        public string IsWin11()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
                int osbuild = Convert.ToInt32(key.GetValue("CurrentBuildNumber"));
                if (osbuild >= 21996)
                {
                    return "Windows 11";
                }
            }
            catch { }
            return "Windows 10 (Partial support)";
        }

        public string GetVersion()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            var UBR = key.GetValue("UBR").ToString();
            var CurrentBuild = key.GetValue("CurrentBuild").ToString();

            string version = CurrentBuild + "." + UBR;

            return "Build " + version;
        }

        public string Is64Bit()
        {
            string bitness = string.Empty;

            if (Environment.Is64BitOperatingSystem)
            {
                bitness = "64bit";
            }
            else
            {
                bitness = "32bit";
            }

            return bitness;
        }

        // Ref. https://docs.microsoft.com/en-us/previous-versions/system-center/configuration-manager-2003/cc180825(v=technet.10)?redirectedfrom=MSDN
        public string GetChassisType()
        {
            if (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery)
            {
                return "Desktop";
            }
            else
            {
                return "Laptop";
            }
        }
    }
}
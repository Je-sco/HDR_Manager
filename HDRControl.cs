using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace HDR_Manager
{
    static public class HDRControl
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        static public void ToggleHDR()  // Toggles HDR through the keybind, other methods exist but seem to be undocumented
        {
            const int VK_LWIN = 0x5B;
            const int VK_MENU = 0x12;
            const int VK_B = 0x42;

            keybd_event((byte)VK_LWIN, 0, 0, UIntPtr.Zero); // Press Win key
            keybd_event((byte)VK_MENU, 0, 0, UIntPtr.Zero); // Press Alt key
            keybd_event((byte)VK_B, 0, 0, UIntPtr.Zero);    // Press B key

            keybd_event((byte)VK_LWIN, 0, 0x0002, UIntPtr.Zero); // Release Win key
            keybd_event((byte)VK_MENU, 0, 0x0002, UIntPtr.Zero); // Release Alt key
            keybd_event((byte)VK_B, 0, 0x0002, UIntPtr.Zero);    // Release B key

            Thread.Sleep(5000); // Takes a while for HDR to turn on and for the registry key to update

        }

        static public bool GetHDRStatus()
        {
            const string REG_PATH = "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\MonitorDataStore";
            const string VALUE_NAME = "AdvancedColorEnabled";

            RegistryKey reg = Registry.LocalMachine.OpenSubKey(REG_PATH, false);

            foreach (string subkey in reg.GetSubKeyNames())
            {
                RegistryKey subReg = reg.OpenSubKey(subkey);
                if (Convert.ToInt32(subReg.GetValue(VALUE_NAME, -1)) == 1)
                {
                    return true;
                }
            }
            return false;
        }

        static public void SetHDR(bool value)
        {
            if (value && !GetHDRStatus())
            {
                ToggleHDR();
            }
            if (!value && GetHDRStatus())
            {
                ToggleHDR();
            }
        }

    }
}

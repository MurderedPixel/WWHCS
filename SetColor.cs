using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWHCS {
    public class SetColor {

        public int MainColor { get; set; }
        public int SecondaryColor { get; set; }
        public int Customized { get; set; }

        RegistryKey DWM = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\DWM", true);
        RegistryKey windowOutline = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Accent", true);

        public void SetCustomValues(int main, int secondary) {
            MainColor = main;
            SecondaryColor = secondary;

            DWM.SetValue("AccentColor", MainColor, RegistryValueKind.DWord);
            DWM.SetValue("AccentColorInactive", SecondaryColor, RegistryValueKind.DWord);
            windowOutline.SetValue("AccentColorMenu", MainColor, RegistryValueKind.DWord);
            DWM.SetValue("ColorPrevalence", Customized, RegistryValueKind.DWord);
        }

        public void SetHeaderColors(int selectedTheme) {

            if (selectedTheme == 1) //dark
            {
                MainColor = 0x00141414; //Active color
                SecondaryColor = 0x000d0d0d; //Inactive color
                MainColor = 0x00141414; //Outline color (must be same as Active color otherwise broken)
                Customized = 1; //Be custom or not (0 == be default)
            }
            if (selectedTheme == 3) //Xbox green
            {
                MainColor = 0x00008700;
                SecondaryColor = 0x00004100;
                MainColor = 0x00008700;
                Customized = 1;
            }
            if (selectedTheme == 2) //oldschool ugly fcking blue
            {
                MainColor = 0x009f0000;
                SecondaryColor = 0x00510000;
                MainColor = 0x009f0000;
                Customized = 1;
            }
            if (selectedTheme == 0) //default lame
            {
                MainColor = 0;
                SecondaryColor = 0;
                MainColor = 0;
                Customized = 0;
            }
            if (selectedTheme == 4) //Blood (Red)
            {
                MainColor = 0x00040068;
                SecondaryColor = 0x0002003b;
                MainColor = 0x00040068;
                Customized = 1;
            }
            if (selectedTheme == 5) //Sky (actually good looking blue)
            {
                MainColor = 0x00ffd799;
                SecondaryColor = 0x007f5d28;
                MainColor = 0x00ffd799;
                Customized = 1;
            }
            if (selectedTheme == 6) //Red and Blue
            {
                MainColor = 0x00b44900;
                SecondaryColor = 0x002003b;
                MainColor = 0x00b44900;
                Customized = 1;
            }
            if (selectedTheme == 7) //Purple
            {
                MainColor = 0x00ff3bbe;
                SecondaryColor = 0x008a1764;
                MainColor = 0x00ff3bbe;
                Customized = 1;
            }
            if (selectedTheme == 8) //2023 logo style
            {
                MainColor = 0x00ff9100;
                SecondaryColor = 0x008a1764;
                MainColor = 0x00ff9100;
                Customized = 1;
            }
            if (selectedTheme == 9) //Only a sith deals in absolutes
            {
                MainColor = 0x00ffffff;
                SecondaryColor = 0x000d0d0d;
                MainColor = 0x00ffffff;
                Customized = 1;
            }
            if (selectedTheme == 10) //Metal (Red and Black)
            {
                MainColor = 0x001f1c80;
                SecondaryColor = 0x000d0d0d;
                MainColor = 0x001f1c80;
                Customized = 1;
            }

            DWM.SetValue("AccentColor", MainColor, RegistryValueKind.DWord);
            DWM.SetValue("AccentColorInactive", SecondaryColor, RegistryValueKind.DWord);
            windowOutline.SetValue("AccentColorMenu", MainColor, RegistryValueKind.DWord);
            DWM.SetValue("ColorPrevalence", Customized, RegistryValueKind.DWord);
        }
    }
}

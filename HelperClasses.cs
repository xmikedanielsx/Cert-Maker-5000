using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertMaker5000
{
    internal static class HelperClasses
    {
        /// <summary>
        /// This returns a <see cref="System.Drawing.Color"/>  when provided a string in the format of "#HexNumber" ex "#1e1e1e"
        /// </summary>
        /// <param name="hex"></param>
        /// <returns>System.Drawing.Color</returns>
        public static Color GetSystemColorFromHex(string hex)
        {
            System.Windows.Media.Color ColorFromHex;
            ColorFromHex = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(hex);
            return Color.FromArgb(ColorFromHex.A, ColorFromHex.R, ColorFromHex.G, ColorFromHex.B);
        }
        /// <summary>This Returns a <see cref="System.Drawing.Color"/> Based on Ssytem Theme Setings</summary>
        /// <returns>System.Drawing.Color</returns>
        public static Color GetSystemColor(bool IsDarkModeOverride = true)
        {
            if (GetWindowsColorMode() && IsDarkModeOverride == true)
            {
                return GetSystemColorFromHex("#1e1e1e");
            }
            else
            {
                return GetSystemColorFromHex("#CCCCCC");
            }
        }
        /// <summary>
        /// This returns a <see cref="System.Drawing.Color"/> for the Font Color to be used based on system settings.
        /// </summary>
        /// <returns></returns>
        public static Color GetSystemFontColor(bool IsDarkModeOverride = true)
        {
            // Dark mode
            if (GetWindowsColorMode() && IsDarkModeOverride == true)
            {
                return GetSystemColorFromHex("#CCCCCC");
            } 
            // Light Mode
            else
            {
                return Color.Black;
            }
        }


        /// <summary>Returns an <see cref="int"/> representing the system's theme
        /// <para>true=dark theme, false=light theme</para>
        /// </summary>
        public static bool GetWindowsColorMode(bool UseSystemModeInsteadOfAppMode = true)
        {
            try
            {
                return  ((int)Microsoft.Win32.Registry.GetValue(
                    @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize",
                    UseSystemModeInsteadOfAppMode ? "SystemUsesLightTheme" : "AppsUseLightTheme",
                    -1)) == 0 ? true : false;
            }
            catch
            {
                return false;
            }
        }

    }
}

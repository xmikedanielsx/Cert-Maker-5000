using CertMaker5000.Screens;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertMaker5000
{
    public static class HelperClasses
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
        public static Color GetSystemColor(bool DarkTheme)
        {
            if (DarkTheme)
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
        public static Color GetSystemFontColor(bool DarkTheme)
        {
            // Dark mode
            if (DarkTheme)
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

        public static void SetControlColor(Control control, bool DarkTheme)
        {
            Control? a = (GetInitialFormControls().Where(f => f.Key == control.GetType()).FirstOrDefault()).Value;
            //bool DarkTheme = GetWindowsColorMode();
            if (a != null)
            {
                if (DarkTheme)
                {
                    control.BackColor = GetSystemColor(DarkTheme);
                    control.ForeColor = GetSystemFontColor(DarkTheme);
                }
                else
                {
                    control.BackColor = a.BackColor;
                    control.ForeColor = a.ForeColor;
                }
            }
        }

        public static Dictionary<Type, Control> GetInitialFormControls()
        {
            Dictionary<Type,Control> rval = new();
            
            rval.Add(typeof(TabControl), new TabControl());
            rval.Add(typeof(TableLayoutPanel), new TableLayoutPanel());
            rval.Add(typeof(MenuStrip), new MenuStrip());
            rval.Add(typeof(Panel), new Panel());
            rval.Add(typeof(Form), new Form());
            rval.Add(typeof(ListBox), new ListBox());
            rval.Add(typeof(Button), new Button());
            rval.Add(typeof(Label), new Label());
            rval.Add(typeof(TabPage), new TabPage());
            rval.Add(typeof(MainForm), new Form() {});
            rval.Add(typeof(TextBox), new TextBox() {});



            return rval;
        }

    }
}

using CertMaker5000.Screens;
using System.Security.Cryptography;
using System.Text;

namespace CertMaker5000
{

    // ToDo: This will be removed later on. And inplace the controllers will pass the key that coems from a Network Share of some sort
    // This is just a random string to test with.
    

    public static class HelperClasses
    {
        private static string TestKeyEncryption = "3TYFEKbMkNh4sWJdNdUFQTCnBEwBQpWkW22EQTQU7QG8jPf4uLwpMvwf3EYvcuaB";

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

        /// <summary>
        /// Sets the Color of the BackColor and ForeColor for the control that is passed based on the DarkTheme that is passed as well
        /// </summary>
        /// <param name="control"></param>
        /// <param name="DarkTheme"></param>
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

        /// <summary>
        /// This simply returns a list of Default Controls that can be used for getting the default back and fore colors from
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Encrypts the plain text with a key that is passed with it. using Asymetric Encryption.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string EncryptString(string plainText, string key = null!)
        {
            if(key == null)
            {
                key = TestKeyEncryption;
            }
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        /// <summary>
        /// Decrypts the encrypted text if you pass the same key the encrypted text was encrypted with. if not you will just get garbage.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cipherText"></param>
        /// <returns></returns>
        public static string DecryptString(string cipherText, string key = null!)
        {
            if (key == null)
            {
                key = TestKeyEncryption;
            }
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
        
    }
}

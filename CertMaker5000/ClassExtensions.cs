using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CertMaker5000;

namespace CertMaker5000
{
    public static class ControlExtensions
    {
        public static Dictionary<Type, Control> ControlList = HelperClasses.GetInitialFormControls();


        public static void SetRecursion(Control.ControlCollection controls, bool DarkTheme)
        {
            foreach (Control control in controls)
            {
                control.SetTheme(DarkTheme);
            }
        }
        public static void SetRecursion(TabControl.TabPageCollection tabpages, bool DarkTheme)
        {
            foreach (TabPage tp in tabpages)
            {
                SetRecursion(tp.Controls, DarkTheme);
            }
        }
        //public static void SetRecursion(TabControl.TabPageCollection tabpages, bool DarkTheme)
        //{
        //    foreach (TabPage tp in tabpages)
        //    {
        //        SetRecursion(tp.Controls, DarkTheme);
        //    }
        //}
        public static void SetTheme(this Control control, bool DarkTheme)
        {
            HelperClasses.SetControlColor(control, DarkTheme);
            if (control is TabControl tc)
                SetRecursion(tc.TabPages, DarkTheme);

            foreach (Control c in control.Controls)
            {
                c.SetTheme(DarkTheme);
            }
            
        }
    }
}

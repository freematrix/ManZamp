using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManZamp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main(string[] args)
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new FormMain(args));
        //}


        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMain(args));
            //return;

            bool instanceCountOne = false;

            using (Mutex mtex = new Mutex(true, "ManZamp", out instanceCountOne))
            {

                bool _net_version_ok = Get45PlusFromRegistry();

                if(!_net_version_ok)
                {
                    MessageBox.Show(".Net framework incompatible - please install 4.7.2 or a newer version", "ManZamp", MessageBoxButtons.OK);
                }
                else if (instanceCountOne)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormMain(args));
                    mtex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("An application instance is already running", "ManZamp", MessageBoxButtons.OK);
                }
            }
        }


        /// <summary>
        /// Di default è ok dalla "4.7.2" in su - nel caso cambiare metodo
        /// </summary>
        /// <returns></returns>
        public static bool Get45PlusFromRegistry()
        {
            string sout = "";
            bool b_ok = false;
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";

            using (var ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    //sout += $".NET Framework Version: {CheckFor45PlusVersion((int)ndpKey.GetValue("Release"))}";
                    b_ok = CheckFor45PlusVersion((int)ndpKey.GetValue("Release"));
                }
                else
                {
                    //sout += ".NET Framework Version 4.5 or later is not detected.";
                    b_ok = false;
                }
            }

            
            // Checking the version using >= enables forward compatibility.
            bool CheckFor45PlusVersion(int releaseKey)
            {
                bool b_net_ok;
                if (releaseKey >= 528040)
                {
                    //"4.8 or later";
                    b_net_ok = true;
                }    
                else if (releaseKey >= 461808)
                {
                    //"4.7.2";
                    b_net_ok = true;
                }
                else if (releaseKey >= 461308)
                {
                    //"4.7.1";
                    b_net_ok = false;
                }
                else if (releaseKey >= 460798)
                {
                    //"4.7";
                    b_net_ok = false;
                }
                else if (releaseKey >= 394802)
                {
                    //"4.6.2";
                    b_net_ok = false;
                }
                else if (releaseKey >= 394254)
                {
                    //"4.6.1";
                    b_net_ok = false;
                }
                else if (releaseKey >= 393295)
                {
                    //"4.6";
                    b_net_ok = false;
                }
                else if (releaseKey >= 379893)
                {
                    //"4.5.2";
                    b_net_ok = false;
                }
                else if (releaseKey >= 378675)
                {
                    //"4.5.1";
                    b_net_ok = false;
                }
                else if (releaseKey >= 378389)
                {
                    //"4.5";
                    b_net_ok = false;
                }
                else
                {
                    // This code should never execute. A non-null release key should mean
                    // that 4.5 or later is installed.
                    //"No 4.5 or later version detected";

                    b_net_ok = false;
                }
                return b_net_ok;
            }

            return b_ok;
        }


    }
}

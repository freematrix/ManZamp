using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using System.Configuration;
using ManLib;
using ManLib.Business;

namespace ManZamp
{
    public partial class FormPathChange : Form
    {
        public string abs_main_path = "";
        
        public FormPathChange()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            abs_main_path = txt_mainpath.Text;
            

            if (Directory.Exists(abs_main_path))
            {
                this.Close();
            }

            if(Directory.Exists(abs_main_path))
            {
                string[] subdir = (from x in Directory.GetDirectories(abs_main_path) select new DirectoryInfo(x).Name).ToArray();
                if(!subdir.Contains("Apps"))
                {
                    ManZampLib.printMsg_and_exit("directory App not found inside " + abs_main_path, true);
                }
            }
            else
            {
                ManZampLib.printMsg_and_exit("base directory not found", true);
            }
        }

        private void FormPathChange_Load(object sender, EventArgs e)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            for (int i = 0; i < appSettings.Count; i++)
            {
                if ("pathBase".Equals(appSettings.GetKey(i)))
                {
                    txt_mainpath.Text = appSettings[i];
                }
                //Console.WriteLine("#{0} Key: {1} Value: {2}", i, appSettings.GetKey(i), appSettings[i]);
            }
        }
    }
}

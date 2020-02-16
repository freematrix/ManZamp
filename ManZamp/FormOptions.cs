using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManZamp.lib;
using ManZamp.Business;

namespace ManZamp
{
    public partial class FormOptions : Form
    {
        public ConfigVar cv;

        public FormOptions(ConfigVar cv)
        {
            InitializeComponent();
            this.cv = cv;
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            string svalidate = cv.validateSetting();
            if (!string.IsNullOrEmpty(svalidate))
            {
                ManZampLib.printMsg_and_exit(svalidate);
            }

            txtPathEditor.Text = cv.default_editor_path;
            numericUpDown_http.Value = Convert.ToInt32(cv.apache_http_port);
            numericUpDown_https.Value = Convert.ToInt32(cv.apache_https_port);
            numericUpDown_mariadb.Value = Convert.ToInt32(cv.mariadb_port);   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.txtPathEditor.Text.ToLower() != "notepad.exe" && !System.IO.File.Exists(txtPathEditor.Text))
            {
                MessageBox.Show("default_editor_path not found");
            }
            else if(changed_port() && procs_port())
            {
                MessageBox.Show("apache or mariadb running - before changhing any port close apache and mariadb");
            }
            else if(check_change())
            {
                cv.default_editor_path = txtPathEditor.Text.Trim().ToLower();
                cv.apache_http_port = numericUpDown_http.Value.ToString();
                cv.apache_https_port = numericUpDown_https.Value.ToString();
                cv.mariadb_port = numericUpDown_mariadb.Value.ToString();
            }
            this.Close();
        }

        private bool check_change()
        {
            return cv.default_editor_path != txtPathEditor.Text.Trim().ToLower() || changed_port();
        }

        private bool changed_port()
        {
            return cv.apache_http_port != numericUpDown_http.Value.ToString()
                || cv.apache_https_port != numericUpDown_https.Value.ToString()
                || cv.mariadb_port != numericUpDown_mariadb.Value.ToString();
        }

        private bool procs_port()
        {
            return ManZampLib.checkRunningProc(cv.getPID_apache) || ManZampLib.checkRunningProc(cv.getPID_mariadb);
        }
    }
}

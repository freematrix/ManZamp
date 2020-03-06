using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using ManLib;
using ManLib.Business;


namespace ManZamp
{
    public partial class FormMain : Form
    {
        #region vars
        public ConfigVar cv;
        #endregion

        #region constructor
        public FormMain(string[] args)
        {
            InitializeComponent();

            if(args != null && args.Length == 1 && args[0] == "setup")
            {
                ConfigVar _cv = new ConfigVar();
                string assemblyFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string root_folder = System.IO.Directory.GetParent(assemblyFolder).Parent.FullName;
                //root_folder = @"F:\SVL\zamp_template";
                _cv.updatePath(root_folder);
                //MessageBox.Show(root_folder);
                System.Threading.Thread.Sleep(1000);
                //System.Windows.Forms.Application.Exit();
            }
        }
        #endregion

        #region eventi
        private void FrmManZAMP_Load(object sender, EventArgs e)
        {
            try
            {
                cv = new ConfigVar();

                //base dir not exist
                //rebase directories
                if (!System.IO.Directory.Exists(cv.pathBase))
                {
                    //FormPathChange frm2 = new FormPathChange();
                    //DialogResult dr = frm2.ShowDialog(this);
                    //if (dr == DialogResult.OK)
                    //{
                    //    cv.updatePath(frm2.abs_main_path);
                    //}
                    //frm2.Close();
                    ManZampLib.printMsg_and_exit("Base folder changed - please run \"setup.vbs\"", true, this);
                }


                string svalidate = cv.validateSetting();
                if(!string.IsNullOrEmpty(svalidate))
                {
                    ManZampLib.printMsg_and_exit(svalidate);
                }

                string msg_port_in_use = "";
                if(ManZampLib.port_in_use(cv.apache_http_port))
                {
                    msg_port_in_use += "http port \"" + cv.apache_http_port + "\" in use" + Environment.NewLine;
                }
                if (ManZampLib.port_in_use(cv.apache_https_port))
                {
                    msg_port_in_use += "https port \"" + cv.apache_https_port + "\" in use" + Environment.NewLine;
                }
                if (ManZampLib.port_in_use(cv.mariadb_port))
                {
                    msg_port_in_use += "MariaDB port \"" + cv.mariadb_port + "\" in use" + Environment.NewLine;
                }
                if(!string.IsNullOrEmpty(msg_port_in_use))
                {
                    addOutput(msg_port_in_use);
                    MessageBox.Show(msg_port_in_use, "!!!!!", MessageBoxButtons.OK);
                }


                cv.get_software_version();
                refreshStatusForm();
            }
            catch (ConfigurationErrorsException er)
            {
                MessageBox.Show(er.ToString());
                ManZampLib.printMsg_and_exit();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManZampLib.printMsg_and_exit("", true);
        }
        private void runAllProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check_and_kill_other_instance(typeProg.apache);
            check_and_kill_other_instance(typeProg.mariadb);


            addOutput(ManZampLib.startProc(cv, typeProg.apache, new string[] { }));
            addOutput(ManZampLib.startProc(cv, typeProg.mariadb, new string[] { }));

            addOutput(ManZampLib.getStatusProc(cv, typeProg.apache));
            addOutput(ManZampLib.getStatusProc(cv, typeProg.mariadb));

            System.Threading.Thread.Sleep(1000);
            refreshStatusForm();
        }
        private void stopAllProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addOutput(ManZampLib.killproc(cv, typeProg.apache));
            addOutput(ManZampLib.killproc(cv, typeProg.mariadb));

            System.Threading.Thread.Sleep(1000);
            refreshStatusForm();
        }
        private void checkStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addOutput(ManZampLib.getStatusProc(cv, typeProg.apache));
            addOutput(ManZampLib.getStatusProc(cv, typeProg.mariadb));
        }
        private void changeBaseFolderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //FormPathChange
            ManZampLib.printMsg_and_exit("Move your zamp folder and then run \"setup.vbs\"");

            //FormPathChange frm2 = new FormPathChange();
            //DialogResult dr = frm2.ShowDialog(this);
            //if (dr == DialogResult.OK)
            //{
            //    cv.updatePath(frm2.abs_main_path);

            //}
            //frm2.Close();
        }
        private void changeConfig_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename_config = "";
            string vocemenu_chiamata = ((System.Windows.Forms.ToolStripMenuItem)sender).Name;
            switch(vocemenu_chiamata)
            {
                case "apacheHttpdconfToolStripMenuItem":
                    filename_config = cv.Apache_httpd_conf;
                    break;
                case "apacheHttpdvhostsconfToolStripMenuItem":
                    filename_config = cv.Apache_httpd_vhosts;
                    break;
                case "phpiniToolStripMenuItem":
                    filename_config = cv.PHP_ini;
                    break;
                case "mariadbIniToolStripMenuItem":
                    filename_config = cv.MariaDB_ini;
                    break;
            }
            ManZampLib.startProc(cv, typeProg.editor, new string[] { filename_config });
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOptions frm2 = new FormOptions(cv);
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                cv = frm2.cv;
                cv.updatePort();
                cv.updateDefaultEditor(cv.default_editor_path);
            }
            frm2.Close();
        }
        private void backupRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!ManZampLib.checkRunningProc(cv.getPID_mariadb))
            {
                MessageBox.Show("MariaDB is not running");
                return;
            }

            FormBackupRestore frm2 = new FormBackupRestore(cv);
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                
            }
            frm2.Close();
        }
        private void btnStartStopApache_Click(object sender, EventArgs e)
        {
            check_and_kill_other_instance(typeProg.apache);
            if (ManZampLib.checkRunningProc(cv.getPID_apache))
            {
                addOutput(ManZampLib.killproc(cv, typeProg.apache));
            }
            else
            {
                addOutput(ManZampLib.startProc(cv, typeProg.apache, new string[] { }));
            }
            System.Threading.Thread.Sleep(1000);
            refreshStatusForm();
        }
        private void btnStartStopMariaDB_Click(object sender, EventArgs e)
        {
            check_and_kill_other_instance(typeProg.mariadb);
            if (ManZampLib.checkRunningProc(cv.getPID_mariadb))
            {
                addOutput(ManZampLib.killproc(cv, typeProg.mariadb));
            }
            else
            {
                addOutput(ManZampLib.startProc(cv, typeProg.mariadb, new string[] { }));
            }
            System.Threading.Thread.Sleep(1000);
            refreshStatusForm();
        }
        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            refreshStatusForm();
        }
        private void btnConsole_Click(object sender, EventArgs e)
        {
            string apache_dir_bin = System.IO.Path.Combine(cv.pathApache, "bin");
            string mariadb_dir_bin = System.IO.Path.Combine(cv.pathMariaDB, "bin");

            ManZampLib.ExecuteBatchFile(System.IO.Path.Combine(cv.pathBase, "scripts", "open_console.bat"),
                    new string[] { apache_dir_bin, cv.pathPHP, mariadb_dir_bin }
            );
        }
        private void phpinfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _url = cv.url_phpinfo;
            if (!string.IsNullOrEmpty(_url))
            {
                System.Diagnostics.Process.Start(_url);
            }
        }

        private void phpMyAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _url = cv.url_phpmyadmin;
            if(!string.IsNullOrEmpty(_url))
            {
                System.Diagnostics.Process.Start(_url);
            }
        }

        private void adminerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _url = cv.url_adminer;
            if (!string.IsNullOrEmpty(_url))
            {
                System.Diagnostics.Process.Start(_url);
            }
        }
        #endregion

        #region private method


        private void refreshStatusForm()
        {
            lbVersion.Text = "Ambiente: " + cv._env;
            lb_baseFolder.Text = "Base Folder: " + cv.pathBase;

            bool bRunProc = ManZampLib.checkRunningProc(cv.getPID_apache);
            if (bRunProc)
            {
                pictureBoxApache.Image = Properties.Resources.bullet_green;
                btnStartStopApache.Text = "Stop";
            }
            else
            {
                pictureBoxApache.Image = Properties.Resources.bullet_red;
                btnStartStopApache.Text = "Start";
                if(!string.IsNullOrEmpty(cv.getPID_apache))
                {
                    cv.updatePID(typeProg.apache, typeStartorKill.start, null);
                }
                
            }



            bRunProc = ManZampLib.checkRunningProc(cv.getPID_mariadb);
            if (bRunProc)
            {
                pictureBoxMariaDB.Image = Properties.Resources.bullet_green;
                btnStartStopMariaDB.Text = "Stop";
            }
            else
            {
                pictureBoxMariaDB.Image = Properties.Resources.bullet_red;
                btnStartStopMariaDB.Text = "Start";
                if (!string.IsNullOrEmpty(cv.getPID_mariadb))
                {
                    cv.updatePID(typeProg.mariadb, typeStartorKill.start, null);
                }
                    
            }


            lbPHP_ver.Text = cv.php_vers;
            lbMariaDB_ver.Text = cv.mariadb_vers;
        }
        private void addOutput(string testo)
        {
            string[] lines = Regex.Split(testo, Environment.NewLine);
            foreach (string s in lines)
            {
                if(!string.IsNullOrEmpty(s))
                {
                    string datamia = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    txtOut.AppendText(datamia + " - " + s + Environment.NewLine);
                }
                
            }
        }
        private void check_and_kill_other_instance(typeProg tpg)
        {
            switch(tpg)
            {
                case typeProg.apache:
                    _check_and_kill_other_instance(cv.getPID_apache, cv.procApache, cv.get_friendly_name(typeProg.apache));
                    break;
                case typeProg.mariadb:
                    _check_and_kill_other_instance(cv.getPID_mariadb, cv.procMariaDB, cv.get_friendly_name(typeProg.mariadb));
                    break;
                case typeProg.apache_and_mariadb:
                    _check_and_kill_other_instance(cv.getPID_apache, cv.procApache, cv.get_friendly_name(typeProg.apache));
                    _check_and_kill_other_instance(cv.getPID_mariadb, cv.procMariaDB, cv.get_friendly_name(typeProg.mariadb));
                    break;
            }

        }
        private void _check_and_kill_other_instance(string pid, string nameproc, string friendly_name)
        {
            if (string.IsNullOrEmpty(pid) && ManZampLib.checkstatusProc_byName(nameproc))
            {
                DialogResult dialogResult = MessageBox.Show(friendly_name + " running from another program ? Do you want to kill every " + friendly_name + " process ?", friendly_name + " running", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    ManZampLib.killproc_byName(nameproc);
                    System.Threading.Thread.Sleep(1000);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    return;
                }
            }
        }


        #endregion
    }
}

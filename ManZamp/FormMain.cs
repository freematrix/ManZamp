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
        public string YN_DEBUG { get; set; }
        #endregion

        #region constructor
        public FormMain(string[] args)
        {
            InitializeComponent();

            cv = new ConfigVar();
            string assemblyFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string root_folder = System.IO.Directory.GetParent(assemblyFolder).Parent.FullName;

            //this.YN_DEBUG = ManZampLib.getval_from_appsetting("YN_DEBUG");
            //if(  !this.YN_DEBUG.Equals("Y")  )
            //{

            //root_folder = @"C:\Users\pablo\Desktop\varie\zamp_1.1.10";
            cv.updatePath(root_folder);
            cv = new ConfigVar();
            //}

        }
        #endregion

        #region eventi
        private void FrmManZAMP_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text += " - (User: " + ManLib.ManZampLib.getNameCurrent_user() + ")";
                
                if (!System.IO.Directory.Exists(cv.pathBase))
                {
                    ManZampLib.printMsg_and_exit("Path '" + cv.pathBase + "' does not exist", true, this);
                }


                string svalidate = cv.validateSetting();
                if(!string.IsNullOrEmpty(svalidate))
                {
                    ManZampLib.printMsg_and_exit(svalidate);
                }
                
                string msg_port_in_use = "";
                
                if(ManZampLib.port_in_use(cv.apache_http_port, cv.pid_currentproc_apache))
                {
                    msg_port_in_use += "http port \"" + cv.apache_http_port + "\" in use" + Environment.NewLine;
                }
                if (ManZampLib.port_in_use(cv.apache_https_port, cv.pid_currentproc_apache))
                {
                    msg_port_in_use += "https port \"" + cv.apache_https_port + "\" in use" + Environment.NewLine;
                }
                if (ManZampLib.port_in_use(cv.mariadb_port, cv.pid_currentproc_mariadb))
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

                List<string> arrListSite = ManZampLib.getListSite(cv);
                crealinkSite(arrListSite);

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

            
            refreshStatusForm();
        }
        private void stopAllProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addOutput(ManZampLib.killproc(cv, typeProg.apache));
            addOutput(ManZampLib.killproc(cv, typeProg.mariadb));

            refreshStatusForm();
        }
        private void checkStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addOutput(ManZampLib.getStatusProc(cv, typeProg.apache));
            addOutput(ManZampLib.getStatusProc(cv, typeProg.mariadb));
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
            refreshStatusForm();
        }
        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            refreshStatusForm();
        }
        private void btnConsole_Click(object sender, EventArgs e)
        {
            openConsole();
        }
        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openConsole();
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
        private void showHostEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path_host_file = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");
                string contents = System.IO.File.ReadAllText(path_host_file);

                FormMsg frm_msg = new FormMsg(contents);
                frm_msg.ShowDialog(this);
                frm_msg.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void hostFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path_host_file = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");
            ManZampLib.startProc_as_admin(cv.default_editor_path, path_host_file);
        }
        private void wordpressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("function not available at the moment");
            return;
            
            if (!ManZampLib.checkRunningProc(cv.getPID_mariadb))
            {
                MessageBox.Show("MariaDB is not running");
                return;
            }

            FormOneClick_WP frm_wp = new FormOneClick_WP(cv);
            if (frm_wp.ShowDialog(this) == DialogResult.OK)
            {
                //cv = frm2.cv;
                //cv.updatePort();
                //cv.updateDefaultEditor(cv.default_editor_path);
            }

            frm_wp.Dispose();
        }
        private void reloadSitesFromVhostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> arrListSite = ManZampLib.getListSite(cv);
            crealinkSite(arrListSite);
        }
        private void ChangeVersStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManZampLib.checkRunningProc(cv.getPID_mariadb))
            {
                MessageBox.Show("Please close MariaDB");
                return;
            }
            if (ManZampLib.checkRunningProc(cv.getPID_apache))
            {
                MessageBox.Show("Please close Apache");
                return;
            }

            FormChangeVers frm2 = new FormChangeVers(cv);
            DialogResult dr = frm2.ShowDialog(this);
            cv = new ConfigVar();
            cv.get_software_version();
            refreshStatusForm();
            frm2.Close();
        }
        #endregion

        #region private method
        private void openConsole()
        {
            string apache_dir_bin = System.IO.Path.Combine(cv.pathApache, "bin");
            string mariadb_dir_bin = System.IO.Path.Combine(cv.MariaDB_path_scelto, "bin");
            string composer_path = System.IO.Path.Combine(cv.pathBase, "Apps", "composer");
            //string node_path = System.IO.Path.Combine(cv.pathBase, "Apps", "node-x64");
            //string sass_path = System.IO.Path.Combine(cv.pathBase, "Apps", "dart-sass");

            string drive_letter = System.IO.Path.GetPathRoot(cv.pathBase).Substring(0, 1);
            //MessageBox.Show(drive_letter);

            //ManZampLib.ExecuteBatchFile_dont_wait(System.IO.Path.Combine(cv.pathBase, "scripts", "open_console.bat"),
            //        new string[] { apache_dir_bin, cv.pathPHP, mariadb_dir_bin, composer_path, node_path, sass_path, drive_letter, cv.pathBase }
            //);

            ManZampLib.ExecuteBatchFile_dont_wait(System.IO.Path.Combine(cv.pathBase, "scripts", "open_console.bat"),
                    new string[] { apache_dir_bin, cv.PHP_path_scelto, mariadb_dir_bin, composer_path, drive_letter, cv.pathBase }
            );
        }
        private void refreshStatusForm()
        {
            lbVersion.Text = "Env: " + cv._env;
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

            lbApache_ver.Text = cv.apache_vers;
            lbPHP_ver.Text = cv.php_vers;
            lbMariaDB_ver.Text = cv.mariadb_vers;
            lbComposer_ver.Text = cv.composer_vers;
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
                ManZampLib.killproc_byName(nameproc); //kill in any case 

                //DialogResult dialogResult = MessageBox.Show(friendly_name + " running from another program ? Do you want to kill every " + friendly_name + " process ?", friendly_name + " running", MessageBoxButtons.YesNo);
                //if (dialogResult == DialogResult.Yes)
                //{
                //    //do something
                //    ManZampLib.killproc_byName(nameproc);
                //}
                //else if (dialogResult == DialogResult.No)
                //{
                //    //do something else
                //    return;
                //}
            }
        }
        private void crealinkSite(List<string> arrListSite)
        {
            this.sitesToolStripMenuItem.DropDownItems.Clear();

            for (int i = 0; i < arrListSite.Count; i++)
            {
                string slink = arrListSite[i].Trim();
                
                if (i > 0 && slink.StartsWith("https:") && arrListSite[i-1].StartsWith("http:"))
                {
                    ToolStripSeparator sep = new System.Windows.Forms.ToolStripSeparator();
                    this.toolStripSeparator7.Name = "separator_sl" + i;
                    this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { sep });
                }

                System.Windows.Forms.ToolStripMenuItem toolstr = new System.Windows.Forms.ToolStripMenuItem();
                toolstr.Name = "toolstripitem_sites" + i;
                toolstr.Text = slink;
                toolstr.Click += new EventHandler(delegate (object s, EventArgs ev)
                {
                    System.Diagnostics.Process.Start(slink);
                }); ;
                this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolstr });
            }


        }



        #endregion

        
    }
}

namespace ManZamp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtOut = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAllProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apacheHttpdconfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apacheHttpdvhostsconfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phpiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mariadbIniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBaseFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.backupRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apacheHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phpinfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mariaDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phpMyAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartStopApache = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartStopMariaDB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsole = new System.Windows.Forms.Button();
            this.pictureBoxMariaDB = new System.Windows.Forms.PictureBox();
            this.pictureBoxApache = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_baseFolder = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbMariaDB_ver = new System.Windows.Forms.Label();
            this.lbPHP_ver = new System.Windows.Forms.Label();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMariaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApache)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOut
            // 
            this.txtOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOut.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(12, 195);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOut.Size = new System.Drawing.Size(600, 211);
            this.txtOut.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem,
            this.editToolStripMenuItem,
            this.browserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkStatusToolStripMenuItem,
            this.stopAllProgrammToolStripMenuItem,
            this.runAllProgramToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.operationToolStripMenuItem.Text = "Server";
            // 
            // checkStatusToolStripMenuItem
            // 
            this.checkStatusToolStripMenuItem.Name = "checkStatusToolStripMenuItem";
            this.checkStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkStatusToolStripMenuItem.Text = "Check status";
            this.checkStatusToolStripMenuItem.Click += new System.EventHandler(this.checkStatusToolStripMenuItem_Click);
            // 
            // stopAllProgrammToolStripMenuItem
            // 
            this.stopAllProgrammToolStripMenuItem.Name = "stopAllProgrammToolStripMenuItem";
            this.stopAllProgrammToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopAllProgrammToolStripMenuItem.Text = "Stop All";
            this.stopAllProgrammToolStripMenuItem.Click += new System.EventHandler(this.stopAllProgrammToolStripMenuItem_Click);
            // 
            // runAllProgramToolStripMenuItem
            // 
            this.runAllProgramToolStripMenuItem.Name = "runAllProgramToolStripMenuItem";
            this.runAllProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runAllProgramToolStripMenuItem.Text = "Run All";
            this.runAllProgramToolStripMenuItem.Click += new System.EventHandler(this.runAllProgramToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesConfigToolStripMenuItem,
            this.changeBaseFolderToolStripMenuItem,
            this.toolStripSeparator2,
            this.backupRestoreToolStripMenuItem,
            this.toolStripSeparator3,
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // filesConfigToolStripMenuItem
            // 
            this.filesConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apacheHttpdconfToolStripMenuItem,
            this.apacheHttpdvhostsconfToolStripMenuItem,
            this.phpiniToolStripMenuItem,
            this.mariadbIniToolStripMenuItem});
            this.filesConfigToolStripMenuItem.Name = "filesConfigToolStripMenuItem";
            this.filesConfigToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filesConfigToolStripMenuItem.Text = "Edit config";
            // 
            // apacheHttpdconfToolStripMenuItem
            // 
            this.apacheHttpdconfToolStripMenuItem.Name = "apacheHttpdconfToolStripMenuItem";
            this.apacheHttpdconfToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.apacheHttpdconfToolStripMenuItem.Text = "apache httpd.conf";
            this.apacheHttpdconfToolStripMenuItem.Click += new System.EventHandler(this.changeConfig_ToolStripMenuItem_Click);
            // 
            // apacheHttpdvhostsconfToolStripMenuItem
            // 
            this.apacheHttpdvhostsconfToolStripMenuItem.Name = "apacheHttpdvhostsconfToolStripMenuItem";
            this.apacheHttpdvhostsconfToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.apacheHttpdvhostsconfToolStripMenuItem.Text = "apache httpd-vhosts.conf";
            this.apacheHttpdvhostsconfToolStripMenuItem.Click += new System.EventHandler(this.changeConfig_ToolStripMenuItem_Click);
            // 
            // phpiniToolStripMenuItem
            // 
            this.phpiniToolStripMenuItem.Name = "phpiniToolStripMenuItem";
            this.phpiniToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.phpiniToolStripMenuItem.Text = "php ini";
            this.phpiniToolStripMenuItem.Click += new System.EventHandler(this.changeConfig_ToolStripMenuItem_Click);
            // 
            // mariadbIniToolStripMenuItem
            // 
            this.mariadbIniToolStripMenuItem.Name = "mariadbIniToolStripMenuItem";
            this.mariadbIniToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mariadbIniToolStripMenuItem.Text = "mariadb ini";
            this.mariadbIniToolStripMenuItem.Click += new System.EventHandler(this.changeConfig_ToolStripMenuItem_Click);
            // 
            // changeBaseFolderToolStripMenuItem
            // 
            this.changeBaseFolderToolStripMenuItem.Name = "changeBaseFolderToolStripMenuItem";
            this.changeBaseFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeBaseFolderToolStripMenuItem.Text = "Change Base Folder";
            this.changeBaseFolderToolStripMenuItem.Click += new System.EventHandler(this.changeBaseFolderToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // backupRestoreToolStripMenuItem
            // 
            this.backupRestoreToolStripMenuItem.Name = "backupRestoreToolStripMenuItem";
            this.backupRestoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backupRestoreToolStripMenuItem.Text = "Backup - Restore";
            this.backupRestoreToolStripMenuItem.Click += new System.EventHandler(this.backupRestoreToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apacheHomeToolStripMenuItem,
            this.mariaDBToolStripMenuItem});
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.browserToolStripMenuItem.Text = "Link";
            // 
            // apacheHomeToolStripMenuItem
            // 
            this.apacheHomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phpinfoToolStripMenuItem});
            this.apacheHomeToolStripMenuItem.Name = "apacheHomeToolStripMenuItem";
            this.apacheHomeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apacheHomeToolStripMenuItem.Text = "Apache";
            // 
            // phpinfoToolStripMenuItem
            // 
            this.phpinfoToolStripMenuItem.Name = "phpinfoToolStripMenuItem";
            this.phpinfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phpinfoToolStripMenuItem.Text = "phpinfo";
            this.phpinfoToolStripMenuItem.Click += new System.EventHandler(this.phpinfoToolStripMenuItem_Click);
            // 
            // mariaDBToolStripMenuItem
            // 
            this.mariaDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phpMyAdminToolStripMenuItem,
            this.adminerToolStripMenuItem});
            this.mariaDBToolStripMenuItem.Name = "mariaDBToolStripMenuItem";
            this.mariaDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mariaDBToolStripMenuItem.Text = "MariaDB ";
            // 
            // phpMyAdminToolStripMenuItem
            // 
            this.phpMyAdminToolStripMenuItem.Name = "phpMyAdminToolStripMenuItem";
            this.phpMyAdminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phpMyAdminToolStripMenuItem.Text = "phpMyAdmin";
            this.phpMyAdminToolStripMenuItem.Click += new System.EventHandler(this.phpMyAdminToolStripMenuItem_Click);
            // 
            // adminerToolStripMenuItem
            // 
            this.adminerToolStripMenuItem.Name = "adminerToolStripMenuItem";
            this.adminerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminerToolStripMenuItem.Text = "adminer";
            this.adminerToolStripMenuItem.Click += new System.EventHandler(this.adminerToolStripMenuItem_Click);
            // 
            // btnStartStopApache
            // 
            this.btnStartStopApache.Location = new System.Drawing.Point(112, 17);
            this.btnStartStopApache.Name = "btnStartStopApache";
            this.btnStartStopApache.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopApache.TabIndex = 4;
            this.btnStartStopApache.Text = "Start";
            this.btnStartStopApache.UseVisualStyleBackColor = true;
            this.btnStartStopApache.Click += new System.EventHandler(this.btnStartStopApache_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apache";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "MariaDB";
            // 
            // btnStartStopMariaDB
            // 
            this.btnStartStopMariaDB.Location = new System.Drawing.Point(112, 53);
            this.btnStartStopMariaDB.Name = "btnStartStopMariaDB";
            this.btnStartStopMariaDB.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopMariaDB.TabIndex = 8;
            this.btnStartStopMariaDB.Text = "Start";
            this.btnStartStopMariaDB.UseVisualStyleBackColor = true;
            this.btnStartStopMariaDB.Click += new System.EventHandler(this.btnStartStopMariaDB_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnConsole);
            this.panel1.Controls.Add(this.pictureBoxMariaDB);
            this.panel1.Controls.Add(this.btnStartStopMariaDB);
            this.panel1.Controls.Add(this.pictureBoxApache);
            this.panel1.Controls.Add(this.btnStartStopApache);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(407, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 133);
            this.panel1.TabIndex = 11;
            // 
            // btnConsole
            // 
            this.btnConsole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsole.Location = new System.Drawing.Point(112, 98);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(75, 23);
            this.btnConsole.TabIndex = 14;
            this.btnConsole.Text = "Console";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // pictureBoxMariaDB
            // 
            this.pictureBoxMariaDB.Location = new System.Drawing.Point(19, 53);
            this.pictureBoxMariaDB.Name = "pictureBoxMariaDB";
            this.pictureBoxMariaDB.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxMariaDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMariaDB.TabIndex = 13;
            this.pictureBoxMariaDB.TabStop = false;
            // 
            // pictureBoxApache
            // 
            this.pictureBoxApache.Location = new System.Drawing.Point(19, 17);
            this.pictureBoxApache.Name = "pictureBoxApache";
            this.pictureBoxApache.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxApache.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxApache.TabIndex = 12;
            this.pictureBoxApache.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lb_baseFolder);
            this.panel2.Controls.Add(this.lbVersion);
            this.panel2.Controls.Add(this.lbMariaDB_ver);
            this.panel2.Controls.Add(this.lbPHP_ver);
            this.panel2.Location = new System.Drawing.Point(15, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 132);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::ManZamp.Properties.Resources.mariadb_icona;
            this.pictureBox2.Location = new System.Drawing.Point(7, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ManZamp.Properties.Resources.php_icona;
            this.pictureBox1.Location = new System.Drawing.Point(3, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lb_baseFolder
            // 
            this.lb_baseFolder.AutoSize = true;
            this.lb_baseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_baseFolder.Location = new System.Drawing.Point(4, 37);
            this.lb_baseFolder.Name = "lb_baseFolder";
            this.lb_baseFolder.Size = new System.Drawing.Size(49, 15);
            this.lb_baseFolder.TabIndex = 3;
            this.lb_baseFolder.Text = "label4";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbVersion.Location = new System.Drawing.Point(4, 16);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(49, 15);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "label4";
            // 
            // lbMariaDB_ver
            // 
            this.lbMariaDB_ver.AutoSize = true;
            this.lbMariaDB_ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbMariaDB_ver.Location = new System.Drawing.Point(59, 70);
            this.lbMariaDB_ver.Name = "lbMariaDB_ver";
            this.lbMariaDB_ver.Size = new System.Drawing.Size(105, 15);
            this.lbMariaDB_ver.TabIndex = 1;
            this.lbMariaDB_ver.Text = "MariaDB Vers: ";
            // 
            // lbPHP_ver
            // 
            this.lbPHP_ver.AutoSize = true;
            this.lbPHP_ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPHP_ver.Location = new System.Drawing.Point(55, 105);
            this.lbPHP_ver.Name = "lbPHP_ver";
            this.lbPHP_ver.Size = new System.Drawing.Size(77, 15);
            this.lbPHP_ver.TabIndex = 0;
            this.lbPHP_ver.Text = "PHP Vers: ";
            // 
            // timer_refresh
            // 
            this.timer_refresh.Enabled = true;
            this.timer_refresh.Interval = 2000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtOut);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 457);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManZAMP - beta";
            this.Load += new System.EventHandler(this.FrmManZAMP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMariaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApache)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllProgrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAllProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBaseFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem filesConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apacheHttpdconfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apacheHttpdvhostsconfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phpiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mariadbIniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnStartStopApache;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartStopMariaDB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxApache;
        private System.Windows.Forms.PictureBox pictureBoxMariaDB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMariaDB_ver;
        private System.Windows.Forms.Label lbPHP_ver;
        private System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apacheHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phpinfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mariaDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phpMyAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminerToolStripMenuItem;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lb_baseFolder;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


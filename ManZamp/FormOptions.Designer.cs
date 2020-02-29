namespace ManZamp
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathEditor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_http = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_https = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_mariadb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_http)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_https)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mariadb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Editor (Insert full path)";
            // 
            // txtPathEditor
            // 
            this.txtPathEditor.Location = new System.Drawing.Point(15, 27);
            this.txtPathEditor.Name = "txtPathEditor";
            this.txtPathEditor.Size = new System.Drawing.Size(632, 21);
            this.txtPathEditor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apache http port";
            // 
            // numericUpDown_http
            // 
            this.numericUpDown_http.Location = new System.Drawing.Point(15, 74);
            this.numericUpDown_http.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_http.Name = "numericUpDown_http";
            this.numericUpDown_http.Size = new System.Drawing.Size(114, 21);
            this.numericUpDown_http.TabIndex = 4;
            this.numericUpDown_http.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_https
            // 
            this.numericUpDown_https.Location = new System.Drawing.Point(137, 74);
            this.numericUpDown_https.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_https.Name = "numericUpDown_https";
            this.numericUpDown_https.Size = new System.Drawing.Size(121, 21);
            this.numericUpDown_https.TabIndex = 6;
            this.numericUpDown_https.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apache https port";
            // 
            // numericUpDown_mariadb
            // 
            this.numericUpDown_mariadb.Location = new System.Drawing.Point(266, 74);
            this.numericUpDown_mariadb.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown_mariadb.Name = "numericUpDown_mariadb";
            this.numericUpDown_mariadb.Size = new System.Drawing.Size(121, 21);
            this.numericUpDown_mariadb.TabIndex = 8;
            this.numericUpDown_mariadb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "MariaDB port";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(409, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(531, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 116);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericUpDown_mariadb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_https);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_http);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathEditor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(685, 155);
            this.MinimumSize = new System.Drawing.Size(685, 155);
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOptions";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_http)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_https)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mariadb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathEditor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_http;
        private System.Windows.Forms.NumericUpDown numericUpDown_https;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_mariadb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
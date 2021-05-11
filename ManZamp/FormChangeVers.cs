using ManLib.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManZamp
{
    public partial class FormChangeVers : Form
    {
        public ConfigVar cv;

        public FormChangeVers(ConfigVar cv)
        {
            InitializeComponent();
            this.cv = cv;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

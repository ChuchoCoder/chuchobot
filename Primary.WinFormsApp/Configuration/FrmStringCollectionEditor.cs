using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp.Configuration
{
    public partial class FrmStringCollectionEditor : Form
    {
        public StringCollection Setting { get; set; }

        public FrmStringCollectionEditor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var settings = txtSetting.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Setting.Clear();
            Setting.AddRange(settings);
            Properties.Settings.Default.Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmStringCollectionEditor_Load(object sender, EventArgs e)
        {
            foreach (var item in Setting.Cast<string>().OrderBy(x => x))
            {
                txtSetting.Text += item + Environment.NewLine;
            }
            txtSetting.SelectionStart = 0;
            txtSetting.SelectionLength = 0;
        }
    }
}

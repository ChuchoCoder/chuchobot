using System;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    internal class FormBase : Form
    {
        public FormBase()
        {
            Load += FormBase_Load;
            FormClosed += FormBase_FormClosed;
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            Telemetry.LogInformation($"Form Open {GetType().Name} {Text}");
        }

        private void FormBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Telemetry.LogInformation($"Form Closed {GetType().Name} {Text}");
        }
    }
}

using System;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp;

public partial class FrmLogin : Form
{
    public string Password => txtPassword.Text;
    public string UserName => txtUserName.Text;
    public string BaseUrl => txtBaseUrl.Text;

    public FrmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        txtUserName.Text = string.Empty;
        txtPassword.Text = string.Empty;
        Close();
    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {
        txtBaseUrl.Text = Properties.Settings.Default.ApiBaseUrl;
        txtUserName.Text = Properties.Settings.Default.UserName;
        txtPassword.Text = Properties.Settings.Default.Password;

        if (txtUserName.Text.Length > 0)
        {
            ActiveControl = txtPassword;
            _ = txtPassword.Focus();
        }
    }
}

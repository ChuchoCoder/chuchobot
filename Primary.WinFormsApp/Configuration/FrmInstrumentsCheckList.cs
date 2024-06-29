using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp.Configuration;
public partial class FrmInstrumentsCheckList : Form
{

    public StringCollection Setting { get; set; }
    public Func<string[], bool> Validator { get; set; }

    public FrmInstrumentsCheckList()
    {
        InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var settings = instrumentCheckList1.SelectedItems.Cast<string>().ToArray();

        if (Validator == null || Validator(settings))
        {
            Setting.Clear();
            Setting.AddRange(settings);
            Properties.Settings.Default.Save();
            Close();
        }
        else
        {
            DialogResult = DialogResult.None;
        }
    }

    private void FrmInstrumentsCheckList_Load(object sender, EventArgs e)
    {
        instrumentCheckList1.LoadInstruments(Setting.Cast<string>());
    }
}

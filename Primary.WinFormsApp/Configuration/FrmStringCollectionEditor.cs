using System;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp.Configuration;

public partial class FrmStringCollectionEditor : Form
{
    public StringCollection Setting { get; set; }
    public Func<string[], bool> Validator { get; set; }

    public FrmStringCollectionEditor()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var settings = txtSetting.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();

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

    private void btnLoadFile_Click(object sender, EventArgs e)
    {
        // Crear una instancia de OpenFileDialog
        var openFileDialog = new OpenFileDialog
        {
            // Configurar el OpenFileDialog
            Filter = "Archivos CSV (*.csv)|*.csv",
            Title = "Selecciona un archivo CSV"
        };

        // Mostrar el cuadro de diálogo
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            var filePath = openFileDialog.FileName;

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                try
                {
                    // Leer el contenido del archivo CSV
                    var lines = File.ReadAllLines(filePath);
                    txtSetting.Text = "";
                    foreach (var line in lines)
                    {
                        txtSetting.Text += line + Environment.NewLine;
                    }
                    txtSetting.SelectionStart = 0;
                    txtSetting.SelectionLength = 0;
                }
                catch (IOException ex)
                {
                    _ = MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _ = MessageBox.Show("El archivo seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

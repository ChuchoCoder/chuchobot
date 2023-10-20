using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp.Configuration
{
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
            var settings = txtSetting.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (Validator == null || Validator(settings))
            {
                Setting.Clear();
                Setting.AddRange(settings);
                Properties.Settings.Default.Save();
                Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el OpenFileDialog
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            openFileDialog.Title = "Selecciona un archivo CSV";

            // Mostrar el cuadro de diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Verificar si el archivo existe
                if (File.Exists(filePath))
                {
                    try
                    {
                        // Leer el contenido del archivo CSV
                        string[] lines = File.ReadAllLines(filePath);
                        txtSetting.Text = "";
                        foreach (string line in lines)
                        {
                            txtSetting.Text += line + Environment.NewLine;
                        }
                        txtSetting.SelectionStart = 0;
                        txtSetting.SelectionLength = 0;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error al leer el archivo: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no existe.");
                }
            }
        }
    }
}

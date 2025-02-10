
namespace ChuchoBot.WinFormsApp.SettlementTerms
{
    partial class FrmCaucion
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaucion));
            numTNA = new System.Windows.Forms.NumericUpDown();
            numImporteBruto = new System.Windows.Forms.NumericUpDown();
            numDias = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            grpCaucion = new System.Windows.Forms.GroupBox();
            lblImporteNeto = new System.Windows.Forms.Label();
            lblMontoCaucion = new System.Windows.Forms.Label();
            lblGastosCaucion = new System.Windows.Forms.Label();
            lblDiasCaucion = new System.Windows.Forms.Label();
            lblIva = new System.Windows.Forms.Label();
            lblInteresNeto = new System.Windows.Forms.Label();
            lblGtoGtiaCaucion = new System.Windows.Forms.Label();
            lblInteresBruto = new System.Windows.Forms.Label();
            lblDerMerCaucion = new System.Windows.Forms.Label();
            lblArancelCaucion = new System.Windows.Forms.Label();
            numComisionColocadora = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            numComisionTomadora = new System.Windows.Forms.NumericUpDown();
            rdoCaucionColocadora = new System.Windows.Forms.RadioButton();
            rdoTomadora = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)numTNA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numImporteBruto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDias).BeginInit();
            grpCaucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numComisionColocadora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numComisionTomadora).BeginInit();
            SuspendLayout();
            // 
            // numTNA
            // 
            numTNA.DecimalPlaces = 2;
            numTNA.Location = new System.Drawing.Point(151, 58);
            numTNA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numTNA.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTNA.Name = "numTNA";
            numTNA.Size = new System.Drawing.Size(160, 27);
            numTNA.TabIndex = 1;
            numTNA.ThousandsSeparator = true;
            numTNA.Value = new decimal(new int[] { 86, 0, 0, 0 });
            numTNA.ValueChanged += numTNA_ValueChanged;
            // 
            // numImporteBruto
            // 
            numImporteBruto.Location = new System.Drawing.Point(151, 18);
            numImporteBruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numImporteBruto.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numImporteBruto.Name = "numImporteBruto";
            numImporteBruto.Size = new System.Drawing.Size(160, 27);
            numImporteBruto.TabIndex = 0;
            numImporteBruto.ThousandsSeparator = true;
            numImporteBruto.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            numImporteBruto.ValueChanged += numImporteBruto_ValueChanged;
            // 
            // numDias
            // 
            numDias.Location = new System.Drawing.Point(151, 98);
            numDias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numDias.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numDias.Name = "numDias";
            numDias.Size = new System.Drawing.Size(160, 27);
            numDias.TabIndex = 2;
            numDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numDias.ValueChanged += numDias_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 22);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 20);
            label1.TabIndex = 9;
            label1.Text = "Monto a caucionar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(56, 62);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Tasa (TNA):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(105, 102);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 20);
            label3.TabIndex = 5;
            label3.Text = "Dias";
            // 
            // grpCaucion
            // 
            grpCaucion.Controls.Add(lblImporteNeto);
            grpCaucion.Controls.Add(lblMontoCaucion);
            grpCaucion.Controls.Add(lblGastosCaucion);
            grpCaucion.Controls.Add(lblDiasCaucion);
            grpCaucion.Controls.Add(lblIva);
            grpCaucion.Controls.Add(lblInteresNeto);
            grpCaucion.Controls.Add(lblGtoGtiaCaucion);
            grpCaucion.Controls.Add(lblInteresBruto);
            grpCaucion.Controls.Add(lblDerMerCaucion);
            grpCaucion.Controls.Add(lblArancelCaucion);
            grpCaucion.Location = new System.Drawing.Point(15, 137);
            grpCaucion.Name = "grpCaucion";
            grpCaucion.Size = new System.Drawing.Size(773, 254);
            grpCaucion.TabIndex = 7;
            grpCaucion.TabStop = false;
            grpCaucion.Text = "Caucion";
            // 
            // lblImporteNeto
            // 
            lblImporteNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblImporteNeto.Location = new System.Drawing.Point(16, 120);
            lblImporteNeto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImporteNeto.Name = "lblImporteNeto";
            lblImporteNeto.Size = new System.Drawing.Size(340, 28);
            lblImporteNeto.TabIndex = 32;
            lblImporteNeto.Text = "Importe Neto:";
            // 
            // lblMontoCaucion
            // 
            lblMontoCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMontoCaucion.Location = new System.Drawing.Point(16, 77);
            lblMontoCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMontoCaucion.Name = "lblMontoCaucion";
            lblMontoCaucion.Size = new System.Drawing.Size(340, 28);
            lblMontoCaucion.TabIndex = 31;
            lblMontoCaucion.Text = "Importe a Caucionar:";
            // 
            // lblGastosCaucion
            // 
            lblGastosCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGastosCaucion.Location = new System.Drawing.Point(385, 197);
            lblGastosCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGastosCaucion.Name = "lblGastosCaucion";
            lblGastosCaucion.Size = new System.Drawing.Size(371, 28);
            lblGastosCaucion.TabIndex = 30;
            lblGastosCaucion.Text = "Total Gastos";
            // 
            // lblDiasCaucion
            // 
            lblDiasCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDiasCaucion.Location = new System.Drawing.Point(16, 34);
            lblDiasCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDiasCaucion.Name = "lblDiasCaucion";
            lblDiasCaucion.Size = new System.Drawing.Size(340, 28);
            lblDiasCaucion.TabIndex = 23;
            lblDiasCaucion.Text = "Dias Caucion:";
            // 
            // lblIva
            // 
            lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIva.Location = new System.Drawing.Point(385, 158);
            lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblIva.Name = "lblIva";
            lblIva.Size = new System.Drawing.Size(375, 28);
            lblIva.TabIndex = 28;
            lblIva.Text = "Iva";
            // 
            // lblInteresNeto
            // 
            lblInteresNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblInteresNeto.Location = new System.Drawing.Point(16, 197);
            lblInteresNeto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInteresNeto.Name = "lblInteresNeto";
            lblInteresNeto.Size = new System.Drawing.Size(340, 28);
            lblInteresNeto.TabIndex = 29;
            lblInteresNeto.Text = "Interes Neto";
            // 
            // lblGtoGtiaCaucion
            // 
            lblGtoGtiaCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGtoGtiaCaucion.Location = new System.Drawing.Point(385, 120);
            lblGtoGtiaCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGtoGtiaCaucion.Name = "lblGtoGtiaCaucion";
            lblGtoGtiaCaucion.Size = new System.Drawing.Size(375, 28);
            lblGtoGtiaCaucion.TabIndex = 27;
            lblGtoGtiaCaucion.Text = "Gto Gtia";
            // 
            // lblInteresBruto
            // 
            lblInteresBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblInteresBruto.Location = new System.Drawing.Point(16, 158);
            lblInteresBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInteresBruto.Name = "lblInteresBruto";
            lblInteresBruto.Size = new System.Drawing.Size(340, 28);
            lblInteresBruto.TabIndex = 24;
            lblInteresBruto.Text = "Interes Caucion:";
            // 
            // lblDerMerCaucion
            // 
            lblDerMerCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDerMerCaucion.Location = new System.Drawing.Point(385, 77);
            lblDerMerCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDerMerCaucion.Name = "lblDerMerCaucion";
            lblDerMerCaucion.Size = new System.Drawing.Size(375, 28);
            lblDerMerCaucion.TabIndex = 26;
            lblDerMerCaucion.Text = "Der Mer";
            // 
            // lblArancelCaucion
            // 
            lblArancelCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArancelCaucion.Location = new System.Drawing.Point(385, 34);
            lblArancelCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArancelCaucion.Name = "lblArancelCaucion";
            lblArancelCaucion.Size = new System.Drawing.Size(375, 28);
            lblArancelCaucion.TabIndex = 25;
            lblArancelCaucion.Text = "Arancel";
            // 
            // numComisionColocadora
            // 
            numComisionColocadora.DecimalPlaces = 3;
            numComisionColocadora.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numComisionColocadora.Location = new System.Drawing.Point(587, 58);
            numComisionColocadora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numComisionColocadora.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numComisionColocadora.Name = "numComisionColocadora";
            numComisionColocadora.Size = new System.Drawing.Size(109, 27);
            numComisionColocadora.TabIndex = 4;
            numComisionColocadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numComisionColocadora.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            numComisionColocadora.ValueChanged += numComisionColocadora_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(400, 62);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(198, 20);
            label4.TabIndex = 38;
            label4.Text = "Comision Colocadora (TNA):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(400, 22);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(189, 20);
            label5.TabIndex = 37;
            label5.Text = "Comision Tomadora (TNA):";
            // 
            // numComisionTomadora
            // 
            numComisionTomadora.DecimalPlaces = 3;
            numComisionTomadora.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numComisionTomadora.Location = new System.Drawing.Point(587, 18);
            numComisionTomadora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numComisionTomadora.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numComisionTomadora.Name = "numComisionTomadora";
            numComisionTomadora.Size = new System.Drawing.Size(109, 27);
            numComisionTomadora.TabIndex = 3;
            numComisionTomadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numComisionTomadora.Value = new decimal(new int[] { 25, 0, 0, 65536 });
            numComisionTomadora.ValueChanged += numComisionTomadora_ValueChanged;
            // 
            // rdoCaucionColocadora
            // 
            rdoCaucionColocadora.AutoSize = true;
            rdoCaucionColocadora.Checked = true;
            rdoCaucionColocadora.Location = new System.Drawing.Point(404, 103);
            rdoCaucionColocadora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rdoCaucionColocadora.Name = "rdoCaucionColocadora";
            rdoCaucionColocadora.Size = new System.Drawing.Size(107, 24);
            rdoCaucionColocadora.TabIndex = 5;
            rdoCaucionColocadora.TabStop = true;
            rdoCaucionColocadora.Text = "Colocadora";
            rdoCaucionColocadora.UseVisualStyleBackColor = true;
            rdoCaucionColocadora.CheckedChanged += rdoCaucionColocadora_CheckedChanged;
            // 
            // rdoTomadora
            // 
            rdoTomadora.AutoSize = true;
            rdoTomadora.Location = new System.Drawing.Point(544, 103);
            rdoTomadora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rdoTomadora.Name = "rdoTomadora";
            rdoTomadora.Size = new System.Drawing.Size(98, 24);
            rdoTomadora.TabIndex = 6;
            rdoTomadora.Text = "Tomadora";
            rdoTomadora.UseVisualStyleBackColor = true;
            rdoTomadora.CheckedChanged += rdoTomadora_CheckedChanged;
            // 
            // FrmCaucion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(817, 412);
            Controls.Add(rdoTomadora);
            Controls.Add(rdoCaucionColocadora);
            Controls.Add(numComisionColocadora);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(numComisionTomadora);
            Controls.Add(grpCaucion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numDias);
            Controls.Add(numImporteBruto);
            Controls.Add(numTNA);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmCaucion";
            Text = "Calculadora de Caución";
            Load += FrmCaucion_Load;
            ((System.ComponentModel.ISupportInitialize)numTNA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numImporteBruto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDias).EndInit();
            grpCaucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numComisionColocadora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numComisionTomadora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTNA;
        private System.Windows.Forms.NumericUpDown numImporteBruto;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpCaucion;
        private System.Windows.Forms.Label lblMontoCaucion;
        private System.Windows.Forms.Label lblGastosCaucion;
        private System.Windows.Forms.Label lblDiasCaucion;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblInteresNeto;
        private System.Windows.Forms.Label lblGtoGtiaCaucion;
        private System.Windows.Forms.Label lblInteresBruto;
        private System.Windows.Forms.Label lblDerMerCaucion;
        private System.Windows.Forms.Label lblArancelCaucion;
        private System.Windows.Forms.NumericUpDown numComisionColocadora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numComisionTomadora;
        private System.Windows.Forms.RadioButton rdoCaucionColocadora;
        private System.Windows.Forms.RadioButton rdoTomadora;
        private System.Windows.Forms.Label lblImporteNeto;
    }
}
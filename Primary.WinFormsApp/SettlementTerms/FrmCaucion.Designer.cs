
namespace Primary.WinFormsApp.SettlementTerms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaucion));
            this.numTNA = new System.Windows.Forms.NumericUpDown();
            this.numImporteBruto = new System.Windows.Forms.NumericUpDown();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCaucion = new System.Windows.Forms.GroupBox();
            this.lblImporteNeto = new System.Windows.Forms.Label();
            this.lblMontoCaucion = new System.Windows.Forms.Label();
            this.lblGastosCaucion = new System.Windows.Forms.Label();
            this.lblDiasCaucion = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblInteresNeto = new System.Windows.Forms.Label();
            this.lblGtoGtiaCaucion = new System.Windows.Forms.Label();
            this.lblInteresBruto = new System.Windows.Forms.Label();
            this.lblDerMerCaucion = new System.Windows.Forms.Label();
            this.lblArancelCaucion = new System.Windows.Forms.Label();
            this.numComisionColocadora = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numComisionTomadora = new System.Windows.Forms.NumericUpDown();
            this.rdoCaucionColocadora = new System.Windows.Forms.RadioButton();
            this.rdoTomadora = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numTNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImporteBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.grpCaucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionColocadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionTomadora)).BeginInit();
            this.SuspendLayout();
            // 
            // numTNA
            // 
            this.numTNA.DecimalPlaces = 2;
            this.numTNA.Location = new System.Drawing.Point(113, 38);
            this.numTNA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTNA.Name = "numTNA";
            this.numTNA.Size = new System.Drawing.Size(120, 20);
            this.numTNA.TabIndex = 1;
            this.numTNA.ThousandsSeparator = true;
            this.numTNA.Value = new decimal(new int[] {
            86,
            0,
            0,
            0});
            this.numTNA.ValueChanged += new System.EventHandler(this.numTNA_ValueChanged);
            // 
            // numImporteBruto
            // 
            this.numImporteBruto.Location = new System.Drawing.Point(113, 12);
            this.numImporteBruto.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numImporteBruto.Name = "numImporteBruto";
            this.numImporteBruto.Size = new System.Drawing.Size(120, 20);
            this.numImporteBruto.TabIndex = 0;
            this.numImporteBruto.ThousandsSeparator = true;
            this.numImporteBruto.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numImporteBruto.ValueChanged += new System.EventHandler(this.numImporteBruto_ValueChanged);
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(113, 64);
            this.numDias.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(120, 20);
            this.numDias.TabIndex = 2;
            this.numDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDias.ValueChanged += new System.EventHandler(this.numDias_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monto a caucionar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasa (TNA):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dias";
            // 
            // grpCaucion
            // 
            this.grpCaucion.Controls.Add(this.lblImporteNeto);
            this.grpCaucion.Controls.Add(this.lblMontoCaucion);
            this.grpCaucion.Controls.Add(this.lblGastosCaucion);
            this.grpCaucion.Controls.Add(this.lblDiasCaucion);
            this.grpCaucion.Controls.Add(this.lblIva);
            this.grpCaucion.Controls.Add(this.lblInteresNeto);
            this.grpCaucion.Controls.Add(this.lblGtoGtiaCaucion);
            this.grpCaucion.Controls.Add(this.lblInteresBruto);
            this.grpCaucion.Controls.Add(this.lblDerMerCaucion);
            this.grpCaucion.Controls.Add(this.lblArancelCaucion);
            this.grpCaucion.Location = new System.Drawing.Point(11, 89);
            this.grpCaucion.Margin = new System.Windows.Forms.Padding(2);
            this.grpCaucion.Name = "grpCaucion";
            this.grpCaucion.Padding = new System.Windows.Forms.Padding(2);
            this.grpCaucion.Size = new System.Drawing.Size(580, 165);
            this.grpCaucion.TabIndex = 7;
            this.grpCaucion.TabStop = false;
            this.grpCaucion.Text = "Caucion";
            // 
            // lblImporteNeto
            // 
            this.lblImporteNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteNeto.Location = new System.Drawing.Point(12, 78);
            this.lblImporteNeto.Name = "lblImporteNeto";
            this.lblImporteNeto.Size = new System.Drawing.Size(255, 18);
            this.lblImporteNeto.TabIndex = 32;
            this.lblImporteNeto.Text = "Importe Neto:";
            // 
            // lblMontoCaucion
            // 
            this.lblMontoCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCaucion.Location = new System.Drawing.Point(12, 50);
            this.lblMontoCaucion.Name = "lblMontoCaucion";
            this.lblMontoCaucion.Size = new System.Drawing.Size(255, 18);
            this.lblMontoCaucion.TabIndex = 31;
            this.lblMontoCaucion.Text = "Importe a Caucionar:";
            // 
            // lblGastosCaucion
            // 
            this.lblGastosCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosCaucion.Location = new System.Drawing.Point(289, 128);
            this.lblGastosCaucion.Name = "lblGastosCaucion";
            this.lblGastosCaucion.Size = new System.Drawing.Size(278, 18);
            this.lblGastosCaucion.TabIndex = 30;
            this.lblGastosCaucion.Text = "Total Gastos";
            // 
            // lblDiasCaucion
            // 
            this.lblDiasCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasCaucion.Location = new System.Drawing.Point(12, 22);
            this.lblDiasCaucion.Name = "lblDiasCaucion";
            this.lblDiasCaucion.Size = new System.Drawing.Size(255, 18);
            this.lblDiasCaucion.TabIndex = 23;
            this.lblDiasCaucion.Text = "Dias Caucion:";
            // 
            // lblIva
            // 
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(289, 103);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(281, 18);
            this.lblIva.TabIndex = 28;
            this.lblIva.Text = "Iva";
            // 
            // lblInteresNeto
            // 
            this.lblInteresNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteresNeto.Location = new System.Drawing.Point(12, 128);
            this.lblInteresNeto.Name = "lblInteresNeto";
            this.lblInteresNeto.Size = new System.Drawing.Size(255, 18);
            this.lblInteresNeto.TabIndex = 29;
            this.lblInteresNeto.Text = "Interes Neto";
            // 
            // lblGtoGtiaCaucion
            // 
            this.lblGtoGtiaCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGtoGtiaCaucion.Location = new System.Drawing.Point(289, 78);
            this.lblGtoGtiaCaucion.Name = "lblGtoGtiaCaucion";
            this.lblGtoGtiaCaucion.Size = new System.Drawing.Size(281, 18);
            this.lblGtoGtiaCaucion.TabIndex = 27;
            this.lblGtoGtiaCaucion.Text = "Gto Gtia";
            // 
            // lblInteresBruto
            // 
            this.lblInteresBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteresBruto.Location = new System.Drawing.Point(12, 103);
            this.lblInteresBruto.Name = "lblInteresBruto";
            this.lblInteresBruto.Size = new System.Drawing.Size(255, 18);
            this.lblInteresBruto.TabIndex = 24;
            this.lblInteresBruto.Text = "Interes Caucion:";
            // 
            // lblDerMerCaucion
            // 
            this.lblDerMerCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerMerCaucion.Location = new System.Drawing.Point(289, 50);
            this.lblDerMerCaucion.Name = "lblDerMerCaucion";
            this.lblDerMerCaucion.Size = new System.Drawing.Size(281, 18);
            this.lblDerMerCaucion.TabIndex = 26;
            this.lblDerMerCaucion.Text = "Der Mer";
            // 
            // lblArancelCaucion
            // 
            this.lblArancelCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArancelCaucion.Location = new System.Drawing.Point(289, 22);
            this.lblArancelCaucion.Name = "lblArancelCaucion";
            this.lblArancelCaucion.Size = new System.Drawing.Size(281, 18);
            this.lblArancelCaucion.TabIndex = 25;
            this.lblArancelCaucion.Text = "Arancel";
            // 
            // numComisionColocadora
            // 
            this.numComisionColocadora.DecimalPlaces = 3;
            this.numComisionColocadora.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numComisionColocadora.Location = new System.Drawing.Point(440, 38);
            this.numComisionColocadora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComisionColocadora.Name = "numComisionColocadora";
            this.numComisionColocadora.Size = new System.Drawing.Size(82, 20);
            this.numComisionColocadora.TabIndex = 4;
            this.numComisionColocadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComisionColocadora.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numComisionColocadora.ValueChanged += new System.EventHandler(this.numComisionColocadora_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Comision Colocadora (TNA):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Comision Tomadora (TNA):";
            // 
            // numComisionTomadora
            // 
            this.numComisionTomadora.DecimalPlaces = 3;
            this.numComisionTomadora.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numComisionTomadora.Location = new System.Drawing.Point(440, 12);
            this.numComisionTomadora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComisionTomadora.Name = "numComisionTomadora";
            this.numComisionTomadora.Size = new System.Drawing.Size(82, 20);
            this.numComisionTomadora.TabIndex = 3;
            this.numComisionTomadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComisionTomadora.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.numComisionTomadora.ValueChanged += new System.EventHandler(this.numComisionTomadora_ValueChanged);
            // 
            // rdoCaucionColocadora
            // 
            this.rdoCaucionColocadora.AutoSize = true;
            this.rdoCaucionColocadora.Checked = true;
            this.rdoCaucionColocadora.Location = new System.Drawing.Point(303, 67);
            this.rdoCaucionColocadora.Name = "rdoCaucionColocadora";
            this.rdoCaucionColocadora.Size = new System.Drawing.Size(79, 17);
            this.rdoCaucionColocadora.TabIndex = 5;
            this.rdoCaucionColocadora.TabStop = true;
            this.rdoCaucionColocadora.Text = "Colocadora";
            this.rdoCaucionColocadora.UseVisualStyleBackColor = true;
            this.rdoCaucionColocadora.CheckedChanged += new System.EventHandler(this.rdoCaucionColocadora_CheckedChanged);
            // 
            // rdoTomadora
            // 
            this.rdoTomadora.AutoSize = true;
            this.rdoTomadora.Location = new System.Drawing.Point(408, 67);
            this.rdoTomadora.Name = "rdoTomadora";
            this.rdoTomadora.Size = new System.Drawing.Size(73, 17);
            this.rdoTomadora.TabIndex = 6;
            this.rdoTomadora.Text = "Tomadora";
            this.rdoTomadora.UseVisualStyleBackColor = true;
            this.rdoTomadora.CheckedChanged += new System.EventHandler(this.rdoTomadora_CheckedChanged);
            // 
            // FrmCaucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 268);
            this.Controls.Add(this.rdoTomadora);
            this.Controls.Add(this.rdoCaucionColocadora);
            this.Controls.Add(this.numComisionColocadora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numComisionTomadora);
            this.Controls.Add(this.grpCaucion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDias);
            this.Controls.Add(this.numImporteBruto);
            this.Controls.Add(this.numTNA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCaucion";
            this.Text = "Calculadora de Caución";
            this.Load += new System.EventHandler(this.FrmCaucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImporteBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.grpCaucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numComisionColocadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionTomadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
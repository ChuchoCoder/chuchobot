namespace Primary.WinFormsApp.SettlementTerms
{
    partial class SettlementTermSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.numComisionColocadora = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numDiasLiq48H = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numDiasLiq24H = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numTasa = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numComision = new System.Windows.Forms.NumericUpDown();
            this.numComisionTomadora = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionColocadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasLiq48H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasLiq24H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionTomadora)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Comision Operación%:";
            // 
            // numComisionColocadora
            // 
            this.numComisionColocadora.DecimalPlaces = 3;
            this.numComisionColocadora.Location = new System.Drawing.Point(559, 26);
            this.numComisionColocadora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComisionColocadora.Name = "numComisionColocadora";
            this.numComisionColocadora.Size = new System.Drawing.Size(82, 20);
            this.numComisionColocadora.TabIndex = 35;
            this.numComisionColocadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComisionColocadora.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numComisionColocadora.ValueChanged += new System.EventHandler(this.numComisionColocadora_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Comision Colocadora (TNA):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Dias para Liq. 48H:";
            // 
            // numDiasLiq48H
            // 
            this.numDiasLiq48H.Location = new System.Drawing.Point(321, 26);
            this.numDiasLiq48H.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiasLiq48H.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numDiasLiq48H.Name = "numDiasLiq48H";
            this.numDiasLiq48H.Size = new System.Drawing.Size(82, 20);
            this.numDiasLiq48H.TabIndex = 32;
            this.numDiasLiq48H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiasLiq48H.ValueChanged += new System.EventHandler(this.numDiasLiq48H_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Dias para Liq. 24H: ";
            // 
            // numDiasLiq24H
            // 
            this.numDiasLiq24H.Location = new System.Drawing.Point(321, 0);
            this.numDiasLiq24H.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiasLiq24H.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numDiasLiq24H.Name = "numDiasLiq24H";
            this.numDiasLiq24H.Size = new System.Drawing.Size(82, 20);
            this.numDiasLiq24H.TabIndex = 30;
            this.numDiasLiq24H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiasLiq24H.ValueChanged += new System.EventHandler(this.numDiasLiq24H_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tasa Caucion%: ";
            // 
            // numTasa
            // 
            this.numTasa.DecimalPlaces = 2;
            this.numTasa.Location = new System.Drawing.Point(118, 0);
            this.numTasa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTasa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numTasa.Name = "numTasa";
            this.numTasa.Size = new System.Drawing.Size(82, 20);
            this.numTasa.TabIndex = 28;
            this.numTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTasa.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.numTasa.ValueChanged += new System.EventHandler(this.numTasa_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Comision Tomadora (TNA):";
            // 
            // numComision
            // 
            this.numComision.DecimalPlaces = 2;
            this.numComision.Location = new System.Drawing.Point(118, 26);
            this.numComision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComision.Name = "numComision";
            this.numComision.Size = new System.Drawing.Size(82, 20);
            this.numComision.TabIndex = 26;
            this.numComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComision.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numComision.ValueChanged += new System.EventHandler(this.numComision_ValueChanged);
            // 
            // numComisionTomadora
            // 
            this.numComisionTomadora.DecimalPlaces = 3;
            this.numComisionTomadora.Location = new System.Drawing.Point(559, 0);
            this.numComisionTomadora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComisionTomadora.Name = "numComisionTomadora";
            this.numComisionTomadora.Size = new System.Drawing.Size(82, 20);
            this.numComisionTomadora.TabIndex = 24;
            this.numComisionTomadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComisionTomadora.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.numComisionTomadora.ValueChanged += new System.EventHandler(this.numComisionTomadora_ValueChanged);
            // 
            // SettlementTermSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numComisionColocadora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numDiasLiq48H);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDiasLiq24H);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numComision);
            this.Controls.Add(this.numComisionTomadora);
            this.Name = "SettlementTermSettings";
            this.Size = new System.Drawing.Size(643, 48);
            this.Load += new System.EventHandler(this.SettlementTermSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numComisionColocadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasLiq48H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasLiq24H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionTomadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numComisionColocadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numDiasLiq48H;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDiasLiq24H;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numComision;
        private System.Windows.Forms.NumericUpDown numComisionTomadora;
    }
}

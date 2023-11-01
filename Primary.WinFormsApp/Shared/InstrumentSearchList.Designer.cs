namespace Primary.WinFormsApp.Shared
{
    partial class InstrumentSearchList
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
            this.chkOnlyCurrentPositions = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listInstrumentos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chkOnlyCurrentPositions
            // 
            this.chkOnlyCurrentPositions.AutoSize = true;
            this.chkOnlyCurrentPositions.Location = new System.Drawing.Point(0, 3);
            this.chkOnlyCurrentPositions.Name = "chkOnlyCurrentPositions";
            this.chkOnlyCurrentPositions.Size = new System.Drawing.Size(196, 17);
            this.chkOnlyCurrentPositions.TabIndex = 9;
            this.chkOnlyCurrentPositions.Text = "Mostrar sólo instrumentos en cartera";
            this.chkOnlyCurrentPositions.UseVisualStyleBackColor = true;
            this.chkOnlyCurrentPositions.CheckedChanged += new System.EventHandler(this.chkOnlyCurrentPositions_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(0, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(772, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listInstrumentos
            // 
            this.listInstrumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listInstrumentos.FormattingEnabled = true;
            this.listInstrumentos.Location = new System.Drawing.Point(0, 51);
            this.listInstrumentos.Name = "listInstrumentos";
            this.listInstrumentos.Size = new System.Drawing.Size(772, 446);
            this.listInstrumentos.TabIndex = 0;
            this.listInstrumentos.DoubleClick += new System.EventHandler(this.listInstrumentos_DoubleClick);
            // 
            // InstrumentSearchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listInstrumentos);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.chkOnlyCurrentPositions);
            this.Name = "InstrumentSearchList";
            this.Size = new System.Drawing.Size(772, 505);
            this.Load += new System.EventHandler(this.InstrumentSearchList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOnlyCurrentPositions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listInstrumentos;
    }
}

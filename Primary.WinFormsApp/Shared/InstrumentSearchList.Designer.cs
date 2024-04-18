namespace ChuchoBot.WinFormsApp.Shared
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
            chkOnlyCurrentPositions = new System.Windows.Forms.CheckBox();
            txtSearch = new System.Windows.Forms.TextBox();
            listInstrumentos = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // chkOnlyCurrentPositions
            // 
            chkOnlyCurrentPositions.AutoSize = true;
            chkOnlyCurrentPositions.Location = new System.Drawing.Point(0, 3);
            chkOnlyCurrentPositions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkOnlyCurrentPositions.Name = "chkOnlyCurrentPositions";
            chkOnlyCurrentPositions.Size = new System.Drawing.Size(220, 19);
            chkOnlyCurrentPositions.TabIndex = 9;
            chkOnlyCurrentPositions.Text = "Mostrar sólo instrumentos en cartera";
            chkOnlyCurrentPositions.UseVisualStyleBackColor = true;
            chkOnlyCurrentPositions.CheckedChanged += chkOnlyCurrentPositions_CheckedChanged;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSearch.Location = new System.Drawing.Point(0, 28);
            txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(747, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // listInstrumentos
            // 
            listInstrumentos.FormattingEnabled = true;
            listInstrumentos.ItemHeight = 15;
            listInstrumentos.Location = new System.Drawing.Point(0, 57);
            listInstrumentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listInstrumentos.Name = "listInstrumentos";
            listInstrumentos.Size = new System.Drawing.Size(747, 529);
            listInstrumentos.TabIndex = 0;
            listInstrumentos.DoubleClick += listInstrumentos_DoubleClick;
            // 
            // InstrumentSearchList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(listInstrumentos);
            Controls.Add(txtSearch);
            Controls.Add(chkOnlyCurrentPositions);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "InstrumentSearchList";
            Size = new System.Drawing.Size(747, 594);
            Load += InstrumentSearchList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox chkOnlyCurrentPositions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listInstrumentos;
    }
}

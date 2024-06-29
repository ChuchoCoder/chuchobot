namespace ChuchoBot.WinFormsApp.Shared;

partial class InstrumentCheckList
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
        cmbCfiCodes = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        lstInstrumentos = new System.Windows.Forms.ListBox();
        txtSearch = new System.Windows.Forms.TextBox();
        lstSelected = new System.Windows.Forms.ListBox();
        btnAdd = new System.Windows.Forms.Button();
        btnRemove = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // cmbCfiCodes
        // 
        cmbCfiCodes.FormattingEnabled = true;
        cmbCfiCodes.Location = new System.Drawing.Point(74, 3);
        cmbCfiCodes.Name = "cmbCfiCodes";
        cmbCfiCodes.Size = new System.Drawing.Size(277, 23);
        cmbCfiCodes.TabIndex = 1;
        cmbCfiCodes.SelectedIndexChanged += cmbCfiCodes_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(4, 6);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(61, 15);
        label1.TabIndex = 2;
        label1.Text = "Filtrar por:";
        // 
        // lstInstrumentos
        // 
        lstInstrumentos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lstInstrumentos.FormattingEnabled = true;
        lstInstrumentos.ItemHeight = 15;
        lstInstrumentos.Location = new System.Drawing.Point(4, 61);
        lstInstrumentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        lstInstrumentos.Name = "lstInstrumentos";
        lstInstrumentos.Size = new System.Drawing.Size(347, 319);
        lstInstrumentos.TabIndex = 3;
        // 
        // txtSearch
        // 
        txtSearch.Location = new System.Drawing.Point(4, 32);
        txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(347, 23);
        txtSearch.TabIndex = 4;
        // 
        // lstSelected
        // 
        lstSelected.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lstSelected.FormattingEnabled = true;
        lstSelected.ItemHeight = 15;
        lstSelected.Location = new System.Drawing.Point(408, 61);
        lstSelected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        lstSelected.Name = "lstSelected";
        lstSelected.Size = new System.Drawing.Size(347, 319);
        lstSelected.TabIndex = 5;
        // 
        // btnAdd
        // 
        btnAdd.Location = new System.Drawing.Point(358, 61);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(43, 23);
        btnAdd.TabIndex = 6;
        btnAdd.Text = ">";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnRemove
        // 
        btnRemove.Location = new System.Drawing.Point(358, 90);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new System.Drawing.Size(43, 23);
        btnRemove.TabIndex = 7;
        btnRemove.Text = "<";
        btnRemove.UseVisualStyleBackColor = true;
        // 
        // InstrumentCheckList
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(btnRemove);
        Controls.Add(btnAdd);
        Controls.Add(lstSelected);
        Controls.Add(lstInstrumentos);
        Controls.Add(txtSearch);
        Controls.Add(label1);
        Controls.Add(cmbCfiCodes);
        Name = "InstrumentCheckList";
        Size = new System.Drawing.Size(760, 389);
        Load += InstrumentCheckList_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.ComboBox cmbCfiCodes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lstInstrumentos;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.ListBox lstSelected;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnRemove;
}

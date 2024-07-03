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
        lstAvailable = new System.Windows.Forms.ListBox();
        txtSearch = new System.Windows.Forms.TextBox();
        lstSelected = new System.Windows.Forms.ListBox();
        btnAdd = new System.Windows.Forms.Button();
        btnRemove = new System.Windows.Forms.Button();
        btnAddAll = new System.Windows.Forms.Button();
        btnRemoveAll = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // cmbCfiCodes
        // 
        cmbCfiCodes.FormattingEnabled = true;
        cmbCfiCodes.Location = new System.Drawing.Point(85, 4);
        cmbCfiCodes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        cmbCfiCodes.Name = "cmbCfiCodes";
        cmbCfiCodes.Size = new System.Drawing.Size(316, 28);
        cmbCfiCodes.TabIndex = 1;
        cmbCfiCodes.SelectedIndexChanged += cmbCfiCodes_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(5, 8);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(77, 20);
        label1.TabIndex = 2;
        label1.Text = "Filtrar por:";
        // 
        // lstInstrumentos
        // 
        lstAvailable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lstAvailable.FormattingEnabled = true;
        lstAvailable.Location = new System.Drawing.Point(5, 81);
        lstAvailable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
        lstAvailable.Name = "lstInstrumentos";
        lstAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        lstAvailable.Size = new System.Drawing.Size(396, 424);
        lstAvailable.TabIndex = 3;
        // 
        // txtSearch
        // 
        txtSearch.Location = new System.Drawing.Point(5, 43);
        txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(396, 27);
        txtSearch.TabIndex = 4;
        // 
        // lstSelected
        // 
        lstSelected.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lstSelected.FormattingEnabled = true;
        lstSelected.Location = new System.Drawing.Point(466, 81);
        lstSelected.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
        lstSelected.Name = "lstSelected";
        lstSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        lstSelected.Size = new System.Drawing.Size(396, 424);
        lstSelected.TabIndex = 5;
        // 
        // btnAdd
        // 
        btnAdd.Location = new System.Drawing.Point(409, 81);
        btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(49, 31);
        btnAdd.TabIndex = 6;
        btnAdd.Text = ">";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnRemove
        // 
        btnRemove.Location = new System.Drawing.Point(409, 198);
        btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new System.Drawing.Size(49, 31);
        btnRemove.TabIndex = 7;
        btnRemove.Text = "<";
        btnRemove.UseVisualStyleBackColor = true;
        btnRemove.Click += btnRemove_Click;
        // 
        // btnAddAll
        // 
        btnAddAll.Location = new System.Drawing.Point(409, 120);
        btnAddAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnAddAll.Name = "btnAddAll";
        btnAddAll.Size = new System.Drawing.Size(49, 31);
        btnAddAll.TabIndex = 8;
        btnAddAll.Text = ">>";
        btnAddAll.UseVisualStyleBackColor = true;
        btnAddAll.Click += btnAddAll_Click;
        // 
        // btnRemoveAll
        // 
        btnRemoveAll.Location = new System.Drawing.Point(409, 159);
        btnRemoveAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnRemoveAll.Name = "btnRemoveAll";
        btnRemoveAll.Size = new System.Drawing.Size(49, 31);
        btnRemoveAll.TabIndex = 9;
        btnRemoveAll.Text = "<<";
        btnRemoveAll.UseVisualStyleBackColor = true;
        btnRemoveAll.Click += btnRemoveAll_Click;
        // 
        // InstrumentCheckList
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(btnRemoveAll);
        Controls.Add(btnAddAll);
        Controls.Add(btnRemove);
        Controls.Add(btnAdd);
        Controls.Add(lstSelected);
        Controls.Add(lstAvailable);
        Controls.Add(txtSearch);
        Controls.Add(label1);
        Controls.Add(cmbCfiCodes);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Name = "InstrumentCheckList";
        Size = new System.Drawing.Size(869, 519);
        Load += InstrumentCheckList_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.ComboBox cmbCfiCodes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lstAvailable;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.ListBox lstSelected;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnAddAll;
    private System.Windows.Forms.Button btnRemoveAll;
}

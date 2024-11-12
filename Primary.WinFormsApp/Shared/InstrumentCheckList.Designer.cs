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
        // lstAvailable
        // 
        lstAvailable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lstAvailable.FormattingEnabled = true;
        lstAvailable.ItemHeight = 15;
        lstAvailable.Location = new System.Drawing.Point(4, 61);
        lstAvailable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        lstAvailable.Name = "lstAvailable";
        lstAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        lstAvailable.Size = new System.Drawing.Size(347, 319);
        lstAvailable.TabIndex = 3;
        // 
        // txtSearch
        // 
        txtSearch.Location = new System.Drawing.Point(4, 32);
        txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(347, 23);
        txtSearch.TabIndex = 4;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // lstSelected
        // 
        lstSelected.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lstSelected.FormattingEnabled = true;
        lstSelected.ItemHeight = 15;
        lstSelected.Location = new System.Drawing.Point(408, 61);
        lstSelected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        lstSelected.Name = "lstSelected";
        lstSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
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
        btnRemove.Location = new System.Drawing.Point(358, 148);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new System.Drawing.Size(43, 23);
        btnRemove.TabIndex = 7;
        btnRemove.Text = "<";
        btnRemove.UseVisualStyleBackColor = true;
        btnRemove.Click += btnRemove_Click;
        // 
        // btnAddAll
        // 
        btnAddAll.Location = new System.Drawing.Point(358, 90);
        btnAddAll.Name = "btnAddAll";
        btnAddAll.Size = new System.Drawing.Size(43, 23);
        btnAddAll.TabIndex = 8;
        btnAddAll.Text = ">>";
        btnAddAll.UseVisualStyleBackColor = true;
        btnAddAll.Click += btnAddAll_Click;
        // 
        // btnRemoveAll
        // 
        btnRemoveAll.Location = new System.Drawing.Point(358, 119);
        btnRemoveAll.Name = "btnRemoveAll";
        btnRemoveAll.Size = new System.Drawing.Size(43, 23);
        btnRemoveAll.TabIndex = 9;
        btnRemoveAll.Text = "<<";
        btnRemoveAll.UseVisualStyleBackColor = true;
        btnRemoveAll.Click += btnRemoveAll_Click;
        // 
        // InstrumentCheckList
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
        Name = "InstrumentCheckList";
        Size = new System.Drawing.Size(760, 389);
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

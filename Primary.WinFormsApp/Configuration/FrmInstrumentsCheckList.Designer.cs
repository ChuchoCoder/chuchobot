namespace ChuchoBot.WinFormsApp.Configuration;

partial class FrmInstrumentsCheckList
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstrumentsCheckList));
        instrumentCheckList1 = new Shared.InstrumentCheckList();
        btnCancel = new System.Windows.Forms.Button();
        btnSave = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // instrumentCheckList1
        // 
        instrumentCheckList1.Location = new System.Drawing.Point(12, 12);
        instrumentCheckList1.Name = "instrumentCheckList1";
        instrumentCheckList1.SettlementsVisible = false;
        instrumentCheckList1.Size = new System.Drawing.Size(763, 531);
        instrumentCheckList1.TabIndex = 0;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btnCancel.Location = new System.Drawing.Point(653, 550);
        btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(115, 27);
        btnCancel.TabIndex = 4;
        btnCancel.Text = "Cancelar";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // btnSave
        // 
        btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
        btnSave.Location = new System.Drawing.Point(531, 550);
        btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(114, 27);
        btnSave.TabIndex = 3;
        btnSave.Text = "Aceptar";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // FrmInstrumentsCheckList
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(781, 589);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(instrumentCheckList1);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Name = "FrmInstrumentsCheckList";
        Text = "FrmInstrumentsCheckList";
        Load += FrmInstrumentsCheckList_Load;
        ResumeLayout(false);
    }

    #endregion

    private Shared.InstrumentCheckList instrumentCheckList1;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
}
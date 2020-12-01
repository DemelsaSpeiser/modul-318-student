namespace SwissTransportArbeit
{
  partial class TransportApp
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtVon = new System.Windows.Forms.TextBox();
      this.txtNach = new System.Windows.Forms.TextBox();
      this.lbxAusgabeVon = new System.Windows.Forms.ListBox();
      this.btnGo = new System.Windows.Forms.Button();
      this.lbxAusgabeNach = new System.Windows.Forms.ListBox();
      this.lbxZeitNach = new System.Windows.Forms.ListBox();
      this.lbxZeitVon = new System.Windows.Forms.ListBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(26, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Von";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 53);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(33, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Nach";
      // 
      // txtVon
      // 
      this.txtVon.AutoCompleteCustomSource.AddRange(new string[] {
            "Luzern"});
      this.txtVon.Location = new System.Drawing.Point(84, 12);
      this.txtVon.Name = "txtVon";
      this.txtVon.Size = new System.Drawing.Size(100, 20);
      this.txtVon.TabIndex = 1;
      // 
      // txtNach
      // 
      this.txtNach.AutoCompleteCustomSource.AddRange(new string[] {
            "Emmenbrücke"});
      this.txtNach.Location = new System.Drawing.Point(84, 50);
      this.txtNach.Name = "txtNach";
      this.txtNach.Size = new System.Drawing.Size(100, 20);
      this.txtNach.TabIndex = 2;
      // 
      // lbxAusgabeVon
      // 
      this.lbxAusgabeVon.FormattingEnabled = true;
      this.lbxAusgabeVon.Location = new System.Drawing.Point(142, 102);
      this.lbxAusgabeVon.Name = "lbxAusgabeVon";
      this.lbxAusgabeVon.Size = new System.Drawing.Size(130, 173);
      this.lbxAusgabeVon.TabIndex = 0;
      // 
      // btnGo
      // 
      this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnGo.Location = new System.Drawing.Point(245, 10);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 3;
      this.btnGo.Text = "Go";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
      // 
      // lbxAusgabeNach
      // 
      this.lbxAusgabeNach.FormattingEnabled = true;
      this.lbxAusgabeNach.Location = new System.Drawing.Point(526, 102);
      this.lbxAusgabeNach.Name = "lbxAusgabeNach";
      this.lbxAusgabeNach.Size = new System.Drawing.Size(120, 173);
      this.lbxAusgabeNach.TabIndex = 0;
      // 
      // lbxZeitNach
      // 
      this.lbxZeitNach.FormattingEnabled = true;
      this.lbxZeitNach.Location = new System.Drawing.Point(400, 102);
      this.lbxZeitNach.Name = "lbxZeitNach";
      this.lbxZeitNach.Size = new System.Drawing.Size(120, 173);
      this.lbxZeitNach.TabIndex = 0;
      // 
      // lbxZeitVon
      // 
      this.lbxZeitVon.FormattingEnabled = true;
      this.lbxZeitVon.Location = new System.Drawing.Point(16, 102);
      this.lbxZeitVon.Name = "lbxZeitVon";
      this.lbxZeitVon.Size = new System.Drawing.Size(120, 173);
      this.lbxZeitVon.TabIndex = 4;
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(245, 48);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 5;
      this.btnClear.Text = "Reset";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
      // 
      // TransportApp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.lbxZeitVon);
      this.Controls.Add(this.lbxZeitNach);
      this.Controls.Add(this.lbxAusgabeNach);
      this.Controls.Add(this.btnGo);
      this.Controls.Add(this.lbxAusgabeVon);
      this.Controls.Add(this.txtNach);
      this.Controls.Add(this.txtVon);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TransportApp";
      this.Text = "TransportApp";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtVon;
    private System.Windows.Forms.TextBox txtNach;
    private System.Windows.Forms.ListBox lbxAusgabeVon;
    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.ListBox lbxAusgabeNach;
    private System.Windows.Forms.ListBox lbxZeitNach;
    private System.Windows.Forms.ListBox lbxZeitVon;
    private System.Windows.Forms.Button btnClear;
  }
}
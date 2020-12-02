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
      this.lbxAusgabeVon = new System.Windows.Forms.ListBox();
      this.btnGo = new System.Windows.Forms.Button();
      this.lbxAusgabeNach = new System.Windows.Forms.ListBox();
      this.lbxZeitNach = new System.Windows.Forms.ListBox();
      this.lbxZeitVon = new System.Windows.Forms.ListBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.dtpDate = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.dtpTime = new System.Windows.Forms.DateTimePicker();
      this.btnJetzt = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.cbxVon = new System.Windows.Forms.ComboBox();
      this.cbxNach = new System.Windows.Forms.ComboBox();
      this.btnAddVon = new System.Windows.Forms.Button();
      this.btnAddNach = new System.Windows.Forms.Button();
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
      // lbxAusgabeVon
      // 
      this.lbxAusgabeVon.FormattingEnabled = true;
      this.lbxAusgabeVon.Location = new System.Drawing.Point(82, 176);
      this.lbxAusgabeVon.Name = "lbxAusgabeVon";
      this.lbxAusgabeVon.Size = new System.Drawing.Size(200, 147);
      this.lbxAusgabeVon.TabIndex = 99;
      this.lbxAusgabeVon.TabStop = false;
      // 
      // btnGo
      // 
      this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnGo.Location = new System.Drawing.Point(258, 97);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 8;
      this.btnGo.Text = "Go";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
      // 
      // lbxAusgabeNach
      // 
      this.lbxAusgabeNach.FormattingEnabled = true;
      this.lbxAusgabeNach.Location = new System.Drawing.Point(369, 176);
      this.lbxAusgabeNach.Name = "lbxAusgabeNach";
      this.lbxAusgabeNach.Size = new System.Drawing.Size(200, 147);
      this.lbxAusgabeNach.TabIndex = 99;
      this.lbxAusgabeNach.TabStop = false;
      // 
      // lbxZeitNach
      // 
      this.lbxZeitNach.FormattingEnabled = true;
      this.lbxZeitNach.Location = new System.Drawing.Point(303, 176);
      this.lbxZeitNach.Name = "lbxZeitNach";
      this.lbxZeitNach.Size = new System.Drawing.Size(60, 147);
      this.lbxZeitNach.TabIndex = 99;
      this.lbxZeitNach.TabStop = false;
      // 
      // lbxZeitVon
      // 
      this.lbxZeitVon.FormattingEnabled = true;
      this.lbxZeitVon.Location = new System.Drawing.Point(16, 176);
      this.lbxZeitVon.Name = "lbxZeitVon";
      this.lbxZeitVon.Size = new System.Drawing.Size(60, 147);
      this.lbxZeitVon.TabIndex = 99;
      this.lbxZeitVon.TabStop = false;
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(494, 97);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 9;
      this.btnClear.Text = "Reset";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
      // 
      // dtpDate
      // 
      this.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand;
      this.dtpDate.CustomFormat = "dd.MM.yyyy";
      this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpDate.Location = new System.Drawing.Point(369, 12);
      this.dtpDate.Name = "dtpDate";
      this.dtpDate.Size = new System.Drawing.Size(200, 20);
      this.dtpDate.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(313, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Datum";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(313, 53);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(25, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Zeit";
      // 
      // dtpTime
      // 
      this.dtpTime.CustomFormat = "HH:mm";
      this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpTime.Location = new System.Drawing.Point(369, 50);
      this.dtpTime.Name = "dtpTime";
      this.dtpTime.ShowUpDown = true;
      this.dtpTime.Size = new System.Drawing.Size(200, 20);
      this.dtpTime.TabIndex = 6;
      // 
      // btnJetzt
      // 
      this.btnJetzt.Location = new System.Drawing.Point(16, 97);
      this.btnJetzt.Name = "btnJetzt";
      this.btnJetzt.Size = new System.Drawing.Size(75, 23);
      this.btnJetzt.TabIndex = 7;
      this.btnJetzt.Text = "Jetzt";
      this.btnJetzt.UseVisualStyleBackColor = true;
      this.btnJetzt.Click += new System.EventHandler(this.BtnJetzt_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(26, 160);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(20, 13);
      this.label5.TabIndex = 100;
      this.label5.Text = "Ab";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(135, 157);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(41, 13);
      this.label6.TabIndex = 101;
      this.label6.Text = "Abfahrt";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(313, 157);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(20, 13);
      this.label7.TabIndex = 102;
      this.label7.Text = "An";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(441, 156);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(44, 13);
      this.label8.TabIndex = 103;
      this.label8.Text = "Ankunft";
      // 
      // cbxVon
      // 
      this.cbxVon.FormattingEnabled = true;
      this.cbxVon.Location = new System.Drawing.Point(82, 12);
      this.cbxVon.Name = "cbxVon";
      this.cbxVon.Size = new System.Drawing.Size(159, 21);
      this.cbxVon.TabIndex = 1;
      // 
      // cbxNach
      // 
      this.cbxNach.FormattingEnabled = true;
      this.cbxNach.Location = new System.Drawing.Point(82, 50);
      this.cbxNach.Name = "cbxNach";
      this.cbxNach.Size = new System.Drawing.Size(159, 21);
      this.cbxNach.TabIndex = 3;
      // 
      // btnAddVon
      // 
      this.btnAddVon.Location = new System.Drawing.Point(247, 10);
      this.btnAddVon.Name = "btnAddVon";
      this.btnAddVon.Size = new System.Drawing.Size(35, 23);
      this.btnAddVon.TabIndex = 2;
      this.btnAddVon.Text = "Add";
      this.btnAddVon.UseVisualStyleBackColor = true;
      this.btnAddVon.Click += new System.EventHandler(this.BtnAddVon_Click);
      // 
      // btnAddNach
      // 
      this.btnAddNach.Location = new System.Drawing.Point(247, 48);
      this.btnAddNach.Name = "btnAddNach";
      this.btnAddNach.Size = new System.Drawing.Size(35, 23);
      this.btnAddNach.TabIndex = 4;
      this.btnAddNach.Text = "Add";
      this.btnAddNach.UseVisualStyleBackColor = true;
      this.btnAddNach.Click += new System.EventHandler(this.BtnAddNach_Click);
      // 
      // TransportApp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(587, 343);
      this.Controls.Add(this.btnAddNach);
      this.Controls.Add(this.btnAddVon);
      this.Controls.Add(this.cbxNach);
      this.Controls.Add(this.cbxVon);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnJetzt);
      this.Controls.Add(this.dtpTime);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dtpDate);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.lbxZeitVon);
      this.Controls.Add(this.lbxZeitNach);
      this.Controls.Add(this.lbxAusgabeNach);
      this.Controls.Add(this.btnGo);
      this.Controls.Add(this.lbxAusgabeVon);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(603, 382);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(603, 382);
      this.Name = "TransportApp";
      this.ShowIcon = false;
      this.Text = "TransportApp";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ListBox lbxAusgabeVon;
    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.ListBox lbxAusgabeNach;
    private System.Windows.Forms.ListBox lbxZeitNach;
    private System.Windows.Forms.ListBox lbxZeitVon;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DateTimePicker dtpDate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dtpTime;
    private System.Windows.Forms.Button btnJetzt;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ComboBox cbxVon;
    private System.Windows.Forms.ComboBox cbxNach;
    private System.Windows.Forms.Button btnAddVon;
    private System.Windows.Forms.Button btnAddNach;
  }
}
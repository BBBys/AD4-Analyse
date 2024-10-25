namespace AnAD4lyse
{
  partial class AD4Main
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.BDatei = new System.Windows.Forms.ToolStripButton();
      this.bAnalyse = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bEnde = new System.Windows.Forms.ToolStripButton();
      this.ofdDatei = new System.Windows.Forms.OpenFileDialog();
      this.label1 = new System.Windows.Forms.Label();
      this.lStart = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.l2 = new System.Windows.Forms.Label();
      this.l3 = new System.Windows.Forms.Label();
      this.lDatei = new System.Windows.Forms.Label();
      this.l5 = new System.Windows.Forms.Label();
      this.l4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.l7 = new System.Windows.Forms.Label();
      this.l6 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.l9 = new System.Windows.Forms.Label();
      this.l8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.l11 = new System.Windows.Forms.Label();
      this.l10 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BDatei,
            this.bAnalyse,
            this.toolStripSeparator1,
            this.bEnde});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
      this.toolStrip1.Size = new System.Drawing.Size(391, 31);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // BDatei
      // 
      this.BDatei.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BDatei.Image = global::AnAD4lyse.Properties.Resources.file_yellow_open;
      this.BDatei.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BDatei.Name = "BDatei";
      this.BDatei.Size = new System.Drawing.Size(29, 24);
      this.BDatei.Text = "toolStripButton1";
      this.BDatei.ToolTipText = "Datei";
      this.BDatei.Click += new System.EventHandler(this.BDatei_Click);
      // 
      // bAnalyse
      // 
      this.bAnalyse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bAnalyse.Enabled = false;
      this.bAnalyse.Image = global::AnAD4lyse.Properties.Resources.align_text_center;
      this.bAnalyse.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.bAnalyse.Name = "bAnalyse";
      this.bAnalyse.Size = new System.Drawing.Size(29, 24);
      this.bAnalyse.Text = "toolStripButton1";
      this.bAnalyse.ToolTipText = "Analyse";
      this.bAnalyse.Click += new System.EventHandler(this.bAnalyse_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
      // 
      // bEnde
      // 
      this.bEnde.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bEnde.Image = global::AnAD4lyse.Properties.Resources.exit;
      this.bEnde.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.bEnde.Name = "bEnde";
      this.bEnde.Size = new System.Drawing.Size(29, 24);
      this.bEnde.Text = "toolStripButton1";
      this.bEnde.ToolTipText = "Ende";
      this.bEnde.Click += new System.EventHandler(this.bEnde_Click);
      // 
      // ofdDatei
      // 
      this.ofdDatei.DefaultExt = "*.AD4";
      this.ofdDatei.FileName = "openFileDialog1";
      this.ofdDatei.Filter = "Audi|*.AD4|alle|*.*";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(5, 64);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 27);
      this.label1.TabIndex = 1;
      this.label1.Text = "Start:";
      // 
      // lStart
      // 
      this.lStart.AutoSize = true;
      this.lStart.Location = new System.Drawing.Point(99, 64);
      this.lStart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lStart.Name = "lStart";
      this.lStart.Size = new System.Drawing.Size(26, 27);
      this.lStart.TabIndex = 2;
      this.lStart.Text = "?";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(5, 91);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 27);
      this.label2.TabIndex = 3;
      this.label2.Text = "2.:";
      // 
      // l2
      // 
      this.l2.AutoSize = true;
      this.l2.Location = new System.Drawing.Point(99, 91);
      this.l2.Name = "l2";
      this.l2.Size = new System.Drawing.Size(26, 27);
      this.l2.TabIndex = 4;
      this.l2.Text = "?";
      // 
      // l3
      // 
      this.l3.AutoSize = true;
      this.l3.Location = new System.Drawing.Point(99, 118);
      this.l3.Name = "l3";
      this.l3.Size = new System.Drawing.Size(26, 27);
      this.l3.TabIndex = 5;
      this.l3.Text = "?";
      // 
      // lDatei
      // 
      this.lDatei.AutoSize = true;
      this.lDatei.Location = new System.Drawing.Point(5, 27);
      this.lDatei.Name = "lDatei";
      this.lDatei.Size = new System.Drawing.Size(26, 27);
      this.lDatei.TabIndex = 6;
      this.lDatei.Text = "?";
      // 
      // l5
      // 
      this.l5.AutoSize = true;
      this.l5.Location = new System.Drawing.Point(99, 174);
      this.l5.Name = "l5";
      this.l5.Size = new System.Drawing.Size(26, 27);
      this.l5.TabIndex = 9;
      this.l5.Text = "?";
      // 
      // l4
      // 
      this.l4.AutoSize = true;
      this.l4.Location = new System.Drawing.Point(99, 147);
      this.l4.Name = "l4";
      this.l4.Size = new System.Drawing.Size(26, 27);
      this.l4.TabIndex = 8;
      this.l4.Text = "?";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(5, 147);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(54, 27);
      this.label5.TabIndex = 7;
      this.label5.Text = "3.:";
      // 
      // l7
      // 
      this.l7.AutoSize = true;
      this.l7.Location = new System.Drawing.Point(99, 225);
      this.l7.Name = "l7";
      this.l7.Size = new System.Drawing.Size(26, 27);
      this.l7.TabIndex = 12;
      this.l7.Text = "?";
      this.l7.Click += new System.EventHandler(this.label3_Click);
      // 
      // l6
      // 
      this.l6.AutoSize = true;
      this.l6.Location = new System.Drawing.Point(99, 198);
      this.l6.Name = "l6";
      this.l6.Size = new System.Drawing.Size(26, 27);
      this.l6.TabIndex = 11;
      this.l6.Text = "?";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(5, 198);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(54, 27);
      this.label6.TabIndex = 10;
      this.label6.Text = "4.:";
      // 
      // l9
      // 
      this.l9.AutoSize = true;
      this.l9.Location = new System.Drawing.Point(99, 285);
      this.l9.Name = "l9";
      this.l9.Size = new System.Drawing.Size(26, 27);
      this.l9.TabIndex = 15;
      this.l9.Text = "?";
      // 
      // l8
      // 
      this.l8.AutoSize = true;
      this.l8.Location = new System.Drawing.Point(99, 258);
      this.l8.Name = "l8";
      this.l8.Size = new System.Drawing.Size(26, 27);
      this.l8.TabIndex = 14;
      this.l8.Text = "?";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(5, 258);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(54, 27);
      this.label7.TabIndex = 13;
      this.label7.Text = "5.:";
      // 
      // l11
      // 
      this.l11.AutoSize = true;
      this.l11.Location = new System.Drawing.Point(99, 343);
      this.l11.Name = "l11";
      this.l11.Size = new System.Drawing.Size(26, 27);
      this.l11.TabIndex = 18;
      this.l11.Text = "?";
      // 
      // l10
      // 
      this.l10.AutoSize = true;
      this.l10.Location = new System.Drawing.Point(99, 316);
      this.l10.Name = "l10";
      this.l10.Size = new System.Drawing.Size(26, 27);
      this.l10.TabIndex = 17;
      this.l10.Text = "?";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(5, 316);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(54, 27);
      this.label10.TabIndex = 16;
      this.label10.Text = "6.:";
      // 
      // AD4Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(391, 387);
      this.Controls.Add(this.l11);
      this.Controls.Add(this.l10);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.l9);
      this.Controls.Add(this.l8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.l7);
      this.Controls.Add(this.l6);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.l5);
      this.Controls.Add(this.l4);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lDatei);
      this.Controls.Add(this.l3);
      this.Controls.Add(this.l2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lStart);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.toolStrip1);
      this.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "AD4Main";
      this.Text = "Form1";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton BDatei;
    private System.Windows.Forms.OpenFileDialog ofdDatei;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton bEnde;
    private System.Windows.Forms.ToolStripButton bAnalyse;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lStart;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label l2;
    private System.Windows.Forms.Label l3;
    private System.Windows.Forms.Label lDatei;
    private System.Windows.Forms.Label l5;
    private System.Windows.Forms.Label l4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label l7;
    private System.Windows.Forms.Label l6;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label l9;
    private System.Windows.Forms.Label l8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label l11;
    private System.Windows.Forms.Label l10;
    private System.Windows.Forms.Label label10;
  }
}


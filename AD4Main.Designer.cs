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
      this.lDatei = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tbBytes = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.tbShorts = new System.Windows.Forms.TextBox();
      this.toolStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
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
      this.toolStrip1.Size = new System.Drawing.Size(391, 27);
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
      // lDatei
      // 
      this.lDatei.AutoSize = true;
      this.lDatei.Location = new System.Drawing.Point(5, 27);
      this.lDatei.Name = "lDatei";
      this.lDatei.Size = new System.Drawing.Size(26, 27);
      this.lDatei.TabIndex = 6;
      this.lDatei.Text = "?";
      // 
      // groupBox1
      // 
      this.groupBox1.AutoSize = true;
      this.groupBox1.Controls.Add(this.tbBytes);
      this.groupBox1.Location = new System.Drawing.Point(10, 94);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(149, 278);
      this.groupBox1.TabIndex = 19;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Byte";
      // 
      // tbBytes
      // 
      this.tbBytes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbBytes.Location = new System.Drawing.Point(3, 30);
      this.tbBytes.Multiline = true;
      this.tbBytes.Name = "tbBytes";
      this.tbBytes.Size = new System.Drawing.Size(143, 245);
      this.tbBytes.TabIndex = 1;
      this.tbBytes.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
      // 
      // groupBox2
      // 
      this.groupBox2.AutoSize = true;
      this.groupBox2.Controls.Add(this.tbShorts);
      this.groupBox2.Location = new System.Drawing.Point(165, 94);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(149, 281);
      this.groupBox2.TabIndex = 20;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Short";
      // 
      // tbShorts
      // 
      this.tbShorts.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbShorts.Location = new System.Drawing.Point(3, 30);
      this.tbShorts.Multiline = true;
      this.tbShorts.Name = "tbShorts";
      this.tbShorts.Size = new System.Drawing.Size(143, 248);
      this.tbShorts.TabIndex = 1;
      this.tbShorts.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
      // 
      // AD4Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(391, 387);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lDatei);
      this.Controls.Add(this.lStart);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.toolStrip1);
      this.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "AD4Main";
      this.Text = "Form1";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
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
    private System.Windows.Forms.Label lDatei;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox tbBytes;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox tbShorts;
  }
}


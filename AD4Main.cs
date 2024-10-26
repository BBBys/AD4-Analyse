using System;
using System.IO;
using System.Windows.Forms;
namespace AnAD4lyse
{
  public partial class AD4Main : Form
  {
    private string Datei;
    private readonly char[] buff4 = new char[4];
    public AD4Main()
    {
      InitializeComponent();
      Text = Properties.Resources.Fenstertitel + " V" + Application.ProductVersion + ". ";
#if DEBUG
      Text += "DEBUGVERSION";
#else
      Text += Application.CompanyName + ": " + Application.ProductName;
#endif
    }

    private void BDatei_Click(object sender, EventArgs e)
    {
      if (ofdDatei.ShowDialog() == DialogResult.OK)
      {
        Datei = ofdDatei.FileName;
        bAnalyse.Enabled = true;
      }
    }

    private void bEnde_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void bAnalyse_Click(object sender, EventArgs e)
    {
      string bytes, shorts;
      FileInfo fileInfo;
      fileInfo = new FileInfo(Datei);
      using (StreamReader sr = new StreamReader(Datei, true))
      {
        int zeile = 0;
        string[] zBytes = tbBytes.Lines, zShorts = tbShorts.Lines;
        System.Text.Encoding encoding = sr.CurrentEncoding;
        lDatei.Text = $"{fileInfo.Name} {fileInfo.Length} Bytes {encoding}";
        _ = sr.Read(buff4, 0, 4);
        lStart.Text = new string(buff4);
        for (int i = 0; i < 14; i++)
        {
          _ = sr.Read(buff4, 0, 4);
          bytes = $"{(byte)buff4[0]:X2} {(byte)buff4[1]:X2} {(byte)buff4[2]:X2} {(byte)buff4[3]:X2}";
          zBytes[zeile] = bytes;
          shorts = $"{(buff4[0] << 8) | (byte)buff4[1]:D} {(buff4[2] << 8) | (byte)buff4[3]:D}";
          zShorts[zeile++] = shorts;
        }
        tbBytes.Lines = zBytes;
        tbShorts.Lines = zShorts;
      }
    }
  }
}

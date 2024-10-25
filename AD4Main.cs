using System;
using System.IO;
using System.Windows.Forms;

namespace AnAD4lyse
{
  public partial class AD4Main : Form
  {
    private string Datei;
    private readonly char[] buff4 = new char[4];
    private readonly string string4 = "....";

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
      FileInfo fileInfo;
      fileInfo = new FileInfo(Datei);
      lDatei.Text = $"{fileInfo.Name} {fileInfo.Length} Bytes vom {fileInfo.CreationTime}";
      using (StreamReader sr = new StreamReader(Datei))
      {
        _ = sr.Read(buff4, 0, 4);
        lStart.Text = new string(buff4);
        Auswerten4Bytes(sr, l2, l3);
        Auswerten4Bytes(sr, l4, l5);
        Auswerten4Bytes(sr, l6, l7);
        Auswerten4Bytes(sr, l8, l9);
        Auswerten4Bytes(sr, l10, l11);
      }
    }

    /// <summary>
    /// 4 Bytes lesen, formatiert ausgeben
    /// </summary>
    /// <param name="EinStream"></param>
    /// <param name="LabelA"></param>
    /// <param name="LabelB"></param>
    private void Auswerten4Bytes(StreamReader EinStream, Label LabelA, Label LabelB)
    {
      string StringB, StringA;
      (StringA, StringB) = LesenFormatieren(EinStream);
      LabelB.Text = StringB;
      LabelA.Text = StringA;
    }

    private (string, string) LesenFormatieren(StreamReader sr)
    {
      long i1, i2;
      string b16, b32;
      _ = sr.Read(buff4, 0, 4);
      //2. Block
      i1 = (buff4[0] << 16) + buff4[1];
      i2 = (buff4[2] << 16) + buff4[3];
      b32 = $"{i1:d7} {i2:d7} 0x{i1:X8} 0x{i2:X8}";
      b16 =
       $"{(int)buff4[0]:d6} {(int)buff4[1]:d6} {(int)buff4[2]:d6} {(int)buff4[3]:d6} " +
       $"0x{(int)buff4[0]:X4} 0x{(int)buff4[1]:X4} 0x{(int)buff4[2]:X4} 0x{(int)buff4[3]:X4}";
      return (b16, b32);
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
  }
}

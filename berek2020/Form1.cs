using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace berek2020
{
  public partial class Form1 : Form
  {
    List<adatok> berek = new List<adatok>();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      Beolvas();
      Masodikfeladat();
      Harmadikfeladat();
    }

    private void Harmadikfeladat()
    {
      
    }

    private void Masodikfeladat()
    {
      string ki = $"{berek.Count} fő";
      lbKimenet.Items.Add(ki);
    }

    private void Beolvas()
    {
     
        StreamReader be = new StreamReader("berek2020.txt");

        be.ReadLine();

        while (!be.EndOfStream)
        {
          string[] a = be.ReadLine().Split(';');

          berek.Add(new adatok(a[0],a[1],a[2],int.Parse(a[3]), int.Parse(a[4])));
        }

        be.Close();
      
    }
  }
}

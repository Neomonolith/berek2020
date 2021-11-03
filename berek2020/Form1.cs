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
      Negyedikfeladat();
      
    }

    private void Otodikfeladat()
    {
      string reszleg = tbBekeres.Text;
      //if (reszleg == " ")
      //{
      //  MessageBox.Show("Nem adtál meg adatot");
      //}

      
      //foreach (var b in berek)
      //{

      //  if (reszleg != b.Beszerzes)
      //  {
      //    MessageBox.Show("Nem létezik ilyen részleg!");
      //  }

      //}

    }

    private void Negyedikfeladat()
    {
      
      MessageBox.Show("Kérek egy részleg nevet:", "Adatbekérés", MessageBoxButtons.OK, MessageBoxIcon.Information);


      tbBekeres.Enabled = true;
      tbBekeres.Focus();
      Otodikfeladat();
    }

    private void Harmadikfeladat()
    {
      int ossz = 0;
      double atlag = 0;

      foreach (var b in berek)
      {
        ossz += b.Fizetes;
      }
        atlag = ossz / berek.Count / 1000;
        lbAtlag.Items.Add($"{atlag:N1}eFT");
    }

    private void Masodikfeladat()
    {
      string ki = $"{berek.Count} fő";
      lbKimenet.Items.Add(ki);

      foreach (var b in berek)
      {
        lbDolgozoklista.Items.Add(b.Nev);
        lbDolgozoklista.Items.Add(b.Neme);
        lbDolgozoklista.Items.Add(b.Beszerzes);
      }
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

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020
{
  class adatok
  {

    private string nev;

    public string Nev
    {
      get { return nev; }
      set { nev = value; }
    }

    private string neme;

    public string Neme
    {
      get { return neme; }
      set { neme = value; }
    }

    private string beszerzes;

    public string Beszerzes
    {
      get { return beszerzes; }
      set { beszerzes = value; }
    }

    private int ev;

    public int Ev
    {
      get { return ev; }
      set { ev = value; }
    }

    private int fizetes;

    public int Fizetes
    {
      get { return fizetes; }
      set { fizetes = value; }
    }

    public adatok(string nev, string neme, string beszerzes, int ev, int fizetes)
    {
      this.nev = nev;
      this.neme = neme;
      this.beszerzes = beszerzes;
      this.ev = ev;
      this.fizetes = fizetes;
    }
  }
}

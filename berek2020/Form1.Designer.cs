
namespace berek2020
{
  partial class Form1
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
      this.label1 = new System.Windows.Forms.Label();
      this.lbKimenet = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.lbAtlag = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbBekeres = new System.Windows.Forms.TextBox();
      this.lbDolgozoklista = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(34, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(88, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Dolgozók száma:";
      // 
      // lbKimenet
      // 
      this.lbKimenet.FormattingEnabled = true;
      this.lbKimenet.Location = new System.Drawing.Point(128, 32);
      this.lbKimenet.Name = "lbKimenet";
      this.lbKimenet.Size = new System.Drawing.Size(73, 17);
      this.lbKimenet.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(25, 218);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(123, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "4. Feladat: Bérek átlaga:";
      // 
      // lbAtlag
      // 
      this.lbAtlag.FormattingEnabled = true;
      this.lbAtlag.Location = new System.Drawing.Point(163, 214);
      this.lbAtlag.Name = "lbAtlag";
      this.lbAtlag.Size = new System.Drawing.Size(66, 17);
      this.lbAtlag.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(25, 252);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(115, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Kérem a részleg nevét:";
      // 
      // tbBekeres
      // 
      this.tbBekeres.Enabled = false;
      this.tbBekeres.Location = new System.Drawing.Point(163, 249);
      this.tbBekeres.Name = "tbBekeres";
      this.tbBekeres.Size = new System.Drawing.Size(100, 20);
      this.tbBekeres.TabIndex = 5;
      // 
      // lbDolgozoklista
      // 
      this.lbDolgozoklista.FormattingEnabled = true;
      this.lbDolgozoklista.Location = new System.Drawing.Point(230, 32);
      this.lbDolgozoklista.Name = "lbDolgozoklista";
      this.lbDolgozoklista.Size = new System.Drawing.Size(352, 160);
      this.lbDolgozoklista.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1017, 544);
      this.Controls.Add(this.lbDolgozoklista);
      this.Controls.Add(this.tbBekeres);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lbAtlag);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lbKimenet);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Bérek 2020";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lbKimenet;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox lbAtlag;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbBekeres;
    private System.Windows.Forms.ListBox lbDolgozoklista;
  }
}


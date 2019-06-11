using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickAnAlien
{
    public partial class Form1 : Form
    {
        Alien alien = new Alien();
        int score;
        Graphics g;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;// sets g to the Graphics object supplied in the PaintEventArgs
            alien.drawAlien(g); // draw the alien on the panel (pnlGame)

        }
    }
}

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
            alien.moveAlien();
            alien.collideWall();//check whether alien hits pnlGame's walls
        }

        private void tmrAlien_Tick(object sender, EventArgs e)
        {
            pnlGame.Invalidate();
        }

        private void pnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            int diffX = e.X - alien.alienRec.X;
            int diffY = e.Y - alien.alienRec.Y;
            double length = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            if (length < 70)
            {
                score++;//add 1 to the score
                lblScore.Text = score.ToString();// display the score
            }

        }
    }
}

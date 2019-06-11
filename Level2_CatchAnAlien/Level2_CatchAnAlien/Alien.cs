using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ClickAnAlien
{
    class Alien
    {
        //fields
        public int x, y, width, height, xSpeed, ySpeed;
        public Image alien;
        public Rectangle alienRec;
        Random rand = new Random();
        //Create a constructor (initialises the values of the fields)
        public Alien()
        {
            x = 0;
            y = 0;
            width = 50;
            height = 65;
            xSpeed = rand.Next(15, 20);
            ySpeed = rand.Next(15, 20);
          
            alien = Image.FromFile("alien.png");
            alienRec = new Rectangle(x, y, width, height);
        }
        public void drawAlien(Graphics g)
        {
            g.DrawImage(alien, alienRec);

        }
        public void moveAlien()
        {
            x += xSpeed;
            y += ySpeed;
            alienRec.Location = new Point(x, y);
        }
        public void collideWall()
        {
            // check for alien hitting left and right walls
            if (alienRec.X < 10 || alienRec.X > 235)
            {
                xSpeed *= -1; //change direction of alien
            }
            // check for alien hitting top and bottom of game area
            if (alienRec.Y < 10 || alienRec.Y > 230)
            {
                ySpeed *= -1;//change direction of alien
            }
        }


    }
}

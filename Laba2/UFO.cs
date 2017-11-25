using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class UFO : AIRvehical
    {
        private bool Far;
        private bool Antenna;
        private bool Hatch;
        private Color dopColor;
        


        public UFO(int maxSpeed, int maxCountPassenger,  double weight, Color color,
         bool Far,bool Antenna, bool Hatch,Color dopColor) :
        base(maxSpeed, maxCountPassenger, weight, color)
        {
            this.Far = Far;
            this.Antenna = Antenna;
            this.Hatch = Hatch;
            this.dopColor = dopColor;
        }
        protected override void drawBadUFO(Graphics g)
        {
            Brush brush = new HatchBrush(HatchStyle.Divot, Color.DodgerBlue);
            g.FillEllipse(brush, startPosX - 10, startPosY + 50, 200, 30);
            if (Far)
            {
                Pen penDOP = new Pen(dopColor, 10);
                g.DrawEllipse(penDOP, startPosX-5, startPosY+20, 10, 10);
                g.DrawEllipse(penDOP, startPosX+ 195, startPosY + 20, 10, 10);
                g.DrawEllipse(penDOP, startPosX + 90, startPosY + 45, 10, 10);
            }
            if (Antenna)
            {
                Pen penGreen = new Pen(Color.Green, 10);
                g.DrawLine(penGreen, startPosX + 95, startPosY, startPosX + 110, startPosY - 30);
                g.DrawEllipse(penGreen, startPosX + 105, startPosY - 35, 10, 10);
            }
            if(Hatch)
            {
                Brush brGreen = new SolidBrush(Color.Green);
                Brush brDOP = new SolidBrush(dopColor);
                g.FillEllipse(brGreen, startPosX + 40, startPosY - 20, 120, 50);
                g.FillEllipse(brDOP, startPosX + 50, startPosY - 10, 100, 30);
                
            }
            base.drawBadUFO(g);

          
        }


    }
}

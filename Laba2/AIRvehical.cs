using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class AIRvehical : Vehicle
    {
        private string info;

        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 2000)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 1000;
                }
            }
        }

        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }

            protected set
            {
                if (value > 0 && value < 4)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 3;
                }
            }
        }
        
        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {
                if (value > 50 && value < 200)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 150;
                }
            }
        }
        public AIRvehical(int maxSpeed, int maxCountPassengers, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassengers;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;

            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public AIRvehical(string info)
        {
            this.info = info;
        }

        public override void moveAIRvehical(Graphics g)
        {
            startPosX +=
                (MaxSpeed * 50 / (float)Weight) /
                    (countPassengers == 0 ? 1 : countPassengers);
            drawAIRvehical(g);
        }
        public override void drawAIRvehical(Graphics g)
        {
            drawBadUFO(g);
        }
        protected virtual void drawBadUFO(Graphics g)
        {
            //отрисовка плохой летающей тарелки
            Pen penBody = new Pen(ColorBody,10);
            Pen penRed = new Pen(Color.Red, 5);
            Brush brBlue = new SolidBrush(Color.Blue);
            g.FillEllipse(brBlue, startPosX, startPosY, 200, 50);
            g.DrawLine(penBody, startPosX + 60, startPosY + 45, startPosX + 40, startPosY + 75);
            g.DrawLine(penBody, startPosX + 130, startPosY + 45, startPosX + 150, startPosY + 75);
            g.DrawLine(penRed, startPosX , startPosY+25, startPosX +60, startPosY + 30);
            g.DrawLine(penRed,  startPosX + 60, startPosY + 30, startPosX+130, startPosY + 30);
            g.DrawLine(penRed, startPosX + 129, startPosY + 30, startPosX + 200, startPosY + 25);

        }
    }
}

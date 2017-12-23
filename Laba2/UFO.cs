using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class UFO : AIRvehical, IComparable<UFO>, IEquatable<UFO>
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

        public UFO (string info):base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length==8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
                Far = Convert.ToBoolean(strs[4]);
                Antenna = Convert.ToBoolean(strs[5]);
                Hatch = Convert.ToBoolean(strs[6]);
                dopColor = Color.FromName(strs[7]);
            }
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
        public void setDopColor (Color color)
        {
            dopColor = color;
        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + ColorBody.Name + ";" +
                Far + ";" + Antenna + ";" + Hatch + ";" + dopColor.Name;
        }

        //Чтобы не дублировать проверки параметров, унаследованных от базового класса, 
        //вызовем там функции CompareTo и Equals от базового класса. 
           // И добавим проверки по параметрам дочернего класса, которые будут проходит, если параметры базового класса идентичны. 
        public int CompareTo(UFO other)
        {
            var res = (this is AIRvehical).CompareTo(other is AIRvehical);
            if(res != 0)
            {
                return res;
            }
            if(Hatch != other.Hatch)
            {
                return Hatch.CompareTo(other.Hatch);
            }
            if(Antenna != other.Antenna)
            {
                return Antenna.CompareTo(other.Antenna);
            }
            if(Far != other.Far)
            {
                return Far.CompareTo(other.Far);
            }
            if(dopColor != other.dopColor)
            {
                return dopColor.Name.CompareTo(other.dopColor.Name);
            }
            return 0;
        }

        public bool Equals(UFO other)
        {
            var res = (this is AIRvehical).Equals(this is AIRvehical);
            if (!res)
            {
                return res;
            }
            if (Hatch != other.Hatch)
            {
                return false;
            }
            if (Antenna != other.Antenna)
            {
                return false;
            }
            if (Far != other.Far)
            {
                return false;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            UFO ufoObj = obj as UFO;
            if (ufoObj == null)
            {
                return false;
            }
            else
            {
                return Equals(ufoObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
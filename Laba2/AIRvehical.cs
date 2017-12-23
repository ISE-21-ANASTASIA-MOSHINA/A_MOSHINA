using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class AIRvehical : Vehicle, IComparable<AIRvehical>, IEquatable<AIRvehical>
    {
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

        public Expression Expression => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

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
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
            }
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
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
            Pen penBody = new Pen(ColorBody, 10);
            Pen penRed = new Pen(Color.Red, 5);
            Brush brBlue = new SolidBrush(Color.Blue);
            g.FillEllipse(brBlue, startPosX, startPosY, 200, 50);
            g.DrawLine(penBody, startPosX + 60, startPosY + 45, startPosX + 40, startPosY + 75);
            g.DrawLine(penBody, startPosX + 130, startPosY + 45, startPosX + 150, startPosY + 75);
            g.DrawLine(penRed, startPosX, startPosY + 25, startPosX + 60, startPosY + 30);
            g.DrawLine(penRed, startPosX + 60, startPosY + 30, startPosX + 130, startPosY + 30);
            g.DrawLine(penRed, startPosX + 129, startPosY + 30, startPosX + 200, startPosY + 25);

        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" +
                Weight + ";" + ColorBody.Name;
        }

        //Для интерфейса IEquatable требуется еще перегрузить операторы Equals(object obj) и GetHashCode().
        public int CompareTo(AIRvehical other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (MaxCountPassengers != other.MaxCountPassengers)
            {
                return MaxCountPassengers.CompareTo(other.MaxCountPassengers);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (ColorBody != other.ColorBody)
            {
                return ColorBody.Name.CompareTo(other.ColorBody.Name);
            }
            return 0;
        }

        public bool Equals(AIRvehical other)
        {
            if (other == null)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (MaxCountPassengers != other.MaxCountPassengers)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (ColorBody != other.ColorBody)
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
            AIRvehical vehObj = obj as AIRvehical;
            if(vehObj == null)
            {
                return false;
            }
            else
            {
                return Equals(vehObj);
            }
        }
        public override int GetHashCode()
        {
            return MaxSpeed.GetHashCode();
        }
    }
}
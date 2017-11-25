using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Planet
    {
        List<ClassArray<Tehnika>> planetStages;
        //ClassArray<Tehnika> planet;
        int countPlaces = 16;
        int placeSizeWidth = 230;
        int placeSizeHeight = 150;
        int currentLevel;

        public int getCurrrenLevel { get { return currentLevel; } }
        
        public void LevelUp()
        {
            if (currentLevel+1<planetStages.Count)
            {
                currentLevel++;
            }
        }
        // переход ниже
        public void LevelDown()
        {
            if (currentLevel>0)
            {
                currentLevel--;
            }
        }
        public Planet (int level)
        {
            planetStages = new List<ClassArray<Tehnika>>();
            for (int i = 0; i < level; i++)
            {
                planetStages.Add(new ClassArray<Tehnika>(countPlaces, null));
            }
        }
        // поставить тарелку на planet
        public int PutAirvehicle(Tehnika airvehicle)
        {
            return planetStages[currentLevel] + airvehicle;
        }
        // забрать тарелку 
        public Tehnika GetAirvehicle (int ticket)
        {
            return planetStages[currentLevel] - ticket;
        }

        public void Draw (Graphics g)
        {
            DrawMarking(g);
            for (int i=0;i<countPlaces;i++)
            {
                var airvehicle = planetStages[currentLevel][i];
                if (airvehicle!=null)
                {
                    airvehicle.setPosition(4 + i /4 * placeSizeWidth + 4, i % 4 * placeSizeHeight + 15);
                    airvehicle.drawAIRvehical(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.DeepPink, 3);
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.GreenYellow),
                (countPlaces / 4) * placeSizeWidth-70, 440);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth,600);
            for (int i = 0; i < countPlaces / 4; i++)
            {
                for (int j = 0; j <5; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j<4)
                    {
                        g.DrawString((i * 4 + j + 1).ToString(), new Font("Arial", 30),
                          new SolidBrush (Color.GreenYellow), i*placeSizeWidth+30,j*placeSizeHeight+20 );
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 550);
            }
        }  
    }
}

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
        ClassArray<Tehnika> planet;

        int countPlaces = 20;

        int placeSizeWidth = 230;

        int placeSizeHeight = 150;

        public Planet()
        {
            planet = new ClassArray<Tehnika>(countPlaces, null);
        }

        public int PutAirvehicle(Tehnika airvehicle)
        {
            return planet + airvehicle;
        }

        public Tehnika GetAirvehicle (int ticket)
        {
            return planet - ticket;
        }

        public void Draw (Graphics g, int width, int height)
        {
            DrawPlanet(g);
            for (int i=0;i<countPlaces;i++)
            {
                var airvehicle = planet.getObject(i);
                if (airvehicle!=null)
                {
                    airvehicle.setPosition(5 + i / 4 * placeSizeWidth + 4, i % 4 * placeSizeHeight + 15);
                    airvehicle.drawAIRvehical(g);
                }
            }
        }

        private void DrawPlanet(Graphics g)
        {
            Pen pen = new Pen(Color.DeepPink, 3);
            for (int i = 0; i < countPlaces / 4; i++)
            {
                for (int j = 0; j <6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i * placeSizeWidth + 110, j * placeSizeHeight);
                    g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 600);
                }
            }
            for (int i = 0; i < countPlaces; i++)
            {
                if (planet.getObject(i) != null)
                {
                    planet.getObject(i).setPosition(15 + (200 * (i / 5)), 55 + (80 * (i % 5)));
                }
            }
        }
        
    }
}

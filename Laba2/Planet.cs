using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public bool SaveData (string filname)
        {
            if (File.Exists(filname))
            {
                File.Delete(filname);
            }
            using (FileStream fs = new FileStream(filname, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    // записываем кол-во уровней
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" +
                       planetStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in planetStages)
                    {
                        // начинаем уровень
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i=0;i<countPlaces;i++)
                        {
                            var UFO = level[i];
                            if (UFO != null)
                            {
                                // если мнесто непустое записывем тип машины
                                if (UFO.GetType().Name=="AIRvehicle")
                                {
                                    info = new UTF8Encoding(true).GetBytes("AIRvehicle:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (UFO.GetType().Name=="UFO")
                                {
                                    info = new UTF8Encoding(true).GetBytes("UFO:");
                                    fs.Write(info, 0, info.Length);
                                }
                                // записываем параметры
                                info = new UTF8Encoding(true).GetBytes(UFO.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);

                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b,0,b.Length)>0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {
                    // cчмтаем к-во уровней
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (planetStages!=null)
                    {
                        planetStages.Clear();
                    }
                    planetStages = new List<ClassArray<Tehnika>>(count);
                }
                else
                {
                    // если нет такой записи, то это не те данные
                    return false;
                }
                int counter = -1;
                for (int i = 1; i < strs.Length; ++i)
                {
                    // идем по считанным записям
                    if (strs[i] == "Level")
                    {
                        //начинаем новый уровень
                        counter++;
                        planetStages.Add(new ClassArray<Tehnika>(countPlaces, null));
                    }
                    else if (strs[i].Split(':')[0]=="AIRvehicle")
                    {
                        Tehnika AIRvehicle = new AIRvehical(strs[i].Split(':')[1]);
                        int number = planetStages[counter] + AIRvehicle;
                        if (number==-1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "UFO")
                    {
                        Tehnika AIRvehicle = new UFO(strs[i].Split(':')[1]);
                        int number = planetStages[counter] + AIRvehicle;
                        if (number==-1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        
    }
}

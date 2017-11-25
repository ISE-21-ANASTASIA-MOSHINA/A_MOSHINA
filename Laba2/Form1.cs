using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        Planet planet;

        Form2 form;

        public Form1()
        {
            InitializeComponent();
            planet = new Planet(5);
            //ЗАПОЛНЕНИЕ LISTBOX
            for (int i=1;i<6;i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = planet.getCurrrenLevel;
             Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                planet.Draw(gr);
                pictureBoxParking.Image = bmp;

            }
        }

        // перемещение на след уровень
        private void buttonDown_Click_Click(object sender, EventArgs e)
        {
            planet.LevelDown();
            listBoxLevels.SelectedIndex = planet.getCurrrenLevel;
            Draw();
        }

        // на нижний уровень
        private void buttonUp_Click_Click(object sender, EventArgs e)
        {
            planet.LevelUp();
            listBoxLevels.SelectedIndex = planet.getCurrrenLevel;
            Draw();

        }

        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            /* ColorDialog dialog = new ColorDialog();
             if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 var bedufo = new AIRvehical(100, 4, 1000, dialog.Color);
                 int place = planet.PutAirvehicle(bedufo);
                 Draw();
                 MessageBox.Show("Ваше место: " + (place));
             }*/
            form = new Form2();
            form.AddEvent(AddVehicle);// навязывается к форме событие (срабатывает) 
            form.Show();
        }

        private void AddVehicle(Tehnika vehicle)
        {
            if (vehicle != null)
            {
                int place = planet.PutAirvehicle(vehicle);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }



        private void buttonSetSportCar_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var ufo = new UFO(150, 4, 1000, dialog.Color, true, true, true,dialogDop.Color);
                    int place = planet.PutAirvehicle(ufo);
                    Draw();
                    MessageBox.Show("Вашеместо: " +place);
                }
            }
        }
        // забираем
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    Tehnika ufo = planet.GetAirvehicle(Convert.ToInt32(maskedTextBox1.Text));
                    if (ufo != null)
                    {//если удалось забрать, то отрисовываем
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ufo.setPosition(5, 5);
                        ufo.drawAIRvehical(gr);
                        pictureBoxTakeCar.Image = bmp;
                        Draw();
                    }
                    else
                    {//иначесообщаемобэтом
                        MessageBox.Show("Извинте, на этом месте нет машины");
                    }

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxParking_Click(object sender, EventArgs e)
        {

        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
namespace Laba2
{
    public partial class Form1 : Form
    {
        Planet planet;

        Form2 form;
        private Logger log;

        public Form1()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger(); 
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
            log.Info("Переход на новый уровень. Текущий уровень:" + planet.getCurrrenLevel);
            Draw();
        }

        // на нижний уровень
        private void buttonUp_Click_Click(object sender, EventArgs e)
        {
            planet.LevelUp();
            listBoxLevels.SelectedIndex = planet.getCurrrenLevel;
            log.Info("Переход на  предыдущий уровень. Текущий уровень:" + planet.getCurrrenLevel);
            Draw();

        }

        private void buttonSetCar_Click(object sender, EventArgs e)
        {
          
            form = new Form2();
            form.AddEvent(AddVehicle);// навязывается к форме событие (срабатывает) 
            form.Show();
        }

        private void AddVehicle(Tehnika vehicle)
        {
            if (vehicle != null)
            { 
                    try
                    {
                        int place = planet.PutAirvehicle(vehicle);
                        Draw();
                    log.Info("Добавление на место: " + place);
                    MessageBox.Show("Ваше место: " + (1 + place));
                    }
                    catch (ParkingIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка  переполнения",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Ваше место: " +(1+place));
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
                    try
                    {
                        Tehnika ufo = planet.GetAirvehicle(Convert.ToInt32(maskedTextBox1.Text));

                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ufo.setPosition(5, 5);
                        ufo.drawAIRvehical(gr);
                        pictureBoxTakeCar.Image = bmp;
                        log.Info("Забрали с места: " + Convert.ToInt32(maskedTextBox1.Text));
                        Draw();
                    }
                    catch (ParkingIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message,"Неверный номер",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                if (planet.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (planet.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            planet.Sort();
            Draw();
        }
    }
}


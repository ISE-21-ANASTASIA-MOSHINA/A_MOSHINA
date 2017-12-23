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
    public partial class Form2 : Form
    {
        
        Vehicle vehicle = null;
        public Vehicle GetVehicle { get { return vehicle; } }
        private void DrawVehicle()
        {
            if (vehicle!=null)
            {
                Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(btm);
                vehicle.setPosition(5,5);
                vehicle.drawAIRvehical(gr);
                pictureBox1.Image = btm;
            }
        }

        private event myDel eventAddVeh;// создаем событие 
        public void AddEvent(myDel ev)// метод который добавляет в него методы (или нет)
        {
            if (eventAddVeh == null)
            {
                eventAddVeh = new myDel(ev);
            }
            else
            {
                eventAddVeh += ev;
            }
        }


        public Form2()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void labelAirveh_MouseDown(object sender, MouseEventArgs e)
        {
            labelAirvehical.DoDragDrop(labelAirvehical.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelUFO_MouseDown(object sender, MouseEventArgs e)
        {
            labelUFO.DoDragDrop(labelUFO.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelAirvehicle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelAirvehicle_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                //выбор случайной машины
                case "AIRvehicle":
                    vehicle = new AIRvehical(1500, 3, 150, Color.Red);
                    break;
                case "UFO":
                    vehicle = new UFO(3000, 5, 150, Color.Pink, true, true, true, Color.Olive);
                    break;
            }
            DrawVehicle();
        }


        private void Airvehicle_Click(object sender, EventArgs e)
        {

        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
            DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelColor_DragDrop(object sender, DragEventArgs e)
        {
            if (vehicle != null)
            {
                vehicle.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawVehicle();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (vehicle != null)
            {
                if (vehicle is UFO)
                {
                    (vehicle as UFO).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawVehicle();
                }
            }
        }
        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (eventAddVeh != null)
            {
                eventAddVeh(vehicle);//вызывается метод при наж
            }
            Close();
        }
       


        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelAirvehical_Click(object sender, EventArgs e)
        {

        }

        private void labelUFO_Click(object sender, EventArgs e)
        {

        }

        private void labelAirVeh_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelAirVeh_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}

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

        public Form1()
        {
            InitializeComponent();
            planet = new Planet();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            planet.Draw(gr, pictureBoxParking.Width, pictureBoxParking.Height);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var bedufo = new AIRvehical(100, 4, 1000, dialog.Color);
                int place = planet.PutAirvehicle(bedufo);
                Draw();
                MessageBox.Show("Ваше место: " + (place + 1));
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
                    MessageBox.Show("Вашеместо: " + (place + 1));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var ufo = planet.GetAirvehicle(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ufo.setPosition(5, 5);
                ufo.drawAIRvehical(gr);
                pictureBoxTakeCar.Image = bmp;
                Draw();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


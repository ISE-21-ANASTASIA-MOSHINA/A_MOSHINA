using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAAAAAAAAAAAAAAAAAAA
{
    public partial class Form1 : Form
    {
        private Salt salt;

        private WaterTap waterTap;

        private Knife knife;

        private Pan pan;

        private Stove stove;
        
        private Potato[] potato;
        private Onion[] onion;
        private Oil oil;
        public Form1()
        {
            InitializeComponent();
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
            waterTap = new WaterTap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ker_Click(object sender, EventArgs e)
        {

        }
        
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                waterTap.State = true;
            }
        }
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                waterTap.State = false;
            }

        }


        private void numericUpDownPOP_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (onion == null)
            {
                MessageBox.Show("ДОБАВЬТЕ ЛУК", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (onion.Length == 0)
            {
                MessageBox.Show("ДОБАВЬТЕ ЛУК", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
      
            for (int i = 0; i < onion.Length; ++i)
            {
                knife.Clean_onion(onion[i]);
            }
            button11.Enabled = true;
            MessageBox.Show("лук почищен", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (potato == null)
            {
                MessageBox.Show("Добавьте картошку", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potato.Length == 0)
            {
                MessageBox.Show("добавьте картошку", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potato.Length; i++)
            {
                if (potato[i].Dirty == true)
                {
                    MessageBox.Show("Помойте картошку", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potato.Length; i++)
            {
                knife.Clean_potato(potato[i]);
            }
            //button9.Enabled = true;
            MessageBox.Show("картошка почищена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (potato == null)
            {
                MessageBox.Show("ДОБАВЬТЕ КАРТОШКУ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potato.Length == 0)
            {
                MessageBox.Show("ДОБАВЬТЕ КАРТОШКУ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < potato.Length; ++i)
            {

                if (potato[i].Have_scin)
                {
                    MessageBox.Show("КАЖЕТСЯ ВЫ ЗАБЫЛИ ПОЧИСТИТЬ КАРТОШКУ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            pan.AddPotato(potato);
            MessageBox.Show("КАРТОШКА ДОБАВЛЕНА", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (onion == null)
            {
                MessageBox.Show("ДОБАВЬТЕ ЛУК", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (onion.Length == 0)
            {
                MessageBox.Show("ДОБАВЬТЕ ЛУК", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < onion.Length; ++i)
            {

                if (onion[i].Have_scin)
                {
                    MessageBox.Show("КАЖЕТСЯ ВЫ ЗАБЫЛИ ПОЧИСТИТЬ ЛУК", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            pan.AddOnion(onion);
            MessageBox.Show("ЛУК ДОБАВЛЕН", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (oil == null)
            {
                MessageBox.Show("ДОБВЬТЕ МАСЛО", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("МАСЛО ДОБАВЛЕНО", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pan.AddOil(oil);

        }
        private void button13_Click(object sender, EventArgs e)
        {
            salt = new Salt();
            salt.Count = Convert.ToInt32(numericUpDown3.Value);
            if (salt.Count > 0)
            {
                pan.AddSalt(salt);
                MessageBox.Show("СОЛЬ ДОБАВЛЕНА", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ДОБАВЬТЕ СОЛЬ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            button7.Enabled = true;
            MessageBox.Show("СКОВОРОДА НА ПЛИТЕ", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!stove.pan1())
            {
                MessageBox.Show("К ЖАРКЕ ВСЕ ГОТОВО", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!stove.State)
            {
                MessageBox.Show("ВКЛЮЧИТЕ ПЛИТУ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stove.Cook();
            if (!stove.Pan.Isready())
            {
                radioButton3.Checked = false;
                MessageBox.Show("ЕЕЕ ГОТОВОООО!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Я КУДА-ТО ТЫКНУЛ И ВСЕ ПОЛОМАЛОСЬ =(", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = radioButton3.Checked;
        }
        private void button15_Click(object sender, EventArgs e)
        {

            potato = new Potato[3];
            for (int i = 0; i < potato.Length; i++)
            {
                potato[i] = new Potato();

            }
            onion = new Onion[2];
            for (int i = 0; i < onion.Length; i++)
            {
                onion[i] = new Onion();
            }
            oil = new Oil();
            MessageBox.Show("ПОГНАЛИ", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (potato == null)
            {
                MessageBox.Show("где картошку потерял??", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    for (int i = 0; i < potato.Length; ++i)
                    {
                        potato[i].Dirty = false;
                    }

                    for (int i = 0; i < potato.Length; i++)
                    {
                        if (potato[i].Dirty == false && potato[i] != null)
                        {
                            MessageBox.Show("Картошку помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Картошкитонет, что мыть?", "Ошибкалогики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            
            
        }

        
    }
}

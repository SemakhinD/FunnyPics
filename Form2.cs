using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOne
{
    public partial class Form2 : Form
    {
        string Data;
        string DataTest;
        bool AbleToStart = false;
        int Delay = 1000;
        string[] Images = new string[] { "Cat.png", "Dog.png", "House.png", "USSR.png", "Eagle.png", "Ball.png", "Pikachu.png", "Batman.png" };

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AbleToStart == true)
            {
                Delay = Convert.ToInt32(textBox2.Text);
                Form1 newForm1 = new Form1(Data, Delay);
                newForm1.Show();
            }
            else
                MessageBox.Show("Адрес не загружен. \nНевозможно начать игру.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data = textBox1.Text;

            for (int i = 0; i < 8; i++)
            {
                DataTest = Data + Images[i];
                if (File.Exists(DataTest) == false)
                {
                    MessageBox.Show("Неверный адрес, проверьте наличие \nвсех картинок и правильность адреса к ним.");
                    break;
                }
                MessageBox.Show("Адрес успешно загружен");
                AbleToStart = true;
                break;
            }
        }
    }
}

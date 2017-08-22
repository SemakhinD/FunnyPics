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

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1(Data);
            newForm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data = textBox1.Text;
            string DataTest = Data + "Cat.png";

            if (File.Exists(DataTest) == false)
                MessageBox.Show("Неверный адрес, проверьте наличие \nвсех картинок и правильность адреса к ним.");
            else
                MessageBox.Show("Адрес успешно загружен");
        }
    }
}

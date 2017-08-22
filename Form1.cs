using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOne
{
    public partial class Form1 : Form
    {
        string[] Images = new string[] { "Cat.png", "Dog.png", "House.png", "USSR.png", "Eagle.png", "Ball.png", "Pikachu.png", "Batman.png" };
        
        int Score = 100;
        string[] FinalPic = new string[16];
        string[] ElementaryPic = new string[16];
        int[,] Pairs = new int[,] { { 1, 12 }, { 2, 16 }, { 3, 15 }, { 4, 7 }, { 5, 13 }, { 6, 14 }, { 8, 10 }, { 9, 11 } };
        int[] BrotherImage = new int[16];
        int[] BrotherImageClone = new int[16];
        int LastImage = 0;
        bool[] BoxIsClosed = new bool[16];

        public Form1(string Data)
        {
            InitializeComponent();

            ConvertToBrotherImageMassive(Pairs);
            Constructor();

            for (int i = 0; i < 16; i++)
            {
                FinalPic[i] = Data + ElementaryPic[i];
                BoxIsClosed[i] = false;
            }
        }

        void ConvertToBrotherImageMassive(int[,] Pairs)
        {
            for (int i = 0; i < 8; i++)
            {
                BrotherImage[Pairs[i, 0] - 1] = BrotherImageClone[Pairs[i, 0] - 1] = Pairs[i, 1];
                BrotherImage[Pairs[i, 1] - 1] = BrotherImageClone[Pairs[i, 1] - 1] = Pairs[i, 0];
            }
        }

        void Constructor()
        {
            int k = 0;
            for (int A = 1; A < 17; A++)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (BrotherImageClone[i] == A)
                    {
                        ElementaryPic[A - 1] = ElementaryPic[i] = Images[k];
                        k++;
                        BrotherImageClone[A - 1] = BrotherImageClone[i] = 0;
                    }
                }
            }
        }

        void CloseAll()
        {
            if (BoxIsClosed[0] == false)
                pictureBox1.BackgroundImage = null;
            if (BoxIsClosed[1] == false)
                pictureBox2.BackgroundImage = null;
            if (BoxIsClosed[2] == false)
                pictureBox3.BackgroundImage = null;
            if (BoxIsClosed[3] == false)
                pictureBox4.BackgroundImage = null;
            if (BoxIsClosed[4] == false)
                pictureBox5.BackgroundImage = null;
            if (BoxIsClosed[5] == false)
                pictureBox6.BackgroundImage = null;
            if (BoxIsClosed[6] == false)
                pictureBox7.BackgroundImage = null;
            if (BoxIsClosed[7] == false)
                pictureBox8.BackgroundImage = null;
            if (BoxIsClosed[8] == false)
                pictureBox9.BackgroundImage = null;
            if (BoxIsClosed[9] == false)
                pictureBox10.BackgroundImage = null;
            if (BoxIsClosed[10] == false)
                pictureBox11.BackgroundImage = null;
            if (BoxIsClosed[11] == false)
                pictureBox12.BackgroundImage = null;
            if (BoxIsClosed[12] == false)
                pictureBox13.BackgroundImage = null;
            if (BoxIsClosed[13] == false)
                pictureBox14.BackgroundImage = null;
            if (BoxIsClosed[14] == false)
                pictureBox15.BackgroundImage = null;
            if (BoxIsClosed[15] == false)
                pictureBox16.BackgroundImage = null;
        }

        async void CloseBoxes(int CurrentImageNumber, int LastImageNumber)
        {
            CloseAll();

            switch(CurrentImageNumber)
            {
                case 1:
                    pictureBox1.BackgroundImage = Image.FromFile(FinalPic[0]);
                    break;
                case 2:
                    pictureBox2.BackgroundImage = Image.FromFile(FinalPic[1]);
                    break;
                case 3:
                    pictureBox3.BackgroundImage = Image.FromFile(FinalPic[2]);
                    break;
                case 4:
                    pictureBox4.BackgroundImage = Image.FromFile(FinalPic[3]);
                    break;
                case 5:
                    pictureBox5.BackgroundImage = Image.FromFile(FinalPic[4]);
                    break;
                case 6:
                    pictureBox6.BackgroundImage = Image.FromFile(FinalPic[5]);
                    break;
                case 7:
                    pictureBox7.BackgroundImage = Image.FromFile(FinalPic[6]);
                    break;
                case 8:
                    pictureBox8.BackgroundImage = Image.FromFile(FinalPic[7]);
                    break;
                case 9:
                    pictureBox9.BackgroundImage = Image.FromFile(FinalPic[8]);
                    break;
                case 10:
                    pictureBox10.BackgroundImage = Image.FromFile(FinalPic[9]);
                    break;
                case 11:
                    pictureBox11.BackgroundImage = Image.FromFile(FinalPic[10]);
                    break;
                case 12:
                    pictureBox12.BackgroundImage = Image.FromFile(FinalPic[11]);
                    break;
                case 13:
                    pictureBox13.BackgroundImage = Image.FromFile(FinalPic[12]);
                    break;
                case 14:
                    pictureBox14.BackgroundImage = Image.FromFile(FinalPic[13]);
                    break;
                case 15:
                    pictureBox15.BackgroundImage = Image.FromFile(FinalPic[14]);
                    break;
                case 16:
                    pictureBox16.BackgroundImage = Image.FromFile(FinalPic[15]);
                    break;
            }

            switch (LastImageNumber)
            {
                case 1:
                    pictureBox1.BackgroundImage = Image.FromFile(FinalPic[0]);
                    if (BrotherImage[0] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 2:
                    pictureBox2.BackgroundImage = Image.FromFile(FinalPic[1]);
                    if (BrotherImage[1] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 3:
                    pictureBox3.BackgroundImage = Image.FromFile(FinalPic[2]);
                    if (BrotherImage[2] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 4:
                    pictureBox4.BackgroundImage = Image.FromFile(FinalPic[3]);
                    if (BrotherImage[3] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 5:
                    pictureBox5.BackgroundImage = Image.FromFile(FinalPic[4]);
                    if (BrotherImage[4] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 6:
                    pictureBox6.BackgroundImage = Image.FromFile(FinalPic[5]);
                    if (BrotherImage[5] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 7:
                    pictureBox7.BackgroundImage = Image.FromFile(FinalPic[6]);
                    if (BrotherImage[6] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 8:
                    pictureBox8.BackgroundImage = Image.FromFile(FinalPic[7]);
                    if (BrotherImage[7] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 9:
                    pictureBox9.BackgroundImage = Image.FromFile(FinalPic[8]);
                    if (BrotherImage[8] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 10:
                    pictureBox10.BackgroundImage = Image.FromFile(FinalPic[9]);
                    if (BrotherImage[9] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 11:
                    pictureBox11.BackgroundImage = Image.FromFile(FinalPic[10]);
                    if (BrotherImage[10] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 12:
                    pictureBox12.BackgroundImage = Image.FromFile(FinalPic[11]);
                    if (BrotherImage[11] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 13:
                    pictureBox13.BackgroundImage = Image.FromFile(FinalPic[12]);
                    if (BrotherImage[12] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 14:
                    pictureBox14.BackgroundImage = Image.FromFile(FinalPic[13]);
                    if (BrotherImage[13] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 15:
                    pictureBox15.BackgroundImage = Image.FromFile(FinalPic[14]);
                    if (BrotherImage[14] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 16:
                    pictureBox16.BackgroundImage = Image.FromFile(FinalPic[15]);
                    if (BrotherImage[15] == CurrentImageNumber)
                    {
                        BoxIsClosed[CurrentImageNumber-1] = true;
                        BoxIsClosed[LastImageNumber-1] = true;
                    }
                    LastImage = 0;
                    await Task.Delay(1000);
                    CloseAll();
                    break;
                case 0:
                    LastImage = CurrentImageNumber;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[0] == false)
            {
                if (pictureBox1.BackgroundImage == null)
                {
                    CloseBoxes(1, LastImage);
                }
                else
                {
                    pictureBox1.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[1] == false)
            {
                if (pictureBox2.BackgroundImage == null)
                {
                    CloseBoxes(2, LastImage);
                }
                else
                {
                    pictureBox2.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[2] == false)
            {
                if (pictureBox3.BackgroundImage == null)
                {
                    CloseBoxes(3, LastImage);
                }
                else
                {
                    pictureBox3.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[3] == false)
            {
                if (pictureBox4.BackgroundImage == null)
                {
                    CloseBoxes(4, LastImage);
                }
                else
                {
                    pictureBox4.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[4] == false)
            {
                if (pictureBox5.BackgroundImage == null)
                {
                    CloseBoxes(5, LastImage);
                }
                else
                {
                    pictureBox5.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[5] == false)
            {
                if (pictureBox6.BackgroundImage == null)
                {
                    CloseBoxes(6, LastImage);
                }
                else
                {
                    pictureBox6.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[6] == false)
            {
                if (pictureBox7.BackgroundImage == null)
                {
                    CloseBoxes(7, LastImage);
                }
                else
                {
                    pictureBox7.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[7] == false)
            {
                if (pictureBox8.BackgroundImage == null)
                {
                    CloseBoxes(8, LastImage);
                }
                else
                {
                    pictureBox8.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[8] == false)
            {
                if (pictureBox9.BackgroundImage == null)
                {
                    CloseBoxes(9, LastImage);
                }
                else
                {
                    pictureBox9.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[9] == false)
            {
                if (pictureBox10.BackgroundImage == null)
                {
                    CloseBoxes(10, LastImage);
                }
                else
                {
                    pictureBox10.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[10] == false)
            {
                if (pictureBox11.BackgroundImage == null)
                {
                    CloseBoxes(11, LastImage);
                }
                else
                {
                    pictureBox11.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[11] == false)
            {
                if (pictureBox12.BackgroundImage == null)
                {
                    CloseBoxes(12, LastImage);
                }
                else
                {
                    pictureBox12.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[12] == false)
            {
                if (pictureBox13.BackgroundImage == null)
                {
                    CloseBoxes(13, LastImage);
                }
                else
                {
                    pictureBox13.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[13] == false)
            {
                if (pictureBox14.BackgroundImage == null)
                {
                    CloseBoxes(14, LastImage);
                }
                else
                {
                    pictureBox14.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[14] == false)
            {
                if (pictureBox15.BackgroundImage == null)
                {
                    CloseBoxes(15, LastImage);
                }
                else
                {
                    pictureBox15.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (BoxIsClosed[15] == false)
            {
                if (pictureBox16.BackgroundImage == null)
                {
                    CloseBoxes(16, LastImage);
                }
                else
                {
                    pictureBox16.BackgroundImage = null;
                    LastImage = 0;
                }
                Score--;
                label2.Text = Convert.ToString(Score);
            }
        }
    }
}

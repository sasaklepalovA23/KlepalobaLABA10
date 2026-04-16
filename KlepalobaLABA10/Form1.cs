using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KlepalobaLABA10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            {
                case 0:
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS1.png");


                        break;
                    }
                case 1:
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS2.png");

                        break;
                    }
                case 2:
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS3.png");

                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex) 
            {
                case 0:
                    {
                        pictureBox2.Visible = true;
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS1.png");
                       
                        break;
                    }
                case 1:
                    {
                        pictureBox2.Visible = true;
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS2.png");
                        break;
                    }
                case 2:
                    {
                        pictureBox2.Visible = true;
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS3.png");
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) 
            {
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS1.png");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS2.png");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS3.png");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS1.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS2.png");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                pictureBox4.Visible = true;
                pictureBox4.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS3.png");
            }

            if (numericUpDown1.Value == 1)
            {
                pictureBox4.Visible = true;
                pictureBox4.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS1.png");
            }

            if (numericUpDown1.Value == 2)
            {
                pictureBox4.Visible = true;
                pictureBox4.Image = Image.FromFile(@"C:\Users\Digma\Pictures\RIS2.png");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            Form1 f1 = new Form1();

            f1.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int value2 = (int)numeric.Value;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int value4 = (int)numeric.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int value6 = (int)numeric.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int value8 = (int)numeric.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int value10 = (int)numeric.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int value12 = (int)numeric.Value;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int value20 = (int)numeric.Value;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int value100 = (int)numeric.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            StringBuilder rolls = new StringBuilder();

            for (int i = 0; i < value2; i++)
            {
                int roll2 = random.Next(1, 3);
                rolls.Append(roll + " ");
            }
            for (int i = 0; i < value4; i++)
            {
                int roll4 = random.Next(1, 5);
                rolls.Append(roll + " ");
            }
            for (int i = 0; i < value6; i++)
            {
                int roll6 = random.Next(1, 7);
                rolls.Append(roll + " ");
            }
            for (int i = 0; i < value8; i++)
            {
                int roll8 = random.Next(1, 9);
                rolls.Append(roll + " ");
            }
            for (int i = 0; i < value10; i++)
            {
                int roll10 = random.Next(1, 11);
                rolls.Append(roll + " ");
            }
            for (int i = 0; i < value12; i++)
            {
                int roll12 = random.Next(1, 13);
                rolls.Append(roll + " ");
            }
            for (int i = 0; i < value20; i++)
            {
                int roll20 = random.Next(1, 21);
                rolls.Append(roll + " ");
            }
            for (int i = 0; i < value100; i++)
            {
                int roll100 = random.Next(1, 100);
                rolls.Append(roll + " ");
            }

            Form2 form2 = new Form2();
            form2.label9.Text = rolls2.ToString();
            form2.label10.Text = rolls4.ToString();
            form2.label11.Text = rolls6.ToString();
            form2.label12.Text = rolls8.ToString();
            form2.label13.Text = rolls10.ToString();
            form2.label14.Text = rolls12.ToString();
            form2.label15.Text = rolls20.ToString();
            form2.label16.Text = rolls100.ToString();
            form2.Show();
        }
    }
}

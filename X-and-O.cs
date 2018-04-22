using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int number = 0;
        int[] i = new int[9];
        private void button1_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number % 2 == 1)
            {
                button1.Text = "X";
                i[0] = 1;
            }
            else
            {
                button1.Text = "O";
                i[0] = 2;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number % 2 == 1)
            {
                button2.Text = "X";
                i[1] = 1;
            }
            else
            {
                button2.Text = "O";
                i[1] = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number % 2 == 1)
            {
                button3.Text = "X";
                i[2] = 1;
            }
            else
            {
                button3.Text = "O";
                i[2] = 2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number % 2 == 1)
            {
                button6.Text = "X";
                i[3] = 1;
            }
            else
            {
                button6.Text = "O";
                i[3] = 2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number % 2 == 1)
            {
                button5.Text = "X";
                i[4] = 1;
            }
            else
            {
                button5.Text = "O";
                i[4] = 2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number % 2 == 1)
            {
                button4.Text = "X";
                i[5] = 1;
            }
            else
            {
                button4.Text = "O";
                i[5] = 2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number % 2 == 1)
            {
                button9.Text = "X";
                i[6] = 1;
            }
            else
            {
                button9.Text = "O";
                i[6] = 2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number % 2 == 1)
            {
                button8.Text = "X";
                i[7] = 1;
            }
            else
            {
                button8.Text = "O";
                i[7] = 2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number % 2 == 1)
            {
                button7.Text = "X";
                i[8] = 1;
            }
            else
            {
                button7.Text = "O";
                i[8] = 2;
            }
            button7.Enabled = false;
        }
        int count1 = 0;
        bool Xvictory = false;
        bool Ovictory = false;
        int help1 = 0;
        int count2 = 0;
        int help2 = 0;
        int victory1 = 0;
        int victory2 = 0;
        int victory3 = 0;
        int victory4 = 0;
        int help3 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            switch (i[count1])
            {
                case 1:
                    victory1 = victory1 + 1;
                    help1 = help1 + 1;
                    if (victory1 == 3 && help1 == 3)
                    { Xvictory = true; }
                    if (help1 == 3)
                    {
                        help1 = 0;
                        victory1 = 0;
                    }
                    victory2 = 0;
                    break;
                case 2:
                    victory2 = victory2 + 1;
                    help1 = help1 + 1;
                    if (victory2 == 3 && help1 == 3)
                    { Ovictory = true; }
                    if (help1 == 3)
                    {
                        help1 = 0;
                        victory2 = 0;
                    }
                    victory1 = 0;
                    break;
                default:
                    victory2 = 0;
                    victory1 = 0;
                    help1 = 0;
                    break;
            }
            count1 = count1 + 1;
            if (count1 == 9)
            { count1 = 0; }
            
            
            switch (i[count2])
              {
                  case 1:
                      victory3 = victory3 + 1;
                      help3 = help3 + 1;
                      if (victory3 == 3 && help3 == 3)
                      { Xvictory = true; }
                      if (help3 == 3)
                      {
                          help3 = 0;
                          victory3 = 0;
                      }
                    victory4 = 0;
                      break;
                  case 2:
                      victory4 = victory4 + 1;
                      help3 = help3 + 1;
                      if (victory4 == 3 && help3 == 3)
                      { Ovictory = true; }
                      if (help3 == 3)
                      {
                          help3 = 0;
                          victory4 = 0;
                      }
                    victory3 = 0;
                      break;
                  default:
                      victory3 = 0;
                      victory4 = 0;
                      help3 = 0;
                      break;
              }
              count2 = count2 + 3;
              if (help2 > 1 && help2 < 3)
              {
                  count2 = 1;
              }
              if (help2 > 4 && help2 < 6)
              {
                  count2 = 2;
              }
              if (help2 > 7 )
              {
                  count2 = 0;
                help2 = -1;
              }
              help2 = help2 + 1;
            
              
            if (Xvictory == true)
            {
                button5.Text = "Victory (X)";
                timer1.Enabled = false;
            }
            if (Ovictory == true)
            {
                button5.Text = "Victory (O)";
                timer1.Enabled = false;
            }
        }
    }
}

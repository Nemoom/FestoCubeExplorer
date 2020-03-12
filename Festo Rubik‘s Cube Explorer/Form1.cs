using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Festo_Rubik_s_Cube_Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'W':
                case 'w':
                case '1':
                    ((Button)sender).BackColor = Color.White;
                    break;
                case 'B':
                case 'b':
                case '2':
                    ((Button)sender).BackColor = Color.Blue;
                    break;
                case 'O':
                case 'o':
                case '3':
                    ((Button)sender).BackColor = Color.Orange;
                    break;
                case 'G':
                case 'g':
                case '4':
                    ((Button)sender).BackColor = Color.Green;
                    break;
                case 'R':
                case 'r':
                case '5':
                    ((Button)sender).BackColor = Color.Red;
                    break;
                case 'Y':
                case 'y':
                case '6':
                    ((Button)sender).BackColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.White)
            {
                ((Button)sender).BackColor = Color.Blue;
            }
            else if (((Button)sender).BackColor == Color.Blue)
            {
                ((Button)sender).BackColor = Color.Orange;
            }
            else if (((Button)sender).BackColor == Color.Orange)
            {
                ((Button)sender).BackColor = Color.Green;
            }
            else if (((Button)sender).BackColor == Color.Green)
            {
                ((Button)sender).BackColor = Color.Red;
            }
            else if (((Button)sender).BackColor == Color.Red)
            {
                ((Button)sender).BackColor = Color.Yellow;
            }
            else if (((Button)sender).BackColor == Color.Yellow)
            {
                ((Button)sender).BackColor = Color.White;
            }
            else
            {
                ((Button)sender).BackColor = Color.White;
            }
        }
    }
}

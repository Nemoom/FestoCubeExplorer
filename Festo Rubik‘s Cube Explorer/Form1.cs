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

        private string GetColor(Button mButton)
        {
            string mColor = " ";
            if (mButton.BackColor == btn_U5.BackColor) { mColor = "U"; }
            else if (mButton.BackColor == btn_R5.BackColor) { mColor = "R"; }
            else if (mButton.BackColor == btn_F5.BackColor) { mColor = "F"; }
            else if (mButton.BackColor == btn_D5.BackColor) { mColor = "D"; }
            else if (mButton.BackColor == btn_L5.BackColor) { mColor = "L"; }
            else if (mButton.BackColor == btn_B5.BackColor) { mColor = "B"; }
            return mColor;
        }
        private void tableLayoutPanel_Cube_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = GetColor(btn_U1) 
                        + GetColor(btn_U2)
                        + GetColor(btn_U3)
                        + GetColor(btn_U4)
                        + GetColor(btn_U5)
                        + GetColor(btn_U6)
                        + GetColor(btn_U7)
                        + GetColor(btn_U8)
                        + GetColor(btn_U9)
                        + GetColor(btn_R1)
                        + GetColor(btn_R2)
                        + GetColor(btn_R3)
                        + GetColor(btn_R4)
                        + GetColor(btn_R5)
                        + GetColor(btn_R6)
                        + GetColor(btn_R7)
                        + GetColor(btn_R8)
                        + GetColor(btn_R9)
                        + GetColor(btn_F1)
                        + GetColor(btn_F2)
                        + GetColor(btn_F3)
                        + GetColor(btn_F4)
                        + GetColor(btn_F5)
                        + GetColor(btn_F6)
                        + GetColor(btn_F7)
                        + GetColor(btn_F8)
                        + GetColor(btn_F9)
                        + GetColor(btn_D1)
                        + GetColor(btn_D2)
                        + GetColor(btn_D3)
                        + GetColor(btn_D4)
                        + GetColor(btn_D5)
                        + GetColor(btn_D6)
                        + GetColor(btn_D7)
                        + GetColor(btn_D8)
                        + GetColor(btn_D9)
                        + GetColor(btn_L1)
                        + GetColor(btn_L2)
                        + GetColor(btn_L3)
                        + GetColor(btn_L4)
                        + GetColor(btn_L5)
                        + GetColor(btn_L6)
                        + GetColor(btn_L7)
                        + GetColor(btn_L8)
                        + GetColor(btn_L9)
                        + GetColor(btn_B1)
                        + GetColor(btn_B2)
                        + GetColor(btn_B3)
                        + GetColor(btn_B4)
                        + GetColor(btn_B5)
                        + GetColor(btn_B6)
                        + GetColor(btn_B7)
                        + GetColor(btn_B8)
                        + GetColor(btn_B9);
        }
    }
}

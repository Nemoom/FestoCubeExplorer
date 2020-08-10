using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Opc.Ua;
using OpcUaHelper;

namespace Festo_Rubik_s_Cube_Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpcUaClient m_OpcUaClient;
        private void Form1_Load(object sender, EventArgs e)
        {
            m_OpcUaClient = new OpcUaClient();
            //设置匿名连接
            m_OpcUaClient.UserIdentity = new UserIdentity(new AnonymousIdentityToken());
            //设置用户名连接
            //m_OpcUaClient.UserIdentity = new UserIdentity( "user", "password" );

            //使用证书连接
            //X509Certificate2 certificate = new X509Certificate2("[证书的路径]", "[密钥]", X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable);
            //m_OpcUaClient.UserIdentity = new UserIdentity(certificate);

            m_OpcUaClient.ConnectComplete += M_OpcUaClient_ConnectComplete;
            m_OpcUaClient.OpcStatusChange += M_OpcUaClient_OpcStatusChange;
        }

        private void M_OpcUaClient_OpcStatusChange(object sender, OpcUaStatusEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void M_OpcUaClient_ConnectComplete(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        private void SetColor(int index, string str_c)
        {
            Button mBtn = new Button();
            switch (index)
            {
                case 1:
                    mBtn = btn_U1;
                    break;
                case 2:
                    mBtn = btn_U2;
                    break;
                case 3:
                    mBtn = btn_U3;
                    break;
                case 4:
                    mBtn = btn_U4;
                    break;
                case 5:
                    mBtn = btn_U5;
                    break;
                case 6:
                    mBtn = btn_U6;
                    break;
                case 7:
                    mBtn = btn_U7;
                    break;
                case 8:
                    mBtn = btn_U8;
                    break;
                case 9:
                    mBtn = btn_U9;
                    break;
                case 10:
                    mBtn = btn_R1;
                    break;
                case 11:
                    mBtn = btn_R2;
                    break;
                case 12:
                    mBtn = btn_R3;
                    break;
                case 13:
                    mBtn = btn_R4;
                    break;
                case 14:
                    mBtn = btn_R5;
                    break;
                case 15:
                    mBtn = btn_R6;
                    break;
                case 16:
                    mBtn = btn_R7;
                    break;
                case 17:
                    mBtn = btn_R8;
                    break;
                case 18:
                    mBtn = btn_R9;
                    break;
                case 19:
                    mBtn = btn_F1;
                    break;
                case 20:
                    mBtn = btn_F2;
                    break;
                case 21:
                    mBtn = btn_F3;
                    break;
                case 22:
                    mBtn = btn_F4;
                    break;
                case 23:
                    mBtn = btn_F5;
                    break;
                case 24:
                    mBtn = btn_F6;
                    break;
                case 25:
                    mBtn = btn_F7;
                    break;
                case 26:
                    mBtn = btn_F8;
                    break;
                case 27:
                    mBtn = btn_F9;
                    break;
                case 28:
                    mBtn = btn_D1;
                    break;
                case 29:
                    mBtn = btn_D2;
                    break;
                case 30:
                    mBtn = btn_D3;
                    break;
                case 31:
                    mBtn = btn_D4;
                    break;
                case 32:
                    mBtn = btn_D5;
                    break;
                case 33:
                    mBtn = btn_D6;
                    break;
                case 34:
                    mBtn = btn_D7;
                    break;
                case 35:
                    mBtn = btn_D8;
                    break;
                case 36:
                    mBtn = btn_D9;
                    break;
                case 37:
                    mBtn = btn_L1;
                    break;
                case 38:
                    mBtn = btn_L2;
                    break;
                case 39:
                    mBtn = btn_L3;
                    break;
                case 40:
                    mBtn = btn_L4;
                    break;
                case 41:
                    mBtn = btn_L5;
                    break;
                case 42:
                    mBtn = btn_L6;
                    break;
                case 43:
                    mBtn = btn_L7;
                    break;
                case 44:
                    mBtn = btn_L8;
                    break;
                case 45:
                    mBtn = btn_L9;
                    break;
                case 46:
                    mBtn = btn_B1;
                    break;
                case 47:
                    mBtn = btn_B2;
                    break;
                case 48:
                    mBtn = btn_B3;
                    break;
                case 49:
                    mBtn = btn_B4;
                    break;
                case 50:
                    mBtn = btn_B5;
                    break;
                case 51:
                    mBtn = btn_B6;
                    break;
                case 52:
                    mBtn = btn_B7;
                    break;
                case 53:
                    mBtn = btn_B8;
                    break;
                case 54:
                    mBtn = btn_B9;
                    break;
                default:
                    break;
            }
            switch (str_c)
            {
                case "U":
                case "u":
                    mBtn.BackColor = btn_U5.BackColor;
                    break;
                case "R":
                case "r":
                    mBtn.BackColor = btn_R5.BackColor;
                    break;
                case "F":
                case "f":
                    mBtn.BackColor = btn_F5.BackColor;
                    break;
                case "D":
                case "d":
                    mBtn.BackColor = btn_D5.BackColor;
                    break;
                case "L":
                case "l":
                    mBtn.BackColor = btn_L5.BackColor;
                    break;
                case "B":
                case "b":
                    mBtn.BackColor = btn_B5.BackColor;
                    break;
                default:
                    break;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pyexePath = @"kociemba.exe";
                //python文件所在路径，一般不使用绝对路径，此处仅作为例子，建议转移到debug文件夹下

                Process p = new Process();
                p.StartInfo.FileName = pyexePath;//需要执行的文件路径
                p.StartInfo.UseShellExecute = false; //必需
                p.StartInfo.RedirectStandardOutput = true;//输出参数设定
                p.StartInfo.RedirectStandardInput = true;//传入参数设定
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.Arguments =  textBox1.Text ;//参数以空格分隔，如果某个参数为空，可以传入””
                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//关键，等待外部程序退出后才能往下执行}
                Console.Write(output);//输出
                textBox2.Text = output;
                p.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                SetColor((i + 1), textBox1.Text.Substring(i, 1));
            }
        }
 
    }
}

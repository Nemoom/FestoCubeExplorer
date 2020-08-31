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
using System.Net.Sockets;
using System.Net;
using Modbus.Device;
using System.Threading;

namespace Festo_Rubik_s_Cube_Explorer
{
    public partial class Form1 : Form
    {
        Form_Manual mForm_Manual;
        public Form1()
        {
            InitializeComponent();
            GlobalVariables.LoadParasFromXML();
            tcpClient_CamU = new TcpClient();
            tcpClient_CamD = new TcpClient();
            tcpClient_CamL = new TcpClient();
            tcpClient_CamR = new TcpClient();
            tcpClient_CamF = new TcpClient();
            tcpClient_CamB = new TcpClient();
            tcpClient_CamU.Connect(new IPEndPoint(IPAddress.Parse(GlobalVariables.CurrentParas.CamU.str_IP), 502));
            tcpClient_CamD.Connect(new IPEndPoint(IPAddress.Parse(GlobalVariables.CurrentParas.CamD.str_IP), 502));
            tcpClient_CamL.Connect(new IPEndPoint(IPAddress.Parse(GlobalVariables.CurrentParas.CamL.str_IP), 502));
            tcpClient_CamR.Connect(new IPEndPoint(IPAddress.Parse(GlobalVariables.CurrentParas.CamR.str_IP), 502));
            tcpClient_CamF.Connect(new IPEndPoint(IPAddress.Parse(GlobalVariables.CurrentParas.CamF.str_IP), 502));
            tcpClient_CamB.Connect(new IPEndPoint(IPAddress.Parse(GlobalVariables.CurrentParas.CamB.str_IP), 502));
            tcpClient_CamU.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            tcpClient_CamD.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            tcpClient_CamL.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            tcpClient_CamR.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            tcpClient_CamF.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            tcpClient_CamB.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            m_Master_CamU = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient_CamU);
            m_Master_CamD = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient_CamD);
            m_Master_CamL = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient_CamL);
            m_Master_CamR = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient_CamR);
            m_Master_CamF = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient_CamF);
            m_Master_CamB = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient_CamB);
            mForm_Manual = new Form_Manual(this);
        }

        public static OpcUaClient m_OpcUaClient;
        public TcpClient tcpClient_CamU;
        public TcpClient tcpClient_CamD;
        public TcpClient tcpClient_CamL;
        public TcpClient tcpClient_CamR;
        public TcpClient tcpClient_CamF;
        public TcpClient tcpClient_CamB;
        public static Modbus.Device.ModbusIpMaster m_Master_CamU;
        public static Modbus.Device.ModbusIpMaster m_Master_CamD;
        public static Modbus.Device.ModbusIpMaster m_Master_CamL;
        public static Modbus.Device.ModbusIpMaster m_Master_CamR;
        public static Modbus.Device.ModbusIpMaster m_Master_CamF; 
        public static Modbus.Device.ModbusIpMaster m_Master_CamB;

        public bool CamError = false;
        public bool CamU_Done = false;
        public bool CamD_Done = false;
        public bool CamL_Done = false;
        public bool CamR_Done = false;
        public bool CamF_Done = false; 
        public bool CamB_Done = false;
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

            button4_Click(sender, e);
            //Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_U, false);
            //Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_D, false);
            //Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_L, false);
            //Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_R, false);
            //Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_F, false);
            //Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_B, false);
            
        }

        private void M_OpcUaClient_OpcStatusChange(object sender, OpcUaStatusEventArgs e)
        {
            if (m_OpcUaClient.Connected)
            {
                InvokeChangeButtonText(button4, "Disconnect");
                //button1.Text = "Disconnect";
             
            }
            else
            {
                InvokeChangeButtonText(button4, "Connect");
                //button1.Text = "Connect";
            }
            //throw new NotImplementedException();
        }
        #region InvokeChangeButtonText
        protected delegate void ChangeButtonTextHandler(Button buttonCtrl, string Txt);
        void InvokeChangeButtonText(Button buttonCtrl, string Txt)
        {
            buttonCtrl.Invoke((ChangeButtonTextHandler)ChangeButtonCtrlText, buttonCtrl, Txt);
        }
        void ChangeButtonCtrlText(Button buttonCtrl, string Txt)
        {
            buttonCtrl.Text = Txt;
        }
        #endregion

        #region InvokeChangeButtonColor
        protected delegate void ChangeButtonColorHandler(Button buttonCtrl, Color Col);
        void InvokeChangeButtonColor(Button buttonCtrl, Color Col)
        {
            buttonCtrl.Invoke((ChangeButtonColorHandler)ChangeButtonCtrlColor, buttonCtrl, Col);
        }
        void ChangeButtonCtrlColor(Button buttonCtrl, Color Col)
        {
            buttonCtrl.BackColor = Col;
        }
        #endregion


        private void M_OpcUaClient_ConnectComplete(object sender, EventArgs e)
        {
            if (Form1.m_OpcUaClient.Connected)
            {
                ResetAllCamTrigger();
                Form_Manual.EmergencyStop();
                Form_Manual.ResetAll();
                Form_Manual.EnableAll();
            }            
            //throw new NotImplementedException();
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

        public void button2_Click(object sender, EventArgs e)
        {
            CamError = false;
            CamU_Done = false;
            CamD_Done = false;
            CamL_Done = false;
            CamR_Done = false;
            CamF_Done = false;
            CamB_Done = false;
            CamTrigger(CamID.CamU);
            CamTrigger(CamID.CamD);
            CamTrigger(CamID.CamL);
            CamTrigger(CamID.CamR);
            CamTrigger(CamID.CamF);
            CamTrigger(CamID.CamB);

            //CamTrigger(CamID.CamU);
            //CamTrigger(CamID.CamD);
            //CamTrigger(CamID.CamL);
            //CamTrigger(CamID.CamR);
            //CamTrigger(CamID.CamF);
            //CamTrigger(CamID.CamB);

            CamTrigger(CamID.CamU);
            CamTrigger(CamID.CamD);
            CamTrigger(CamID.CamL);
            CamTrigger(CamID.CamR);
            CamTrigger(CamID.CamF);
            CamTrigger(CamID.CamB);
            ColorDisplay();
            ////ThreadStart start_CamU = delegate
            ////{
            ////    ColorDisplayU(CamID.CamU);
            ////};
            //Thread tStartCamU = new Thread(new ParameterizedThreadStart(CamColorDisplay));
            //tStartCamU.IsBackground = true;
            //tStartCamU.Priority = ThreadPriority.AboveNormal;
            //tStartCamU.Start(CamID.CamU);

            ////ThreadStart start_CamD = delegate
            ////{
            ////    ColorDisplayD(CamID.CamD);
            ////};
            //Thread tStartCamD = new Thread(new ParameterizedThreadStart(CamColorDisplay));
            //tStartCamD.IsBackground = true;
            //tStartCamD.Priority = ThreadPriority.AboveNormal;
            //tStartCamD.Start(CamID.CamD);

            ////ThreadStart start_CamL = delegate
            ////{
            ////    ColorDisplay(CamID.CamL);
            ////};
            //Thread tStartCamL = new Thread(new ParameterizedThreadStart(CamColorDisplay));
            //tStartCamL.IsBackground = true;
            //tStartCamL.Priority = ThreadPriority.AboveNormal;
            //tStartCamL.Start(CamID.CamL);

            ////ThreadStart start_CamR = delegate
            ////{
            ////    ColorDisplay(CamID.CamR);
            ////};
            //Thread tStartCamR = new Thread(new ParameterizedThreadStart(CamColorDisplay));
            //tStartCamR.IsBackground = true;
            //tStartCamR.Priority = ThreadPriority.AboveNormal;
            //tStartCamR.Start(CamID.CamR);

            ////ThreadStart start_CamF = delegate
            ////{
            ////    ColorDisplay(CamID.CamF);
            ////};
            //Thread tStartCamF = new Thread(new ParameterizedThreadStart(CamColorDisplay));
            //tStartCamF.IsBackground = true;
            //tStartCamF.Priority = ThreadPriority.AboveNormal;
            //tStartCamF.Start(CamID.CamF);

            ////ThreadStart start_CamB = delegate
            ////{
            ////    ColorDisplay(CamID.CamB);
            ////};
            //Thread tStartCamB = new Thread(new ParameterizedThreadStart(CamColorDisplay));
            //tStartCamB.IsBackground = true;
            //tStartCamB.Priority = ThreadPriority.AboveNormal;
            //tStartCamB.Start(CamID.CamB);
            //while (!(CamU_Done && CamD_Done && CamL_Done && CamR_Done && CamF_Done && CamB_Done))
            //{
            //    Thread.Sleep(100);
            //}
            if (!CamError)
            {
                tableLayoutPanel_Cube_DoubleClick(sender, e);//生成魔方颜色描述字符串
                button1_Click(sender, e);//生成解魔方算法
            }
            else
            {
                textBox2.Text = "Unsolvable ";
            }
        }

        /// <summary>
        /// 相机触发
        /// </summary>
        /// <param name="mCamID"></param>
        public static void CamTrigger(CamID mCamID)
        {
            try
            {
                switch (mCamID)
                {
                    case CamID.CamU:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_U, false);
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_U, true);
                        break;
                    case CamID.CamD:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_D, false);
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_D, true);
                        break;
                    case CamID.CamL:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_L, false);
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_L, true);
                        break;
                    case CamID.CamR:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_R, false);
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_R, true);
                        break;
                    case CamID.CamF:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_F, false);
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_F, true);
                        break;
                    case CamID.CamB:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_B, false);
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_B, true);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            #region 放弃：ModbusTCP触发无效
            //ModbusIpMaster m_Master_Cam = null;
            //switch (mCamID)
            //{
            //    case CamID.CamU:
            //        m_Master_Cam = m_Master_CamU;
            //        break;
            //    case CamID.CamD:
            //        m_Master_Cam = m_Master_CamD;
            //        break;
            //    case CamID.CamL:
            //        m_Master_Cam = m_Master_CamL;
            //        break;
            //    case CamID.CamR:
            //        m_Master_Cam = m_Master_CamR;
            //        break;
            //    case CamID.CamF:
            //        m_Master_Cam = m_Master_CamF;
            //        break;
            //    case CamID.CamB:
            //        m_Master_Cam = m_Master_CamB;
            //        break;
            //}
            //if (m_Master_Cam != null)
            //{
            //    try
            //    {
            //        m_Master_Cam.ReadHoldingRegisters(1, 0, 10);
            //        m_Master_Cam.WriteSingleRegister(1, 0, 1);//0:Trigger signal置1
            //        Thread.Sleep(100);                        //延时，等待拍照完成
            //        m_Master_Cam.WriteSingleRegister(1, 0, 0);//0:Trigger signal清0
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //} 
            #endregion
        }

        public static void ResetCamTrigger(CamID mCamID)
        {
            try
            {
                switch (mCamID)
                {
                    case CamID.CamU:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_U, false);
                        break;
                    case CamID.CamD:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_D, false);
                        break;
                    case CamID.CamL:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_L, false);
                        break;
                    case CamID.CamR:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_R, false);
                        break;
                    case CamID.CamF:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_F, false);
                        break;
                    case CamID.CamB:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_B, false);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public static void ResetAllCamTrigger()
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_U, false);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_D, false);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_L, false);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_R, false);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_F, false);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_B, false);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mCamID"></param>
        /// <param name="BlockID">Start from 1</param>
        /// <returns></returns>
        public static Color GetRGBvalue(CamID mCamID, int BlockID)
        {
            Color r_Color = new Color();
            //Color FestoBlue_Light = Color.FromArgb(200, 200, 230, 250);//第1个参数为透明度(alpha)参数,其后为红,绿和蓝.
            //Color FestoBlue = Color.FromArgb(200, 0, 145, 220);//第1个参数为透明度(alpha)参数,其后为红,绿和蓝.
            //Color FestoBlue_Dark = Color.FromArgb(200, 114, 196, 239);//第1个参数为透明度(alpha)参数,其后为红,绿和蓝.
            ModbusIpMaster m_Master_Cam = null;
            switch (mCamID)
            {
                case CamID.CamU:
                    m_Master_Cam = m_Master_CamU;
                    break;
                case CamID.CamD:
                    m_Master_Cam = m_Master_CamD;
                    break;
                case CamID.CamL:
                    m_Master_Cam = m_Master_CamL;
                    break;
                case CamID.CamR:
                    m_Master_Cam = m_Master_CamR;
                    break;
                case CamID.CamF:
                    m_Master_Cam = m_Master_CamF;
                    break;
                case CamID.CamB:
                    m_Master_Cam = m_Master_CamB;
                    break;
            }
            if (m_Master_Cam != null)
            {
                ushort startAddress = (ushort)(10000 + (BlockID - 1) * 3 * 100);
                //ushort[] m_R = m_Master_Cam.ReadHoldingRegisters(1, (ushort)(startAddress + 79), 1);
                //ushort[] m_G = m_Master_Cam.ReadHoldingRegisters(1, (ushort)(startAddress + 179), 1);
                //ushort[] m_B = m_Master_Cam.ReadHoldingRegisters(1, (ushort)(startAddress + 279), 1);
                //r_Color = Color.FromArgb(m_R[0], m_G[0], m_B[0]);
                ushort[] m_R = m_Master_Cam.ReadHoldingRegisters(1, (ushort)(startAddress + 76), 5);
                ushort[] m_G = m_Master_Cam.ReadHoldingRegisters(1, (ushort)(startAddress + 176), 5);
                ushort[] m_B = m_Master_Cam.ReadHoldingRegisters(1, (ushort)(startAddress + 276), 5);
                if (m_R[0] == 1 && m_G[0] == 1 && m_B[0] == 1)
                {
                    r_Color = Color.FromArgb(m_R[3], m_G[3], m_B[3]);
                }
                else
                {
                    r_Color = Color.FromArgb(0,0,0);//返回“黑色”
                }
            }

            //清除6个相机触发的高电平
            try
            {
                switch (mCamID)
                {
                    case CamID.CamU:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_U, false);
                        break;
                    case CamID.CamD:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_D, false);
                        break;
                    case CamID.CamL:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_L, false);
                        break;
                    case CamID.CamR:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_R, false);
                        break;
                    case CamID.CamF:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_F, false);
                        break;
                    case CamID.CamB:
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.CamControl.NodeID_B, false);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return r_Color;
        }

        public static FaceColor ColorMatch(CamID mCamID, Color mColor)
        {
            FaceColor r_FaceColor = 0;
            ColorMatch mColorMatch = new ColorMatch();
            if (mColor.R == 0 && mColor.G == 0 && mColor.B == 0)
            {
                return FaceColor.Black;
            }
            switch (mCamID)
            {
                case CamID.CamU:
                    mColorMatch = GlobalVariables.CurrentParas.CamU.mColorMatch;
                    break;
                case CamID.CamD:
                    mColorMatch = GlobalVariables.CurrentParas.CamD.mColorMatch;
                    break;
                case CamID.CamL:
                    mColorMatch = GlobalVariables.CurrentParas.CamL.mColorMatch;
                    break;
                case CamID.CamR:
                    mColorMatch = GlobalVariables.CurrentParas.CamR.mColorMatch;
                    break;
                case CamID.CamF:
                    mColorMatch = GlobalVariables.CurrentParas.CamF.mColorMatch;
                    break;
                case CamID.CamB:
                    mColorMatch = GlobalVariables.CurrentParas.CamB.mColorMatch;
                    break;
            }
            if (mColor.R >= mColorMatch.c_Red.R_min && mColor.R <= mColorMatch.c_Red.R_max
                && mColor.G >= mColorMatch.c_Red.G_min && mColor.G <= mColorMatch.c_Red.G_max
                && mColor.B >= mColorMatch.c_Red.B_min && mColor.B <= mColorMatch.c_Red.B_max)
            {
                r_FaceColor = FaceColor.Red;
            }
            else if (mColor.R >= mColorMatch.c_Green.R_min && mColor.R <= mColorMatch.c_Green.R_max
                && mColor.G >= mColorMatch.c_Green.G_min && mColor.G <= mColorMatch.c_Green.G_max
                && mColor.B >= mColorMatch.c_Green.B_min && mColor.B <= mColorMatch.c_Green.B_max)
            {
                r_FaceColor = FaceColor.Green;
            }
            else if (mColor.R >= mColorMatch.c_Blue.R_min && mColor.R <= mColorMatch.c_Blue.R_max
                && mColor.G >= mColorMatch.c_Blue.G_min && mColor.G <= mColorMatch.c_Blue.G_max
                && mColor.B >= mColorMatch.c_Blue.B_min && mColor.B <= mColorMatch.c_Blue.B_max)
            {
                r_FaceColor = FaceColor.Blue;
            }
            else if (mColor.R >= mColorMatch.c_White.R_min && mColor.R <= mColorMatch.c_White.R_max
                && mColor.G >= mColorMatch.c_White.G_min && mColor.G <= mColorMatch.c_White.G_max
                && mColor.B >= mColorMatch.c_White.B_min && mColor.B <= mColorMatch.c_White.B_max)
            {
                r_FaceColor = FaceColor.White;
            }
            else if (mColor.R >= mColorMatch.c_Orange.R_min && mColor.R <= mColorMatch.c_Orange.R_max
                && mColor.G >= mColorMatch.c_Orange.G_min && mColor.G <= mColorMatch.c_Orange.G_max
                && mColor.B >= mColorMatch.c_Orange.B_min && mColor.B <= mColorMatch.c_Orange.B_max)
            {
                r_FaceColor = FaceColor.Orange;
            }
            else if (mColor.R >= mColorMatch.c_Yellow.R_min && mColor.R <= mColorMatch.c_Yellow.R_max
              && mColor.G >= mColorMatch.c_Yellow.G_min && mColor.G <= mColorMatch.c_Yellow.G_max
              && mColor.B >= mColorMatch.c_Yellow.B_min && mColor.B <= mColorMatch.c_Yellow.B_max)
            {
                r_FaceColor = FaceColor.Yellow;
            }
            return r_FaceColor;
        }

        /// <summary>
        /// 显示相机原本识别的RGB值
        /// </summary>
        /// <param name="mCamID"></param>
        /// <param name="BlockID"></param>
        /// <param name="mColor"></param>
        public void OriginalColorDisplay(CamID mCamID, int BlockID, Color mColor)
        {
            Button mBtn = new Button();
            switch (mCamID)
            {
                case CamID.CamU:
                    switch (BlockID)
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
                    }
                    break;
                case CamID.CamD:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_D1;
                            break;
                        case 2:
                            mBtn = btn_D2;
                            break;
                        case 3:
                            mBtn = btn_D3;
                            break;
                        case 4:
                            mBtn = btn_D4;
                            break;
                        case 5:
                            mBtn = btn_D5;
                            break;
                        case 6:
                            mBtn = btn_D6;
                            break;
                        case 7:
                            mBtn = btn_D7;
                            break;
                        case 8:
                            mBtn = btn_D8;
                            break;
                        case 9:
                            mBtn = btn_D9;
                            break;
                    }
                    break;
                case CamID.CamL:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_L1;
                            break;
                        case 2:
                            mBtn = btn_L2;
                            break;
                        case 3:
                            mBtn = btn_L3;
                            break;
                        case 4:
                            mBtn = btn_L4;
                            break;
                        case 5:
                            mBtn = btn_L5;
                            break;
                        case 6:
                            mBtn = btn_L6;
                            break;
                        case 7:
                            mBtn = btn_L7;
                            break;
                        case 8:
                            mBtn = btn_L8;
                            break;
                        case 9:
                            mBtn = btn_L9;
                            break;
                    }
                    break;
                case CamID.CamR:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_R1;
                            break;
                        case 2:
                            mBtn = btn_R2;
                            break;
                        case 3:
                            mBtn = btn_R3;
                            break;
                        case 4:
                            mBtn = btn_R4;
                            break;
                        case 5:
                            mBtn = btn_R5;
                            break;
                        case 6:
                            mBtn = btn_R6;
                            break;
                        case 7:
                            mBtn = btn_R7;
                            break;
                        case 8:
                            mBtn = btn_R8;
                            break;
                        case 9:
                            mBtn = btn_R9;
                            break;
                    }
                    break;
                case CamID.CamF:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_F1;
                            break;
                        case 2:
                            mBtn = btn_F2;
                            break;
                        case 3:
                            mBtn = btn_F3;
                            break;
                        case 4:
                            mBtn = btn_F4;
                            break;
                        case 5:
                            mBtn = btn_F5;
                            break;
                        case 6:
                            mBtn = btn_F6;
                            break;
                        case 7:
                            mBtn = btn_F7;
                            break;
                        case 8:
                            mBtn = btn_F8;
                            break;
                        case 9:
                            mBtn = btn_F9;
                            break;
                    }
                    break;
                case CamID.CamB:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_B1;
                            break;
                        case 2:
                            mBtn = btn_B2;
                            break;
                        case 3:
                            mBtn = btn_B3;
                            break;
                        case 4:
                            mBtn = btn_B4;
                            break;
                        case 5:
                            mBtn = btn_B5;
                            break;
                        case 6:
                            mBtn = btn_B6;
                            break;
                        case 7:
                            mBtn = btn_B7;
                            break;
                        case 8:
                            mBtn = btn_B8;
                            break;
                        case 9:
                            mBtn = btn_B9;
                            break;
                    }
                    break;
            }
            mBtn.BackColor = mColor;
        }

        /// <summary>
        /// 显示为匹配到的颜色
        /// </summary>
        /// <param name="mCamID"></param>
        /// <param name="BlockID"></param>
        /// <param name="mFaceColor"></param>
        public void ColorDisplay(CamID mCamID, int BlockID, FaceColor mFaceColor)
        {
            Button mBtn = new Button();
            switch (mCamID)
            {
                case CamID.CamU:
                    switch (BlockID)
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
                    }
                    break;
                case CamID.CamD:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_D1;
                            break;
                        case 2:
                            mBtn = btn_D2;
                            break;
                        case 3:
                            mBtn = btn_D3;
                            break;
                        case 4:
                            mBtn = btn_D4;
                            break;
                        case 5:
                            mBtn = btn_D5;
                            break;
                        case 6:
                            mBtn = btn_D6;
                            break;
                        case 7:
                            mBtn = btn_D7;
                            break;
                        case 8:
                            mBtn = btn_D8;
                            break;
                        case 9:
                            mBtn = btn_D9;
                            break;
                    }
                    break;
                case CamID.CamL:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_L1;
                            break;
                        case 2:
                            mBtn = btn_L2;
                            break;
                        case 3:
                            mBtn = btn_L3;
                            break;
                        case 4:
                            mBtn = btn_L4;
                            break;
                        case 5:
                            mBtn = btn_L5;
                            break;
                        case 6:
                            mBtn = btn_L6;
                            break;
                        case 7:
                            mBtn = btn_L7;
                            break;
                        case 8:
                            mBtn = btn_L8;
                            break;
                        case 9:
                            mBtn = btn_L9;
                            break;
                    }
                    break;
                case CamID.CamR:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_R1;
                            break;
                        case 2:
                            mBtn = btn_R2;
                            break;
                        case 3:
                            mBtn = btn_R3;
                            break;
                        case 4:
                            mBtn = btn_R4;
                            break;
                        case 5:
                            mBtn = btn_R5;
                            break;
                        case 6:
                            mBtn = btn_R6;
                            break;
                        case 7:
                            mBtn = btn_R7;
                            break;
                        case 8:
                            mBtn = btn_R8;
                            break;
                        case 9:
                            mBtn = btn_R9;
                            break;
                    }
                    break;
                case CamID.CamF:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_F1;
                            break;
                        case 2:
                            mBtn = btn_F2;
                            break;
                        case 3:
                            mBtn = btn_F3;
                            break;
                        case 4:
                            mBtn = btn_F4;
                            break;
                        case 5:
                            mBtn = btn_F5;
                            break;
                        case 6:
                            mBtn = btn_F6;
                            break;
                        case 7:
                            mBtn = btn_F7;
                            break;
                        case 8:
                            mBtn = btn_F8;
                            break;
                        case 9:
                            mBtn = btn_F9;
                            break;
                    }
                    break;
                case CamID.CamB:
                    switch (BlockID)
                    {
                        case 1:
                            mBtn = btn_B1;
                            break;
                        case 2:
                            mBtn = btn_B2;
                            break;
                        case 3:
                            mBtn = btn_B3;
                            break;
                        case 4:
                            mBtn = btn_B4;
                            break;
                        case 5:
                            mBtn = btn_B5;
                            break;
                        case 6:
                            mBtn = btn_B6;
                            break;
                        case 7:
                            mBtn = btn_B7;
                            break;
                        case 8:
                            mBtn = btn_B8;
                            break;
                        case 9:
                            mBtn = btn_B9;
                            break;
                    }
                    break;
            }
            switch (mFaceColor)
            {
                case FaceColor.Red:
                    InvokeChangeButtonColor(mBtn, Color.Red);
                    //mBtn.BackColor = Color.Red;
                    break;
                case FaceColor.Green:
                    InvokeChangeButtonColor(mBtn, Color.Green);
                    //mBtn.BackColor = Color.Green;
                    break;
                case FaceColor.Blue:
                    InvokeChangeButtonColor(mBtn, Color.Blue);
                    //mBtn.BackColor = Color.Blue;
                    break;
                case FaceColor.White:
                    InvokeChangeButtonColor(mBtn, Color.White);
                    //mBtn.BackColor = Color.White;
                    break;
                case FaceColor.Orange:
                    InvokeChangeButtonColor(mBtn, Color.Orange);
                    //mBtn.BackColor = Color.Orange;
                    break;
                case FaceColor.Yellow:
                    InvokeChangeButtonColor(mBtn, Color.Yellow);
                    //mBtn.BackColor = Color.Yellow;
                    break;
                default:
                    InvokeChangeButtonColor(mBtn, Color.Black);
                    CamError = true;
                    //mBtn.BackColor = Color.Black;
                    break;
            }
        }

        public void OriginalColorDisplay()
        {
            OriginalColorDisplay(CamID.CamU, 1, GetRGBvalue(CamID.CamU, 9));
            OriginalColorDisplay(CamID.CamU, 2, GetRGBvalue(CamID.CamU, 8));
            OriginalColorDisplay(CamID.CamU, 3, GetRGBvalue(CamID.CamU, 7));
            OriginalColorDisplay(CamID.CamU, 4, GetRGBvalue(CamID.CamU, 6));
            OriginalColorDisplay(CamID.CamU, 5, GetRGBvalue(CamID.CamU, 5));
            OriginalColorDisplay(CamID.CamU, 6, GetRGBvalue(CamID.CamU, 4));
            OriginalColorDisplay(CamID.CamU, 7, GetRGBvalue(CamID.CamU, 3));
            OriginalColorDisplay(CamID.CamU, 8, GetRGBvalue(CamID.CamU, 2));
            OriginalColorDisplay(CamID.CamU, 9, GetRGBvalue(CamID.CamU, 1));

            OriginalColorDisplay(CamID.CamD, 1, GetRGBvalue(CamID.CamD, 1));
            OriginalColorDisplay(CamID.CamD, 2, GetRGBvalue(CamID.CamD, 2));
            OriginalColorDisplay(CamID.CamD, 3, GetRGBvalue(CamID.CamD, 3));
            OriginalColorDisplay(CamID.CamD, 4, GetRGBvalue(CamID.CamD, 4));
            OriginalColorDisplay(CamID.CamD, 5, GetRGBvalue(CamID.CamD, 5));
            OriginalColorDisplay(CamID.CamD, 6, GetRGBvalue(CamID.CamD, 6));
            OriginalColorDisplay(CamID.CamD, 7, GetRGBvalue(CamID.CamD, 7));
            OriginalColorDisplay(CamID.CamD, 8, GetRGBvalue(CamID.CamD, 8));
            OriginalColorDisplay(CamID.CamD, 9, GetRGBvalue(CamID.CamD, 9));

            OriginalColorDisplay(CamID.CamL, 1, GetRGBvalue(CamID.CamL, 1));
            OriginalColorDisplay(CamID.CamL, 2, GetRGBvalue(CamID.CamL, 2));
            OriginalColorDisplay(CamID.CamL, 3, GetRGBvalue(CamID.CamL, 3));
            OriginalColorDisplay(CamID.CamL, 4, GetRGBvalue(CamID.CamL, 4));
            OriginalColorDisplay(CamID.CamL, 5, GetRGBvalue(CamID.CamL, 5));
            OriginalColorDisplay(CamID.CamL, 6, GetRGBvalue(CamID.CamL, 6));
            OriginalColorDisplay(CamID.CamL, 7, GetRGBvalue(CamID.CamL, 7));
            OriginalColorDisplay(CamID.CamL, 8, GetRGBvalue(CamID.CamL, 8));
            OriginalColorDisplay(CamID.CamL, 9, GetRGBvalue(CamID.CamL, 9));

            OriginalColorDisplay(CamID.CamR, 1, GetRGBvalue(CamID.CamR, 1));
            OriginalColorDisplay(CamID.CamR, 2, GetRGBvalue(CamID.CamR, 2));
            OriginalColorDisplay(CamID.CamR, 3, GetRGBvalue(CamID.CamR, 3));
            OriginalColorDisplay(CamID.CamR, 4, GetRGBvalue(CamID.CamR, 4));
            OriginalColorDisplay(CamID.CamR, 5, GetRGBvalue(CamID.CamR, 5));
            OriginalColorDisplay(CamID.CamR, 6, GetRGBvalue(CamID.CamR, 6));
            OriginalColorDisplay(CamID.CamR, 7, GetRGBvalue(CamID.CamR, 7));
            OriginalColorDisplay(CamID.CamR, 8, GetRGBvalue(CamID.CamR, 8));
            OriginalColorDisplay(CamID.CamR, 9, GetRGBvalue(CamID.CamR, 9));

            OriginalColorDisplay(CamID.CamF, 1, GetRGBvalue(CamID.CamF, 1));
            OriginalColorDisplay(CamID.CamF, 2, GetRGBvalue(CamID.CamF, 2));
            OriginalColorDisplay(CamID.CamF, 3, GetRGBvalue(CamID.CamF, 3));
            OriginalColorDisplay(CamID.CamF, 4, GetRGBvalue(CamID.CamF, 4));
            OriginalColorDisplay(CamID.CamF, 5, GetRGBvalue(CamID.CamF, 5));
            OriginalColorDisplay(CamID.CamF, 6, GetRGBvalue(CamID.CamF, 6));
            OriginalColorDisplay(CamID.CamF, 7, GetRGBvalue(CamID.CamF, 7));
            OriginalColorDisplay(CamID.CamF, 8, GetRGBvalue(CamID.CamF, 8));
            OriginalColorDisplay(CamID.CamF, 9, GetRGBvalue(CamID.CamF, 9));

            OriginalColorDisplay(CamID.CamB, 1, GetRGBvalue(CamID.CamB, 1));
            OriginalColorDisplay(CamID.CamB, 2, GetRGBvalue(CamID.CamB, 2));
            OriginalColorDisplay(CamID.CamB, 3, GetRGBvalue(CamID.CamB, 3));
            OriginalColorDisplay(CamID.CamB, 4, GetRGBvalue(CamID.CamB, 4));
            OriginalColorDisplay(CamID.CamB, 5, GetRGBvalue(CamID.CamB, 5));
            OriginalColorDisplay(CamID.CamB, 6, GetRGBvalue(CamID.CamB, 6));
            OriginalColorDisplay(CamID.CamB, 7, GetRGBvalue(CamID.CamB, 7));
            OriginalColorDisplay(CamID.CamB, 8, GetRGBvalue(CamID.CamB, 8));
            OriginalColorDisplay(CamID.CamB, 9, GetRGBvalue(CamID.CamB, 9));
        }

        public void ColorDisplay()
        {
            ColorDisplay(CamID.CamU, 1, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 9)));
            ColorDisplay(CamID.CamU, 2, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 8)));
            ColorDisplay(CamID.CamU, 3, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 7)));
            ColorDisplay(CamID.CamU, 4, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 6)));
            ColorDisplay(CamID.CamU, 5, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 5)));
            ColorDisplay(CamID.CamU, 6, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 4)));
            ColorDisplay(CamID.CamU, 7, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 3)));
            ColorDisplay(CamID.CamU, 8, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 2)));
            ColorDisplay(CamID.CamU, 9, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 1)));
       
            ColorDisplay(CamID.CamD, 1, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 1)));
            ColorDisplay(CamID.CamD, 2, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 2)));
            ColorDisplay(CamID.CamD, 3, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 3)));
            ColorDisplay(CamID.CamD, 4, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 4)));
            ColorDisplay(CamID.CamD, 5, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 5)));
            ColorDisplay(CamID.CamD, 6, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 6)));
            ColorDisplay(CamID.CamD, 7, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 7)));
            ColorDisplay(CamID.CamD, 8, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 8)));
            ColorDisplay(CamID.CamD, 9, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 9)));

            ColorDisplay(CamID.CamL, 1, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 1)));
            ColorDisplay(CamID.CamL, 2, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 2)));
            ColorDisplay(CamID.CamL, 3, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 3)));
            ColorDisplay(CamID.CamL, 4, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 4)));
            ColorDisplay(CamID.CamL, 5, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 5)));
            ColorDisplay(CamID.CamL, 6, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 6)));
            ColorDisplay(CamID.CamL, 7, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 7)));
            ColorDisplay(CamID.CamL, 8, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 8)));
            ColorDisplay(CamID.CamL, 9, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 9)));
                                       
            ColorDisplay(CamID.CamR, 1, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 1)));
            ColorDisplay(CamID.CamR, 2, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 2)));
            ColorDisplay(CamID.CamR, 3, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 3)));
            ColorDisplay(CamID.CamR, 4, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 4)));
            ColorDisplay(CamID.CamR, 5, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 5)));
            ColorDisplay(CamID.CamR, 6, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 6)));
            ColorDisplay(CamID.CamR, 7, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 7)));
            ColorDisplay(CamID.CamR, 8, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 8)));
            ColorDisplay(CamID.CamR, 9, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 9)));
                                        
            ColorDisplay(CamID.CamF, 1, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 1)));
            ColorDisplay(CamID.CamF, 2, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 2)));
            ColorDisplay(CamID.CamF, 3, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 3)));
            ColorDisplay(CamID.CamF, 4, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 4)));
            ColorDisplay(CamID.CamF, 5, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 5)));
            ColorDisplay(CamID.CamF, 6, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 6)));
            ColorDisplay(CamID.CamF, 7, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 7)));
            ColorDisplay(CamID.CamF, 8, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 8)));
            ColorDisplay(CamID.CamF, 9, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 9)));
                                        
            ColorDisplay(CamID.CamB, 1, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 1)));
            ColorDisplay(CamID.CamB, 2, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 2)));
            ColorDisplay(CamID.CamB, 3, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 3)));
            ColorDisplay(CamID.CamB, 4, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 4)));
            ColorDisplay(CamID.CamB, 5, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 5)));
            ColorDisplay(CamID.CamB, 6, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 6)));
            ColorDisplay(CamID.CamB, 7, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 7)));
            ColorDisplay(CamID.CamB, 8, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 8)));
            ColorDisplay(CamID.CamB, 9, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 9)));
        }

        public void CamColorDisplay(object mCamID)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    ColorDisplay(CamID.CamU, 1, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 9)));
                    ColorDisplay(CamID.CamU, 2, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 8)));
                    ColorDisplay(CamID.CamU, 3, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 7)));
                    ColorDisplay(CamID.CamU, 4, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 6)));
                    ColorDisplay(CamID.CamU, 5, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 5)));
                    ColorDisplay(CamID.CamU, 6, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 4)));
                    ColorDisplay(CamID.CamU, 7, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 3)));
                    ColorDisplay(CamID.CamU, 8, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 2)));
                    ColorDisplay(CamID.CamU, 9, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 1)));
                    CamU_Done = true;                  
                    break;
                case CamID.CamD:
                    ColorDisplay(CamID.CamD, 1, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 1)));
                    ColorDisplay(CamID.CamD, 2, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 2)));
                    ColorDisplay(CamID.CamD, 3, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 3)));
                    ColorDisplay(CamID.CamD, 4, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 4)));
                    ColorDisplay(CamID.CamD, 5, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 5)));
                    ColorDisplay(CamID.CamD, 6, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 6)));
                    ColorDisplay(CamID.CamD, 7, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 7)));
                    ColorDisplay(CamID.CamD, 8, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 8)));
                    ColorDisplay(CamID.CamD, 9, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 9)));
                    CamD_Done = true;
                    break;
                case CamID.CamL:
                    ColorDisplay(CamID.CamL, 1, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 1)));
                    ColorDisplay(CamID.CamL, 2, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 2)));
                    ColorDisplay(CamID.CamL, 3, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 3)));
                    ColorDisplay(CamID.CamL, 4, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 4)));
                    ColorDisplay(CamID.CamL, 5, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 5)));
                    ColorDisplay(CamID.CamL, 6, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 6)));
                    ColorDisplay(CamID.CamL, 7, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 7)));
                    ColorDisplay(CamID.CamL, 8, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 8)));
                    ColorDisplay(CamID.CamL, 9, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 9)));
                    CamL_Done = true;
                    break;
                case CamID.CamR:
                    ColorDisplay(CamID.CamR, 1, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 1)));
                    ColorDisplay(CamID.CamR, 2, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 2)));
                    ColorDisplay(CamID.CamR, 3, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 3)));
                    ColorDisplay(CamID.CamR, 4, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 4)));
                    ColorDisplay(CamID.CamR, 5, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 5)));
                    ColorDisplay(CamID.CamR, 6, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 6)));
                    ColorDisplay(CamID.CamR, 7, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 7)));
                    ColorDisplay(CamID.CamR, 8, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 8)));
                    ColorDisplay(CamID.CamR, 9, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 9)));
                    CamR_Done = true;
                    break;
                case CamID.CamF:
                    ColorDisplay(CamID.CamF, 1, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 1)));
                    ColorDisplay(CamID.CamF, 2, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 2)));
                    ColorDisplay(CamID.CamF, 3, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 3)));
                    ColorDisplay(CamID.CamF, 4, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 4)));
                    ColorDisplay(CamID.CamF, 5, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 5)));
                    ColorDisplay(CamID.CamF, 6, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 6)));
                    ColorDisplay(CamID.CamF, 7, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 7)));
                    ColorDisplay(CamID.CamF, 8, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 8)));
                    ColorDisplay(CamID.CamF, 9, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 9)));
                    CamF_Done = true;
                    break;
                case CamID.CamB:
                    ColorDisplay(CamID.CamB, 1, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 1)));
                    ColorDisplay(CamID.CamB, 2, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 2)));
                    ColorDisplay(CamID.CamB, 3, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 3)));
                    ColorDisplay(CamID.CamB, 4, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 4)));
                    ColorDisplay(CamID.CamB, 5, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 5)));
                    ColorDisplay(CamID.CamB, 6, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 6)));
                    ColorDisplay(CamID.CamB, 7, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 7)));
                    ColorDisplay(CamID.CamB, 8, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 8)));
                    ColorDisplay(CamID.CamB, 9, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 9)));
                    CamB_Done = true;
                    break;
                default:
                    break;
            }           
        }
        public void ColorDisplayU(CamID mCamID)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    ColorDisplay(CamID.CamU, 1, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 9)));
                    ColorDisplay(CamID.CamU, 2, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 8)));
                    ColorDisplay(CamID.CamU, 3, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 7)));
                    ColorDisplay(CamID.CamU, 4, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 6)));
                    ColorDisplay(CamID.CamU, 5, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 5)));
                    ColorDisplay(CamID.CamU, 6, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 4)));
                    ColorDisplay(CamID.CamU, 7, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 3)));
                    ColorDisplay(CamID.CamU, 8, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 2)));
                    ColorDisplay(CamID.CamU, 9, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 1)));
                    CamU_Done = true;
                    break;
                case CamID.CamD:
                    ColorDisplay(CamID.CamD, 1, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 1)));
                    ColorDisplay(CamID.CamD, 2, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 2)));
                    ColorDisplay(CamID.CamD, 3, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 3)));
                    ColorDisplay(CamID.CamD, 4, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 4)));
                    ColorDisplay(CamID.CamD, 5, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 5)));
                    ColorDisplay(CamID.CamD, 6, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 6)));
                    ColorDisplay(CamID.CamD, 7, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 7)));
                    ColorDisplay(CamID.CamD, 8, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 8)));
                    ColorDisplay(CamID.CamD, 9, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 9)));
                    CamD_Done = true;
                    break;
                case CamID.CamL:
                    ColorDisplay(CamID.CamL, 1, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 1)));
                    ColorDisplay(CamID.CamL, 2, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 2)));
                    ColorDisplay(CamID.CamL, 3, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 3)));
                    ColorDisplay(CamID.CamL, 4, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 4)));
                    ColorDisplay(CamID.CamL, 5, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 5)));
                    ColorDisplay(CamID.CamL, 6, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 6)));
                    ColorDisplay(CamID.CamL, 7, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 7)));
                    ColorDisplay(CamID.CamL, 8, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 8)));
                    ColorDisplay(CamID.CamL, 9, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 9)));
                    CamL_Done = true;
                    break;
                case CamID.CamR:
                    ColorDisplay(CamID.CamR, 1, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 1)));
                    ColorDisplay(CamID.CamR, 2, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 2)));
                    ColorDisplay(CamID.CamR, 3, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 3)));
                    ColorDisplay(CamID.CamR, 4, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 4)));
                    ColorDisplay(CamID.CamR, 5, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 5)));
                    ColorDisplay(CamID.CamR, 6, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 6)));
                    ColorDisplay(CamID.CamR, 7, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 7)));
                    ColorDisplay(CamID.CamR, 8, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 8)));
                    ColorDisplay(CamID.CamR, 9, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 9)));
                    CamR_Done = true;
                    break;
                case CamID.CamF:
                    ColorDisplay(CamID.CamF, 1, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 1)));
                    ColorDisplay(CamID.CamF, 2, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 2)));
                    ColorDisplay(CamID.CamF, 3, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 3)));
                    ColorDisplay(CamID.CamF, 4, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 4)));
                    ColorDisplay(CamID.CamF, 5, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 5)));
                    ColorDisplay(CamID.CamF, 6, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 6)));
                    ColorDisplay(CamID.CamF, 7, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 7)));
                    ColorDisplay(CamID.CamF, 8, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 8)));
                    ColorDisplay(CamID.CamF, 9, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 9)));
                    CamF_Done = true;
                    break;
                case CamID.CamB:
                    ColorDisplay(CamID.CamB, 1, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 1)));
                    ColorDisplay(CamID.CamB, 2, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 2)));
                    ColorDisplay(CamID.CamB, 3, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 3)));
                    ColorDisplay(CamID.CamB, 4, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 4)));
                    ColorDisplay(CamID.CamB, 5, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 5)));
                    ColorDisplay(CamID.CamB, 6, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 6)));
                    ColorDisplay(CamID.CamB, 7, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 7)));
                    ColorDisplay(CamID.CamB, 8, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 8)));
                    ColorDisplay(CamID.CamB, 9, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 9)));
                    CamB_Done = true;
                    break;
                default:
                    break;
            }
        }
        public void ColorDisplayD(CamID mCamID)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    ColorDisplay(CamID.CamU, 1, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 9)));
                    ColorDisplay(CamID.CamU, 2, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 8)));
                    ColorDisplay(CamID.CamU, 3, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 7)));
                    ColorDisplay(CamID.CamU, 4, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 6)));
                    ColorDisplay(CamID.CamU, 5, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 5)));
                    ColorDisplay(CamID.CamU, 6, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 4)));
                    ColorDisplay(CamID.CamU, 7, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 3)));
                    ColorDisplay(CamID.CamU, 8, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 2)));
                    ColorDisplay(CamID.CamU, 9, ColorMatch(CamID.CamU, GetRGBvalue(CamID.CamU, 1)));
                    CamU_Done = true;
                    break;
                case CamID.CamD:
                    ColorDisplay(CamID.CamD, 1, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 1)));
                    ColorDisplay(CamID.CamD, 2, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 2)));
                    ColorDisplay(CamID.CamD, 3, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 3)));
                    ColorDisplay(CamID.CamD, 4, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 4)));
                    ColorDisplay(CamID.CamD, 5, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 5)));
                    ColorDisplay(CamID.CamD, 6, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 6)));
                    ColorDisplay(CamID.CamD, 7, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 7)));
                    ColorDisplay(CamID.CamD, 8, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 8)));
                    ColorDisplay(CamID.CamD, 9, ColorMatch(CamID.CamD, GetRGBvalue(CamID.CamD, 9)));
                    CamD_Done = true;
                    break;
                case CamID.CamL:
                    ColorDisplay(CamID.CamL, 1, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 1)));
                    ColorDisplay(CamID.CamL, 2, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 2)));
                    ColorDisplay(CamID.CamL, 3, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 3)));
                    ColorDisplay(CamID.CamL, 4, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 4)));
                    ColorDisplay(CamID.CamL, 5, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 5)));
                    ColorDisplay(CamID.CamL, 6, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 6)));
                    ColorDisplay(CamID.CamL, 7, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 7)));
                    ColorDisplay(CamID.CamL, 8, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 8)));
                    ColorDisplay(CamID.CamL, 9, ColorMatch(CamID.CamL, GetRGBvalue(CamID.CamL, 9)));
                    CamL_Done = true;
                    break;
                case CamID.CamR:
                    ColorDisplay(CamID.CamR, 1, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 1)));
                    ColorDisplay(CamID.CamR, 2, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 2)));
                    ColorDisplay(CamID.CamR, 3, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 3)));
                    ColorDisplay(CamID.CamR, 4, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 4)));
                    ColorDisplay(CamID.CamR, 5, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 5)));
                    ColorDisplay(CamID.CamR, 6, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 6)));
                    ColorDisplay(CamID.CamR, 7, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 7)));
                    ColorDisplay(CamID.CamR, 8, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 8)));
                    ColorDisplay(CamID.CamR, 9, ColorMatch(CamID.CamR, GetRGBvalue(CamID.CamR, 9)));
                    CamR_Done = true;
                    break;
                case CamID.CamF:
                    ColorDisplay(CamID.CamF, 1, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 1)));
                    ColorDisplay(CamID.CamF, 2, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 2)));
                    ColorDisplay(CamID.CamF, 3, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 3)));
                    ColorDisplay(CamID.CamF, 4, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 4)));
                    ColorDisplay(CamID.CamF, 5, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 5)));
                    ColorDisplay(CamID.CamF, 6, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 6)));
                    ColorDisplay(CamID.CamF, 7, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 7)));
                    ColorDisplay(CamID.CamF, 8, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 8)));
                    ColorDisplay(CamID.CamF, 9, ColorMatch(CamID.CamF, GetRGBvalue(CamID.CamF, 9)));
                    CamF_Done = true;
                    break;
                case CamID.CamB:
                    ColorDisplay(CamID.CamB, 1, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 1)));
                    ColorDisplay(CamID.CamB, 2, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 2)));
                    ColorDisplay(CamID.CamB, 3, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 3)));
                    ColorDisplay(CamID.CamB, 4, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 4)));
                    ColorDisplay(CamID.CamB, 5, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 5)));
                    ColorDisplay(CamID.CamB, 6, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 6)));
                    ColorDisplay(CamID.CamB, 7, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 7)));
                    ColorDisplay(CamID.CamB, 8, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 8)));
                    ColorDisplay(CamID.CamB, 9, ColorMatch(CamID.CamB, GetRGBvalue(CamID.CamB, 9)));
                    CamB_Done = true;
                    break;
                default:
                    break;
            }
        }


        public void SendResult2PLC()
        {
            string[] mCubeResult = textBox2.Text.Split(' ');
            string[] mCubeResult_Send = new string[21];
            for (int i = 0; i < mCubeResult.Length; i++)
            {
                mCubeResult_Send[i] = mCubeResult[i];
            }
            bool success = m_OpcUaClient.WriteNodes(new string[] {
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step1,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step2,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step3,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step4,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step5,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step6,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step7,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step8,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step9,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step10,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step11,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step12,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step13,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step14,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step15,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step16,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step17,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step18,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step19,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step20,
                GlobalVariables.CurrentParas.mPLC.CubeResult.NodeID_Step21 },        
           new object[] {
            mCubeResult_Send[0],
            mCubeResult_Send[1],
            mCubeResult_Send[2],
            mCubeResult_Send[3],
            mCubeResult_Send[4],
            mCubeResult_Send[5],
            mCubeResult_Send[6],
            mCubeResult_Send[7],
            mCubeResult_Send[8],
            mCubeResult_Send[9],
            mCubeResult_Send[10],
            mCubeResult_Send[11],
            mCubeResult_Send[12],
            mCubeResult_Send[13],
            mCubeResult_Send[14],
            mCubeResult_Send[15],
            mCubeResult_Send[16],
            mCubeResult_Send[17],
            mCubeResult_Send[18],
            mCubeResult_Send[19],
            mCubeResult_Send[20],
            mCubeResult_Send[21],
           });
            if (success)
            {
                // 写入成功
            }
            else
            {
                // 写入失败，一个失败即为失败
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mForm_Manual.Show();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                await m_OpcUaClient.ConnectServer("opc.tcp://" + GlobalVariables.CurrentParas.mPLC.str_IP + ":4840");

            }
            catch (Exception ex)
            {
                ClientUtils.HandleException("Connected Failed", ex);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            mForm_Manual.btn_Start_Click(sender, e);
        }
    }
}

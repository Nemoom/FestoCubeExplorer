using Opc.Ua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Festo_Rubik_s_Cube_Explorer
{
    public partial class Form_Manual : Form
    {
        public Form_Manual()
        {
            InitializeComponent();
        }
        #region tabPage_Cam
        public static void updateLightStatus()
        {
            #region 更新所有光源的状态
            try
            {
                List<string> tags = new List<string>();
                tags.Add(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_U);
                tags.Add(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_D);
                tags.Add(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_L);
                tags.Add(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_R);
                tags.Add(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_F);
                tags.Add(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_B);

                // 按照顺序定义的值
                List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());

                if (values[0])
                {
                    GlobalVariables.lightStatus.o_U = true;
                }
                else
                {
                    GlobalVariables.lightStatus.o_U = false;
                }
                if (values[1])
                {
                    GlobalVariables.lightStatus.o_D = true;
                }
                else
                {
                    GlobalVariables.lightStatus.o_D = false;
                }
                if (values[2])
                {
                    GlobalVariables.lightStatus.o_L = true;
                }
                else
                {
                    GlobalVariables.lightStatus.o_L = false;
                }
                if (values[3])
                {
                    GlobalVariables.lightStatus.o_R = true;
                }
                else
                {
                    GlobalVariables.lightStatus.o_R = false;
                }
                if (values[4])
                {
                    GlobalVariables.lightStatus.o_F = true;
                }
                else
                {
                    GlobalVariables.lightStatus.o_F = false;
                }
                if (values[5])
                {
                    GlobalVariables.lightStatus.o_B = true;
                }
                else
                {
                    GlobalVariables.lightStatus.o_B = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }
        private void btn_ColorLearning_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning().Show();
        }

        private void btn_L8_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("L").Show();
        }

        private void btn_L2_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("L").Show();
        }

        private void btn_L3_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("L").Show();
        }

        private void btn_L4_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("L").Show();
        }

        private void btn_L5_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("L").Show();
        }

        private void btn_L6_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("L").Show();
        }

        private void btn_L7_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("L").Show();
        }

        private void btn_L1_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("L").Show();
        }

        private void btn_L9_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("L").Show();
        }
        private void pic_L_U_Click(object sender, EventArgs e)
        {
            updateLightStatus();
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_U, !GlobalVariables.lightStatus.o_U);
            updateLightStatus();
            if (GlobalVariables.lightStatus.o_U)
            {
                pic_L_U.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_U.Image = imageList1.Images[0];
            }
        }

        private void pic_L_L_Click(object sender, EventArgs e)
        {
            updateLightStatus();
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_L, !GlobalVariables.lightStatus.o_L);
            updateLightStatus();
            if (GlobalVariables.lightStatus.o_L)
            {
                pic_L_L.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_L.Image = imageList1.Images[0];
            }
        }

        private void pic_L_F_Click(object sender, EventArgs e)
        {
            updateLightStatus();
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_F, !GlobalVariables.lightStatus.o_F);
            updateLightStatus();
            if (GlobalVariables.lightStatus.o_F)
            {
                pic_L_F.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_F.Image = imageList1.Images[0];
            }
        }

        private void pic_L_R_Click(object sender, EventArgs e)
        {
            updateLightStatus();
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_R, !GlobalVariables.lightStatus.o_R);
            updateLightStatus();
            if (GlobalVariables.lightStatus.o_R)
            {
                pic_L_R.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_R.Image = imageList1.Images[0];
            }
        }

        private void pic_L_B_Click(object sender, EventArgs e)
        {
            updateLightStatus();
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_B, !GlobalVariables.lightStatus.o_B);
            updateLightStatus();
            if (GlobalVariables.lightStatus.o_B)
            {
                pic_L_B.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_B.Image = imageList1.Images[0];
            }
        }

        private void pic_L_D_Click(object sender, EventArgs e)
        {
            updateLightStatus();
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_D, !GlobalVariables.lightStatus.o_D);
            updateLightStatus();
            if (GlobalVariables.lightStatus.o_D)
            {
                pic_L_D.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_D.Image = imageList1.Images[0];
            }
        }

        #endregion

        #region tabPage_Step
        public static void AllLightOn()
        {
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_U, true);
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_D, true);
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_L, true);
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_R, true);
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_F, true);
            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_B, true);
        }
        public static void AllLightOff()
        {
            Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_U,
        GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_D,
        GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_L,
        GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_R,
        GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_F,
        GlobalVariables.CurrentParas.mPLC.LightControl.NodeID_B},
        new object[] { false, false, false, false, false, false });
        }
        public static bool IOlinkAxisIn(string AxisID)
        {
            IOlinkNodeID mIOlinkNodeID = new IOlinkNodeID();
            switch (AxisID)
            {
                case "IOlink_Rotate":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_Rotate;
                    break;
                case "IOlink_F_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam;
                    break;
                case "IOlink_B_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam;
                    break;
                case "IOlink_L_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam;
                    break;
                case "IOlink_R_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam;
                    break;
                case "IOlink_D_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam;
                    break;
                case "IOlink_F_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab;
                    break;
                case "IOlink_B_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab;
                    break;
                case "IOlink_L_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab;
                    break;
                case "IOlink_R_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab;
                    break;
                default:
                    break;
            }

            try
            {
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_Out, false);
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_In, true);
                while (!Form1.m_OpcUaClient.ReadNode<bool>(mIOlinkNodeID.NodeID_i_In))
                {
                    Thread.Sleep(100);
                }
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_In, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }
        public static bool IOlinkAxisOut(string AxisID)
        {
            IOlinkNodeID mIOlinkNodeID = new IOlinkNodeID();
            switch (AxisID)
            {
                case "IOlink_Rotate":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_Rotate;
                    break;
                case "IOlink_F_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam;
                    break;
                case "IOlink_B_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam;
                    break;
                case "IOlink_L_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam;
                    break;
                case "IOlink_R_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam;
                    break;
                case "IOlink_D_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam;
                    break;
                case "IOlink_F_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab;
                    break;
                case "IOlink_B_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab;
                    break;
                case "IOlink_L_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab;
                    break;
                case "IOlink_R_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab;
                    break;
                default:
                    break;
            }
            try
            {
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_In, false);
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_Out, true);
                while (!Form1.m_OpcUaClient.ReadNode<bool>(mIOlinkNodeID.NodeID_i_Out))
                {
                    Thread.Sleep(100);
                }
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_Out, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }
        public static bool IOlinkAxisReset(string AxisID)
        {
            IOlinkNodeID mIOlinkNodeID = new IOlinkNodeID();
            switch (AxisID)
            {
                case "IOlink_Rotate":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_Rotate;
                    break;
                case "IOlink_F_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam;
                    break;
                case "IOlink_B_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam;
                    break;
                case "IOlink_L_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam;
                    break;
                case "IOlink_R_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam;
                    break;
                case "IOlink_D_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam;
                    break;
                case "IOlink_F_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab;
                    break;
                case "IOlink_B_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab;
                    break;
                case "IOlink_L_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab;
                    break;
                case "IOlink_R_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab;
                    break;
                default:
                    break;
            }
            try
            {
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_QuitError, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }
        public static bool IOlinkAxisIn(int AxisCount)
        {
            switch (AxisCount)
            {
                case 1:
                    //魔方姿态
                    try
                    {
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_Out, false);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_In, true);
                        while (!Form1.m_OpcUaClient.ReadNode<bool>(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_i_In))
                        {
                            Thread.Sleep(100);
                        }
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_In, false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case 4:
                    //4周旋杆儿前后
                    try
                    {
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_Out},
        new object[] { false, false, false, false });
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_In},
        new object[] { true, true, true, true });
                        List<string> tags = new List<string>();
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_In);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_In);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_In);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_In);
                        List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());

                        int n = 0;
                        while (!(values[0] && values[1] && values[2] && values[3]))
                        {
                            Thread.Sleep(100);
                            values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                            n++;
                            if (n>50)
                            {
                                break;
                            }
                        }

                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_In},
        new object[] { false, false, false, false });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case 5:
                    //5个相机上下
                    try
                    {
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_Out},
        new object[] { false, false, false, false, false });
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_In},
        new object[] { true, true, true, true, true });
                        List<string> tags = new List<string>();
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_In);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_In);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_In);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_In);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_In);
                        List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());

                        while (!(values[0] && values[1] && values[2] && values[3] && values[4]))
                        {
                            Thread.Sleep(100);
                            values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                        }

                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_In},
        new object[] { false, false, false, false, false });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                default:
                    break;

            }
            return true;
        }
        //尝试让下面的相机不伸出
        public static bool IOlinkAxisOut(int AxisCount)
        {
            switch (AxisCount)
            {
                case 1:
                    //魔方姿态
                    try
                    {
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_In, false);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_Out, true);
                        while (!Form1.m_OpcUaClient.ReadNode<bool>(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_i_Out))
                        {
                            Thread.Sleep(100);
                        }
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_Out, false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case 4:
                    //4周旋杆儿前后
                    try
                    {
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_In},
        new object[] { false, false, false, false });
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_Out},
        new object[] { true, true, true, true});
                        List<string> tags = new List<string>();
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_Out);
                        List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());

                        while (!(values[0] && values[1] && values[2] && values[3]))
                        {
                            Thread.Sleep(100);
                            values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                        }
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_Out},
        new object[] { false, false, false, false});
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case 5:
                    //5个相机上下，确认F相机是否与Feeding轴干涉
                    try
                    {
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_In},
        new object[] { false, false, false, false, false });
        //                Form1.m_OpcUaClient.WriteNodes(new string[] {
        //GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_Out,
        //GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_Out,
        //GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_Out,
        //GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_Out,
        //GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_Out},
        //new object[] { true, true, true, true, true });
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_Out},
       new object[] { true, true, true, true });
                        List<string> tags = new List<string>();
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Out);
                        List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());

                        //while (!(values[0] && values[1] && values[2] && values[3] && values[4]))
                        //{
                        //    Thread.Sleep(100);
                        //}
                        while (!(values[0] && values[1] && values[2] && values[3]))
                        {
                            Thread.Sleep(100);
                            values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                        }
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_Out},
        new object[] { false, false, false, false, false });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                default:
                    break;

            }
            return true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateAxisStatus();
            updateForm();
            //#region 更新所有IOlink轴的状态
            //try
            //{
            //    List<string> tags = new List<string>();
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_i_Device);

            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Device);

            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Device);

            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Device);

            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Device);

            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Device);

            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_Device);

            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_Device);

            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_Device);

            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_In);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_Out);
            //    tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_Device);


            //    // 按照顺序定义的值
            //    List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
            //    #region Rotate
            //    if (values[0])
            //    {
            //        GlobalVariables.IOlink_Rotate.i_In = true;
            //        rbtn_Rotate_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_Rotate.i_In = false;
            //        rbtn_Rotate_P1.Checked = false;
            //    }
            //    if (values[1])
            //    {
            //        GlobalVariables.IOlink_Rotate.i_Out = true;
            //        rbtn_Rotate_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_Rotate.i_Out = false;
            //        rbtn_Rotate_P2.Checked = false;
            //    }
            //    if (values[2])
            //    {
            //        GlobalVariables.IOlink_Rotate.i_Device = true;
            //        lbl_Status_Rotate.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_Rotate.i_Device = false;
            //        lbl_Status_Rotate.BackColor = Color.Transparent;
            //    }
            //    #endregion
            //    #region F_Move_Cam
            //    if (values[1 * 3 + 0])
            //    {
            //        GlobalVariables.IOlink_F_Move_Cam.i_In = true;
            //        rbtn_MoveF_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_F_Move_Cam.i_In = false;
            //        rbtn_MoveF_P1.Checked = false;
            //    }
            //    if (values[1 * 3 + 1])
            //    {
            //        GlobalVariables.IOlink_F_Move_Cam.i_Out = true;
            //        rbtn_MoveF_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_F_Move_Cam.i_Out = false;
            //        rbtn_MoveF_P2.Checked = false;
            //    }
            //    if (values[1 * 3 + 2])
            //    {
            //        GlobalVariables.IOlink_F_Move_Cam.i_Device = true;
            //        lbl_Status_MovCamF.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_F_Move_Cam.i_Device = false;
            //        lbl_Status_MovCamF.BackColor = Color.Transparent;
            //    }
            //    #endregion
            //    #region B_Move_Cam
            //    if (values[2 * 3 + 0])
            //    {
            //        GlobalVariables.IOlink_B_Move_Cam.i_In = true;
            //        rbtn_MoveB_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_B_Move_Cam.i_In = false;
            //        rbtn_MoveB_P1.Checked = false;
            //    }
            //    if (values[2 * 3 + 1])
            //    {
            //        GlobalVariables.IOlink_B_Move_Cam.i_Out = true;
            //        rbtn_MoveB_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_B_Move_Cam.i_Out = false;
            //        rbtn_MoveB_P2.Checked = false;
            //    }
            //    if (values[2 * 3 + 2])
            //    {
            //        GlobalVariables.IOlink_B_Move_Cam.i_Device = true;
            //        lbl_Status_MovCamB.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_B_Move_Cam.i_Device = false;
            //        lbl_Status_MovCamB.BackColor = Color.Transparent;
            //    }
            //    #endregion
            //    #region L_Move_Cam
            //    if (values[3 * 3 + 0])
            //    {
            //        GlobalVariables.IOlink_L_Move_Cam.i_In = true;
            //        rbtn_MoveL_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_L_Move_Cam.i_In = false;
            //        rbtn_MoveL_P1.Checked = false;
            //    }
            //    if (values[3 * 3 + 1])
            //    {
            //        GlobalVariables.IOlink_L_Move_Cam.i_Out = true;
            //        rbtn_MoveL_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_L_Move_Cam.i_Out = false;
            //        rbtn_MoveL_P2.Checked = false;
            //    }
            //    if (values[3 * 3 + 2])
            //    {
            //        GlobalVariables.IOlink_L_Move_Cam.i_Device = true;
            //        lbl_Status_MovCamL.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_L_Move_Cam.i_Device = false;
            //        lbl_Status_MovCamL.BackColor = Color.Transparent;
            //    }
            //    #endregion
            //    #region R_Move_Cam
            //    if (values[4 * 3 + 0])
            //    {
            //        GlobalVariables.IOlink_R_Move_Cam.i_In = true;
            //        rbtn_MoveR_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_R_Move_Cam.i_In = false;
            //        rbtn_MoveR_P1.Checked = false;
            //    }
            //    if (values[4 * 3 + 1])
            //    {
            //        GlobalVariables.IOlink_R_Move_Cam.i_Out = true;
            //        rbtn_MoveR_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_R_Move_Cam.i_Out = false;
            //        rbtn_MoveR_P2.Checked = false;
            //    }
            //    if (values[4 * 3 + 2])
            //    {
            //        GlobalVariables.IOlink_R_Move_Cam.i_Device = true;
            //        lbl_Status_MovCamR.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_R_Move_Cam.i_Device = false;
            //        lbl_Status_MovCamR.BackColor = Color.Transparent;
            //    }
            //    #endregion
            //    #region D_Move_Cam
            //    if (values[5 * 3 + 0])
            //    {
            //        GlobalVariables.IOlink_D_Move_Cam.i_In = true;
            //        rbtn_MoveD_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_D_Move_Cam.i_In = false;
            //        rbtn_MoveD_P1.Checked = false;
            //    }
            //    if (values[5 * 3 + 1])
            //    {
            //        GlobalVariables.IOlink_D_Move_Cam.i_Out = true;
            //        rbtn_MoveD_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_D_Move_Cam.i_Out = false;
            //        rbtn_MoveD_P2.Checked = false;
            //    }
            //    if (values[5 * 3 + 2])
            //    {
            //        GlobalVariables.IOlink_D_Move_Cam.i_Device = true;
            //        lbl_Status_MovCamD.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_D_Move_Cam.i_Device = false;
            //        lbl_Status_MovCamD.BackColor = Color.Transparent;
            //    }
            //    #endregion
            //    #region F_Grab
            //    if (values[6 * 3 + 0])
            //    {
            //        GlobalVariables.IOlink_F_Grab.i_In = true;
            //        rbtn_GrabF_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_F_Grab.i_In = false;
            //        rbtn_GrabF_P1.Checked = false;
            //    }
            //    if (values[6 * 3 + 1])
            //    {
            //        GlobalVariables.IOlink_F_Grab.i_Out = true;
            //        rbtn_GrabF_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_F_Grab.i_Out = false;
            //        rbtn_GrabF_P2.Checked = false;
            //    }
            //    if (values[6 * 3 + 2])
            //    {
            //        GlobalVariables.IOlink_F_Grab.i_Device = true;
            //        lbl_Status_GrabF.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_F_Grab.i_Device = false;
            //        lbl_Status_GrabF.BackColor = Color.Transparent;
            //    }
            //    #endregion
            //    #region B_Grab
            //    if (values[7 * 3 + 0])
            //    {
            //        GlobalVariables.IOlink_B_Grab.i_In = true;
            //        rbtn_GrabB_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_B_Grab.i_In = false;
            //        rbtn_GrabB_P1.Checked = false;
            //    }
            //    if (values[7 * 3 + 1])
            //    {
            //        GlobalVariables.IOlink_B_Grab.i_Out = true;
            //        rbtn_GrabB_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_B_Grab.i_Out = false;
            //        rbtn_GrabB_P2.Checked = false;
            //    }
            //    if (values[7 * 3 + 2])
            //    {
            //        GlobalVariables.IOlink_B_Grab.i_Device = true;
            //        lbl_Status_GrabB.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_B_Grab.i_Device = false;
            //        lbl_Status_GrabB.BackColor = Color.Transparent;
            //    }
            //    #endregion
            //    #region L_Grab
            //    if (values[8 * 3 + 0])
            //    {
            //        GlobalVariables.IOlink_L_Grab.i_In = true;
            //        rbtn_GrabL_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_L_Grab.i_In = false;
            //        rbtn_GrabL_P1.Checked = false;
            //    }
            //    if (values[8 * 3 + 1])
            //    {
            //        GlobalVariables.IOlink_L_Grab.i_Out = true;
            //        rbtn_GrabL_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_L_Grab.i_Out = false;
            //        rbtn_GrabL_P2.Checked = false;
            //    }
            //    if (values[8 * 3 + 2])
            //    {
            //        GlobalVariables.IOlink_L_Grab.i_Device = true;
            //        lbl_Status_GrabL.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_L_Grab.i_Device = false;
            //        lbl_Status_GrabL.BackColor = Color.Transparent;
            //    }
            //    #endregion
            //    #region R_Grab
            //    if (values[9 * 3 + 0])
            //    {
            //        GlobalVariables.IOlink_R_Grab.i_In = true;
            //        rbtn_GrabR_P1.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_R_Grab.i_In = false;
            //        rbtn_GrabR_P1.Checked = false;
            //    }
            //    if (values[9 * 3 + 1])
            //    {
            //        GlobalVariables.IOlink_R_Grab.i_Out = true;
            //        rbtn_GrabR_P2.Checked = true;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_R_Grab.i_Out = false;
            //        rbtn_GrabR_P2.Checked = false;
            //    }
            //    if (values[9 * 3 + 2])
            //    {
            //        GlobalVariables.IOlink_R_Grab.i_Device = true;
            //        lbl_Status_GrabR.BackColor = Color.Transparent;
            //    }
            //    else
            //    {
            //        GlobalVariables.IOlink_R_Grab.i_Device = false;
            //        lbl_Status_GrabR.BackColor = Color.Transparent;
            //    }
            //    #endregion

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //#endregion
            //#region 更新Servo的当前位置信息
            //try
            //{
            //    List<NodeId> nodeIds = new List<NodeId>();
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId( GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_ActPos));
            //    nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_ActPos));
            //    // 按照顺序定义的值
            //    List<DataValue> dataValues = Form1.m_OpcUaClient.ReadNodes(nodeIds.ToArray());
            //    lbl_ActPos_GrabU.Text = dataValues[0].ToString();
            //    lbl_ActPos_GrabD.Text = dataValues[1].ToString();
            //    lbl_ActPos_RotateU.Text = dataValues[2].ToString();
            //    lbl_ActPos_RotateD.Text = dataValues[3].ToString();
            //    lbl_ActPos_RotateL.Text = dataValues[4].ToString();
            //    lbl_ActPos_RotateR.Text = dataValues[5].ToString();
            //    lbl_ActPos_RotateF.Text = dataValues[6].ToString();
            //    lbl_ActPos_RotateB.Text = dataValues[7].ToString();
            //    lbl_ActPos_MoveU.Text = dataValues[8].ToString();
            //    lbl_ActPos_MoveD.Text = dataValues[9].ToString();
            //    lbl_ActPos_Feeding.Text = dataValues[10].ToString();
            //    GlobalVariables.servo_U_Grab.i_ActPos = Convert.ToDouble(dataValues[0].ToString());
            //    GlobalVariables.servo_D_Grab.i_ActPos = Convert.ToDouble(dataValues[1].ToString());
            //    GlobalVariables.servo_U_Rotate.i_ActPos = Convert.ToDouble(dataValues[2].ToString());
            //    GlobalVariables.servo_D_Rotate.i_ActPos = Convert.ToDouble(dataValues[3].ToString());
            //    GlobalVariables.servo_L_Rotate.i_ActPos = Convert.ToDouble(dataValues[4].ToString());
            //    GlobalVariables.servo_R_Rotate.i_ActPos = Convert.ToDouble(dataValues[5].ToString());
            //    GlobalVariables.servo_F_Rotate.i_ActPos = Convert.ToDouble(dataValues[6].ToString());
            //    GlobalVariables.servo_B_Rotate.i_ActPos = Convert.ToDouble(dataValues[7].ToString());
            //    GlobalVariables.servo_U_Move.i_ActPos = Convert.ToDouble(dataValues[8].ToString());
            //    GlobalVariables.servo_D_Move.i_ActPos = Convert.ToDouble(dataValues[9].ToString());
            //    GlobalVariables.servo_Feeding.i_ActPos = Convert.ToDouble(dataValues[10].ToString());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //#endregion
            
        }
        public static void updateAxisStatus()
        {
            #region 更新所有IOlink轴的状态
            try
            {
                List<string> tags = new List<string>();
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_i_Device);

                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Device);

                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Device);

                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Device);

                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Device);

                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Device);

                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_Device);

                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_Device);

                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_Device);

                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_In);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_Out);
                tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_Device);


                // 按照顺序定义的值
                List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                #region Rotate
                if (values[0])
                {
                    GlobalVariables.IOlink_Rotate.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_Rotate.i_In = false;
                }
                if (values[1])
                {
                    GlobalVariables.IOlink_Rotate.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_Rotate.i_Out = false;
                }
                if (values[2])
                {
                    GlobalVariables.IOlink_Rotate.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_Rotate.i_Device = false;
                }
                #endregion
                #region F_Move_Cam
                if (values[1 * 3 + 0])
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_In = false;
                }
                if (values[1 * 3 + 1])
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_Out = false;
                }
                if (values[1 * 3 + 2])
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_Device = false;
                }
                #endregion
                #region B_Move_Cam
                if (values[2 * 3 + 0])
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_In = false;
                }
                if (values[2 * 3 + 1])
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_Out = false;
                }
                if (values[2 * 3 + 2])
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_Device = false;
                }
                #endregion
                #region L_Move_Cam
                if (values[3 * 3 + 0])
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_In = false;
                }
                if (values[3 * 3 + 1])
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_Out = false;
                }
                if (values[3 * 3 + 2])
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_Device = false;
                }
                #endregion
                #region R_Move_Cam
                if (values[4 * 3 + 0])
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_In = false;
                }
                if (values[4 * 3 + 1])
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_Out = false;
                }
                if (values[4 * 3 + 2])
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_Device = false;
                }
                #endregion
                #region D_Move_Cam
                if (values[5 * 3 + 0])
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_In = false;
                }
                if (values[5 * 3 + 1])
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_Out = false;
                }
                if (values[5 * 3 + 2])
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_Device = false;
                }
                #endregion
                #region F_Grab
                if (values[6 * 3 + 0])
                {
                    GlobalVariables.IOlink_F_Grab.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Grab.i_In = false;
                }
                if (values[6 * 3 + 1])
                {
                    GlobalVariables.IOlink_F_Grab.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Grab.i_Out = false;
                }
                if (values[6 * 3 + 2])
                {
                    GlobalVariables.IOlink_F_Grab.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Grab.i_Device = false;
                }
                #endregion
                #region B_Grab
                if (values[7 * 3 + 0])
                {
                    GlobalVariables.IOlink_B_Grab.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Grab.i_In = false;
                }
                if (values[7 * 3 + 1])
                {
                    GlobalVariables.IOlink_B_Grab.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Grab.i_Out = false;
                }
                if (values[7 * 3 + 2])
                {
                    GlobalVariables.IOlink_B_Grab.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Grab.i_Device = false;
                }
                #endregion
                #region L_Grab
                if (values[8 * 3 + 0])
                {
                    GlobalVariables.IOlink_L_Grab.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Grab.i_In = false;
                }
                if (values[8 * 3 + 1])
                {
                    GlobalVariables.IOlink_L_Grab.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Grab.i_Out = false;
                }
                if (values[8 * 3 + 2])
                {
                    GlobalVariables.IOlink_L_Grab.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Grab.i_Device = false;
                }
                #endregion
                #region R_Grab
                if (values[9 * 3 + 0])
                {
                    GlobalVariables.IOlink_R_Grab.i_In = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Grab.i_In = false;
                }
                if (values[9 * 3 + 1])
                {
                    GlobalVariables.IOlink_R_Grab.i_Out = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Grab.i_Out = false;
                }
                if (values[9 * 3 + 2])
                {
                    GlobalVariables.IOlink_R_Grab.i_Device = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Grab.i_Device = false;
                }
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
            #region 更新Servo状态信息
            try
            {
                #region i_Error
                List<string> tags = new List<string>();
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_Error);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_Error);
                // 按照顺序定义的值
                List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                GlobalVariables.servo_U_Grab.i_Error = values[0];
                GlobalVariables.servo_D_Grab.i_Error = values[1];
                GlobalVariables.servo_U_Rotate.i_Error = values[2];
                GlobalVariables.servo_D_Rotate.i_Error = values[3];
                GlobalVariables.servo_L_Rotate.i_Error = values[4];
                GlobalVariables.servo_R_Rotate.i_Error = values[5];
                GlobalVariables.servo_F_Rotate.i_Error = values[6];
                GlobalVariables.servo_B_Rotate.i_Error = values[7];
                GlobalVariables.servo_U_Move.i_Error = values[8];
                GlobalVariables.servo_D_Move.i_Error = values[9];
                GlobalVariables.servo_Feeding.i_Error = values[10];
                #endregion
                #region i_Enable
                tags = new List<string>();
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_Enable);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_Enable);
                // 按照顺序定义的值
                values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                GlobalVariables.servo_U_Grab.i_Enable = values[0];
                GlobalVariables.servo_D_Grab.i_Enable = values[1];
                GlobalVariables.servo_U_Rotate.i_Enable = values[2];
                GlobalVariables.servo_D_Rotate.i_Enable = values[3];
                GlobalVariables.servo_L_Rotate.i_Enable = values[4];
                GlobalVariables.servo_R_Rotate.i_Enable = values[5];
                GlobalVariables.servo_F_Rotate.i_Enable = values[6];
                GlobalVariables.servo_B_Rotate.i_Enable = values[7];
                GlobalVariables.servo_U_Move.i_Enable = values[8];
                GlobalVariables.servo_D_Move.i_Enable = values[9];
                GlobalVariables.servo_Feeding.i_Enable = values[10];
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion

            #region 更新Servo的当前位置信息
            try
            {
                List<NodeId> nodeIds = new List<NodeId>();
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_ActPos));
                nodeIds.Add(new NodeId(GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_ActPos));
                // 按照顺序定义的值
                List<DataValue> values = Form1.m_OpcUaClient.ReadNodes(nodeIds.ToArray());

                GlobalVariables.servo_U_Grab.i_ActPos = Convert.ToDouble(values[0].ToString());
                GlobalVariables.servo_D_Grab.i_ActPos = Convert.ToDouble(values[1].ToString());
                GlobalVariables.servo_U_Rotate.i_ActPos = Convert.ToDouble(values[2].ToString());
                GlobalVariables.servo_D_Rotate.i_ActPos = Convert.ToDouble(values[3].ToString());
                GlobalVariables.servo_L_Rotate.i_ActPos = Convert.ToDouble(values[4].ToString());
                GlobalVariables.servo_R_Rotate.i_ActPos = Convert.ToDouble(values[5].ToString());
                GlobalVariables.servo_F_Rotate.i_ActPos = Convert.ToDouble(values[6].ToString());
                GlobalVariables.servo_B_Rotate.i_ActPos = Convert.ToDouble(values[7].ToString());
                GlobalVariables.servo_U_Move.i_ActPos = Convert.ToDouble(values[8].ToString());
                GlobalVariables.servo_D_Move.i_ActPos = Convert.ToDouble(values[9].ToString());
                GlobalVariables.servo_Feeding.i_ActPos = Convert.ToDouble(values[10].ToString());

                #region servo_U_Grab
                if (GlobalVariables.servo_U_Grab.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_U_Grab.P1 - GlobalVariables.positionTolerance &&
                      GlobalVariables.servo_U_Grab.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_U_Grab.P1 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_U_Grab.b_P1 = true;
                    GlobalVariables.servo_U_Grab.b_P2 = false;
                    GlobalVariables.servo_U_Grab.b_P3 = false;
                }
                else if (GlobalVariables.servo_U_Grab.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_U_Grab.P2 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_U_Grab.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_U_Grab.P2 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_U_Grab.b_P1 = false;
                    GlobalVariables.servo_U_Grab.b_P2 = true;
                    GlobalVariables.servo_U_Grab.b_P3 = false;
                }
                else if (GlobalVariables.servo_U_Grab.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_U_Grab.P3 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_U_Grab.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_U_Grab.P3 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_U_Grab.b_P1 = false;
                    GlobalVariables.servo_U_Grab.b_P2 = false;
                    GlobalVariables.servo_U_Grab.b_P3 = true;
                }
                #endregion

                #region servo_D_Grab
                if (GlobalVariables.servo_D_Grab.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_D_Grab.P1 - GlobalVariables.positionTolerance &&
                           GlobalVariables.servo_D_Grab.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_D_Grab.P1 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_D_Grab.b_P1 = true;
                    GlobalVariables.servo_D_Grab.b_P2 = false;
                    GlobalVariables.servo_D_Grab.b_P3 = false;
                }
                else if (GlobalVariables.servo_D_Grab.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_D_Grab.P2 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_D_Grab.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_D_Grab.P2 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_D_Grab.b_P1 = false;
                    GlobalVariables.servo_D_Grab.b_P2 = true;
                    GlobalVariables.servo_D_Grab.b_P3 = false;
                }
                else if (GlobalVariables.servo_D_Grab.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_D_Grab.P3 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_D_Grab.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_D_Grab.P3 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_D_Grab.b_P1 = false;
                    GlobalVariables.servo_D_Grab.b_P2 = false;
                    GlobalVariables.servo_D_Grab.b_P3 = true;
                }
                #endregion

                #region servo_U_Move
                if (GlobalVariables.servo_U_Move.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_U_Move.P1 - GlobalVariables.positionTolerance &&
                      GlobalVariables.servo_U_Move.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_U_Move.P1 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_U_Move.b_P1 = true;
                    GlobalVariables.servo_U_Move.b_P2 = false;
                    GlobalVariables.servo_U_Move.b_P3 = false;
                }
                else if (GlobalVariables.servo_U_Move.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_U_Move.P2 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_U_Move.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_U_Move.P2 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_U_Move.b_P1 = false;
                    GlobalVariables.servo_U_Move.b_P2 = true;
                    GlobalVariables.servo_U_Move.b_P3 = false;
                }
                else if (GlobalVariables.servo_U_Move.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_U_Move.P3 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_U_Move.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_U_Move.P3 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_U_Move.b_P1 = false;
                    GlobalVariables.servo_U_Move.b_P2 = false;
                    GlobalVariables.servo_U_Move.b_P3 = true;
                }
                #endregion

                #region servo_D_Move
                if (GlobalVariables.servo_D_Move.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_D_Move.P1 - GlobalVariables.positionTolerance &&
                      GlobalVariables.servo_D_Move.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_D_Move.P1 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_D_Move.b_P1 = true;
                    GlobalVariables.servo_D_Move.b_P2 = false;
                    GlobalVariables.servo_D_Move.b_P3 = false;
                }
                else if (GlobalVariables.servo_D_Move.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_D_Move.P2 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_D_Move.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_D_Move.P2 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_D_Move.b_P1 = false;
                    GlobalVariables.servo_D_Move.b_P2 = true;
                    GlobalVariables.servo_D_Move.b_P3 = false;
                }
                else if (GlobalVariables.servo_D_Move.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_D_Move.P3 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_D_Move.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_D_Move.P3 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_D_Move.b_P1 = false;
                    GlobalVariables.servo_D_Move.b_P2 = false;
                    GlobalVariables.servo_D_Move.b_P3 = true;
                }
                #endregion

                #region servo_Feeding
                if (GlobalVariables.servo_Feeding.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P1 - GlobalVariables.positionTolerance &&
                      GlobalVariables.servo_Feeding.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P1 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_Feeding.b_P1 = true;
                    GlobalVariables.servo_Feeding.b_P2 = false;
                    GlobalVariables.servo_Feeding.b_P3 = false;
                }
                else if (GlobalVariables.servo_Feeding.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P2 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_Feeding.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P2 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_Feeding.b_P1 = false;
                    GlobalVariables.servo_Feeding.b_P2 = true;
                    GlobalVariables.servo_Feeding.b_P3 = false;
                }
                else if (GlobalVariables.servo_Feeding.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P3 - GlobalVariables.positionTolerance &&
                    GlobalVariables.servo_Feeding.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P3 + GlobalVariables.positionTolerance)
                {
                    GlobalVariables.servo_Feeding.b_P1 = false;
                    GlobalVariables.servo_Feeding.b_P2 = false;
                    GlobalVariables.servo_Feeding.b_P3 = true;
                }
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }
        public void updateForm()
        {
            updateAxisStatus();
            #region 更新所有IOlink轴的状态
            try
            {
                #region Rotate
                rbtn_Rotate_P1.Checked = GlobalVariables.IOlink_Rotate.i_In;
                rbtn_Rotate_P2.Checked = GlobalVariables.IOlink_Rotate.i_Out;
                if (GlobalVariables.IOlink_Rotate.i_Device)
                {                    
                    lbl_Status_Rotate.BackColor = Color.Green;
                }
                else
                {                    
                    lbl_Status_Rotate.BackColor = Color.Transparent;
                }
                #endregion
                #region F_Move_Cam
                rbtn_MoveF_P1.Checked = GlobalVariables.IOlink_F_Move_Cam.i_In;
                rbtn_MoveF_P2.Checked = GlobalVariables.IOlink_F_Move_Cam.i_Out;
                if (GlobalVariables.IOlink_F_Move_Cam.i_Device)
                {
                    lbl_Status_MovCamF.BackColor = Color.Green;
                }
                else
                {
                    lbl_Status_MovCamF.BackColor = Color.Transparent;
                }
                #endregion
                #region B_Move_Cam
                rbtn_MoveB_P1.Checked = GlobalVariables.IOlink_B_Move_Cam.i_In;
                rbtn_MoveB_P2.Checked = GlobalVariables.IOlink_B_Move_Cam.i_Out;
                if (GlobalVariables.IOlink_B_Move_Cam.i_Device)
                {
                    lbl_Status_MovCamB.BackColor = Color.Green;
                }
                else
                {
                    lbl_Status_MovCamB.BackColor = Color.Transparent;
                }
                #endregion
                #region L_Move_Cam
                rbtn_MoveL_P1.Checked = GlobalVariables.IOlink_L_Move_Cam.i_In;
                rbtn_MoveL_P2.Checked = GlobalVariables.IOlink_L_Move_Cam.i_Out;
                if (GlobalVariables.IOlink_L_Move_Cam.i_Device)
                {
                    lbl_Status_MovCamL.BackColor = Color.Green;
                }
                else
                {
                    lbl_Status_MovCamL.BackColor = Color.Transparent;
                }
                #endregion
                #region R_Move_Cam
                rbtn_MoveR_P1.Checked = GlobalVariables.IOlink_R_Move_Cam.i_In;
                rbtn_MoveR_P2.Checked = GlobalVariables.IOlink_R_Move_Cam.i_Out;
                if (GlobalVariables.IOlink_R_Move_Cam.i_Device)
                {
                    lbl_Status_MovCamR.BackColor = Color.Green;
                }
                else
                {
                    lbl_Status_MovCamR.BackColor = Color.Transparent;
                }
                #endregion
                #region D_Move_Cam
                rbtn_MoveD_P1.Checked = GlobalVariables.IOlink_D_Move_Cam.i_In;
                rbtn_MoveD_P2.Checked = GlobalVariables.IOlink_D_Move_Cam.i_Out;
                if (GlobalVariables.IOlink_D_Move_Cam.i_Device)
                {
                    lbl_Status_MovCamD.BackColor = Color.Green;
                }
                else
                {
                    lbl_Status_MovCamD.BackColor = Color.Transparent;
                }
                #endregion
                #region F_Grab
                rbtn_GrabF_P1.Checked = GlobalVariables.IOlink_F_Grab.i_In;
                rbtn_GrabF_P2.Checked = GlobalVariables.IOlink_F_Grab.i_Out;
                if (GlobalVariables.IOlink_F_Grab.i_Device)
                {
                    lbl_Status_GrabF.BackColor = Color.Green;
                }
                else
                {
                    lbl_Status_GrabF.BackColor = Color.Transparent;
                }
                #endregion
                #region B_Grab
                rbtn_GrabB_P1.Checked = GlobalVariables.IOlink_B_Grab.i_In;
                rbtn_GrabB_P2.Checked = GlobalVariables.IOlink_B_Grab.i_Out;
                if (GlobalVariables.IOlink_B_Grab.i_Device)
                {
                    lbl_Status_GrabB.BackColor = Color.Green;
                }
                else
                {
                    lbl_Status_GrabB.BackColor = Color.Transparent;
                }
                #endregion
                #region L_Grab
                rbtn_GrabL_P1.Checked = GlobalVariables.IOlink_L_Grab.i_In;
                rbtn_GrabL_P2.Checked = GlobalVariables.IOlink_L_Grab.i_Out;
                if (GlobalVariables.IOlink_L_Grab.i_Device)
                {
                    lbl_Status_GrabL.BackColor = Color.Green;
                }
                else
                {
                    lbl_Status_GrabL.BackColor = Color.Transparent;
                }
                #endregion
                #region R_Grab
                rbtn_GrabR_P1.Checked = GlobalVariables.IOlink_R_Grab.i_In;
                rbtn_GrabR_P2.Checked = GlobalVariables.IOlink_R_Grab.i_Out;
                if (GlobalVariables.IOlink_R_Grab.i_Device)
                {
                    lbl_Status_GrabR.BackColor = Color.Green;
                }
                else
                {
                    lbl_Status_GrabR.BackColor = Color.Transparent;
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
            #region 更新Servo的当前位置信息
            try
            {               
                lbl_ActPos_GrabU.Text = GlobalVariables.servo_U_Grab.i_ActPos.ToString();
                lbl_ActPos_GrabD.Text = GlobalVariables.servo_D_Grab.i_ActPos.ToString();
                lbl_ActPos_RotateU.Text = GlobalVariables.servo_U_Rotate.i_ActPos.ToString();
                lbl_ActPos_RotateD.Text = GlobalVariables.servo_D_Rotate.i_ActPos.ToString();
                lbl_ActPos_RotateL.Text = GlobalVariables.servo_L_Rotate.i_ActPos.ToString();
                lbl_ActPos_RotateR.Text = GlobalVariables.servo_R_Rotate.i_ActPos.ToString();
                lbl_ActPos_RotateF.Text = GlobalVariables.servo_F_Rotate.i_ActPos.ToString();
                lbl_ActPos_RotateB.Text = GlobalVariables.servo_B_Rotate.i_ActPos.ToString();
                lbl_ActPos_MoveU.Text = GlobalVariables.servo_U_Move.i_ActPos.ToString();
                lbl_ActPos_MoveD.Text = GlobalVariables.servo_D_Move.i_ActPos.ToString();
                lbl_ActPos_Feeding.Text = GlobalVariables.servo_Feeding.i_ActPos.ToString();

                rbtn_GrabU_P1.Checked = GlobalVariables.servo_U_Grab.b_P1;
                rbtn_GrabU_P2.Checked = GlobalVariables.servo_U_Grab.b_P2;
                rbtn_GrabU_P3.Checked = GlobalVariables.servo_U_Grab.b_P3;

                rbtn_GrabD_P1.Checked = GlobalVariables.servo_D_Grab.b_P1;
                rbtn_GrabD_P2.Checked = GlobalVariables.servo_D_Grab.b_P2;
                rbtn_GrabD_P3.Checked = GlobalVariables.servo_D_Grab.b_P3;

                rbtn_BlockMoveU_P1.Checked = GlobalVariables.servo_U_Move.b_P1;
                rbtn_BlockMoveU_P2.Checked = GlobalVariables.servo_U_Move.b_P2;

                rbtn_BlockMoveD_P1.Checked = GlobalVariables.servo_D_Move.b_P1;
                rbtn_BlockMoveD_P2.Checked = GlobalVariables.servo_D_Move.b_P2;

                rbtn_Feeding_P1.Checked = GlobalVariables.servo_Feeding.b_P1;
                rbtn_Feeding_P2.Checked = GlobalVariables.servo_Feeding.b_P2;

                #region servo_U_Grab
                if (GlobalVariables.servo_U_Grab.i_Enable)
                {
                    lbl_Status_GrabU.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_U_Grab.i_Error)
                    {
                        lbl_Status_GrabU.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_GrabU.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_D_Grab
                if (GlobalVariables.servo_D_Grab.i_Enable)
                {
                    lbl_Status_GrabD.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_D_Grab.i_Error)
                    {
                        lbl_Status_GrabD.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_GrabD.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_U_Rotate
                if (GlobalVariables.servo_U_Rotate.i_Enable)
                {
                    lbl_Status_RotateU.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_U_Rotate.i_Error)
                    {
                        lbl_Status_RotateU.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_RotateU.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_D_Rotate
                if (GlobalVariables.servo_D_Rotate.i_Enable)
                {
                    lbl_Status_RotateD.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_D_Rotate.i_Error)
                    {
                        lbl_Status_RotateD.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_RotateD.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_L_Rotate
                if (GlobalVariables.servo_L_Rotate.i_Enable)
                {
                    lbl_Status_RotateL.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_L_Rotate.i_Error)
                    {
                        lbl_Status_RotateL.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_RotateL.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_R_Rotate
                if (GlobalVariables.servo_R_Rotate.i_Enable)
                {
                    lbl_Status_RotateR.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_R_Rotate.i_Error)
                    {
                        lbl_Status_RotateR.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_RotateR.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_F_Rotate
                if (GlobalVariables.servo_F_Rotate.i_Enable)
                {
                    lbl_Status_RotateF.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_F_Rotate.i_Error)
                    {
                        lbl_Status_RotateF.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_RotateF.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_B_Rotate
                if (GlobalVariables.servo_B_Rotate.i_Enable)
                {
                    lbl_Status_RotateB.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_B_Rotate.i_Error)
                    {
                        lbl_Status_RotateB.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_RotateB.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_U_Move
                if (GlobalVariables.servo_U_Move.i_Enable)
                {
                    lbl_Status_MoveU.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_U_Move.i_Error)
                    {
                        lbl_Status_MoveU.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_MoveU.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_D_Move
                if (GlobalVariables.servo_D_Move.i_Enable)
                {
                    lbl_Status_MoveD.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_D_Move.i_Error)
                    {
                        lbl_Status_MoveD.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_MoveD.BackColor = Color.Transparent;
                    }
                }
                #endregion
                #region servo_Feeding
                if (GlobalVariables.servo_Feeding.i_Enable)
                {
                    lbl_Status_Feeding.BackColor = Color.Green;
                }
                else
                {
                    if (GlobalVariables.servo_Feeding.i_Error)
                    {
                        lbl_Status_Feeding.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status_Feeding.BackColor = Color.Transparent;
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion

        }
        public static bool ServoGoto(string AxisID,int PointIndex,bool b_FirstRotate=false,bool b_ChangeDirection=false)
        {
            updateAxisStatus();
            ServoParas mServoParas = new ServoParas();
            ServoStatus mServoStatus = new ServoStatus();
            double TargetPosition = 0;
            switch (AxisID)
            {
                case "servo_B_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                    mServoStatus = GlobalVariables.servo_B_Rotate;
                    switch (PointIndex)
                    {
                        case 0:
                            TargetPosition = mServoParas.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos + PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            break;                        
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos + PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            break;
                    }

                    break;
                case "servo_D_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                    mServoStatus = GlobalVariables.servo_D_Grab;
                    switch (PointIndex)
                    {
                        case 1:
                            TargetPosition = mServoParas.P1;
                            break;
                        case 2:
                            TargetPosition = mServoParas.P2;
                            break;
                        case 3:
                            TargetPosition = mServoParas.P3;
                            break;
                    }
                    break;
                case "servo_D_Move":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Move;
                    mServoStatus = GlobalVariables.servo_D_Move;
                    switch (PointIndex)
                    {
                        case 1:
                            TargetPosition = mServoParas.P1;
                            break;
                        case 2:
                            TargetPosition = mServoParas.P2;
                            break;
                    }
                    //确定D相机，D杆都在原位
                    if (GlobalVariables.servo_D_Grab.b_P1 && GlobalVariables.IOlink_D_Move_Cam.i_In)
                    {
                        break;
                    }
                    else
                    {
                        return false;
                    }                    
                case "servo_D_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Rotate;
                    mServoStatus = GlobalVariables.servo_D_Rotate;
                    switch (PointIndex)
                    {
                        case 0:
                            TargetPosition = mServoParas.P_0;
                            break;                        
                    }
                    break;
                case "servo_Feeding":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_Feeding;
                    mServoStatus = GlobalVariables.servo_Feeding;
                    switch (PointIndex)
                    {
                        case 1:
                            TargetPosition = mServoParas.P1;
                            break;
                        case 2:
                            TargetPosition = mServoParas.P2;
                            break;
                    }
                    //确定F相机，D相机，D杆都在原位
                    if (GlobalVariables.servo_D_Grab.b_P1 && GlobalVariables.IOlink_D_Move_Cam.i_In && GlobalVariables.IOlink_F_Move_Cam.i_In)
                    {
                        break;
                    }
                    else
                    {
                        return false;
                    }
                case "servo_F_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                    mServoStatus = GlobalVariables.servo_F_Rotate;
                    switch (PointIndex)
                    {
                        case 0:
                            TargetPosition = mServoParas.P_0;
                            break;
                    }
                    break;
                case "servo_L_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                    mServoStatus = GlobalVariables.servo_L_Rotate;
                    switch (PointIndex)
                    {
                        case 0:
                            TargetPosition = mServoParas.P_0;
                            break;
                    }
                    break;
                case "servo_R_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                    mServoStatus = GlobalVariables.servo_R_Rotate;
                    switch (PointIndex)
                    {
                        case 0:
                            TargetPosition = mServoParas.P_0;
                            break;
                    }
                    break;
                case "servo_U_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                    mServoStatus = GlobalVariables.servo_U_Grab;
                    switch (PointIndex)
                    {
                        case 1:
                            TargetPosition = mServoParas.P1;
                            break;
                        case 2:
                            TargetPosition = mServoParas.P2;
                            break;
                        case 3:
                            TargetPosition = mServoParas.P3;
                            break;
                    }
                    break;
                case "servo_U_Move":
                    mServoStatus = GlobalVariables.servo_U_Move;
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Move;
                    switch (PointIndex)
                    {
                        case 1:
                            TargetPosition = mServoParas.P1;
                            break;
                        case 2:
                            TargetPosition = mServoParas.P2;
                            break;
                    }
                    //确定U杆都在原位
                    if (GlobalVariables.servo_U_Grab.b_P1)
                    {
                        break;
                    }
                    else
                    {
                        return false;
                    }
                case "servo_U_Rotate":
                    mServoStatus = GlobalVariables.servo_U_Rotate;
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Rotate;
                    switch (PointIndex)
                    {
                        case 0:
                            TargetPosition = mServoParas.P_0;
                            break;
                    }
                    break;
                default:
                    break;
            }

            try
            {
                if (mServoStatus.i_Error)
                {
                    //有异常，下使能，Reset
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, false);
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, true);
                    Thread.Sleep(100);
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, false);
                }
                if (!mServoStatus.i_Enable)
                {
                    //上使能
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, true);
                }
                if (!mServoStatus.i_Error)
                {
                    Form1.m_OpcUaClient.WriteNodes(new string[] {
                mServoParas.mServoNodeID.NodeID_o_Vel,
                mServoParas.mServoNodeID.NodeID_o_Acc,
                mServoParas.mServoNodeID.NodeID_o_Dec,
                mServoParas.mServoNodeID.NodeID_o_Jerk},
                new object[] {
                    Convert.ToSingle(GlobalVariables.global_Vel),
                    Convert.ToSingle(GlobalVariables.global_Acc),
                    Convert.ToSingle(GlobalVariables.global_Dec),
                    Convert.ToSingle(GlobalVariables.global_Jerk)
                });
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition));
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, true);
                    System.Threading.Thread.Sleep(100);
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, false);
                }
                else
                {
                    MessageBox.Show(AxisID + " Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }

        public static bool ServoGoHome(string AxisID)
        {
            updateAxisStatus();
            ServoParas mServoParas = new ServoParas();
            ServoStatus mServoStatus = new ServoStatus();
            double TargetPosition = 0;
            switch (AxisID)
            {
                case "servo_B_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                    mServoStatus = GlobalVariables.servo_B_Rotate;
                    break;
                case "servo_D_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                    mServoStatus = GlobalVariables.servo_D_Grab;
                    break;
                case "servo_D_Move":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Move;
                    mServoStatus = GlobalVariables.servo_D_Move;
                    //确定D相机，D杆都在原位
                    if (GlobalVariables.servo_D_Grab.b_P1 && GlobalVariables.IOlink_D_Move_Cam.i_In)
                    {
                        break;
                    }
                    else
                    {
                        return false;
                    }
                case "servo_D_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Rotate;
                    mServoStatus = GlobalVariables.servo_D_Rotate;
                    break;
                case "servo_Feeding":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_Feeding;
                    mServoStatus = GlobalVariables.servo_Feeding;
                    //确定D相机，D杆都在原位
                    if (GlobalVariables.servo_D_Grab.b_P1 && GlobalVariables.IOlink_D_Move_Cam.i_In && GlobalVariables.IOlink_F_Move_Cam.i_In)
                    {
                        break;
                    }
                    else
                    {
                        return false;                        
                    }                                 
                case "servo_F_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                    mServoStatus = GlobalVariables.servo_F_Rotate;
                    break;
                case "servo_L_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                    mServoStatus = GlobalVariables.servo_L_Rotate;
                    break;
                case "servo_R_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                    mServoStatus = GlobalVariables.servo_R_Rotate;
                    break;
                case "servo_U_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                    mServoStatus = GlobalVariables.servo_U_Grab;
                    break;
                case "servo_U_Move":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Move;
                    mServoStatus = GlobalVariables.servo_U_Move;
                    break;
                case "servo_U_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Rotate;
                    mServoStatus = GlobalVariables.servo_U_Rotate;
                    break;
                default:
                    break;
            }

            try
            {
                if (mServoStatus.i_Error)
                {
                    //有异常，下使能，Reset
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, false);
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, true);
                    Thread.Sleep(100);
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, false);
                }
                if (!mServoStatus.i_Enable)
                {
                    //上使能
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, true);
                }
                if (!mServoStatus.i_Error)
                {
                    Form1.m_OpcUaClient.WriteNodes(new string[] {
                mServoParas.mServoNodeID.NodeID_o_Vel,
                mServoParas.mServoNodeID.NodeID_o_Acc,
                mServoParas.mServoNodeID.NodeID_o_Dec,
                mServoParas.mServoNodeID.NodeID_o_Jerk},
                new object[] {
                    Convert.ToSingle(GlobalVariables.global_Vel),
                    Convert.ToSingle(GlobalVariables.global_Acc),
                    Convert.ToSingle(GlobalVariables.global_Dec),
                    Convert.ToSingle(GlobalVariables.global_Jerk)
                });
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition));
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, true);
                    System.Threading.Thread.Sleep(100);
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, false);
                }
                else
                {
                    MessageBox.Show(AxisID + " Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }
        private void btn_ResetAll_Click(object sender, EventArgs e)
        {
            List<string> tags = new List<string>();
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_Error);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_Device);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Device);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Device);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_Device);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Device);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_Device);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Device);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_i_Device);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_Device);
            tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Device);
            // 按照顺序定义的值
            List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
            if (values[0])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[1])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[2])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[3])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[4])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[5])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[6])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[7])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[8])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[9])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Reset, false);
            }
            if (values[10])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Reset, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Reset, false);
            }
            if (!values[11])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_QuitError, false);
            }
            if (!values[12])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_QuitError, false);
            }
            if (!values[13])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_QuitError, false);
            }
            if (!values[14])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_QuitError, false);
            }
            if (!values[15])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_QuitError, false);
            }
            if (!values[16])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_QuitError, false);
            }
            if (!values[17])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_QuitError, false);
            }
            if (!values[18])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_QuitError, false);
            }
            if (!values[19])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_QuitError, false);
            }
            if (!values[20])
            {
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_QuitError, true);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_QuitError, false);
            }
        }

        private void btn_EnableAll_Click(object sender, EventArgs e)
        {
            btn_ResetAll_Click(sender, e);
            Form1.m_OpcUaClient.WriteNodes(new string[] {
            GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Enable},
        new object[] { true, true, true, true, true, true, true, true, true, true, true });
            
        }

        private void btn_2_P_Start_Click(object sender, EventArgs e)
        {
            IOlinkAxisIn(5);//5个相机回原位
            IOlinkAxisOut(1);//魔方姿态45度
            IOlinkAxisIn(4);//4个旋转杆回原位           
            ServoGoto("servo_L_Rotate",0);
            ServoGoto("servo_R_Rotate",0);
            ServoGoto("servo_F_Rotate",0);
            ServoGoto("servo_B_Rotate",0);
            ServoGoHome("servo_U_Grab");
            ServoGoHome("servo_D_Grab");//魔方落回台子上
            ServoGoto("servo_U_Rotate",0);
            ServoGoto("servo_D_Rotate",0);
            IOlinkAxisIn(1);//魔方姿态回0位拍照位
            //确定D相机，D杆都在原位
            ServoGoto("servo_Feeding",1);
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Form1.m_OpcUaClient.WriteNodes(new string[] {
            GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Enable,
            GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Enable},
        new object[] { false, false, false, false, false, false, false, false, false, false, false });
        }

        private void btn_2_P_Acquire_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            updateAxisStatus();

            if (!GlobalVariables.IOlink_F_Grab.i_Out && !GlobalVariables.IOlink_B_Grab.i_Out
                && !GlobalVariables.IOlink_L_Grab.i_Out && !GlobalVariables.IOlink_R_Grab.i_Out
                 && GlobalVariables.servo_U_Grab.b_P1 && GlobalVariables.servo_D_Grab.b_P1)
            {
                if (GlobalVariables.IOlink_B_Move_Cam .i_In && GlobalVariables.IOlink_F_Move_Cam.i_In && GlobalVariables.IOlink_B_Move_Cam.i_In
                && GlobalVariables.IOlink_L_Move_Cam.i_In && GlobalVariables.IOlink_R_Move_Cam.i_In)
                {
                    //线缆未到，屏蔽
                    //if (GlobalVariables.IOlink_Rotate.i_In)
                    //{

                    //}
                    ServoGoto("servo_Feeding", 2);
                    ServoGoto("servo_U_Move", 1);
                    ServoGoto("servo_D_Move", 1);
                    while (!GlobalVariables.servo_Feeding.b_P2)
                    {
                        Thread.Sleep(1000);
                        updateAxisStatus();
                    }
                    AllLightOn();
                    if (GlobalVariables.servo_Feeding.b_P2)
                    {
                        IOlinkAxisOut(5);//5个相机工作位  
                    }
                    else
                    {
                        MessageBox.Show("上料轴未到拍照位，相机不能升起");
                    }
                    
                }
                else
                {
                    IOlinkAxisIn(5);//5个相机回原位  
                }
            }
            else
            {
                ServoGoHome("servo_U_Grab");
                ServoGoHome("servo_D_Grab");
                IOlinkAxisIn(4);//4个旋转杆回原位  
            }
            timer1.Enabled = true;
        }

        private void btn_2_P_Rotate_Click(object sender, EventArgs e)
        {
            updateAxisStatus();
            AllLightOff();
            IOlinkAxisIn(5);//5个相机回原位  
            if (GlobalVariables.IOlink_F_Grab.i_In && GlobalVariables.IOlink_B_Grab.i_In
                && GlobalVariables.IOlink_L_Grab.i_In && GlobalVariables.IOlink_R_Grab.i_In
                 && GlobalVariables.servo_U_Grab.b_P1 && GlobalVariables.servo_D_Grab.b_P1)
            {

            }
            else
            {
                ServoGoHome("servo_U_Grab");
                ServoGoHome("servo_D_Grab");
                IOlinkAxisIn(4);//4个旋转杆回原位  
            }

            //旋转杆归零
            ServoGoto("servo_L_Rotate",0);
            ServoGoto("servo_R_Rotate",0);
            ServoGoto("servo_F_Rotate",0);
            ServoGoto("servo_B_Rotate",0);
            ServoGoto("servo_U_Rotate",0);
            ServoGoto("servo_D_Rotate",0);

            IOlinkAxisOut(1);//魔方姿态至45度

            //UD模块至旋转位
            ServoGoto("servo_U_Move", 2);
            ServoGoto("servo_D_Move", 2);

            updateAxisStatus();
            while (!(GlobalVariables.servo_U_Move.b_P2 && GlobalVariables.servo_D_Move.b_P2))
            {
                Thread.Sleep(100);
                updateAxisStatus();
            }
            if (GlobalVariables.servo_U_Rotate.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.P_0 - GlobalVariables.positionTolerance &&
                     GlobalVariables.servo_U_Rotate.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.P_0 + GlobalVariables.positionTolerance &&
                     GlobalVariables.servo_D_Rotate.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.P_0 - GlobalVariables.positionTolerance &&
                     GlobalVariables.servo_D_Rotate.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.P_0 + GlobalVariables.positionTolerance)
            {
                //UD杆至取料位
                ServoGoto("servo_U_Grab", 3);
                ServoGoto("servo_D_Grab", 3);
                while (!(GlobalVariables.servo_U_Grab.b_P3 && GlobalVariables.servo_D_Grab.b_P3))
                {
                    Thread.Sleep(100);
                    updateAxisStatus();
                }
                //UD杆至旋转位，U先上，而后D上，避免顶到
                ServoGoto("servo_U_Grab", 2);
                ServoGoto("servo_D_Grab", 2);
                while (!(GlobalVariables.servo_U_Grab.b_P2 && GlobalVariables.servo_D_Grab.b_P2))
                {
                    Thread.Sleep(100);
                    updateAxisStatus();
                }
                if (GlobalVariables.servo_F_Rotate.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.P_0 - GlobalVariables.positionTolerance &&
                        GlobalVariables.servo_F_Rotate.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.P_0 + GlobalVariables.positionTolerance &&
                        GlobalVariables.servo_B_Rotate.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.P_0 - GlobalVariables.positionTolerance &&
                        GlobalVariables.servo_B_Rotate.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.P_0 + GlobalVariables.positionTolerance &&
                        GlobalVariables.servo_L_Rotate.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.P_0 - GlobalVariables.positionTolerance &&
                        GlobalVariables.servo_L_Rotate.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.P_0 + GlobalVariables.positionTolerance &&
                        GlobalVariables.servo_R_Rotate.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.P_0 - GlobalVariables.positionTolerance &&
                        GlobalVariables.servo_R_Rotate.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.P_0 + GlobalVariables.positionTolerance)
                {
                    //FBLR杆伸出至旋转位
                    IOlinkAxisOut(4);
                }
                else
                {
                    MessageBox.Show("上下旋杆儿捅进魔方有风险");
                }
            }
            else
            {
                MessageBox.Show("上下旋杆儿捅进魔方有风险");
            }
            
        }

        private void btn_CubeBack_Click(object sender, EventArgs e)
        {
            //判断魔方是否是正方体，不是则弹出手动页面微调
            IOlinkAxisIn(4);//4个旋转杆回原位  
            IOlinkAxisIn(5);//5个相机回原位  
            IOlinkAxisOut(1);//托盘位置至45度位
            ServoGoto("servo_D_Grab", 3);
            Thread.Sleep(100);
            ServoGoto("servo_U_Grab", 3);
            updateAxisStatus();
            while(!(GlobalVariables.servo_D_Grab.b_P3 && GlobalVariables.servo_U_Grab.b_P3))
            { 
                Thread.Sleep(100);
                updateAxisStatus();
            }
            ServoGoto("servo_U_Grab", 1);
            ServoGoto("servo_D_Grab", 1);
            updateAxisStatus();
            while (!(GlobalVariables.servo_D_Grab.b_P1 && GlobalVariables.servo_U_Grab.b_P1))
            {
                Thread.Sleep(100);
                updateAxisStatus();
            }
            IOlinkAxisIn(1);//托盘位置至0度位
            ServoGoto("servo_Feeding", 1);
        }

        public static bool RotateTo(string str_Rotate, bool b_FirstRotate = false, bool b_ChangeDirection = false)
        {
            try
            {
                string str_ServoName = "";
                switch (str_Rotate.Substring(0, 1))
                {
                    case "U":
                        str_ServoName = "servo_U_Rotate";
                        break;
                    case "D":
                        str_ServoName = "servo_D_Rotate";
                        break;
                    case "L":
                        str_ServoName = "servo_L_Rotate";
                        break;
                    case "R":
                        str_ServoName = "servo_R_Rotate";
                        break;
                    case "F":
                        str_ServoName = "servo_F_Rotate";
                        break;
                    case "B":
                        str_ServoName = "servo_B_Rotate";
                        break;
                    default:
                        break;
                }
                int PointIndex = 0;
                if (str_Rotate.Length == 1)
                {
                    PointIndex = 90;
                }
                else
                {
                    switch (str_Rotate.Substring(1, 1))
                    {
                        case "'":
                            PointIndex = 270;
                            break;
                        case "2":
                            PointIndex = 180;
                            break;
                    }
                }
                ServoGoto(str_ServoName, PointIndex, b_FirstRotate, b_ChangeDirection);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        #endregion

        #region tabPage_Servo
        private void btn_Rotate_Click(object sender, EventArgs e)
        {
            Form_Servo2 mForm_Servo2 = new Form_Servo2("IOlink_Rotate");
            mForm_Servo2.Show();
        }

        private void btn_L_Move_Cam_Click(object sender, EventArgs e)
        {
            new Form_Servo2("IOlink_L_Move_Cam").Show();
        }

        private void btn_F_Move_Cam_Click(object sender, EventArgs e)
        {
            new Form_Servo2("IOlink_F_Move_Cam").Show();
        }

        private void btn_R_Move_Cam_Click(object sender, EventArgs e)
        {
            new Form_Servo2("IOlink_R_Move_Cam").Show();
        }

        private void btn_B__Move_Cam_Click(object sender, EventArgs e)
        {
            new Form_Servo2("IOlink_B_Move_Cam").Show();
        }

        private void btn_D_Move_Cam_Click(object sender, EventArgs e)
        {
            new Form_Servo2("IOlink_D_Move_Cam").Show();
        }

        private void btn_L_Grab_Click(object sender, EventArgs e)
        {
            new Form_Servo2("IOlink_L_Grab").Show();
        }

        private void btn_F_Grab_Click(object sender, EventArgs e)
        {
            new Form_Servo2("IOlink_F_Grab").Show();
        }

        private void btn_R_Grab_Click(object sender, EventArgs e)
        {
            new Form_Servo2("IOlink_R_Grab").Show();
        }

        private void btn_B_Grab_Click(object sender, EventArgs e)
        {
            new Form_Servo2("IOlink_B_Grab").Show();
        }

        private void btn_Feeding_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_Feeding").Show();
        }

        private void btn_U_Grab_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_U_Grab").Show();
        }

        private void btn_D_Grab_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_D_Grab").Show();
        }

        private void btn_U_Move_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_U_Move").Show();
        }

        private void btn_D_Move_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_D_Move").Show();
        }

        private void btn_U_Rotate_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_U_Rotate").Show();
        }

        private void btn_L_Rotate_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_L_Rotate").Show();
        }

        private void btn_F_Rotate_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_F_Rotate").Show();
        }

        private void btn_R_Rotate_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_R_Rotate").Show();
        }

        private void btn_B_Rotate_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_B_Rotate").Show();
        }

        private void btn_D_Rotate_Click(object sender, EventArgs e)
        {
            new Form_Servo("servo_D_Rotate").Show();
        }


        #endregion


        private void Form_Manual_Load(object sender, EventArgs e)
        {
            updateLightStatus();
            if (GlobalVariables.lightStatus.o_U)
            {
                pic_L_U.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_U.Image = imageList1.Images[0];
            }
            if (GlobalVariables.lightStatus.o_D)
            {
                pic_L_D.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_D.Image = imageList1.Images[0];
            }
            if (GlobalVariables.lightStatus.o_L)
            {
                pic_L_L.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_L.Image = imageList1.Images[0];
            }
            if (GlobalVariables.lightStatus.o_R)
            {
                pic_L_R.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_R.Image = imageList1.Images[0];
            }
            if (GlobalVariables.lightStatus.o_F)
            {
                pic_L_F.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_F.Image = imageList1.Images[0];
            }
            if (GlobalVariables.lightStatus.o_B)
            {
                pic_L_B.Image = imageList1.Images[1];
            }
            else
            {
                pic_L_B.Image = imageList1.Images[0];
            }
            timer1.Enabled = true;
        }

        private void btn_U_Click(object sender, EventArgs e)
        {
            Form1.CamTrigger(CamID.CamU);
            btn_U1.BackColor = Form1.GetRGBvalue(CamID.CamU, 9);
            btn_U2.BackColor = Form1.GetRGBvalue(CamID.CamU, 8);
            btn_U3.BackColor = Form1.GetRGBvalue(CamID.CamU, 7);
            btn_U4.BackColor = Form1.GetRGBvalue(CamID.CamU, 6);
            btn_U5.BackColor = Form1.GetRGBvalue(CamID.CamU, 5);
            btn_U6.BackColor = Form1.GetRGBvalue(CamID.CamU, 4);
            btn_U7.BackColor = Form1.GetRGBvalue(CamID.CamU, 3);
            btn_U8.BackColor = Form1.GetRGBvalue(CamID.CamU, 2);
            btn_U9.BackColor = Form1.GetRGBvalue(CamID.CamU, 1);
           
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            Form1.CamTrigger(CamID.CamL);
            btn_L1.BackColor = Form1.GetRGBvalue(CamID.CamL, 1);
            btn_L2.BackColor = Form1.GetRGBvalue(CamID.CamL, 2);
            btn_L3.BackColor = Form1.GetRGBvalue(CamID.CamL, 3);
            btn_L4.BackColor = Form1.GetRGBvalue(CamID.CamL, 4);
            btn_L5.BackColor = Form1.GetRGBvalue(CamID.CamL, 5);
            btn_L6.BackColor = Form1.GetRGBvalue(CamID.CamL, 6);
            btn_L7.BackColor = Form1.GetRGBvalue(CamID.CamL, 7);
            btn_L8.BackColor = Form1.GetRGBvalue(CamID.CamL, 8);
            btn_L9.BackColor = Form1.GetRGBvalue(CamID.CamL, 9);
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            Form1.CamTrigger(CamID.CamF);
            btn_F1.BackColor = Form1.GetRGBvalue(CamID.CamF, 1);
            btn_F2.BackColor = Form1.GetRGBvalue(CamID.CamF, 2);
            btn_F3.BackColor = Form1.GetRGBvalue(CamID.CamF, 3);
            btn_F4.BackColor = Form1.GetRGBvalue(CamID.CamF, 4);
            btn_F5.BackColor = Form1.GetRGBvalue(CamID.CamF, 5);
            btn_F6.BackColor = Form1.GetRGBvalue(CamID.CamF, 6);
            btn_F7.BackColor = Form1.GetRGBvalue(CamID.CamF, 7);
            btn_F8.BackColor = Form1.GetRGBvalue(CamID.CamF, 8);
            btn_F9.BackColor = Form1.GetRGBvalue(CamID.CamF, 9);
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            Form1.CamTrigger(CamID.CamR);
            btn_R1.BackColor = Form1.GetRGBvalue(CamID.CamR, 1);
            btn_R2.BackColor = Form1.GetRGBvalue(CamID.CamR, 2);
            btn_R3.BackColor = Form1.GetRGBvalue(CamID.CamR, 3);
            btn_R4.BackColor = Form1.GetRGBvalue(CamID.CamR, 4);
            btn_R5.BackColor = Form1.GetRGBvalue(CamID.CamR, 5);
            btn_R6.BackColor = Form1.GetRGBvalue(CamID.CamR, 6);
            btn_R7.BackColor = Form1.GetRGBvalue(CamID.CamR, 7);
            btn_R8.BackColor = Form1.GetRGBvalue(CamID.CamR, 8);
            btn_R9.BackColor = Form1.GetRGBvalue(CamID.CamR, 9);
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            Form1.CamTrigger(CamID.CamB);
            btn_B1.BackColor = Form1.GetRGBvalue(CamID.CamB, 1);
            btn_B2.BackColor = Form1.GetRGBvalue(CamID.CamB, 2);
            btn_B3.BackColor = Form1.GetRGBvalue(CamID.CamB, 3);
            btn_B4.BackColor = Form1.GetRGBvalue(CamID.CamB, 4);
            btn_B5.BackColor = Form1.GetRGBvalue(CamID.CamB, 5);
            btn_B6.BackColor = Form1.GetRGBvalue(CamID.CamB, 6);
            btn_B7.BackColor = Form1.GetRGBvalue(CamID.CamB, 7);
            btn_B8.BackColor = Form1.GetRGBvalue(CamID.CamB, 8);
            btn_B9.BackColor = Form1.GetRGBvalue(CamID.CamB, 9);
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            Form1.CamTrigger(CamID.CamD);
            btn_D1.BackColor = Form1.GetRGBvalue(CamID.CamD, 1);
            btn_D2.BackColor = Form1.GetRGBvalue(CamID.CamD, 2);
            btn_D3.BackColor = Form1.GetRGBvalue(CamID.CamD, 3);
            btn_D4.BackColor = Form1.GetRGBvalue(CamID.CamD, 4);
            btn_D5.BackColor = Form1.GetRGBvalue(CamID.CamD, 5);
            btn_D6.BackColor = Form1.GetRGBvalue(CamID.CamD, 6);
            btn_D7.BackColor = Form1.GetRGBvalue(CamID.CamD, 7);
            btn_D8.BackColor = Form1.GetRGBvalue(CamID.CamD, 8);
            btn_D9.BackColor = Form1.GetRGBvalue(CamID.CamD, 9);
        }
    }
}

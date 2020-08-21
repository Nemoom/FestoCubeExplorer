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

        #endregion

        #region tabPage_Step
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

                        while (!(values[0] && values[1] && values[2] && values[3]))
                        {
                            Thread.Sleep(100);
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
                    //5个相机上下
                    try
                    {
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_In},
        new object[] { false, false, false, false, false });
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_Out},
        new object[] { true, true, true, true, true });
                        List<string> tags = new List<string>();
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Out);
                        tags.Add(GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Out);
                        List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());

                        while (!(values[0] && values[1] && values[2] && values[3] && values[4]))
                        {
                            Thread.Sleep(100);
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
                    rbtn_Rotate_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_Rotate.i_In = false;
                    rbtn_Rotate_P1.Checked = false;
                }
                if (values[1])
                {
                    GlobalVariables.IOlink_Rotate.i_Out = true;
                    rbtn_Rotate_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_Rotate.i_Out = false;
                    rbtn_Rotate_P2.Checked = false;
                }
                if (values[2])
                {
                    GlobalVariables.IOlink_Rotate.i_Device = true;
                    lbl_Status_Rotate.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_Rotate.i_Device = false;
                    lbl_Status_Rotate.BackColor = Color.Transparent;
                }
                #endregion
                #region F_Move_Cam
                if (values[1 * 3 + 0])
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_In = true;
                    rbtn_MoveF_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_In = false;
                    rbtn_MoveF_P1.Checked = false;
                }
                if (values[1 * 3 + 1])
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_Out = true;
                    rbtn_MoveF_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_Out = false;
                    rbtn_MoveF_P2.Checked = false;
                }
                if (values[1 * 3 + 2])
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_Device = true;
                    lbl_Status_MovCamF.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_F_Move_Cam.i_Device = false;
                    lbl_Status_MovCamF.BackColor = Color.Transparent;
                }
                #endregion
                #region B_Move_Cam
                if (values[2 * 3 + 0])
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_In = true;
                    rbtn_MoveB_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_In = false;
                    rbtn_MoveB_P1.Checked = false;
                }
                if (values[2 * 3 + 1])
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_Out = true;
                    rbtn_MoveB_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_Out = false;
                    rbtn_MoveB_P2.Checked = false;
                }
                if (values[2 * 3 + 2])
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_Device = true;
                    lbl_Status_MovCamB.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_B_Move_Cam.i_Device = false;
                    lbl_Status_MovCamB.BackColor = Color.Transparent;
                }
                #endregion
                #region L_Move_Cam
                if (values[3 * 3 + 0])
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_In = true;
                    rbtn_MoveL_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_In = false;
                    rbtn_MoveL_P1.Checked = false;
                }
                if (values[3 * 3 + 1])
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_Out = true;
                    rbtn_MoveL_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_Out = false;
                    rbtn_MoveL_P2.Checked = false;
                }
                if (values[3 * 3 + 2])
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_Device = true;
                    lbl_Status_MovCamL.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_L_Move_Cam.i_Device = false;
                    lbl_Status_MovCamL.BackColor = Color.Transparent;
                }
                #endregion
                #region R_Move_Cam
                if (values[4 * 3 + 0])
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_In = true;
                    rbtn_MoveR_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_In = false;
                    rbtn_MoveR_P1.Checked = false;
                }
                if (values[4 * 3 + 1])
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_Out = true;
                    rbtn_MoveR_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_Out = false;
                    rbtn_MoveR_P2.Checked = false;
                }
                if (values[4 * 3 + 2])
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_Device = true;
                    lbl_Status_MovCamR.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_R_Move_Cam.i_Device = false;
                    lbl_Status_MovCamR.BackColor = Color.Transparent;
                }
                #endregion
                #region D_Move_Cam
                if (values[5 * 3 + 0])
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_In = true;
                    rbtn_MoveD_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_In = false;
                    rbtn_MoveD_P1.Checked = false;
                }
                if (values[5 * 3 + 1])
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_Out = true;
                    rbtn_MoveD_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_Out = false;
                    rbtn_MoveD_P2.Checked = false;
                }
                if (values[5 * 3 + 2])
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_Device = true;
                    lbl_Status_MovCamD.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_D_Move_Cam.i_Device = false;
                    lbl_Status_MovCamD.BackColor = Color.Transparent;
                }
                #endregion
                #region F_Grab
                if (values[6 * 3 + 0])
                {
                    GlobalVariables.IOlink_F_Grab.i_In = true;
                    rbtn_GrabF_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Grab.i_In = false;
                    rbtn_GrabF_P1.Checked = false;
                }
                if (values[6 * 3 + 1])
                {
                    GlobalVariables.IOlink_F_Grab.i_Out = true;
                    rbtn_GrabF_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_F_Grab.i_Out = false;
                    rbtn_GrabF_P2.Checked = false;
                }
                if (values[6 * 3 + 2])
                {
                    GlobalVariables.IOlink_F_Grab.i_Device = true;
                    lbl_Status_GrabF.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_F_Grab.i_Device = false;
                    lbl_Status_GrabF.BackColor = Color.Transparent;
                }
                #endregion
                #region B_Grab
                if (values[7 * 3 + 0])
                {
                    GlobalVariables.IOlink_B_Grab.i_In = true;
                    rbtn_GrabB_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Grab.i_In = false;
                    rbtn_GrabB_P1.Checked = false;
                }
                if (values[7 * 3 + 1])
                {
                    GlobalVariables.IOlink_B_Grab.i_Out = true;
                    rbtn_GrabB_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_B_Grab.i_Out = false;
                    rbtn_GrabB_P2.Checked = false;
                }
                if (values[7 * 3 + 2])
                {
                    GlobalVariables.IOlink_B_Grab.i_Device = true;
                    lbl_Status_GrabB.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_B_Grab.i_Device = false;
                    lbl_Status_GrabB.BackColor = Color.Transparent;
                }
                #endregion
                #region L_Grab
                if (values[8 * 3 + 0])
                {
                    GlobalVariables.IOlink_L_Grab.i_In = true;
                    rbtn_GrabL_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Grab.i_In = false;
                    rbtn_GrabL_P1.Checked = false;
                }
                if (values[8 * 3 + 1])
                {
                    GlobalVariables.IOlink_L_Grab.i_Out = true;
                    rbtn_GrabL_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_L_Grab.i_Out = false;
                    rbtn_GrabL_P2.Checked = false;
                }
                if (values[8 * 3 + 2])
                {
                    GlobalVariables.IOlink_L_Grab.i_Device = true;
                    lbl_Status_GrabL.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_L_Grab.i_Device = false;
                    lbl_Status_GrabL.BackColor = Color.Transparent;
                }
                #endregion
                #region R_Grab
                if (values[9 * 3 + 0])
                {
                    GlobalVariables.IOlink_R_Grab.i_In = true;
                    rbtn_GrabR_P1.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Grab.i_In = false;
                    rbtn_GrabR_P1.Checked = false;
                }
                if (values[9 * 3 + 1])
                {
                    GlobalVariables.IOlink_R_Grab.i_Out = true;
                    rbtn_GrabR_P2.Checked = true;
                }
                else
                {
                    GlobalVariables.IOlink_R_Grab.i_Out = false;
                    rbtn_GrabR_P2.Checked = false;
                }
                if (values[9 * 3 + 2])
                {
                    GlobalVariables.IOlink_R_Grab.i_Device = true;
                    lbl_Status_GrabR.BackColor = Color.Transparent;
                }
                else
                {
                    GlobalVariables.IOlink_R_Grab.i_Device = false;
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
                List<string> tags = new List<string>();
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_ActPos);
                tags.Add(GlobalVariables.CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_ActPos);
                // 按照顺序定义的值
                List<float> values = Form1.m_OpcUaClient.ReadNodes<float>(tags.ToArray());
                lbl_ActPos_GrabU.Text = values[0].ToString();
                lbl_ActPos_GrabD.Text = values[1].ToString();
                lbl_ActPos_RotateU.Text = values[2].ToString();
                lbl_ActPos_RotateD.Text = values[3].ToString();
                lbl_ActPos_RotateL.Text = values[4].ToString();
                lbl_ActPos_RotateR.Text = values[5].ToString();
                lbl_ActPos_RotateF.Text = values[6].ToString();
                lbl_ActPos_RotateB.Text = values[7].ToString();
                lbl_ActPos_MoveU.Text = values[8].ToString();
                lbl_ActPos_MoveD.Text = values[9].ToString();
                lbl_ActPos_Feeding.Text = values[10].ToString();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }

        public static bool ServoGoto(string AxisID,int PointIndex)
        {
            ServoParas mServoParas = new ServoParas();
            double TargetPosition = 0;
            switch (AxisID)
            {
                case "servo_B_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                    break;
                case "servo_D_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                    break;
                case "servo_D_Move":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Move;
                    switch (PointIndex)
                    {
                        case 1:
                            TargetPosition = mServoParas.P1;
                            break;
                        case 2:
                            TargetPosition = mServoParas.P2;
                            break;
                    }
                    break;
                case "servo_D_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Rotate;
                    break;
                case "servo_Feeding":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_Feeding;
                    switch (PointIndex)
                    {
                        case 1:
                            TargetPosition = mServoParas.P1;
                            break;
                        case 2:
                            TargetPosition = mServoParas.P2;
                            break;
                    }
                    break;
                case "servo_F_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                    break;
                case "servo_L_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                    break;
                case "servo_R_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                    break;
                case "servo_U_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                    break;
                case "servo_U_Move":
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
                    break;
                case "servo_U_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Rotate;
                    break;
                default:
                    break;
            }

            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }

        public static bool ServoGoHome(string AxisID)
        {
            ServoParas mServoParas = new ServoParas();
            double TargetPosition = 0;
            switch (AxisID)
            {
                case "servo_B_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                    break;
                case "servo_D_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                    break;
                case "servo_D_Move":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Move;                    
                    break;
                case "servo_D_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Rotate;
                    break;
                case "servo_Feeding":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_Feeding;
                    //确定D相机，D杆都在原位
                    if (true)
                    {
                        break;
                    }
                    else
                    {
                        return false;                        
                    }                                 
                case "servo_F_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                    break;
                case "servo_L_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                    break;
                case "servo_R_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                    break;
                case "servo_U_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                    break;
                case "servo_U_Move":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Move;                   
                    break;
                case "servo_U_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Rotate;
                    break;
                default:
                    break;
            }

            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
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
            ServoGoHome("servo_L_Rotate");
            ServoGoHome("servo_R_Rotate");
            ServoGoHome("servo_F_Rotate");
            ServoGoHome("servo_B_Rotate");
            
            ServoGoHome("servo_D_Grab");//魔方落回台子上
            ServoGoHome("servo_U_Rotate");
            ServoGoHome("servo_D_Rotate");
            IOlinkAxisIn(1);//魔方姿态回0位拍照位
            //确定D相机，D杆都在原位
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
    }
}

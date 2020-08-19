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
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_Out, (short)0);
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_In, (short)1);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_In, (short)0);
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
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_In, (short)0);
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_Out, (short)1);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_Out, (short)0);
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
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_QuitError, (short)1);
                Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_QuitError, (short)0);
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
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_Out, (short)0);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_In, (short)1);
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_In, (short)0);
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
        new object[] { (short)0, 0, 0, 0 });
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_In},
        new object[] { (short)1, 1, 1, 1 });
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_In},
        new object[] { (short)0, 0, 0, 0 });
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
        new object[] { (short)0, 0, 0, 0, 0 });
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_In},
        new object[] { (short)1, 1, 1, 1, 1 });
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_In,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_In},
        new object[] { (short)0, 0, 0, 0, 0 });
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
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_In, (short)0);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_Out, (short)1);
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.IOlink_Rotate.NodeID_o_Out, (short)0);
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
        new object[] { (short)0, 0, 0, 0 });
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_Out},
        new object[] { (short)1, 1, 1, 1 });
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_Out},
        new object[] { (short)0, 0, 0, 0 });
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
        new object[] { (short)0, 0, 0, 0, 0 });
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_Out},
        new object[] { (short)1, 1, 1, 1, 1 });
                        Thread.Sleep(100);
                        Form1.m_OpcUaClient.WriteNodes(new string[] {
        GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_Out,
        GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_Out},
        new object[] { (short)0, 0, 0, 0, 0 });
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
                    rbtn_Rotate_P1.Checked = true;
                }
                else
                {
                    rbtn_Rotate_P1.Checked = false;
                }
                if (values[1])
                {
                    rbtn_Rotate_P2.Checked = true;
                }
                else
                {
                    rbtn_Rotate_P2.Checked = false;
                }
                if (values[2])
                {
                    lbl_Status_Rotate.BackColor = Color.Transparent;
                }
                else
                {
                    lbl_Status_Rotate.BackColor = Color.Transparent;
                }
                #endregion
                #region F_Move_Cam
                if (values[1 * 3 + 0])
                {
                    rbtn_MoveF_P1.Checked = true;
                }
                else
                {
                    rbtn_MoveF_P1.Checked = false;
                }
                if (values[1 * 3 + 1])
                {
                    rbtn_MoveF_P2.Checked = true;
                }
                else
                {
                    rbtn_MoveF_P2.Checked = false;
                }
                if (values[1 * 3 + 2])
                {
                    lbl_Status_MovCamF.BackColor = Color.Transparent;
                }
                else
                {
                    lbl_Status_MovCamF.BackColor = Color.Transparent;
                }
                #endregion
                #region B_Move_Cam
                if (values[2 * 3 + 0])
                {
                    rbtn_MoveB_P1.Checked = true;
                }
                else
                {
                    rbtn_MoveB_P1.Checked = false;
                }
                if (values[2 * 3 + 1])
                {
                    rbtn_MoveB_P2.Checked = true;
                }
                else
                {
                    rbtn_MoveB_P2.Checked = false;
                }
                if (values[2 * 3 + 2])
                {
                    lbl_Status_MovCamB.BackColor = Color.Transparent;
                }
                else
                {
                    lbl_Status_MovCamB.BackColor = Color.Transparent;
                }
                #endregion
                #region L_Move_Cam
                if (values[3 * 3 + 0])
                {
                    rbtn_MoveL_P1.Checked = true;
                }
                else
                {
                    rbtn_MoveL_P1.Checked = false;
                }
                if (values[3 * 3 + 1])
                {
                    rbtn_MoveL_P2.Checked = true;
                }
                else
                {
                    rbtn_MoveL_P2.Checked = false;
                }
                if (values[3 * 3 + 2])
                {
                    lbl_Status_MovCamL.BackColor = Color.Transparent;
                }
                else
                {
                    lbl_Status_MovCamL.BackColor = Color.Transparent;
                }
                #endregion
                #region R_Move_Cam
                if (values[4 * 3 + 0])
                {
                    rbtn_MoveR_P1.Checked = true;
                }
                else
                {
                    rbtn_MoveR_P1.Checked = false;
                }
                if (values[4 * 3 + 1])
                {
                    rbtn_MoveR_P2.Checked = true;
                }
                else
                {
                    rbtn_MoveR_P2.Checked = false;
                }
                if (values[4 * 3 + 2])
                {
                    lbl_Status_MovCamR.BackColor = Color.Transparent;
                }
                else
                {
                    lbl_Status_MovCamR.BackColor = Color.Transparent;
                }
                #endregion
                #region D_Move_Cam
                if (values[5 * 3 + 0])
                {
                    rbtn_MoveD_P1.Checked = true;
                }
                else
                {
                    rbtn_MoveD_P1.Checked = false;
                }
                if (values[5 * 3 + 1])
                {
                    rbtn_MoveD_P2.Checked = true;
                }
                else
                {
                    rbtn_MoveD_P2.Checked = false;
                }
                if (values[5 * 3 + 2])
                {
                    lbl_Status_MovCamD.BackColor = Color.Transparent;
                }
                else
                {
                    lbl_Status_MovCamD.BackColor = Color.Transparent;
                }
                #endregion
                #region F_Grab
                if (values[6 * 3 + 0])
                {
                    rbtn_GrabF_P1.Checked = true;
                }
                else
                {
                    rbtn_GrabF_P1.Checked = false;
                }
                if (values[6 * 3 + 1])
                {
                    rbtn_GrabF_P2.Checked = true;
                }
                else
                {
                    rbtn_GrabF_P2.Checked = false;
                }
                if (values[6 * 3 + 2])
                {
                    lbl_Status_GrabF.BackColor = Color.Transparent;
                }
                else
                {
                    lbl_Status_GrabF.BackColor = Color.Transparent;
                }
                #endregion
                #region B_Grab
                if (values[7 * 3 + 0])
                {
                    rbtn_GrabB_P1.Checked = true;
                }
                else
                {
                    rbtn_GrabB_P1.Checked = false;
                }
                if (values[7 * 3 + 1])
                {
                    rbtn_GrabB_P2.Checked = true;
                }
                else
                {
                    rbtn_GrabB_P2.Checked = false;
                }
                if (values[7 * 3 + 2])
                {
                    lbl_Status_GrabB.BackColor = Color.Transparent;
                }
                else
                {
                    lbl_Status_GrabB.BackColor = Color.Transparent;
                }
                #endregion
                #region L_Grab
                if (values[8 * 3 + 0])
                {
                    rbtn_GrabL_P1.Checked = true;
                }
                else
                {
                    rbtn_GrabL_P1.Checked = false;
                }
                if (values[8 * 3 + 1])
                {
                    rbtn_GrabL_P2.Checked = true;
                }
                else
                {
                    rbtn_GrabL_P2.Checked = false;
                }
                if (values[8 * 3 + 2])
                {
                    lbl_Status_GrabL.BackColor = Color.Transparent;
                }
                else
                {
                    lbl_Status_GrabL.BackColor = Color.Transparent;
                }
                #endregion
                #region R_Grab
                if (values[9 * 3 + 0])
                {
                    rbtn_GrabR_P1.Checked = true;
                }
                else
                {
                    rbtn_GrabR_P1.Checked = false;
                }
                if (values[9 * 3 + 1])
                {
                    rbtn_GrabR_P2.Checked = true;
                }
                else
                {
                    rbtn_GrabR_P2.Checked = false;
                }
                if (values[9 * 3 + 2])
                {
                    lbl_Status_GrabR.BackColor = Color.Transparent;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
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
    }
}

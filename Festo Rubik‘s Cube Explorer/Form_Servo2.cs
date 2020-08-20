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
    public partial class Form_Servo2 : Form
    {
        string AxisID;
        IOlinkNodeID mIOlinkNodeID = new IOlinkNodeID();
        public Form_Servo2(string mAxisID)
        {
            InitializeComponent();
            AxisID = mAxisID;
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
        }

        private void btn_o_In_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {                
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_In, true);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_In_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_In, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_Out_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_Out, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_Out_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_Out, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_QuitError_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_QuitError, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_QuitError_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mIOlinkNodeID.NodeID_o_QuitError, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {   
                List<string> tags = new List<string>();
                tags.Add(mIOlinkNodeID.NodeID_i_In);
                tags.Add(mIOlinkNodeID.NodeID_i_Out);
                tags.Add(mIOlinkNodeID.NodeID_i_Move);
                tags.Add(mIOlinkNodeID.NodeID_i_Device);

                // 按照顺序定义的值
                List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                if (values[0])
                {
                    lbl_i_In.Image = imageList_Status.Images[1];
                }
                else
                {
                    lbl_i_In.Image = imageList_Status.Images[0];
                }
                if (values[1])
                {
                    lbl_i_Out.Image = imageList_Status.Images[1];
                }
                else
                {
                    lbl_i_Out.Image = imageList_Status.Images[0];
                }
                if (values[2])
                {
                    lbl_i_Move.Image = imageList_Status.Images[1];
                }
                else
                {
                    lbl_i_Move.Image = imageList_Status.Images[0];
                }
                if (values[3])
                {
                    lbl_i_Device.Image = imageList_Status.Images[1];
                }
                else
                {
                    lbl_i_Device.Image = imageList_Status.Images[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form_Servo2_Load(object sender, EventArgs e)
        {
            lbl_ServoName.Text = AxisID;
            timer1.Enabled = true;
        }
    }
}

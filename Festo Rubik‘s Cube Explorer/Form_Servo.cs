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
    public partial class Form_Servo : Form
    {
        string AxisID;
        ServoParas mServoParas;
        public Form_Servo(string mAxisID)
        {
            InitializeComponent();
            AxisID = mAxisID;
            switch (AxisID)
            {
                case "servo_Feeding":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_Feeding;
                    break;
                case "servo_U_Move":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Move;
                    break;
                case "servo_D_Move":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Move;
                    break;
                case "servo_U_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                    break;
                case "servo_D_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                    break;
                case "servo_U_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Rotate;
                    break;
                case "servo_D_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Rotate;
                    break;
                case "servo_F_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                    break;
                case "servo_B_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                    break;
                case "servo_L_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                    break;
                case "servo_R_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                    break;
                default:
                    break;
            }
        }

        private void Form_Servo_Load(object sender, EventArgs e)
        {
            lbl_ServoName.Text = AxisID;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                List<Opc.Ua.NodeId> nodeIds = new List<Opc.Ua.NodeId>();
                nodeIds.Add(mServoParas.mServoNodeID.NodeID_i_Enable);
                nodeIds.Add(mServoParas.mServoNodeID.NodeID_i_Error);
                nodeIds.Add(mServoParas.mServoNodeID.NodeID_i_Home);
                nodeIds.Add(mServoParas.mServoNodeID.NodeID_i_MC);
                nodeIds.Add(mServoParas.mServoNodeID.NodeID_i_ActPos);

                // 按照顺序定义的值
                List<Opc.Ua.DataValue> values = Form1.m_OpcUaClient.ReadNodes(nodeIds.ToArray());
                if (values[0].ToString()=="True")
                {
                    lbl_i_Enable.Image = imageList_Status.Images[1];
                }
                else
                {
                    lbl_i_Enable.Image = imageList_Status.Images[0];
                }
                if (values[1].ToString() == "True")
                {
                    lbl_i_Error.Image = imageList_Status.Images[1];
                }
                else
                {
                    lbl_i_Error.Image = imageList_Status.Images[0];
                }
                if (values[2].ToString() == "True")
                {
                    lbl_i_Home.Image = imageList_Status.Images[1];
                }
                else
                {
                    lbl_i_Home.Image = imageList_Status.Images[0];
                }
                if (values[3].ToString() == "True")
                {
                    lbl_i_MC.Image = imageList_Status.Images[1];
                }
                else
                {
                    lbl_i_MC.Image = imageList_Status.Images[0];
                }
                txt_i_ActPos.Text = values[4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbx_o_Enable_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbx_o_Enable_Click(object sender, EventArgs e)
        {
            if (cbx_o_Enable.Checked)
            {
                cbx_o_Enable.Checked = false;
                try
                {
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                cbx_o_Enable.Checked = true;
                try
                {
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_o_Reset_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_Reset_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_JogNegative_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_JogNegative, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_JogNegative_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_JogNegative, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_JogPositive_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_JogPositive, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_JogPositive_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_JogPositive, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_o_Go_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.m_OpcUaClient.WriteNodes(new string[] {
                mServoParas.mServoNodeID.NodeID_o_Vel,
                mServoParas.mServoNodeID.NodeID_o_Acc,
                mServoParas.mServoNodeID.NodeID_o_Dec,
                mServoParas.mServoNodeID.NodeID_o_Jerk,
                mServoParas.mServoNodeID.NodeID_o_Pos},
                new object[] {
                    Convert.ToSingle(txt_o_Vel.Text),
                    Convert.ToSingle(txt_o_Acc.Text),
                    Convert.ToSingle(txt_o_Dec.Text),
                    Convert.ToSingle(txt_o_Jerk.Text),
                    Convert.ToSingle(txt_o_Pos.Text)
                });
                //Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Vel, Convert.ToSingle(txt_o_Vel.Text));
                Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, true);
                System.Threading.Thread.Sleep(100);
                Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

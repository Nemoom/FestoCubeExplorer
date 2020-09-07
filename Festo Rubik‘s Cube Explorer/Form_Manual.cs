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
        Form1 form1;
        public static bool b_P_Start = false;
        public static bool b_P_Acquire = false;
        public static bool b_P_Rotate = false;
        public Form_Manual(Form1 mform1)
        {
            InitializeComponent();
            form1 = mform1;
        }
        #region tabPage_Cam
        public static void updateLightStatus()
        {
            if (Form1.m_OpcUaClient.Connected)
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
        }
        public void updateCamStatus()
        {
            if (Form1.b_CamU_Connected)
            {
                lbl_Status_U.Text = "已连接";
                lbl_Status_U.BackColor = Color.Green;
            }
            else
            {
                lbl_Status_U.Text = "未连接";
                lbl_Status_U.BackColor = Color.Red;
            }
            if (Form1.b_CamD_Connected)
            {
                lbl_Status_D.Text = "已连接";
                lbl_Status_D.BackColor = Color.Green;
            }
            else
            {
                lbl_Status_D.Text = "未连接";
                lbl_Status_D.BackColor = Color.Red;
            }
            if (Form1.b_CamL_Connected)
            {
                lbl_Status_L.Text = "已连接";
                lbl_Status_L.BackColor = Color.Green;
            }
            else
            {
                lbl_Status_L.Text = "未连接";
                lbl_Status_L.BackColor = Color.Red;
            }
            if (Form1.b_CamR_Connected)
            {
                lbl_Status_R.Text = "已连接";
                lbl_Status_R.BackColor = Color.Green;
            }
            else
            {
                lbl_Status_R.Text = "未连接";
                lbl_Status_R.BackColor = Color.Red;
            }
            if (Form1.b_CamF_Connected)
            {
                lbl_Status_F.Text = "已连接";
                lbl_Status_F.BackColor = Color.Green;
            }              
            else           
            {              
                lbl_Status_F.Text = "未连接";
                lbl_Status_F.BackColor = Color.Red;
            }
            if (Form1.b_CamB_Connected)
            {
                lbl_Status_B.Text = "已连接";
                lbl_Status_B.BackColor = Color.Green;
            }            
            else         
            {            
                lbl_Status_B.Text = "未连接";
                lbl_Status_B.BackColor = Color.Red;
            }
        }
        private void btn_ColorLearning_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning().Show();
        }

        #region L Setting
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
            new Form_ColorLearning("L_C").Show();
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

        #region U Setting
        private void btn_U9_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("U").Show();
        }

        private void btn_U2_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("U").Show();
        }

        private void btn_U3_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("U").Show();
        }

        private void btn_U4_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("U").Show();
        }

        private void btn_U5_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("U_C").Show();
        }

        private void btn_U6_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("U").Show();
        }

        private void btn_U7_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("U").Show();
        }

        private void btn_U8_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("U").Show();
        }

        private void btn_U1_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("U").Show();
        }
        #endregion

        #region B Setting
        private void btn_B9_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("B").Show();
        }

        private void btn_B1_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("B").Show();
        }

        private void btn_B2_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("B").Show();
        }

        private void btn_B4_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("B").Show();
        }

        private void btn_B5_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("B_C").Show();
        }

        private void btn_B6_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("B").Show();
        }

        private void btn_B7_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("B").Show();
        }

        private void btn_B8_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("B").Show();
        }

        private void btn_B3_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("B").Show();
        }
        #endregion

        #region R Setting
        private void btn_R9_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("R").Show();
        }

        private void btn_R2_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("R").Show();
        }

        private void btn_R3_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("R").Show();
        }

        private void btn_R4_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("R").Show();
        }

        private void btn_R5_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("R_C").Show();
        }

        private void btn_R6_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("R").Show();
        }

        private void btn_R7_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("R").Show();
        }

        private void btn_R8_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("R").Show();
        }

        private void btn_R1_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("R").Show();
        }
        #endregion

        #region F Setting
        private void btn_F9_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("F").Show();
        }

        private void btn_F2_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("F").Show();
        }

        private void btn_F3_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("F").Show();
        }

        private void btn_F4_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("F").Show();
        }

        private void btn_F5_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("F_C").Show();
        }

        private void btn_F6_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("F").Show();
        }

        private void btn_F7_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("F").Show();
        }

        private void btn_F8_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("F").Show();
        }

        private void btn_F1_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("F").Show();
        }
        #endregion

        #region D Setting
        private void btn_D9_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("D").Show();
        }

        private void btn_D2_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("D").Show();
        }

        private void btn_D3_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("D").Show();
        }

        private void btn_D4_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("D").Show();
        }

        private void btn_D5_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("D_C").Show();
        }

        private void btn_D6_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("D").Show();
        }

        private void btn_D7_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("D").Show();
        }

        private void btn_D8_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("D").Show();
        }

        private void btn_D1_Click(object sender, EventArgs e)
        {
            new Form_ColorLearning("D").Show();
        } 
        #endregion

        #region LightControl
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

        #region 6 Camera trigger
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
            btn_U1.Text = btn_U1.BackColor.R.ToString() + "\n" + btn_U1.BackColor.G.ToString() + "\n" + btn_U1.BackColor.B.ToString();
            btn_U2.Text = btn_U2.BackColor.R.ToString() + "\n" + btn_U2.BackColor.G.ToString() + "\n" + btn_U2.BackColor.B.ToString();
            btn_U3.Text = btn_U3.BackColor.R.ToString() + "\n" + btn_U3.BackColor.G.ToString() + "\n" + btn_U3.BackColor.B.ToString();
            btn_U4.Text = btn_U4.BackColor.R.ToString() + "\n" + btn_U4.BackColor.G.ToString() + "\n" + btn_U4.BackColor.B.ToString();
            btn_U5.Text = btn_U5.BackColor.R.ToString() + "\n" + btn_U5.BackColor.G.ToString() + "\n" + btn_U5.BackColor.B.ToString();
            btn_U6.Text = btn_U6.BackColor.R.ToString() + "\n" + btn_U6.BackColor.G.ToString() + "\n" + btn_U6.BackColor.B.ToString();
            btn_U7.Text = btn_U7.BackColor.R.ToString() + "\n" + btn_U7.BackColor.G.ToString() + "\n" + btn_U7.BackColor.B.ToString();
            btn_U8.Text = btn_U8.BackColor.R.ToString() + "\n" + btn_U8.BackColor.G.ToString() + "\n" + btn_U8.BackColor.B.ToString();
            btn_U9.Text = btn_U9.BackColor.R.ToString() + "\n" + btn_U9.BackColor.G.ToString() + "\n" + btn_U9.BackColor.B.ToString();
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
            btn_L1.Text = btn_L1.BackColor.R.ToString() + "\n" + btn_L1.BackColor.G.ToString() + "\n" + btn_L1.BackColor.B.ToString();
            btn_L2.Text = btn_L2.BackColor.R.ToString() + "\n" + btn_L2.BackColor.G.ToString() + "\n" + btn_L2.BackColor.B.ToString();
            btn_L3.Text = btn_L3.BackColor.R.ToString() + "\n" + btn_L3.BackColor.G.ToString() + "\n" + btn_L3.BackColor.B.ToString();
            btn_L4.Text = btn_L4.BackColor.R.ToString() + "\n" + btn_L4.BackColor.G.ToString() + "\n" + btn_L4.BackColor.B.ToString();
            btn_L5.Text = btn_L5.BackColor.R.ToString() + "\n" + btn_L5.BackColor.G.ToString() + "\n" + btn_L5.BackColor.B.ToString();
            btn_L6.Text = btn_L6.BackColor.R.ToString() + "\n" + btn_L6.BackColor.G.ToString() + "\n" + btn_L6.BackColor.B.ToString();
            btn_L7.Text = btn_L7.BackColor.R.ToString() + "\n" + btn_L7.BackColor.G.ToString() + "\n" + btn_L7.BackColor.B.ToString();
            btn_L8.Text = btn_L8.BackColor.R.ToString() + "\n" + btn_L8.BackColor.G.ToString() + "\n" + btn_L8.BackColor.B.ToString();
            btn_L9.Text = btn_L9.BackColor.R.ToString() + "\n" + btn_L9.BackColor.G.ToString() + "\n" + btn_L9.BackColor.B.ToString();
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
            btn_F1.Text = btn_F1.BackColor.R.ToString() + "\n" + btn_F1.BackColor.G.ToString() + "\n" + btn_F1.BackColor.B.ToString();
            btn_F2.Text = btn_F2.BackColor.R.ToString() + "\n" + btn_F2.BackColor.G.ToString() + "\n" + btn_F2.BackColor.B.ToString();
            btn_F3.Text = btn_F3.BackColor.R.ToString() + "\n" + btn_F3.BackColor.G.ToString() + "\n" + btn_F3.BackColor.B.ToString();
            btn_F4.Text = btn_F4.BackColor.R.ToString() + "\n" + btn_F4.BackColor.G.ToString() + "\n" + btn_F4.BackColor.B.ToString();
            btn_F5.Text = btn_F5.BackColor.R.ToString() + "\n" + btn_F5.BackColor.G.ToString() + "\n" + btn_F5.BackColor.B.ToString();
            btn_F6.Text = btn_F6.BackColor.R.ToString() + "\n" + btn_F6.BackColor.G.ToString() + "\n" + btn_F6.BackColor.B.ToString();
            btn_F7.Text = btn_F7.BackColor.R.ToString() + "\n" + btn_F7.BackColor.G.ToString() + "\n" + btn_F7.BackColor.B.ToString();
            btn_F8.Text = btn_F8.BackColor.R.ToString() + "\n" + btn_F8.BackColor.G.ToString() + "\n" + btn_F8.BackColor.B.ToString();
            btn_F9.Text = btn_F9.BackColor.R.ToString() + "\n" + btn_F9.BackColor.G.ToString() + "\n" + btn_F9.BackColor.B.ToString();
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
            btn_R1.Text = btn_R1.BackColor.R.ToString() + "\n" + btn_R1.BackColor.G.ToString() + "\n" + btn_R1.BackColor.B.ToString();
            btn_R2.Text = btn_R2.BackColor.R.ToString() + "\n" + btn_R2.BackColor.G.ToString() + "\n" + btn_R2.BackColor.B.ToString();
            btn_R3.Text = btn_R3.BackColor.R.ToString() + "\n" + btn_R3.BackColor.G.ToString() + "\n" + btn_R3.BackColor.B.ToString();
            btn_R4.Text = btn_R4.BackColor.R.ToString() + "\n" + btn_R4.BackColor.G.ToString() + "\n" + btn_R4.BackColor.B.ToString();
            btn_R5.Text = btn_R5.BackColor.R.ToString() + "\n" + btn_R5.BackColor.G.ToString() + "\n" + btn_R5.BackColor.B.ToString();
            btn_R6.Text = btn_R6.BackColor.R.ToString() + "\n" + btn_R6.BackColor.G.ToString() + "\n" + btn_R6.BackColor.B.ToString();
            btn_R7.Text = btn_R7.BackColor.R.ToString() + "\n" + btn_R7.BackColor.G.ToString() + "\n" + btn_R7.BackColor.B.ToString();
            btn_R8.Text = btn_R8.BackColor.R.ToString() + "\n" + btn_R8.BackColor.G.ToString() + "\n" + btn_R8.BackColor.B.ToString();
            btn_R9.Text = btn_R9.BackColor.R.ToString() + "\n" + btn_R9.BackColor.G.ToString() + "\n" + btn_R9.BackColor.B.ToString();
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
            btn_B1.Text = btn_B1.BackColor.R.ToString() + "\n" + btn_B1.BackColor.G.ToString() + "\n" + btn_B1.BackColor.B.ToString();
            btn_B2.Text = btn_B2.BackColor.R.ToString() + "\n" + btn_B2.BackColor.G.ToString() + "\n" + btn_B2.BackColor.B.ToString();
            btn_B3.Text = btn_B3.BackColor.R.ToString() + "\n" + btn_B3.BackColor.G.ToString() + "\n" + btn_B3.BackColor.B.ToString();
            btn_B4.Text = btn_B4.BackColor.R.ToString() + "\n" + btn_B4.BackColor.G.ToString() + "\n" + btn_B4.BackColor.B.ToString();
            btn_B5.Text = btn_B5.BackColor.R.ToString() + "\n" + btn_B5.BackColor.G.ToString() + "\n" + btn_B5.BackColor.B.ToString();
            btn_B6.Text = btn_B6.BackColor.R.ToString() + "\n" + btn_B6.BackColor.G.ToString() + "\n" + btn_B6.BackColor.B.ToString();
            btn_B7.Text = btn_B7.BackColor.R.ToString() + "\n" + btn_B7.BackColor.G.ToString() + "\n" + btn_B7.BackColor.B.ToString();
            btn_B8.Text = btn_B8.BackColor.R.ToString() + "\n" + btn_B8.BackColor.G.ToString() + "\n" + btn_B8.BackColor.B.ToString();
            btn_B9.Text = btn_B9.BackColor.R.ToString() + "\n" + btn_B9.BackColor.G.ToString() + "\n" + btn_B9.BackColor.B.ToString();
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
            btn_D1.Text = btn_D1.BackColor.R.ToString() + "\n" + btn_D1.BackColor.G.ToString() + "\n" + btn_D1.BackColor.B.ToString();
            btn_D2.Text = btn_D2.BackColor.R.ToString() + "\n" + btn_D2.BackColor.G.ToString() + "\n" + btn_D2.BackColor.B.ToString();
            btn_D3.Text = btn_D3.BackColor.R.ToString() + "\n" + btn_D3.BackColor.G.ToString() + "\n" + btn_D3.BackColor.B.ToString();
            btn_D4.Text = btn_D4.BackColor.R.ToString() + "\n" + btn_D4.BackColor.G.ToString() + "\n" + btn_D4.BackColor.B.ToString();
            btn_D5.Text = btn_D5.BackColor.R.ToString() + "\n" + btn_D5.BackColor.G.ToString() + "\n" + btn_D5.BackColor.B.ToString();
            btn_D6.Text = btn_D6.BackColor.R.ToString() + "\n" + btn_D6.BackColor.G.ToString() + "\n" + btn_D6.BackColor.B.ToString();
            btn_D7.Text = btn_D7.BackColor.R.ToString() + "\n" + btn_D7.BackColor.G.ToString() + "\n" + btn_D7.BackColor.B.ToString();
            btn_D8.Text = btn_D8.BackColor.R.ToString() + "\n" + btn_D8.BackColor.G.ToString() + "\n" + btn_D8.BackColor.B.ToString();
            btn_D9.Text = btn_D9.BackColor.R.ToString() + "\n" + btn_D9.BackColor.G.ToString() + "\n" + btn_D9.BackColor.B.ToString();
        }

        #endregion

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
            if (Form1.m_OpcUaClient.Connected)
            {
                try
                {
                    if (updateAxisStatus())
                    {
                        updateForm();
                    }
                    else
                    {
                        //timer1.Enabled = false;
                        Form1.m_OpcUaClient.Disconnect();
                    }
                    
                }
                catch (Exception)
                {
                    timer1.Enabled = false;
                }
            }
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
        public static bool updateAxisStatus()
        {
            b_P_Start = false;
            b_P_Acquire = false;
            b_P_Rotate = false;
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
                return false;
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
                return false;
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
                return false;
            }
            #endregion
            if (GlobalVariables.IOlink_D_Move_Cam.i_In&& GlobalVariables.IOlink_F_Move_Cam.i_In && GlobalVariables.IOlink_B_Move_Cam.i_In
                && GlobalVariables.IOlink_L_Move_Cam.i_In && GlobalVariables.IOlink_R_Move_Cam.i_In
                && GlobalVariables.IOlink_Rotate.i_In 
                && GlobalVariables.IOlink_F_Grab.i_In && GlobalVariables.IOlink_B_Grab.i_In
                && GlobalVariables.IOlink_L_Grab.i_In && GlobalVariables.IOlink_R_Grab.i_In
                && GlobalVariables.servo_U_Grab.b_P1 && GlobalVariables.servo_D_Grab.b_P1
                && GlobalVariables.servo_Feeding.b_P1
                && GlobalVariables.servo_U_Move.b_P1 && GlobalVariables.servo_D_Move.b_P1)
            {
                b_P_Start = true;
                b_P_Acquire = false;
                b_P_Rotate = false;
            }
            else if (GlobalVariables.IOlink_F_Move_Cam.i_Out && GlobalVariables.IOlink_B_Move_Cam.i_Out
                && GlobalVariables.IOlink_L_Move_Cam.i_Out && GlobalVariables.IOlink_R_Move_Cam.i_Out
                && GlobalVariables.IOlink_Rotate.i_In
                && GlobalVariables.IOlink_F_Grab.i_In && GlobalVariables.IOlink_B_Grab.i_In
                && GlobalVariables.IOlink_L_Grab.i_In && GlobalVariables.IOlink_R_Grab.i_In
                && GlobalVariables.servo_U_Grab.b_P1 && GlobalVariables.servo_D_Grab.b_P1
                && GlobalVariables.servo_Feeding.b_P2
                && GlobalVariables.servo_U_Move.b_P1 && GlobalVariables.servo_D_Move.b_P1)
            {
                b_P_Start = false;
                b_P_Acquire = true;
                b_P_Rotate = false;
            }
            else if (GlobalVariables.IOlink_D_Move_Cam.i_In && GlobalVariables.IOlink_F_Move_Cam.i_In && GlobalVariables.IOlink_B_Move_Cam.i_In
                && GlobalVariables.IOlink_L_Move_Cam.i_In && GlobalVariables.IOlink_R_Move_Cam.i_In
                && GlobalVariables.IOlink_Rotate.i_Out
                && GlobalVariables.IOlink_F_Grab.i_Out && GlobalVariables.IOlink_B_Grab.i_Out
                && GlobalVariables.IOlink_L_Grab.i_Out && GlobalVariables.IOlink_R_Grab.i_Out
                && GlobalVariables.servo_U_Grab.b_P2 && GlobalVariables.servo_D_Grab.b_P2
                && GlobalVariables.servo_Feeding.b_P2
                && GlobalVariables.servo_U_Move.b_P2 && GlobalVariables.servo_D_Move.b_P2)
            {
                b_P_Start = false;
                b_P_Acquire = false;
                b_P_Rotate = true;
            }
            return true;
        }
        public static void updateAxisStatus(string AxisID)
        {
            IOlinkNodeID mIOlinkNodeID = new IOlinkNodeID();
            IOlinkStatus mIOlinkStatus = new IOlinkStatus();
            ServoParas mServoParas = new ServoParas();
            ServoStatus mServoStatus = new ServoStatus();
            bool b_isServo = false;
            switch (AxisID)
            {
                case "IOlink_Rotate":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_Rotate;
                    mIOlinkStatus = GlobalVariables.IOlink_Rotate;
                    break;
                case "IOlink_F_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_F_Move_Cam;
                    mIOlinkStatus = GlobalVariables.IOlink_F_Move_Cam;
                    break;
                case "IOlink_B_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_B_Move_Cam;
                    mIOlinkStatus = GlobalVariables.IOlink_B_Move_Cam;
                    break;
                case "IOlink_L_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_L_Move_Cam;
                    mIOlinkStatus = GlobalVariables.IOlink_L_Move_Cam;
                    break;
                case "IOlink_R_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_R_Move_Cam;
                    mIOlinkStatus = GlobalVariables.IOlink_R_Move_Cam;
                    break;
                case "IOlink_D_Move_Cam":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_D_Move_Cam;
                    mIOlinkStatus = GlobalVariables.IOlink_D_Move_Cam;
                    break;
                case "IOlink_F_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_F_Grab;
                    mIOlinkStatus = GlobalVariables.IOlink_F_Grab;
                    break;
                case "IOlink_B_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_B_Grab;
                    mIOlinkStatus = GlobalVariables.IOlink_B_Grab;
                    break;
                case "IOlink_L_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_L_Grab;
                    mIOlinkStatus = GlobalVariables.IOlink_L_Grab;
                    break;
                case "IOlink_R_Grab":
                    mIOlinkNodeID = GlobalVariables.CurrentParas.mPLC.IOlink_R_Grab;
                    mIOlinkStatus = GlobalVariables.IOlink_R_Grab;
                    break;
                case "servo_B_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                    mServoStatus = GlobalVariables.servo_B_Rotate;
                    b_isServo = true;
                    break;
                case "servo_D_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                    mServoStatus = GlobalVariables.servo_D_Grab;
                    b_isServo = true;
                    break;
                case "servo_D_Move":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Move;
                    mServoStatus = GlobalVariables.servo_D_Move;
                    b_isServo = true;
                    break;
                case "servo_D_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Rotate;
                    mServoStatus = GlobalVariables.servo_D_Rotate;
                    b_isServo = true;
                    break;
                case "servo_Feeding":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_Feeding;
                    mServoStatus = GlobalVariables.servo_Feeding;
                    b_isServo = true;
                    break;
                case "servo_F_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                    mServoStatus = GlobalVariables.servo_F_Rotate;
                    b_isServo = true;
                    break;
                case "servo_L_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                    mServoStatus = GlobalVariables.servo_L_Rotate;
                    b_isServo = true;
                    break;
                case "servo_R_Rotate":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                    mServoStatus = GlobalVariables.servo_R_Rotate;
                    b_isServo = true;
                    break;
                case "servo_U_Grab":
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                    mServoStatus = GlobalVariables.servo_U_Grab;
                    b_isServo = true;
                    break;
                case "servo_U_Move":                  
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Move;
                    mServoStatus = GlobalVariables.servo_U_Move;
                    b_isServo = true;
                    break;
                case "servo_U_Rotate":                    
                    mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Rotate;
                    mServoStatus = GlobalVariables.servo_U_Rotate;
                    b_isServo = true;
                    break;
                default:
                    break;
            }
            if (b_isServo)
            {
                //更新mServoStatus
                List<string> tags = new List<string>();
                tags.Add(mServoParas.mServoNodeID.NodeID_i_Error);
                tags.Add(mServoParas.mServoNodeID.NodeID_i_Enable);
                // 按照顺序定义的值
                List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                mServoStatus.i_Error = values[0];
                mServoStatus.i_Enable = values[1];
                mServoStatus.i_ActPos = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());
                //if (mServoStatus.i_ActPos >= mServoParas.P1 - GlobalVariables.positionTolerance &&
                //    mServoStatus.i_ActPos <= mServoParas.P1 + GlobalVariables.positionTolerance)
                //{
                //    mServoStatus.b_P1 = true;
                //    mServoStatus.b_P2 = false;
                //    mServoStatus.b_P3 = false;
                //}
                //else if (mServoStatus.i_ActPos >= mServoParas.P2 - GlobalVariables.positionTolerance &&
                //    mServoStatus.i_ActPos <= mServoParas.P2 + GlobalVariables.positionTolerance)
                //{
                //    mServoStatus.b_P1 = false;
                //    mServoStatus.b_P2 = true;
                //    mServoStatus.b_P3 = false;
                //}
                //else if (mServoStatus.i_ActPos >= mServoParas.P3 - GlobalVariables.positionTolerance &&
                //    mServoStatus.i_ActPos <= mServoParas.P3 + GlobalVariables.positionTolerance)
                //{
                //    mServoStatus.b_P1 = false;
                //    mServoStatus.b_P2 = false;
                //    mServoStatus.b_P3 = true;
                //}
                #region 弃用
                switch (AxisID)
                {
                    case "servo_Feeding":
                        if (mServoStatus.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P1 - GlobalVariables.positionTolerance &&
                     mServoStatus.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P1 + GlobalVariables.positionTolerance)
                        {
                            GlobalVariables.servo_Feeding.b_P1 = true;
                            GlobalVariables.servo_Feeding.b_P2 = false;
                            GlobalVariables.servo_Feeding.b_P3 = false;
                        }
                        else if (mServoStatus.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P2 - GlobalVariables.positionTolerance &&
                            mServoStatus.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P2 + GlobalVariables.positionTolerance)
                        {
                            GlobalVariables.servo_Feeding.b_P1 = false;
                            GlobalVariables.servo_Feeding.b_P2 = true;
                            GlobalVariables.servo_Feeding.b_P3 = false;
                        }
                        else if (mServoStatus.i_ActPos >= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P3 - GlobalVariables.positionTolerance &&
                            mServoStatus.i_ActPos <= GlobalVariables.CurrentParas.mPLC.servo_Feeding.P3 + GlobalVariables.positionTolerance)
                        {
                            GlobalVariables.servo_Feeding.b_P1 = false;
                            GlobalVariables.servo_Feeding.b_P2 = false;
                            GlobalVariables.servo_Feeding.b_P3 = true;
                        }
                        break;
                    case "servo_U_Grab":
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
                        break;
                    case "servo_D_Grab":
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
                        break;
                    case "servo_U_Move":
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
                        break;
                    case "servo_D_Move":
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
                        break;
                }
                #endregion
            }
            else
            {
                //更新mIOlinkStatus
                List<string> tags = new List<string>();
                tags.Add(mIOlinkNodeID.NodeID_i_In);
                tags.Add(mIOlinkNodeID.NodeID_i_Out);
                tags.Add(mIOlinkNodeID.NodeID_i_Device);
                // 按照顺序定义的值
                List<bool> values = Form1.m_OpcUaClient.ReadNodes<bool>(tags.ToArray());
                mIOlinkStatus.i_In = values[0];
                mIOlinkStatus.i_Out = values[1];
                mIOlinkStatus.i_Device = values[2];
            }
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
        public static bool WaitServoMC(string[] AxisIDs, int PointIndex)
        {
            try
            {
                bool b_MC = true;
                ServoParas mServoParas = new ServoParas();
                ServoStatus mServoStatus = new ServoStatus();
                double TargetPosition = 0;
                for (int i = 0; i < AxisIDs.Length; i++)
                {
                    #region PointIndex得TargetPosition
                    switch (AxisIDs[i])
                    {
                        case "servo_B_Rotate":
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                            mServoStatus = GlobalVariables.servo_B_Rotate;
                            switch (PointIndex)
                            {
                                case 0:
                                    TargetPosition = mServoParas.P_0;
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
                    #endregion
                    #region 确认是否运动到位
                    double curPosition = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());
                   
                    int times = 0;
                    if (curPosition >= TargetPosition - GlobalVariables.positionTolerance &&
                             curPosition <= TargetPosition + GlobalVariables.positionTolerance)
                    {
                        b_MC = true;
                    }
                    while (!b_MC)
                    {
                        Thread.Sleep(100);
                        if (Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_Error).ToString() == "True")
                        {
                            return false;
                        }
                        else
                        {
                            curPosition = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());
                            if (curPosition >= TargetPosition - GlobalVariables.positionTolerance &&
                                 curPosition <= TargetPosition + GlobalVariables.positionTolerance)
                            {
                                b_MC = true;
                            }
                        }
                        times++;
                        //防止死循环
                        if (times > 20)
                        {
                            break;
                        }
                    }
                    curPosition = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());
                    if (curPosition >= TargetPosition - GlobalVariables.positionTolerance &&
                         curPosition <= TargetPosition + GlobalVariables.positionTolerance)
                    {
                        b_MC = true;
                    }
                    else
                    {
                        b_MC = false;
                        return false;
                    }
                    #endregion
                }
                return b_MC;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static bool WaitServoMC(string AxisID, int PointIndex, bool b_FirstRotate = false, bool b_ChangeDirection = false)
        {
            try
            {
                bool b_MC = true;
                ServoParas mServoParas = new ServoParas();
                ServoStatus mServoStatus = new ServoStatus();
                double TargetPosition = 0;
                #region PointIndex得TargetPosition
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
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                                }
                                break;
                            case -90:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CWgap;
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
                            case 90:
                            case 180:
                            case 270:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                                }
                                break;
                            case -90:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CWgap;
                                }
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
                            case 90:
                            case 180:
                            case 270:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                                }
                                break;
                            case -90:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CWgap;
                                }
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
                            case 90:
                            case 180:
                            case 270:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                                }
                                break;
                            case -90:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CWgap;
                                }
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
                            case 90:
                            case 180:
                            case 270:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                                }
                                break;
                            case -90:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CWgap;
                                }
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
                            case 90:
                            case 180:
                            case 270:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                                }
                                break;
                            case -90:
                                TargetPosition = mServoStatus.i_ActPos - PointIndex;
                                if (b_FirstRotate)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                                }
                                if (b_ChangeDirection)
                                {
                                    TargetPosition = TargetPosition + GlobalVariables.CWgap;
                                }
                                break;
                        }
                        break;
                    default:
                        break;
                }
                #endregion
                #region 确认是否运动到位
                double curPosition = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());                
                int times = 0;
                if (curPosition >= TargetPosition - GlobalVariables.positionTolerance &&
                         curPosition <= TargetPosition + GlobalVariables.positionTolerance)
                {
                    b_MC = true;
                }
                while (!b_MC)
                {
                    Thread.Sleep(100);
                    if (Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_Error).ToString() == "True")
                    {
                        return false;
                    }
                    else
                    {
                        curPosition = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());
                        if (curPosition >= TargetPosition - GlobalVariables.positionTolerance &&
                             curPosition <= TargetPosition + GlobalVariables.positionTolerance)
                        {
                            b_MC = true;
                        }
                    }
                    times++;
                    //防止死循环
                    if (times > 20)
                    {
                        break;
                    }
                }
                curPosition = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());
                if (curPosition >= TargetPosition - GlobalVariables.positionTolerance &&
                     curPosition <= TargetPosition + GlobalVariables.positionTolerance)
                {
                    b_MC = true;
                }
                else
                {
                    b_MC = false;
                }
                #endregion
                return b_MC;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ServoGoto(string AxisID,int PointIndex,bool b_FirstRotate=false,bool b_ChangeDirection=false)
        {
            updateAxisStatus();//需要避免干涉，所以更新所有轴的状态
            ServoParas mServoParas = new ServoParas();
            ServoStatus mServoStatus = new ServoStatus();
            double TargetPosition = 0;
            #region PointIndex得TargetPosition
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
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                default:
                    break;
            }
            #endregion
            #region 执行运动指令
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
                    switch (AxisID)
                    {
                        case "servo_B_Rotate":
                        case "servo_F_Rotate":
                        case "servo_U_Rotate":
                        case "servo_D_Rotate":
                        case "servo_L_Rotate":
                        case "servo_R_Rotate":
                            Form1.m_OpcUaClient.WriteNodes(new string[] {
                mServoParas.mServoNodeID.NodeID_o_Vel,
                mServoParas.mServoNodeID.NodeID_o_Acc,
                mServoParas.mServoNodeID.NodeID_o_Dec,
                mServoParas.mServoNodeID.NodeID_o_Jerk},
                new object[] {
                    Convert.ToSingle(GlobalVariables.global_Vel_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Acc_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Dec_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Jerk_Rotate)
                });
                            break;
                        default:
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
                            break;
                    }


                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition));
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, true);
                    System.Threading.Thread.Sleep(100);
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, false);
                }
                else
                {
                    MessageBox.Show(AxisID + " Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            #endregion   
            #region 确认是否运动到位
            double curPosition = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());
            bool b_MC = false;
            int times = 0;
            if (curPosition >= TargetPosition - GlobalVariables.positionTolerance &&
                     curPosition <= TargetPosition + GlobalVariables.positionTolerance)
            {
                b_MC = true;
            }
            while (!b_MC)
            {
                Thread.Sleep(100);
                if (Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_Error).ToString() == "True")
                {
                    return false;
                }
                else
                {
                    curPosition = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());
                    if (curPosition >= TargetPosition - GlobalVariables.positionTolerance &&
                         curPosition <= TargetPosition + GlobalVariables.positionTolerance)
                    {
                        b_MC = true;
                    }
                }
                times++;
                //防止死循环
                if (times > 20)
                {
                    break;
                }
            }
            curPosition = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(mServoParas.mServoNodeID.NodeID_i_ActPos).ToString());
            if (curPosition >= TargetPosition - GlobalVariables.positionTolerance &&
                 curPosition <= TargetPosition + GlobalVariables.positionTolerance)
            {
                b_MC = true;
            }
            else
            {
                b_MC = false;
            } 
            #endregion
            return b_MC;
        }
        public static bool ServoGotoWithoutCheck(string AxisID1, string AxisID2, int PointIndex1, int PointIndex2, 
            bool b_FirstRotate1 = false, bool b_FirstRotate2 = false, bool b_ChangeDirection1 = false, bool b_ChangeDirection2 = false)
        {
            updateAxisStatus();
            ServoParas mServoParas1 = new ServoParas();
            ServoStatus mServoStatus1 = new ServoStatus();
            ServoParas mServoParas2 = new ServoParas();
            ServoStatus mServoStatus2 = new ServoStatus();
            double TargetPosition1 = 0;
            double TargetPosition2 = 0;
            #region PointIndex得TargetPosition
            switch (AxisID1)
            {
                case "servo_B_Rotate":
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                    mServoStatus1 = GlobalVariables.servo_B_Rotate;
                    switch (PointIndex1)
                    {
                        case 0:
                            TargetPosition1 = mServoParas1.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_D_Grab":
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                    mServoStatus1 = GlobalVariables.servo_D_Grab;
                    switch (PointIndex1)
                    {
                        case 1:
                            TargetPosition1 = mServoParas1.P1;
                            break;
                        case 2:
                            TargetPosition1 = mServoParas1.P2;
                            break;
                        case 3:
                            TargetPosition1 = mServoParas1.P3;
                            break;
                    }
                    break;
                case "servo_D_Move":
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_D_Move;
                    mServoStatus1 = GlobalVariables.servo_D_Move;
                    switch (PointIndex1)
                    {
                        case 1:
                            TargetPosition1 = mServoParas1.P1;
                            break;
                        case 2:
                            TargetPosition1 = mServoParas1.P2;
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
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_D_Rotate;
                    mServoStatus1 = GlobalVariables.servo_D_Rotate;
                    switch (PointIndex1)
                    {
                        case 0:
                            TargetPosition1 = mServoParas1.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_Feeding":
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_Feeding;
                    mServoStatus1 = GlobalVariables.servo_Feeding;
                    switch (PointIndex1)
                    {
                        case 1:
                            TargetPosition1 = mServoParas1.P1;
                            break;
                        case 2:
                            TargetPosition1 = mServoParas1.P2;
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
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                    mServoStatus1 = GlobalVariables.servo_F_Rotate;
                    switch (PointIndex1)
                    {
                        case 0:
                            TargetPosition1 = mServoParas1.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_L_Rotate":
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                    mServoStatus1 = GlobalVariables.servo_L_Rotate;
                    switch (PointIndex1)
                    {
                        case 0:
                            TargetPosition1 = mServoParas1.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_R_Rotate":
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                    mServoStatus1 = GlobalVariables.servo_R_Rotate;
                    switch (PointIndex1)
                    {
                        case 0:
                            TargetPosition1 = mServoParas1.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_U_Grab":
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                    mServoStatus1 = GlobalVariables.servo_U_Grab;
                    switch (PointIndex1)
                    {
                        case 1:
                            TargetPosition1 = mServoParas1.P1;
                            break;
                        case 2:
                            TargetPosition1 = mServoParas1.P2;
                            break;
                        case 3:
                            TargetPosition1 = mServoParas1.P3;
                            break;
                    }
                    break;
                case "servo_U_Move":
                    mServoStatus1 = GlobalVariables.servo_U_Move;
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_U_Move;
                    switch (PointIndex1)
                    {
                        case 1:
                            TargetPosition1 = mServoParas1.P1;
                            break;
                        case 2:
                            TargetPosition1 = mServoParas1.P2;
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
                    mServoStatus1 = GlobalVariables.servo_U_Rotate;
                    mServoParas1 = GlobalVariables.CurrentParas.mPLC.servo_U_Rotate;
                    switch (PointIndex1)
                    {
                        case 0:
                            TargetPosition1 = mServoParas1.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition1 = mServoStatus1.i_ActPos - PointIndex1;
                            if (b_FirstRotate1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection1)
                            {
                                TargetPosition1 = TargetPosition1 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                default:
                    break;
            }
            switch (AxisID2)
            {
                case "servo_B_Rotate":
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                    mServoStatus2 = GlobalVariables.servo_B_Rotate;
                    switch (PointIndex2)
                    {
                        case 0:
                            TargetPosition2 = mServoParas2.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_D_Grab":
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                    mServoStatus2 = GlobalVariables.servo_D_Grab;
                    switch (PointIndex2)
                    {
                        case 1:
                            TargetPosition2 = mServoParas2.P1;
                            break;
                        case 2:
                            TargetPosition2 = mServoParas2.P2;
                            break;
                        case 3:
                            TargetPosition2 = mServoParas2.P3;
                            break;
                    }
                    break;
                case "servo_D_Move":
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_D_Move;
                    mServoStatus2 = GlobalVariables.servo_D_Move;
                    switch (PointIndex2)
                    {
                        case 1:
                            TargetPosition2 = mServoParas2.P1;
                            break;
                        case 2:
                            TargetPosition2 = mServoParas2.P2;
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
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_D_Rotate;
                    mServoStatus2 = GlobalVariables.servo_D_Rotate;
                    switch (PointIndex2)
                    {
                        case 0:
                            TargetPosition2 = mServoParas2.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_Feeding":
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_Feeding;
                    mServoStatus2 = GlobalVariables.servo_Feeding;
                    switch (PointIndex2)
                    {
                        case 1:
                            TargetPosition2 = mServoParas2.P1;
                            break;
                        case 2:
                            TargetPosition2 = mServoParas2.P2;
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
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                    mServoStatus2 = GlobalVariables.servo_F_Rotate;
                    switch (PointIndex2)
                    {
                        case 0:
                            TargetPosition2 = mServoParas2.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_L_Rotate":
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                    mServoStatus2 = GlobalVariables.servo_L_Rotate;
                    switch (PointIndex2)
                    {
                        case 0:
                            TargetPosition2 = mServoParas2.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_R_Rotate":
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                    mServoStatus2 = GlobalVariables.servo_R_Rotate;
                    switch (PointIndex2)
                    {
                        case 0:
                            TargetPosition2 = mServoParas2.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                case "servo_U_Grab":
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                    mServoStatus2 = GlobalVariables.servo_U_Grab;
                    switch (PointIndex2)
                    {
                        case 1:
                            TargetPosition2 = mServoParas2.P1;
                            break;
                        case 2:
                            TargetPosition2 = mServoParas2.P2;
                            break;
                        case 3:
                            TargetPosition2 = mServoParas2.P3;
                            break;
                    }
                    break;
                case "servo_U_Move":
                    mServoStatus2 = GlobalVariables.servo_U_Move;
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_U_Move;
                    switch (PointIndex2)
                    {
                        case 1:
                            TargetPosition2 = mServoParas2.P1;
                            break;
                        case 2:
                            TargetPosition2 = mServoParas2.P2;
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
                    mServoStatus2 = GlobalVariables.servo_U_Rotate;
                    mServoParas2 = GlobalVariables.CurrentParas.mPLC.servo_U_Rotate;
                    switch (PointIndex2)
                    {
                        case 0:
                            TargetPosition2 = mServoParas2.P_0;
                            break;
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition2 = mServoStatus2.i_ActPos - PointIndex2;
                            if (b_FirstRotate2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection2)
                            {
                                TargetPosition2 = TargetPosition2 + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                default:
                    break;
            }
            #endregion
            #region 执行运动指令
            try
            {
                if (Form1.m_OpcUaClient.ReadNode(mServoParas1.mServoNodeID.NodeID_i_Error).ToString() == "True")
                {
                    //有异常，下使能，Reset
                    Form1.m_OpcUaClient.WriteNode(mServoParas1.mServoNodeID.NodeID_o_Enable, false);
                    Form1.m_OpcUaClient.WriteNode(mServoParas1.mServoNodeID.NodeID_o_Reset, true);
                    Thread.Sleep(100);
                    Form1.m_OpcUaClient.WriteNode(mServoParas1.mServoNodeID.NodeID_o_Reset, false);
                }
                if (Form1.m_OpcUaClient.ReadNode(mServoParas1.mServoNodeID.NodeID_i_Enable).ToString() == "False")
                {
                    //上使能
                    Form1.m_OpcUaClient.WriteNode(mServoParas1.mServoNodeID.NodeID_o_Enable, true);
                }
                if (Form1.m_OpcUaClient.ReadNode(mServoParas2.mServoNodeID.NodeID_i_Error).ToString() == "True")
                {
                    //有异常，下使能，Reset
                    Form1.m_OpcUaClient.WriteNode(mServoParas2.mServoNodeID.NodeID_o_Enable, false);
                    Form1.m_OpcUaClient.WriteNode(mServoParas2.mServoNodeID.NodeID_o_Reset, true);
                    Thread.Sleep(100);
                    Form1.m_OpcUaClient.WriteNode(mServoParas2.mServoNodeID.NodeID_o_Reset, false);
                }
                if (Form1.m_OpcUaClient.ReadNode(mServoParas2.mServoNodeID.NodeID_i_Enable).ToString() == "False")
                {
                    //上使能
                    Form1.m_OpcUaClient.WriteNode(mServoParas2.mServoNodeID.NodeID_o_Enable, true);
                }
                if (!(Form1.m_OpcUaClient.ReadNode(mServoParas1.mServoNodeID.NodeID_i_Error).ToString() == "True" ||
                    Form1.m_OpcUaClient.ReadNode(mServoParas2.mServoNodeID.NodeID_i_Error).ToString() == "True"))
                {
                    Form1.m_OpcUaClient.WriteNodes(new string[] {
                mServoParas1.mServoNodeID.NodeID_o_Vel,
                mServoParas1.mServoNodeID.NodeID_o_Acc,
                mServoParas1.mServoNodeID.NodeID_o_Dec,
                mServoParas1.mServoNodeID.NodeID_o_Jerk,
                mServoParas2.mServoNodeID.NodeID_o_Vel,
                mServoParas2.mServoNodeID.NodeID_o_Acc,
                mServoParas2.mServoNodeID.NodeID_o_Dec,
                mServoParas2.mServoNodeID.NodeID_o_Jerk},
                 new object[] {
                    Convert.ToSingle(GlobalVariables.global_Vel_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Acc_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Dec_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Jerk_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Vel_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Acc_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Dec_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Jerk_Rotate)});


                    Form1.m_OpcUaClient.WriteNode(mServoParas1.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition1));
                    Form1.m_OpcUaClient.WriteNode(mServoParas2.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition2));
                    Form1.m_OpcUaClient.WriteNodes(new string[] { mServoParas1.mServoNodeID.NodeID_o_Go, mServoParas2.mServoNodeID.NodeID_o_Go },
                        new object[] { true, true });
                    System.Threading.Thread.Sleep(100);
                    Form1.m_OpcUaClient.WriteNodes(new string[] { mServoParas1.mServoNodeID.NodeID_o_Go, mServoParas2.mServoNodeID.NodeID_o_Go },
                        new object[] { false, false });
                }
                else
                {
                    MessageBox.Show(AxisID1 + "&" + AxisID2 + " Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
            #endregion   
        }

        public static bool ServoGotoWithoutCheck(string AxisID, int PointIndex, bool b_FirstRotate = false, bool b_ChangeDirection = false)
        {
            updateAxisStatus();
            ServoParas mServoParas = new ServoParas();
            ServoStatus mServoStatus = new ServoStatus();
            double TargetPosition = 0;
            #region PointIndex得TargetPosition
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
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
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
                        case 90:
                        case 180:
                        case 270:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition - GlobalVariables.CCWgap;
                            }
                            break;
                        case -90:
                            TargetPosition = mServoStatus.i_ActPos - PointIndex;
                            if (b_FirstRotate)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CCWgap;
                            }
                            if (b_ChangeDirection)
                            {
                                TargetPosition = TargetPosition + GlobalVariables.CWgap;
                            }
                            break;
                    }
                    break;
                default:
                    break;
            }
            #endregion
            #region 执行运动指令
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
                    switch (AxisID)
                    {
                        case "servo_B_Rotate":
                        case "servo_F_Rotate":
                        case "servo_U_Rotate":
                        case "servo_D_Rotate":
                        case "servo_L_Rotate":
                        case "servo_R_Rotate":
                            Form1.m_OpcUaClient.WriteNodes(new string[] {
                mServoParas.mServoNodeID.NodeID_o_Vel,
                mServoParas.mServoNodeID.NodeID_o_Acc,
                mServoParas.mServoNodeID.NodeID_o_Dec,
                mServoParas.mServoNodeID.NodeID_o_Jerk},
                new object[] {
                    Convert.ToSingle(GlobalVariables.global_Vel_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Acc_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Dec_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Jerk_Rotate)
                });
                            break;
                        default:
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
                            break;
                    }


                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition));
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, true);
                    System.Threading.Thread.Sleep(100);
                    Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Go, false);
                }
                else
                {
                    MessageBox.Show(AxisID + " Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
            #endregion   
        }
        public static bool ServoGoto(int AxisCount, int PointIndex=0)
        {
            updateAxisStatus();            
            ServoStatus mServoStatus1 = new ServoStatus();
            ServoStatus mServoStatus2 = new ServoStatus();
            ServoStatus mServoStatus3 = new ServoStatus();
            ServoStatus mServoStatus4 = new ServoStatus();
            double TargetPosition1 = 0;
            double TargetPosition2 = 0;
            double TargetPosition3 = 0;
            double TargetPosition4 = 0;
            #region PointIndex得TargetPosition
            switch (AxisCount)
            {
                case 2://上下杆同步上下
                    mServoStatus1 = GlobalVariables.servo_D_Grab;
                    mServoStatus2 = GlobalVariables.servo_U_Grab;
                    switch (PointIndex)
                    {
                        case 1:
                            TargetPosition1 = GlobalVariables.CurrentParas.mPLC.servo_D_Grab.P1;
                            TargetPosition2 = GlobalVariables.CurrentParas.mPLC.servo_U_Grab.P1;
                            break;
                        case 2:
                            TargetPosition1 = GlobalVariables.CurrentParas.mPLC.servo_D_Grab.P2;
                            TargetPosition2 = GlobalVariables.CurrentParas.mPLC.servo_U_Grab.P2;
                            break;
                        case 3:
                            TargetPosition1 = GlobalVariables.CurrentParas.mPLC.servo_D_Grab.P3;
                            TargetPosition2 = GlobalVariables.CurrentParas.mPLC.servo_U_Grab.P3;
                            break;
                    }
                    break;
                case 4://4周旋转杆同步回0
                    mServoStatus1 = GlobalVariables.servo_L_Rotate;
                    mServoStatus2 = GlobalVariables.servo_R_Rotate;
                    mServoStatus3 = GlobalVariables.servo_F_Rotate;
                    mServoStatus4 = GlobalVariables.servo_B_Rotate;
                    TargetPosition1 = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.P_0;
                    TargetPosition2 = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.P_0;
                    TargetPosition3 = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.P_0;
                    TargetPosition4 = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.P_0;
                    break;             
            }
            #endregion
            #region 执行运动指令
            try
            {
                ServoParas mServoParas;
                switch (AxisCount)
                {
                    case 2://上下杆同步上下                       
                        if (mServoStatus1.i_Error)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                            //有异常，下使能，Reset
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, false);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, true);
                            Thread.Sleep(100);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, false);
                        }
                        if (mServoStatus2.i_Error)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                            //有异常，下使能，Reset
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, false);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, true);
                            Thread.Sleep(100);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, false);
                        }
                        
                        if (!mServoStatus1.i_Enable)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_D_Grab;
                            //上使能
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, true);
                        }
                        if (!mServoStatus2.i_Enable)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_U_Grab;
                            //上使能
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, true);
                        }
                        
                        if (!(mServoStatus1.i_Error || mServoStatus2.i_Error ))
                        {
                            Form1.m_OpcUaClient.WriteNodes(new string[] {
                GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Vel,
                GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Acc,
                GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Dec,
                GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Jerk,
                GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Vel,
                GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Acc,
                GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Dec,
                GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Jerk},
                        new object[] {
                    Convert.ToSingle(GlobalVariables.global_Vel),
                    Convert.ToSingle(GlobalVariables.global_Acc),
                    Convert.ToSingle(GlobalVariables.global_Dec),
                    Convert.ToSingle(GlobalVariables.global_Jerk),
                    Convert.ToSingle(GlobalVariables.global_Vel),
                    Convert.ToSingle(GlobalVariables.global_Acc),
                    Convert.ToSingle(GlobalVariables.global_Dec),
                    Convert.ToSingle(GlobalVariables.global_Jerk)
                        });
                            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition1));
                            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition2));
                          
                            Form1.m_OpcUaClient.WriteNodes(new string[] { GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Go,                                                                            
                                                                            GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Go },
                                                                            new object[] { true, true });
                            System.Threading.Thread.Sleep(100);
                            Form1.m_OpcUaClient.WriteNodes(new string[] { GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Go,
                                                                            GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Go },
                                                                            new object[] { false, false });
                        }
                        else
                        {
                            MessageBox.Show("上下杆同步上下Error");
                            return false;
                        }
                        break;               
                    case 4://4周旋转杆同步回0                        
                        if (mServoStatus1.i_Error)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                            //有异常，下使能，Reset
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, false);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, true);
                            Thread.Sleep(100);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, false);
                        }
                        if (mServoStatus2.i_Error)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                            //有异常，下使能，Reset
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, false);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, true);
                            Thread.Sleep(100);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, false);
                        }
                        if (mServoStatus3.i_Error)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                            //有异常，下使能，Reset
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, false);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, true);
                            Thread.Sleep(100);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, false);
                        }
                        if (mServoStatus4.i_Error)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                            //有异常，下使能，Reset
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, false);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, true);
                            Thread.Sleep(100);
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Reset, false);
                        }
                        if (!mServoStatus1.i_Enable)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_L_Rotate;
                            //上使能
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, true);
                        }
                        if (!mServoStatus2.i_Enable)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_R_Rotate;
                            //上使能
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, true);
                        }
                        if (!mServoStatus3.i_Enable)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_F_Rotate;
                            //上使能
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, true);
                        }
                        if (!mServoStatus4.i_Enable)
                        {
                            mServoParas = GlobalVariables.CurrentParas.mPLC.servo_B_Rotate;
                            //上使能
                            Form1.m_OpcUaClient.WriteNode(mServoParas.mServoNodeID.NodeID_o_Enable, true);
                        }
                        if (!(mServoStatus1.i_Error|| mServoStatus2.i_Error || mServoStatus3.i_Error || mServoStatus4.i_Error))
                        {                         
                            Form1.m_OpcUaClient.WriteNodes(new string[] {
                GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Vel,
                GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Acc,
                GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Dec,
                GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Jerk,
                GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Vel,
                GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Acc,
                GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Dec,
                GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Jerk,
                GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Vel,
                GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Acc,
                GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Dec,
                GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Jerk,
                GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Vel,
                GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Acc,
                GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Dec,
                GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Jerk},
                        new object[] {
                    Convert.ToSingle(GlobalVariables.global_Vel_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Acc_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Dec_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Jerk_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Vel_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Acc_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Dec_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Jerk_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Vel_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Acc_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Dec_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Jerk_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Vel_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Acc_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Dec_Rotate),
                    Convert.ToSingle(GlobalVariables.global_Jerk_Rotate)
                        });
                            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition1));
                            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition2));
                            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition3));
                            Form1.m_OpcUaClient.WriteNode(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Pos, Convert.ToSingle(TargetPosition4));
                            Form1.m_OpcUaClient.WriteNodes(new string[] { GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Go,
                                                                            GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Go,
                                                                            GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Go,
                                                                            GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Go }, 
                                                                            new object[] { true, true, true, true });
                            System.Threading.Thread.Sleep(100);
                            Form1.m_OpcUaClient.WriteNodes(new string[] { GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Go,
                                                                            GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Go,
                                                                            GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Go,
                                                                            GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Go },
                                                                            new object[] { false, false, false, false });
                        }
                        else
                        {
                            MessageBox.Show("四周旋转轴Error");
                            return false;
                        }
                        break;
                }
                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            #endregion   
            #region 确认是否运动到位
            double curPosition1;
            double curPosition2;
            double curPosition3;
            double curPosition4;
            bool b_MC = false;
            int times = 0;
            bool b_MC1 = false;
            bool b_MC2 = false;
            bool b_MC3 = false;
            bool b_MC4 = false;
            switch (AxisCount)
            {
                case 2://上下杆同步上下
                    curPosition1 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_ActPos).ToString());
                    curPosition2 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_ActPos).ToString());
                    if (curPosition1 >= TargetPosition1 - GlobalVariables.positionTolerance &&
                    curPosition1 <= TargetPosition1 + GlobalVariables.positionTolerance &&
                    curPosition2 >= TargetPosition2 - GlobalVariables.positionTolerance &&
                    curPosition2 <= TargetPosition2 + GlobalVariables.positionTolerance )
                    {
                        b_MC = true;
                    }
                    while (!b_MC)
                    {
                        Thread.Sleep(100);
                        if (Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_Error).ToString() == "True" ||
                            Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_Error).ToString() == "True" )
                        {
                            return false;
                        }
                        else
                        {
                            curPosition1 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_ActPos).ToString());
                            curPosition2 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_ActPos).ToString());
                            if (curPosition1 >= TargetPosition1 - GlobalVariables.positionTolerance &&
                            curPosition1 <= TargetPosition1 + GlobalVariables.positionTolerance &&
                            curPosition2 >= TargetPosition2 - GlobalVariables.positionTolerance &&
                            curPosition2 <= TargetPosition2 + GlobalVariables.positionTolerance)
                            {
                                b_MC = true;
                            }
                        }
                        times++;
                        //防止死循环
                        if (times > 20)
                        {
                            break;
                        }
                    }
                    curPosition1 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_ActPos).ToString());
                    curPosition2 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_ActPos).ToString());
                    if (curPosition1 >= TargetPosition1 - GlobalVariables.positionTolerance &&
                    curPosition1 <= TargetPosition1 + GlobalVariables.positionTolerance &&
                    curPosition2 >= TargetPosition2 - GlobalVariables.positionTolerance &&
                    curPosition2 <= TargetPosition2 + GlobalVariables.positionTolerance)
                    {
                        b_MC = true;
                    }
                    else
                    {
                        b_MC = false;
                    }
                    return b_MC;                    
                case 4://4周旋转杆同步回0
                    curPosition1 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_ActPos).ToString());
                    curPosition2 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_ActPos).ToString());
                    curPosition3 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_ActPos).ToString());
                    curPosition4 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_ActPos).ToString());
                    if (curPosition1 >= TargetPosition1 - GlobalVariables.positionTolerance &&
                   curPosition1 <= TargetPosition1 + GlobalVariables.positionTolerance &&
                   curPosition2 >= TargetPosition2 - GlobalVariables.positionTolerance &&
                   curPosition2 <= TargetPosition2 + GlobalVariables.positionTolerance &&
                   curPosition3 >= TargetPosition3 - GlobalVariables.positionTolerance &&
                   curPosition3 <= TargetPosition3 + GlobalVariables.positionTolerance &&
                   curPosition4 >= TargetPosition4 - GlobalVariables.positionTolerance &&
                   curPosition4 <= TargetPosition4 + GlobalVariables.positionTolerance)
                    {
                        b_MC = true;
                    }
                    while (!b_MC)
                    {
                        Thread.Sleep(100);
                        if (Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_Error).ToString() == "True"||
                            Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_Error).ToString() == "True" ||
                            Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_Error).ToString() == "True" ||
                            Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_Error).ToString() == "True")
                        {
                            return false;
                        }
                        else
                        {
                            curPosition1 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_ActPos).ToString());
                            curPosition2 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_ActPos).ToString());
                            curPosition3 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_ActPos).ToString());
                            curPosition4 = Convert.ToDouble(Form1.m_OpcUaClient.ReadNode(GlobalVariables.CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_ActPos).ToString());
                            if (curPosition1 >= TargetPosition1 - GlobalVariables.positionTolerance &&
                           curPosition1 <= TargetPosition1 + GlobalVariables.positionTolerance &&
                           curPosition2 >= TargetPosition2 - GlobalVariables.positionTolerance &&
                           curPosition2 <= TargetPosition2 + GlobalVariables.positionTolerance &&
                           curPosition3 >= TargetPosition3 - GlobalVariables.positionTolerance &&
                           curPosition3 <= TargetPosition3 + GlobalVariables.positionTolerance &&
                           curPosition4 >= TargetPosition4 - GlobalVariables.positionTolerance &&
                           curPosition4 <= TargetPosition4 + GlobalVariables.positionTolerance)
                            {
                                b_MC = true;
                            }
                        }
                        times++;
                        //防止死循环
                        if (times > 20)
                        {
                            break;
                        }
                    }
                    if (curPosition1 >= TargetPosition1 - GlobalVariables.positionTolerance &&
                          curPosition1 <= TargetPosition1 + GlobalVariables.positionTolerance &&
                          curPosition2 >= TargetPosition2 - GlobalVariables.positionTolerance &&
                          curPosition2 <= TargetPosition2 + GlobalVariables.positionTolerance &&
                          curPosition3 >= TargetPosition3 - GlobalVariables.positionTolerance &&
                          curPosition3 <= TargetPosition3 + GlobalVariables.positionTolerance &&
                          curPosition4 >= TargetPosition4 - GlobalVariables.positionTolerance &&
                          curPosition4 <= TargetPosition4 + GlobalVariables.positionTolerance)
                    {
                        b_MC = true;
                    }
                    else
                    {
                        b_MC = false;
                    }
                    return b_MC;
                default:
                    return false;
            }          
            #endregion
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
            ResetAll();
        }

        private void btn_EnableAll_Click(object sender, EventArgs e)
        {
            ResetAll();
            EnableAll();            
        }

        public void btn_2_P_Start_Click(object sender, EventArgs e)
        {
            updateAxisStatus();
            if (b_P_Start)
            {
                //已在初始位，无需动作
            }
            else if (b_P_Acquire)
            {
                IOlinkAxisIn(5);//5个相机回原位               
                IOlinkAxisIn(4);//4个旋转杆回原位           
                ServoGotoWithoutCheck("servo_L_Rotate", 0);
                ServoGotoWithoutCheck("servo_R_Rotate", 0);
                ServoGotoWithoutCheck("servo_F_Rotate", 0);
                ServoGotoWithoutCheck("servo_B_Rotate", 0);               
                ServoGotoWithoutCheck("servo_U_Rotate", 0);
                ServoGotoWithoutCheck("servo_D_Rotate", 0);
                IOlinkAxisIn(1);//魔方姿态回0位拍照位
                                //确定D相机，D杆都在原位
                ServoGoto("servo_Feeding", 1);
            }
            else if (b_P_Rotate)
            {
                IOlinkAxisIn(5);//5个相机回原位
                IOlinkAxisOut(1);//魔方姿态45度
                IOlinkAxisIn(4);//4个旋转杆回原位           
                ServoGotoWithoutCheck("servo_L_Rotate", 0);
                ServoGotoWithoutCheck("servo_R_Rotate", 0);
                ServoGotoWithoutCheck("servo_F_Rotate", 0);
                ServoGotoWithoutCheck("servo_B_Rotate", 0);
                ServoGoto("servo_U_Grab", 1);
                ServoGoto("servo_D_Grab", 1);//魔方落回台子上
                ServoGotoWithoutCheck("servo_U_Rotate", 0);
                ServoGotoWithoutCheck("servo_D_Rotate", 0);
                IOlinkAxisIn(1);//魔方姿态回0位拍照位
                                //确定D相机，D杆都在原位
                ServoGoto("servo_Feeding", 1);
            }
            else
            {
                if (!(GlobalVariables.servo_U_Move.b_P1 && GlobalVariables.servo_D_Move.b_P1))
                {
                    ServoGotoWithoutCheck("servo_U_Move", 1);
                    ServoGoto("servo_D_Move", 1);
                }
                updateAxisStatus();
                if (!b_P_Start)
                {
                    IOlinkAxisIn(5);//5个相机回原位
                    IOlinkAxisOut(1);//魔方姿态45度
                    IOlinkAxisIn(4);//4个旋转杆回原位           
                    ServoGotoWithoutCheck("servo_L_Rotate", 0);
                    ServoGotoWithoutCheck("servo_R_Rotate", 0);
                    ServoGotoWithoutCheck("servo_F_Rotate", 0);
                    ServoGotoWithoutCheck("servo_B_Rotate", 0);
                    ServoGoto("servo_U_Grab", 1);
                    ServoGoto("servo_D_Grab", 1);//魔方落回台子上
                    ServoGotoWithoutCheck("servo_U_Rotate", 0);
                    ServoGotoWithoutCheck("servo_D_Rotate", 0);
                    IOlinkAxisIn(1);//魔方姿态回0位拍照位
                                    //确定D相机，D杆都在原位
                    ServoGoto("servo_Feeding", 1);
                }
            }           
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            EmergencyStop();
        }
        public static void EmergencyStop()
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
        public static void EnableAll()
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
        public static void ResetAll()
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
        public void btn_2_P_Acquire_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            updateAxisStatus();
            if (!GlobalVariables.IOlink_F_Grab.i_Out && !GlobalVariables.IOlink_B_Grab.i_Out
                && !GlobalVariables.IOlink_L_Grab.i_Out && !GlobalVariables.IOlink_R_Grab.i_Out
                 && GlobalVariables.servo_U_Grab.b_P1 && GlobalVariables.servo_D_Grab.b_P1)//6个旋杆儿都在缩回的状态
            {
                if (GlobalVariables.IOlink_B_Move_Cam .i_In && GlobalVariables.IOlink_F_Move_Cam.i_In && GlobalVariables.IOlink_B_Move_Cam.i_In
                && GlobalVariables.IOlink_L_Move_Cam.i_In && GlobalVariables.IOlink_R_Move_Cam.i_In)//5个相机都在缩回的状态
                {
                    //魔方姿态在0度位，屏蔽
                    //if (GlobalVariables.IOlink_Rotate.i_In)
                    //{

                    //}
                    ServoGotoWithoutCheck("servo_Feeding", 2);//上料轴运动必须确保下面的旋杆儿和前面的相机都在缩回状态
                    //上下平移轴至拍照位
                    ServoGotoWithoutCheck("servo_U_Move", 1);
                    ServoGotoWithoutCheck("servo_D_Move", 1);//下平移轴运动必须确认下面的旋杆儿在缩回状态
                    while (!GlobalVariables.servo_Feeding.b_P2)
                    {
                        Thread.Sleep(50);
                        updateAxisStatus();
                    }                    
                    if (GlobalVariables.servo_Feeding.b_P2)
                    {
                        IOlinkAxisOut(5);//5个相机至工作位，确认servo_Feeding已在拍照位
                    }
                    else
                    {
                        MessageBox.Show("上料轴未到拍照位，相机不能升起");
                    }
                    AllLightOn();                    
                }
                else
                {
                    //不动作
                    //IOlinkAxisIn(5);//5个相机回原位                      
                }
            }
            else
            {
                //不动作
                //ServoGoHome("servo_U_Grab");
                //ServoGoHome("servo_D_Grab");
                //IOlinkAxisIn(4);//4个旋转杆回原位  
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
            ServoGotoWithoutCheck("servo_L_Rotate",0);
            ServoGotoWithoutCheck("servo_R_Rotate",0);
            ServoGotoWithoutCheck("servo_F_Rotate",0);
            ServoGotoWithoutCheck("servo_B_Rotate",0);
            ServoGotoWithoutCheck("servo_U_Rotate",0);
            ServoGotoWithoutCheck("servo_D_Rotate",0);

            IOlinkAxisOut(1);//魔方姿态至45度

            //UD模块至旋转位
            if (ServoGotoWithoutCheck("servo_U_Move", 2))
            {
                if (ServoGotoWithoutCheck("servo_D_Move", 2))
                {
                    updateAxisStatus();
                    while (!(GlobalVariables.servo_U_Move.b_P2 && GlobalVariables.servo_D_Move.b_P2))
                    {
                        Thread.Sleep(100);
                        updateAxisStatus();
                    }
                    string[] mServoNames = new string[2];
                    mServoNames[0] = "servo_U_Rotate";
                    mServoNames[1] = "servo_D_Rotate";
                    if (WaitServoMC(mServoNames, 0))
                    {
                        //UD杆至取料位
                        //ServoGotoWithoutCheck("servo_U_Grab", 3);
                        //ServoGotoWithoutCheck("servo_D_Grab", 3);
                        ServoGoto(2, 3);
                        updateAxisStatus();
                        while (!(GlobalVariables.servo_U_Grab.b_P3 && GlobalVariables.servo_D_Grab.b_P3))
                        {
                            Thread.Sleep(100);
                            updateAxisStatus();
                        }
                        //UD杆至旋转位，U先上，而后D上，避免顶到
                        //ServoGotoWithoutCheck("servo_U_Grab", 2);
                        //ServoGotoWithoutCheck("servo_D_Grab", 2);
                        ServoGoto(2, 2);
                        updateAxisStatus();
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
                            mServoNames = new string[4];
                            mServoNames[0] = "servo_F_Rotate";
                            mServoNames[1] = "servo_B_Rotate";
                            mServoNames[2] = "servo_L_Rotate";
                            mServoNames[3] = "servo_R_Rotate";
                            if (!WaitServoMC(mServoNames, 0))
                            {
                                MessageBox.Show("四周旋杆儿捅进魔方有风险");
                            }
                            else
                            {
                                //FBLR杆伸出至旋转位
                                IOlinkAxisOut(4);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("上下旋杆儿捅进魔方有风险");
                    }
                }
            }
            //stepIndex = 0;
            b_First_U = true;
            b_First_D = true;
            b_First_L = true;
            b_First_R = true;
            b_First_F = true;
            b_First_B = true;
        }

        private void btn_CubeBack_Click(object sender, EventArgs e)
        {
            //判断魔方是否是正方体，不是则弹出手动页面微调
            IOlinkAxisIn(4);//4个旋转杆回原位  
            IOlinkAxisIn(5);//5个相机回原位  
            IOlinkAxisOut(1);//托盘位置至45度位
            //ServoGotoWithoutCheck("servo_D_Grab", 3);
            //Thread.Sleep(100);
            //ServoGotoWithoutCheck("servo_U_Grab", 3);
            ServoGoto(2, 3);      //上下杆同步运动      
            updateAxisStatus();
            while(!(GlobalVariables.servo_D_Grab.b_P3 && GlobalVariables.servo_U_Grab.b_P3))
            { 
                Thread.Sleep(50);
                updateAxisStatus();
            }            
            ServoGotoWithoutCheck("servo_U_Grab", 1);
            ServoGotoWithoutCheck("servo_D_Grab", 1);           
            updateAxisStatus();
            while (!(GlobalVariables.servo_D_Grab.b_P1 && GlobalVariables.servo_U_Grab.b_P1))
            {
                Thread.Sleep(50);
                updateAxisStatus();
            }
            //旋转杆归零
            ServoGotoWithoutCheck("servo_L_Rotate", 0);
            ServoGotoWithoutCheck("servo_R_Rotate", 0);
            ServoGotoWithoutCheck("servo_F_Rotate", 0);
            ServoGotoWithoutCheck("servo_B_Rotate", 0);
            ServoGotoWithoutCheck("servo_U_Rotate", 0);
            ServoGotoWithoutCheck("servo_D_Rotate", 0);
            IOlinkAxisIn(1);//托盘位置至0度位
            ServoGoto("servo_Feeding", 1);
            ProcessEndTime = DateTime.Now;
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
                ServoGotoWithoutCheck(str_ServoName, PointIndex, b_FirstRotate, b_ChangeDirection);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static bool RotateTo(string str_Rotate1, string str_Rotate2, bool b_FirstRotate1 = false, bool b_FirstRotate2 = false, bool b_ChangeDirection1 = false, bool b_ChangeDirection2 = false)
        {
            try
            {
                string str_ServoName1 = "";
                string str_ServoName2 = "";
                switch (str_Rotate1.Substring(0, 1))
                {
                    case "U":
                        str_ServoName1 = "servo_U_Rotate";
                        break;
                    case "D":
                        str_ServoName1 = "servo_D_Rotate";
                        break;
                    case "L":
                        str_ServoName1 = "servo_L_Rotate";
                        break;
                    case "R":
                        str_ServoName1 = "servo_R_Rotate";
                        break;
                    case "F":
                        str_ServoName1 = "servo_F_Rotate";
                        break;
                    case "B":
                        str_ServoName1 = "servo_B_Rotate";
                        break;
                    default:
                        break;
                }
                switch (str_Rotate2.Substring(0, 1))
                {
                    case "U":
                        str_ServoName2 = "servo_U_Rotate";
                        break;
                    case "D":
                        str_ServoName2 = "servo_D_Rotate";
                        break;
                    case "L":
                        str_ServoName2 = "servo_L_Rotate";
                        break;
                    case "R":
                        str_ServoName2 = "servo_R_Rotate";
                        break;
                    case "F":
                        str_ServoName2 = "servo_F_Rotate";
                        break;
                    case "B":
                        str_ServoName2 = "servo_B_Rotate";
                        break;
                    default:
                        break;
                }
                int PointIndex1 = 0;
                int PointIndex2 = 0;
                if (str_Rotate1.Length == 1)
                {
                    PointIndex1 = 90;
                }
                else
                {
                    switch (str_Rotate1.Substring(1, 1))
                    {
                        case "'":
                            PointIndex1 = 270;
                            break;
                        case "2":
                            PointIndex1 = 180;
                            break;
                    }
                }
                if (str_Rotate2.Length == 1)
                {
                    PointIndex2 = 90;
                }
                else
                {
                    switch (str_Rotate2.Substring(1, 1))
                    {
                        case "'":
                            PointIndex2 = 270;
                            break;
                        case "2":
                            PointIndex2 = 180;
                            break;
                    }
                }
                ServoGotoWithoutCheck(str_ServoName1, str_ServoName2, PointIndex1, PointIndex2, 
                    b_FirstRotate1, b_FirstRotate2, b_ChangeDirection1, b_ChangeDirection2);
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
            updateCamStatus();
            if (Form1.m_OpcUaClient.Connected)
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //enable color match
                ColorDisplay(CamID.CamU, 1, Form1.ColorMatch(CamID.CamU, Form1.GetRGBvalue(CamID.CamU, 9)));
                ColorDisplay(CamID.CamU, 2, Form1.ColorMatch(CamID.CamU, Form1.GetRGBvalue(CamID.CamU, 8)));
                ColorDisplay(CamID.CamU, 3, Form1.ColorMatch(CamID.CamU, Form1.GetRGBvalue(CamID.CamU, 7)));
                ColorDisplay(CamID.CamU, 4, Form1.ColorMatch(CamID.CamU, Form1.GetRGBvalue(CamID.CamU, 6)));
                ColorDisplay(CamID.CamU, 5, Form1.ColorMatch(CamID.CamU, Form1.GetRGBvalue(CamID.CamU, 5), true));
                ColorDisplay(CamID.CamU, 6, Form1.ColorMatch(CamID.CamU, Form1.GetRGBvalue(CamID.CamU, 4)));
                ColorDisplay(CamID.CamU, 7, Form1.ColorMatch(CamID.CamU, Form1.GetRGBvalue(CamID.CamU, 3)));
                ColorDisplay(CamID.CamU, 8, Form1.ColorMatch(CamID.CamU, Form1.GetRGBvalue(CamID.CamU, 2)));
                ColorDisplay(CamID.CamU, 9, Form1.ColorMatch(CamID.CamU, Form1.GetRGBvalue(CamID.CamU, 1)));

                ColorDisplay(CamID.CamD, 1, Form1.ColorMatch(CamID.CamD, Form1.GetRGBvalue(CamID.CamD, 1)));
                ColorDisplay(CamID.CamD, 2, Form1.ColorMatch(CamID.CamD, Form1.GetRGBvalue(CamID.CamD, 2)));
                ColorDisplay(CamID.CamD, 3, Form1.ColorMatch(CamID.CamD, Form1.GetRGBvalue(CamID.CamD, 3)));
                ColorDisplay(CamID.CamD, 4, Form1.ColorMatch(CamID.CamD, Form1.GetRGBvalue(CamID.CamD, 4)));
                ColorDisplay(CamID.CamD, 5, Form1.ColorMatch(CamID.CamD, Form1.GetRGBvalue(CamID.CamD, 5), true));
                ColorDisplay(CamID.CamD, 6, Form1.ColorMatch(CamID.CamD, Form1.GetRGBvalue(CamID.CamD, 6)));
                ColorDisplay(CamID.CamD, 7, Form1.ColorMatch(CamID.CamD, Form1.GetRGBvalue(CamID.CamD, 7)));
                ColorDisplay(CamID.CamD, 8, Form1.ColorMatch(CamID.CamD, Form1.GetRGBvalue(CamID.CamD, 8)));
                ColorDisplay(CamID.CamD, 9, Form1.ColorMatch(CamID.CamD, Form1.GetRGBvalue(CamID.CamD, 9)));
                ColorDisplay(CamID.CamL, 1, Form1.ColorMatch(CamID.CamL, Form1.GetRGBvalue(CamID.CamL, 1)));
                ColorDisplay(CamID.CamL, 2, Form1.ColorMatch(CamID.CamL, Form1.GetRGBvalue(CamID.CamL, 2)));
                ColorDisplay(CamID.CamL, 3, Form1.ColorMatch(CamID.CamL, Form1.GetRGBvalue(CamID.CamL, 3)));
                ColorDisplay(CamID.CamL, 4, Form1.ColorMatch(CamID.CamL, Form1.GetRGBvalue(CamID.CamL, 4)));
                ColorDisplay(CamID.CamL, 5, Form1.ColorMatch(CamID.CamL, Form1.GetRGBvalue(CamID.CamL, 5), true));
                ColorDisplay(CamID.CamL, 6, Form1.ColorMatch(CamID.CamL, Form1.GetRGBvalue(CamID.CamL, 6)));
                ColorDisplay(CamID.CamL, 7, Form1.ColorMatch(CamID.CamL, Form1.GetRGBvalue(CamID.CamL, 7)));
                ColorDisplay(CamID.CamL, 8, Form1.ColorMatch(CamID.CamL, Form1.GetRGBvalue(CamID.CamL, 8)));
                ColorDisplay(CamID.CamL, 9, Form1.ColorMatch(CamID.CamL, Form1.GetRGBvalue(CamID.CamL, 9)));
                ColorDisplay(CamID.CamR, 1, Form1.ColorMatch(CamID.CamR, Form1.GetRGBvalue(CamID.CamR, 1)));
                ColorDisplay(CamID.CamR, 2, Form1.ColorMatch(CamID.CamR, Form1.GetRGBvalue(CamID.CamR, 2)));
                ColorDisplay(CamID.CamR, 3, Form1.ColorMatch(CamID.CamR, Form1.GetRGBvalue(CamID.CamR, 3)));
                ColorDisplay(CamID.CamR, 4, Form1.ColorMatch(CamID.CamR, Form1.GetRGBvalue(CamID.CamR, 4)));
                ColorDisplay(CamID.CamR, 5, Form1.ColorMatch(CamID.CamR, Form1.GetRGBvalue(CamID.CamR, 5), true));
                ColorDisplay(CamID.CamR, 6, Form1.ColorMatch(CamID.CamR, Form1.GetRGBvalue(CamID.CamR, 6)));
                ColorDisplay(CamID.CamR, 7, Form1.ColorMatch(CamID.CamR, Form1.GetRGBvalue(CamID.CamR, 7)));
                ColorDisplay(CamID.CamR, 8, Form1.ColorMatch(CamID.CamR, Form1.GetRGBvalue(CamID.CamR, 8)));
                ColorDisplay(CamID.CamR, 9, Form1.ColorMatch(CamID.CamR, Form1.GetRGBvalue(CamID.CamR, 9)));

                ColorDisplay(CamID.CamF, 1, Form1.ColorMatch(CamID.CamF, Form1.GetRGBvalue(CamID.CamF, 1)));
                ColorDisplay(CamID.CamF, 2, Form1.ColorMatch(CamID.CamF, Form1.GetRGBvalue(CamID.CamF, 2)));
                ColorDisplay(CamID.CamF, 3, Form1.ColorMatch(CamID.CamF, Form1.GetRGBvalue(CamID.CamF, 3)));
                ColorDisplay(CamID.CamF, 4, Form1.ColorMatch(CamID.CamF, Form1.GetRGBvalue(CamID.CamF, 4)));
                ColorDisplay(CamID.CamF, 5, Form1.ColorMatch(CamID.CamF, Form1.GetRGBvalue(CamID.CamF, 5), true));
                ColorDisplay(CamID.CamF, 6, Form1.ColorMatch(CamID.CamF, Form1.GetRGBvalue(CamID.CamF, 6)));
                ColorDisplay(CamID.CamF, 7, Form1.ColorMatch(CamID.CamF, Form1.GetRGBvalue(CamID.CamF, 7)));
                ColorDisplay(CamID.CamF, 8, Form1.ColorMatch(CamID.CamF, Form1.GetRGBvalue(CamID.CamF, 8)));
                ColorDisplay(CamID.CamF, 9, Form1.ColorMatch(CamID.CamF, Form1.GetRGBvalue(CamID.CamF, 9)));

                ColorDisplay(CamID.CamB, 1, Form1.ColorMatch(CamID.CamB, Form1.GetRGBvalue(CamID.CamB, 1)));
                ColorDisplay(CamID.CamB, 2, Form1.ColorMatch(CamID.CamB, Form1.GetRGBvalue(CamID.CamB, 2)));
                ColorDisplay(CamID.CamB, 3, Form1.ColorMatch(CamID.CamB, Form1.GetRGBvalue(CamID.CamB, 3)));
                ColorDisplay(CamID.CamB, 4, Form1.ColorMatch(CamID.CamB, Form1.GetRGBvalue(CamID.CamB, 4)));
                ColorDisplay(CamID.CamB, 5, Form1.ColorMatch(CamID.CamB, Form1.GetRGBvalue(CamID.CamB, 5), true));
                ColorDisplay(CamID.CamB, 6, Form1.ColorMatch(CamID.CamB, Form1.GetRGBvalue(CamID.CamB, 6)));
                ColorDisplay(CamID.CamB, 7, Form1.ColorMatch(CamID.CamB, Form1.GetRGBvalue(CamID.CamB, 7)));
                ColorDisplay(CamID.CamB, 8, Form1.ColorMatch(CamID.CamB, Form1.GetRGBvalue(CamID.CamB, 8)));
                ColorDisplay(CamID.CamB, 9, Form1.ColorMatch(CamID.CamB, Form1.GetRGBvalue(CamID.CamB, 9)));
            }
            else
            {
                btn_U_Click(sender, e);
                btn_D_Click(sender, e);
                btn_L_Click(sender, e);
                btn_R_Click(sender, e);
                btn_F_Click(sender, e);
                btn_B_Click(sender, e);
            }
        }

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
                    mBtn.BackColor = Color.Red;
                    break;
                case FaceColor.Green:
                    mBtn.BackColor = Color.Green;
                    break;
                case FaceColor.Blue:
                    mBtn.BackColor = Color.Blue;
                    break;
                case FaceColor.White:
                    mBtn.BackColor = Color.White;
                    break;
                case FaceColor.Orange:
                    mBtn.BackColor = Color.Orange;
                    break;
                case FaceColor.Yellow:
                    mBtn.BackColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void btn_Acquire_Click(object sender, EventArgs e)
        { 
            form1.button2_Click(sender, e);
        }
        //int stepIndex = 0;
        bool b_First_U = true;
        bool b_First_D = true;
        bool b_First_L = true;
        bool b_First_R = true;
        bool b_First_F = true;
        bool b_First_B = true;
        private void btn_Solve_Click(object sender, EventArgs e)
        {
            CubeSolve2();
            //if (form1.textBox2.Text !=""&& form1.textBox2.Text.Split(' ')[0]!="Unsolvable")
            //{
            //    string[] mSteps = form1.textBox2.Text.Split(' ');
            //    for (int stepIndex = 0; stepIndex < mSteps.Length; stepIndex++)
            //    {
            //        switch (mSteps[stepIndex].Substring(0, 1))
            //        {
            //            case "U":
            //                RotateTo(mSteps[stepIndex], b_First_U);
            //                if (b_First_U)
            //                {
            //                    b_First_U = false;
            //                }
            //                break;
            //            case "D":
            //                RotateTo(mSteps[stepIndex], b_First_D);
            //                if (b_First_D)
            //                {
            //                    b_First_D = false;
            //                }
            //                break;
            //            case "L":
            //                RotateTo(mSteps[stepIndex], b_First_L);
            //                if (b_First_L)
            //                {
            //                    b_First_L = false;
            //                }
            //                break;
            //            case "R":
            //                RotateTo(mSteps[stepIndex], b_First_R);
            //                if (b_First_R)
            //                {
            //                    b_First_R = false;
            //                }
            //                break;
            //            case "F":
            //                RotateTo(mSteps[stepIndex], b_First_F);
            //                if (b_First_F)
            //                {
            //                    b_First_F = false;
            //                }
            //                break;
            //            case "B":
            //                RotateTo(mSteps[stepIndex], b_First_B);
            //                if (b_First_B)
            //                {
            //                    b_First_B = false;
            //                }
            //                break;
            //            default:
            //                break;
            //        }

            //    }

            //}
            //else
            //{

            //    MessageBox.Show("解魔方失败！");
            //}
        }

        /// <summary>
        /// 支持对面的旋杆儿一起动作
        /// </summary>
        /// <returns></returns>
        public int CubeSolve2()
        {
            int cutTimes = 0;
            if (form1.textBox2.Text != "" && form1.textBox2.Text.Split(' ')[0] != "Unsolvable")
            {
                string[] mSteps = form1.textBox2.Text.Split(' ');
                for (int stepIndex = 0; stepIndex < mSteps.Length; stepIndex++)
                {
                    switch (mSteps[stepIndex].Substring(0, 1))
                    {
                        case "U":
                            if (mSteps[stepIndex + 1].Substring(0, 1) == "D")
                            {
                                cutTimes++;
                                RotateTo(mSteps[stepIndex], mSteps[stepIndex + 1], b_First_U, b_First_D);
                                if (b_First_U)
                                {
                                    b_First_U = false;
                                }
                                if (b_First_D)
                                {
                                    b_First_D = false;
                                }
                                stepIndex = stepIndex + 1;
                            }
                            else
                            {
                                RotateTo(mSteps[stepIndex], b_First_U);
                                if (b_First_U)
                                {
                                    b_First_U = false;
                                }
                            }
                           
                            break;
                        case "D":
                            if (mSteps[stepIndex + 1].Substring(0, 1) == "U")
                            {
                                cutTimes++;
                                RotateTo(mSteps[stepIndex], mSteps[stepIndex + 1], b_First_D, b_First_U);
                                if (b_First_U)
                                {
                                    b_First_U = false;
                                }
                                if (b_First_D)
                                {
                                    b_First_D = false;
                                }
                                stepIndex = stepIndex + 1;
                            }
                            else
                            {
                                RotateTo(mSteps[stepIndex], b_First_D);
                                if (b_First_D)
                                {
                                    b_First_D = false;
                                }
                            }
                            
                            break;
                        case "L":
                            if (mSteps[stepIndex + 1].Substring(0, 1) == "R")
                            {
                                cutTimes++;
                                RotateTo(mSteps[stepIndex], mSteps[stepIndex + 1], b_First_L, b_First_R);
                                if (b_First_L)
                                {
                                    b_First_L = false;
                                }
                                if (b_First_R)
                                {
                                    b_First_R = false;
                                }
                                stepIndex = stepIndex + 1;
                            }
                            else
                            {
                                RotateTo(mSteps[stepIndex], b_First_L);
                                if (b_First_L)
                                {
                                    b_First_L = false;
                                }
                            }
                           
                            break;
                        case "R":
                            if (mSteps[stepIndex + 1].Substring(0, 1) == "L")
                            {
                                cutTimes++;
                                RotateTo(mSteps[stepIndex], mSteps[stepIndex + 1], b_First_R, b_First_L);
                                if (b_First_L)
                                {
                                    b_First_L = false;
                                }
                                if (b_First_R)
                                {
                                    b_First_R = false;
                                }
                                stepIndex = stepIndex + 1;
                            }
                            else
                            {
                                RotateTo(mSteps[stepIndex], b_First_R);
                                if (b_First_R)
                                {
                                    b_First_R = false;
                                }
                            }
                           
                            break;
                        case "F":
                            if (mSteps[stepIndex + 1].Substring(0, 1) == "B")
                            {
                                cutTimes++;
                                RotateTo(mSteps[stepIndex], mSteps[stepIndex + 1], b_First_F, b_First_B);
                                if (b_First_F)
                                {
                                    b_First_F = false;
                                }
                                if (b_First_B)
                                {
                                    b_First_B = false;
                                }
                                stepIndex = stepIndex + 1;
                            }
                            else
                            {
                                RotateTo(mSteps[stepIndex], b_First_F);
                                if (b_First_F)
                                {
                                    b_First_F = false;
                                }
                            }
                           
                            break;
                        case "B":
                            if (mSteps[stepIndex + 1].Substring(0, 1) == "F")
                            {
                                cutTimes++;
                                RotateTo(mSteps[stepIndex], mSteps[stepIndex + 1], b_First_B, b_First_F);
                                if (b_First_F)
                                {
                                    b_First_F = false;
                                }
                                if (b_First_B)
                                {
                                    b_First_B = false;
                                }
                                stepIndex = stepIndex + 1;
                            }
                            else
                            {
                                RotateTo(mSteps[stepIndex], b_First_B);
                                if (b_First_B)
                                {
                                    b_First_B = false;
                                }                                
                            }
                            break;
                        default:
                            break;
                    }

                }
                return mSteps.Length- cutTimes;
            }
            else
            {

                MessageBox.Show("解魔方失败！");
                return 0;
            }
        }
        DateTime ProcessStartTime = DateTime.Now;
        DateTime ProcessEndTime = DateTime.Now;
        public void btn_Start_Click(object sender, EventArgs e)
        {
            updateAxisStatus();
            ProcessStartTime = DateTime.Now;
            if (b_P_Acquire)
            {
                btn_Acquire_Click(sender, e);
                //等待魔方解法计算
                while (form1.textBox2.Text == "")
                {
                    Thread.Sleep(50);
                }
                form1.Update();
                if (form1.textBox2.Text != "" && form1.textBox2.Text.Split(' ')[0] != "Unsolvable")
                {
                    btn_2_P_Rotate_Click(sender, e);
                    DateTime mStartTime = DateTime.Now;
                    int StepCount = CubeSolve2();
                    DateTime mEndTime = DateTime.Now;
                    form1.lbl_TotalTime.Text = "动作时间：" + (mEndTime - mStartTime).Seconds.ToString() + "秒 " + (mEndTime - mStartTime).Milliseconds.ToString() + "毫秒";
                    form1.lbl_StepTime.Text = "单步计时：(" + StepCount.ToString() + ") " + Math.Round(((mEndTime - mStartTime).TotalMilliseconds / StepCount), 3).ToString() + "毫秒";
                    btn_CubeBack_Click(sender, e);
                    form1.lbl_ProcessTime.Text = "整体时间：" + (ProcessEndTime - ProcessStartTime).Seconds.ToString() + "秒 "
                        + (ProcessEndTime - ProcessStartTime).Milliseconds.ToString() + "毫秒";
                }
                else
                {
                    MessageBox.Show("解魔方失败！");
                }
            }
            else if (b_P_Rotate)
            {
                if (form1.textBox2.Text != "" && form1.textBox2.Text.Split(' ')[0] != "Unsolvable")
                {
                    DateTime mStartTime = DateTime.Now;
                    int StepCount = CubeSolve2();
                    DateTime mEndTime = DateTime.Now;
                    form1.lbl_TotalTime.Text = "动作时间：" + (mEndTime - mStartTime).Seconds.ToString() + "秒 " + (mEndTime - mStartTime).Milliseconds.ToString() + "毫秒";
                    form1.lbl_StepTime.Text = "单步计时：(" + StepCount.ToString() + ") " + Math.Round(((mEndTime - mStartTime).TotalMilliseconds / StepCount), 3).ToString() + "毫秒";
                    btn_CubeBack_Click(sender, e);
                    form1.lbl_ProcessTime.Text = "整体时间：" + (ProcessEndTime - ProcessStartTime).Seconds.ToString() + "秒 "
                        + (ProcessEndTime - ProcessStartTime).Milliseconds.ToString() + "毫秒";
                }
                else
                {
                    btn_CubeBack_Click(sender, e);                    
                    form1.lbl_ProcessTime.Text = "整体时间：" + (ProcessEndTime - ProcessStartTime).Seconds.ToString() + "秒 "
                        + (ProcessEndTime - ProcessStartTime).Milliseconds.ToString() + "毫秒";
                }
            }
            else
            {
                btn_2_P_Acquire_Click(sender, e);
                btn_Acquire_Click(sender, e);
                //等待魔方解法计算
                while (form1.textBox2.Text == "")
                {
                    Thread.Sleep(50);
                }
                form1.Update();
                if (form1.textBox2.Text != "" && form1.textBox2.Text.Split(' ')[0] != "Unsolvable")
                {
                    btn_2_P_Rotate_Click(sender, e);
                    DateTime mStartTime = DateTime.Now;
                    int StepCount = CubeSolve2();
                    DateTime mEndTime = DateTime.Now;
                    form1.lbl_TotalTime.Text = "动作时间：" + (mEndTime - mStartTime).Seconds.ToString() + "秒 " + (mEndTime - mStartTime).Milliseconds.ToString() + "毫秒";
                    form1.lbl_StepTime.Text = "单步计时：(" + StepCount.ToString() + ") " + Math.Round(((mEndTime - mStartTime).TotalMilliseconds / StepCount), 3).ToString() + "毫秒";
                    btn_CubeBack_Click(sender, e);
                    form1.lbl_ProcessTime.Text = "整体时间：" + (ProcessEndTime - ProcessStartTime).Seconds.ToString() + "秒 "
                        + (ProcessEndTime - ProcessStartTime).Milliseconds.ToString() + "毫秒";
                }
                else
                {
                    MessageBox.Show("解魔方失败！");
                }
            }
           
        }

        private void Form_Manual_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.mForm_Manual = new Form_Manual(form1);//否则再次打开Form_Manual会报错
        }

        private void btn_AutoColorLearning_Click(object sender, EventArgs e)
        {
            new Form_AutoColorLearning(this).Show();
        }
    }
}

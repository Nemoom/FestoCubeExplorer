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
        }
    }
}

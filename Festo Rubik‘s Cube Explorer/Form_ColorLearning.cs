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
    public partial class Form_ColorLearning : Form
    {
        CamParas mCamParas;
        string mstrCam = "";
        public Form_ColorLearning(string strCam = "")
        {
            InitializeComponent();
            switch (strCam.ToUpper())
            {
                case "U":
                    mstrCam = "CamU";
                    mCamParas = GlobalVariables.CurrentParas.CamU;
                    break;
                case "U_C":
                    mstrCam = @"CamU/Centre";
                    mCamParas = GlobalVariables.CurrentParas.CamU;
                    break;
                case "D":
                    mstrCam = "CamD";
                    mCamParas = GlobalVariables.CurrentParas.CamD;
                    break;
                case "D_C":
                    mstrCam = @"CamD/Centre";
                    mCamParas = GlobalVariables.CurrentParas.CamD;
                    break;
                case "L":
                    mstrCam = "CamL";
                    mCamParas = GlobalVariables.CurrentParas.CamL;
                    break;
                case "L_C":
                    mstrCam = @"CamL/Centre";
                    mCamParas = GlobalVariables.CurrentParas.CamL;
                    break;
                case "R":
                    mstrCam = "CamR";
                    mCamParas = GlobalVariables.CurrentParas.CamR;
                    break;
                case "R_C":
                    mstrCam = @"CamR/Centre";
                    mCamParas = GlobalVariables.CurrentParas.CamR;
                    break;
                case "F":
                    mstrCam = "CamF";
                    mCamParas = GlobalVariables.CurrentParas.CamF;
                    break;
                case "F_C":
                    mstrCam = @"CamF/Centre";
                    mCamParas = GlobalVariables.CurrentParas.CamF;
                    break;
                case "B":
                    mstrCam = "CamB";
                    mCamParas = GlobalVariables.CurrentParas.CamB;
                    break;
                case "B_C":
                    mstrCam = @"CamB/Centre";
                    mCamParas = GlobalVariables.CurrentParas.CamB;
                    break;
                default:
                    mstrCam = "";
                    mCamParas = GlobalVariables.CurrentParas.CamF;
                    break;
            }
            //mstrCam = "Cam" + strCam.ToUpper();
            this.Text = mstrCam;
        }

        private void lbl_Save_DoubleClick(object sender, EventArgs e)
        {
            string XMLNodePath = "";
            if (mstrCam != "")
            {
                if (mstrCam.Length > 4)
                {
                    XMLNodePath = @"Cube/" + mstrCam.Substring(0, 4) + @"/ColorMatch/Centre/";
                }
                else
                {
                    XMLNodePath = @"Cube/" + mstrCam + @"/ColorMatch/";
                }               
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/R_min", nud_Red_R_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/R_max", nud_Red_R_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/G_min", nud_Red_G_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/G_max", nud_Red_G_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/B_min", nud_Red_B_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/B_max", nud_Red_B_Max.Value.ToString());

                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/R_min", nud_Green_R_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/R_max", nud_Green_R_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/G_min", nud_Green_G_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/G_max", nud_Green_G_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/B_min", nud_Green_B_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/B_max", nud_Green_B_Max.Value.ToString());

                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/R_min", nud_Blue_R_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/R_max", nud_Blue_R_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/G_min", nud_Blue_G_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/G_max", nud_Blue_G_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/B_min", nud_Blue_B_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/B_max", nud_Blue_B_Max.Value.ToString());

                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/R_min", nud_White_R_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/R_max", nud_White_R_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/G_min", nud_White_G_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/G_max", nud_White_G_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/B_min", nud_White_B_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/B_max", nud_White_B_Max.Value.ToString());

                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/R_min", nud_Orange_R_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/R_max", nud_Orange_R_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/G_min", nud_Orange_G_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/G_max", nud_Orange_G_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/B_min", nud_Orange_B_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/B_max", nud_Orange_B_Max.Value.ToString());

                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/R_min", nud_Yellow_R_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/R_max", nud_Yellow_R_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/G_min", nud_Yellow_G_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/G_max", nud_Yellow_G_Max.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/B_min", nud_Yellow_B_Min.Value.ToString());
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/B_max", nud_Yellow_B_Max.Value.ToString());
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {                    
                    switch (i)
                    {
                        case 0:
                            XMLNodePath = @"Cube/CamU/ColorMatch/";
                            break;
                        case 1:
                            XMLNodePath = @"Cube/CamD/ColorMatch/";
                            break;
                        case 2:
                            XMLNodePath = @"Cube/CamL/ColorMatch/";
                            break;
                        case 3:
                            XMLNodePath = @"Cube/CamR/ColorMatch/";
                            break;
                        case 4:
                            XMLNodePath = @"Cube/CamF/ColorMatch/";
                            break;
                        case 5:
                            XMLNodePath = @"Cube/CamB/ColorMatch/";
                            break;
                    }
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/R_min", nud_Red_R_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/R_max", nud_Red_R_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/G_min", nud_Red_G_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/G_max", nud_Red_G_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/B_min", nud_Red_B_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Red/B_max", nud_Red_B_Max.Value.ToString());

                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/R_min", nud_Green_R_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/R_max", nud_Green_R_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/G_min", nud_Green_G_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/G_max", nud_Green_G_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/B_min", nud_Green_B_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Green/B_max", nud_Green_B_Max.Value.ToString());

                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/R_min", nud_Blue_R_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/R_max", nud_Blue_R_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/G_min", nud_Blue_G_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/G_max", nud_Blue_G_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/B_min", nud_Blue_B_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Blue/B_max", nud_Blue_B_Max.Value.ToString());

                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/R_min", nud_White_R_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/R_max", nud_White_R_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/G_min", nud_White_G_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/G_max", nud_White_G_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/B_min", nud_White_B_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"White/B_max", nud_White_B_Max.Value.ToString());

                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/R_min", nud_Orange_R_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/R_max", nud_Orange_R_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/G_min", nud_Orange_G_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/G_max", nud_Orange_G_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/B_min", nud_Orange_B_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Orange/B_max", nud_Orange_B_Max.Value.ToString());

                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/R_min", nud_Yellow_R_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/R_max", nud_Yellow_R_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/G_min", nud_Yellow_G_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/G_max", nud_Yellow_G_Max.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/B_min", nud_Yellow_B_Min.Value.ToString());
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Yellow/B_max", nud_Yellow_B_Max.Value.ToString());
                }
            }
            MessageBox.Show("保存成功~");
            GlobalVariables.LoadParasFromXML();
        }

        private void Form_ColorLearning_Load(object sender, EventArgs e)
        {
            if (mstrCam.Length > 4)
            {
                if (mCamParas.mColorMatch.c_Red_c.R_min == mCamParas.mColorMatch.c_Red_c.R_max)
                {
                    //中心块的参数还未单独设置保存
                    nud_Red_R_Min.Value = mCamParas.mColorMatch.c_Red.R_min;
                    nud_Red_R_Max.Value = mCamParas.mColorMatch.c_Red.R_max;
                    nud_Red_G_Min.Value = mCamParas.mColorMatch.c_Red.G_min;
                    nud_Red_G_Max.Value = mCamParas.mColorMatch.c_Red.G_max;
                    nud_Red_B_Min.Value = mCamParas.mColorMatch.c_Red.B_min;
                    nud_Red_B_Max.Value = mCamParas.mColorMatch.c_Red.B_max;

                    nud_Green_R_Min.Value = mCamParas.mColorMatch.c_Green.R_min;
                    nud_Green_R_Max.Value = mCamParas.mColorMatch.c_Green.R_max;
                    nud_Green_G_Min.Value = mCamParas.mColorMatch.c_Green.G_min;
                    nud_Green_G_Max.Value = mCamParas.mColorMatch.c_Green.G_max;
                    nud_Green_B_Min.Value = mCamParas.mColorMatch.c_Green.B_min;
                    nud_Green_B_Max.Value = mCamParas.mColorMatch.c_Green.B_max;

                    nud_Blue_R_Min.Value = mCamParas.mColorMatch.c_Blue.R_min;
                    nud_Blue_R_Max.Value = mCamParas.mColorMatch.c_Blue.R_max;
                    nud_Blue_G_Min.Value = mCamParas.mColorMatch.c_Blue.G_min;
                    nud_Blue_G_Max.Value = mCamParas.mColorMatch.c_Blue.G_max;
                    nud_Blue_B_Min.Value = mCamParas.mColorMatch.c_Blue.B_min;
                    nud_Blue_B_Max.Value = mCamParas.mColorMatch.c_Blue.B_max;

                    nud_White_R_Min.Value = mCamParas.mColorMatch.c_White.R_min;
                    nud_White_R_Max.Value = mCamParas.mColorMatch.c_White.R_max;
                    nud_White_G_Min.Value = mCamParas.mColorMatch.c_White.G_min;
                    nud_White_G_Max.Value = mCamParas.mColorMatch.c_White.G_max;
                    nud_White_B_Min.Value = mCamParas.mColorMatch.c_White.B_min;
                    nud_White_B_Max.Value = mCamParas.mColorMatch.c_White.B_max;

                    nud_Orange_R_Min.Value = mCamParas.mColorMatch.c_Orange.R_min;
                    nud_Orange_R_Max.Value = mCamParas.mColorMatch.c_Orange.R_max;
                    nud_Orange_G_Min.Value = mCamParas.mColorMatch.c_Orange.G_min;
                    nud_Orange_G_Max.Value = mCamParas.mColorMatch.c_Orange.G_max;
                    nud_Orange_B_Min.Value = mCamParas.mColorMatch.c_Orange.B_min;
                    nud_Orange_B_Max.Value = mCamParas.mColorMatch.c_Orange.B_max;

                    nud_Yellow_R_Min.Value = mCamParas.mColorMatch.c_Yellow.R_min;
                    nud_Yellow_R_Max.Value = mCamParas.mColorMatch.c_Yellow.R_max;
                    nud_Yellow_G_Min.Value = mCamParas.mColorMatch.c_Yellow.G_min;
                    nud_Yellow_G_Max.Value = mCamParas.mColorMatch.c_Yellow.G_max;
                    nud_Yellow_B_Min.Value = mCamParas.mColorMatch.c_Yellow.B_min;
                    nud_Yellow_B_Max.Value = mCamParas.mColorMatch.c_Yellow.B_max;
                }
                else
                {
                    nud_Red_R_Min.Value = mCamParas.mColorMatch.c_Red_c.R_min;
                    nud_Red_R_Max.Value = mCamParas.mColorMatch.c_Red_c.R_max;
                    nud_Red_G_Min.Value = mCamParas.mColorMatch.c_Red_c.G_min;
                    nud_Red_G_Max.Value = mCamParas.mColorMatch.c_Red_c.G_max;
                    nud_Red_B_Min.Value = mCamParas.mColorMatch.c_Red_c.B_min;
                    nud_Red_B_Max.Value = mCamParas.mColorMatch.c_Red_c.B_max;

                    nud_Green_R_Min.Value = mCamParas.mColorMatch.c_Green_c.R_min;
                    nud_Green_R_Max.Value = mCamParas.mColorMatch.c_Green_c.R_max;
                    nud_Green_G_Min.Value = mCamParas.mColorMatch.c_Green_c.G_min;
                    nud_Green_G_Max.Value = mCamParas.mColorMatch.c_Green_c.G_max;
                    nud_Green_B_Min.Value = mCamParas.mColorMatch.c_Green_c.B_min;
                    nud_Green_B_Max.Value = mCamParas.mColorMatch.c_Green_c.B_max;

                    nud_Blue_R_Min.Value = mCamParas.mColorMatch.c_Blue_c.R_min;
                    nud_Blue_R_Max.Value = mCamParas.mColorMatch.c_Blue_c.R_max;
                    nud_Blue_G_Min.Value = mCamParas.mColorMatch.c_Blue_c.G_min;
                    nud_Blue_G_Max.Value = mCamParas.mColorMatch.c_Blue_c.G_max;
                    nud_Blue_B_Min.Value = mCamParas.mColorMatch.c_Blue_c.B_min;
                    nud_Blue_B_Max.Value = mCamParas.mColorMatch.c_Blue_c.B_max;

                    nud_White_R_Min.Value = mCamParas.mColorMatch.c_White_c.R_min;
                    nud_White_R_Max.Value = mCamParas.mColorMatch.c_White_c.R_max;
                    nud_White_G_Min.Value = mCamParas.mColorMatch.c_White_c.G_min;
                    nud_White_G_Max.Value = mCamParas.mColorMatch.c_White_c.G_max;
                    nud_White_B_Min.Value = mCamParas.mColorMatch.c_White_c.B_min;
                    nud_White_B_Max.Value = mCamParas.mColorMatch.c_White_c.B_max;

                    nud_Orange_R_Min.Value = mCamParas.mColorMatch.c_Orange_c.R_min;
                    nud_Orange_R_Max.Value = mCamParas.mColorMatch.c_Orange_c.R_max;
                    nud_Orange_G_Min.Value = mCamParas.mColorMatch.c_Orange_c.G_min;
                    nud_Orange_G_Max.Value = mCamParas.mColorMatch.c_Orange_c.G_max;
                    nud_Orange_B_Min.Value = mCamParas.mColorMatch.c_Orange_c.B_min;
                    nud_Orange_B_Max.Value = mCamParas.mColorMatch.c_Orange_c.B_max;

                    nud_Yellow_R_Min.Value = mCamParas.mColorMatch.c_Yellow_c.R_min;
                    nud_Yellow_R_Max.Value = mCamParas.mColorMatch.c_Yellow_c.R_max;
                    nud_Yellow_G_Min.Value = mCamParas.mColorMatch.c_Yellow_c.G_min;
                    nud_Yellow_G_Max.Value = mCamParas.mColorMatch.c_Yellow_c.G_max;
                    nud_Yellow_B_Min.Value = mCamParas.mColorMatch.c_Yellow_c.B_min;
                    nud_Yellow_B_Max.Value = mCamParas.mColorMatch.c_Yellow_c.B_max;
                }
               
            }
            else
            {
                nud_Red_R_Min.Value = mCamParas.mColorMatch.c_Red.R_min;
                nud_Red_R_Max.Value = mCamParas.mColorMatch.c_Red.R_max;
                nud_Red_G_Min.Value = mCamParas.mColorMatch.c_Red.G_min;
                nud_Red_G_Max.Value = mCamParas.mColorMatch.c_Red.G_max;
                nud_Red_B_Min.Value = mCamParas.mColorMatch.c_Red.B_min;
                nud_Red_B_Max.Value = mCamParas.mColorMatch.c_Red.B_max;

                nud_Green_R_Min.Value = mCamParas.mColorMatch.c_Green.R_min;
                nud_Green_R_Max.Value = mCamParas.mColorMatch.c_Green.R_max;
                nud_Green_G_Min.Value = mCamParas.mColorMatch.c_Green.G_min;
                nud_Green_G_Max.Value = mCamParas.mColorMatch.c_Green.G_max;
                nud_Green_B_Min.Value = mCamParas.mColorMatch.c_Green.B_min;
                nud_Green_B_Max.Value = mCamParas.mColorMatch.c_Green.B_max;

                nud_Blue_R_Min.Value = mCamParas.mColorMatch.c_Blue.R_min;
                nud_Blue_R_Max.Value = mCamParas.mColorMatch.c_Blue.R_max;
                nud_Blue_G_Min.Value = mCamParas.mColorMatch.c_Blue.G_min;
                nud_Blue_G_Max.Value = mCamParas.mColorMatch.c_Blue.G_max;
                nud_Blue_B_Min.Value = mCamParas.mColorMatch.c_Blue.B_min;
                nud_Blue_B_Max.Value = mCamParas.mColorMatch.c_Blue.B_max;

                nud_White_R_Min.Value = mCamParas.mColorMatch.c_White.R_min;
                nud_White_R_Max.Value = mCamParas.mColorMatch.c_White.R_max;
                nud_White_G_Min.Value = mCamParas.mColorMatch.c_White.G_min;
                nud_White_G_Max.Value = mCamParas.mColorMatch.c_White.G_max;
                nud_White_B_Min.Value = mCamParas.mColorMatch.c_White.B_min;
                nud_White_B_Max.Value = mCamParas.mColorMatch.c_White.B_max;

                nud_Orange_R_Min.Value = mCamParas.mColorMatch.c_Orange.R_min;
                nud_Orange_R_Max.Value = mCamParas.mColorMatch.c_Orange.R_max;
                nud_Orange_G_Min.Value = mCamParas.mColorMatch.c_Orange.G_min;
                nud_Orange_G_Max.Value = mCamParas.mColorMatch.c_Orange.G_max;
                nud_Orange_B_Min.Value = mCamParas.mColorMatch.c_Orange.B_min;
                nud_Orange_B_Max.Value = mCamParas.mColorMatch.c_Orange.B_max;

                nud_Yellow_R_Min.Value = mCamParas.mColorMatch.c_Yellow.R_min;
                nud_Yellow_R_Max.Value = mCamParas.mColorMatch.c_Yellow.R_max;
                nud_Yellow_G_Min.Value = mCamParas.mColorMatch.c_Yellow.G_min;
                nud_Yellow_G_Max.Value = mCamParas.mColorMatch.c_Yellow.G_max;
                nud_Yellow_B_Min.Value = mCamParas.mColorMatch.c_Yellow.B_min;
                nud_Yellow_B_Max.Value = mCamParas.mColorMatch.c_Yellow.B_max;
            }
                
        }
    }
}

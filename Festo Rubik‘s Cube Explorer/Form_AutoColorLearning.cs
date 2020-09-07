using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Festo_Rubik_s_Cube_Explorer
{
    public partial class Form_AutoColorLearning : Form
    {
        public Form_AutoColorLearning(Form_Manual form_Manual)
        {
            InitializeComponent();
            mForm_Manual = form_Manual;
        }
        XMLStruct mXMLStruct_new = new XMLStruct();
        int StepIndex_Cur = 0;
        Form_Manual mForm_Manual;
        bool Step1_Updated = false; 
        bool Step2_Updated = false; 
        bool Step3_Updated = false;
        bool Step4_Updated = false;
        bool Step5_Updated = false;
        bool Step6_Updated = false;
        public void update_c_Red(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }

        public void update_c_Red_c(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red_c.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red_c.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red_c.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red_c.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red_c.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Red_c.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Red_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Red_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red_c.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red_c.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red_c.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red_c.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red_c.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Red_c.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Red_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Red_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red_c.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red_c.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red_c.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red_c.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red_c.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Red_c.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Red_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Red_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red_c.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red_c.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red_c.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red_c.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red_c.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Red_c.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Red_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Red_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red_c.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red_c.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red_c.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red_c.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red_c.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Red_c.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Red_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Red_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red_c.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red_c.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red_c.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red_c.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red_c.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Red_c.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Red_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Red_c.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }

        public void update_c_Green(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }

        public void update_c_Green_c(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green_c.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green_c.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green_c.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green_c.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green_c.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Green_c.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Green_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Green_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green_c.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green_c.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green_c.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green_c.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green_c.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Green_c.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Green_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Green_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green_c.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green_c.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green_c.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green_c.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green_c.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Green_c.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Green_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Green_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green_c.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green_c.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green_c.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green_c.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green_c.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Green_c.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Green_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Green_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green_c.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green_c.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green_c.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green_c.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green_c.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Green_c.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Green_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Green_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green_c.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green_c.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green_c.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green_c.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green_c.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Green_c.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Green_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Green_c.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }


        public void update_c_Blue(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }

        public void update_c_Blue_c(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue_c.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue_c.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue_c.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue_c.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue_c.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Blue_c.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Blue_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Blue_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue_c.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue_c.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue_c.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue_c.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue_c.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Blue_c.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Blue_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Blue_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue_c.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue_c.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue_c.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue_c.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue_c.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Blue_c.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Blue_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Blue_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue_c.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue_c.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue_c.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue_c.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue_c.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Blue_c.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Blue_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Blue_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue_c.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue_c.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue_c.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue_c.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue_c.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Blue_c.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Blue_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Blue_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue_c.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue_c.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue_c.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue_c.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue_c.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Blue_c.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Blue_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Blue_c.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }


        public void update_c_White(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_White.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_White.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_White.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_White.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_White.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_White.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_White.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_White.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_White.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_White.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_White.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_White.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_White.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_White.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_White.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_White.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_White.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_White.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_White.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_White.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_White.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_White.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_White.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_White.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_White.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_White.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_White.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_White.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_White.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_White.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_White.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_White.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_White.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_White.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_White.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_White.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_White.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_White.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_White.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_White.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_White.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_White.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }

        public void update_c_White_c(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_White_c.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_White_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White_c.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_White_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White_c.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_White_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White_c.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_White_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White_c.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_White_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_White_c.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_White_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_White_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_White_c.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_White_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White_c.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_White_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White_c.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_White_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White_c.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_White_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White_c.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_White_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_White_c.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_White_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_White_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_White_c.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_White_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White_c.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_White_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White_c.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_White_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White_c.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_White_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White_c.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_White_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_White_c.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_White_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_White_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_White_c.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_White_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White_c.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_White_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White_c.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_White_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White_c.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_White_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White_c.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_White_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_White_c.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_White_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_White_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_White_c.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_White_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White_c.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_White_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White_c.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_White_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White_c.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_White_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White_c.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_White_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_White_c.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_White_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_White_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_White_c.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_White_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White_c.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_White_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White_c.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_White_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White_c.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_White_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White_c.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_White_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_White_c.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_White_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_White_c.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }


        public void update_c_Yellow(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }

        public void update_c_Yellow_c(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Yellow_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Yellow_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Yellow_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Yellow_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Yellow_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Yellow_c.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }


        public void update_c_Orange(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }

        public void update_c_Orange_c(CamID mCamID, Button mButton)
        {
            switch (mCamID)
            {
                case CamID.CamU:
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange_c.R_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange_c.R_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange_c.G_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange_c.G_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange_c.B_min == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamU.mColorMatch.c_Orange_c.B_max == 0 || mXMLStruct_new.CamU.mColorMatch.c_Orange_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamU.mColorMatch.c_Orange_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamD:
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange_c.R_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange_c.R_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange_c.G_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange_c.G_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange_c.B_min == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamD.mColorMatch.c_Orange_c.B_max == 0 || mXMLStruct_new.CamD.mColorMatch.c_Orange_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamD.mColorMatch.c_Orange_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamL:
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange_c.R_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange_c.R_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange_c.G_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange_c.G_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange_c.B_min == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamL.mColorMatch.c_Orange_c.B_max == 0 || mXMLStruct_new.CamL.mColorMatch.c_Orange_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamL.mColorMatch.c_Orange_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamR:
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange_c.R_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange_c.R_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange_c.G_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange_c.G_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange_c.B_min == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamR.mColorMatch.c_Orange_c.B_max == 0 || mXMLStruct_new.CamR.mColorMatch.c_Orange_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamR.mColorMatch.c_Orange_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamF:
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange_c.R_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange_c.R_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange_c.G_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange_c.G_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange_c.B_min == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamF.mColorMatch.c_Orange_c.B_max == 0 || mXMLStruct_new.CamF.mColorMatch.c_Orange_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamF.mColorMatch.c_Orange_c.B_max = mButton.BackColor.B;
                    }
                    break;
                case CamID.CamB:
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange_c.R_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange_c.R_min > mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange_c.R_min = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange_c.R_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange_c.R_max < mButton.BackColor.R)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange_c.R_max = mButton.BackColor.R;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange_c.G_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange_c.G_min > mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange_c.G_min = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange_c.G_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange_c.G_max < mButton.BackColor.G)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange_c.G_max = mButton.BackColor.G;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange_c.B_min == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange_c.B_min > mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange_c.B_min = mButton.BackColor.B;
                    }
                    if (mXMLStruct_new.CamB.mColorMatch.c_Orange_c.B_max == 0 || mXMLStruct_new.CamB.mColorMatch.c_Orange_c.B_max < mButton.BackColor.B)
                    {
                        mXMLStruct_new.CamB.mColorMatch.c_Orange_c.B_max = mButton.BackColor.B;
                    }
                    break;
                default:
                    break;
            }
        }


        public void GetMinMax(CamID mCamID, FaceColor mFaceColor) 
        {
            try
            {              
                switch (mCamID)
                {
                    case CamID.CamU:
                        switch (mFaceColor)
                        {
                            case FaceColor.Red:
                                update_c_Red(mCamID, btn_U1);
                                update_c_Red(mCamID, btn_U2);
                                update_c_Red(mCamID, btn_U3);
                                update_c_Red(mCamID, btn_U4);
                                update_c_Red_c(mCamID, btn_U5);
                                update_c_Red(mCamID, btn_U6);
                                update_c_Red(mCamID, btn_U7);
                                update_c_Red(mCamID, btn_U8);
                                update_c_Red(mCamID, btn_U9);
                                break;
                            case FaceColor.Green:
                                update_c_Green(mCamID, btn_U1);
                                update_c_Green(mCamID, btn_U2);
                                update_c_Green(mCamID, btn_U3);
                                update_c_Green(mCamID, btn_U4);
                                update_c_Green_c(mCamID, btn_U5);
                                update_c_Green(mCamID, btn_U6);
                                update_c_Green(mCamID, btn_U7);
                                update_c_Green(mCamID, btn_U8);
                                update_c_Green(mCamID, btn_U9);
                                break;
                            case FaceColor.Blue:
                                update_c_Blue(mCamID, btn_U1);
                                update_c_Blue(mCamID, btn_U2);
                                update_c_Blue(mCamID, btn_U3);
                                update_c_Blue(mCamID, btn_U4);
                                update_c_Blue_c(mCamID, btn_U5);
                                update_c_Blue(mCamID, btn_U6);
                                update_c_Blue(mCamID, btn_U7);
                                update_c_Blue(mCamID, btn_U8);
                                update_c_Blue(mCamID, btn_U9);
                                break;
                            case FaceColor.White:
                                update_c_White(mCamID, btn_U1);
                                update_c_White(mCamID, btn_U2);
                                update_c_White(mCamID, btn_U3);
                                update_c_White(mCamID, btn_U4);
                                update_c_White_c(mCamID, btn_U5);
                                update_c_White(mCamID, btn_U6);
                                update_c_White(mCamID, btn_U7);
                                update_c_White(mCamID, btn_U8);
                                update_c_White(mCamID, btn_U9);
                                break;
                            case FaceColor.Orange:
                                update_c_Orange(mCamID, btn_U1);
                                update_c_Orange(mCamID, btn_U2);
                                update_c_Orange(mCamID, btn_U3);
                                update_c_Orange(mCamID, btn_U4);
                                update_c_Orange_c(mCamID, btn_U5);
                                update_c_Orange(mCamID, btn_U6);
                                update_c_Orange(mCamID, btn_U7);
                                update_c_Orange(mCamID, btn_U8);
                                update_c_Orange(mCamID, btn_U9);
                                break;
                            case FaceColor.Yellow:
                                update_c_Yellow(mCamID, btn_U1);
                                update_c_Yellow(mCamID, btn_U2);
                                update_c_Yellow(mCamID, btn_U3);
                                update_c_Yellow(mCamID, btn_U4);
                                update_c_Yellow_c(mCamID, btn_U5);
                                update_c_Yellow(mCamID, btn_U6);
                                update_c_Yellow(mCamID, btn_U7);
                                update_c_Yellow(mCamID, btn_U8);
                                update_c_Yellow(mCamID, btn_U9);
                                break;
                            default:
                                break;
                        }
                        break;
                    case CamID.CamD:
                        switch (mFaceColor)
                        {
                            case FaceColor.Red:
                                update_c_Red(mCamID, btn_D1);
                                update_c_Red(mCamID, btn_D2);
                                update_c_Red(mCamID, btn_D3);
                                update_c_Red(mCamID, btn_D4);
                                update_c_Red_c(mCamID, btn_D5);
                                update_c_Red(mCamID, btn_D6);
                                update_c_Red(mCamID, btn_D7);
                                update_c_Red(mCamID, btn_D8);
                                update_c_Red(mCamID, btn_D9);
                                break;
                            case FaceColor.Green:
                                update_c_Green(mCamID, btn_D1);
                                update_c_Green(mCamID, btn_D2);
                                update_c_Green(mCamID, btn_D3);
                                update_c_Green(mCamID, btn_D4);
                                update_c_Green_c(mCamID, btn_D5);
                                update_c_Green(mCamID, btn_D6);
                                update_c_Green(mCamID, btn_D7);
                                update_c_Green(mCamID, btn_D8);
                                update_c_Green(mCamID, btn_D9);
                                break;
                            case FaceColor.Blue:
                                update_c_Blue(mCamID, btn_D1);
                                update_c_Blue(mCamID, btn_D2);
                                update_c_Blue(mCamID, btn_D3);
                                update_c_Blue(mCamID, btn_D4);
                                update_c_Blue_c(mCamID, btn_D5);
                                update_c_Blue(mCamID, btn_D6);
                                update_c_Blue(mCamID, btn_D7);
                                update_c_Blue(mCamID, btn_D8);
                                update_c_Blue(mCamID, btn_D9);
                                break;
                            case FaceColor.White:
                                update_c_White(mCamID, btn_D1);
                                update_c_White(mCamID, btn_D2);
                                update_c_White(mCamID, btn_D3);
                                update_c_White(mCamID, btn_D4);
                                update_c_White_c(mCamID, btn_D5);
                                update_c_White(mCamID, btn_D6);
                                update_c_White(mCamID, btn_D7);
                                update_c_White(mCamID, btn_D8);
                                update_c_White(mCamID, btn_D9);
                                break;
                            case FaceColor.Orange:
                                update_c_Orange(mCamID, btn_D1);
                                update_c_Orange(mCamID, btn_D2);
                                update_c_Orange(mCamID, btn_D3);
                                update_c_Orange(mCamID, btn_D4);
                                update_c_Orange_c(mCamID, btn_D5);
                                update_c_Orange(mCamID, btn_D6);
                                update_c_Orange(mCamID, btn_D7);
                                update_c_Orange(mCamID, btn_D8);
                                update_c_Orange(mCamID, btn_D9);
                                break;
                            case FaceColor.Yellow:
                                update_c_Yellow(mCamID, btn_D1);
                                update_c_Yellow(mCamID, btn_D2);
                                update_c_Yellow(mCamID, btn_D3);
                                update_c_Yellow(mCamID, btn_D4);
                                update_c_Yellow_c(mCamID, btn_D5);
                                update_c_Yellow(mCamID, btn_D6);
                                update_c_Yellow(mCamID, btn_D7);
                                update_c_Yellow(mCamID, btn_D8);
                                update_c_Yellow(mCamID, btn_D9);
                                break;
                            default:
                                break;
                        }
                        break;
                    case CamID.CamL:
                        switch (mFaceColor)
                        {
                            case FaceColor.Red:
                                update_c_Red(mCamID, btn_L1);
                                update_c_Red(mCamID, btn_L2);
                                update_c_Red(mCamID, btn_L3);
                                update_c_Red(mCamID, btn_L4);
                                update_c_Red_c(mCamID, btn_L5);
                                update_c_Red(mCamID, btn_L6);
                                update_c_Red(mCamID, btn_L7);
                                update_c_Red(mCamID, btn_L8);
                                update_c_Red(mCamID, btn_L9);
                                break;
                            case FaceColor.Green:
                                update_c_Green(mCamID, btn_L1);
                                update_c_Green(mCamID, btn_L2);
                                update_c_Green(mCamID, btn_L3);
                                update_c_Green(mCamID, btn_L4);
                                update_c_Green_c(mCamID, btn_L5);
                                update_c_Green(mCamID, btn_L6);
                                update_c_Green(mCamID, btn_L7);
                                update_c_Green(mCamID, btn_L8);
                                update_c_Green(mCamID, btn_L9);
                                break;
                            case FaceColor.Blue:
                                update_c_Blue(mCamID, btn_L1);
                                update_c_Blue(mCamID, btn_L2);
                                update_c_Blue(mCamID, btn_L3);
                                update_c_Blue(mCamID, btn_L4);
                                update_c_Blue_c(mCamID, btn_L5);
                                update_c_Blue(mCamID, btn_L6);
                                update_c_Blue(mCamID, btn_L7);
                                update_c_Blue(mCamID, btn_L8);
                                update_c_Blue(mCamID, btn_L9);
                                break;
                            case FaceColor.White:
                                update_c_White(mCamID, btn_L1);
                                update_c_White(mCamID, btn_L2);
                                update_c_White(mCamID, btn_L3);
                                update_c_White(mCamID, btn_L4);
                                update_c_White_c(mCamID, btn_L5);
                                update_c_White(mCamID, btn_L6);
                                update_c_White(mCamID, btn_L7);
                                update_c_White(mCamID, btn_L8);
                                update_c_White(mCamID, btn_L9);
                                break;
                            case FaceColor.Orange:
                                update_c_Orange(mCamID, btn_L1);
                                update_c_Orange(mCamID, btn_L2);
                                update_c_Orange(mCamID, btn_L3);
                                update_c_Orange(mCamID, btn_L4);
                                update_c_Orange_c(mCamID, btn_L5);
                                update_c_Orange(mCamID, btn_L6);
                                update_c_Orange(mCamID, btn_L7);
                                update_c_Orange(mCamID, btn_L8);
                                update_c_Orange(mCamID, btn_L9);
                                break;
                            case FaceColor.Yellow:
                                update_c_Yellow(mCamID, btn_L1);
                                update_c_Yellow(mCamID, btn_L2);
                                update_c_Yellow(mCamID, btn_L3);
                                update_c_Yellow(mCamID, btn_L4);
                                update_c_Yellow_c(mCamID, btn_L5);
                                update_c_Yellow(mCamID, btn_L6);
                                update_c_Yellow(mCamID, btn_L7);
                                update_c_Yellow(mCamID, btn_L8);
                                update_c_Yellow(mCamID, btn_L9);
                                break;
                            default:
                                break;
                        }
                        break;
                    case CamID.CamR:
                        switch (mFaceColor)
                        {
                            case FaceColor.Red:
                                update_c_Red(mCamID, btn_R1);
                                update_c_Red(mCamID, btn_R2);
                                update_c_Red(mCamID, btn_R3);
                                update_c_Red(mCamID, btn_R4);
                                update_c_Red_c(mCamID, btn_R5);
                                update_c_Red(mCamID, btn_R6);
                                update_c_Red(mCamID, btn_R7);
                                update_c_Red(mCamID, btn_R8);
                                update_c_Red(mCamID, btn_R9);
                                break;
                            case FaceColor.Green:
                                update_c_Green(mCamID, btn_R1);
                                update_c_Green(mCamID, btn_R2);
                                update_c_Green(mCamID, btn_R3);
                                update_c_Green(mCamID, btn_R4);
                                update_c_Green_c(mCamID, btn_R5);
                                update_c_Green(mCamID, btn_R6);
                                update_c_Green(mCamID, btn_R7);
                                update_c_Green(mCamID, btn_R8);
                                update_c_Green(mCamID, btn_R9);
                                break;
                            case FaceColor.Blue:
                                update_c_Blue(mCamID, btn_R1);
                                update_c_Blue(mCamID, btn_R2);
                                update_c_Blue(mCamID, btn_R3);
                                update_c_Blue(mCamID, btn_R4);
                                update_c_Blue_c(mCamID, btn_R5);
                                update_c_Blue(mCamID, btn_R6);
                                update_c_Blue(mCamID, btn_R7);
                                update_c_Blue(mCamID, btn_R8);
                                update_c_Blue(mCamID, btn_R9);
                                break;
                            case FaceColor.White:
                                update_c_White(mCamID, btn_R1);
                                update_c_White(mCamID, btn_R2);
                                update_c_White(mCamID, btn_R3);
                                update_c_White(mCamID, btn_R4);
                                update_c_White_c(mCamID, btn_R5);
                                update_c_White(mCamID, btn_R6);
                                update_c_White(mCamID, btn_R7);
                                update_c_White(mCamID, btn_R8);
                                update_c_White(mCamID, btn_R9);
                                break;
                            case FaceColor.Orange:
                                update_c_Orange(mCamID, btn_R1);
                                update_c_Orange(mCamID, btn_R2);
                                update_c_Orange(mCamID, btn_R3);
                                update_c_Orange(mCamID, btn_R4);
                                update_c_Orange_c(mCamID, btn_R5);
                                update_c_Orange(mCamID, btn_R6);
                                update_c_Orange(mCamID, btn_R7);
                                update_c_Orange(mCamID, btn_R8);
                                update_c_Orange(mCamID, btn_R9);
                                break;
                            case FaceColor.Yellow:
                                update_c_Yellow(mCamID, btn_R1);
                                update_c_Yellow(mCamID, btn_R2);
                                update_c_Yellow(mCamID, btn_R3);
                                update_c_Yellow(mCamID, btn_R4);
                                update_c_Yellow_c(mCamID, btn_R5);
                                update_c_Yellow(mCamID, btn_R6);
                                update_c_Yellow(mCamID, btn_R7);
                                update_c_Yellow(mCamID, btn_R8);
                                update_c_Yellow(mCamID, btn_R9);
                                break;
                            default:
                                break;
                        }
                        break;
                    case CamID.CamF:
                        switch (mFaceColor)
                        {
                            case FaceColor.Red:
                                update_c_Red(mCamID, btn_F1);
                                update_c_Red(mCamID, btn_F2);
                                update_c_Red(mCamID, btn_F3);
                                update_c_Red(mCamID, btn_F4);
                                update_c_Red_c(mCamID, btn_F5);
                                update_c_Red(mCamID, btn_F6);
                                update_c_Red(mCamID, btn_F7);
                                update_c_Red(mCamID, btn_F8);
                                update_c_Red(mCamID, btn_F9);
                                break;
                            case FaceColor.Green:
                                update_c_Green(mCamID, btn_F1);
                                update_c_Green(mCamID, btn_F2);
                                update_c_Green(mCamID, btn_F3);
                                update_c_Green(mCamID, btn_F4);
                                update_c_Green_c(mCamID, btn_F5);
                                update_c_Green(mCamID, btn_F6);
                                update_c_Green(mCamID, btn_F7);
                                update_c_Green(mCamID, btn_F8);
                                update_c_Green(mCamID, btn_F9);
                                break;
                            case FaceColor.Blue:
                                update_c_Blue(mCamID, btn_F1);
                                update_c_Blue(mCamID, btn_F2);
                                update_c_Blue(mCamID, btn_F3);
                                update_c_Blue(mCamID, btn_F4);
                                update_c_Blue_c(mCamID, btn_F5);
                                update_c_Blue(mCamID, btn_F6);
                                update_c_Blue(mCamID, btn_F7);
                                update_c_Blue(mCamID, btn_F8);
                                update_c_Blue(mCamID, btn_F9);
                                break;
                            case FaceColor.White:
                                update_c_White(mCamID, btn_F1);
                                update_c_White(mCamID, btn_F2);
                                update_c_White(mCamID, btn_F3);
                                update_c_White(mCamID, btn_F4);
                                update_c_White_c(mCamID, btn_F5);
                                update_c_White(mCamID, btn_F6);
                                update_c_White(mCamID, btn_F7);
                                update_c_White(mCamID, btn_F8);
                                update_c_White(mCamID, btn_F9);
                                break;
                            case FaceColor.Orange:
                                update_c_Orange(mCamID, btn_F1);
                                update_c_Orange(mCamID, btn_F2);
                                update_c_Orange(mCamID, btn_F3);
                                update_c_Orange(mCamID, btn_F4);
                                update_c_Orange_c(mCamID, btn_F5);
                                update_c_Orange(mCamID, btn_F6);
                                update_c_Orange(mCamID, btn_F7);
                                update_c_Orange(mCamID, btn_F8);
                                update_c_Orange(mCamID, btn_F9);
                                break;
                            case FaceColor.Yellow:
                                update_c_Yellow(mCamID, btn_F1);
                                update_c_Yellow(mCamID, btn_F2);
                                update_c_Yellow(mCamID, btn_F3);
                                update_c_Yellow(mCamID, btn_F4);
                                update_c_Yellow_c(mCamID, btn_F5);
                                update_c_Yellow(mCamID, btn_F6);
                                update_c_Yellow(mCamID, btn_F7);
                                update_c_Yellow(mCamID, btn_F8);
                                update_c_Yellow(mCamID, btn_F9);
                                break;
                            default:
                                break;
                        }
                        break;
                    case CamID.CamB:
                        switch (mFaceColor)
                        {
                            case FaceColor.Red:
                                update_c_Red(mCamID, btn_B1);
                                update_c_Red(mCamID, btn_B2);
                                update_c_Red(mCamID, btn_B3);
                                update_c_Red(mCamID, btn_B4);
                                update_c_Red_c(mCamID, btn_B5);
                                update_c_Red(mCamID, btn_B6);
                                update_c_Red(mCamID, btn_B7);
                                update_c_Red(mCamID, btn_B8);
                                update_c_Red(mCamID, btn_B9);
                                break;
                            case FaceColor.Green:
                                update_c_Green(mCamID, btn_B1);
                                update_c_Green(mCamID, btn_B2);
                                update_c_Green(mCamID, btn_B3);
                                update_c_Green(mCamID, btn_B4);
                                update_c_Green_c(mCamID, btn_B5);
                                update_c_Green(mCamID, btn_B6);
                                update_c_Green(mCamID, btn_B7);
                                update_c_Green(mCamID, btn_B8);
                                update_c_Green(mCamID, btn_B9);
                                break;
                            case FaceColor.Blue:
                                update_c_Blue(mCamID, btn_B1);
                                update_c_Blue(mCamID, btn_B2);
                                update_c_Blue(mCamID, btn_B3);
                                update_c_Blue(mCamID, btn_B4);
                                update_c_Blue_c(mCamID, btn_B5);
                                update_c_Blue(mCamID, btn_B6);
                                update_c_Blue(mCamID, btn_B7);
                                update_c_Blue(mCamID, btn_B8);
                                update_c_Blue(mCamID, btn_B9);
                                break;
                            case FaceColor.White:
                                update_c_White(mCamID, btn_B1);
                                update_c_White(mCamID, btn_B2);
                                update_c_White(mCamID, btn_B3);
                                update_c_White(mCamID, btn_B4);
                                update_c_White_c(mCamID, btn_B5);
                                update_c_White(mCamID, btn_B6);
                                update_c_White(mCamID, btn_B7);
                                update_c_White(mCamID, btn_B8);
                                update_c_White(mCamID, btn_B9);
                                break;
                            case FaceColor.Orange:
                                update_c_Orange(mCamID, btn_B1);
                                update_c_Orange(mCamID, btn_B2);
                                update_c_Orange(mCamID, btn_B3);
                                update_c_Orange(mCamID, btn_B4);
                                update_c_Orange_c(mCamID, btn_B5);
                                update_c_Orange(mCamID, btn_B6);
                                update_c_Orange(mCamID, btn_B7);
                                update_c_Orange(mCamID, btn_B8);
                                update_c_Orange(mCamID, btn_B9);
                                break;
                            case FaceColor.Yellow:
                                update_c_Yellow(mCamID, btn_B1);
                                update_c_Yellow(mCamID, btn_B2);
                                update_c_Yellow(mCamID, btn_B3);
                                update_c_Yellow(mCamID, btn_B4);
                                update_c_Yellow_c(mCamID, btn_B5);
                                update_c_Yellow(mCamID, btn_B6);
                                update_c_Yellow(mCamID, btn_B7);
                                update_c_Yellow(mCamID, btn_B8);
                                update_c_Yellow(mCamID, btn_B9);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool UpdateParams(string strCam, FaceColor mFaceColor)
        {
            bool b_Success = false;
            CamParas mCamParas = new CamParas();
            RGB_MinMax mRGB_MinMax = new RGB_MinMax();
            string mstrCam;
            try
            {
                switch (strCam.ToUpper())
                {
                    case "U":
                    case "U_C":
                        mstrCam = "Cam" + strCam.ToUpper();
                        mCamParas = mXMLStruct_new.CamU;
                        break;
                    case "D":
                    case "D_C":
                        mstrCam = "Cam" + strCam.ToUpper();
                        mCamParas = mXMLStruct_new.CamD;
                        break;
                    case "L":
                    case "L_C":
                        mstrCam = "Cam" + strCam.ToUpper();
                        mCamParas = mXMLStruct_new.CamL;
                        break;
                    case "R":
                    case "R_C":
                        mstrCam = "Cam" + strCam.ToUpper();
                        mCamParas = mXMLStruct_new.CamR;
                        break;
                    case "F":
                    case "F_C":
                        mstrCam = "Cam" + strCam.ToUpper();
                        mCamParas = mXMLStruct_new.CamF;
                        break;
                    case "B":
                    case "B_C":
                        mstrCam = "Cam" + strCam.ToUpper();
                        mCamParas = mXMLStruct_new.CamB;
                        break;
                    default:
                        mstrCam = "";
                        break;
                }
                string XMLNodePath = "";
                if (mstrCam.Length > 4)
                {
                    //更新中心块
                    XMLNodePath = @"Cube/" + mstrCam.Substring(0, 4) + @"/ColorMatch/Centre/";
                }
                else
                {
                    XMLNodePath = @"Cube/" + mstrCam + @"/ColorMatch/";
                }
                switch (mFaceColor)
                {
                    case FaceColor.Red:
                        if (mstrCam.Length > 4)
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Red_c;
                        }
                        else
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Red;
                        }
                        XMLNodePath = XMLNodePath + @"Red/";
                        break;
                    case FaceColor.Green:
                        if (mstrCam.Length > 4)
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Green_c;
                        }
                        else
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Green;
                        }
                        XMLNodePath = XMLNodePath + @"Green/";
                        break;
                    case FaceColor.Blue:
                        if (mstrCam.Length > 4)
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Blue_c;
                        }
                        else
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Blue;
                        }
                        XMLNodePath = XMLNodePath + @"Blue/";
                        break;
                    case FaceColor.White:
                        if (mstrCam.Length > 4)
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_White_c;
                        }
                        else
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_White;
                        }
                        XMLNodePath = XMLNodePath + @"White/";
                        break;
                    case FaceColor.Orange:
                        if (mstrCam.Length > 4)
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Orange_c;
                        }
                        else
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Orange;
                        }
                        XMLNodePath = XMLNodePath + @"Orange/";
                        break;
                    case FaceColor.Yellow:
                        if (mstrCam.Length > 4)
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Yellow_c;
                        }
                        else
                        {
                            mRGB_MinMax = mCamParas.mColorMatch.c_Yellow;
                        }
                        XMLNodePath = XMLNodePath + @"Yellow/";
                        break;
                    default:
                        return false;                        
                }
                if (mstrCam.Length > 4)
                {
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"R_min", (mRGB_MinMax.R_min - (int)(nud_MinusTolerance.Value) * 2).ToString());
                    if (mRGB_MinMax.R_max + (int)(nud_PlusTolerance.Value) * 2<=255)
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"R_max", (mRGB_MinMax.R_max + (int)(nud_PlusTolerance.Value) * 2).ToString());

                    }
                    else
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"R_max", (255).ToString());
                    }
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"G_min", (mRGB_MinMax.G_min - (int)(nud_MinusTolerance.Value) * 2).ToString());
                    if (mRGB_MinMax.G_max + (int)(nud_PlusTolerance.Value) * 2<=255)
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"G_max", (mRGB_MinMax.G_max + (int)(nud_PlusTolerance.Value) * 2).ToString());

                    }
                    else
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"G_max", (255).ToString());
                    }
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"B_min", (mRGB_MinMax.B_min - (int)(nud_MinusTolerance.Value) * 2).ToString());
                    if (mRGB_MinMax.B_max + (int)(nud_PlusTolerance.Value) * 2<=255)
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"B_max", (mRGB_MinMax.B_max + (int)(nud_PlusTolerance.Value) * 2).ToString());

                    }
                    else
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"B_max", (255).ToString());
                    }
                    if (mFaceColor == FaceColor.White)
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"R_max", (255).ToString());
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"G_max", (255).ToString());
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"B_max", (255).ToString());
                    }
                }
                else
                {
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"R_min", (mRGB_MinMax.R_min - (int)(nud_MinusTolerance.Value)).ToString());
                    if (mRGB_MinMax.R_max + (int)(nud_PlusTolerance.Value)<=255)
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"R_max", (mRGB_MinMax.R_max + (int)(nud_PlusTolerance.Value)).ToString());

                    }
                    else
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"R_max", (255).ToString());
                    }
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"G_min", (mRGB_MinMax.G_min - (int)(nud_MinusTolerance.Value)).ToString());
                    if (mRGB_MinMax.G_max + (int)(nud_PlusTolerance.Value)<=255)
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"G_max", (mRGB_MinMax.G_max + (int)(nud_PlusTolerance.Value)).ToString());

                    }
                    else
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"G_max", (255).ToString());
                    }
                    GlobalVariables.SetXMLNodeValue(XMLNodePath + @"B_min", (mRGB_MinMax.B_min - (int)(nud_MinusTolerance.Value)).ToString());
                    if (mRGB_MinMax.B_max + (int)(nud_PlusTolerance.Value)<=255)
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"B_max", (mRGB_MinMax.B_max + (int)(nud_PlusTolerance.Value)).ToString());

                    }
                    else
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"B_max", (255).ToString());
                    }
                    if (mFaceColor == FaceColor.White)
                    {
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"R_max", (255).ToString());
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"G_max", (255).ToString());
                        GlobalVariables.SetXMLNodeValue(XMLNodePath + @"B_max", (255).ToString());
                    }
                }
                b_Success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return b_Success;
        }

        public bool UpdateParamsStep(int StepIndex)
        {
            bool b_Success = false;
            switch (StepIndex)
            {
                case 1:
                    //更新到临时变量
                    GetMinMax(CamID.CamL, FaceColor.Blue);
                    GetMinMax(CamID.CamR, FaceColor.Green);
                    GetMinMax(CamID.CamF, FaceColor.Orange);
                    GetMinMax(CamID.CamB, FaceColor.Red);
                    GetMinMax(CamID.CamU, FaceColor.White);
                    GetMinMax(CamID.CamD, FaceColor.Yellow);
                    //更新到XML
                    b_Success = UpdateParams("L", FaceColor.Blue)   && UpdateParams("L_c", FaceColor.Blue)
                             && UpdateParams("R", FaceColor.Green)  && UpdateParams("R_c", FaceColor.Green)
                             && UpdateParams("F", FaceColor.Orange) && UpdateParams("F_c", FaceColor.Orange)
                             && UpdateParams("B", FaceColor.Red)    && UpdateParams("B_c", FaceColor.Red)
                             && UpdateParams("U", FaceColor.White)  && UpdateParams("U_c", FaceColor.White)
                             && UpdateParams("D", FaceColor.Yellow) && UpdateParams("D_c", FaceColor.Yellow);
                    break;
                case 2:
                    GetMinMax(CamID.CamD, FaceColor.Blue);
                    GetMinMax(CamID.CamU, FaceColor.Green);
                    GetMinMax(CamID.CamR, FaceColor.Orange);
                    GetMinMax(CamID.CamL, FaceColor.Red);
                    GetMinMax(CamID.CamF, FaceColor.White);
                    GetMinMax(CamID.CamB, FaceColor.Yellow);
                    b_Success = UpdateParams("D", FaceColor.Blue)   && UpdateParams("D_c", FaceColor.Blue)
                             && UpdateParams("U", FaceColor.Green)  && UpdateParams("U_c", FaceColor.Green)
                             && UpdateParams("R", FaceColor.Orange) && UpdateParams("R_c", FaceColor.Orange)
                             && UpdateParams("L", FaceColor.Red)    && UpdateParams("L_c", FaceColor.Red)
                             && UpdateParams("F", FaceColor.White)  && UpdateParams("F_c", FaceColor.White)
                             && UpdateParams("B", FaceColor.Yellow) && UpdateParams("B_c", FaceColor.Yellow);
                    break;
                case 3:
                    GetMinMax(CamID.CamB, FaceColor.Blue);
                    GetMinMax(CamID.CamF, FaceColor.Green);
                    GetMinMax(CamID.CamU, FaceColor.Orange);
                    GetMinMax(CamID.CamD, FaceColor.Red);
                    GetMinMax(CamID.CamR, FaceColor.White);
                    GetMinMax(CamID.CamL, FaceColor.Yellow);
                    b_Success = UpdateParams("B", FaceColor.Blue)   && UpdateParams("B_c", FaceColor.Blue)
                             && UpdateParams("F", FaceColor.Green)  && UpdateParams("F_c", FaceColor.Green)
                             && UpdateParams("U", FaceColor.Orange) && UpdateParams("U_c", FaceColor.Orange)
                             && UpdateParams("D", FaceColor.Red)    && UpdateParams("D_c", FaceColor.Red)
                             && UpdateParams("R", FaceColor.White)  && UpdateParams("R_c", FaceColor.White)
                             && UpdateParams("L", FaceColor.Yellow) && UpdateParams("L_c", FaceColor.Yellow);
                    break;
                case 4:
                    GetMinMax(CamID.CamF, FaceColor.Blue);
                    GetMinMax(CamID.CamB, FaceColor.Green);
                    GetMinMax(CamID.CamL, FaceColor.Orange);
                    GetMinMax(CamID.CamR, FaceColor.Red);
                    GetMinMax(CamID.CamD, FaceColor.White);
                    GetMinMax(CamID.CamU, FaceColor.Yellow);
                    b_Success = UpdateParams("F", FaceColor.Blue)   && UpdateParams("F_c", FaceColor.Blue)
                             && UpdateParams("B", FaceColor.Green)  && UpdateParams("B_c", FaceColor.Green)
                             && UpdateParams("L", FaceColor.Orange) && UpdateParams("L_c", FaceColor.Orange)
                             && UpdateParams("R", FaceColor.Red)    && UpdateParams("R_c", FaceColor.Red)
                             && UpdateParams("D", FaceColor.White)  && UpdateParams("D_c", FaceColor.White)
                             && UpdateParams("U", FaceColor.Yellow) && UpdateParams("U_c", FaceColor.Yellow);
                    break;
                case 5:
                    GetMinMax(CamID.CamU, FaceColor.Blue);
                    GetMinMax(CamID.CamD, FaceColor.Green);
                    GetMinMax(CamID.CamB, FaceColor.Orange);
                    GetMinMax(CamID.CamF, FaceColor.Red);
                    GetMinMax(CamID.CamL, FaceColor.White);
                    GetMinMax(CamID.CamR, FaceColor.Yellow);
                    b_Success = UpdateParams("U", FaceColor.Blue)   && UpdateParams("U_c", FaceColor.Blue)
                             && UpdateParams("D", FaceColor.Green)  && UpdateParams("D_c", FaceColor.Green)
                             && UpdateParams("B", FaceColor.Orange) && UpdateParams("B_c", FaceColor.Orange)
                             && UpdateParams("F", FaceColor.Red)    && UpdateParams("F_c", FaceColor.Red)
                             && UpdateParams("L", FaceColor.White)  && UpdateParams("L_c", FaceColor.White)
                             && UpdateParams("R", FaceColor.Yellow) && UpdateParams("R_c", FaceColor.Yellow);
                    break;
                case 6:
                    GetMinMax(CamID.CamR, FaceColor.Blue);
                    GetMinMax(CamID.CamL, FaceColor.Green);
                    GetMinMax(CamID.CamD, FaceColor.Orange);
                    GetMinMax(CamID.CamU, FaceColor.Red);
                    GetMinMax(CamID.CamB, FaceColor.White);
                    GetMinMax(CamID.CamF, FaceColor.Yellow);
                    b_Success = UpdateParams("R", FaceColor.Blue)   && UpdateParams("R_c", FaceColor.Blue)
                             && UpdateParams("L", FaceColor.Green)  && UpdateParams("L_c", FaceColor.Green)
                             && UpdateParams("D", FaceColor.Orange) && UpdateParams("D_c", FaceColor.Orange)
                             && UpdateParams("U", FaceColor.Red)    && UpdateParams("U_c", FaceColor.Red)
                             && UpdateParams("B", FaceColor.White)  && UpdateParams("B_c", FaceColor.White)
                             && UpdateParams("F", FaceColor.Yellow) && UpdateParams("F_c", FaceColor.Yellow);
                    break;
                default:
                    break;
            }
            
            return b_Success;
        }

        public void ShowTabPageN(int TabPageIndex)
        {
            foreach (TabPage item in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(item);
            }
            switch (TabPageIndex)
            {
                case 1:
                    tabControl1.TabPages.Add(tabPage1);
                    break;
                case 2:
                    tabControl1.TabPages.Add(tabPage2);
                    break;
                case 3:
                    tabControl1.TabPages.Add(tabPage3);
                    break;
                case 4:
                    tabControl1.TabPages.Add(tabPage4);
                    break;
                case 5:
                    tabControl1.TabPages.Add(tabPage5);
                    break;
                case 6:
                    tabControl1.TabPages.Add(tabPage6);
                    break;
                default:
                    break;
            }
        }

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
            mBtn.Text = mBtn.BackColor.R.ToString() + "\n" + mBtn.BackColor.G.ToString() + "\n" + mBtn.BackColor.B.ToString();
        }


        public void OriginalColorDisplay()
        {
            OriginalColorDisplay(CamID.CamU, 1, Form1.GetRGBvalue(CamID.CamU, 9));
            OriginalColorDisplay(CamID.CamU, 2, Form1.GetRGBvalue(CamID.CamU, 8));
            OriginalColorDisplay(CamID.CamU, 3, Form1.GetRGBvalue(CamID.CamU, 7));
            OriginalColorDisplay(CamID.CamU, 4, Form1.GetRGBvalue(CamID.CamU, 6));
            OriginalColorDisplay(CamID.CamU, 5, Form1.GetRGBvalue(CamID.CamU, 5));
            OriginalColorDisplay(CamID.CamU, 6, Form1.GetRGBvalue(CamID.CamU, 4));
            OriginalColorDisplay(CamID.CamU, 7, Form1.GetRGBvalue(CamID.CamU, 3));
            OriginalColorDisplay(CamID.CamU, 8, Form1.GetRGBvalue(CamID.CamU, 2));
            OriginalColorDisplay(CamID.CamU, 9, Form1.GetRGBvalue(CamID.CamU, 1));

            OriginalColorDisplay(CamID.CamD, 1, Form1.GetRGBvalue(CamID.CamD, 1));
            OriginalColorDisplay(CamID.CamD, 2, Form1.GetRGBvalue(CamID.CamD, 2));
            OriginalColorDisplay(CamID.CamD, 3, Form1.GetRGBvalue(CamID.CamD, 3));
            OriginalColorDisplay(CamID.CamD, 4, Form1.GetRGBvalue(CamID.CamD, 4));
            OriginalColorDisplay(CamID.CamD, 5, Form1.GetRGBvalue(CamID.CamD, 5));
            OriginalColorDisplay(CamID.CamD, 6, Form1.GetRGBvalue(CamID.CamD, 6));
            OriginalColorDisplay(CamID.CamD, 7, Form1.GetRGBvalue(CamID.CamD, 7));
            OriginalColorDisplay(CamID.CamD, 8, Form1.GetRGBvalue(CamID.CamD, 8));
            OriginalColorDisplay(CamID.CamD, 9, Form1.GetRGBvalue(CamID.CamD, 9));

            OriginalColorDisplay(CamID.CamL, 1, Form1.GetRGBvalue(CamID.CamL, 1));
            OriginalColorDisplay(CamID.CamL, 2, Form1.GetRGBvalue(CamID.CamL, 2));
            OriginalColorDisplay(CamID.CamL, 3, Form1.GetRGBvalue(CamID.CamL, 3));
            OriginalColorDisplay(CamID.CamL, 4, Form1.GetRGBvalue(CamID.CamL, 4));
            OriginalColorDisplay(CamID.CamL, 5, Form1.GetRGBvalue(CamID.CamL, 5));
            OriginalColorDisplay(CamID.CamL, 6, Form1.GetRGBvalue(CamID.CamL, 6));
            OriginalColorDisplay(CamID.CamL, 7, Form1.GetRGBvalue(CamID.CamL, 7));
            OriginalColorDisplay(CamID.CamL, 8, Form1.GetRGBvalue(CamID.CamL, 8));
            OriginalColorDisplay(CamID.CamL, 9, Form1.GetRGBvalue(CamID.CamL, 9));

            OriginalColorDisplay(CamID.CamR, 1, Form1.GetRGBvalue(CamID.CamR, 1));
            OriginalColorDisplay(CamID.CamR, 2, Form1.GetRGBvalue(CamID.CamR, 2));
            OriginalColorDisplay(CamID.CamR, 3, Form1.GetRGBvalue(CamID.CamR, 3));
            OriginalColorDisplay(CamID.CamR, 4, Form1.GetRGBvalue(CamID.CamR, 4));
            OriginalColorDisplay(CamID.CamR, 5, Form1.GetRGBvalue(CamID.CamR, 5));
            OriginalColorDisplay(CamID.CamR, 6, Form1.GetRGBvalue(CamID.CamR, 6));
            OriginalColorDisplay(CamID.CamR, 7, Form1.GetRGBvalue(CamID.CamR, 7));
            OriginalColorDisplay(CamID.CamR, 8, Form1.GetRGBvalue(CamID.CamR, 8));
            OriginalColorDisplay(CamID.CamR, 9, Form1.GetRGBvalue(CamID.CamR, 9));

            OriginalColorDisplay(CamID.CamF, 1, Form1.GetRGBvalue(CamID.CamF, 1));
            OriginalColorDisplay(CamID.CamF, 2, Form1.GetRGBvalue(CamID.CamF, 2));
            OriginalColorDisplay(CamID.CamF, 3, Form1.GetRGBvalue(CamID.CamF, 3));
            OriginalColorDisplay(CamID.CamF, 4, Form1.GetRGBvalue(CamID.CamF, 4));
            OriginalColorDisplay(CamID.CamF, 5, Form1.GetRGBvalue(CamID.CamF, 5));
            OriginalColorDisplay(CamID.CamF, 6, Form1.GetRGBvalue(CamID.CamF, 6));
            OriginalColorDisplay(CamID.CamF, 7, Form1.GetRGBvalue(CamID.CamF, 7));
            OriginalColorDisplay(CamID.CamF, 8, Form1.GetRGBvalue(CamID.CamF, 8));
            OriginalColorDisplay(CamID.CamF, 9, Form1.GetRGBvalue(CamID.CamF, 9));

            OriginalColorDisplay(CamID.CamB, 1, Form1.GetRGBvalue(CamID.CamB, 1));
            OriginalColorDisplay(CamID.CamB, 2, Form1.GetRGBvalue(CamID.CamB, 2));
            OriginalColorDisplay(CamID.CamB, 3, Form1.GetRGBvalue(CamID.CamB, 3));
            OriginalColorDisplay(CamID.CamB, 4, Form1.GetRGBvalue(CamID.CamB, 4));
            OriginalColorDisplay(CamID.CamB, 5, Form1.GetRGBvalue(CamID.CamB, 5));
            OriginalColorDisplay(CamID.CamB, 6, Form1.GetRGBvalue(CamID.CamB, 6));
            OriginalColorDisplay(CamID.CamB, 7, Form1.GetRGBvalue(CamID.CamB, 7));
            OriginalColorDisplay(CamID.CamB, 8, Form1.GetRGBvalue(CamID.CamB, 8));
            OriginalColorDisplay(CamID.CamB, 9, Form1.GetRGBvalue(CamID.CamB, 9));
        }

        public void Auto2_P_Start()
        {
            mForm_Manual.btn_2_P_Start_Click(null, null);
            switch (StepIndex_Cur)
            {
                case 0:
                    StepIndex_Cur = 1;
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 1:
                    StepIndex_Cur = 2;
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 2:
                    StepIndex_Cur = 3;
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 3:
                    StepIndex_Cur = 4;
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 4:
                    StepIndex_Cur = 5;
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 5:
                    StepIndex_Cur = 6;
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 6:
                    textBox1.AppendText("开班示教完成~\r\n");
                    break;
                default:
                    break;
            }
        }
        private void Form_AutoColorLearning_Load(object sender, EventArgs e)
        {
            File.Copy(GlobalVariables.ProjectPath + "Cube.xml",
                GlobalVariables.ProjectPath + "Cube_" + DateTime.Now.ToString("MMddHHmmss") + ".xml");
            StepIndex_Cur = 0;
            Form_Manual.updateAxisStatus();
            textBox1.Text = "";
            if (Form_Manual.b_P_Start)
            {               
                textBox1.AppendText("步序1：\r\n");
                StepIndex_Cur = 1;
                ShowTabPageN(1);
                textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
            }
            else
            {
                textBox1.AppendText("确认OK后，点击“回初始位”\r\n");
            }
        }

        private void btn_Acquire_Click(object sender, EventArgs e)
        {
            Form1.CamTrigger(CamID.CamU);
            Form1.CamTrigger(CamID.CamD);
            Form1.CamTrigger(CamID.CamL);
            Form1.CamTrigger(CamID.CamR);
            Form1.CamTrigger(CamID.CamF);
            Form1.CamTrigger(CamID.CamB);

            //Form1.CamTrigger(CamID.CamU);
            //Form1.CamTrigger(CamID.CamD);
            //Form1.CamTrigger(CamID.CamL);
            //Form1.CamTrigger(CamID.CamR);
            //Form1.CamTrigger(CamID.CamF);
            //Form1.CamTrigger(CamID.CamB);

            Form1.CamTrigger(CamID.CamU);
            Form1.CamTrigger(CamID.CamD);
            Form1.CamTrigger(CamID.CamL);
            Form1.CamTrigger(CamID.CamR);
            Form1.CamTrigger(CamID.CamF);
            Form1.CamTrigger(CamID.CamB);

            OriginalColorDisplay();
        }

        private void btn_UpdateParams_Click(object sender, EventArgs e)
        {
            if (UpdateParamsStep(StepIndex_Cur))
            {
                switch (StepIndex_Cur)
                {
                    case 1:
                        Step1_Updated = true;
                        break;
                    case 2:
                        Step2_Updated = true;
                        break;
                    case 3:
                        Step3_Updated = true;
                        break;
                    case 4:
                        Step4_Updated = true;
                        break;
                    case 5:
                        Step5_Updated = true;
                        break;
                    case 6:
                        Step6_Updated = true;
                        break;
                    default:
                        break;
                }
                textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "参数写入 成功!\r\n");
                btn_2_P_Start_Click(sender, e);
                //MessageBox.Show(StepIndex_Cur.ToString() + "更新成功!");
            }
            
        }

        private void btn_2_P_Start_Click(object sender, EventArgs e)
        {
            mForm_Manual.btn_2_P_Start_Click(sender, e);
            switch (StepIndex_Cur)
            {
                case 0:
                    StepIndex_Cur = 1;
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 1:
                    if (Step1_Updated)
                    {
                        StepIndex_Cur = 2;
                        
                    }
                    else
                    {

                    }
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 2:
                    if (Step2_Updated)
                    {
                        StepIndex_Cur = 3;
                        
                    }
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 3:
                    if (Step3_Updated)
                    {
                        StepIndex_Cur = 4;
                    }
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 4:
                    if (Step4_Updated)
                    {
                        StepIndex_Cur = 5;
                    }
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 5:
                    if (Step5_Updated)
                    {
                        StepIndex_Cur = 6;
                    }
                    textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                    ShowTabPageN(StepIndex_Cur);
                    textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    break;
                case 6:
                    if (Step6_Updated)
                    {
                        textBox1.AppendText("开班示教完成~\r\n");
                    }
                    else
                    {
                        textBox1.AppendText("步序" + StepIndex_Cur.ToString() + "：\r\n");
                        ShowTabPageN(StepIndex_Cur);
                        textBox1.AppendText("按上图图示放入魔方后，点击“启动”\r\n");
                    }
                    break;
                default:
                    break;
            }
            
        }

        private void btn_2_P_Acquire_Click(object sender, EventArgs e)
        {
            mForm_Manual.btn_2_P_Acquire_Click(sender, e);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            mForm_Manual.btn_2_P_Acquire_Click(sender, e);
            btn_Acquire_Click(sender, e);
            this.Update();
            if (MessageBox.Show("确认更新？", "参数恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btn_UpdateParams_Click(sender, e);
            }
            else
            {
                textBox1.AppendText("请确认图像后，点击“更新参数”\r\n");
            }
        }
    }
}

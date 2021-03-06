﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml;
using System.Reflection;

namespace Festo_Rubik_s_Cube_Explorer
{
    class GlobalVariables
    {
        public static string ProjectPath = "";
        public static XMLStruct CurrentParas;
        public static double positionTolerance;
        public static double global_Vel;
        public static double global_Acc;
        public static double global_Dec;
        public static double global_Jerk;
        public static double global_Vel_Rotate;
        public static double global_Acc_Rotate;
        public static double global_Dec_Rotate;
        public static double global_Jerk_Rotate;
        public static double CWgap;
        public static double CCWgap;
        public static ServoStatus servo_Feeding;
        public static IOlinkStatus IOlink_Rotate;
        public static ServoStatus servo_U_Move;
        public static ServoStatus servo_U_Grab;
        public static ServoStatus servo_U_Rotate;
        public static IOlinkStatus IOlink_F_Move_Cam;
        public static IOlinkStatus IOlink_F_Grab;
        public static ServoStatus servo_F_Rotate;
        public static IOlinkStatus IOlink_B_Move_Cam;
        public static IOlinkStatus IOlink_B_Grab;
        public static ServoStatus servo_B_Rotate;
        public static IOlinkStatus IOlink_L_Move_Cam;
        public static IOlinkStatus IOlink_L_Grab;
        public static ServoStatus servo_L_Rotate;
        public static IOlinkStatus IOlink_R_Move_Cam;
        public static IOlinkStatus IOlink_R_Grab;
        public static ServoStatus servo_R_Rotate;
        public static ServoStatus servo_D_Move;
        public static IOlinkStatus IOlink_D_Move_Cam;
        public static ServoStatus servo_D_Grab;
        public static ServoStatus servo_D_Rotate;
        public static LightStatus lightStatus;

        public static string LoadParasFromXML()
        {
            string str_CheckXML = XMLCheckResult.OK.ToString();
            XmlDocument xmldoc; //XML文档操作句柄
            XmlNode xmlnode;
            XmlElement xmlelem; //根元素
            string strFilename; //xmldoc.Load(strFilename)
            try
            {
                xmldoc = new XmlDocument();
                strFilename = GlobalVariables.ProjectPath + "Cube.xml";

                try
                {
                    xmldoc.Load(strFilename);

                }
                catch (Exception ex)
                {
                    //Log_ex(ex, EnumService.GetDescription(XMLCheckResult.NoXML));
                    return XMLCheckResult.NoXML.ToString();
                }
                CurrentParas = new XMLStruct();

                xmlelem = xmldoc.DocumentElement;
                #region CamU
                xmlnode = xmlelem.SelectSingleNode("CamU");
                if (xmlnode != null)
                {
                    CurrentParas.CamU.str_IP = xmlnode.Attributes["IP"].Value;
                    XmlNode ColorMatchNode = xmlnode.SelectSingleNode("ColorMatch");
                    if (ColorMatchNode != null)
                    {
                        XmlNode xmlnode_Color = ColorMatchNode.SelectSingleNode("Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Red.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Green.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Blue.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_White.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Orange.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Yellow.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        #region 中心块参数单设
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Red_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Red_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Green_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Green_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Blue_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Blue_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_White_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_White_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Orange_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Orange_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamU.mColorMatch.c_Yellow_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamU.mColorMatch.c_Yellow_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamU.ToString();
                        } 
                        #endregion
                    }
                    else
                    {
                        return XMLCheckResult.ErrorCamU.ToString();
                    }
                }
                else
                {
                    return XMLCheckResult.ErrorCamU.ToString();
                }
                #endregion
                #region CamD
                xmlnode = xmlelem.SelectSingleNode("CamD");
                if (xmlnode != null)
                {
                    CurrentParas.CamD.str_IP = xmlnode.Attributes["IP"].Value;
                    XmlNode ColorMatchNode = xmlnode.SelectSingleNode("ColorMatch");
                    if (ColorMatchNode != null)
                    {
                        XmlNode xmlnode_Color = ColorMatchNode.SelectSingleNode("Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Red.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Green.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Blue.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_White.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Orange.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Yellow.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        #region 中心块参数单设
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Red_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Red_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Green_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Green_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Blue_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Blue_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_White_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_White_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Orange_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Orange_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamD.mColorMatch.c_Yellow_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamD.mColorMatch.c_Yellow_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamD.ToString();
                        }
                        #endregion

                    }
                    else
                    {
                        return XMLCheckResult.ErrorCamD.ToString();
                    }
                }
                else
                {
                    return XMLCheckResult.ErrorCamD.ToString();
                }
                #endregion
                #region CamL
                xmlnode = xmlelem.SelectSingleNode("CamL");
                if (xmlnode != null)
                {
                    CurrentParas.CamL.str_IP = xmlnode.Attributes["IP"].Value;
                    XmlNode ColorMatchNode = xmlnode.SelectSingleNode("ColorMatch");
                    if (ColorMatchNode != null)
                    {
                        XmlNode xmlnode_Color = ColorMatchNode.SelectSingleNode("Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Red.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Green.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Blue.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_White.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Orange.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Yellow.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        #region 中心块参数单设
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Red_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Red_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Green_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Green_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Blue_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Blue_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_White_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_White_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Orange_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Orange_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamL.mColorMatch.c_Yellow_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamL.mColorMatch.c_Yellow_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamL.ToString();
                        }
                        #endregion

                    }
                    else
                    {
                        return XMLCheckResult.ErrorCamL.ToString();
                    }
                }
                else
                {
                    return XMLCheckResult.ErrorCamL.ToString();
                }
                #endregion
                #region CamR
                xmlnode = xmlelem.SelectSingleNode("CamR");
                if (xmlnode != null)
                {
                    CurrentParas.CamR.str_IP = xmlnode.Attributes["IP"].Value;
                    XmlNode ColorMatchNode = xmlnode.SelectSingleNode("ColorMatch");
                    if (ColorMatchNode != null)
                    {
                        XmlNode xmlnode_Color = ColorMatchNode.SelectSingleNode("Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Red.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Green.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Blue.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_White.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Orange.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Yellow.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        #region 中心块参数单设
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Red_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Red_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Green_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Green_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Blue_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Blue_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_White_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_White_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Orange_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Orange_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamR.mColorMatch.c_Yellow_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamR.mColorMatch.c_Yellow_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamR.ToString();
                        }
                        #endregion

                    }
                    else
                    {
                        return XMLCheckResult.ErrorCamR.ToString();
                    }
                }
                else
                {
                    return XMLCheckResult.ErrorCamR.ToString();
                }
                #endregion
                #region CamF
                xmlnode = xmlelem.SelectSingleNode("CamF");
                if (xmlnode != null)
                {
                    CurrentParas.CamF.str_IP = xmlnode.Attributes["IP"].Value;
                    XmlNode ColorMatchNode = xmlnode.SelectSingleNode("ColorMatch");
                    if (ColorMatchNode != null)
                    {
                        XmlNode xmlnode_Color = ColorMatchNode.SelectSingleNode("Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Red.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Green.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Blue.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_White.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Orange.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Yellow.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        #region 中心块参数单设
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Red_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Red_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Green_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Green_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Blue_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Blue_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_White_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_White_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Orange_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Orange_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamF.mColorMatch.c_Yellow_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamF.mColorMatch.c_Yellow_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamF.ToString();
                        }
                        #endregion

                    }
                    else
                    {
                        return XMLCheckResult.ErrorCamF.ToString();
                    }
                }
                else
                {
                    return XMLCheckResult.ErrorCamF.ToString();
                }
                #endregion
                #region CamB
                xmlnode = xmlelem.SelectSingleNode("CamB");
                if (xmlnode != null)
                {
                    CurrentParas.CamB.str_IP = xmlnode.Attributes["IP"].Value;
                    XmlNode ColorMatchNode = xmlnode.SelectSingleNode("ColorMatch");
                    if (ColorMatchNode != null)
                    {
                        XmlNode xmlnode_Color = ColorMatchNode.SelectSingleNode("Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Red.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Green.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Blue.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_White.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Orange.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode("Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Yellow.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        #region 中心块参数单设
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Red");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Red_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Red_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Green");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Green_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Green_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Blue");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Blue_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Blue_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/White");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_White_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_White_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Orange");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Orange_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Orange_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        xmlnode_Color = ColorMatchNode.SelectSingleNode(@"Centre/Yellow");
                        if (xmlnode_Color != null)
                        {
                            CurrentParas.CamB.mColorMatch.c_Yellow_c.R_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow_c.R_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("R_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow_c.G_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow_c.G_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("G_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow_c.B_min = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_min").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                            CurrentParas.CamB.mColorMatch.c_Yellow_c.B_max = Convert.ToInt16(xmlnode_Color.SelectSingleNode("B_max").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        }
                        else
                        {
                            return XMLCheckResult.ErrorCamB.ToString();
                        }
                        #endregion

                    }
                    else
                    {
                        return XMLCheckResult.ErrorCamB.ToString();
                    }
                }
                else
                {
                    return XMLCheckResult.ErrorCamB.ToString();
                }
                #endregion
                #region PLC
                xmlnode = xmlelem.SelectSingleNode("PLC");
                if (xmlnode != null)
                {
                    CurrentParas.mPLC.str_IP = xmlnode.Attributes["IP"].Value;
                    positionTolerance = Convert.ToDouble(xmlnode.SelectSingleNode("positionTolerance").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    global_Vel = Convert.ToDouble(xmlnode.SelectSingleNode("Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    global_Acc = Convert.ToDouble(xmlnode.SelectSingleNode("Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    global_Dec = Convert.ToDouble(xmlnode.SelectSingleNode("Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    global_Jerk = Convert.ToDouble(xmlnode.SelectSingleNode("Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    global_Vel_Rotate = Convert.ToDouble(xmlnode.SelectSingleNode("Vel_Rotate").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    global_Acc_Rotate = Convert.ToDouble(xmlnode.SelectSingleNode("Acc_Rotate").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    global_Dec_Rotate = Convert.ToDouble(xmlnode.SelectSingleNode("Dec_Rotate").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    global_Jerk_Rotate = Convert.ToDouble(xmlnode.SelectSingleNode("Jerk_Rotate").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    CWgap = Convert.ToDouble(xmlnode.SelectSingleNode("CWgap").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    CCWgap = Convert.ToDouble(xmlnode.SelectSingleNode("CCWgap").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    #region 1-Feeding
                    XmlNode ServoNode = xmlnode.SelectSingleNode("Feeding");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_Feeding.ID = ServoNode.Name;
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_Feeding.P1 = Convert.ToDouble(ServoNode.SelectSingleNode("P1").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        CurrentParas.mPLC.servo_Feeding.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 2-Rotate
                    ServoNode = xmlnode.SelectSingleNode("Rotate");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_Rotate.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_Rotate.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_Rotate.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_Rotate.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_Rotate.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_Rotate.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_Rotate.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");                       
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 3-U_Move
                    ServoNode = xmlnode.SelectSingleNode("U_Move");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Move.P1 = Convert.ToDouble(ServoNode.SelectSingleNode("P_1").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        CurrentParas.mPLC.servo_U_Move.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P_2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 4-U_Grab
                    ServoNode = xmlnode.SelectSingleNode("U_Grab");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Grab.P1 = Convert.ToDouble(ServoNode.SelectSingleNode("P_1").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        CurrentParas.mPLC.servo_U_Grab.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P_2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        CurrentParas.mPLC.servo_U_Grab.P3 = Convert.ToDouble(ServoNode.SelectSingleNode("P_3").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 5-U_Rotate
                    ServoNode = xmlnode.SelectSingleNode("U_Rotate");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_U_Rotate.P_0 = Convert.ToDouble(ServoNode.SelectSingleNode("P_0").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 6-F_Move_Cam
                    ServoNode = xmlnode.SelectSingleNode("F_Move_Cam");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Move_Cam.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");                       
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 7-F_Grab
                    ServoNode = xmlnode.SelectSingleNode("F_Grab");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Grab.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_F_Grab.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 8-F_Rotate
                    ServoNode = xmlnode.SelectSingleNode("F_Rotate");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_F_Rotate.P_0 = Convert.ToDouble(ServoNode.SelectSingleNode("P_0").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        //CurrentParas.mPLC.servo_F_Rotate.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 9-B_Move_Cam
                    ServoNode = xmlnode.SelectSingleNode("B_Move_Cam");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Move_Cam.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                      
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 10-B_Grab
                    ServoNode = xmlnode.SelectSingleNode("B_Grab");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Grab.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_B_Grab.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                       
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 11-B_Rotate
                    ServoNode = xmlnode.SelectSingleNode("B_Rotate");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_B_Rotate.P_0 = Convert.ToDouble(ServoNode.SelectSingleNode("P_0").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        //CurrentParas.mPLC.servo_B_Rotate.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 12-L_Move_Cam
                    ServoNode = xmlnode.SelectSingleNode("L_Move_Cam");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Move_Cam.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 13-L_Grab
                    ServoNode = xmlnode.SelectSingleNode("L_Grab");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Grab.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_L_Grab.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 14-L_Rotate
                    ServoNode = xmlnode.SelectSingleNode("L_Rotate");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_L_Rotate.P_0 = Convert.ToDouble(ServoNode.SelectSingleNode("P_0").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        //CurrentParas.mPLC.servo_L_Rotate.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 15-R_Move_Cam
                    ServoNode = xmlnode.SelectSingleNode("R_Move_Cam");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Move_Cam.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 16-R_Grab
                    ServoNode = xmlnode.SelectSingleNode("R_Grab");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Grab.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_R_Grab.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 17-R_Rotate
                    ServoNode = xmlnode.SelectSingleNode("R_Rotate");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_R_Rotate.P_0 = Convert.ToDouble(ServoNode.SelectSingleNode("P_0").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        //CurrentParas.mPLC.servo_R_Rotate.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 18-D_Move
                    ServoNode = xmlnode.SelectSingleNode("D_Move");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Move.P1 = Convert.ToDouble(ServoNode.SelectSingleNode("P_1").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        CurrentParas.mPLC.servo_D_Move.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P_2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 19-D_Move_Cam
                    ServoNode = xmlnode.SelectSingleNode("D_Move_Cam");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_In = ServoNode.SelectSingleNode("i_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Out = ServoNode.SelectSingleNode("i_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Move = ServoNode.SelectSingleNode("i_Move").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_i_Device = ServoNode.SelectSingleNode("i_Device").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_In = ServoNode.SelectSingleNode("o_In").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_Out = ServoNode.SelectSingleNode("o_Out").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.IOlink_D_Move_Cam.NodeID_o_QuitError = ServoNode.SelectSingleNode("o_QuitError").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 20-D_Grab
                    ServoNode = xmlnode.SelectSingleNode("D_Grab");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Grab.P1 = Convert.ToDouble(ServoNode.SelectSingleNode("P_1").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        CurrentParas.mPLC.servo_D_Grab.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P_2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        CurrentParas.mPLC.servo_D_Grab.P3 = Convert.ToDouble(ServoNode.SelectSingleNode("P_3").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region 21-D_Rotate
                    ServoNode = xmlnode.SelectSingleNode("D_Rotate");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_Enable = ServoNode.SelectSingleNode("i_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_Error = ServoNode.SelectSingleNode("i_Error").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_ErrorID = ServoNode.SelectSingleNode("i_ErrorID").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_Home = ServoNode.SelectSingleNode("i_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_MC = ServoNode.SelectSingleNode("i_MC").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_i_ActPos = ServoNode.SelectSingleNode("i_ActPos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Enable = ServoNode.SelectSingleNode("o_Enable").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Reset = ServoNode.SelectSingleNode("o_Reset").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Home = ServoNode.SelectSingleNode("o_Home").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_JogPositive = ServoNode.SelectSingleNode("o_JogPositive").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_JogNegative = ServoNode.SelectSingleNode("o_JogNegative").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Vel = ServoNode.SelectSingleNode("o_Vel").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Acc = ServoNode.SelectSingleNode("o_Acc").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Dec = ServoNode.SelectSingleNode("o_Dec").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Jerk = ServoNode.SelectSingleNode("o_Jerk").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Pos = ServoNode.SelectSingleNode("o_Pos").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.mServoNodeID.NodeID_o_Go = ServoNode.SelectSingleNode("o_Go").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.servo_D_Rotate.P_0 = Convert.ToDouble(ServoNode.SelectSingleNode("P_0").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                        //CurrentParas.mPLC.servo_D_Rotate.P2 = Convert.ToDouble(ServoNode.SelectSingleNode("P_2").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", ""));
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region LightControl
                    ServoNode = xmlnode.SelectSingleNode("LightControl");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.LightControl.NodeID_U = ServoNode.SelectSingleNode("U").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.LightControl.NodeID_D = ServoNode.SelectSingleNode("D").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.LightControl.NodeID_L = ServoNode.SelectSingleNode("L").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.LightControl.NodeID_R = ServoNode.SelectSingleNode("R").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.LightControl.NodeID_F = ServoNode.SelectSingleNode("F").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.LightControl.NodeID_B = ServoNode.SelectSingleNode("B").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion
                    #region CamControl
                    ServoNode = xmlnode.SelectSingleNode("CamControl");
                    if (ServoNode != null)
                    {
                        CurrentParas.mPLC.CamControl.NodeID_U = ServoNode.SelectSingleNode("U").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.CamControl.NodeID_D = ServoNode.SelectSingleNode("D").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.CamControl.NodeID_L = ServoNode.SelectSingleNode("L").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.CamControl.NodeID_R = ServoNode.SelectSingleNode("R").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.CamControl.NodeID_F = ServoNode.SelectSingleNode("F").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        CurrentParas.mPLC.CamControl.NodeID_B = ServoNode.SelectSingleNode("B").InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                    }
                    else
                    {
                        return XMLCheckResult.ErrorPLC.ToString();
                    }
                    #endregion


                }
                else
                {
                    return XMLCheckResult.ErrorPLC.ToString();
                }
                #endregion
            }
            catch (Exception ex)
            {
                //Log_ex(ex, EnumService.GetDescription(XMLCheckResult.Other));
                return XMLCheckResult.Other.ToString();
            }
            return str_CheckXML;
        }

        public static void SetXMLNodeValue(string XMLNodePath,string value)
        {
            XmlDocument xmldoc; //XML文档操作句柄
            XmlNode xmlnode;
            xmldoc = new XmlDocument();
            string strFilename = GlobalVariables.ProjectPath + "Cube.xml";
            try
            {
                xmldoc.Load(strFilename);               
                xmlnode = xmldoc.SelectSingleNode(XMLNodePath);
                xmlnode.InnerText = value;
                xmldoc.Save(GlobalVariables.ProjectPath + "Cube.xml");
            }
            catch (Exception ex)
            {
               
            }
        }
    }

    #region XML中的参数
    //写在XML中的参数
    public struct XMLStruct
    {
        public CamParas CamU;
        public CamParas CamD;
        public CamParas CamL;
        public CamParas CamR;
        public CamParas CamF;
        public CamParas CamB;
        public PLCParas mPLC;
    }
    public struct RGB_MinMax
    {
        public int R_min;
        public int R_max;
        public int G_min;
        public int G_max;
        public int B_min;
        public int B_max;
    }
    public struct ColorMatch
    {
        public RGB_MinMax c_Red;
        public RGB_MinMax c_Green;
        public RGB_MinMax c_Blue;
        public RGB_MinMax c_White;
        public RGB_MinMax c_Orange;
        public RGB_MinMax c_Yellow;

        public RGB_MinMax c_Red_c;
        public RGB_MinMax c_Green_c;
        public RGB_MinMax c_Blue_c;
        public RGB_MinMax c_White_c;
        public RGB_MinMax c_Orange_c;
        public RGB_MinMax c_Yellow_c;
    }
    public struct CamParas
    {
        public string str_IP;
        public ColorMatch mColorMatch;
    }
    public struct PLCParas
    {
        public string str_IP;
        public ServoParas servo_Feeding;
        public IOlinkNodeID IOlink_Rotate;
        public ServoParas servo_U_Move;
        public ServoParas servo_U_Grab;
        public ServoParas servo_U_Rotate;
        public IOlinkNodeID IOlink_F_Move_Cam;
        public IOlinkNodeID IOlink_F_Grab;
        public ServoParas servo_F_Rotate;
        public IOlinkNodeID IOlink_B_Move_Cam;
        public IOlinkNodeID IOlink_B_Grab;
        public ServoParas servo_B_Rotate;
        public IOlinkNodeID IOlink_L_Move_Cam;
        public IOlinkNodeID IOlink_L_Grab;
        public ServoParas servo_L_Rotate;
        public IOlinkNodeID IOlink_R_Move_Cam;
        public IOlinkNodeID IOlink_R_Grab;
        public ServoParas servo_R_Rotate;
        public ServoParas servo_D_Move;
        public IOlinkNodeID IOlink_D_Move_Cam;
        public ServoParas servo_D_Grab;
        public ServoParas servo_D_Rotate;
        public CubeResultNodeID CubeResult;
        public LightControlNodeID LightControl;
        public CamControlNodeID CamControl;
    }

    //PC写给PLC的参数
    public struct CubeResultNodeID
    {
        public string NodeID_Step1;
        public string NodeID_Step2;
        public string NodeID_Step3;
        public string NodeID_Step4;
        public string NodeID_Step5;
        public string NodeID_Step6;
        public string NodeID_Step7;
        public string NodeID_Step8;
        public string NodeID_Step9;
        public string NodeID_Step10;
        public string NodeID_Step11;
        public string NodeID_Step12;
        public string NodeID_Step13;
        public string NodeID_Step14;
        public string NodeID_Step15;
        public string NodeID_Step16;
        public string NodeID_Step17;
        public string NodeID_Step18;
        public string NodeID_Step19;
        public string NodeID_Step20;
        public string NodeID_Step21;
    }

    public struct LightControlNodeID
    {
        public string NodeID_U;
        public string NodeID_D;
        public string NodeID_L;
        public string NodeID_R;
        public string NodeID_F;
        public string NodeID_B;        
    }
    public struct CamControlNodeID
    {
        public string NodeID_U;
        public string NodeID_D;
        public string NodeID_L;
        public string NodeID_R;
        public string NodeID_F;
        public string NodeID_B;
    }

    public struct ServoParas
    {
        public string ID;
        public ServoNodeID mServoNodeID;//变量在PLC中的节点名
        public double P1;
        public double P2;
        public double P3;
        public double P_0;
        public double P_90;
        public double P_180;
        public double P_270;
    }
    public struct ServoNodeID
    {
        public string NodeID_i_Enable;
        public string NodeID_i_Error;
        public string NodeID_i_ErrorID;
        public string NodeID_i_Home;
        public string NodeID_i_MC;
        public string NodeID_i_ActPos;
        public string NodeID_o_Enable;
        public string NodeID_o_Reset;
        public string NodeID_o_Home;
        public string NodeID_o_JogPositive;
        public string NodeID_o_JogNegative;
        public string NodeID_o_Vel;
        public string NodeID_o_Acc;
        public string NodeID_o_Dec;
        public string NodeID_o_Jerk;
        public string NodeID_o_Pos;
        public string NodeID_o_Go;
    }
    public struct IOlinkNodeID
    {
        public string ID;
        public string NodeID_i_In;
        public string NodeID_i_Out;
        public string NodeID_i_Move;
        public string NodeID_i_Device;
        public string NodeID_o_In;
        public string NodeID_o_Out;
        public string NodeID_o_QuitError;
    } 
    #endregion
    public struct ServoStatus
    {
        public bool i_Enable;
        public bool i_Error;
        public string i_ErrorID;
        public bool i_Home;
        public bool i_MC;
        public double i_ActPos;
        public bool o_Enable;
        public bool o_Reset;
        public bool o_Home;
        public bool o_JogPositive;
        public bool o_JogNegative;
        public double o_Vel;
        public double o_Acc;
        public double o_Dec;
        public double o_Jerk;
        public double o_Pos;
        public bool o_Go;
        public bool b_P1;
        public bool b_P2;
        public bool b_P3;
        public bool b_P_90;
        public bool b_P_180;
        public bool b_P_270;
    }
    public struct IOlinkStatus
    {
        public bool i_In;
        public bool i_Out;
        public bool i_Move;
        public bool i_Device;
        public bool o_In;
        public bool o_Out;
        public bool o_QuitError;
    }
    public struct LightStatus
    {
        public bool o_U;
        public bool o_D;
        public bool o_L;
        public bool o_R;
        public bool o_F;
        public bool o_B;
    }


    public enum CamID
    {
        CamU = 1,
        CamD = 2,
        CamL = 3,
        CamR = 4,
        CamF = 5,
        CamB = 6
    }

    public enum FaceColor
    {
        Black = 0,
        Red = 1,
        Green = 2,
        Blue = 3,
        White = 4,
        Orange = 5,
        Yellow = 6
    }

    public enum XMLCheckResult
    {
        [Description("设置完整")]
        OK = 0,

        [Description("上方相机参数异常")]
        ErrorCamU = 1,       
                                 
        [Description("下方相机参数异常")]
        ErrorCamD = 2,     
                                  
        [Description("左侧相机参数异常")]
        ErrorCamL = 3,     
                                  
        [Description("右侧相机参数异常")]
        ErrorCamR = 4,     
                                  
        [Description("前侧相机参数异常")]
        ErrorCamF = 5,     
                                  
        [Description("后侧相机参数异常")]
        ErrorCamB = 6,        

        [Description("PLC参数异常")]
        ErrorPLC = 7,

        [Description("XML配置文档不存在或格式有误")]
        NoXML = 8,

        [Description("未知异常")]
        Other = 10,
    }

    public class EnumService
    {
        public static string GetDescription(Enum obj)
        {
            string objName = obj.ToString();
            Type t = obj.GetType();
            FieldInfo fi = t.GetField(objName);
            DescriptionAttribute[] arrDesc = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return arrDesc[0].Description;
        }
    }
}

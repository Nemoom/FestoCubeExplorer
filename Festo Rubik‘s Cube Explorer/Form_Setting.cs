using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festo_Rubik_s_Cube_Explorer
{
    public partial class Form_Setting : Form
    {
        public Form_Setting()
        {
            InitializeComponent();
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            textBox1.Text = GlobalVariables.global_Vel.ToString();
            textBox2.Text = GlobalVariables.global_Acc.ToString();
            textBox3.Text = GlobalVariables.global_Dec.ToString();
            textBox4.Text = GlobalVariables.global_Jerk.ToString();
            textBox5.Text = GlobalVariables.global_Vel_Rotate.ToString();
            textBox6.Text = GlobalVariables.global_Acc_Rotate.ToString();
            textBox7.Text = GlobalVariables.global_Dec_Rotate.ToString();
            textBox8.Text = GlobalVariables.global_Jerk_Rotate.ToString();
            textBox9.Text = GlobalVariables.CWgap.ToString();
            textBox10.Text = GlobalVariables.CCWgap.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string XMLNodePath = "";
            if (true)
            {
                XMLNodePath = @"Cube/PLC/";
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Vel", textBox1.Text);
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Acc", textBox2.Text);
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Dec", textBox3.Text);
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Jerk", textBox4.Text);
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Vel_Rotate", textBox5.Text);
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Acc_Rotate", textBox6.Text);
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Dec_Rotate", textBox7.Text);
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"Jerk_Rotate", textBox8.Text);
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"CWgap", textBox9.Text);
                GlobalVariables.SetXMLNodeValue(XMLNodePath + @"CCWgap", textBox10.Text);
            }
            MessageBox.Show("保存成功~");
            GlobalVariables.LoadParasFromXML();
        }
    }
}

namespace Festo_Rubik_s_Cube_Explorer
{
    partial class Form_Servo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Servo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_o_Enable = new System.Windows.Forms.CheckBox();
            this.btn_o_Reset = new System.Windows.Forms.Button();
            this.btn_o_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_o_JogNegative = new System.Windows.Forms.Button();
            this.btn_o_JogPositive = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_i_Enable = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_i_Error = new System.Windows.Forms.Label();
            this.txt_i_ErrorID = new System.Windows.Forms.TextBox();
            this.lbl_i_Home = new System.Windows.Forms.Label();
            this.lbl_i_MC = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_i_ActPos = new System.Windows.Forms.Label();
            this.txt_i_ActPos = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_o_Vel = new System.Windows.Forms.Label();
            this.btn_o_Go = new System.Windows.Forms.Button();
            this.lbl_o_Jerk = new System.Windows.Forms.Label();
            this.txt_o_Pos = new System.Windows.Forms.TextBox();
            this.cbx_P = new System.Windows.Forms.ComboBox();
            this.txt_o_Dec = new System.Windows.Forms.TextBox();
            this.lbl_o_Pos = new System.Windows.Forms.Label();
            this.txt_o_Acc = new System.Windows.Forms.TextBox();
            this.lbl_P = new System.Windows.Forms.Label();
            this.txt_o_Vel = new System.Windows.Forms.TextBox();
            this.lbl_o_Dec = new System.Windows.Forms.Label();
            this.txt_o_Jerk = new System.Windows.Forms.TextBox();
            this.lbl_o_Acc = new System.Windows.Forms.Label();
            this.imageList_Status = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Error = new System.Windows.Forms.ImageList(this.components);
            this.lbl_ServoName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 261);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.89764F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.10236F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Controls.Add(this.cbx_o_Enable, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_o_Reset, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_o_Home, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_i_Enable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_i_Home, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_i_MC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbx_o_Enable
            // 
            this.cbx_o_Enable.AutoCheck = false;
            this.cbx_o_Enable.AutoSize = true;
            this.cbx_o_Enable.Location = new System.Drawing.Point(294, 3);
            this.cbx_o_Enable.Name = "cbx_o_Enable";
            this.cbx_o_Enable.Size = new System.Drawing.Size(74, 21);
            this.cbx_o_Enable.TabIndex = 78;
            this.cbx_o_Enable.Text = "Enable";
            this.cbx_o_Enable.UseVisualStyleBackColor = true;
            this.cbx_o_Enable.CheckedChanged += new System.EventHandler(this.cbx_o_Enable_CheckedChanged);
            this.cbx_o_Enable.Click += new System.EventHandler(this.cbx_o_Enable_Click);
            // 
            // btn_o_Reset
            // 
            this.btn_o_Reset.Location = new System.Drawing.Point(294, 33);
            this.btn_o_Reset.Name = "btn_o_Reset";
            this.btn_o_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_o_Reset.TabIndex = 96;
            this.btn_o_Reset.Text = "Reset";
            this.btn_o_Reset.UseVisualStyleBackColor = true;
            this.btn_o_Reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_o_Reset_MouseDown);
            this.btn_o_Reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_o_Reset_MouseUp);
            // 
            // btn_o_Home
            // 
            this.btn_o_Home.Enabled = false;
            this.btn_o_Home.Location = new System.Drawing.Point(294, 63);
            this.btn_o_Home.Name = "btn_o_Home";
            this.btn_o_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_o_Home.TabIndex = 97;
            this.btn_o_Home.Text = "Homing";
            this.btn_o_Home.UseVisualStyleBackColor = true;
            this.btn_o_Home.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(291, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 30);
            this.panel2.TabIndex = 98;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(39, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_o_JogNegative);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_o_JogPositive);
            this.splitContainer1.Size = new System.Drawing.Size(281, 30);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.TabIndex = 101;
            // 
            // btn_o_JogNegative
            // 
            this.btn_o_JogNegative.Location = new System.Drawing.Point(0, 0);
            this.btn_o_JogNegative.Name = "btn_o_JogNegative";
            this.btn_o_JogNegative.Size = new System.Drawing.Size(75, 23);
            this.btn_o_JogNegative.TabIndex = 98;
            this.btn_o_JogNegative.Text = "<<";
            this.btn_o_JogNegative.UseVisualStyleBackColor = true;
            this.btn_o_JogNegative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_o_JogNegative_MouseDown);
            this.btn_o_JogNegative.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_o_JogNegative_MouseUp);
            // 
            // btn_o_JogPositive
            // 
            this.btn_o_JogPositive.Location = new System.Drawing.Point(0, 0);
            this.btn_o_JogPositive.Name = "btn_o_JogPositive";
            this.btn_o_JogPositive.Size = new System.Drawing.Size(75, 23);
            this.btn_o_JogPositive.TabIndex = 99;
            this.btn_o_JogPositive.Text = ">>";
            this.btn_o_JogPositive.UseVisualStyleBackColor = true;
            this.btn_o_JogPositive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_o_JogPositive_MouseDown);
            this.btn_o_JogPositive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_o_JogPositive_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Jog: ";
            // 
            // lbl_i_Enable
            // 
            this.lbl_i_Enable.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Enable.Image")));
            this.lbl_i_Enable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Enable.Location = new System.Drawing.Point(24, 0);
            this.lbl_i_Enable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Enable.Name = "lbl_i_Enable";
            this.lbl_i_Enable.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Enable.Size = new System.Drawing.Size(124, 25);
            this.lbl_i_Enable.TabIndex = 20;
            this.lbl_i_Enable.Text = "Enable";
            this.lbl_i_Enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_i_Error);
            this.panel3.Controls.Add(this.txt_i_ErrorID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(23, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 24);
            this.panel3.TabIndex = 99;
            // 
            // lbl_i_Error
            // 
            this.lbl_i_Error.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_i_Error.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Error.Image")));
            this.lbl_i_Error.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Error.Location = new System.Drawing.Point(0, 0);
            this.lbl_i_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Error.Name = "lbl_i_Error";
            this.lbl_i_Error.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Error.Size = new System.Drawing.Size(77, 24);
            this.lbl_i_Error.TabIndex = 19;
            this.lbl_i_Error.Text = "Error";
            this.lbl_i_Error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_i_ErrorID
            // 
            this.txt_i_ErrorID.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_i_ErrorID.Enabled = false;
            this.txt_i_ErrorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txt_i_ErrorID.Location = new System.Drawing.Point(113, 0);
            this.txt_i_ErrorID.Name = "txt_i_ErrorID";
            this.txt_i_ErrorID.Size = new System.Drawing.Size(132, 22);
            this.txt_i_ErrorID.TabIndex = 81;
            this.txt_i_ErrorID.Visible = false;
            // 
            // lbl_i_Home
            // 
            this.lbl_i_Home.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Home.Image")));
            this.lbl_i_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Home.Location = new System.Drawing.Point(24, 60);
            this.lbl_i_Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Home.Name = "lbl_i_Home";
            this.lbl_i_Home.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Home.Size = new System.Drawing.Size(158, 30);
            this.lbl_i_Home.TabIndex = 8;
            this.lbl_i_Home.Text = "Homing valid";
            this.lbl_i_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_i_MC
            // 
            this.lbl_i_MC.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_MC.Image")));
            this.lbl_i_MC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_MC.Location = new System.Drawing.Point(24, 90);
            this.lbl_i_MC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_MC.Name = "lbl_i_MC";
            this.lbl_i_MC.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_MC.Size = new System.Drawing.Size(64, 30);
            this.lbl_i_MC.TabIndex = 18;
            this.lbl_i_MC.Text = "MC";
            this.lbl_i_MC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lbl_i_ActPos);
            this.panel4.Controls.Add(this.txt_i_ActPos);
            this.panel4.Location = new System.Drawing.Point(23, 123);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel1.SetRowSpan(this.panel4, 4);
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label9.Location = new System.Drawing.Point(139, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 105;
            this.label9.Text = "mm";
            // 
            // lbl_i_ActPos
            // 
            this.lbl_i_ActPos.AutoSize = true;
            this.lbl_i_ActPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbl_i_ActPos.Location = new System.Drawing.Point(23, 20);
            this.lbl_i_ActPos.Name = "lbl_i_ActPos";
            this.lbl_i_ActPos.Size = new System.Drawing.Size(64, 17);
            this.lbl_i_ActPos.TabIndex = 82;
            this.lbl_i_ActPos.Text = "Act. Pos.";
            // 
            // txt_i_ActPos
            // 
            this.txt_i_ActPos.Enabled = false;
            this.txt_i_ActPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txt_i_ActPos.Location = new System.Drawing.Point(26, 40);
            this.txt_i_ActPos.Name = "txt_i_ActPos";
            this.txt_i_ActPos.Size = new System.Drawing.Size(107, 22);
            this.txt_i_ActPos.TabIndex = 83;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(291, 120);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.tableLayoutPanel1.SetRowSpan(this.panel5, 4);
            this.panel5.Size = new System.Drawing.Size(320, 120);
            this.panel5.TabIndex = 101;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Save, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_o_Vel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_o_Go, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_o_Jerk, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_o_Pos, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbx_P, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_o_Dec, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_o_Pos, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_o_Acc, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_P, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_o_Vel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_o_Dec, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_o_Jerk, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_o_Acc, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 120);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(209, 93);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 104;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // lbl_o_Vel
            // 
            this.lbl_o_Vel.AutoSize = true;
            this.lbl_o_Vel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbl_o_Vel.Location = new System.Drawing.Point(3, 0);
            this.lbl_o_Vel.Name = "lbl_o_Vel";
            this.lbl_o_Vel.Size = new System.Drawing.Size(28, 17);
            this.lbl_o_Vel.TabIndex = 84;
            this.lbl_o_Vel.Text = "Vel";
            // 
            // btn_o_Go
            // 
            this.btn_o_Go.Location = new System.Drawing.Point(50, 93);
            this.btn_o_Go.Name = "btn_o_Go";
            this.btn_o_Go.Size = new System.Drawing.Size(75, 23);
            this.btn_o_Go.TabIndex = 103;
            this.btn_o_Go.Text = "Go";
            this.btn_o_Go.UseVisualStyleBackColor = true;
            this.btn_o_Go.Click += new System.EventHandler(this.btn_o_Go_Click);
            // 
            // lbl_o_Jerk
            // 
            this.lbl_o_Jerk.AutoSize = true;
            this.lbl_o_Jerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbl_o_Jerk.Location = new System.Drawing.Point(3, 30);
            this.lbl_o_Jerk.Name = "lbl_o_Jerk";
            this.lbl_o_Jerk.Size = new System.Drawing.Size(35, 17);
            this.lbl_o_Jerk.TabIndex = 92;
            this.lbl_o_Jerk.Text = "Jerk";
            // 
            // txt_o_Pos
            // 
            this.txt_o_Pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txt_o_Pos.Location = new System.Drawing.Point(209, 63);
            this.txt_o_Pos.Name = "txt_o_Pos";
            this.txt_o_Pos.Size = new System.Drawing.Size(91, 22);
            this.txt_o_Pos.TabIndex = 95;
            this.txt_o_Pos.Text = "90";
            // 
            // cbx_P
            // 
            this.cbx_P.FormattingEnabled = true;
            this.cbx_P.Location = new System.Drawing.Point(50, 63);
            this.cbx_P.Name = "cbx_P";
            this.cbx_P.Size = new System.Drawing.Size(90, 24);
            this.cbx_P.TabIndex = 101;
            // 
            // txt_o_Dec
            // 
            this.txt_o_Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txt_o_Dec.Location = new System.Drawing.Point(209, 33);
            this.txt_o_Dec.Name = "txt_o_Dec";
            this.txt_o_Dec.Size = new System.Drawing.Size(91, 22);
            this.txt_o_Dec.TabIndex = 89;
            this.txt_o_Dec.Text = "100";
            // 
            // lbl_o_Pos
            // 
            this.lbl_o_Pos.AutoSize = true;
            this.lbl_o_Pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbl_o_Pos.Location = new System.Drawing.Point(164, 60);
            this.lbl_o_Pos.Name = "lbl_o_Pos";
            this.lbl_o_Pos.Size = new System.Drawing.Size(36, 17);
            this.lbl_o_Pos.TabIndex = 94;
            this.lbl_o_Pos.Text = "Pos.";
            // 
            // txt_o_Acc
            // 
            this.txt_o_Acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txt_o_Acc.Location = new System.Drawing.Point(209, 3);
            this.txt_o_Acc.Name = "txt_o_Acc";
            this.txt_o_Acc.Size = new System.Drawing.Size(91, 22);
            this.txt_o_Acc.TabIndex = 87;
            this.txt_o_Acc.Text = "100";
            // 
            // lbl_P
            // 
            this.lbl_P.AutoSize = true;
            this.lbl_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbl_P.Location = new System.Drawing.Point(3, 60);
            this.lbl_P.Name = "lbl_P";
            this.lbl_P.Size = new System.Drawing.Size(17, 17);
            this.lbl_P.TabIndex = 102;
            this.lbl_P.Text = "P";
            // 
            // txt_o_Vel
            // 
            this.txt_o_Vel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txt_o_Vel.Location = new System.Drawing.Point(50, 3);
            this.txt_o_Vel.Name = "txt_o_Vel";
            this.txt_o_Vel.Size = new System.Drawing.Size(90, 22);
            this.txt_o_Vel.TabIndex = 85;
            this.txt_o_Vel.Text = "10000";
            // 
            // lbl_o_Dec
            // 
            this.lbl_o_Dec.AutoSize = true;
            this.lbl_o_Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbl_o_Dec.Location = new System.Drawing.Point(164, 30);
            this.lbl_o_Dec.Name = "lbl_o_Dec";
            this.lbl_o_Dec.Size = new System.Drawing.Size(33, 17);
            this.lbl_o_Dec.TabIndex = 88;
            this.lbl_o_Dec.Text = "Dec";
            // 
            // txt_o_Jerk
            // 
            this.txt_o_Jerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txt_o_Jerk.Location = new System.Drawing.Point(50, 33);
            this.txt_o_Jerk.Name = "txt_o_Jerk";
            this.txt_o_Jerk.Size = new System.Drawing.Size(90, 22);
            this.txt_o_Jerk.TabIndex = 93;
            this.txt_o_Jerk.Text = "100000";
            // 
            // lbl_o_Acc
            // 
            this.lbl_o_Acc.AutoSize = true;
            this.lbl_o_Acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbl_o_Acc.Location = new System.Drawing.Point(164, 0);
            this.lbl_o_Acc.Name = "lbl_o_Acc";
            this.lbl_o_Acc.Size = new System.Drawing.Size(31, 17);
            this.lbl_o_Acc.TabIndex = 86;
            this.lbl_o_Acc.Text = "Acc";
            // 
            // imageList_Status
            // 
            this.imageList_Status.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Status.ImageStream")));
            this.imageList_Status.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Status.Images.SetKeyName(0, "status-offline.png");
            this.imageList_Status.Images.SetKeyName(1, "status.png");
            // 
            // imageList_Error
            // 
            this.imageList_Error.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Error.ImageStream")));
            this.imageList_Error.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Error.Images.SetKeyName(0, "status-offline.png");
            this.imageList_Error.Images.SetKeyName(1, "status-busy.png");
            // 
            // lbl_ServoName
            // 
            this.lbl_ServoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ServoName.Font = new System.Drawing.Font("MetaPlusLF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServoName.Location = new System.Drawing.Point(0, 0);
            this.lbl_ServoName.Name = "lbl_ServoName";
            this.lbl_ServoName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_ServoName.Size = new System.Drawing.Size(638, 72);
            this.lbl_ServoName.TabIndex = 1;
            this.lbl_ServoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Servo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 333);
            this.Controls.Add(this.lbl_ServoName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Servo";
            this.Text = "Form_Servo";
            this.Load += new System.EventHandler(this.Form_Servo_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList_Status;
        private System.Windows.Forms.ImageList imageList_Error;
        private System.Windows.Forms.TextBox txt_o_Pos;
        private System.Windows.Forms.Label lbl_o_Pos;
        private System.Windows.Forms.TextBox txt_o_Jerk;
        private System.Windows.Forms.Label lbl_o_Jerk;
        private System.Windows.Forms.TextBox txt_o_Dec;
        private System.Windows.Forms.Label lbl_o_Dec;
        private System.Windows.Forms.TextBox txt_o_Acc;
        private System.Windows.Forms.Label lbl_o_Acc;
        private System.Windows.Forms.TextBox txt_o_Vel;
        private System.Windows.Forms.Label lbl_o_Vel;
        private System.Windows.Forms.TextBox txt_i_ActPos;
        private System.Windows.Forms.Label lbl_i_ActPos;
        private System.Windows.Forms.TextBox txt_i_ErrorID;
        private System.Windows.Forms.CheckBox cbx_o_Enable;
        private System.Windows.Forms.Label lbl_i_Enable;
        private System.Windows.Forms.Label lbl_i_Error;
        private System.Windows.Forms.Label lbl_i_MC;
        private System.Windows.Forms.Label lbl_i_Home;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_o_Reset;
        private System.Windows.Forms.Button btn_o_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_o_JogNegative;
        private System.Windows.Forms.Button btn_o_JogPositive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_o_Go;
        private System.Windows.Forms.ComboBox cbx_P;
        private System.Windows.Forms.Label lbl_P;
        private System.Windows.Forms.Label lbl_ServoName;
        private System.Windows.Forms.Timer timer1;
    }
}
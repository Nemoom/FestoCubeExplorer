namespace Festo_Rubik_s_Cube_Explorer
{
    partial class Form_Servo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Servo2));
            this.imageList_Status = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Error = new System.Windows.Forms.ImageList(this.components);
            this.lbl_ServoName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_i_Out = new System.Windows.Forms.Label();
            this.btn_o_In = new System.Windows.Forms.Button();
            this.btn_o_Out = new System.Windows.Forms.Button();
            this.btn_o_QuitError = new System.Windows.Forms.Button();
            this.lbl_i_In = new System.Windows.Forms.Label();
            this.lbl_i_Move = new System.Windows.Forms.Label();
            this.lbl_i_Device = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.lbl_ServoName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ServoName.Location = new System.Drawing.Point(0, 0);
            this.lbl_ServoName.Name = "lbl_ServoName";
            this.lbl_ServoName.Size = new System.Drawing.Size(260, 37);
            this.lbl_ServoName.TabIndex = 1;
            this.lbl_ServoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.73619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.26381F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_i_Out, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_o_In, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_o_Out, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_o_QuitError, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_i_In, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_i_Move, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_i_Device, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 134);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_i_Out
            // 
            this.lbl_i_Out.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Out.Image")));
            this.lbl_i_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Out.Location = new System.Drawing.Point(4, 33);
            this.lbl_i_Out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Out.Name = "lbl_i_Out";
            this.lbl_i_Out.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Out.Size = new System.Drawing.Size(77, 26);
            this.lbl_i_Out.TabIndex = 19;
            this.lbl_i_Out.Text = "Out";
            this.lbl_i_Out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_o_In
            // 
            this.btn_o_In.Location = new System.Drawing.Point(160, 3);
            this.btn_o_In.Name = "btn_o_In";
            this.btn_o_In.Size = new System.Drawing.Size(75, 23);
            this.btn_o_In.TabIndex = 102;
            this.btn_o_In.Text = "In";
            this.btn_o_In.UseVisualStyleBackColor = true;
            this.btn_o_In.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_o_In_MouseDown);
            this.btn_o_In.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_o_In_MouseUp);
            // 
            // btn_o_Out
            // 
            this.btn_o_Out.Location = new System.Drawing.Point(160, 36);
            this.btn_o_Out.Name = "btn_o_Out";
            this.btn_o_Out.Size = new System.Drawing.Size(75, 23);
            this.btn_o_Out.TabIndex = 96;
            this.btn_o_Out.Text = "Out";
            this.btn_o_Out.UseVisualStyleBackColor = true;
            this.btn_o_Out.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_o_Out_MouseDown);
            this.btn_o_Out.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_o_Out_MouseUp);
            // 
            // btn_o_QuitError
            // 
            this.btn_o_QuitError.Location = new System.Drawing.Point(160, 69);
            this.btn_o_QuitError.Name = "btn_o_QuitError";
            this.btn_o_QuitError.Size = new System.Drawing.Size(75, 23);
            this.btn_o_QuitError.TabIndex = 97;
            this.btn_o_QuitError.Text = "QuitError";
            this.btn_o_QuitError.UseVisualStyleBackColor = true;
            this.btn_o_QuitError.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_o_QuitError_MouseDown);
            this.btn_o_QuitError.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_o_QuitError_MouseUp);
            // 
            // lbl_i_In
            // 
            this.lbl_i_In.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_In.Image")));
            this.lbl_i_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_In.Location = new System.Drawing.Point(4, 0);
            this.lbl_i_In.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_In.Name = "lbl_i_In";
            this.lbl_i_In.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_In.Size = new System.Drawing.Size(119, 25);
            this.lbl_i_In.TabIndex = 20;
            this.lbl_i_In.Text = "In";
            this.lbl_i_In.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_i_Move
            // 
            this.lbl_i_Move.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Move.Image")));
            this.lbl_i_Move.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Move.Location = new System.Drawing.Point(4, 66);
            this.lbl_i_Move.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Move.Name = "lbl_i_Move";
            this.lbl_i_Move.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Move.Size = new System.Drawing.Size(134, 31);
            this.lbl_i_Move.TabIndex = 8;
            this.lbl_i_Move.Text = "Move";
            this.lbl_i_Move.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_i_Device
            // 
            this.lbl_i_Device.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Device.Image")));
            this.lbl_i_Device.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Device.Location = new System.Drawing.Point(4, 99);
            this.lbl_i_Device.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Device.Name = "lbl_i_Device";
            this.lbl_i_Device.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Device.Size = new System.Drawing.Size(96, 31);
            this.lbl_i_Device.TabIndex = 18;
            this.lbl_i_Device.Text = "Device";
            this.lbl_i_Device.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Servo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 171);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_ServoName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Servo2";
            this.Text = "Form_Servo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList_Status;
        private System.Windows.Forms.ImageList imageList_Error;
        private System.Windows.Forms.Label lbl_ServoName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_i_Out;
        private System.Windows.Forms.Button btn_o_In;
        private System.Windows.Forms.Button btn_o_Out;
        private System.Windows.Forms.Button btn_o_QuitError;
        private System.Windows.Forms.Label lbl_i_In;
        private System.Windows.Forms.Label lbl_i_Move;
        private System.Windows.Forms.Label lbl_i_Device;
        private System.Windows.Forms.Timer timer1;
    }
}
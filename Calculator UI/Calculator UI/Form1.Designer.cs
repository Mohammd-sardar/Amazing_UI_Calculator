
namespace Calculator_UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btndevide = new Guna.UI2.WinForms.Guna2Button();
            this.btnmode = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btnmultiply = new Guna.UI2.WinForms.Guna2Button();
            this.btnminus = new Guna.UI2.WinForms.Guna2Button();
            this.btnplus = new Guna.UI2.WinForms.Guna2Button();
            this.btn9 = new Guna.UI2.WinForms.Guna2Button();
            this.btn6 = new Guna.UI2.WinForms.Guna2Button();
            this.btn3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnequal = new Guna.UI2.WinForms.Guna2Button();
            this.btn8 = new Guna.UI2.WinForms.Guna2Button();
            this.btn5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.btndot = new Guna.UI2.WinForms.Guna2Button();
            this.btn7 = new Guna.UI2.WinForms.Guna2Button();
            this.btn4 = new Guna.UI2.WinForms.Guna2Button();
            this.btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn0 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 19;
            this.guna2Panel1.Controls.Add(this.pictureBox3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.guna2Panel1.Location = new System.Drawing.Point(22, 28);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.guna2Panel1.Size = new System.Drawing.Size(444, 46);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(152, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Calculator_UI.Properties.Resources.minimize;
            this.pictureBox2.Location = new System.Drawing.Point(365, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Calculator_UI.Properties.Resources.remove_button;
            this.pictureBox1.Location = new System.Drawing.Point(400, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.guna2Panel2.BorderRadius = 70;
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.btndevide);
            this.guna2Panel2.Controls.Add(this.btnmode);
            this.guna2Panel2.Controls.Add(this.btnclear);
            this.guna2Panel2.Controls.Add(this.btnmultiply);
            this.guna2Panel2.Controls.Add(this.btnminus);
            this.guna2Panel2.Controls.Add(this.btnplus);
            this.guna2Panel2.Controls.Add(this.btn9);
            this.guna2Panel2.Controls.Add(this.btn6);
            this.guna2Panel2.Controls.Add(this.btn3);
            this.guna2Panel2.Controls.Add(this.btnequal);
            this.guna2Panel2.Controls.Add(this.btn8);
            this.guna2Panel2.Controls.Add(this.btn5);
            this.guna2Panel2.Controls.Add(this.btn2);
            this.guna2Panel2.Controls.Add(this.btndot);
            this.guna2Panel2.Controls.Add(this.btn7);
            this.guna2Panel2.Controls.Add(this.btn4);
            this.guna2Panel2.Controls.Add(this.btn1);
            this.guna2Panel2.Controls.Add(this.btn0);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 264);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(484, 522);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Lime;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.guna2Button1.Location = new System.Drawing.Point(164, 52);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(63, 60);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "+/-";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btndevide
            // 
            this.btndevide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btndevide.BorderRadius = 15;
            this.btndevide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndevide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndevide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndevide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndevide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndevide.FillColor = System.Drawing.Color.Black;
            this.btndevide.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndevide.ForeColor = System.Drawing.Color.Lime;
            this.btndevide.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btndevide.Location = new System.Drawing.Point(342, 52);
            this.btndevide.Name = "btndevide";
            this.btndevide.Size = new System.Drawing.Size(63, 60);
            this.btndevide.TabIndex = 18;
            this.btndevide.Text = "/";
            this.btndevide.Click += new System.EventHandler(this.btndevide_Click);
            // 
            // btnmode
            // 
            this.btnmode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btnmode.BorderRadius = 15;
            this.btnmode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmode.FillColor = System.Drawing.Color.Black;
            this.btnmode.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmode.ForeColor = System.Drawing.Color.Lime;
            this.btnmode.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btnmode.Location = new System.Drawing.Point(252, 52);
            this.btnmode.Name = "btnmode";
            this.btnmode.Size = new System.Drawing.Size(63, 60);
            this.btnmode.TabIndex = 17;
            this.btnmode.Text = "%";
            this.btnmode.Click += new System.EventHandler(this.btnmode_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btnclear.BorderRadius = 15;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.Red;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclear.Location = new System.Drawing.Point(78, 52);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(63, 60);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "C";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btnmultiply.BorderRadius = 15;
            this.btnmultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmultiply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmultiply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmultiply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmultiply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmultiply.FillColor = System.Drawing.Color.Black;
            this.btnmultiply.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiply.ForeColor = System.Drawing.Color.Lime;
            this.btnmultiply.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btnmultiply.Location = new System.Drawing.Point(342, 130);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(63, 60);
            this.btnmultiply.TabIndex = 14;
            this.btnmultiply.Text = "*";
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btnminus.BorderRadius = 15;
            this.btnminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnminus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnminus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnminus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnminus.FillColor = System.Drawing.Color.Black;
            this.btnminus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.ForeColor = System.Drawing.Color.Lime;
            this.btnminus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btnminus.Location = new System.Drawing.Point(342, 206);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(63, 60);
            this.btnminus.TabIndex = 13;
            this.btnminus.Text = "-";
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btnplus.BorderRadius = 15;
            this.btnplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnplus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnplus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnplus.FillColor = System.Drawing.Color.Black;
            this.btnplus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.ForeColor = System.Drawing.Color.Lime;
            this.btnplus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btnplus.Location = new System.Drawing.Point(342, 284);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(63, 60);
            this.btnplus.TabIndex = 12;
            this.btnplus.Text = "+";
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn9.BorderRadius = 15;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn9.FillColor = System.Drawing.Color.Black;
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn9.Location = new System.Drawing.Point(252, 130);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(63, 60);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn6.BorderRadius = 15;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn6.FillColor = System.Drawing.Color.Black;
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn6.Location = new System.Drawing.Point(252, 206);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 60);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn3.BorderRadius = 15;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn3.FillColor = System.Drawing.Color.Black;
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn3.Location = new System.Drawing.Point(252, 284);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(63, 60);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btnequal.BorderRadius = 15;
            this.btnequal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnequal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnequal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnequal.FillColor = System.Drawing.Color.Lime;
            this.btnequal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequal.ForeColor = System.Drawing.Color.Black;
            this.btnequal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnequal.Location = new System.Drawing.Point(252, 360);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(153, 60);
            this.btnequal.TabIndex = 8;
            this.btnequal.Text = "=";
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn8.BorderRadius = 15;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn8.FillColor = System.Drawing.Color.Black;
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn8.Location = new System.Drawing.Point(164, 130);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(63, 60);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn5.BorderRadius = 15;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn5.FillColor = System.Drawing.Color.Black;
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn5.Location = new System.Drawing.Point(164, 206);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(63, 60);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn2.BorderRadius = 15;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn2.FillColor = System.Drawing.Color.Black;
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn2.Location = new System.Drawing.Point(164, 284);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 60);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btndot.BorderRadius = 15;
            this.btndot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndot.FillColor = System.Drawing.Color.Black;
            this.btndot.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.ForeColor = System.Drawing.Color.White;
            this.btndot.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btndot.Location = new System.Drawing.Point(164, 360);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(63, 60);
            this.btndot.TabIndex = 4;
            this.btndot.Text = ".";
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn7.BorderRadius = 15;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn7.FillColor = System.Drawing.Color.Black;
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn7.Location = new System.Drawing.Point(78, 130);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(63, 60);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn4.BorderRadius = 15;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn4.FillColor = System.Drawing.Color.Black;
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn4.Location = new System.Drawing.Point(78, 206);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 60);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn1.BorderRadius = 15;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn1.FillColor = System.Drawing.Color.Black;
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn1.Location = new System.Drawing.Point(78, 284);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 60);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.btn0.BorderRadius = 15;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn0.FillColor = System.Drawing.Color.Black;
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.btn0.Location = new System.Drawing.Point(78, 360);
            this.btn0.Name = "btn0";
            this.btn0.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btn0.Size = new System.Drawing.Size(63, 60);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(43, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(484, 713);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn0;
        private Guna.UI2.WinForms.Guna2Button btn9;
        private Guna.UI2.WinForms.Guna2Button btn6;
        private Guna.UI2.WinForms.Guna2Button btn3;
        private Guna.UI2.WinForms.Guna2Button btnequal;
        private Guna.UI2.WinForms.Guna2Button btn8;
        private Guna.UI2.WinForms.Guna2Button btn5;
        private Guna.UI2.WinForms.Guna2Button btn2;
        private Guna.UI2.WinForms.Guna2Button btndot;
        private Guna.UI2.WinForms.Guna2Button btn7;
        private Guna.UI2.WinForms.Guna2Button btn4;
        private Guna.UI2.WinForms.Guna2Button btn1;
        private Guna.UI2.WinForms.Guna2Button btndevide;
        private Guna.UI2.WinForms.Guna2Button btnmode;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btnmultiply;
        private Guna.UI2.WinForms.Guna2Button btnminus;
        private Guna.UI2.WinForms.Guna2Button btnplus;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


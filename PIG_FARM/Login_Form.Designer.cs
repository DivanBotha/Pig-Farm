namespace PIG_FARM
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.Login_Logo = new System.Windows.Forms.PictureBox();
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.by_label_login = new System.Windows.Forms.Label();
            this.usrname_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Logo
            // 
            this.Login_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Login_Logo.Image")));
            this.Login_Logo.Location = new System.Drawing.Point(12, 12);
            this.Login_Logo.Name = "Login_Logo";
            this.Login_Logo.Size = new System.Drawing.Size(79, 44);
            this.Login_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login_Logo.TabIndex = 0;
            this.Login_Logo.TabStop = false;
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Label.ForeColor = System.Drawing.Color.White;
            this.Welcome_Label.Location = new System.Drawing.Point(112, 12);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(193, 23);
            this.Welcome_Label.TabIndex = 1;
            this.Welcome_Label.Text = "Welcome to AgriPig";
            // 
            // by_label_login
            // 
            this.by_label_login.AutoSize = true;
            this.by_label_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by_label_login.ForeColor = System.Drawing.Color.White;
            this.by_label_login.Location = new System.Drawing.Point(120, 40);
            this.by_label_login.Name = "by_label_login";
            this.by_label_login.Size = new System.Drawing.Size(173, 16);
            this.by_label_login.TabIndex = 1;
            this.by_label_login.Text = "by Software Farm (Pty) Ltd";
            // 
            // usrname_label
            // 
            this.usrname_label.AutoSize = true;
            this.usrname_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrname_label.ForeColor = System.Drawing.Color.White;
            this.usrname_label.Location = new System.Drawing.Point(14, 82);
            this.usrname_label.Name = "usrname_label";
            this.usrname_label.Size = new System.Drawing.Size(71, 17);
            this.usrname_label.TabIndex = 1;
            this.usrname_label.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forgot Password?";
            // 
            // Login_Button
            // 
            this.Login_Button.Activecolor = System.Drawing.Color.DimGray;
            this.Login_Button.BackColor = System.Drawing.Color.DimGray;
            this.Login_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Button.BorderRadius = 0;
            this.Login_Button.ButtonText = "Login";
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Login_Button.Iconimage = null;
            this.Login_Button.Iconimage_right = null;
            this.Login_Button.Iconimage_right_Selected = null;
            this.Login_Button.Iconimage_Selected = null;
            this.Login_Button.IconMarginLeft = 0;
            this.Login_Button.IconMarginRight = 0;
            this.Login_Button.IconRightVisible = true;
            this.Login_Button.IconRightZoom = 0D;
            this.Login_Button.IconVisible = true;
            this.Login_Button.IconZoom = 90D;
            this.Login_Button.IsTab = false;
            this.Login_Button.Location = new System.Drawing.Point(50, 157);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Normalcolor = System.Drawing.Color.DimGray;
            this.Login_Button.OnHovercolor = System.Drawing.Color.DimGray;
            this.Login_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Login_Button.selected = false;
            this.Login_Button.Size = new System.Drawing.Size(74, 28);
            this.Login_Button.TabIndex = 3;
            this.Login_Button.Text = "Login";
            this.Login_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_Button.Textcolor = System.Drawing.Color.White;
            this.Login_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Exit";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(200, 157);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(74, 28);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "Exit";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Activate Program";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(191, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Register Program";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(340, 235);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrname_label);
            this.Controls.Add(this.by_label_login);
            this.Controls.Add(this.Welcome_Label);
            this.Controls.Add(this.Login_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Login_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Login_Logo;
        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.Label by_label_login;
        private System.Windows.Forms.Label usrname_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton Login_Button;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
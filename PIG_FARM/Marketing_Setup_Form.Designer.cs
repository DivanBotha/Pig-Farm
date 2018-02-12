namespace PIG_FARM
{
    partial class Marketing_Setup_Form
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
            this.Mrkt_Setup_Data_Panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Mrkt_Setup_Datagrid = new System.Windows.Forms.DataGridView();
            this.Mrkt_Setup_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrkt_Agent_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrkt_Agent_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrkt_Setup_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrkt_Setup_Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrkt_Setup_Cellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrkt_Setup_Fax_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrkt_Setup_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrkt_Setup_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrkt_Setup_Vat_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mrkt_trgt_label = new System.Windows.Forms.Label();
            this.Mrkt_Setup_Head_Panel = new System.Windows.Forms.Panel();
            this.Mrkt_Setup_Data_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mrkt_Setup_Datagrid)).BeginInit();
            this.Mrkt_Setup_Head_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mrkt_Setup_Data_Panel
            // 
            this.Mrkt_Setup_Data_Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.Mrkt_Setup_Data_Panel.Controls.Add(this.button2);
            this.Mrkt_Setup_Data_Panel.Controls.Add(this.Mrkt_Setup_Datagrid);
            this.Mrkt_Setup_Data_Panel.Controls.Add(this.button3);
            this.Mrkt_Setup_Data_Panel.Controls.Add(this.button1);
            this.Mrkt_Setup_Data_Panel.Location = new System.Drawing.Point(31, 69);
            this.Mrkt_Setup_Data_Panel.Name = "Mrkt_Setup_Data_Panel";
            this.Mrkt_Setup_Data_Panel.Size = new System.Drawing.Size(1197, 251);
            this.Mrkt_Setup_Data_Panel.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(657, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Mrkt_Setup_Datagrid
            // 
            this.Mrkt_Setup_Datagrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Mrkt_Setup_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mrkt_Setup_Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mrkt_Setup_Code,
            this.Mrkt_Agent_Name,
            this.Mrkt_Agent_Surname,
            this.Mrkt_Setup_Company,
            this.Mrkt_Setup_Telephone,
            this.Mrkt_Setup_Cellphone,
            this.Mrkt_Setup_Fax_No,
            this.Mrkt_Setup_Email,
            this.Mrkt_Setup_City,
            this.Mrkt_Setup_Vat_No});
            this.Mrkt_Setup_Datagrid.Location = new System.Drawing.Point(27, 21);
            this.Mrkt_Setup_Datagrid.Name = "Mrkt_Setup_Datagrid";
            this.Mrkt_Setup_Datagrid.Size = new System.Drawing.Size(1143, 164);
            this.Mrkt_Setup_Datagrid.TabIndex = 1;
            // 
            // Mrkt_Setup_Code
            // 
            this.Mrkt_Setup_Code.HeaderText = "Code";
            this.Mrkt_Setup_Code.Name = "Mrkt_Setup_Code";
            // 
            // Mrkt_Agent_Name
            // 
            this.Mrkt_Agent_Name.HeaderText = "Name";
            this.Mrkt_Agent_Name.Name = "Mrkt_Agent_Name";
            // 
            // Mrkt_Agent_Surname
            // 
            this.Mrkt_Agent_Surname.HeaderText = "Surname";
            this.Mrkt_Agent_Surname.Name = "Mrkt_Agent_Surname";
            // 
            // Mrkt_Setup_Company
            // 
            this.Mrkt_Setup_Company.HeaderText = "Company";
            this.Mrkt_Setup_Company.Name = "Mrkt_Setup_Company";
            // 
            // Mrkt_Setup_Telephone
            // 
            this.Mrkt_Setup_Telephone.HeaderText = "Telephone Nr";
            this.Mrkt_Setup_Telephone.Name = "Mrkt_Setup_Telephone";
            // 
            // Mrkt_Setup_Cellphone
            // 
            this.Mrkt_Setup_Cellphone.HeaderText = "Cellphone Nr";
            this.Mrkt_Setup_Cellphone.Name = "Mrkt_Setup_Cellphone";
            // 
            // Mrkt_Setup_Fax_No
            // 
            this.Mrkt_Setup_Fax_No.HeaderText = "Fax Nr";
            this.Mrkt_Setup_Fax_No.Name = "Mrkt_Setup_Fax_No";
            // 
            // Mrkt_Setup_Email
            // 
            this.Mrkt_Setup_Email.HeaderText = "Email Address";
            this.Mrkt_Setup_Email.Name = "Mrkt_Setup_Email";
            // 
            // Mrkt_Setup_City
            // 
            this.Mrkt_Setup_City.HeaderText = "City";
            this.Mrkt_Setup_City.Name = "Mrkt_Setup_City";
            // 
            // Mrkt_Setup_Vat_No
            // 
            this.Mrkt_Setup_Vat_No.HeaderText = "VAT Number";
            this.Mrkt_Setup_Vat_No.Name = "Mrkt_Setup_Vat_No";
            this.Mrkt_Setup_Vat_No.Width = 200;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(551, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(447, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mrkt_trgt_label
            // 
            this.mrkt_trgt_label.AutoSize = true;
            this.mrkt_trgt_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrkt_trgt_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mrkt_trgt_label.Location = new System.Drawing.Point(545, 5);
            this.mrkt_trgt_label.Name = "mrkt_trgt_label";
            this.mrkt_trgt_label.Size = new System.Drawing.Size(84, 16);
            this.mrkt_trgt_label.TabIndex = 0;
            this.mrkt_trgt_label.Text = "MARKETING";
            // 
            // Mrkt_Setup_Head_Panel
            // 
            this.Mrkt_Setup_Head_Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.Mrkt_Setup_Head_Panel.Controls.Add(this.mrkt_trgt_label);
            this.Mrkt_Setup_Head_Panel.Location = new System.Drawing.Point(31, 35);
            this.Mrkt_Setup_Head_Panel.Name = "Mrkt_Setup_Head_Panel";
            this.Mrkt_Setup_Head_Panel.Size = new System.Drawing.Size(1197, 28);
            this.Mrkt_Setup_Head_Panel.TabIndex = 5;
            // 
            // Marketing_Setup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1261, 360);
            this.Controls.Add(this.Mrkt_Setup_Head_Panel);
            this.Controls.Add(this.Mrkt_Setup_Data_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Marketing_Setup_Form";
            this.Text = "Marketing_Setup_Form";
            this.Load += new System.EventHandler(this.Marketing_Setup_Form_Load);
            this.Mrkt_Setup_Data_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mrkt_Setup_Datagrid)).EndInit();
            this.Mrkt_Setup_Head_Panel.ResumeLayout(false);
            this.Mrkt_Setup_Head_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mrkt_Setup_Data_Panel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Mrkt_Setup_Datagrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mrkt_trgt_label;
        private System.Windows.Forms.Panel Mrkt_Setup_Head_Panel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Setup_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Agent_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Agent_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Setup_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Setup_Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Setup_Cellphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Setup_Fax_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Setup_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Setup_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrkt_Setup_Vat_No;
    }
}
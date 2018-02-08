namespace PIG_FARM
{
    partial class Setup_AniClass_Breeds
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
            this.mrkt_trgt_label = new System.Windows.Forms.Label();
            this.mrkt_target_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Animal_Class_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animal_Class_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Breed_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breed_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breeds_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mrkt_target_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mrkt_trgt_label
            // 
            this.mrkt_trgt_label.AutoSize = true;
            this.mrkt_trgt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrkt_trgt_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mrkt_trgt_label.Location = new System.Drawing.Point(142, 12);
            this.mrkt_trgt_label.Name = "mrkt_trgt_label";
            this.mrkt_trgt_label.Size = new System.Drawing.Size(135, 16);
            this.mrkt_trgt_label.TabIndex = 0;
            this.mrkt_trgt_label.Text = "ANIMAL CLASSES";
            // 
            // mrkt_target_panel
            // 
            this.mrkt_target_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.mrkt_target_panel.Controls.Add(this.button2);
            this.mrkt_target_panel.Controls.Add(this.dataGridView1);
            this.mrkt_target_panel.Controls.Add(this.button3);
            this.mrkt_target_panel.Controls.Add(this.button1);
            this.mrkt_target_panel.Controls.Add(this.mrkt_trgt_label);
            this.mrkt_target_panel.Location = new System.Drawing.Point(29, 26);
            this.mrkt_target_panel.Name = "mrkt_target_panel";
            this.mrkt_target_panel.Size = new System.Drawing.Size(393, 264);
            this.mrkt_target_panel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(258, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Animal_Class_Code,
            this.Animal_Class_Description});
            this.dataGridView1.Location = new System.Drawing.Point(26, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 144);
            this.dataGridView1.TabIndex = 1;
            // 
            // Animal_Class_Code
            // 
            this.Animal_Class_Code.HeaderText = "Code";
            this.Animal_Class_Code.Name = "Animal_Class_Code";
            // 
            // Animal_Class_Description
            // 
            this.Animal_Class_Description.HeaderText = "Description";
            this.Animal_Class_Description.MaxInputLength = 40000;
            this.Animal_Class_Description.Name = "Animal_Class_Description";
            this.Animal_Class_Description.Width = 200;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(152, 208);
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
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(48, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(457, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 264);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(422, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Breed_Code,
            this.Breed_Description,
            this.Breeds_Notes});
            this.dataGridView2.Location = new System.Drawing.Point(26, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 144);
            this.dataGridView2.TabIndex = 1;
            // 
            // Breed_Code
            // 
            this.Breed_Code.HeaderText = "Code";
            this.Breed_Code.Name = "Breed_Code";
            // 
            // Breed_Description
            // 
            this.Breed_Description.HeaderText = "Description";
            this.Breed_Description.MaxInputLength = 40000;
            this.Breed_Description.Name = "Breed_Description";
            this.Breed_Description.Width = 200;
            // 
            // Breeds_Notes
            // 
            this.Breeds_Notes.HeaderText = "Notes";
            this.Breeds_Notes.Name = "Breeds_Notes";
            this.Breeds_Notes.Width = 300;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(316, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 28);
            this.button5.TabIndex = 3;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(212, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 28);
            this.button6.TabIndex = 3;
            this.button6.Text = "Insert";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(313, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BREEDS";
            // 
            // Setup_AniClass_Breeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1179, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mrkt_target_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setup_AniClass_Breeds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup_AniClass_Breeds";
            this.Load += new System.EventHandler(this.Setup_AniClass_Breeds_Load);
            this.mrkt_target_panel.ResumeLayout(false);
            this.mrkt_target_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mrkt_trgt_label;
        private System.Windows.Forms.Panel mrkt_target_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal_Class_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal_Class_Description;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breed_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breed_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breeds_Notes;
    }
}
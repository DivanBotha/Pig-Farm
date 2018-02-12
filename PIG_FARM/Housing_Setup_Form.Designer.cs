namespace PIG_FARM
{
    partial class Housing_Setup_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Pen_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pen_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Housing_Pen_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pen_Surface_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pen_Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mrkt_target_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Housing_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Housing_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surface_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Housing_Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_Pens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mrkt_trgt_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.mrkt_target_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(28, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 247);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(416, 208);
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
            this.Pen_Code,
            this.Pen_Description,
            this.Housing_Pen_Code,
            this.Pen_Surface_Area,
            this.Pen_Capacity});
            this.dataGridView2.Location = new System.Drawing.Point(26, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(663, 166);
            this.dataGridView2.TabIndex = 1;
            // 
            // Pen_Code
            // 
            this.Pen_Code.HeaderText = "Code";
            this.Pen_Code.Name = "Pen_Code";
            // 
            // Pen_Description
            // 
            this.Pen_Description.HeaderText = "Description";
            this.Pen_Description.MaxInputLength = 40000;
            this.Pen_Description.Name = "Pen_Description";
            this.Pen_Description.Width = 200;
            // 
            // Housing_Pen_Code
            // 
            this.Housing_Pen_Code.HeaderText = "Housing Code";
            this.Housing_Pen_Code.Name = "Housing_Pen_Code";
            // 
            // Pen_Surface_Area
            // 
            this.Pen_Surface_Area.HeaderText = "Surface Area (m2)";
            this.Pen_Surface_Area.Name = "Pen_Surface_Area";
            this.Pen_Surface_Area.Width = 120;
            // 
            // Pen_Capacity
            // 
            this.Pen_Capacity.HeaderText = "Capacity";
            this.Pen_Capacity.Name = "Pen_Capacity";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(310, 208);
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
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(206, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 28);
            this.button6.TabIndex = 3;
            this.button6.Text = "Insert";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(337, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PENS";
            // 
            // mrkt_target_panel
            // 
            this.mrkt_target_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.mrkt_target_panel.Controls.Add(this.button2);
            this.mrkt_target_panel.Controls.Add(this.dataGridView1);
            this.mrkt_target_panel.Controls.Add(this.button3);
            this.mrkt_target_panel.Controls.Add(this.button1);
            this.mrkt_target_panel.Location = new System.Drawing.Point(28, 55);
            this.mrkt_target_panel.Name = "mrkt_target_panel";
            this.mrkt_target_panel.Size = new System.Drawing.Size(717, 251);
            this.mrkt_target_panel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(416, 210);
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
            this.Housing_Code,
            this.Housing_Description,
            this.Surface_Area,
            this.Housing_Capacity,
            this.Qty_Pens});
            this.dataGridView1.Location = new System.Drawing.Point(26, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 176);
            this.dataGridView1.TabIndex = 1;
            // 
            // Housing_Code
            // 
            this.Housing_Code.HeaderText = "Code";
            this.Housing_Code.Name = "Housing_Code";
            // 
            // Housing_Description
            // 
            this.Housing_Description.HeaderText = "Description";
            this.Housing_Description.MaxInputLength = 40000;
            this.Housing_Description.Name = "Housing_Description";
            this.Housing_Description.Width = 200;
            // 
            // Surface_Area
            // 
            this.Surface_Area.HeaderText = "Surface Area (m2)";
            this.Surface_Area.Name = "Surface_Area";
            this.Surface_Area.Width = 120;
            // 
            // Housing_Capacity
            // 
            this.Housing_Capacity.HeaderText = "Capacity";
            this.Housing_Capacity.Name = "Housing_Capacity";
            // 
            // Qty_Pens
            // 
            this.Qty_Pens.HeaderText = "Pens";
            this.Qty_Pens.Name = "Qty_Pens";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(310, 210);
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
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(206, 210);
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
            this.mrkt_trgt_label.Location = new System.Drawing.Point(329, 6);
            this.mrkt_trgt_label.Name = "mrkt_trgt_label";
            this.mrkt_trgt_label.Size = new System.Drawing.Size(68, 16);
            this.mrkt_trgt_label.TabIndex = 0;
            this.mrkt_trgt_label.Text = "HOUSING";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.mrkt_trgt_label);
            this.panel2.Location = new System.Drawing.Point(28, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 28);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(28, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 28);
            this.panel3.TabIndex = 4;
            // 
            // Housing_Setup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(782, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mrkt_target_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Housing_Setup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Housing_Form";
            this.Load += new System.EventHandler(this.Housing_Setup_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.mrkt_target_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mrkt_target_panel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mrkt_trgt_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pen_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pen_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Housing_Pen_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pen_Surface_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pen_Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Housing_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Housing_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surface_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Housing_Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_Pens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
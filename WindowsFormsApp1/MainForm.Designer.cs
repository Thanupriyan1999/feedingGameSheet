namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lableExit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date_label = new System.Windows.Forms.Label();
            this.ModuleNo_textBox = new System.Windows.Forms.TextBox();
            this.ModuleNo_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Audit_button9 = new System.Windows.Forms.Button();
            this.Production_button8 = new System.Windows.Forms.Button();
            this.ZonelHead_button6 = new System.Windows.Forms.Button();
            this.Technical_button5 = new System.Windows.Forms.Button();
            this.Leader_button4 = new System.Windows.Forms.Button();
            this.WorkStudy_button3 = new System.Windows.Forms.Button();
            this.Machanic_button2 = new System.Windows.Forms.Button();
            this.FeedingSheet_button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lableExit
            // 
            this.lableExit.AutoSize = true;
            this.lableExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lableExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableExit.Location = new System.Drawing.Point(1041, 9);
            this.lableExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableExit.Name = "lableExit";
            this.lableExit.Size = new System.Drawing.Size(15, 16);
            this.lableExit.TabIndex = 0;
            this.lableExit.Text = "X";
            this.lableExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Date_label);
            this.panel1.Controls.Add(this.ModuleNo_textBox);
            this.panel1.Controls.Add(this.ModuleNo_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lableExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 40);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(773, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.Location = new System.Drawing.Point(730, 9);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(43, 18);
            this.Date_label.TabIndex = 5;
            this.Date_label.Text = "Date:";
            // 
            // ModuleNo_textBox
            // 
            this.ModuleNo_textBox.Location = new System.Drawing.Point(359, 9);
            this.ModuleNo_textBox.Name = "ModuleNo_textBox";
            this.ModuleNo_textBox.Size = new System.Drawing.Size(83, 22);
            this.ModuleNo_textBox.TabIndex = 4;
            // 
            // ModuleNo_label
            // 
            this.ModuleNo_label.AutoSize = true;
            this.ModuleNo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleNo_label.Location = new System.Drawing.Point(264, 11);
            this.ModuleNo_label.Name = "ModuleNo_label";
            this.ModuleNo_label.Size = new System.Drawing.Size(85, 18);
            this.ModuleNo_label.TabIndex = 3;
            this.ModuleNo_label.Text = "Module No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pre Plan For The Feeding";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.Audit_button9);
            this.panel2.Controls.Add(this.Production_button8);
            this.panel2.Controls.Add(this.ZonelHead_button6);
            this.panel2.Controls.Add(this.Technical_button5);
            this.panel2.Controls.Add(this.Leader_button4);
            this.panel2.Controls.Add(this.WorkStudy_button3);
            this.panel2.Controls.Add(this.Machanic_button2);
            this.panel2.Controls.Add(this.FeedingSheet_button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 652);
            this.panel2.TabIndex = 2;
            // 
            // Audit_button9
            // 
            this.Audit_button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Audit_button9.FlatAppearance.BorderSize = 0;
            this.Audit_button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Audit_button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Audit_button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Audit_button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Audit_button9.Location = new System.Drawing.Point(20, 563);
            this.Audit_button9.Name = "Audit_button9";
            this.Audit_button9.Size = new System.Drawing.Size(182, 46);
            this.Audit_button9.TabIndex = 10;
            this.Audit_button9.Text = "Audit Conformation Process";
            this.Audit_button9.UseVisualStyleBackColor = false;
            this.Audit_button9.Click += new System.EventHandler(this.Audit_button9_Click);
            // 
            // Production_button8
            // 
            this.Production_button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Production_button8.FlatAppearance.BorderSize = 0;
            this.Production_button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Production_button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Production_button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Production_button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Production_button8.Location = new System.Drawing.Point(17, 522);
            this.Production_button8.Name = "Production_button8";
            this.Production_button8.Size = new System.Drawing.Size(182, 35);
            this.Production_button8.TabIndex = 9;
            this.Production_button8.Text = "Production Assistant";
            this.Production_button8.UseVisualStyleBackColor = false;
            // 
            // ZonelHead_button6
            // 
            this.ZonelHead_button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.ZonelHead_button6.FlatAppearance.BorderSize = 0;
            this.ZonelHead_button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ZonelHead_button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ZonelHead_button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZonelHead_button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZonelHead_button6.Location = new System.Drawing.Point(17, 466);
            this.ZonelHead_button6.Name = "ZonelHead_button6";
            this.ZonelHead_button6.Size = new System.Drawing.Size(182, 35);
            this.ZonelHead_button6.TabIndex = 8;
            this.ZonelHead_button6.Text = "Zonel Head";
            this.ZonelHead_button6.UseVisualStyleBackColor = false;
            // 
            // Technical_button5
            // 
            this.Technical_button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Technical_button5.FlatAppearance.BorderSize = 0;
            this.Technical_button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Technical_button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Technical_button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Technical_button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Technical_button5.Location = new System.Drawing.Point(16, 409);
            this.Technical_button5.Name = "Technical_button5";
            this.Technical_button5.Size = new System.Drawing.Size(182, 35);
            this.Technical_button5.TabIndex = 7;
            this.Technical_button5.Text = "Technical";
            this.Technical_button5.UseVisualStyleBackColor = false;
            // 
            // Leader_button4
            // 
            this.Leader_button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Leader_button4.FlatAppearance.BorderSize = 0;
            this.Leader_button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Leader_button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Leader_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Leader_button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Leader_button4.Location = new System.Drawing.Point(16, 358);
            this.Leader_button4.Name = "Leader_button4";
            this.Leader_button4.Size = new System.Drawing.Size(182, 35);
            this.Leader_button4.TabIndex = 6;
            this.Leader_button4.Text = "Leader/Incharge";
            this.Leader_button4.UseVisualStyleBackColor = false;
            // 
            // WorkStudy_button3
            // 
            this.WorkStudy_button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.WorkStudy_button3.FlatAppearance.BorderSize = 0;
            this.WorkStudy_button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.WorkStudy_button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.WorkStudy_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkStudy_button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WorkStudy_button3.Location = new System.Drawing.Point(16, 301);
            this.WorkStudy_button3.Name = "WorkStudy_button3";
            this.WorkStudy_button3.Size = new System.Drawing.Size(182, 35);
            this.WorkStudy_button3.TabIndex = 5;
            this.WorkStudy_button3.Text = "Work Study";
            this.WorkStudy_button3.UseVisualStyleBackColor = false;
            this.WorkStudy_button3.Click += new System.EventHandler(this.WorkStudy_button3_Click);
            // 
            // Machanic_button2
            // 
            this.Machanic_button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Machanic_button2.FlatAppearance.BorderSize = 0;
            this.Machanic_button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Machanic_button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Machanic_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Machanic_button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Machanic_button2.Location = new System.Drawing.Point(16, 243);
            this.Machanic_button2.Name = "Machanic_button2";
            this.Machanic_button2.Size = new System.Drawing.Size(182, 35);
            this.Machanic_button2.TabIndex = 4;
            this.Machanic_button2.Text = "Mechanic";
            this.Machanic_button2.UseVisualStyleBackColor = false;
            this.Machanic_button2.Click += new System.EventHandler(this.Machanic_button2_Click);
            // 
            // FeedingSheet_button1
            // 
            this.FeedingSheet_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.FeedingSheet_button1.FlatAppearance.BorderSize = 0;
            this.FeedingSheet_button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.FeedingSheet_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.FeedingSheet_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeedingSheet_button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FeedingSheet_button1.Location = new System.Drawing.Point(16, 187);
            this.FeedingSheet_button1.Name = "FeedingSheet_button1";
            this.FeedingSheet_button1.Size = new System.Drawing.Size(182, 35);
            this.FeedingSheet_button1.TabIndex = 3;
            this.FeedingSheet_button1.Text = "Feeding game sheet";
            this.FeedingSheet_button1.UseVisualStyleBackColor = false;
            this.FeedingSheet_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(56, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome, user";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 652);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1069, 692);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lableExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FeedingSheet_button1;
        private System.Windows.Forms.Button Technical_button5;
        private System.Windows.Forms.Button Leader_button4;
        private System.Windows.Forms.Button WorkStudy_button3;
        private System.Windows.Forms.Button Machanic_button2;
        private System.Windows.Forms.Button ZonelHead_button6;
        private System.Windows.Forms.Button Audit_button9;
        private System.Windows.Forms.Button Production_button8;
        private System.Windows.Forms.Label ModuleNo_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.TextBox ModuleNo_textBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
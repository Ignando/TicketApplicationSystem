namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label10 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel7 = new Panel();
            label8 = new Label();
            panel8 = new Panel();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 178);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(116, 14);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 2;
            label1.Text = "Passenger Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 57);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            label2.Click += rrn;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 125);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "Age";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Location = new Point(31, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(299, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(15, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 125);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 73);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Distance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 73);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 2;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(132, 16);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 2;
            label6.Text = "Travel Details";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(15, 370);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 44);
            panel3.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 112);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 3;
            label7.Text = "Full Name";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Menu;
            textBox7.Location = new Point(268, 91);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.MenuBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(82, 24);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 6);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 10;
            label10.Text = "Gender";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.MenuBar;
            panel5.Controls.Add(radioButton1);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(radioButton2);
            panel5.Location = new Point(31, 114);
            panel5.Name = "panel5";
            panel5.Size = new Size(159, 52);
            panel5.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(15, 216);
            panel4.Name = "panel4";
            panel4.Size = new Size(434, 53);
            panel4.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.GradientActiveCaption;
            panel6.Controls.Add(label1);
            panel6.Location = new Point(12, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(434, 54);
            panel6.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(113, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 10;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(194, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 11;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(275, 3);
            button3.Name = "button3";
            button3.Size = new Size(121, 32);
            button3.TabIndex = 12;
            button3.Text = "Calculate Ticket";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.RoyalBlue;
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(513, 69);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 123);
            panel7.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(6, 56);
            label8.Name = "label8";
            label8.Size = new Size(97, 37);
            label8.TabIndex = 2;
            label8.Text = "R 0.00";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlLightLight;
            panel8.Controls.Add(label20);
            panel8.Controls.Add(label19);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(label15);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(513, 69);
            panel8.Name = "panel8";
            panel8.Size = new Size(289, 245);
            panel8.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 108);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 3;
            label9.Text = "Distance";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 138);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 2;
            label11.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(78, 14);
            label12.Name = "label12";
            label12.Size = new Size(134, 21);
            label12.TabIndex = 8;
            label12.Text = "Ticket Summary";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 163);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 4;
            label13.Text = "Category";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 192);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 5;
            label14.Text = "Distance";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 220);
            label15.Name = "label15";
            label15.Size = new Size(54, 15);
            label15.TabIndex = 6;
            label15.Text = "Discount";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(7, 39);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 8;
            label16.Text = "Category";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(211, 138);
            label17.Name = "label17";
            label17.Size = new Size(22, 15);
            label17.TabIndex = 7;
            label17.Text = "---";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(211, 163);
            label18.Name = "label18";
            label18.Size = new Size(22, 15);
            label18.TabIndex = 8;
            label18.Text = "---";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(211, 192);
            label19.Name = "label19";
            label19.Size = new Size(22, 15);
            label19.TabIndex = 9;
            label19.Text = "---";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(211, 220);
            label20.Name = "label20";
            label20.Size = new Size(22, 15);
            label20.TabIndex = 10;
            label20.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(829, 451);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel3;
        private Label label7;
        private Panel panel5;
        private RadioButton radioButton1;
        private Label label10;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private Panel panel6;
        private Panel panel4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel7;
        private Label label12;
        private Label label8;
        private Panel panel8;
        private Label label9;
        private Label label11;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
    }
}

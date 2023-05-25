namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            TimeBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            InputTime1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(87, 292);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 0;
            button1.Text = "▶";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TimeBox1
            // 
            TimeBox1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBox1.Location = new Point(23, 148);
            TimeBox1.Margin = new Padding(2);
            TimeBox1.Multiline = true;
            TimeBox1.Name = "TimeBox1";
            TimeBox1.ReadOnly = true;
            TimeBox1.Size = new Size(166, 59);
            TimeBox1.TabIndex = 1;
            TimeBox1.Text = "00:00:00";
            TimeBox1.TextAlign = HorizontalAlignment.Center;
            TimeBox1.TextChanged += TimeBox1_TextChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // InputTime1
            // 
            InputTime1.ForeColor = SystemColors.WindowText;
            InputTime1.Location = new Point(87, 255);
            InputTime1.Margin = new Padding(2);
            InputTime1.MaxLength = 4;
            InputTime1.Name = "InputTime1";
            InputTime1.Size = new Size(34, 23);
            InputTime1.TabIndex = 2;
            InputTime1.TextAlign = HorizontalAlignment.Right;
            InputTime1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 258);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 3;
            label1.Text = "분";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 99);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "첫번째 자리";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(220, 148);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 59);
            textBox1.TabIndex = 5;
            textBox1.Text = "00:00:00";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 99);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 6;
            label3.Text = "두번째 자리";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(286, 255);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(34, 23);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.Location = new Point(286, 292);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(33, 29);
            button2.TabIndex = 8;
            button2.Text = "▶";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(410, 148);
            textBox3.Margin = new Padding(2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 59);
            textBox3.TabIndex = 9;
            textBox3.Text = "00:00:00";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(604, 148);
            textBox4.Margin = new Padding(2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 59);
            textBox4.TabIndex = 10;
            textBox4.Text = "00:00:00";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.WindowText;
            textBox5.Location = new Point(480, 255);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(34, 23);
            textBox5.TabIndex = 11;
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.WindowText;
            textBox6.Location = new Point(676, 255);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(34, 23);
            textBox6.TabIndex = 12;
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // button3
            // 
            button3.Location = new Point(480, 292);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(33, 29);
            button3.TabIndex = 13;
            button3.Text = "▶";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(677, 292);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(33, 29);
            button4.TabIndex = 14;
            button4.Text = "▶";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 99);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 15;
            label4.Text = "세번째 자리";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(654, 99);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 16;
            label5.Text = "네번째 자리";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 258);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 17;
            label6.Text = "분";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(518, 258);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 18;
            label7.Text = "분";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(714, 258);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 19;
            label8.Text = "분";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputTime1);
            Controls.Add(TimeBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TimeBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox InputTime1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
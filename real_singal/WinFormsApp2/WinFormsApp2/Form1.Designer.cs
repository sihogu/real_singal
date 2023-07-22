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
            timer1 = new System.Windows.Forms.Timer(components);
            label9 = new Label();
            label1 = new Label();
            InputTime1 = new TextBox();
            TimeBox1 = new TextBox();
            button1_2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox4 = new GroupBox();
            button6 = new Button();
            button7 = new Button();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox5 = new GroupBox();
            button8 = new Button();
            button9 = new Button();
            label4 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            groupBox6 = new GroupBox();
            button10 = new Button();
            button11 = new Button();
            label8 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            groupBox7 = new GroupBox();
            button12 = new Button();
            button13 = new Button();
            label11 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            groupBox8 = new GroupBox();
            button14 = new Button();
            button15 = new Button();
            label2 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(55, 174);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 20;
            label9.Text = "(빈칸 = 60분)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 200);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 3;
            label1.Text = "분";
            label1.Click += label1_Click;
            // 
            // InputTime1
            // 
            InputTime1.ForeColor = SystemColors.WindowText;
            InputTime1.Location = new Point(84, 198);
            InputTime1.Margin = new Padding(2);
            InputTime1.MaxLength = 4;
            InputTime1.Name = "InputTime1";
            InputTime1.Size = new Size(34, 23);
            InputTime1.TabIndex = 2;
            InputTime1.TextAlign = HorizontalAlignment.Right;
            InputTime1.TextChanged += textBox1_TextChanged;
            // 
            // TimeBox1
            // 
            TimeBox1.AllowDrop = true;
            TimeBox1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBox1.Location = new Point(15, 57);
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
            // button1_2
            // 
            button1_2.Location = new Point(108, 236);
            button1_2.Margin = new Padding(2);
            button1_2.Name = "button1_2";
            button1_2.Size = new Size(33, 30);
            button1_2.TabIndex = 21;
            button1_2.Text = "■";
            button1_2.UseVisualStyleBackColor = true;
            button1_2.Click += button1_2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(64, 236);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 0;
            button1.Text = "▶";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button1_2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TimeBox1);
            groupBox1.Controls.Add(InputTime1);
            groupBox1.Location = new Point(23, 32);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(198, 326);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "1번 컴퓨터";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(250, 32);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(198, 326);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "2번 컴퓨터";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(64, 236);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(33, 29);
            button2.TabIndex = 0;
            button2.Text = "▶";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(108, 236);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(33, 30);
            button3.TabIndex = 21;
            button3.Text = "■";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 200);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 3;
            label3.Text = "분";
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(15, 57);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(166, 59);
            textBox1.TabIndex = 1;
            textBox1.Text = "00:00:00";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(84, 198);
            textBox2.Margin = new Padding(2);
            textBox2.MaxLength = 4;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(34, 23);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Location = new Point(476, 32);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(198, 326);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "3번 컴퓨터";
            // 
            // button4
            // 
            button4.Location = new Point(64, 236);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(33, 29);
            button4.TabIndex = 0;
            button4.Text = "▶";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(108, 236);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(33, 30);
            button5.TabIndex = 21;
            button5.Text = "■";
            button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 200);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 3;
            label5.Text = "분";
            // 
            // textBox3
            // 
            textBox3.AllowDrop = true;
            textBox3.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(15, 57);
            textBox3.Margin = new Padding(2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(166, 59);
            textBox3.TabIndex = 1;
            textBox3.Text = "00:00:00";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.WindowText;
            textBox4.Location = new Point(84, 198);
            textBox4.Margin = new Padding(2);
            textBox4.MaxLength = 4;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(34, 23);
            textBox4.TabIndex = 2;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(button7);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(textBox6);
            groupBox4.Location = new Point(704, 32);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(198, 326);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "4번 컴퓨터";
            // 
            // button6
            // 
            button6.Location = new Point(64, 236);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(33, 29);
            button6.TabIndex = 0;
            button6.Text = "▶";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(108, 236);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(33, 30);
            button7.TabIndex = 21;
            button7.Text = "■";
            button7.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 200);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 3;
            label7.Text = "분";
            // 
            // textBox5
            // 
            textBox5.AllowDrop = true;
            textBox5.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(15, 57);
            textBox5.Margin = new Padding(2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(166, 59);
            textBox5.TabIndex = 1;
            textBox5.Text = "00:00:00";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.WindowText;
            textBox6.Location = new Point(84, 198);
            textBox6.Margin = new Padding(2);
            textBox6.MaxLength = 4;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(34, 23);
            textBox6.TabIndex = 2;
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button8);
            groupBox5.Controls.Add(button9);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(textBox7);
            groupBox5.Controls.Add(textBox8);
            groupBox5.Location = new Point(23, 390);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(198, 326);
            groupBox5.TabIndex = 33;
            groupBox5.TabStop = false;
            groupBox5.Text = "닌텐도";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // button8
            // 
            button8.Location = new Point(64, 236);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(33, 29);
            button8.TabIndex = 0;
            button8.Text = "▶";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(108, 236);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(33, 30);
            button9.TabIndex = 21;
            button9.Text = "■";
            button9.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 199);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 3;
            label4.Text = "분";
            // 
            // textBox7
            // 
            textBox7.AllowDrop = true;
            textBox7.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(15, 57);
            textBox7.Margin = new Padding(2);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(166, 59);
            textBox7.TabIndex = 1;
            textBox7.Text = "00:00:00";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.ForeColor = SystemColors.WindowText;
            textBox8.Location = new Point(84, 198);
            textBox8.Margin = new Padding(2);
            textBox8.MaxLength = 4;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(34, 23);
            textBox8.TabIndex = 2;
            textBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button10);
            groupBox6.Controls.Add(button11);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(textBox9);
            groupBox6.Controls.Add(textBox10);
            groupBox6.Location = new Point(250, 390);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(198, 326);
            groupBox6.TabIndex = 34;
            groupBox6.TabStop = false;
            groupBox6.Text = "노래방";
            // 
            // button10
            // 
            button10.Location = new Point(64, 236);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(33, 29);
            button10.TabIndex = 0;
            button10.Text = "▶";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(108, 236);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(33, 30);
            button11.TabIndex = 21;
            button11.Text = "■";
            button11.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(121, 199);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 3;
            label8.Text = "분";
            // 
            // textBox9
            // 
            textBox9.AllowDrop = true;
            textBox9.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.Location = new Point(15, 57);
            textBox9.Margin = new Padding(2);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(166, 59);
            textBox9.TabIndex = 1;
            textBox9.Text = "00:00:00";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            textBox10.ForeColor = SystemColors.WindowText;
            textBox10.Location = new Point(84, 198);
            textBox10.Margin = new Padding(2);
            textBox10.MaxLength = 4;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(34, 23);
            textBox10.TabIndex = 2;
            textBox10.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(button12);
            groupBox7.Controls.Add(button13);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(textBox11);
            groupBox7.Controls.Add(textBox12);
            groupBox7.Location = new Point(476, 390);
            groupBox7.Margin = new Padding(2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(2);
            groupBox7.Size = new Size(198, 326);
            groupBox7.TabIndex = 35;
            groupBox7.TabStop = false;
            groupBox7.Text = "패드민턴";
            // 
            // button12
            // 
            button12.Location = new Point(64, 236);
            button12.Margin = new Padding(2);
            button12.Name = "button12";
            button12.Size = new Size(33, 29);
            button12.TabIndex = 0;
            button12.Text = "▶";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(108, 236);
            button13.Margin = new Padding(2);
            button13.Name = "button13";
            button13.Size = new Size(33, 30);
            button13.TabIndex = 21;
            button13.Text = "■";
            button13.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(121, 199);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 3;
            label11.Text = "분";
            // 
            // textBox11
            // 
            textBox11.AllowDrop = true;
            textBox11.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox11.Location = new Point(15, 57);
            textBox11.Margin = new Padding(2);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(166, 59);
            textBox11.TabIndex = 1;
            textBox11.Text = "00:00:00";
            textBox11.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            textBox12.ForeColor = SystemColors.WindowText;
            textBox12.Location = new Point(84, 198);
            textBox12.Margin = new Padding(2);
            textBox12.MaxLength = 4;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(34, 23);
            textBox12.TabIndex = 2;
            textBox12.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(button14);
            groupBox8.Controls.Add(button15);
            groupBox8.Controls.Add(label2);
            groupBox8.Controls.Add(textBox13);
            groupBox8.Controls.Add(textBox14);
            groupBox8.Location = new Point(704, 390);
            groupBox8.Margin = new Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(2);
            groupBox8.Size = new Size(198, 326);
            groupBox8.TabIndex = 36;
            groupBox8.TabStop = false;
            // 
            // button14
            // 
            button14.Location = new Point(64, 236);
            button14.Margin = new Padding(2);
            button14.Name = "button14";
            button14.Size = new Size(33, 29);
            button14.TabIndex = 0;
            button14.Text = "▶";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(108, 236);
            button15.Margin = new Padding(2);
            button15.Name = "button15";
            button15.Size = new Size(33, 30);
            button15.TabIndex = 21;
            button15.Text = "■";
            button15.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 198);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 3;
            label2.Text = "분";
            // 
            // textBox13
            // 
            textBox13.AllowDrop = true;
            textBox13.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox13.Location = new Point(15, 57);
            textBox13.Margin = new Padding(2);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(166, 59);
            textBox13.TabIndex = 1;
            textBox13.Text = "00:00:00";
            textBox13.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            textBox14.ForeColor = SystemColors.WindowText;
            textBox14.Location = new Point(84, 198);
            textBox14.Margin = new Padding(2);
            textBox14.MaxLength = 4;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(34, 23);
            textBox14.TabIndex = 2;
            textBox14.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1779, 757);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "신갈 타이머";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label9;
        private Label label1;
        private TextBox InputTime1;
        private TextBox TimeBox1;
        private Button button1_2;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private Button button4;
        private Button button5;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox4;
        private Button button6;
        private Button button7;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private GroupBox groupBox5;
        private Button button8;
        private Button button9;
        private Label label4;
        private TextBox textBox7;
        private TextBox textBox8;
        private GroupBox groupBox6;
        private Button button10;
        private Button button11;
        private Label label8;
        private TextBox textBox9;
        private TextBox textBox10;
        private GroupBox groupBox7;
        private Button button12;
        private Button button13;
        private Label label11;
        private TextBox textBox11;
        private TextBox textBox12;
        private GroupBox groupBox8;
        private Button button14;
        private Button button15;
        private Label label2;
        private TextBox textBox13;
        private TextBox textBox14;
    }
}
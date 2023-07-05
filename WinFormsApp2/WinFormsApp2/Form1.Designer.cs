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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            label9.Location = new Point(71, 232);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 20;
            label9.Text = "(빈칸 = 60분)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 267);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 3;
            label1.Text = "분";
            label1.Click += label1_Click;
            // 
            // InputTime1
            // 
            InputTime1.ForeColor = SystemColors.WindowText;
            InputTime1.Location = new Point(108, 264);
            InputTime1.MaxLength = 4;
            InputTime1.Name = "InputTime1";
            InputTime1.Size = new Size(43, 27);
            InputTime1.TabIndex = 2;
            InputTime1.TextAlign = HorizontalAlignment.Right;
            InputTime1.TextChanged += textBox1_TextChanged;
            // 
            // TimeBox1
            // 
            TimeBox1.AllowDrop = true;
            TimeBox1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBox1.Location = new Point(19, 76);
            TimeBox1.Multiline = true;
            TimeBox1.Name = "TimeBox1";
            TimeBox1.ReadOnly = true;
            TimeBox1.Size = new Size(212, 77);
            TimeBox1.TabIndex = 1;
            TimeBox1.Text = "00:00:00";
            TimeBox1.TextAlign = HorizontalAlignment.Center;
            TimeBox1.TextChanged += TimeBox1_TextChanged;
            // 
            // button1_2
            // 
            button1_2.Location = new Point(139, 314);
            button1_2.Name = "button1_2";
            button1_2.Size = new Size(42, 40);
            button1_2.TabIndex = 21;
            button1_2.Text = "■";
            button1_2.UseVisualStyleBackColor = true;
            button1_2.Click += button1_2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(82, 314);
            button1.Name = "button1";
            button1.Size = new Size(42, 39);
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
            groupBox1.Location = new Point(30, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 434);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "첫번째 자리";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(321, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 434);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "두번째 자리";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(82, 314);
            button2.Name = "button2";
            button2.Size = new Size(42, 39);
            button2.TabIndex = 0;
            button2.Text = "▶";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(139, 314);
            button3.Name = "button3";
            button3.Size = new Size(42, 40);
            button3.TabIndex = 21;
            button3.Text = "■";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 267);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 3;
            label3.Text = "분";
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(19, 76);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(212, 77);
            textBox1.TabIndex = 1;
            textBox1.Text = "00:00:00";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(108, 264);
            textBox2.MaxLength = 4;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(43, 27);
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
            groupBox3.Location = new Point(612, 92);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(254, 434);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "세번째 자리";
            // 
            // button4
            // 
            button4.Location = new Point(82, 314);
            button4.Name = "button4";
            button4.Size = new Size(42, 39);
            button4.TabIndex = 0;
            button4.Text = "▶";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(139, 314);
            button5.Name = "button5";
            button5.Size = new Size(42, 40);
            button5.TabIndex = 21;
            button5.Text = "■";
            button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 267);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 3;
            label5.Text = "분";
            // 
            // textBox3
            // 
            textBox3.AllowDrop = true;
            textBox3.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(19, 76);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(212, 77);
            textBox3.TabIndex = 1;
            textBox3.Text = "00:00:00";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.WindowText;
            textBox4.Location = new Point(108, 264);
            textBox4.MaxLength = 4;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(43, 27);
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
            groupBox4.Location = new Point(897, 92);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(254, 434);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "네번째 자리";
            // 
            // button6
            // 
            button6.Location = new Point(82, 314);
            button6.Name = "button6";
            button6.Size = new Size(42, 39);
            button6.TabIndex = 0;
            button6.Text = "▶";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(139, 314);
            button7.Name = "button7";
            button7.Size = new Size(42, 40);
            button7.TabIndex = 21;
            button7.Text = "■";
            button7.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 267);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 3;
            label7.Text = "분";
            // 
            // textBox5
            // 
            textBox5.AllowDrop = true;
            textBox5.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(19, 76);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(212, 77);
            textBox5.TabIndex = 1;
            textBox5.Text = "00:00:00";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.WindowText;
            textBox6.Location = new Point(108, 264);
            textBox6.MaxLength = 4;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(43, 27);
            textBox6.TabIndex = 2;
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 596);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
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
    }
}
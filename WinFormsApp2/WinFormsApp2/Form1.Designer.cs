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
            timerzz1 = new System.Windows.Forms.Timer(components);
            label9 = new Label();
            label1 = new Label();
            InputTimezz1 = new TextBox();
            TimeBoxzz1 = new TextBox();
            buttonzz1_2 = new Button();
            buttonzz1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            buttonzz2_2 = new Button();
            InputTimezz2 = new TextBox();
            TimeBoxzz2 = new TextBox();
            buttonzz2 = new Button();
            label3 = new Label();
            groupBox3 = new GroupBox();
            buttonzz3 = new Button();
            buttonzz3_1 = new Button();
            label5 = new Label();
            TimeBoxzz3 = new TextBox();
            InputTimezz3 = new TextBox();
            groupBox4 = new GroupBox();
            buttonzz4 = new Button();
            buttonzz4_1 = new Button();
            label7 = new Label();
            TimeBoxzz4 = new TextBox();
            InputTimezz4 = new TextBox();
            groupBox5 = new GroupBox();
            buttonzz5 = new Button();
            buttonzz5_1 = new Button();
            label4 = new Label();
            TimeBoxzz5 = new TextBox();
            InputTimezz5 = new TextBox();
            groupBox6 = new GroupBox();
            buttonzz6 = new Button();
            buttonzz6_1 = new Button();
            label8 = new Label();
            TimeBoxzz6 = new TextBox();
            InputTimezz6 = new TextBox();
            groupBox7 = new GroupBox();
            buttonzz7 = new Button();
            buttonzz7_1 = new Button();
            label11 = new Label();
            TimeBoxzz7 = new TextBox();
            InputTimezz7 = new TextBox();
            groupBox8 = new GroupBox();
            buttonzz8 = new Button();
            buttonzz8_1 = new Button();
            label2 = new Label();
            TimeBoxzz8 = new TextBox();
            InputTimezz8 = new TextBox();
            timerzz2 = new System.Windows.Forms.Timer(components);
            timerzz3 = new System.Windows.Forms.Timer(components);
            timerzz4 = new System.Windows.Forms.Timer(components);
            timerzz5 = new System.Windows.Forms.Timer(components);
            timerzz6 = new System.Windows.Forms.Timer(components);
            timerzz7 = new System.Windows.Forms.Timer(components);
            timerzz8 = new System.Windows.Forms.Timer(components);
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
            // timerzz1
            // 
            timerzz1.Tick += timer1_Tick;
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
            // InputTimezz1
            // 
            InputTimezz1.ForeColor = SystemColors.WindowText;
            InputTimezz1.Location = new Point(84, 198);
            InputTimezz1.Margin = new Padding(2);
            InputTimezz1.MaxLength = 4;
            InputTimezz1.Name = "InputTimezz1";
            InputTimezz1.Size = new Size(34, 23);
            InputTimezz1.TabIndex = 2;
            InputTimezz1.TextAlign = HorizontalAlignment.Right;
            InputTimezz1.TextChanged += textBox1_TextChanged;
            // 
            // TimeBoxzz1
            // 
            TimeBoxzz1.AllowDrop = true;
            TimeBoxzz1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBoxzz1.Location = new Point(15, 57);
            TimeBoxzz1.Margin = new Padding(2);
            TimeBoxzz1.Multiline = true;
            TimeBoxzz1.Name = "TimeBoxzz1";
            TimeBoxzz1.ReadOnly = true;
            TimeBoxzz1.Size = new Size(166, 59);
            TimeBoxzz1.TabIndex = 1;
            TimeBoxzz1.Text = "00:00:00";
            TimeBoxzz1.TextAlign = HorizontalAlignment.Center;
            TimeBoxzz1.TextChanged += TimeBox1_TextChanged;
            // 
            // buttonzz1_2
            // 
            buttonzz1_2.Location = new Point(108, 236);
            buttonzz1_2.Margin = new Padding(2);
            buttonzz1_2.Name = "buttonzz1_2";
            buttonzz1_2.Size = new Size(33, 30);
            buttonzz1_2.TabIndex = 21;
            buttonzz1_2.Text = "■";
            buttonzz1_2.UseVisualStyleBackColor = true;
            buttonzz1_2.Click += button1_2_Click;
            // 
            // buttonzz1
            // 
            buttonzz1.Location = new Point(64, 236);
            buttonzz1.Margin = new Padding(2);
            buttonzz1.Name = "buttonzz1";
            buttonzz1.Size = new Size(33, 29);
            buttonzz1.TabIndex = 0;
            buttonzz1.Text = "▶";
            buttonzz1.UseVisualStyleBackColor = true;
            buttonzz1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonzz1);
            groupBox1.Controls.Add(buttonzz1_2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TimeBoxzz1);
            groupBox1.Controls.Add(InputTimezz1);
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
            groupBox2.Controls.Add(buttonzz2_2);
            groupBox2.Controls.Add(InputTimezz2);
            groupBox2.Controls.Add(TimeBoxzz2);
            groupBox2.Controls.Add(buttonzz2);
            groupBox2.Controls.Add(label3);
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
            // buttonzz2_2
            // 
            buttonzz2_2.Location = new Point(108, 236);
            buttonzz2_2.Margin = new Padding(2);
            buttonzz2_2.Name = "buttonzz2_2";
            buttonzz2_2.Size = new Size(33, 30);
            buttonzz2_2.TabIndex = 22;
            buttonzz2_2.Text = "■";
            buttonzz2_2.UseVisualStyleBackColor = true;
            buttonzz2_2.Click += buttonzz2_2_Click;
            // 
            // InputTimezz2
            // 
            InputTimezz2.ForeColor = SystemColors.WindowText;
            InputTimezz2.Location = new Point(84, 198);
            InputTimezz2.Margin = new Padding(2);
            InputTimezz2.MaxLength = 4;
            InputTimezz2.Name = "InputTimezz2";
            InputTimezz2.Size = new Size(34, 23);
            InputTimezz2.TabIndex = 5;
            InputTimezz2.TextAlign = HorizontalAlignment.Right;
            // 
            // TimeBoxzz2
            // 
            TimeBoxzz2.AllowDrop = true;
            TimeBoxzz2.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBoxzz2.Location = new Point(15, 57);
            TimeBoxzz2.Margin = new Padding(2);
            TimeBoxzz2.Multiline = true;
            TimeBoxzz2.Name = "TimeBoxzz2";
            TimeBoxzz2.ReadOnly = true;
            TimeBoxzz2.Size = new Size(166, 59);
            TimeBoxzz2.TabIndex = 4;
            TimeBoxzz2.Text = "00:00:00";
            TimeBoxzz2.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonzz2
            // 
            buttonzz2.Location = new Point(64, 236);
            buttonzz2.Margin = new Padding(2);
            buttonzz2.Name = "buttonzz2";
            buttonzz2.Size = new Size(33, 29);
            buttonzz2.TabIndex = 0;
            buttonzz2.Text = "▶";
            buttonzz2.UseVisualStyleBackColor = true;
            buttonzz2.Click += buttonzz2_Click;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonzz3);
            groupBox3.Controls.Add(buttonzz3_1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(TimeBoxzz3);
            groupBox3.Controls.Add(InputTimezz3);
            groupBox3.Location = new Point(476, 32);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(198, 326);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "3번 컴퓨터";
            // 
            // buttonzz3
            // 
            buttonzz3.Location = new Point(64, 236);
            buttonzz3.Margin = new Padding(2);
            buttonzz3.Name = "buttonzz3";
            buttonzz3.Size = new Size(33, 29);
            buttonzz3.TabIndex = 0;
            buttonzz3.Text = "▶";
            buttonzz3.UseVisualStyleBackColor = true;
            buttonzz3.Click += buttonzz3_Click;
            // 
            // buttonzz3_1
            // 
            buttonzz3_1.Location = new Point(108, 236);
            buttonzz3_1.Margin = new Padding(2);
            buttonzz3_1.Name = "buttonzz3_1";
            buttonzz3_1.Size = new Size(33, 30);
            buttonzz3_1.TabIndex = 21;
            buttonzz3_1.Text = "■";
            buttonzz3_1.UseVisualStyleBackColor = true;
            buttonzz3_1.Click += buttonzz3_1_Click;
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
            // TimeBoxzz3
            // 
            TimeBoxzz3.AllowDrop = true;
            TimeBoxzz3.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBoxzz3.Location = new Point(15, 57);
            TimeBoxzz3.Margin = new Padding(2);
            TimeBoxzz3.Multiline = true;
            TimeBoxzz3.Name = "TimeBoxzz3";
            TimeBoxzz3.ReadOnly = true;
            TimeBoxzz3.Size = new Size(166, 59);
            TimeBoxzz3.TabIndex = 1;
            TimeBoxzz3.Text = "00:00:00";
            TimeBoxzz3.TextAlign = HorizontalAlignment.Center;
            // 
            // InputTimezz3
            // 
            InputTimezz3.ForeColor = SystemColors.WindowText;
            InputTimezz3.Location = new Point(84, 198);
            InputTimezz3.Margin = new Padding(2);
            InputTimezz3.MaxLength = 4;
            InputTimezz3.Name = "InputTimezz3";
            InputTimezz3.Size = new Size(34, 23);
            InputTimezz3.TabIndex = 2;
            InputTimezz3.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonzz4);
            groupBox4.Controls.Add(buttonzz4_1);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(TimeBoxzz4);
            groupBox4.Controls.Add(InputTimezz4);
            groupBox4.Location = new Point(704, 32);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(198, 326);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "4번 컴퓨터";
            // 
            // buttonzz4
            // 
            buttonzz4.Location = new Point(64, 236);
            buttonzz4.Margin = new Padding(2);
            buttonzz4.Name = "buttonzz4";
            buttonzz4.Size = new Size(33, 29);
            buttonzz4.TabIndex = 0;
            buttonzz4.Text = "▶";
            buttonzz4.UseVisualStyleBackColor = true;
            buttonzz4.Click += buttonzz4_Click;
            // 
            // buttonzz4_1
            // 
            buttonzz4_1.Location = new Point(108, 236);
            buttonzz4_1.Margin = new Padding(2);
            buttonzz4_1.Name = "buttonzz4_1";
            buttonzz4_1.Size = new Size(33, 30);
            buttonzz4_1.TabIndex = 21;
            buttonzz4_1.Text = "■";
            buttonzz4_1.UseVisualStyleBackColor = true;
            buttonzz4_1.Click += buttonzz4_1_Click;
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
            // TimeBoxzz4
            // 
            TimeBoxzz4.AllowDrop = true;
            TimeBoxzz4.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBoxzz4.Location = new Point(15, 57);
            TimeBoxzz4.Margin = new Padding(2);
            TimeBoxzz4.Multiline = true;
            TimeBoxzz4.Name = "TimeBoxzz4";
            TimeBoxzz4.ReadOnly = true;
            TimeBoxzz4.Size = new Size(166, 59);
            TimeBoxzz4.TabIndex = 1;
            TimeBoxzz4.Text = "00:00:00";
            TimeBoxzz4.TextAlign = HorizontalAlignment.Center;
            // 
            // InputTimezz4
            // 
            InputTimezz4.ForeColor = SystemColors.WindowText;
            InputTimezz4.Location = new Point(84, 198);
            InputTimezz4.Margin = new Padding(2);
            InputTimezz4.MaxLength = 4;
            InputTimezz4.Name = "InputTimezz4";
            InputTimezz4.Size = new Size(34, 23);
            InputTimezz4.TabIndex = 2;
            InputTimezz4.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(buttonzz5);
            groupBox5.Controls.Add(buttonzz5_1);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(TimeBoxzz5);
            groupBox5.Controls.Add(InputTimezz5);
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
            // buttonzz5
            // 
            buttonzz5.Location = new Point(64, 236);
            buttonzz5.Margin = new Padding(2);
            buttonzz5.Name = "buttonzz5";
            buttonzz5.Size = new Size(33, 29);
            buttonzz5.TabIndex = 0;
            buttonzz5.Text = "▶";
            buttonzz5.UseVisualStyleBackColor = true;
            buttonzz5.Click += buttonzz5_Click;
            // 
            // buttonzz5_1
            // 
            buttonzz5_1.Location = new Point(108, 236);
            buttonzz5_1.Margin = new Padding(2);
            buttonzz5_1.Name = "buttonzz5_1";
            buttonzz5_1.Size = new Size(33, 30);
            buttonzz5_1.TabIndex = 21;
            buttonzz5_1.Text = "■";
            buttonzz5_1.UseVisualStyleBackColor = true;
            buttonzz5_1.Click += buttonzz5_1_Click;
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
            // TimeBoxzz5
            // 
            TimeBoxzz5.AllowDrop = true;
            TimeBoxzz5.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBoxzz5.Location = new Point(15, 57);
            TimeBoxzz5.Margin = new Padding(2);
            TimeBoxzz5.Multiline = true;
            TimeBoxzz5.Name = "TimeBoxzz5";
            TimeBoxzz5.ReadOnly = true;
            TimeBoxzz5.Size = new Size(166, 59);
            TimeBoxzz5.TabIndex = 1;
            TimeBoxzz5.Text = "00:00:00";
            TimeBoxzz5.TextAlign = HorizontalAlignment.Center;
            // 
            // InputTimezz5
            // 
            InputTimezz5.ForeColor = SystemColors.WindowText;
            InputTimezz5.Location = new Point(84, 198);
            InputTimezz5.Margin = new Padding(2);
            InputTimezz5.MaxLength = 4;
            InputTimezz5.Name = "InputTimezz5";
            InputTimezz5.Size = new Size(34, 23);
            InputTimezz5.TabIndex = 2;
            InputTimezz5.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(buttonzz6);
            groupBox6.Controls.Add(buttonzz6_1);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(TimeBoxzz6);
            groupBox6.Controls.Add(InputTimezz6);
            groupBox6.Location = new Point(250, 390);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(198, 326);
            groupBox6.TabIndex = 34;
            groupBox6.TabStop = false;
            groupBox6.Text = "노래방";
            // 
            // buttonzz6
            // 
            buttonzz6.Location = new Point(64, 236);
            buttonzz6.Margin = new Padding(2);
            buttonzz6.Name = "buttonzz6";
            buttonzz6.Size = new Size(33, 29);
            buttonzz6.TabIndex = 0;
            buttonzz6.Text = "▶";
            buttonzz6.UseVisualStyleBackColor = true;
            buttonzz6.Click += buttonzz6_Click;
            // 
            // buttonzz6_1
            // 
            buttonzz6_1.Location = new Point(108, 236);
            buttonzz6_1.Margin = new Padding(2);
            buttonzz6_1.Name = "buttonzz6_1";
            buttonzz6_1.Size = new Size(33, 30);
            buttonzz6_1.TabIndex = 21;
            buttonzz6_1.Text = "■";
            buttonzz6_1.UseVisualStyleBackColor = true;
            buttonzz6_1.Click += buttonzz6_1_Click;
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
            // TimeBoxzz6
            // 
            TimeBoxzz6.AllowDrop = true;
            TimeBoxzz6.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBoxzz6.Location = new Point(15, 57);
            TimeBoxzz6.Margin = new Padding(2);
            TimeBoxzz6.Multiline = true;
            TimeBoxzz6.Name = "TimeBoxzz6";
            TimeBoxzz6.ReadOnly = true;
            TimeBoxzz6.Size = new Size(166, 59);
            TimeBoxzz6.TabIndex = 1;
            TimeBoxzz6.Text = "00:00:00";
            TimeBoxzz6.TextAlign = HorizontalAlignment.Center;
            // 
            // InputTimezz6
            // 
            InputTimezz6.ForeColor = SystemColors.WindowText;
            InputTimezz6.Location = new Point(84, 198);
            InputTimezz6.Margin = new Padding(2);
            InputTimezz6.MaxLength = 4;
            InputTimezz6.Name = "InputTimezz6";
            InputTimezz6.Size = new Size(34, 23);
            InputTimezz6.TabIndex = 2;
            InputTimezz6.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(buttonzz7);
            groupBox7.Controls.Add(buttonzz7_1);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(TimeBoxzz7);
            groupBox7.Controls.Add(InputTimezz7);
            groupBox7.Location = new Point(476, 390);
            groupBox7.Margin = new Padding(2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(2);
            groupBox7.Size = new Size(198, 326);
            groupBox7.TabIndex = 35;
            groupBox7.TabStop = false;
            groupBox7.Text = "패드민턴";
            // 
            // buttonzz7
            // 
            buttonzz7.Location = new Point(64, 236);
            buttonzz7.Margin = new Padding(2);
            buttonzz7.Name = "buttonzz7";
            buttonzz7.Size = new Size(33, 29);
            buttonzz7.TabIndex = 0;
            buttonzz7.Text = "▶";
            buttonzz7.UseVisualStyleBackColor = true;
            buttonzz7.Click += buttonzz7_Click;
            // 
            // buttonzz7_1
            // 
            buttonzz7_1.Location = new Point(108, 236);
            buttonzz7_1.Margin = new Padding(2);
            buttonzz7_1.Name = "buttonzz7_1";
            buttonzz7_1.Size = new Size(33, 30);
            buttonzz7_1.TabIndex = 21;
            buttonzz7_1.Text = "■";
            buttonzz7_1.UseVisualStyleBackColor = true;
            buttonzz7_1.Click += buttonzz7_1_Click;
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
            // TimeBoxzz7
            // 
            TimeBoxzz7.AllowDrop = true;
            TimeBoxzz7.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBoxzz7.Location = new Point(15, 57);
            TimeBoxzz7.Margin = new Padding(2);
            TimeBoxzz7.Multiline = true;
            TimeBoxzz7.Name = "TimeBoxzz7";
            TimeBoxzz7.ReadOnly = true;
            TimeBoxzz7.Size = new Size(166, 59);
            TimeBoxzz7.TabIndex = 1;
            TimeBoxzz7.Text = "00:00:00";
            TimeBoxzz7.TextAlign = HorizontalAlignment.Center;
            // 
            // InputTimezz7
            // 
            InputTimezz7.ForeColor = SystemColors.WindowText;
            InputTimezz7.Location = new Point(84, 198);
            InputTimezz7.Margin = new Padding(2);
            InputTimezz7.MaxLength = 4;
            InputTimezz7.Name = "InputTimezz7";
            InputTimezz7.Size = new Size(34, 23);
            InputTimezz7.TabIndex = 2;
            InputTimezz7.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(buttonzz8);
            groupBox8.Controls.Add(buttonzz8_1);
            groupBox8.Controls.Add(label2);
            groupBox8.Controls.Add(TimeBoxzz8);
            groupBox8.Controls.Add(InputTimezz8);
            groupBox8.Location = new Point(704, 390);
            groupBox8.Margin = new Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(2);
            groupBox8.Size = new Size(198, 326);
            groupBox8.TabIndex = 36;
            groupBox8.TabStop = false;
            // 
            // buttonzz8
            // 
            buttonzz8.Location = new Point(64, 236);
            buttonzz8.Margin = new Padding(2);
            buttonzz8.Name = "buttonzz8";
            buttonzz8.Size = new Size(33, 29);
            buttonzz8.TabIndex = 0;
            buttonzz8.Text = "▶";
            buttonzz8.UseVisualStyleBackColor = true;
            buttonzz8.Click += buttonzz8_Click;
            // 
            // buttonzz8_1
            // 
            buttonzz8_1.Location = new Point(108, 236);
            buttonzz8_1.Margin = new Padding(2);
            buttonzz8_1.Name = "buttonzz8_1";
            buttonzz8_1.Size = new Size(33, 30);
            buttonzz8_1.TabIndex = 21;
            buttonzz8_1.Text = "■";
            buttonzz8_1.UseVisualStyleBackColor = true;
            buttonzz8_1.Click += buttonzz8_1_Click;
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
            // TimeBoxzz8
            // 
            TimeBoxzz8.AllowDrop = true;
            TimeBoxzz8.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeBoxzz8.Location = new Point(15, 57);
            TimeBoxzz8.Margin = new Padding(2);
            TimeBoxzz8.Multiline = true;
            TimeBoxzz8.Name = "TimeBoxzz8";
            TimeBoxzz8.ReadOnly = true;
            TimeBoxzz8.Size = new Size(166, 59);
            TimeBoxzz8.TabIndex = 1;
            TimeBoxzz8.Text = "00:00:00";
            TimeBoxzz8.TextAlign = HorizontalAlignment.Center;
            // 
            // InputTimezz8
            // 
            InputTimezz8.ForeColor = SystemColors.WindowText;
            InputTimezz8.Location = new Point(84, 198);
            InputTimezz8.Margin = new Padding(2);
            InputTimezz8.MaxLength = 4;
            InputTimezz8.Name = "InputTimezz8";
            InputTimezz8.Size = new Size(34, 23);
            InputTimezz8.TabIndex = 2;
            InputTimezz8.TextAlign = HorizontalAlignment.Right;
            // 
            // timerzz2
            // 
            timerzz2.Tick += timerzz2_Tick;
            // 
            // timerzz3
            // 
            timerzz3.Tick += timerzz3_Tick;
            // 
            // timerzz4
            // 
            timerzz4.Tick += timerzz4_Tick;
            // 
            // timerzz5
            // 
            timerzz5.Tick += timerzz5_Tick;
            // 
            // timerzz6
            // 
            timerzz6.Tick += timerzz6_Tick;
            // 
            // timerzz7
            // 
            timerzz7.Tick += timerzz7_Tick;
            // 
            // timerzz8
            // 
            timerzz8.Tick += timerzz8_Tick;
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
        private System.Windows.Forms.Timer timerzz1;
        private Label label9;
        private Label label1;
        private TextBox InputTimezz1;
        private TextBox TimeBoxzz1;
        private Button buttonzz1_2;
        private Button buttonzz1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonzz2;
        private Label label3;
        private GroupBox groupBox3;
        private Button buttonzz3;
        private Button buttonzz3_1;
        private Label label5;
        private TextBox TimeBoxzz3;
        private TextBox InputTimezz3;
        private GroupBox groupBox4;
        private Button buttonzz4;
        private Button buttonzz4_1;
        private Label label7;
        private TextBox TimeBoxzz4;
        private TextBox InputTimezz4;
        private GroupBox groupBox5;
        private Button buttonzz5;
        private Button buttonzz5_1;
        private Label label4;
        private TextBox TimeBoxzz5;
        private TextBox InputTimezz5;
        private GroupBox groupBox6;
        private Button buttonzz6;
        private Button buttonzz6_1;
        private Label label8;
        private TextBox TimeBoxzz6;
        private TextBox InputTimezz6;
        private GroupBox groupBox7;
        private Button buttonzz7;
        private Button buttonzz7_1;
        private Label label11;
        private TextBox TimeBoxzz7;
        private TextBox InputTimezz7;
        private GroupBox groupBox8;
        private Button buttonzz8;
        private Button buttonzz8_1;
        private Label label2;
        private TextBox TimeBoxzz8;
        private TextBox InputTimezz8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timerzz2;
        private System.Windows.Forms.Timer timerzz3;
        private System.Windows.Forms.Timer timerzz4;
        private System.Windows.Forms.Timer timerzz5;
        private System.Windows.Forms.Timer timerzz6;
        private System.Windows.Forms.Timer timerzz7;
        private System.Windows.Forms.Timer timerzz8;
        private Button buttonzz2_2;
        private TextBox InputTimezz2;
        private TextBox TimeBoxzz2;
    }
}
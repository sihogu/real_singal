using System;
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        int flag1 = 1;
        DateTime now;
        DateTime dt;
        TimeSpan ts;
        TimeSpan dtt;
        bool flag1_2 = false;
        string tt = "";

       

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            InputTime1.Text = "60";

        }
        

        private void TimeBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (flag1 == 1)
            {
                if (InputTime1.Text == "")
                {
                    now = DateTime.Now.AddMinutes(60);
                }
                else
                {
                    now = DateTime.Now.AddMinutes(Int32.Parse(InputTime1.Text));
                }


                timer1.Start();
                button1.Text = "=";



                flag1 = 2;

            }

            else if (flag1 == 2)
            {



                timer1.Stop();

                button1.Text = "��";

                flag1 = 3;

            }
            else if (flag1 == 3)
            {



                //���� ������ ����
                flag1 = 4;
                flag1_2 = true;

                dt = DateTime.Now.AddMinutes(Int32.Parse(ts.ToString("mm"))).AddHours(Int32.Parse(ts.ToString("hh"))).AddSeconds(Int32.Parse(ts.ToString("ss")));
                timer1.Start();
                button1.Text = "=";
            }
            else if (flag1 == 4)
            {
                timer1.Stop();

                button1.Text = "��";

                flag1 = 5;

            }
            else if (flag1 == 5)
            {



                //���� ������ ����
                flag1 = 4;

                dt = DateTime.Now.AddMinutes(Int32.Parse(dtt.ToString("mm"))).AddHours(Int32.Parse(dtt.ToString("hh"))).AddSeconds(Int32.Parse(dtt.ToString("ss")));
                timer1.Start();
                button1.Text = "=";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (flag1_2 == false)
            {
                //�Է��Ѱ��� Ÿ�̸� �ð��̵�

                ts = now - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                tt = String.Format("{0}", ts.ToString("hh':'mm':'ss"));
            }
            else if (flag1_2 == true)
            {

                //�Ͻ����� Ÿ�̸� �ð��� �ٽ� ���۵�
                dtt = dt - DateTime.Now;

                tt = String.Format("{0}", dtt.ToString("hh':'mm':'ss"));
            }

            TimeBox1.Text = tt;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
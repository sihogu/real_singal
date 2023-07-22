using System;
using System.Diagnostics.Eventing.Reader;
using System.Media;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int flag1 = 1;
        bool flag1_2 = false;
        DateTime now1;
        DateTime dt1;
        TimeSpan ts1;
        TimeSpan dtt1;
        string tt1 = "";

        int flag2 = 1;
        bool flag2_2 = false;
        DateTime now2;
        DateTime dt2;
        TimeSpan ts2;
        TimeSpan dtt2;
        string tt2 = "";

        int flag3 = 1;
        bool flag3_2 = false;
        DateTime now3;
        DateTime dt3;
        TimeSpan ts3;
        TimeSpan dtt3;
        string tt3 = "";

        int flag4 = 1;
        bool flag4_2 = false;
        DateTime now4;
        DateTime dt4;
        TimeSpan ts4;
        TimeSpan dtt4;
        string tt4 = "";

        int flag5 = 1;
        bool flag5_2 = false;
        DateTime now5;
        DateTime dt5;
        TimeSpan ts5;
        TimeSpan dtt5;
        string tt5 = "";

        int flag6 = 1;
        bool flag6_2 = false;
        DateTime now6;
        DateTime dt6;
        TimeSpan ts6;
        TimeSpan dtt6;
        string tt6 = "";

        int flag7 = 1;
        bool flag7_2 = false;
        DateTime now7;
        DateTime dt7;
        TimeSpan ts7;
        TimeSpan dtt7;
        string tt7 = "";

        int flag8 = 1;
        bool flag8_2 = false;
        DateTime now8;
        DateTime dt8;
        TimeSpan ts8;
        TimeSpan dtt8;
        string tt8 = "";


        private void Form1_Load(object sender, EventArgs e)
        {


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
                    now1 = DateTime.Now.AddMinutes(60);

                }
                else
                {
                    now1 = DateTime.Now.AddMinutes(Int32.Parse(InputTime1.Text));

                }


                timer1.Start();
                button1.Text = "❚❚";



                flag1 = 2;

            }

            else if (flag1 == 2)
            {



                timer1.Stop();

                button1.Text = "▶";

                flag1 = 3;

            }
            else if (flag1 == 3)
            {
                //현재 값에서 시작
                flag1 = 4;
                flag1_2 = true;

                dt1 = DateTime.Now.AddMinutes(Int32.Parse(ts1.ToString("mm"))).AddHours(Int32.Parse(ts1.ToString("hh"))).AddSeconds(Int32.Parse(ts1.ToString("ss")));
                timer1.Start();
                button1.Text = "=";
            }
            else if (flag1 == 4)
            {
                timer1.Stop();

                button1.Text = "▶";

                flag1 = 5;

            }
            else if (flag1 == 5)
            {
                //현재 값에서 시작
                flag1 = 4;

                dt1 = DateTime.Now.AddMinutes(Int32.Parse(dtt1.ToString("mm"))).AddHours(Int32.Parse(dtt1.ToString("hh"))).AddSeconds(Int32.Parse(dtt1.ToString("ss")));
                timer1.Start();
                button1.Text = "=";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (TimeBox1.Text == "00:00:01")
            {
                SystemSounds.Beep.Play();

                button1.Text = "▶";
                //TimeBox1.Text = "시간 종료"; //왜 작동을 안하지?
                
                InputTime1.Text = "";

                flag1 = 1;
                flag1_2 = false;

                timer1.Stop();

            }

            else if (flag1_2 == false)
            {
                //입력한값이 타이머 시간이됨

                ts1 = now1 - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                tt1 = String.Format("{0}", ts1.ToString("hh':'mm':'ss"));
            }
            else if (flag1_2 == true)
            {

                //일시정지 타이머 시간이 다시 시작됨
                dtt1 = dt1 - DateTime.Now;

                tt1 = String.Format("{0}", dtt1.ToString("hh':'mm':'ss"));
            }

            TimeBox1.Text = tt1;



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

        private void button1_2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            button1.Text = "▶";
            TimeBox1.Text = "00:00:00";
            InputTime1.Text = "";

            flag1 = 1;
            flag1_2 = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
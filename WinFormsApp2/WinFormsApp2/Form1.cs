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

        int flagzz1 = 1;
        bool flagzz1_2 = false;
        DateTime nowzz1;
        DateTime dtzz1;
        TimeSpan tszz1;
        TimeSpan dttzz1;
        string ttzz1 = "";

        int flagzz2 = 1;
        bool flagzz2_2 = false;
        DateTime nowzz2;
        DateTime dtzz2;
        TimeSpan tszz2;
        TimeSpan dttzz2;
        string ttzz2 = "";

        int flagzz3 = 1;
        bool flagzz3_2 = false;
        DateTime nowzz3;
        DateTime dtzz3;
        TimeSpan tszz3;
        TimeSpan dttzz3;
        string ttzz3 = "";

        int flagzz4 = 1;
        bool flagzz4_2 = false;
        DateTime nowzz4;
        DateTime dtzz4;
        TimeSpan tszz4;
        TimeSpan dttzz4;
        string ttzz4 = "";

        int flagzz5 = 1;
        bool flagzz5_2 = false;
        DateTime nowzz5;
        DateTime dtzz5;
        TimeSpan tszz5;
        TimeSpan dttzz5;
        string ttzz5 = "";

        int flagzz6 = 1;
        bool flagzz6_2 = false;
        DateTime nowzz6;
        DateTime dtzz6;
        TimeSpan tszz6;
        TimeSpan dttzz6;
        string ttzz6 = "";

        int flagzz7 = 1;
        bool flagzz7_2 = false;
        DateTime nowzz7;
        DateTime dtzz7;
        TimeSpan tszz7;
        TimeSpan dttzz7;
        string ttzz7 = "";

        int flagzz8 = 1;
        bool flagzz8_2 = false;
        DateTime nowzz8;
        DateTime dtzz8;
        TimeSpan tszz8;
        TimeSpan dttzz8;
        string ttzz8 = "";


        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void TimeBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// 1번 컴퓨터 타이머
        private void button1_Click(object sender, EventArgs e)
        {


            if (flagzz1 == 1)
            {
                if (InputTimezz1.Text == "")
                {
                    nowzz1 = DateTime.Now.AddMinutes(60);

                }
                else
                {
                    nowzz1 = DateTime.Now.AddMinutes(Int32.Parse(InputTimezz1.Text));

                }


                timerzz1.Start();
                buttonzz1.Text = "❚❚";



                flagzz1 = 2;

            }

            else if (flagzz1 == 2)
            {



                timerzz1.Stop();

                buttonzz1.Text = "▶";

                flagzz1 = 3;

            }
            else if (flagzz1 == 3)
            {
                //현재 값에서 시작
                flagzz1 = 4;
                flagzz1_2 = true;

                dtzz1 = DateTime.Now.AddMinutes(Int32.Parse(tszz1.ToString("mm"))).AddHours(Int32.Parse(tszz1.ToString("hh"))).AddSeconds(Int32.Parse(tszz1.ToString("ss")));
                timerzz1.Start();
                buttonzz1.Text = "=";
            }
            else if (flagzz1 == 4)
            {
                timerzz1.Stop();

                buttonzz1.Text = "▶";

                flagzz1 = 5;

            }
            else if (flagzz1 == 5)
            {
                //현재 값에서 시작
                flagzz1 = 4;

                dtzz1 = DateTime.Now.AddMinutes(Int32.Parse(dttzz1.ToString("mm"))).AddHours(Int32.Parse(dttzz1.ToString("hh"))).AddSeconds(Int32.Parse(dttzz1.ToString("ss")));
                timerzz1.Start();
                buttonzz1.Text = "=";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (TimeBoxzz1.Text == "00:00:01")
            {
                SystemSounds.Beep.Play();

                buttonzz1.Text = "▶";
                //TimeBox1.Text = "시간 종료"; //왜 작동을 안하지?

                InputTimezz1.Text = "";

                flagzz1 = 1;
                flagzz1_2 = false;

                timerzz1.Stop();

            }

            else if (flagzz1_2 == false)
            {
                //입력한값이 타이머 시간이됨

                tszz1 = nowzz1 - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                ttzz1 = String.Format("{0}", tszz1.ToString("hh':'mm':'ss"));
            }
            else if (flagzz1_2 == true)
            {

                //일시정지 타이머 시간이 다시 시작됨
                dttzz1 = dtzz1 - DateTime.Now;

                ttzz1 = String.Format("{0}", dttzz1.ToString("hh':'mm':'ss"));
            }

            TimeBoxzz1.Text = ttzz1;



        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            timerzz1.Stop();

            buttonzz1.Text = "▶";
            TimeBoxzz1.Text = "00:00:00";
            InputTimezz1.Text = "";

            flagzz1 = 1;
            flagzz1_2 = false;
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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        /// 2번 컴퓨터 타이머
        private void buttonzz2_Click(object sender, EventArgs e)
        {
            if (flagzz2 == 1)
            {
                if (InputTimezz2.Text == "")
                {
                    nowzz2 = DateTime.Now.AddMinutes(60);

                }
                else
                {
                    nowzz2 = DateTime.Now.AddMinutes(Int32.Parse(InputTimezz2.Text));

                }


                timerzz2.Start();
                buttonzz2.Text = "❚❚";



                flagzz2 = 2;

            }

            else if (flagzz2 == 2)
            {



                timerzz2.Stop();

                buttonzz2.Text = "▶";

                flagzz2 = 3;

            }
            else if (flagzz2 == 3)
            {
                //현재 값에서 시작
                flagzz2 = 4;
                flagzz2_2 = true;

                dtzz2 = DateTime.Now.AddMinutes(Int32.Parse(tszz2.ToString("mm"))).AddHours(Int32.Parse(tszz2.ToString("hh"))).AddSeconds(Int32.Parse(tszz2.ToString("ss")));
                timerzz2.Start();
                buttonzz2.Text = "=";
            }
            else if (flagzz2 == 4)
            {
                timerzz2.Stop();

                buttonzz2.Text = "▶";

                flagzz2 = 5;

            }
            else if (flagzz2 == 5)
            {
                //현재 값에서 시작
                flagzz2 = 4;

                dtzz2 = DateTime.Now.AddMinutes(Int32.Parse(dttzz2.ToString("mm"))).AddHours(Int32.Parse(dttzz2.ToString("hh"))).AddSeconds(Int32.Parse(dttzz2.ToString("ss")));
                timerzz2.Start();
                buttonzz2.Text = "=";
            }
        }

        private void buttonzz2_2_Click(object sender, EventArgs e)
        {
            timerzz2.Stop();

            buttonzz2.Text = "▶";
            TimeBoxzz2.Text = "00:00:00";
            InputTimezz2.Text = "";

            flagzz2 = 1;
            flagzz2_2 = false;
        }

        private void timerzz2_Tick(object sender, EventArgs e)
        {
            if (TimeBoxzz2.Text == "00:00:01")
            {
                SystemSounds.Beep.Play();

                buttonzz2.Text = "▶";
                //TimeBox1.Text = "시간 종료"; //왜 작동을 안하지?

                InputTimezz2.Text = "";

                flagzz2 = 1;
                flagzz2_2 = false;

                timerzz2.Stop();

            }

            else if (flagzz2_2 == false)
            {
                //입력한값이 타이머 시간이됨

                tszz2 = nowzz2 - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                ttzz2 = String.Format("{0}", tszz2.ToString("hh':'mm':'ss"));
            }
            else if (flagzz2_2 == true)
            {

                //일시정지 타이머 시간이 다시 시작됨
                dttzz2 = dtzz2 - DateTime.Now;

                ttzz2 = String.Format("{0}", dttzz2.ToString("hh':'mm':'ss"));
            }

            TimeBoxzz2.Text = ttzz2;
        }

        /// 3번타이머
        private void buttonzz3_Click(object sender, EventArgs e)
        {
            if (flagzz3 == 1)
            {
                if (InputTimezz3.Text == "")
                {
                    nowzz3 = DateTime.Now.AddMinutes(60);

                }
                else
                {
                    nowzz3 = DateTime.Now.AddMinutes(Int32.Parse(InputTimezz3.Text));

                }


                timerzz3.Start();
                buttonzz3.Text = "❚❚";



                flagzz3 = 2;

            }

            else if (flagzz3 == 2)
            {



                timerzz3.Stop();

                buttonzz3.Text = "▶";

                flagzz3 = 3;

            }
            else if (flagzz3 == 3)
            {
                //현재 값에서 시작
                flagzz3 = 4;
                flagzz3_2 = true;

                dtzz3 = DateTime.Now.AddMinutes(Int32.Parse(tszz3.ToString("mm"))).AddHours(Int32.Parse(tszz3.ToString("hh"))).AddSeconds(Int32.Parse(tszz3.ToString("ss")));
                timerzz3.Start();
                buttonzz3.Text = "=";
            }
            else if (flagzz3 == 4)
            {
                timerzz3.Stop();

                buttonzz3.Text = "▶";

                flagzz3 = 5;

            }
            else if (flagzz3 == 5)
            {
                //현재 값에서 시작
                flagzz3 = 4;

                dtzz3 = DateTime.Now.AddMinutes(Int32.Parse(dttzz3.ToString("mm"))).AddHours(Int32.Parse(dttzz3.ToString("hh"))).AddSeconds(Int32.Parse(dttzz3.ToString("ss")));
                timerzz3.Start();
                buttonzz3.Text = "=";
            }
        }

        private void buttonzz3_1_Click(object sender, EventArgs e)
        {
            timerzz3.Stop();

            buttonzz3.Text = "▶";
            TimeBoxzz3.Text = "00:00:00";
            InputTimezz3.Text = "";

            flagzz3 = 1;
            flagzz3_2 = false;
        }

        private void timerzz3_Tick(object sender, EventArgs e)
        {
            if (TimeBoxzz3.Text == "00:00:01")
            {
                SystemSounds.Beep.Play();

                buttonzz3.Text = "▶";
                //TimeBox1.Text = "시간 종료"; //왜 작동을 안하지?

                InputTimezz3.Text = "";

                flagzz3 = 1;
                flagzz3_2 = false;

                timerzz3.Stop();

            }

            else if (flagzz3_2 == false)
            {
                //입력한값이 타이머 시간이됨

                tszz3 = nowzz3 - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                ttzz3 = String.Format("{0}", tszz3.ToString("hh':'mm':'ss"));
            }
            else if (flagzz3_2 == true)
            {

                //일시정지 타이머 시간이 다시 시작됨
                dttzz3 = dtzz3 - DateTime.Now;

                ttzz3 = String.Format("{0}", dttzz3.ToString("hh':'mm':'ss"));
            }

            TimeBoxzz3.Text = ttzz3;
        }

        /// 4번 컴퓨터
        private void buttonzz4_Click(object sender, EventArgs e)
        {
            if (flagzz4 == 1)
            {
                if (InputTimezz4.Text == "")
                {
                    nowzz4 = DateTime.Now.AddMinutes(60);

                }
                else
                {
                    nowzz4 = DateTime.Now.AddMinutes(Int32.Parse(InputTimezz4.Text));

                }


                timerzz4.Start();
                buttonzz4.Text = "❚❚";



                flagzz4 = 2;

            }

            else if (flagzz4 == 2)
            {



                timerzz4.Stop();

                buttonzz4.Text = "▶";

                flagzz4 = 3;

            }
            else if (flagzz4 == 3)
            {
                //현재 값에서 시작
                flagzz4 = 4;
                flagzz4_2 = true;

                dtzz4 = DateTime.Now.AddMinutes(Int32.Parse(tszz4.ToString("mm"))).AddHours(Int32.Parse(tszz4.ToString("hh"))).AddSeconds(Int32.Parse(tszz4.ToString("ss")));
                timerzz4.Start();
                buttonzz4.Text = "=";
            }
            else if (flagzz4 == 4)
            {
                timerzz4.Stop();

                buttonzz4.Text = "▶";

                flagzz4 = 5;

            }
            else if (flagzz4 == 5)
            {
                //현재 값에서 시작
                flagzz4 = 4;

                dtzz4 = DateTime.Now.AddMinutes(Int32.Parse(dttzz4.ToString("mm"))).AddHours(Int32.Parse(dttzz4.ToString("hh"))).AddSeconds(Int32.Parse(dttzz4.ToString("ss")));
                timerzz4.Start();
                buttonzz4.Text = "=";
            }
        }

        private void buttonzz4_1_Click(object sender, EventArgs e)
        {
            timerzz4.Stop();

            buttonzz4.Text = "▶";
            TimeBoxzz4.Text = "00:00:00";
            InputTimezz4.Text = "";

            flagzz4 = 1;
            flagzz4_2 = false;
        }

        private void timerzz4_Tick(object sender, EventArgs e)
        {
            if (TimeBoxzz4.Text == "00:00:01")
            {
                SystemSounds.Beep.Play();

                buttonzz4.Text = "▶";
                //TimeBox1.Text = "시간 종료"; //왜 작동을 안하지?

                InputTimezz4.Text = "";

                flagzz4 = 1;
                flagzz4_2 = false;

                timerzz4.Stop();

            }

            else if (flagzz4_2 == false)
            {
                //입력한값이 타이머 시간이됨

                tszz4 = nowzz4 - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                ttzz4 = String.Format("{0}", tszz4.ToString("hh':'mm':'ss"));
            }
            else if (flagzz4_2 == true)
            {

                //일시정지 타이머 시간이 다시 시작됨
                dttzz4 = dtzz4 - DateTime.Now;

                ttzz4 = String.Format("{0}", dttzz4.ToString("hh':'mm':'ss"));
            }

            TimeBoxzz4.Text = ttzz4;
        }
        ///닌텐도
        private void buttonzz5_Click(object sender, EventArgs e)
        {
            if (flagzz5 == 1)
            {
                if (InputTimezz5.Text == "")
                {
                    nowzz5 = DateTime.Now.AddMinutes(60);

                }
                else
                {
                    nowzz5 = DateTime.Now.AddMinutes(Int32.Parse(InputTimezz5.Text));

                }


                timerzz5.Start();
                buttonzz5.Text = "❚❚";



                flagzz5 = 2;

            }

            else if (flagzz5 == 2)
            {



                timerzz5.Stop();

                buttonzz5.Text = "▶";

                flagzz5 = 3;

            }
            else if (flagzz5 == 3)
            {
                //현재 값에서 시작
                flagzz5 = 4;
                flagzz5_2 = true;

                dtzz5 = DateTime.Now.AddMinutes(Int32.Parse(tszz5.ToString("mm"))).AddHours(Int32.Parse(tszz5.ToString("hh"))).AddSeconds(Int32.Parse(tszz5.ToString("ss")));
                timerzz5.Start();
                buttonzz5.Text = "=";
            }
            else if (flagzz5 == 4)
            {
                timerzz5.Stop();

                buttonzz5.Text = "▶";

                flagzz5 = 5;

            }
            else if (flagzz5 == 5)
            {
                //현재 값에서 시작
                flagzz5 = 4;

                dtzz5 = DateTime.Now.AddMinutes(Int32.Parse(dttzz5.ToString("mm"))).AddHours(Int32.Parse(dttzz5.ToString("hh"))).AddSeconds(Int32.Parse(dttzz5.ToString("ss")));
                timerzz5.Start();
                buttonzz5.Text = "=";
            }
        }

        private void buttonzz5_1_Click(object sender, EventArgs e)
        {
            timerzz5.Stop();

            buttonzz5.Text = "▶";
            TimeBoxzz5.Text = "00:00:00";
            InputTimezz5.Text = "";

            flagzz5 = 1;
            flagzz5_2 = false;
        }

        private void timerzz5_Tick(object sender, EventArgs e)
        {
            if (TimeBoxzz5.Text == "00:00:01")
            {
                SystemSounds.Beep.Play();

                buttonzz5.Text = "▶";
                //TimeBox1.Text = "시간 종료"; //왜 작동을 안하지?

                InputTimezz5.Text = "";

                flagzz5 = 1;
                flagzz5_2 = false;

                timerzz5.Stop();

            }

            else if (flagzz5_2 == false)
            {
                //입력한값이 타이머 시간이됨

                tszz5 = nowzz5 - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                ttzz5 = String.Format("{0}", tszz5.ToString("hh':'mm':'ss"));
            }
            else if (flagzz5_2 == true)
            {

                //일시정지 타이머 시간이 다시 시작됨
                dttzz5 = dtzz5 - DateTime.Now;

                ttzz5 = String.Format("{0}", dttzz5.ToString("hh':'mm':'ss"));
            }

            TimeBoxzz5.Text = ttzz5;
        }
        ///노래방
        private void buttonzz6_Click(object sender, EventArgs e)
        {
            if (flagzz6 == 1)
            {
                if (InputTimezz6.Text == "")
                {
                    nowzz6 = DateTime.Now.AddMinutes(60);

                }
                else
                {
                    nowzz6 = DateTime.Now.AddMinutes(Int32.Parse(InputTimezz6.Text));

                }


                timerzz6.Start();
                buttonzz6.Text = "❚❚";



                flagzz6 = 2;

            }

            else if (flagzz6 == 2)
            {



                timerzz6.Stop();

                buttonzz6.Text = "▶";

                flagzz6 = 3;

            }
            else if (flagzz6 == 3)
            {
                //현재 값에서 시작
                flagzz6 = 4;
                flagzz6_2 = true;

                dtzz6 = DateTime.Now.AddMinutes(Int32.Parse(tszz6.ToString("mm"))).AddHours(Int32.Parse(tszz6.ToString("hh"))).AddSeconds(Int32.Parse(tszz6.ToString("ss")));
                timerzz6.Start();
                buttonzz6.Text = "=";
            }
            else if (flagzz6 == 4)
            {
                timerzz6.Stop();

                buttonzz6.Text = "▶";

                flagzz6 = 5;

            }
            else if (flagzz6 == 5)
            {
                //현재 값에서 시작
                flagzz6 = 4;

                dtzz6 = DateTime.Now.AddMinutes(Int32.Parse(dttzz6.ToString("mm"))).AddHours(Int32.Parse(dttzz6.ToString("hh"))).AddSeconds(Int32.Parse(dttzz6.ToString("ss")));
                timerzz6.Start();
                buttonzz6.Text = "=";
            }
        }

        private void buttonzz6_1_Click(object sender, EventArgs e)
        {
            timerzz6.Stop();

            buttonzz6.Text = "▶";
            TimeBoxzz6.Text = "00:00:00";
            InputTimezz6.Text = "";

            flagzz6 = 1;
            flagzz6_2 = false;
        }

        private void timerzz6_Tick(object sender, EventArgs e)
        {
            if (TimeBoxzz6.Text == "00:00:01")
            {
                SystemSounds.Beep.Play();

                buttonzz6.Text = "▶";
                //TimeBox1.Text = "시간 종료"; //왜 작동을 안하지?

                InputTimezz6.Text = "";

                flagzz6 = 1;
                flagzz6_2 = false;

                timerzz6.Stop();

            }

            else if (flagzz6_2 == false)
            {
                //입력한값이 타이머 시간이됨

                tszz6 = nowzz6 - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                ttzz6 = String.Format("{0}", tszz6.ToString("hh':'mm':'ss"));
            }
            else if (flagzz6_2 == true)
            {

                //일시정지 타이머 시간이 다시 시작됨
                dttzz6 = dtzz6 - DateTime.Now;

                ttzz6 = String.Format("{0}", dttzz6.ToString("hh':'mm':'ss"));
            }

            TimeBoxzz6.Text = ttzz6;
        }

        ///패드민턴
        private void buttonzz7_Click(object sender, EventArgs e)
        {
            if (flagzz7 == 1)
            {
                if (InputTimezz7.Text == "")
                {
                    nowzz7 = DateTime.Now.AddMinutes(60);

                }
                else
                {
                    nowzz7 = DateTime.Now.AddMinutes(Int32.Parse(InputTimezz7.Text));

                }


                timerzz7.Start();
                buttonzz7.Text = "❚❚";



                flagzz7 = 2;

            }

            else if (flagzz7 == 2)
            {



                timerzz7.Stop();

                buttonzz7.Text = "▶";

                flagzz7 = 3;

            }
            else if (flagzz7 == 3)
            {
                //현재 값에서 시작
                flagzz7 = 4;
                flagzz7_2 = true;

                dtzz7 = DateTime.Now.AddMinutes(Int32.Parse(tszz7.ToString("mm"))).AddHours(Int32.Parse(tszz7.ToString("hh"))).AddSeconds(Int32.Parse(tszz7.ToString("ss")));
                timerzz7.Start();
                buttonzz7.Text = "=";
            }
            else if (flagzz7 == 4)
            {
                timerzz7.Stop();

                buttonzz7.Text = "▶";

                flagzz7 = 5;

            }
            else if (flagzz7 == 5)
            {
                //현재 값에서 시작
                flagzz7 = 4;

                dtzz7 = DateTime.Now.AddMinutes(Int32.Parse(dttzz7.ToString("mm"))).AddHours(Int32.Parse(dttzz7.ToString("hh"))).AddSeconds(Int32.Parse(dttzz7.ToString("ss")));
                timerzz7.Start();
                buttonzz7.Text = "=";
            }
        }
        private void buttonzz7_1_Click(object sender, EventArgs e)
        {
            timerzz7.Stop();

            buttonzz7.Text = "▶";
            TimeBoxzz7.Text = "00:00:00";
            InputTimezz7.Text = "";

            flagzz7 = 1;
            flagzz7_2 = false;
        }

        private void timerzz7_Tick(object sender, EventArgs e)
        {
            if (TimeBoxzz7.Text == "00:00:01")
            {
                SystemSounds.Beep.Play();

                buttonzz7.Text = "▶";
                //TimeBox1.Text = "시간 종료"; //왜 작동을 안하지?

                InputTimezz7.Text = "";

                flagzz7 = 1;
                flagzz7_2 = false;

                timerzz7.Stop();

            }

            else if (flagzz7_2 == false)
            {
                //입력한값이 타이머 시간이됨

                tszz7 = nowzz7 - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                ttzz7 = String.Format("{0}", tszz7.ToString("hh':'mm':'ss"));
            }
            else if (flagzz7_2 == true)
            {

                //일시정지 타이머 시간이 다시 시작됨
                dttzz7 = dtzz7 - DateTime.Now;

                ttzz7 = String.Format("{0}", dttzz7.ToString("hh':'mm':'ss"));
            }

            TimeBoxzz7.Text = ttzz7;
        }

        ///기타
        private void buttonzz8_Click(object sender, EventArgs e)
        {
            if (flagzz8 == 1)
            {
                if (InputTimezz8.Text == "")
                {
                    nowzz8 = DateTime.Now.AddMinutes(60);

                }
                else
                {
                    nowzz8 = DateTime.Now.AddMinutes(Int32.Parse(InputTimezz8.Text));

                }


                timerzz8.Start();
                buttonzz8.Text = "❚❚";



                flagzz8 = 2;

            }

            else if (flagzz8 == 2)
            {



                timerzz8.Stop();

                buttonzz8.Text = "▶";

                flagzz8 = 3;

            }
            else if (flagzz8 == 3)
            {
                //현재 값에서 시작
                flagzz8 = 4;
                flagzz8_2 = true;

                dtzz8 = DateTime.Now.AddMinutes(Int32.Parse(tszz8.ToString("mm"))).AddHours(Int32.Parse(tszz8.ToString("hh"))).AddSeconds(Int32.Parse(tszz8.ToString("ss")));
                timerzz8.Start();
                buttonzz8.Text = "=";
            }
            else if (flagzz8 == 4)
            {
                timerzz8.Stop();

                buttonzz8.Text = "▶";

                flagzz8 = 5;

            }
            else if (flagzz8 == 5)
            {
                //현재 값에서 시작
                flagzz8 = 4;

                dtzz8 = DateTime.Now.AddMinutes(Int32.Parse(dttzz8.ToString("mm"))).AddHours(Int32.Parse(dttzz8.ToString("hh"))).AddSeconds(Int32.Parse(dttzz8.ToString("ss")));
                timerzz8.Start();
                buttonzz8.Text = "=";
            }
        }

        private void buttonzz8_1_Click(object sender, EventArgs e)
        {
            timerzz8.Stop();

            buttonzz8.Text = "▶";
            TimeBoxzz8.Text = "00:00:00";
            InputTimezz8.Text = "";

            flagzz8 = 1;
            flagzz8_2 = false;
        }

        private void timerzz8_Tick(object sender, EventArgs e)
        {
            if (TimeBoxzz8.Text == "00:00:01")
            {
                SystemSounds.Beep.Play();

                buttonzz8.Text = "▶";
                //TimeBox1.Text = "시간 종료"; //왜 작동을 안하지?

                InputTimezz8.Text = "";

                flagzz8 = 1;
                flagzz8_2 = false;

                timerzz8.Stop();

            }

            else if (flagzz8_2 == false)
            {
                //입력한값이 타이머 시간이됨

                tszz8 = nowzz8 - DateTime.Now;
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
                //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));

                ttzz8 = String.Format("{0}", tszz8.ToString("hh':'mm':'ss"));
            }
            else if (flagzz8_2 == true)
            {

                //일시정지 타이머 시간이 다시 시작됨
                dttzz8 = dtzz8 - DateTime.Now;

                ttzz8 = String.Format("{0}", dttzz8.ToString("hh':'mm':'ss"));
            }

            TimeBoxzz8.Text = ttzz8;
        }
    }

}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Internet_Cafe_front
{
    public partial class computer : Form
    {

        System.Timers.Timer timer;
        int h, m, s;
        MySqlConnection conn = loginForm.databaseConnection();
        loginForm loginForm = new loginForm();
        ticketCheck ticketForm = new ticketCheck();
        public computer()
        {
            InitializeComponent();
        }

        private string getRemainingTimeTicket(int ticketID)
        {
            string sql1 = $"SELECT remaining FROM ticket WHERE id = '{ticketID}'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            string remaining = "";

            while (reader.Read())
            {
                remaining = reader.GetString("remaining");
            }

            conn.Close();

            return remaining;
        }

        private string getRemainingTime()
        {
            DateTime dateNow = Convert.ToDateTime(DateTime.Now);
            DateTime startTime = Convert.ToDateTime(ticketCheck.dateGlobal);
            DateTime timeRemaining = Convert.ToDateTime(getTime()[2]); ;
            TimeSpan timeUsed = dateNow.Subtract(startTime);
            DateTime timeUsedCon = dateNow.Date + timeUsed;
            TimeSpan remaining = timeRemaining.Subtract(timeUsedCon);
            DateTime remainTimeCvt = dateNow.Date + remaining;
            string remainTime = remainTimeCvt.ToString("HH:mm:ss");

            return remainTime;
        }

        private string getEndTime(string startTime)
        {
            DateTime start = Convert.ToDateTime(startTime.ToString());
            DateTime timeRemaining = Convert.ToDateTime(getRemainingTimeTicket(ticketCheck.ticketID));
            string endTime = Convert.ToDateTime(start).AddHours(timeRemaining.Hour).AddMinutes(timeRemaining.Minute).AddSeconds(timeRemaining.Second).ToString("HH:mm:ss");
            return endTime;
        }

        private string[] getTime() // [0 start time, 1 time ticket, 2 remaining]
        {
            string sql1 = "SELECT start_time FROM computer WHERE id = '" + loginForm.computerGlobal + "'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            string[] dateTime = { };

            MySqlDataReader reader = cmd.ExecuteReader();
            string startTime = "";
            int ticketID = ticketCheck.ticketID;

            while (reader.Read())
            {
                startTime = reader.GetString("start_time");
            }

            conn.Close();

            string sql2 = "SELECT time,remaining FROM ticket WHERE id = '" + ticketID + "'";
            cmd = new MySqlCommand(sql2, conn);
            conn.Open();

            reader = cmd.ExecuteReader();
            string time = "";
            string remaining = "";
            while (reader.Read())
            {
                time = reader.GetString("time");
                remaining = reader.GetString("remaining");
            }

            conn.Close();

           
            dateTime = new string[] { startTime.ToString(), time.ToString(), remaining.ToString() };
            
            return dateTime;
        }

        private void computer_Load(object sender, EventArgs e)
        {
            Console.WriteLine(ticketCheck.dateGlobal);
            string start = Convert.ToDateTime(ticketCheck.dateGlobal).ToString("HH:mm:ss");
            string end = getEndTime(ticketCheck.dateGlobal);
            startTime.Text = start;
            endTime.Text = end;
            remainText.Text = getRemainingTimeTicket(ticketCheck.ticketID);

            DateTime time = Convert.ToDateTime(getRemainingTimeTicket(ticketCheck.ticketID));
            h = time.Hour;
            m = time.Minute;
            s = time.Second;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += onTimeEvent;

            timer.Start();
        }

        private void onTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                if (s < 0)
                {
                    s = 59;
                    m -= 1;
                }
                if (m < 0)
                {
                    m = 59;
                    h -= 1;
                }

                if (h == 0 && m == 0 && s == 0)
                {
                    timer.Stop();
                    if (checkTimeout() == true)
                    {
                        updateTicket(ticketCheck.ticketID);
                        if (loginForm.phoneGlobal.Contains("guest"))
                        {
                            loginForm.Show();
                        }
                        else
                        {
                            ticketForm.Show();
                        }
                        this.Close();
                    } 
                }
                remainText.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2,'0'), m.ToString().PadLeft(2,'0'), s.ToString().PadLeft(2,'0'));
            }));
        }

        private bool checkTimeout()
        {
            DateTime TimeRemain = Convert.ToDateTime(getTime()[2]);
            DateTime startTime = Convert.ToDateTime(ticketCheck.dateGlobal);
            DateTime dateNow = DateTime.Now;
            TimeSpan timeUsed = dateNow.Subtract(startTime);
            int timeTicketCon = TimeRemain.Hour;
            DateTime timeUsedCon = dateNow.Date + timeUsed;
            TimeSpan remaining = TimeRemain.Subtract(timeUsedCon);
            Console.WriteLine(remaining);
            if (remaining.TotalSeconds <= 0)
            {
                return true;
            }

            return false;
        }

        private void updateTicket(int ticketID)
        {
            int computerID = loginForm.computerGlobal;
            string remainTime = "00:00:00";
            if (checkTimeout() == true)
            {
                remainTime = "00:00:00";
            }
            else
            {
                DateTime dateNow = Convert.ToDateTime(DateTime.Now);
                DateTime startTime = Convert.ToDateTime(ticketCheck.dateGlobal);
                DateTime timeRemaining = Convert.ToDateTime(getTime()[2]); ;
                TimeSpan timeUsed = dateNow.Subtract(startTime);
                DateTime timeUsedCon = dateNow.Date + timeUsed;
                TimeSpan remaining = timeRemaining.Subtract(timeUsedCon);
                DateTime remainTimeCvt = dateNow.Date + remaining;
                remainTime = remainTimeCvt.ToString("HH:mm:ss");
            }
            Console.WriteLine(remainTime);
            string sql2 = $"UPDATE ticket SET remaining = '{remainTime}' WHERE id = '{ticketID}'";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();


            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"UPDATE computer SET available = '1', ticket_id = '0', start_time = '{date}' WHERE id = '{loginForm.computerGlobal}'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateTicket(ticketCheck.ticketID);
            MessageBox.Show("ออกจากระบบเรียบร้อยแล้ว", "Logged Out");
            loginForm.Show();
            this.Close();
        }

        private void computer_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (loginForm.phoneGlobal.Contains("guest"))
            {
                MessageBox.Show("เฉพาะสมาชิกเท่านั้นที่สามารถใช้งานได้");
            } else
            {
                updateTicket(ticketCheck.ticketID);
                ticketForm.Show();
                this.Close();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remainText.Text = getRemainingTime();
            if (checkTimeout() == true)
            {
                updateTicket(ticketCheck.ticketID);
                if (loginForm.phoneGlobal.Contains("guest")) {
                    loginForm.Show();
                } else
                {
                    ticketForm.Show();
                }
                this.Close();
            }
        }
    }
}

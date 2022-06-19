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
        MySqlConnection conn = loginForm.databaseConnection();
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
            DateTime startTime = Convert.ToDateTime(getTime()[0]);
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
            DateTime start = Convert.ToDateTime(startTime);
            DateTime timeRemaining = Convert.ToDateTime(getRemainingTimeTicket(ticketCheck.ticketID));
            string endTime = Convert.ToDateTime(start).AddHours(timeRemaining.Hour).AddMinutes(timeRemaining.Minute).AddSeconds(timeRemaining.Second).ToString("HH:mm:ss");
            return endTime;
        }

        private string[] getTime() // [0 start time, 1 time ticket, 2 remaining]
        {
            string sql1 = "SELECT ticket_id, start_time FROM computer WHERE id = '" + loginForm.computerGlobal + "'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            string[] dateTime = { };

            MySqlDataReader reader = cmd.ExecuteReader();
            string startTime = "";
            int ticketID = 0;

            while (reader.Read())
            {
                ticketID = reader.GetInt32("ticket_id");
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
            string start = DateTime.Now.ToString("HH:mm:ss");
            string end = getEndTime(getTime()[1]);
            startTime.Text = start;
            endTime.Text = end;
            remainText.Text = getRemainingTimeTicket(ticketCheck.ticketID);
        }

        private bool checkTimeout()
        {
            DateTime TimeRemain = Convert.ToDateTime(getTime()[2]);
            DateTime startTime = Convert.ToDateTime(getTime()[0]);
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
                DateTime startTime = Convert.ToDateTime(getTime()[0]);
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


            DateTime date = DateTime.Now;
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
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateTicket(ticketCheck.ticketID);
            ticketCheck ticketForm = new ticketCheck();
            ticketForm.Show();
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string start = Convert.ToDateTime(getTime()[0]).ToString("HH:mm:ss");
            string end = getEndTime(start);
            startTime.Text = start;
            endTime.Text = end;
            remainText.Text = getRemainingTime();
        }
    }
}

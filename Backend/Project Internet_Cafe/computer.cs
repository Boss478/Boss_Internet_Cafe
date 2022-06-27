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
using System.Threading;

namespace Project_Internet_Cafe
{
    public partial class computerForm : Form
    {
        System.Timers.Timer timer;
        int h, m, s;
        loginForm loginWin = new loginForm();
        MySqlConnection conn = loginForm.databaseConnection();
        public static double price = 15; // per hour
        public static double point = 1; // per hour

        public computerForm()
        {
            InitializeComponent();
        }

        private void showComputer(DataGridView data)
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,available FROM computer";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            data.DataSource = ds.Tables[0].DefaultView;
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            showComputer(computerData);
            cellColorChange();
            revokeUser();

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
                    remainText.Clear();
                    timer.Stop();
                    showComputer(computerData);
                    cellColorChange();
                    resetBox();
                    showData();
                    revokeUser();
                }
                remainText.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
        private void revokeUser()
        {
            string[] id = allID();
            foreach (string i in id)
            {
                int numberID = Convert.ToInt32(i);
                if (checkTimeout(numberID) == true && getTime(numberID)[0] != "0")
                {
                    int ticketID = Convert.ToInt32(getTime(numberID)[0]);
                    string sql2 = $"UPDATE ticket SET remaining = '00:00:00' WHERE id = '{ticketID}'";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();


                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string sql = $"UPDATE computer SET available = '1', ticket_id = '0', start_time = '{date}' WHERE id = '{numberID}'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    showComputer(computerData);
                    cellColorChange();
                    resetBox();
                    showData();
                }
            }
        }

        /*private void forceComputerStatus (int computerID)
        {
            string remainTime = "00:00:00";
            if (checkTimeout(computerID) == true)
            {
                remainTime = "00:00:00";
            }
            else
            {
                DateTime dateNow = Convert.ToDateTime(DateTime.Now);
                DateTime startTime = Convert.ToDateTime(getTime(computerID)[1]);
                DateTime timeRemaining = Convert.ToDateTime(getTime(computerID)[3]); ;
                TimeSpan timeUsed = dateNow.Subtract(startTime);
                DateTime timeUsedCon = dateNow.Date + timeUsed;
                TimeSpan remaining = timeRemaining.Subtract(timeUsedCon);
                DateTime remainTimeCvt = dateNow.Date + remaining;
                remainTime = remainTimeCvt.ToString("HH:mm:ss");
            }
            Console.WriteLine(remainTime);
            string sql2 = $"UPDATE ticket SET remaining = '{remainTime}' WHERE id = '{getTime(computerID)[0]}'";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();


            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"UPDATE computer SET available = '1', ticket_id = '0', start_time = '{date}' WHERE id = '{computerID}'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show($"Computer ID : {computerID} \nถูกทำให้วว่างแล้ว", "Succeed");
            showComputer(computerData);
            cellColorChange();
            resetBox();
            showData();
            revokeUser();
        }*/

        private void exitProgramClick(object sender, EventArgs e)
        {
            loginWin.Close();
            this.Close();
        }
        
        private void computerLoginHistory_Click(object sender, EventArgs e)
        {
            computerhistory computerHistory = new computerhistory();
            computerHistory.Show();
            this.Close();
        }
        private void resetBox()
        {
            computerIDText.Text = "";
            availableText.Text = "";
            userText.Text = "";
            startTimeText.Text = "";
            endTimeText.Text = "";
            hourText.Text = "";
            remainText.Text = "";
        }

        private string[] allID()
        {
            string sql = "SELECT id FROM computer";
            MySqlConnection conn = loginForm.databaseConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> allID = new List<string>();

            while (reader.Read())
            {
                allID.Add(reader.GetString("id"));
            }
            conn.Close();
            string[] id = allID.ToArray();

            return id;
        }

        private bool checkTimeout(int id)
        {
            DateTime TimeRemain = Convert.ToDateTime(getTime(id)[3]);
            DateTime startTime = Convert.ToDateTime(getTime(id)[1]);
            DateTime dateNow = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
            TimeSpan timeUsed = dateNow.Subtract(startTime);
            int timeTicketCon = TimeRemain.Hour;
            DateTime timeUsedCon = dateNow.Date + timeUsed;
            TimeSpan remaining = TimeRemain.Subtract(timeUsedCon);

            if (remaining.TotalSeconds <= 0)
            {
                return true;
            }

            return false;
        }
        private void cellColorChange()
        {
            for (int i = 0; i < computerData.RowCount; i++)
            {
                if (computerData.Rows[i].Cells["available"].FormattedValue.ToString() == "True")
                {
                    computerData.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (computerData.Rows[i].Cells["available"].FormattedValue.ToString() == "False")
                {
                    computerData.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        public static string getName(int id)
        {
            MySqlConnection conn = loginForm.databaseConnection();
            string sql1 = "SELECT user FROM ticket WHERE id = '"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            string user = "";

            while (reader.Read())
            {
                user = reader.GetString("user");
            }

            conn.Close();

            string sql2 = "SELECT * FROM member WHERE phone = '" + user + "'";
            cmd = new MySqlCommand(sql2, conn);
            conn.Open();

            reader = cmd.ExecuteReader();
            string fName = "";
            string sName = "";
            while (reader.Read())
            {
                fName = reader.GetString("fName");
                sName = reader.GetString("sName");
            }

            conn.Close();

            string name = fName + " " + sName + " - " + user;
            return name;
        }

        private string[] getTime(int computerID)
        {
            string[] dateTime = { };

            string sql1 = "SELECT ticket_id, start_time FROM computer WHERE id = '" + computerID + "'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            string ticketID = "";
            string startTime = "";

            while (reader.Read())
            {
                ticketID = reader.GetString("ticket_id");
                if (ticketID != "0")
                {
                    startTime = reader.GetString("start_time");
                }
            }

            conn.Close();

            if (Convert.ToInt32(ticketID) != 0)
            {
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

                DateTime timeConverted = Convert.ToDateTime(time); // [0 ticketID , 1 start , 2 time ticket , 3 remain]
                dateTime = new string[] { ticketID, startTime, timeConverted.ToString("HH:mm:ss"), remaining };
            } else
            {
                DateTime dateNow = DateTime.Now;
                dateTime = new string[] { ticketID, dateNow.ToString(), "00:00:00", "00:00:00" };
            }
            conn.Close();
            return dateTime;
        }

        private void showData()
        {
            //computerData.CurrentRow.Selected = true;
            int selectedRow = computerData.CurrentCell.RowIndex;
            int computerID = Convert.ToInt32(computerData.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
            computerIDText.Text = computerID.ToString();
            string checkAvailable = computerData.Rows[selectedRow].Cells["available"].FormattedValue.ToString();
            if (checkAvailable == "False")
            {
                availableText.Text = "ไม่ว่าง";
                int ticketID = Convert.ToInt32(getTime(computerID)[0]);
                userText.Text = $"[{ticketID}] " + getName(ticketID);
                startTimeText.Text = Convert.ToDateTime(getTime(computerID)[1]).ToString("HH:mm:ss");
                DateTime timeTicket = Convert.ToDateTime(getTime(computerID)[2]);
                DateTime timeRemaining = Convert.ToDateTime(getTime(computerID)[3]);
                DateTime startTime = Convert.ToDateTime(getTime(computerID)[1]);
                DateTime dateNow = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
                TimeSpan timeUsed = dateNow.Subtract(startTime);
                DateTime endTime = Convert.ToDateTime(getTime(computerID)[1]).AddHours(timeRemaining.Hour).AddMinutes(timeRemaining.Minute).AddSeconds(timeRemaining.Second);
                endTimeText.Text = endTime.ToString("HH:mm:ss");
                hourText.Text = getTime(computerID)[2].ToString();
                DateTime timeUsedCon = dateNow.Date + timeUsed;
                TimeSpan remaining = timeRemaining.Subtract(timeUsedCon);
                if (remaining.TotalSeconds > 0)
                {
                    DateTime remainingDateTime = DateTime.Now.Date + remaining;
                    remainText.Text = remainingDateTime.ToString("HH:mm:ss");

                    h = remainingDateTime.Hour;
                    m = remainingDateTime.Minute;
                    s = remainingDateTime.Second;
                    timer = new System.Timers.Timer();
                    timer.Interval = 1000;
                    timer.Elapsed += onTimeEvent;
                    
                    if (timer.Enabled == false)
                    {
                        timer.Start();
                    }
                }
                else
                {
                    remainText.Text = "00:00:00";
                }
            }
            else if (checkAvailable == "True")
            {
                availableText.Text = "ว่าง";
            }
        } 

        private void computerData_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }
            //showComputer(computerData);
            cellColorChange();
            resetBox();
            showData();
            revokeUser();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }
            showComputer(computerData);
            cellColorChange();
            resetBox();
            showData();
            revokeUser();
        }

        private void member_menuStripClick(object sender, EventArgs e)
        {
            memberForm memberForm = new memberForm();
            memberForm.Show();
            this.Close();
        }

        private void buyTicket_menuStripClick(object sender, EventArgs e)
        {
            ticket ticketForm = new ticket();
            ticketForm.Show();
            this.Close();
        }

        private void computerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }
        }

        private void addComputer()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"INSERT INTO computer (available,ticket_id,start_time) VALUES ('1','0','{date}')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("เพิ่มคอมพิวเตอร์เรียบร้อยแล้ว", "Succeed");
            showComputer(computerData);
            cellColorChange();
            showData();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
            }
            forceComputerStatus(Convert.ToInt32(computerIDText.Text));
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            addComputer();
        }

        private void remainText_TextChanged(object sender, EventArgs e)
        {
            if (remainText.Text == "00:00:00")
            {
                remainText.Text = "";
            }
        }

        private void ticketHistory_menuStripClick(object sender, EventArgs e)
        {
            ticketHistory ticketHistoryForm = new ticketHistory();
            ticketHistoryForm.Show();
            this.Close();
        }

        private void exit_menuStripClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

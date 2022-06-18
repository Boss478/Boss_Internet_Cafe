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
            MySqlConnection conn = loginForm.databaseConnection();
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
                    int rows2 = cmd2.ExecuteNonQuery();
                    conn.Close();


                    DateTime date = DateTime.Now;
                    string sql = $"UPDATE computer SET available = '1', ticket_id = '0', start_time = '{date}' WHERE id = '{numberID}'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        showComputer(computerData);
                        cellColorChange();
                    }
                }
            }
        }

        private void exitProgramClick(object sender, EventArgs e)
        {
            loginWin.Close();
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

        private string[] getTime(int id)
        {
            string[] dateTime = { };

            string sql1 = "SELECT ticket_id, start_time FROM computer WHERE id = '" + id + "'";
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
            computerData.CurrentRow.Selected = true;
            int selectedRow = computerData.CurrentCell.RowIndex;
            int computerID = Convert.ToInt32(computerData.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
            computerIDText.Text = computerID.ToString();
            string checkAvailable = computerData.Rows[selectedRow].Cells["available"].FormattedValue.ToString();
            if (checkAvailable == "False")
            {
                availableText.Text = "ไม่ว่าง";
                int ticketID = Convert.ToInt32(getTime(computerID)[0]);
                userText.Text = $"[{ticketID}] " + getName(ticketID);
                startTimeText.Text = getTime(computerID)[1];
                DateTime timeTicket = Convert.ToDateTime(getTime(computerID)[2]);
                DateTime timeRemaining = Convert.ToDateTime(getTime(computerID)[3]);
                DateTime startTime = Convert.ToDateTime(getTime(computerID)[1]);
                DateTime dateNow = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
                TimeSpan timeUsed = dateNow.Subtract(startTime);
                endTimeText.Text = Convert.ToDateTime(getTime(computerID)[1]).AddHours(timeRemaining.Hour).AddMinutes(timeRemaining.Minute).AddSeconds(timeRemaining.Second).ToString();
                hourText.Text = getTime(computerID)[2].ToString();
                DateTime timeUsedCon = dateNow.Date + timeUsed;
                TimeSpan remaining = timeRemaining.Subtract(timeUsedCon);
                if (remaining.TotalSeconds > 0)
                {
                    remainText.Text = remaining.ToString();
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
            resetBox();
            showData();
            revokeUser();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void ticketHistory_menuStripClick(object sender, EventArgs e)
        {
            ticketHistory ticketHistoryForm = new ticketHistory();
            ticketHistoryForm.Show();
            this.Close();
        }

        private void exit_menuStripClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

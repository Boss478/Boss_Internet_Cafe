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
        // double price = 15; // per hour

        public computerForm()
        {
            InitializeComponent();
        }

        private void showComputer()
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

            computerData.DataSource = ds.Tables[0].DefaultView;
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            showComputer();
            revokeUser();
        }

        private void revokeUser()
        {
            string[] id = allID();
            foreach (string i in id)
            {
                int numberID = Convert.ToInt32(i);
                if (checkTimeout(numberID) == true)
                {
                    MySqlConnection conn = loginForm.databaseConnection();

                    string sql = $"UPDATE computer SET available = 'Yes', ticket_id = '0' WHERE id = '{numberID}'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        showComputer();
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
            DateTime endTime = Convert.ToDateTime(getTime(id)[1]);
            Console.WriteLine(endTime);
            DateTime dateNow = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
            TimeSpan remaining = endTime.Subtract(dateNow);

            bool isTimeout = false;

            if (remaining.TotalSeconds > 0)
            {
                isTimeout = false;
            } else
            {
                isTimeout = true;
            } 

            return isTimeout;
        }

        private string getName(int id)
        {
            string sql1 = "SELECT user FROM computer WHERE id = '"+id+"'";
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

            string sql1 = "SELECT ticket_id FROM computer WHERE id = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            string ticketID = "";

            while (reader.Read())
            {
                ticketID = reader.GetString("ticket_id");
            }

            conn.Close();

            if (Convert.ToInt32(ticketID) != 0)
            {
                string sql2 = "SELECT start_time,end_time FROM ticket WHERE id = '" + ticketID + "'";
                cmd = new MySqlCommand(sql2, conn);
                conn.Open();

                reader = cmd.ExecuteReader();
                string startTime = "";
                string endTime = "";
                while (reader.Read())
                {
                    startTime = reader.GetString("start_time");
                    endTime = reader.GetString("end_time");
                }

                conn.Close();

                dateTime = new string[] { startTime, endTime };
            } else
            {
                string startTime = "00:00:00";
                string endTime = "00:00:00";
                dateTime = new string[] { startTime, endTime };
            }
            return dateTime;
        }

        private void computerData_Click(object sender, DataGridViewCellEventArgs e)
        {
            resetBox();
            computerData.CurrentRow.Selected = true;
            int selectedRow = computerData.CurrentCell.RowIndex;
            int computerID = Convert.ToInt32(computerData.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
            computerIDText.Text = computerID.ToString();
            string checkAvailable = computerData.Rows[selectedRow].Cells["available"].FormattedValue.ToString();
            if (checkAvailable == "No")
            {
                availableText.Text = "ไม่ว่าง";
                userText.Text = getName(computerID);
                startTimeText.Text = getTime(computerID)[0];
                endTimeText.Text = getTime(computerID)[1];
                DateTime startTime = Convert.ToDateTime(getTime(computerID)[0]);
                DateTime endTime = Convert.ToDateTime(getTime(computerID)[1]);
                TimeSpan time = endTime.Subtract(startTime);
                hourText.Text = time.ToString();
                DateTime dateNow = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
                TimeSpan remaining = endTime.Subtract(dateNow);
                if (remaining.TotalSeconds > 0)
                {
                    remainText.Text = remaining.ToString();
                } else
                {
                    remainText.Text = "00:00:00";
                }
            } else if (checkAvailable == "Yes")
            {
                availableText.Text = "ว่าง";
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showComputer();
            int selectedRow = computerData.CurrentCell.RowIndex;
            int selectedID = Convert.ToInt32(computerData.Rows[selectedRow].Cells["id"].Value);
            DateTime endTime = Convert.ToDateTime(getTime(selectedID)[1]);
            DateTime dateNow = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
            TimeSpan remaining = endTime.Subtract(dateNow);
            remainText.Text = remaining.ToString();
            if (remaining.TotalSeconds > 0)
            {
                remainText.Text = remaining.ToString();
            }
            else
            {
                remainText.Text = "00:00:00";
            }

            revokeUser();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberForm memberForm = new memberForm();
            memberForm.Show();
            this.Close();
        }
    }
}

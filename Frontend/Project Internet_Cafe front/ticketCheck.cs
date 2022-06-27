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
    public partial class ticketCheck : Form
    {
        MySqlConnection conn = loginForm.databaseConnection();
        public static int ticketID = 0;
        public static string dateGlobal = "00:00:00";
        public static int latestID = 0;

        public ticketCheck()
        {
            InitializeComponent();
        }

        private void loadTicketData(string phone)
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT id,time,remaining FROM ticket WHERE user = '{phone}' AND remaining != '00:00:00'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            ticketDataView.DataSource = ds.Tables[0].DefaultView;
        }

        private void ticketCheck_Load(object sender, EventArgs e)
        {
            loadTicketData(loginForm.phoneGlobal);
        }

        public static void setComputerUnavailable(int ticketID)
        {
            MySqlConnection conn = loginForm.databaseConnection();
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"UPDATE computer SET available = '0', ticket_id = '{ticketID}', start_time = '{date}' WHERE id = '{loginForm.computerGlobal}'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void addLoginHistory(int ticketID, string phone)
        {
            MySqlConnection conn = loginForm.databaseConnection();

            string sql = "SELECT id FROM loginhistory";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            List<int> allID = new List<int>();
            while (reader.Read())
            {
                allID.Add(reader.GetInt32("id"));
            }

            conn.Close();
            int last = allID.Count;
            ticketCheck.latestID = allID[last - 1] + 1;

            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            sql = $"INSERT loginhistory (phone,login_time,computer_id,ticket_id) VALUES ('{phone}','{date}','{loginForm.computerGlobal}','{ticketID}')";

            cmd = new MySqlCommand(sql, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void useButton_Click(object sender, EventArgs e)
        {
            ticketDataView.CurrentRow.Selected = true;
            int selectedRow = ticketDataView.CurrentCell.RowIndex;
            ticketID = Convert.ToInt32(ticketDataView.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
            string remainTime = ticketDataView.Rows[selectedRow].Cells["remaining"].FormattedValue.ToString();

            dateGlobal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (IDText.Text != null && remainText.Text != null)
            {
                computer computerForm = new computer();
                computerForm.Show();
                this.Hide();
                setComputerUnavailable(ticketID);
                addLoginHistory(ticketID, loginForm.phoneGlobal);
            } else
            {
                MessageBox.Show("กรุณาเลือกตั๋วของคุณ", "ERROR");
            }
        }

        private void ticketDataCellClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketDataView.CurrentRow.Selected = true;
            int selectedRow = ticketDataView.CurrentCell.RowIndex;
            int ticketIDClick = Convert.ToInt32(ticketDataView.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
            string remainTime = ticketDataView.Rows[selectedRow].Cells["remaining"].FormattedValue.ToString();

            ticketID = ticketIDClick;

            IDText.Text = ticketIDClick.ToString();
            remainText.Text = remainTime;

        }

        private void logoutClick(object sender, EventArgs e)
        {
            this.Close();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }
    }
}

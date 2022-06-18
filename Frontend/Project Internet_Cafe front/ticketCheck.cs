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

        private void setComputerUnavailable(int ticketID)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"UPDATE computer SET available = '0', ticket_id = '{ticketID}', start_time = '{date}' WHERE id = '{loginForm.computerGlobal}'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
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

            computer computerForm = new computer();
            computerForm.Show();
            this.Hide();

            setComputerUnavailable(ticketID);
        }

        private void ticketDataCellClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketDataView.CurrentRow.Selected = true;
            int selectedRow = ticketDataView.CurrentCell.RowIndex;
            int ticketID = Convert.ToInt32(ticketDataView.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
            string remainTime = ticketDataView.Rows[selectedRow].Cells["remaining"].FormattedValue.ToString();

            IDText.Text = ticketID.ToString();
            remainText.Text = remainTime;

        }
    }
}

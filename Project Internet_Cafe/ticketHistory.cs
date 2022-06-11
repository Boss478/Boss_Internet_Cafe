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

namespace Project_Internet_Cafe
{
    public partial class ticketHistory : Form
    {
        MySqlConnection conn = loginForm.databaseConnection();
        public ticketHistory()
        {
            InitializeComponent();
        }

        private void loadTicketData()
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM tickethistory";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            ticketDataView.DataSource = ds.Tables[0].DefaultView;
        }

        private void ticketHistory_Load(object sender, EventArgs e)
        {
            loadTicketData();
        }

        private void ticketDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = ticketDataView.CurrentCell.RowIndex;
            int ticketID = Convert.ToInt32(ticketDataView.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
            ticketIDText.Text = ticketID.ToString();
            buyTimeText.Text = Convert.ToDateTime(ticketDataView.Rows[selectedRow].Cells["timestamp"].FormattedValue.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            hourTimeText.Text = ticketDataView.Rows[selectedRow].Cells["time"].FormattedValue.ToString();
            phoneText.Text = ticketDataView.Rows[selectedRow].Cells["phone"].FormattedValue.ToString();
            nameText.Text = computerForm.getName(ticketID);
            priceText.Text = ticketDataView.Rows[selectedRow].Cells["price"].FormattedValue.ToString();
            pointReText.Text = ticketDataView.Rows[selectedRow].Cells["pointreceived"].FormattedValue.ToString();
            pointUseText.Text = ticketDataView.Rows[selectedRow].Cells["pointused"].FormattedValue.ToString();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTicketData(); ;
            ticketIDText.Clear();
            hourTimeText.Clear();
            phoneText.Clear();
            nameText.Clear();
            priceText.Clear();
            pointReText.Clear();
            pointUseText.Clear();
        }
    }
}

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
        public static int ticketIDGlobal = 0;

        public ticketHistory()
        {
            InitializeComponent();
        }

        private void loadTicketData(string phone)
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            if (phone == "(all)")
            {
                cmd.CommandText = "SELECT * FROM tickethistory";
            } else { 
                cmd.CommandText = $"SELECT * FROM tickethistory WHERE phone = '{phone}'"; 
            }
            

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            ticketDataView.DataSource = ds.Tables[0].DefaultView;
        }

        private string[] getAllName()
        {
            string sql1 = "SELECT id,fname,sname,phone FROM member";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<int> id = new List<int>();
            List<string> fname = new List<string>();
            List<string> sname = new List<string>();
            List<string> phone = new List<string>();

            while (reader.Read())
            {
                id.Add(Convert.ToInt32(reader.GetString("id")));
                fname.Add(reader.GetString("fname"));
                sname.Add(reader.GetString("sname"));
                phone.Add(reader.GetString("phone"));
            }

            conn.Close();

            List<string> fullName = new List<string>();
            for (int i = 0; i < id.Count; i++)
            {
                fullName.Add($"{fname[i]} {sname[i]} {phone[i]}");
            }

            return fullName.ToArray();

        }

        private void ticketHistory_Load(object sender, EventArgs e)
        {
            loadTicketData("(all)");
            string[] nameList = getAllName().ToArray();
            foreach (string name in nameList)
            {
                comboBox1.Items.Add("(all)");
                comboBox1.Items.Add(name.ToString());
                comboBox1.AutoCompleteCustomSource.Add(name.ToString());
            }
        }

        private void ticketDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = ticketDataView.CurrentCell.RowIndex;
            int ticketID = Convert.ToInt32(ticketDataView.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
            ticketIDText.Text = ticketID.ToString();
            ticketIDGlobal = ticketID;
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
            string[] text = comboBox1.Text.Split(' ');
            if (text[2] == "(all)")
            {
                loadTicketData("(all)");
            }
            else
            {
                loadTicketData(text[2]);
            }
            ticketIDText.Clear();
            hourTimeText.Clear();
            phoneText.Clear();
            nameText.Clear();
            priceText.Clear();
            pointReText.Clear();
            pointUseText.Clear();
        }

        private void showReceiptButton_Click(object sender, EventArgs e)
        {
            receipt receipt = new receipt();
            receipt.Show();
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

        private void computer_menuStripClick(object sender, EventArgs e)
        {
            computerForm computerForm = new computerForm();
            computerForm.Show();
            this.Close();
        }

        private void exit_menuStripClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string[] text = comboBox1.Text.Split(' ');
            if (text[2] == "(all)")
            {
                loadTicketData("(all)");
            } else
            {
                loadTicketData(text[2]);
            }
        }
    }
}

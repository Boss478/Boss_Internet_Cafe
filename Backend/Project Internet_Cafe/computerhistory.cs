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
    public partial class computerhistory : Form
    {
        MySqlConnection conn = loginForm.databaseConnection();
        public computerhistory()
        {
            InitializeComponent();
        }
        private void computerAvailableCheck_Click(object sender, EventArgs e)
        {
            computerForm computerForm = new computerForm();
            computerForm.Show();
            this.Close();
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

        private void loadTicketData(string phone)
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            if (checkBox1.Checked)
            {
                if (phone == "(all)")
                {
                    cmd.CommandText = $"SELECT id,phone,computer_id,ticket_id,login_time,logout_time FROM loginhistory WHERE date = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
                }
                else
                {
                    cmd.CommandText = $"SELECT id,phone,computer_id,ticket_id,login_time,logout_time FROM loginhistory WHERE phone = '{phone}' AND date = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
                }
            } else
            {
                if (phone == "(all)")
                {
                    cmd.CommandText = $"SELECT id,phone,computer_id,ticket_id,login_time,logout_time FROM loginhistory";
                }
                else
                {
                    cmd.CommandText = $"SELECT id,phone,computer_id,ticket_id,login_time,logout_time FROM loginhistory WHERE phone = '{phone}'";
                }
            }
            


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
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

        private void computerhistory_Load(object sender, EventArgs e)
        {
            loadTicketData("(all)");
            dateTimePicker1.Enabled = false;
            string[] nameList = getAllName().ToArray();
            comboBox1.Items.Add("(all)");
            foreach (string name in nameList)
            {
                comboBox1.Items.Add(name.ToString());
                comboBox1.AutoCompleteCustomSource.Add(name.ToString());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string[] text = comboBox1.Text.Split(' ');
            if (comboBox1.Text == "(all)")
            {
                loadTicketData("(all)");
            }
            else
            {
                loadTicketData(text[2]);
            }
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                dateTimePicker1.Enabled = false;
            } else
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

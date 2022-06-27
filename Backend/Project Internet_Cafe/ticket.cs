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
    public partial class ticket : Form
    {
        MySqlConnection conn = loginForm.databaseConnection();
        public ticket()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void loadTicket()
        {
            MySqlConnection conn = loginForm.databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,user,time,remaining FROM ticket";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            ticketDataView.DataSource = ds.Tables[0].DefaultView;
        }
        private void computerAvailableCheck_Click(object sender, EventArgs e)
        {
            computerForm computerForm = new computerForm();
            computerForm.Show();
            this.Close();
        }
        private void computerLoginHistory_Click(object sender, EventArgs e)
        {
            computerhistory computerHistory = new computerhistory();
            computerHistory.Show();
            this.Close();
        }

        private void ticket_Load(object sender, EventArgs e)
        {
            loadTicket();
            int[] allPoint = pointList();
            foreach (int p in allPoint)
            {
                usePointText.Items.Add(p);
            }
        }

        private int getPoint(string phone)
        {
            string sql1 = $"SELECT point FROM member WHERE phone = '{phone}'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            int point = 0;

            while (reader.Read())
            {
                point = Convert.ToInt32(reader.GetString("point"));
            }

            conn.Close();
            return point;
        }

        private bool checkPhone(string phone)
        {
            string sql1 = "SELECT phone FROM member";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> allPhone = new List<string>();

            while (reader.Read())
            {
                allPhone.Add(reader.GetString("phone"));
            }

            conn.Close();

            foreach (string i in allPhone)
            {
                if (i == phone.ToString())
                {
                    return true;
                }
            }

            return false;
        }

        private void notMemberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (notMemberCheck.Checked)
            {
                userPhoneText.Text = "* Guest *";
                userPhoneText.ReadOnly = true;
                userPhoneText.BackColor = Color.LightGray;
            }
            else
            {
                userPhoneText.Clear();
                userPhoneText.ReadOnly = false;
                userPhoneText.BackColor = Color.White;
            }
        }

        private void phoneTextChange(object sender, EventArgs e)
        {
            if (userPhoneText.Text != "* Guest *")
            {
                if (checkPhone(userPhoneText.Text))
                {
                    userPointText.Text = getPoint(userPhoneText.Text).ToString();
                    userPhoneText.BackColor = Color.LightGreen;
                }
                else
                {
                    userPointText.Text = "";
                    userPhoneText.BackColor = Color.White;
                }
            }
            else
            {
                userPointText.Text = "0";
            }
        }

        private int[] pointList()
        {
            List<int> point = new List<int>();
            string sql = $"SELECT point FROM point_exchange";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                point.Add(reader.GetInt32("point"));
            }

            conn.Close();
            return point.ToArray();
        }

        private int pointExchange(int point)
        {
            int discount = 0;
            string sql = $"SELECT discount FROM point_exchange WHERE point = '{point}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            discount = reader.GetInt32("discount");
            conn.Close();
            return discount;
        }

        private void calculation()
        {
            try
            {
                if (timeText.Text != "" && Convert.ToInt32(timeText.Text) > 0)
                {
                    try
                    {
                        int hour = Convert.ToInt32(timeText.Text);
                        int pointUse = Convert.ToInt32(usePointText.Text);
                        int discount = pointExchange(pointUse);
                        double price = hour * computerForm.price;
                        if (discount >= price)
                        {
                            moneyCalText.Text = "0";
                            pointCalText.Text = (hour * computerForm.point).ToString();
                            //pointCalText.Text = (hour * computerForm.point).ToString("N0");
                        } else
                        {
                            moneyCalText.Text = ((hour * computerForm.price) - discount).ToString();
                            pointCalText.Text = (hour * computerForm.point).ToString();
                            //pointCalText.Text = (hour * computerForm.point).ToString("N0");
                        }
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show(ex.ToString());
                        moneyCalText.Text = "0";
                        pointCalText.Text = "0";
                    }
                }
                else
                {
                    moneyCalText.Text = "0";
                    pointCalText.Text = "0";
                }
            } catch (Exception ex)
            {
                
            }
        }

        private void usePointText_SelectedIndexChanged(object sender, EventArgs e)
        {
            discountText.Text = pointExchange(Convert.ToInt32(usePointText.Text)).ToString();
            calculation();
        }


        private void timeText_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private string passwordGenerator(int length)
        {
            Random random = new Random();
            string password = "";
            for (int i = 0; i < length; i++)
            {
                password += random.Next(10).ToString();
            }
            return password;
        }

        private void clearData()
        {
            userPhoneText.Clear();
            notMemberCheck.Checked = false;
            timeText.Text = "0";
            userPointText.Clear();
            usePointText.Text = "0";
            discountText.Text = "0";
            moneyCalText.Text = "0";
            pointCalText.Text = "0";
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = userPhoneText.Text;
                if (userPhoneText.BackColor == Color.LightGreen || phone == "* Guest *")
                {
                    int hour = Convert.ToInt32(timeText.Text);
                    string dateNow = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
                    string time = DateTime.Now.Date.AddHours(hour).ToString("HH:mm:ss");
                    int userPoint = Convert.ToInt32(userPointText.Text);
                    int PointUsed = Convert.ToInt32(usePointText.Text);
                    int discount = Convert.ToInt32(discountText.Text);
                    string password = "-";
                    if (userPhoneText.Text == "* Guest *")
                    {
                        string guestUser = "guest" + DateTime.Now.Month + DateTime.Now.Day;
                        if (guestUser.Length <= 12)
                        {
                            guestUser = guestUser + passwordGenerator(12 - guestUser.Length);
                        }
                        phone = guestUser;
                        password = passwordGenerator(10);
                    }
                    if (PointUsed <= userPoint)
                    {
                        int price = Convert.ToInt32(moneyCalText.Text);

                        int pointReceive = Convert.ToInt32(pointCalText.Text);
                        string sql = $"INSERT INTO ticket (user,password,time,remaining) VALUES ('{phone}','{password}','{time}','{time}')";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (rows > 0)
                        {
                            MessageBox.Show("การสั่งซื้อเรียบร้อยแล้ว", "Succeed");
                            loadTicket();
                            clearData();
                        }


                        sql = $"INSERT INTO tickethistory (phone,time,price,pointreceived,pointused) VALUES ('{phone}','{time}','{price}','{pointReceive}','{PointUsed}')";
                        cmd = new MySqlCommand(sql, conn);
                        conn.Open();
                        int rows2 = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (rows2 > 0)
                        {

                        }
                        int pt = userPoint - PointUsed;
                        sql = $"UPDATE member SET point = '{pt}' WHERE phone = '{phone}'";
                        cmd = new MySqlCommand(sql, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("แต้มของคุณไม่เพียงพอ", "ERROR");
                    }

                }
                else
                {
                    MessageBox.Show("ไม่พบผู้ใช้", "ERROR");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            conn.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void ticketHistoryClick(object sender, EventArgs e)
        {
            ticketHistory tHistory = new ticketHistory();
            tHistory.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTicket();
        }

        private void member_menuStripClick(object sender, EventArgs e)
        {
            memberForm memberForm = new memberForm();
            memberForm.Show();
            this.Close();
        }

        private void computer_menuStripClick(object sender, EventArgs e)
        {
            computerForm computerForm = new computerForm();
            computerForm.Show();
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
            Application.Exit();
        }
    }
}

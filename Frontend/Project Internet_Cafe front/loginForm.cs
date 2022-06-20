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

    public partial class loginForm : Form
    {
        public static MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=internet_cafe;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        MySqlConnection conn = databaseConnection();
        public static string phoneGlobal = "";
        public static int computerGlobal = 0;

        public loginForm()
        {
            InitializeComponent();
        }

        private string[] getAllAvailableComputer()
        {
            List<string> availableComputerID = new List<string>();

            string sql1 = "SELECT id FROM computer WHERE available = '1'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                availableComputerID.Add(reader.GetString("id"));
            }

            conn.Close();

            return availableComputerID.ToArray();
        }

        private string[] getAllPhone()
        {
            string sql1 = "SELECT phone FROM member";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> phone = new List<string>();

            while (reader.Read())
            {
                phone.Add(reader.GetString("phone"));
            }

            conn.Close();

            return phone.ToArray();
        }

        private bool checkPassword(string phone, string password)
        {
            string sql = "";
            if (phone.Contains("guest"))
            {
                sql = $"SELECT password FROM ticket WHERE user = '{phone}'";
            } else
            {
                sql = $"SELECT passcode FROM member WHERE phone = '{phone}'";
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            string getPassword = "";

            while (reader.Read())
            {
                if (phone.Contains("guest"))
                {
                    getPassword = reader.GetString("password");
                } else
                {
                    getPassword = reader.GetString("passcode");
                }
            }

            conn.Close();

            if (getPassword == password)
            {
                return true;
            }

            return false;
        }

        private string[] getTicketID(string phone)
        {
            string sql = $"SELECT id FROM ticket WHERE user = '{phone}'";
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> allID = new List<string>();

            while (reader.Read())
            {
                allID.Add(reader.GetString("id"));
            }

            conn.Close();

            return allID.ToArray();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Text;
            string computerID = comboBox1.Text;

            if (username != null && password != null && computerID != null)
            {
                if (checkPassword(username, password) == true)
                {
                    if (username.Contains("guest"))
                    {
                        phoneGlobal = username;
                        computerGlobal = Convert.ToInt32(computerID);
                        ticketCheck.dateGlobal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        ticketCheck.ticketID = Convert.ToInt32(getTicketID(username)[0]);
                        ticketCheck.setComputerUnavailable(ticketCheck.ticketID);
                        MessageBox.Show("เข้าสู่ระบบสำเร็จ", "Succeed");
                        computer computerForm = new computer();
                        computerForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("เข้าสู่ระบบสำเร็จ", "Succeed");
                        phoneGlobal = username;
                        computerGlobal = Convert.ToInt32(computerID);
                        ticketCheck ticket = new ticketCheck();
                        ticket.Show();
                        this.Hide();
                    }
                } else
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "ERROR");
                    passwordText.Clear();
                }
            } else
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบถ่้วน", "ERROR");
            }

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] availableList = getAllAvailableComputer();
            foreach (string item in availableList)
            {
                comboBox1.Items.Add(item);
            }
            
        }
    }
}

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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            MySqlConnection conn = databaseConnection();
            conn.Close();
        }

        public static MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=internet_cafe;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string getUsername = usernameText.Text;
            string getPassword = passwordText.Text;

            string username = "admin";
            string password = "1234";

            if (getUsername == username && getPassword == password)
            {
                MessageBox.Show("เข้าสู่ระบบเรียบร้อย", "Succeed");
                this.Hide();
                computerForm adminWin = new computerForm();
                adminWin.Show();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "Error");
                passwordText.Text = "";
            }

        }
    }
}

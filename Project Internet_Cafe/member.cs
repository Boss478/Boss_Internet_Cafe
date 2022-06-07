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
    public partial class memberForm : Form
    {
        public memberForm()
        {
            InitializeComponent();
        }

        private void showMember()
        {
            MySqlConnection conn = loginForm.databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,fname,sname,phone,point FROM member";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            memberData.DataSource = ds.Tables[0].DefaultView;
        }

        private void memberForm_Load(object sender, EventArgs e)
        {
            showMember();
        }

        private string getPassword(int id)
        {
            string sql1 = "SELECT password FROM member WHERE id = '" + id + "'";
            MySqlConnection conn = loginForm.databaseConnection();
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            string password = "";

            while (reader.Read())
            {
                password = reader.GetString("password");
            }

            conn.Close();
            return password;
        }

        private bool checkPhoneDuplicate(string phone)
        {
            string sql1 = "SELECT phone FROM member";
            MySqlConnection conn = loginForm.databaseConnection();
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> allPhone = new List<string>();

            while (reader.Read())
            {
                allPhone.Add(reader.GetString("phone"));
            }

            bool isDuplicate = false;

            foreach (string i in allPhone)
            {
                if (i == phone)
                {
                    isDuplicate = true;
                } else
                {
                    isDuplicate = false;
                }
            }

            conn.Close();
            return isDuplicate;
        }

        private bool checkID(int id)
        {
            string sql1 = "SELECT id FROM member";
            MySqlConnection conn = loginForm.databaseConnection();
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> allID = new List<string>();

            while (reader.Read())
            {
                allID.Add(reader.GetString("id"));
            }

            bool isAvailable = false;

            foreach (string i in allID)
            {
                if (i == id.ToString())
                {
                    isAvailable = true;
                }
                else
                {
                    isAvailable = false;
                }
            }

            conn.Close();
            return isAvailable;
        }

        private void memberCellClick(object sender, DataGridViewCellEventArgs e)
        {
            memberData.CurrentRow.Selected = true;
            int selectedRow = memberData.CurrentCell.RowIndex;
            int memberID = Convert.ToInt32(memberData.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
            memberIDText.Text = memberID.ToString();
            fNameText.Text = memberData.Rows[selectedRow].Cells["fName"].FormattedValue.ToString();
            sNameText.Text = memberData.Rows[selectedRow].Cells["sName"].FormattedValue.ToString();
            phoneText.Text = memberData.Rows[selectedRow].Cells["phone"].FormattedValue.ToString();
            pointText.Text = memberData.Rows[selectedRow].Cells["point"].FormattedValue.ToString();
            passwordText.Text = getPassword(memberID).ToString();
        }

        private void showPasswordStateChange(object sender, EventArgs e)
        {
            if (showPasswordBox.Checked == true)
            {
                passwordText.UseSystemPasswordChar = false;
            } else
            {
                passwordText.UseSystemPasswordChar = true;
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            string phone = phoneText.Text;
            if (checkPhoneDuplicate(phone) == false)
            {
                string fname = fNameText.Text;
                string sname = sNameText.Text;
                string password = passwordText.Text;
                MySqlConnection conn = loginForm.databaseConnection();
                string sql = $"INSERT INTO member (fname,sname,phone,password,point) VALUES ('{fname}','{sname}','{phone}','{password}','0')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("เพิ่มข้อมูลสมาชิกสำเร็จ", "Succeed");
                    showMember();
                }
            } else
            {
                MessageBox.Show("มีผู้ใช้นี้ในระบบแล้ว", "ERROR");
            }
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(memberIDText.Text);
            if (checkID(id) == true)
            {
                string fName = fNameText.Text;
                string sName = sNameText.Text;
                string password = passwordText.Text;
                int point = Convert.ToInt32(pointText.Text);

                MySqlConnection conn = loginForm.databaseConnection();

                string sql = $"UPDATE member SET fname = '{fName}', sname = '{sName}', password = '{password}', point = '{point}' WHERE id = '{id}'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                 MessageBox.Show($"แก้ไขข้อมูลสมาชิก ID: {id} - {fName} เรียบร้อยแล้ว", "Succeed");
                 showMember();
                }

            }
        }

        private void computerCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            computerForm computerForm = new computerForm();
            computerForm.Show();
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMember();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteMemberButtonClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(memberIDText.Text);
            if (checkID(id) == true)
            {
                DialogResult result = MessageBox.Show("คุณต้องการจะลบหรือไม่", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    string fName = fNameText.Text;

                    MySqlConnection conn = loginForm.databaseConnection();

                    string sql = $"DELETE FROM member WHERE id = '{id}'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show($"ลบข้อมูลสมาชิก ID: {id} - {fName} เรียบร้อยแล้ว", "Succeed");
                        showMember();
                    }
                }

            }
        }
    }
}

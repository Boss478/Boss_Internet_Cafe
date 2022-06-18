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

        private bool checkAlpha(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(char.IsLetter(str[i])) || (char.IsNumber(str[i])))
                {
                    return false;
                }
            }

            return true;
        }


        private bool checkNumeric(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if ((char.IsNumber(str[i])))
                {
                    return true;
                }
            }

            return false;
        }

        private void memberForm_Load(object sender, EventArgs e)
        {
            showMember();
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

            foreach (string i in allPhone)
            {
                if (i == phone)
                {
                    return true;
                }
            }

            conn.Close();
            return false;
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


            foreach (string i in allID)
            {
                if (i == id.ToString())
                {
                    return true;
                }
            }

            conn.Close();
            return false;
        }

        private string getPassword(int memberID)
        {
            string sql1 = $"SELECT passcode FROM member WHERE id = '{memberID}'";
            MySqlConnection conn = loginForm.databaseConnection();
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            string password = "";

            while (reader.Read())
            {
                password = reader.GetString("passcode");
            }

            return password;
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
            passwordText.Text = getPassword(memberID);
            pointText.Text = memberData.Rows[selectedRow].Cells["point"].FormattedValue.ToString();
        }


        private void addMemberButton_Click(object sender, EventArgs e)
        {
            string phone = phoneText.Text;
            if (checkPhoneDuplicate(phone) == false)
            {
                string fname = fNameText.Text;
                string sname = sNameText.Text;

                if (checkAlpha(fname) && checkAlpha(sname))
                {
                    if (checkNumeric(phone) && phone.Length == 10)
                    {
                        if (checkNumeric(passwordText.Text) && passwordText.Text.Length == 6)
                        {
                            MySqlConnection conn = loginForm.databaseConnection();
                            string sql = $"INSERT INTO member (fname,sname,passcode,phone,point) VALUES ('{fname}','{sname}','{passwordText.Text}','{phone}','0')";
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
                            MessageBox.Show("รหัสผ่านต้องเป็นตัวเลข 6 ตัวอักษร", "ERROR");
                        }
                    } else
                    {
                        MessageBox.Show("เบอร์โทรศัพท์ไม่ถูกต้อง\n(ต้องเป็นตัวเลข 10 ตัวเท่านั้น)", "ERROR");
                    }
                } else
                {
                    MessageBox.Show("ชื่อ-สกุล ต้องเป็นตัวอักษรเท่านั้น", "ERROR");
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
                int point = Convert.ToInt32(pointText.Text);
                string phone = phoneText.Text;
                if (checkAlpha(fName) && checkAlpha(sName))
                {
                    if (checkNumeric(phone) && phone.Length == 10)
                    {
                        if (checkNumeric(passwordText.Text) && passwordText.Text.Length == 6)
                        {
                            MySqlConnection conn = loginForm.databaseConnection();

                            string sql = $"UPDATE member SET fname = '{fName}', sname = '{sName}', passcode = '{passwordText.Text}', point = '{point}' WHERE id = '{id}'";

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
                        else
                        {
                            MessageBox.Show("รหัสผ่านต้องเป็นตัวเลข 6 ตัวอักษรเท่านั้น");
                        }
                    }
                    else
                    {
                        MessageBox.Show("เบอร์โทรศัพท์ไม่ถูกต้อง\n(ต้องเป็นตัวเลข 10 ตัวเท่านั้น)", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("ชื่อ-สกุล ต้องเป็นตัวอักษรเท่านั้น", "ERROR");
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            memberData.CurrentRow.Selected = false;
            memberIDText.Text = "";
            fNameText.Text = "";
            sNameText.Text = "";
            phoneText.Text = "";
            passwordText.Text = "";
            pointText.Text = "";
        }

        private void ticketBuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticket buyTicketForm = new ticket();
            buyTicketForm.Show();
            this.Hide();
        }

        private void ticketHistoryClick(object sender, EventArgs e)
        {
            ticketHistory tHistory = new ticketHistory();
            tHistory.Show();
        }

        private void showPasswordCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (showPasswordCheck.Checked)
            {
                passwordText.UseSystemPasswordChar = false;
            } else
            {
                passwordText.UseSystemPasswordChar = true;
            }
        }

        private void computer_menuStripClick(object sender, EventArgs e)
        {
            computerForm computerForm = new computerForm();
            computerForm.Show();
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

        private void exit_menuStripClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

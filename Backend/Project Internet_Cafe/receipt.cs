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
    public partial class receipt : Form
    {
        MySqlConnection conn = loginForm.databaseConnection();
        public receipt()
        {
            InitializeComponent();
        }

        private string[] getData(int ticketID)
        {
            string sql = $"SELECT * FROM ticket WHERE id = '{ticketID}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> data = new List<string>();

            while (reader.Read())
            {
                data.Add(reader.GetString("user"));
                data.Add(reader.GetString("password"));
                data.Add(reader.GetString("time"));
            }

            conn.Close();

            sql = $"SELECT * FROM tickethistory WHERE id = '{ticketID}'";
            cmd = new MySqlCommand(sql, conn);
            conn.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data.Add(reader.GetString("timestamp"));
                data.Add(reader.GetString("price"));
                data.Add(reader.GetString("pointreceived"));
                data.Add(reader.GetString("pointused"));
            }

            conn.Close();

            string[] dataList = data.ToArray();

            return dataList; // [0 phone, 1 password, 2 time, 3 timestamp, 4 price, 5 pointre, 6 pointused]
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            ticketHistory ticketHistory = new ticketHistory();
            int ticketID = ticketHistory.ticketIDGlobal;
            string name = computerForm.getName(ticketID);
            string[] dataList = getData(ticketID);

            ticketIDLabel.Text = "Ticket ID : " + ticketID.ToString();
            if (name.ToString().Contains("guest"))
            {
                nameLabel.Text = "ชื่อผู้ซื้อ : guest";
            } else
            {
                nameLabel.Text = "ชื่อผู้ซื้อ : " + name.ToString();
            }
            timeLabel.Text = "เวลา : " + Convert.ToDateTime(dataList[3]).ToString("dd-MM-yyyy HH:mm:ss");
            hourLabel.Text = "จำนวนชั่วโมง \n" + Convert.ToDateTime(dataList[2]).Hour + " ชั่วโมง";
            priceLabel.Text = "ราคา \n" + Convert.ToDateTime(dataList[2]).Hour * computerForm.price + "";
            pointUsedLabel.Text = "แต้มที่ใช้ : " + dataList[6] + " แต้ม";
            discountLabel.Text = "ส่วนลด : " + ((Convert.ToDateTime(dataList[2]).Hour * computerForm.price) - Convert.ToInt32(dataList[4])) + " บาท";
            totalPriceLabel.Text = "รวมเป็นเงิน : " + dataList[4] + " บาท";
            pointReceivedLabel.Text = "ได้รับแต้ม : " + dataList[5] + " แต้ม";
            if (dataList[1] == "-")
            {
                passwordLabel.Text = "รหัสผ่าน : (-)";
            } else
            {
                passwordLabel.Text = "รหัสผ่าน : " + dataList[1];
            }

        }
    }
}

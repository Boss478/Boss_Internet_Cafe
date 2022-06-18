namespace Project_Internet_Cafe
{
    partial class ticket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สมาชกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ประวตการซอToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากโปรแกรมToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.userPhoneText = new System.Windows.Forms.TextBox();
            this.notMemberCheck = new System.Windows.Forms.CheckBox();
            this.timeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.moneyCalText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pointCalText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.userPointText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.usePointText = new System.Windows.Forms.ComboBox();
            this.discountText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ticketDataView = new System.Windows.Forms.DataGridView();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem,
            this.สมาชกToolStripMenuItem,
            this.ออกจากโปรแกรมToolStripMenuItem,
            this.ออกจากโปรแกรมToolStripMenuItem1});
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.goToolStripMenuItem.Text = "Go";
            // 
            // ตรวจสอบคอมพวเตอรToolStripMenuItem
            // 
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem.Name = "ตรวจสอบคอมพวเตอรToolStripMenuItem";
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem.Text = "ตรวจสอบคอมพิวเตอร์";
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem.Click += new System.EventHandler(this.computer_menuStripClick);
            // 
            // สมาชกToolStripMenuItem
            // 
            this.สมาชกToolStripMenuItem.Name = "สมาชกToolStripMenuItem";
            this.สมาชกToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.สมาชกToolStripMenuItem.Text = "สมาชิก";
            this.สมาชกToolStripMenuItem.Click += new System.EventHandler(this.member_menuStripClick);
            // 
            // ออกจากโปรแกรมToolStripMenuItem
            // 
            this.ออกจากโปรแกรมToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ประวตการซอToolStripMenuItem});
            this.ออกจากโปรแกรมToolStripMenuItem.Name = "ออกจากโปรแกรมToolStripMenuItem";
            this.ออกจากโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ออกจากโปรแกรมToolStripMenuItem.Text = "ตั๋วชั่วโมง";
            // 
            // ประวตการซอToolStripMenuItem
            // 
            this.ประวตการซอToolStripMenuItem.Name = "ประวตการซอToolStripMenuItem";
            this.ประวตการซอToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ประวตการซอToolStripMenuItem.Text = "ประวัติการซื้อ";
            this.ประวตการซอToolStripMenuItem.Click += new System.EventHandler(this.ticketHistory_menuStripClick);
            // 
            // ออกจากโปรแกรมToolStripMenuItem1
            // 
            this.ออกจากโปรแกรมToolStripMenuItem1.Name = "ออกจากโปรแกรมToolStripMenuItem1";
            this.ออกจากโปรแกรมToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ออกจากโปรแกรมToolStripMenuItem1.Text = "ออกจากโปรแกรม";
            this.ออกจากโปรแกรมToolStripMenuItem1.Click += new System.EventHandler(this.exit_menuStripClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(281, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "เบอร์โทรศัพท์ :";
            // 
            // userPhoneText
            // 
            this.userPhoneText.BackColor = System.Drawing.Color.White;
            this.userPhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.userPhoneText.Location = new System.Drawing.Point(408, 40);
            this.userPhoneText.Name = "userPhoneText";
            this.userPhoneText.Size = new System.Drawing.Size(167, 26);
            this.userPhoneText.TabIndex = 5;
            this.userPhoneText.TextChanged += new System.EventHandler(this.phoneTextChange);
            // 
            // notMemberCheck
            // 
            this.notMemberCheck.AutoSize = true;
            this.notMemberCheck.Location = new System.Drawing.Point(408, 72);
            this.notMemberCheck.Name = "notMemberCheck";
            this.notMemberCheck.Size = new System.Drawing.Size(104, 17);
            this.notMemberCheck.TabIndex = 6;
            this.notMemberCheck.Text = "ไม่ได้เป็นสมาชิก";
            this.notMemberCheck.UseVisualStyleBackColor = true;
            this.notMemberCheck.CheckedChanged += new System.EventHandler(this.notMemberCheck_CheckedChanged);
            // 
            // timeText
            // 
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.timeText.Location = new System.Drawing.Point(408, 95);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(167, 26);
            this.timeText.TabIndex = 8;
            this.timeText.Text = "0";
            this.timeText.TextChanged += new System.EventHandler(this.timeText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(281, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "จำนวนชั่วโมง :";
            // 
            // moneyCalText
            // 
            this.moneyCalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.moneyCalText.Location = new System.Drawing.Point(366, 198);
            this.moneyCalText.Name = "moneyCalText";
            this.moneyCalText.ReadOnly = true;
            this.moneyCalText.Size = new System.Drawing.Size(101, 26);
            this.moneyCalText.TabIndex = 15;
            this.moneyCalText.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(269, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "คิดเป็นเงิน :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(472, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "บาท";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(472, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "แต้ม";
            // 
            // pointCalText
            // 
            this.pointCalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pointCalText.Location = new System.Drawing.Point(366, 230);
            this.pointCalText.Name = "pointCalText";
            this.pointCalText.ReadOnly = true;
            this.pointCalText.Size = new System.Drawing.Size(101, 26);
            this.pointCalText.TabIndex = 18;
            this.pointCalText.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(305, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "ได้รับ :";
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buyButton.Location = new System.Drawing.Point(288, 272);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(125, 44);
            this.buyButton.TabIndex = 20;
            this.buyButton.Text = "ซื้อ";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.clearButton.Location = new System.Drawing.Point(441, 272);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 44);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "ล้างข้อมูล";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // userPointText
            // 
            this.userPointText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.userPointText.Location = new System.Drawing.Point(366, 131);
            this.userPointText.Name = "userPointText";
            this.userPointText.ReadOnly = true;
            this.userPointText.Size = new System.Drawing.Size(94, 26);
            this.userPointText.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(288, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "แต้มที่มี :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(281, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "แต้มที่ใช้ :";
            // 
            // usePointText
            // 
            this.usePointText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.usePointText.FormattingEnabled = true;
            this.usePointText.Items.AddRange(new object[] {
            "0",
            "20",
            "50",
            "75",
            "100",
            "150",
            "300",
            "500",
            "800",
            "1000"});
            this.usePointText.Location = new System.Drawing.Point(366, 164);
            this.usePointText.Name = "usePointText";
            this.usePointText.Size = new System.Drawing.Size(94, 28);
            this.usePointText.TabIndex = 25;
            this.usePointText.Text = "0";
            this.usePointText.SelectedIndexChanged += new System.EventHandler(this.usePointText_SelectedIndexChanged);
            this.usePointText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // discountText
            // 
            this.discountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.discountText.Location = new System.Drawing.Point(480, 167);
            this.discountText.Name = "discountText";
            this.discountText.ReadOnly = true;
            this.discountText.Size = new System.Drawing.Size(63, 22);
            this.discountText.TabIndex = 26;
            this.discountText.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(477, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "ส่วนลด :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(548, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "บาท";
            // 
            // ticketDataView
            // 
            this.ticketDataView.AllowUserToAddRows = false;
            this.ticketDataView.AllowUserToDeleteRows = false;
            this.ticketDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataView.Location = new System.Drawing.Point(13, 28);
            this.ticketDataView.Name = "ticketDataView";
            this.ticketDataView.ReadOnly = true;
            this.ticketDataView.Size = new System.Drawing.Size(250, 288);
            this.ticketDataView.TabIndex = 29;
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 327);
            this.Controls.Add(this.ticketDataView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.discountText);
            this.Controls.Add(this.usePointText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.userPointText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pointCalText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moneyCalText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notMemberCheck);
            this.Controls.Add(this.userPhoneText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ticket";
            this.Text = "ระบบซื้อตั๋ว";
            this.Load += new System.EventHandler(this.ticket_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตรวจสอบคอมพวเตอรToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สมาชกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ประวตการซอToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากโปรแกรมToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userPhoneText;
        private System.Windows.Forms.CheckBox notMemberCheck;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moneyCalText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pointCalText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox userPointText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox usePointText;
        private System.Windows.Forms.TextBox discountText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView ticketDataView;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
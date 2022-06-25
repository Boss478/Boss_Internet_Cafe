namespace Project_Internet_Cafe
{
    partial class computerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(computerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตรวจสอบสมาชกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตรวจสอบประวตการซอตวToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ซอตวToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ประวตการซอToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.computerIDText = new System.Windows.Forms.TextBox();
            this.availableText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startTimeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.endTimeText = new System.Windows.Forms.TextBox();
            this.hourText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.remainText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ตรวจสอบสมาชกToolStripMenuItem,
            this.ตรวจสอบประวตการซอตวToolStripMenuItem,
            this.ออกจากโปรแกรมToolStripMenuItem});
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.goToolStripMenuItem.Text = "Go";
            // 
            // ตรวจสอบสมาชกToolStripMenuItem
            // 
            this.ตรวจสอบสมาชกToolStripMenuItem.Name = "ตรวจสอบสมาชกToolStripMenuItem";
            this.ตรวจสอบสมาชกToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ตรวจสอบสมาชกToolStripMenuItem.Text = "สมาชิก";
            this.ตรวจสอบสมาชกToolStripMenuItem.Click += new System.EventHandler(this.member_menuStripClick);
            // 
            // ตรวจสอบประวตการซอตวToolStripMenuItem
            // 
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ซอตวToolStripMenuItem,
            this.ประวตการซอToolStripMenuItem1});
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.Name = "ตรวจสอบประวตการซอตวToolStripMenuItem";
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.Text = "ตั๋วชั่วโมง";
            // 
            // ซอตวToolStripMenuItem
            // 
            this.ซอตวToolStripMenuItem.Name = "ซอตวToolStripMenuItem";
            this.ซอตวToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ซอตวToolStripMenuItem.Text = "ซื้อตั๋ว";
            this.ซอตวToolStripMenuItem.Click += new System.EventHandler(this.buyTicket_menuStripClick);
            // 
            // ประวตการซอToolStripMenuItem1
            // 
            this.ประวตการซอToolStripMenuItem1.Name = "ประวตการซอToolStripMenuItem1";
            this.ประวตการซอToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.ประวตการซอToolStripMenuItem1.Text = "ประวัติการซื้อ";
            this.ประวตการซอToolStripMenuItem1.Click += new System.EventHandler(this.ticketHistory_menuStripClick);
            // 
            // ออกจากโปรแกรมToolStripMenuItem
            // 
            this.ออกจากโปรแกรมToolStripMenuItem.Name = "ออกจากโปรแกรมToolStripMenuItem";
            this.ออกจากโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ออกจากโปรแกรมToolStripMenuItem.Text = "ออกจากโปรแกรม";
            this.ออกจากโปรแกรมToolStripMenuItem.Click += new System.EventHandler(this.exit_menuStripClick);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // computerData
            // 
            this.computerData.AllowUserToAddRows = false;
            this.computerData.AllowUserToDeleteRows = false;
            this.computerData.AllowUserToResizeColumns = false;
            this.computerData.AllowUserToResizeRows = false;
            this.computerData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.computerData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.computerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerData.Location = new System.Drawing.Point(25, 36);
            this.computerData.Name = "computerData";
            this.computerData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.computerData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.computerData.RowHeadersVisible = false;
            this.computerData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.computerData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.computerData.Size = new System.Drawing.Size(220, 263);
            this.computerData.TabIndex = 1;
            this.computerData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.computerData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(275, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Computer ID : ";
            // 
            // computerIDText
            // 
            this.computerIDText.BackColor = System.Drawing.Color.White;
            this.computerIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.computerIDText.Location = new System.Drawing.Point(422, 36);
            this.computerIDText.Name = "computerIDText";
            this.computerIDText.ReadOnly = true;
            this.computerIDText.Size = new System.Drawing.Size(154, 26);
            this.computerIDText.TabIndex = 3;
            this.computerIDText.TextChanged += new System.EventHandler(this.computerIDText_TextChanged);
            // 
            // availableText
            // 
            this.availableText.BackColor = System.Drawing.Color.White;
            this.availableText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.availableText.Location = new System.Drawing.Point(422, 75);
            this.availableText.Name = "availableText";
            this.availableText.ReadOnly = true;
            this.availableText.Size = new System.Drawing.Size(154, 26);
            this.availableText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(278, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "สถานะของเครื่อง : ";
            // 
            // userText
            // 
            this.userText.BackColor = System.Drawing.Color.White;
            this.userText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.userText.Location = new System.Drawing.Point(282, 137);
            this.userText.Name = "userText";
            this.userText.ReadOnly = true;
            this.userText.Size = new System.Drawing.Size(294, 26);
            this.userText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(278, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "เครื่องถูกใช้โดย :";
            // 
            // startTimeText
            // 
            this.startTimeText.BackColor = System.Drawing.Color.White;
            this.startTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.startTimeText.Location = new System.Drawing.Point(282, 202);
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.ReadOnly = true;
            this.startTimeText.Size = new System.Drawing.Size(142, 26);
            this.startTimeText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(278, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "เวลา : (เริ่มต้น - สิ้นสุด)";
            // 
            // endTimeText
            // 
            this.endTimeText.BackColor = System.Drawing.Color.White;
            this.endTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.endTimeText.Location = new System.Drawing.Point(430, 202);
            this.endTimeText.Name = "endTimeText";
            this.endTimeText.ReadOnly = true;
            this.endTimeText.Size = new System.Drawing.Size(146, 26);
            this.endTimeText.TabIndex = 10;
            // 
            // hourText
            // 
            this.hourText.BackColor = System.Drawing.Color.White;
            this.hourText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.hourText.Location = new System.Drawing.Point(361, 238);
            this.hourText.Name = "hourText";
            this.hourText.ReadOnly = true;
            this.hourText.Size = new System.Drawing.Size(98, 26);
            this.hourText.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(275, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ระยะเวลา :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(465, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "ชั่วโมง";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(305, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "เหลือ :";
            // 
            // remainText
            // 
            this.remainText.BackColor = System.Drawing.Color.White;
            this.remainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.remainText.Location = new System.Drawing.Point(361, 273);
            this.remainText.Name = "remainText";
            this.remainText.ReadOnly = true;
            this.remainText.Size = new System.Drawing.Size(98, 26);
            this.remainText.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(465, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "ชั่วโมง";
            // 
            // computerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(588, 314);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.remainText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hourText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endTimeText);
            this.Controls.Add(this.startTimeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.availableText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.computerIDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computerData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "computerForm";
            this.Text = "ระบบผู้ดูแล";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.computerForm_FormClosing);
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตรวจสอบสมาชกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตรวจสอบประวตการซอตวToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView computerData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox computerIDText;
        private System.Windows.Forms.TextBox availableText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startTimeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endTimeText;
        private System.Windows.Forms.TextBox hourText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox remainText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem ซอตวToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ประวตการซอToolStripMenuItem1;
    }
}
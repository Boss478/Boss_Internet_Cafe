namespace Project_Internet_Cafe
{
    partial class ticketHistory
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
            this.ticketDataView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สมาชกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตวชวโมงToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตออายToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketIDText = new System.Windows.Forms.TextBox();
            this.buyTimeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.hourTimeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pointReText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pointUseText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.showReceiptButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketDataView
            // 
            this.ticketDataView.AllowUserToAddRows = false;
            this.ticketDataView.AllowUserToDeleteRows = false;
            this.ticketDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataView.Location = new System.Drawing.Point(12, 54);
            this.ticketDataView.Name = "ticketDataView";
            this.ticketDataView.ReadOnly = true;
            this.ticketDataView.Size = new System.Drawing.Size(699, 209);
            this.ticketDataView.TabIndex = 0;
            this.ticketDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketDataView_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem,
            this.สมาชกToolStripMenuItem,
            this.ตวชวโมงToolStripMenuItem,
            this.ออกจากโปรแกรมToolStripMenuItem});
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
            // ตวชวโมงToolStripMenuItem
            // 
            this.ตวชวโมงToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ตออายToolStripMenuItem});
            this.ตวชวโมงToolStripMenuItem.Name = "ตวชวโมงToolStripMenuItem";
            this.ตวชวโมงToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ตวชวโมงToolStripMenuItem.Text = "ตั๋วชั่วโมง";
            // 
            // ตออายToolStripMenuItem
            // 
            this.ตออายToolStripMenuItem.Name = "ตออายToolStripMenuItem";
            this.ตออายToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ตออายToolStripMenuItem.Text = "ซื้อตั๋ว";
            this.ตออายToolStripMenuItem.Click += new System.EventHandler(this.buyTicket_menuStripClick);
            // 
            // ออกจากโปรแกรมToolStripMenuItem
            // 
            this.ออกจากโปรแกรมToolStripMenuItem.Name = "ออกจากโปรแกรมToolStripMenuItem";
            this.ออกจากโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ticket ID :";
            // 
            // ticketIDText
            // 
            this.ticketIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ticketIDText.Location = new System.Drawing.Point(109, 277);
            this.ticketIDText.Name = "ticketIDText";
            this.ticketIDText.ReadOnly = true;
            this.ticketIDText.Size = new System.Drawing.Size(94, 26);
            this.ticketIDText.TabIndex = 3;
            // 
            // buyTimeText
            // 
            this.buyTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buyTimeText.Location = new System.Drawing.Point(109, 320);
            this.buyTimeText.Name = "buyTimeText";
            this.buyTimeText.ReadOnly = true;
            this.buyTimeText.Size = new System.Drawing.Size(254, 26);
            this.buyTimeText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "เวลาที่ซื้อ :";
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nameText.Location = new System.Drawing.Point(271, 277);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(222, 26);
            this.nameText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(217, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ผู้ซื้อ :";
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.phoneText.Location = new System.Drawing.Point(517, 277);
            this.phoneText.Name = "phoneText";
            this.phoneText.ReadOnly = true;
            this.phoneText.Size = new System.Drawing.Size(157, 26);
            this.phoneText.TabIndex = 8;
            // 
            // hourTimeText
            // 
            this.hourTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.hourTimeText.Location = new System.Drawing.Point(109, 364);
            this.hourTimeText.Name = "hourTimeText";
            this.hourTimeText.ReadOnly = true;
            this.hourTimeText.Size = new System.Drawing.Size(176, 26);
            this.hourTimeText.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(12, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "เวลา :";
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.priceText.Location = new System.Drawing.Point(484, 320);
            this.priceText.Name = "priceText";
            this.priceText.ReadOnly = true;
            this.priceText.Size = new System.Drawing.Size(108, 26);
            this.priceText.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(401, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ราคา :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(598, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "บาท";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(598, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "แต้ม";
            // 
            // pointReText
            // 
            this.pointReText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pointReText.Location = new System.Drawing.Point(484, 352);
            this.pointReText.Name = "pointReText";
            this.pointReText.ReadOnly = true;
            this.pointReText.Size = new System.Drawing.Size(108, 26);
            this.pointReText.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(384, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "แต้มที่ได้รับ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(223, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "แต้ม";
            // 
            // pointUseText
            // 
            this.pointUseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pointUseText.Location = new System.Drawing.Point(109, 405);
            this.pointUseText.Name = "pointUseText";
            this.pointUseText.ReadOnly = true;
            this.pointUseText.Size = new System.Drawing.Size(108, 26);
            this.pointUseText.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(9, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "แต้มที่ใช้ :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(291, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "ชั่วโมง";
            // 
            // showReceiptButton
            // 
            this.showReceiptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.showReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.showReceiptButton.Location = new System.Drawing.Point(463, 386);
            this.showReceiptButton.Name = "showReceiptButton";
            this.showReceiptButton.Size = new System.Drawing.Size(138, 47);
            this.showReceiptButton.TabIndex = 21;
            this.showReceiptButton.Text = "แสดงใบเสร็จ";
            this.showReceiptButton.UseVisualStyleBackColor = false;
            this.showReceiptButton.Click += new System.EventHandler(this.showReceiptButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(12, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "แสดง :";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "(all)";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.searchButton.Location = new System.Drawing.Point(266, 27);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 23);
            this.searchButton.TabIndex = 24;
            this.searchButton.Text = "ค้นหา";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ticketHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 445);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.showReceiptButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pointUseText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pointReText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hourTimeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buyTimeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketIDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketDataView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ticketHistory";
            this.Text = "ประวัติการซื้อตั๋ว";
            this.Load += new System.EventHandler(this.ticketHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ticketDataView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตรวจสอบคอมพวเตอรToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สมาชกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตวชวโมงToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตออายToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ticketIDText;
        private System.Windows.Forms.TextBox buyTimeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox hourTimeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pointReText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pointUseText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button showReceiptButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchButton;
    }
}
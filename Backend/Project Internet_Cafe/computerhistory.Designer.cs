namespace Project_Internet_Cafe
{
    partial class computerhistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตรวจสอบเครองToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สมาชกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตวชวโมงToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตออายToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ประวตการซอToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ตรวจสอบเครองToolStripMenuItem});
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem.Name = "ตรวจสอบคอมพวเตอรToolStripMenuItem";
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem.Text = "คอมพิวเตอร์";
            // 
            // ตรวจสอบเครองToolStripMenuItem
            // 
            this.ตรวจสอบเครองToolStripMenuItem.Name = "ตรวจสอบเครองToolStripMenuItem";
            this.ตรวจสอบเครองToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ตรวจสอบเครองToolStripMenuItem.Text = "ตรวจสอบเครื่อง";
            this.ตรวจสอบเครองToolStripMenuItem.Click += new System.EventHandler(this.computerAvailableCheck_Click);
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
            this.ตออายToolStripMenuItem,
            this.ประวตการซอToolStripMenuItem});
            this.ตวชวโมงToolStripMenuItem.Name = "ตวชวโมงToolStripMenuItem";
            this.ตวชวโมงToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ตวชวโมงToolStripMenuItem.Text = "ตั๋วชั่วโมง";
            // 
            // ตออายToolStripMenuItem
            // 
            this.ตออายToolStripMenuItem.Name = "ตออายToolStripMenuItem";
            this.ตออายToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ตออายToolStripMenuItem.Text = "ซื้อตั๋ว";
            this.ตออายToolStripMenuItem.Click += new System.EventHandler(this.buyTicket_menuStripClick);
            // 
            // ประวตการซอToolStripMenuItem
            // 
            this.ประวตการซอToolStripMenuItem.Name = "ประวตการซอToolStripMenuItem";
            this.ประวตการซอToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ประวตการซอToolStripMenuItem.Text = "ประวัติการซื้อ";
            this.ประวตการซอToolStripMenuItem.Click += new System.EventHandler(this.ticketHistory_menuStripClick);
            // 
            // ออกจากโปรแกรมToolStripMenuItem
            // 
            this.ออกจากโปรแกรมToolStripMenuItem.Name = "ออกจากโปรแกรมToolStripMenuItem";
            this.ออกจากโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ออกจากโปรแกรมToolStripMenuItem.Text = "ออกจากโปรแกรม";
            this.ออกจากโปรแกรมToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(603, 407);
            this.dataGridView1.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.searchButton.Location = new System.Drawing.Point(465, 32);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 23);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "ค้นหา";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(11, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "แสดง :";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "(all)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(375, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "ตรวจสอบวัน";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // computerhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(627, 479);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "computerhistory";
            this.Text = "ประวัติการ Login";
            this.Load += new System.EventHandler(this.computerhistory_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตรวจสอบคอมพวเตอรToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สมาชกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตวชวโมงToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตออายToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตรวจสอบเครองToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem ประวตการซอToolStripMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
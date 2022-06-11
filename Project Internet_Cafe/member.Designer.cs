namespace Project_Internet_Cafe
{
    partial class memberForm
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
            this.ตรวจสอบประวตการซอตวToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ซอตวToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ประวตการซอToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.memberIDText = new System.Windows.Forms.TextBox();
            this.fNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pointText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sNameText = new System.Windows.Forms.TextBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.editMemberButton = new System.Windows.Forms.Button();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem,
            this.ตรวจสอบประวตการซอตวToolStripMenuItem,
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
            this.ตรวจสอบคอมพวเตอรToolStripMenuItem.Click += new System.EventHandler(this.computerCheckToolStripMenuItem_Click);
            // 
            // ตรวจสอบประวตการซอตวToolStripMenuItem
            // 
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ซอตวToolStripMenuItem,
            this.ประวตการซอToolStripMenuItem1});
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.Name = "ตรวจสอบประวตการซอตวToolStripMenuItem";
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.Text = "ตั๋วชั่วโมง";
            // 
            // ซอตวToolStripMenuItem
            // 
            this.ซอตวToolStripMenuItem.Name = "ซอตวToolStripMenuItem";
            this.ซอตวToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ซอตวToolStripMenuItem.Text = "ซื้อตั๋ว";
            this.ซอตวToolStripMenuItem.Click += new System.EventHandler(this.ticketBuyToolStripMenuItem_Click);
            // 
            // ประวตการซอToolStripMenuItem1
            // 
            this.ประวตการซอToolStripMenuItem1.Name = "ประวตการซอToolStripMenuItem1";
            this.ประวตการซอToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ประวตการซอToolStripMenuItem1.Text = "ประวัติการซื้อ";
            this.ประวตการซอToolStripMenuItem1.Click += new System.EventHandler(this.ticketHistoryClick);
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
            // memberData
            // 
            this.memberData.AllowUserToAddRows = false;
            this.memberData.AllowUserToDeleteRows = false;
            this.memberData.AllowUserToResizeRows = false;
            this.memberData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberData.Location = new System.Drawing.Point(13, 28);
            this.memberData.Name = "memberData";
            this.memberData.ReadOnly = true;
            this.memberData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.memberData.Size = new System.Drawing.Size(389, 338);
            this.memberData.TabIndex = 1;
            this.memberData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberCellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(417, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Member ID :";
            // 
            // memberIDText
            // 
            this.memberIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.memberIDText.Location = new System.Drawing.Point(530, 37);
            this.memberIDText.Name = "memberIDText";
            this.memberIDText.ReadOnly = true;
            this.memberIDText.Size = new System.Drawing.Size(106, 26);
            this.memberIDText.TabIndex = 3;
            // 
            // fNameText
            // 
            this.fNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fNameText.Location = new System.Drawing.Point(421, 108);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(156, 26);
            this.fNameText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(417, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ชื่อ - นามสกุล : ";
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.phoneText.Location = new System.Drawing.Point(421, 164);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(322, 26);
            this.phoneText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(417, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "เบอร์โทรศัพท์ :";
            // 
            // pointText
            // 
            this.pointText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pointText.Location = new System.Drawing.Point(491, 209);
            this.pointText.Name = "pointText";
            this.pointText.Size = new System.Drawing.Size(253, 26);
            this.pointText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(418, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "คะแนน :";
            // 
            // sNameText
            // 
            this.sNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.sNameText.Location = new System.Drawing.Point(587, 108);
            this.sNameText.Name = "sNameText";
            this.sNameText.Size = new System.Drawing.Size(156, 26);
            this.sNameText.TabIndex = 12;
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.addMemberButton.Location = new System.Drawing.Point(444, 255);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(112, 50);
            this.addMemberButton.TabIndex = 13;
            this.addMemberButton.Text = "เพิ่มสมาชิก";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // editMemberButton
            // 
            this.editMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.editMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.editMemberButton.Location = new System.Drawing.Point(444, 316);
            this.editMemberButton.Name = "editMemberButton";
            this.editMemberButton.Size = new System.Drawing.Size(112, 50);
            this.editMemberButton.TabIndex = 14;
            this.editMemberButton.Text = "แก้ไขสมาชิก";
            this.editMemberButton.UseVisualStyleBackColor = false;
            this.editMemberButton.Click += new System.EventHandler(this.editMemberButton_Click);
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.deleteMemberButton.Location = new System.Drawing.Point(609, 316);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(112, 50);
            this.deleteMemberButton.TabIndex = 15;
            this.deleteMemberButton.Text = "ลบสมาชิก";
            this.deleteMemberButton.UseVisualStyleBackColor = false;
            this.deleteMemberButton.Click += new System.EventHandler(this.deleteMemberButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.clearButton.Location = new System.Drawing.Point(609, 255);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 50);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "ล้างข้อมูล";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // memberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 377);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.editMemberButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.sNameText);
            this.Controls.Add(this.pointText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberIDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "memberForm";
            this.Text = "ระบบจัดการสมาชิก";
            this.Load += new System.EventHandler(this.memberForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตรวจสอบคอมพวเตอรToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตรวจสอบประวตการซอตวToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.DataGridView memberData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberIDText;
        private System.Windows.Forms.TextBox fNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pointText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sNameText;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button editMemberButton;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ToolStripMenuItem ซอตวToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ประวตการซอToolStripMenuItem1;
    }
}
﻿namespace Project_Internet_Cafe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตรวจสอบสมาชกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตรวจสอบประวตการซอตวToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ตรวจสอบสมาชกToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ตรวจสอบสมาชกToolStripMenuItem.Text = "สมาชิก";
            this.ตรวจสอบสมาชกToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // ตรวจสอบประวตการซอตวToolStripMenuItem
            // 
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.Name = "ตรวจสอบประวตการซอตวToolStripMenuItem";
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ตรวจสอบประวตการซอตวToolStripMenuItem.Text = "ตรวจสอบประวัติการซื้อตั๋ว";
            // 
            // ออกจากโปรแกรมToolStripMenuItem
            // 
            this.ออกจากโปรแกรมToolStripMenuItem.Name = "ออกจากโปรแกรมToolStripMenuItem";
            this.ออกจากโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ออกจากโปรแกรมToolStripMenuItem.Text = "ออกจากโปรแกรม";
            this.ออกจากโปรแกรมToolStripMenuItem.Click += new System.EventHandler(this.exitProgramClick);
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
            this.computerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerData.Location = new System.Drawing.Point(12, 39);
            this.computerData.Name = "computerData";
            this.computerData.ReadOnly = true;
            this.computerData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.computerData.Size = new System.Drawing.Size(242, 344);
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
            this.computerIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.computerIDText.Location = new System.Drawing.Point(422, 36);
            this.computerIDText.Name = "computerIDText";
            this.computerIDText.ReadOnly = true;
            this.computerIDText.Size = new System.Drawing.Size(154, 26);
            this.computerIDText.TabIndex = 3;
            // 
            // availableText
            // 
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
            this.endTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.endTimeText.Location = new System.Drawing.Point(430, 202);
            this.endTimeText.Name = "endTimeText";
            this.endTimeText.ReadOnly = true;
            this.endTimeText.Size = new System.Drawing.Size(146, 26);
            this.endTimeText.TabIndex = 10;
            // 
            // hourText
            // 
            this.hourText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.hourText.Location = new System.Drawing.Point(347, 238);
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
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "คิดเป็น :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(451, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "ชั่วโมง";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(287, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "เหลือ :";
            // 
            // remainText
            // 
            this.remainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.remainText.Location = new System.Drawing.Point(347, 273);
            this.remainText.Name = "remainText";
            this.remainText.ReadOnly = true;
            this.remainText.Size = new System.Drawing.Size(98, 26);
            this.remainText.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(451, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "ชั่วโมง";
            // 
            // computerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 399);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "computerForm";
            this.Text = "ระบบผู้ดูแล";
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
    }
}
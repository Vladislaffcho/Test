﻿namespace TvForms
{
    partial class UcAdminView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.cbAccountStatus = new System.Windows.Forms.CheckBox();
            this.btViewPayment = new System.Windows.Forms.Button();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.btViewChannels = new System.Windows.Forms.Button();
            this.btViewServices = new System.Windows.Forms.Button();
            this.btViewOrders = new System.Windows.Forms.Button();
            this.cbAdultContent = new System.Windows.Forms.CheckBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.tcUserContacts = new System.Windows.Forms.TabControl();
            this.tpAddress = new System.Windows.Forms.TabPage();
            this.lvUserAddress = new System.Windows.Forms.ListView();
            this.colTypeAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommentAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpEmail = new System.Windows.Forms.TabPage();
            this.lvUserEmail = new System.Windows.Forms.ListView();
            this.colTypeEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommentEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpTelephone = new System.Windows.Forms.TabPage();
            this.lvUserTelephone = new System.Windows.Forms.ListView();
            this.colTypeTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommentTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUserList = new System.Windows.Forms.ListView();
            this.colUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbUserType = new System.Windows.Forms.Label();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.gbUsers.SuspendLayout();
            this.tcUserContacts.SuspendLayout();
            this.tpAddress.SuspendLayout();
            this.tpEmail.SuspendLayout();
            this.tpTelephone.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.cbUserType);
            this.gbUsers.Controls.Add(this.lbUserType);
            this.gbUsers.Controls.Add(this.cbAccountStatus);
            this.gbUsers.Controls.Add(this.btViewPayment);
            this.gbUsers.Controls.Add(this.lbSurname);
            this.gbUsers.Controls.Add(this.lbName);
            this.gbUsers.Controls.Add(this.tbName);
            this.gbUsers.Controls.Add(this.tbSurname);
            this.gbUsers.Controls.Add(this.btViewChannels);
            this.gbUsers.Controls.Add(this.btViewServices);
            this.gbUsers.Controls.Add(this.btViewOrders);
            this.gbUsers.Controls.Add(this.cbAdultContent);
            this.gbUsers.Controls.Add(this.cbStatus);
            this.gbUsers.Controls.Add(this.lbStatus);
            this.gbUsers.Controls.Add(this.tbMoney);
            this.gbUsers.Controls.Add(this.lbMoney);
            this.gbUsers.Controls.Add(this.tcUserContacts);
            this.gbUsers.Controls.Add(this.lvUserList);
            this.gbUsers.Location = new System.Drawing.Point(3, 3);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(846, 449);
            this.gbUsers.TabIndex = 0;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Users";
            this.gbUsers.Enter += new System.EventHandler(this.gbUsers_Enter);
            // 
            // cbAccountStatus
            // 
            this.cbAccountStatus.AutoSize = true;
            this.cbAccountStatus.Location = new System.Drawing.Point(613, 118);
            this.cbAccountStatus.Name = "cbAccountStatus";
            this.cbAccountStatus.Size = new System.Drawing.Size(129, 17);
            this.cbAccountStatus.TabIndex = 16;
            this.cbAccountStatus.Text = "Active Billing Account";
            this.cbAccountStatus.UseVisualStyleBackColor = true;
            // 
            // btViewPayment
            // 
            this.btViewPayment.Location = new System.Drawing.Point(709, 49);
            this.btViewPayment.Name = "btViewPayment";
            this.btViewPayment.Size = new System.Drawing.Size(93, 21);
            this.btViewPayment.TabIndex = 15;
            this.btViewPayment.Text = "View Payment";
            this.btViewPayment.UseVisualStyleBackColor = true;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(393, 53);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(49, 13);
            this.lbSurname.TabIndex = 14;
            this.lbSurname.Text = "Surname";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(393, 20);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(459, 17);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(130, 20);
            this.tbName.TabIndex = 12;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(459, 50);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.ReadOnly = true;
            this.tbSurname.Size = new System.Drawing.Size(130, 20);
            this.tbSurname.TabIndex = 11;
            // 
            // btViewChannels
            // 
            this.btViewChannels.Location = new System.Drawing.Point(613, 49);
            this.btViewChannels.Name = "btViewChannels";
            this.btViewChannels.Size = new System.Drawing.Size(75, 21);
            this.btViewChannels.TabIndex = 10;
            this.btViewChannels.Text = "Channels";
            this.btViewChannels.UseVisualStyleBackColor = true;
            // 
            // btViewServices
            // 
            this.btViewServices.Location = new System.Drawing.Point(709, 16);
            this.btViewServices.Name = "btViewServices";
            this.btViewServices.Size = new System.Drawing.Size(93, 21);
            this.btViewServices.TabIndex = 9;
            this.btViewServices.Text = "View Services";
            this.btViewServices.UseVisualStyleBackColor = true;
            // 
            // btViewOrders
            // 
            this.btViewOrders.Location = new System.Drawing.Point(613, 16);
            this.btViewOrders.Name = "btViewOrders";
            this.btViewOrders.Size = new System.Drawing.Size(75, 21);
            this.btViewOrders.TabIndex = 8;
            this.btViewOrders.Text = "View Orders";
            this.btViewOrders.UseVisualStyleBackColor = true;
            // 
            // cbAdultContent
            // 
            this.cbAdultContent.AutoSize = true;
            this.cbAdultContent.Enabled = false;
            this.cbAdultContent.Location = new System.Drawing.Point(613, 85);
            this.cbAdultContent.Name = "cbAdultContent";
            this.cbAdultContent.Size = new System.Drawing.Size(90, 17);
            this.cbAdultContent.TabIndex = 7;
            this.cbAdultContent.Text = "Adult Content";
            this.cbAdultContent.UseVisualStyleBackColor = true;
            this.cbAdultContent.CheckedChanged += new System.EventHandler(this.cbAdultContent_CheckedChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Location = new System.Drawing.Point(459, 116);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(130, 21);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(393, 119);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Status";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(459, 83);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.ReadOnly = true;
            this.tbMoney.Size = new System.Drawing.Size(130, 20);
            this.tbMoney.TabIndex = 3;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(393, 86);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(39, 13);
            this.lbMoney.TabIndex = 2;
            this.lbMoney.Text = "Money";
            // 
            // tcUserContacts
            // 
            this.tcUserContacts.Controls.Add(this.tpAddress);
            this.tcUserContacts.Controls.Add(this.tpEmail);
            this.tcUserContacts.Controls.Add(this.tpTelephone);
            this.tcUserContacts.Location = new System.Drawing.Point(372, 190);
            this.tcUserContacts.Name = "tcUserContacts";
            this.tcUserContacts.SelectedIndex = 0;
            this.tcUserContacts.Size = new System.Drawing.Size(474, 255);
            this.tcUserContacts.TabIndex = 1;
            // 
            // tpAddress
            // 
            this.tpAddress.BackColor = System.Drawing.SystemColors.Control;
            this.tpAddress.Controls.Add(this.lvUserAddress);
            this.tpAddress.Location = new System.Drawing.Point(4, 22);
            this.tpAddress.Name = "tpAddress";
            this.tpAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddress.Size = new System.Drawing.Size(466, 229);
            this.tpAddress.TabIndex = 0;
            this.tpAddress.Text = "Address";
            // 
            // lvUserAddress
            // 
            this.lvUserAddress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTypeAddress,
            this.colNameAddress,
            this.colCommentAddress});
            this.lvUserAddress.FullRowSelect = true;
            this.lvUserAddress.GridLines = true;
            this.lvUserAddress.Location = new System.Drawing.Point(0, 0);
            this.lvUserAddress.Name = "lvUserAddress";
            this.lvUserAddress.Size = new System.Drawing.Size(464, 229);
            this.lvUserAddress.TabIndex = 0;
            this.lvUserAddress.UseCompatibleStateImageBehavior = false;
            this.lvUserAddress.View = System.Windows.Forms.View.Details;
            // 
            // colTypeAddress
            // 
            this.colTypeAddress.Text = "Type";
            this.colTypeAddress.Width = 74;
            // 
            // colNameAddress
            // 
            this.colNameAddress.Text = "Address";
            this.colNameAddress.Width = 180;
            // 
            // colCommentAddress
            // 
            this.colCommentAddress.Text = "Comment";
            this.colCommentAddress.Width = 206;
            // 
            // tpEmail
            // 
            this.tpEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tpEmail.Controls.Add(this.lvUserEmail);
            this.tpEmail.Location = new System.Drawing.Point(4, 22);
            this.tpEmail.Name = "tpEmail";
            this.tpEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmail.Size = new System.Drawing.Size(466, 229);
            this.tpEmail.TabIndex = 1;
            this.tpEmail.Text = "Email";
            // 
            // lvUserEmail
            // 
            this.lvUserEmail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTypeEmail,
            this.colNameEmail,
            this.colCommentEmail});
            this.lvUserEmail.FullRowSelect = true;
            this.lvUserEmail.GridLines = true;
            this.lvUserEmail.Location = new System.Drawing.Point(0, 0);
            this.lvUserEmail.Name = "lvUserEmail";
            this.lvUserEmail.Size = new System.Drawing.Size(464, 229);
            this.lvUserEmail.TabIndex = 0;
            this.lvUserEmail.UseCompatibleStateImageBehavior = false;
            this.lvUserEmail.View = System.Windows.Forms.View.Details;
            // 
            // colTypeEmail
            // 
            this.colTypeEmail.Text = "Type";
            this.colTypeEmail.Width = 74;
            // 
            // colNameEmail
            // 
            this.colNameEmail.Text = "Email";
            this.colNameEmail.Width = 180;
            // 
            // colCommentEmail
            // 
            this.colCommentEmail.Text = "Comment";
            this.colCommentEmail.Width = 206;
            // 
            // tpTelephone
            // 
            this.tpTelephone.BackColor = System.Drawing.SystemColors.Control;
            this.tpTelephone.Controls.Add(this.lvUserTelephone);
            this.tpTelephone.Location = new System.Drawing.Point(4, 22);
            this.tpTelephone.Name = "tpTelephone";
            this.tpTelephone.Padding = new System.Windows.Forms.Padding(3);
            this.tpTelephone.Size = new System.Drawing.Size(466, 229);
            this.tpTelephone.TabIndex = 2;
            this.tpTelephone.Text = "Telephone";
            // 
            // lvUserTelephone
            // 
            this.lvUserTelephone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTypeTelephone,
            this.colNameTelephone,
            this.colCommentTelephone});
            this.lvUserTelephone.FullRowSelect = true;
            this.lvUserTelephone.GridLines = true;
            this.lvUserTelephone.Location = new System.Drawing.Point(0, 0);
            this.lvUserTelephone.Name = "lvUserTelephone";
            this.lvUserTelephone.Size = new System.Drawing.Size(464, 229);
            this.lvUserTelephone.TabIndex = 0;
            this.lvUserTelephone.UseCompatibleStateImageBehavior = false;
            this.lvUserTelephone.View = System.Windows.Forms.View.Details;
            // 
            // colTypeTelephone
            // 
            this.colTypeTelephone.Text = "Type";
            this.colTypeTelephone.Width = 74;
            // 
            // colNameTelephone
            // 
            this.colNameTelephone.Text = "Telephone";
            this.colNameTelephone.Width = 180;
            // 
            // colCommentTelephone
            // 
            this.colCommentTelephone.Text = "Comment";
            this.colCommentTelephone.Width = 206;
            // 
            // lvUserList
            // 
            this.lvUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserID,
            this.colUserLogin,
            this.colUserName,
            this.colUserSurname});
            this.lvUserList.FullRowSelect = true;
            this.lvUserList.GridLines = true;
            this.lvUserList.HideSelection = false;
            this.lvUserList.Location = new System.Drawing.Point(6, 17);
            this.lvUserList.Name = "lvUserList";
            this.lvUserList.Size = new System.Drawing.Size(360, 428);
            this.lvUserList.TabIndex = 0;
            this.lvUserList.UseCompatibleStateImageBehavior = false;
            this.lvUserList.View = System.Windows.Forms.View.Details;
            this.lvUserList.SelectedIndexChanged += new System.EventHandler(this.lvUserList_SelectedIndexChanged);
            // 
            // colUserID
            // 
            this.colUserID.Text = "ID";
            this.colUserID.Width = 30;
            // 
            // colUserLogin
            // 
            this.colUserLogin.Text = "Login";
            this.colUserLogin.Width = 85;
            // 
            // colUserName
            // 
            this.colUserName.Text = "Name";
            this.colUserName.Width = 120;
            // 
            // colUserSurname
            // 
            this.colUserSurname.Text = "Surname";
            this.colUserSurname.Width = 120;
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Location = new System.Drawing.Point(393, 152);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(56, 13);
            this.lbUserType.TabIndex = 17;
            this.lbUserType.Text = "User Type";
            // 
            // cbUserType
            // 
            this.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserType.Location = new System.Drawing.Point(459, 149);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(130, 21);
            this.cbUserType.TabIndex = 18;
            this.cbUserType.SelectedIndexChanged += new System.EventHandler(this.cbUserType_SelectedIndexChanged);
            // 
            // UcAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbUsers);
            this.Name = "UcAdminView";
            this.Size = new System.Drawing.Size(852, 455);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.tcUserContacts.ResumeLayout(false);
            this.tpAddress.ResumeLayout(false);
            this.tpEmail.ResumeLayout(false);
            this.tpTelephone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.ListView lvUserList;
        private System.Windows.Forms.ColumnHeader colUserID;
        private System.Windows.Forms.ColumnHeader colUserLogin;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.TabControl tcUserContacts;
        private System.Windows.Forms.TabPage tpAddress;
        private System.Windows.Forms.TabPage tpEmail;
        private System.Windows.Forms.ListView lvUserAddress;
        private System.Windows.Forms.TabPage tpTelephone;
        private System.Windows.Forms.ColumnHeader colTypeAddress;
        private System.Windows.Forms.ColumnHeader colNameAddress;
        private System.Windows.Forms.ListView lvUserEmail;
        private System.Windows.Forms.ColumnHeader colTypeEmail;
        private System.Windows.Forms.ColumnHeader colNameEmail;
        private System.Windows.Forms.ListView lvUserTelephone;
        private System.Windows.Forms.ColumnHeader colTypeTelephone;
        private System.Windows.Forms.ColumnHeader colNameTelephone;
        private System.Windows.Forms.ColumnHeader colCommentAddress;
        private System.Windows.Forms.ColumnHeader colCommentEmail;
        private System.Windows.Forms.ColumnHeader colCommentTelephone;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.CheckBox cbAdultContent;
        private System.Windows.Forms.Button btViewOrders;
        private System.Windows.Forms.Button btViewServices;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Button btViewChannels;
        private System.Windows.Forms.Button btViewPayment;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ColumnHeader colUserSurname;
        private System.Windows.Forms.CheckBox cbAccountStatus;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.ComboBox cbUserType;
    }
}

namespace AITLibrary
{
    partial class AdminForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showAllUsers = new System.Windows.Forms.Button();
            this.deleteSelectedUser = new System.Windows.Forms.Button();
            this.addUsers = new System.Windows.Forms.Label();
            this.newUserUserName = new System.Windows.Forms.Label();
            this.newUserUserNameBox = new System.Windows.Forms.TextBox();
            this.newUserPassword = new System.Windows.Forms.TextBox();
            this.newUserEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedUserText = new System.Windows.Forms.Label();
            this.userLevelCB = new System.Windows.Forms.ComboBox();
            this.addNewUser = new System.Windows.Forms.Button();
            this.mediaMaintainance = new System.Windows.Forms.Button();
            this.adminReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.masterMaintainanceButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(348, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // showAllUsers
            // 
            this.showAllUsers.Location = new System.Drawing.Point(18, 95);
            this.showAllUsers.Name = "showAllUsers";
            this.showAllUsers.Size = new System.Drawing.Size(97, 23);
            this.showAllUsers.TabIndex = 1;
            this.showAllUsers.Text = "Show All Users";
            this.showAllUsers.UseVisualStyleBackColor = true;
            this.showAllUsers.Click += new System.EventHandler(this.showAllUsers_Click);
            // 
            // deleteSelectedUser
            // 
            this.deleteSelectedUser.ForeColor = System.Drawing.Color.Red;
            this.deleteSelectedUser.Location = new System.Drawing.Point(12, 340);
            this.deleteSelectedUser.Name = "deleteSelectedUser";
            this.deleteSelectedUser.Size = new System.Drawing.Size(122, 23);
            this.deleteSelectedUser.TabIndex = 2;
            this.deleteSelectedUser.Text = "Delete Selected User";
            this.deleteSelectedUser.UseVisualStyleBackColor = true;
            this.deleteSelectedUser.Click += new System.EventHandler(this.deleteSelectedUser_Click);
            // 
            // addUsers
            // 
            this.addUsers.AutoSize = true;
            this.addUsers.ForeColor = System.Drawing.Color.Green;
            this.addUsers.Location = new System.Drawing.Point(448, 148);
            this.addUsers.Name = "addUsers";
            this.addUsers.Size = new System.Drawing.Size(76, 13);
            this.addUsers.TabIndex = 3;
            this.addUsers.Text = "Add New User";
            this.addUsers.Click += new System.EventHandler(this.addUsers_Click);
            // 
            // newUserUserName
            // 
            this.newUserUserName.AutoSize = true;
            this.newUserUserName.Location = new System.Drawing.Point(377, 191);
            this.newUserUserName.Name = "newUserUserName";
            this.newUserUserName.Size = new System.Drawing.Size(66, 13);
            this.newUserUserName.TabIndex = 4;
            this.newUserUserName.Text = "UserName : ";
            // 
            // newUserUserNameBox
            // 
            this.newUserUserNameBox.Location = new System.Drawing.Point(449, 184);
            this.newUserUserNameBox.Name = "newUserUserNameBox";
            this.newUserUserNameBox.Size = new System.Drawing.Size(133, 20);
            this.newUserUserNameBox.TabIndex = 5;
            // 
            // newUserPassword
            // 
            this.newUserPassword.Location = new System.Drawing.Point(449, 216);
            this.newUserPassword.Name = "newUserPassword";
            this.newUserPassword.Size = new System.Drawing.Size(133, 20);
            this.newUserPassword.TabIndex = 6;
            // 
            // newUserEmail
            // 
            this.newUserEmail.Location = new System.Drawing.Point(449, 242);
            this.newUserEmail.Name = "newUserEmail";
            this.newUserEmail.Size = new System.Drawing.Size(133, 20);
            this.newUserEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Level :";
            // 
            // selectedUserText
            // 
            this.selectedUserText.AutoSize = true;
            this.selectedUserText.Location = new System.Drawing.Point(16, 121);
            this.selectedUserText.Name = "selectedUserText";
            this.selectedUserText.Size = new System.Drawing.Size(80, 13);
            this.selectedUserText.TabIndex = 12;
            this.selectedUserText.Text = "Selected User :";
            // 
            // userLevelCB
            // 
            this.userLevelCB.FormattingEnabled = true;
            this.userLevelCB.Location = new System.Drawing.Point(449, 268);
            this.userLevelCB.Name = "userLevelCB";
            this.userLevelCB.Size = new System.Drawing.Size(133, 21);
            this.userLevelCB.TabIndex = 13;
            this.userLevelCB.SelectedIndexChanged += new System.EventHandler(this.userLevelCB_SelectedIndexChanged);
            // 
            // addNewUser
            // 
            this.addNewUser.Location = new System.Drawing.Point(449, 295);
            this.addNewUser.Name = "addNewUser";
            this.addNewUser.Size = new System.Drawing.Size(75, 23);
            this.addNewUser.TabIndex = 14;
            this.addNewUser.Text = "Add User";
            this.addNewUser.UseVisualStyleBackColor = true;
            this.addNewUser.Click += new System.EventHandler(this.addNewUser_Click);
            // 
            // mediaMaintainance
            // 
            this.mediaMaintainance.Location = new System.Drawing.Point(384, 57);
            this.mediaMaintainance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mediaMaintainance.Name = "mediaMaintainance";
            this.mediaMaintainance.Size = new System.Drawing.Size(158, 23);
            this.mediaMaintainance.TabIndex = 19;
            this.mediaMaintainance.Text = "Media Maintainance";
            this.mediaMaintainance.UseVisualStyleBackColor = true;
            this.mediaMaintainance.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminReport
            // 
            this.adminReport.Location = new System.Drawing.Point(384, 95);
            this.adminReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminReport.Name = "adminReport";
            this.adminReport.Size = new System.Drawing.Size(158, 24);
            this.adminReport.TabIndex = 20;
            this.adminReport.Text = "Borrowed Books Report";
            this.adminReport.UseVisualStyleBackColor = true;
            this.adminReport.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "User Maintainance Form :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Other Forms :";
            // 
            // masterMaintainanceButton
            // 
            this.masterMaintainanceButton.Location = new System.Drawing.Point(384, 24);
            this.masterMaintainanceButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masterMaintainanceButton.Name = "masterMaintainanceButton";
            this.masterMaintainanceButton.Size = new System.Drawing.Size(158, 23);
            this.masterMaintainanceButton.TabIndex = 23;
            this.masterMaintainanceButton.Text = "Master Maintainance Form";
            this.masterMaintainanceButton.UseVisualStyleBackColor = true;
            this.masterMaintainanceButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // logOutButton
            // 
            this.logOutButton.ForeColor = System.Drawing.Color.Red;
            this.logOutButton.Location = new System.Drawing.Point(292, 340);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(67, 27);
            this.logOutButton.TabIndex = 24;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 375);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.masterMaintainanceButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminReport);
            this.Controls.Add(this.mediaMaintainance);
            this.Controls.Add(this.addNewUser);
            this.Controls.Add(this.userLevelCB);
            this.Controls.Add(this.selectedUserText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserEmail);
            this.Controls.Add(this.newUserPassword);
            this.Controls.Add(this.newUserUserNameBox);
            this.Controls.Add(this.newUserUserName);
            this.Controls.Add(this.addUsers);
            this.Controls.Add(this.deleteSelectedUser);
            this.Controls.Add(this.showAllUsers);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showAllUsers;
        private System.Windows.Forms.Button deleteSelectedUser;
        private System.Windows.Forms.Label addUsers;
        private System.Windows.Forms.Label newUserUserName;
        private System.Windows.Forms.TextBox newUserUserNameBox;
        private System.Windows.Forms.TextBox newUserPassword;
        private System.Windows.Forms.TextBox newUserEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedUserText;
        private System.Windows.Forms.ComboBox userLevelCB;
        private System.Windows.Forms.Button addNewUser;
        private System.Windows.Forms.Button mediaMaintainance;
        private System.Windows.Forms.Button adminReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button masterMaintainanceButton;
        private System.Windows.Forms.Button logOutButton;
    }
}
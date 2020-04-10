using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AITLibrary.userWebService;
using AITLibrary;
using System.Threading;

namespace AITLibrary
{
    public partial class AdminForm : Form
    {

        userWebService.MyWebService uws = new userWebService.MyWebService();
       // UserLogic userLogic = new UserLogic();
        DataRow selectedUser = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void showAllUsers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = uws.GetAllUserViaWS();
        }

        private void addUsers_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = uws.GetAllUserViaWS();

            List<UserLevel> userLevels= new List<UserLevel>();
            userLevels.Add(new UserLevel(1, "Student"));
            userLevels.Add(new UserLevel(2, "Staff"));
            userLevels.Add(new UserLevel(3, "Admin"));

            userLevelCB.DataSource = userLevels;
            userLevelCB.DisplayMember = "UserLevelDisplay";
            
            userLevelCB.ValueMember = "UserLevelValue";
        }

        private void deleteSelectedUser_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                int rowsAffected = uws.deleteUser((int)selectedUser["UserID"], UserDetail.UserLevel);

                if (rowsAffected > 0)
                {
                    selectedUser = null;
                    selectedUserText.Text = "Selected User: ";
                    MessageBox.Show("Seleted User Deleted!");
                }
                else if (rowsAffected == 0)
                    MessageBox.Show("Error Occured");
                else if (rowsAffected == -1)
                    MessageBox.Show("Error Occured ! Try Again.");

                dataGridView1.DataSource = uws.GetAllUserViaWS();

            }
        }

        private void addNewUser_Click(object sender, EventArgs e)
        {
            int rowsAffected = uws.addNewUsers(newUserUserNameBox.Text, newUserPassword.Text, (int)userLevelCB.SelectedValue, newUserEmail.Text, UserDetail.UserLevel);

            if (rowsAffected > 0)
                MessageBox.Show("Successfully added a new user");
            else if (rowsAffected == 0)
                MessageBox.Show("Error Occured !!");
            


            dataGridView1.DataSource = uws.GetAllUserViaWS();



            ClearFields();


        }

        private void ClearFields()
        {
            newUserUserNameBox.Text = String.Empty;
            newUserPassword.Text = String.Empty;
            newUserEmail.Text = String.Empty;
            userLevelCB.SelectedIndex = -1;
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;

            if (row >= 0)
            {
                DataTable users = (DataTable)dataGridView1.DataSource;
                selectedUser = users.Rows[row];


                selectedUserText.Text = "Selected User: " + selectedUser["username"];


            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(AdminMediaForm));
            t.Start();


        }
        public static void AdminMediaForm()
        {
            Application.Run(new AdminMediaForm());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(AdminReport));
            t.Start();

        }
       
        public static void AdminReport()
        {
            Application.Run(new AdminReport());

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

            //going back to the login form
            Thread t = new Thread(new ThreadStart(LoginForm));
            t.Start();
            Close();

        }

        private void LoginForm()
        {

            Application.Run(new Form1());

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MasterMaintanceForm));
            t.Start();
        }

        private void MasterMaintanceForm()
        {
            Application.Run(new MasterMaintainanceForm());
        }

        private void userLevelCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}

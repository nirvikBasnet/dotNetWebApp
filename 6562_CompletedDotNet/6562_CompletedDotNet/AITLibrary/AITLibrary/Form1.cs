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
using System.Threading;

namespace AITLibrary
{
    public partial class Form1 : Form
    {
        userWebService.MyWebService uws = new userWebService.MyWebService();

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //UserLogic userLogic = new UserLogic();


            DataTable users = uws.GetUsersByCredintials(userName.Text, password.Text);


            if (users.Rows.Count > 0)
            {
               
                UserDetail.UserName = users.Rows[0]["Username"].ToString();
                UserDetail.UserLevel = (int)users.Rows[0]["UserLevel"];

                
                if ((int)users.Rows[0]["UserLevel"] < 3)
                {
                    // Go to media form
                    Thread t = new Thread(new ThreadStart(MediaForm));
                    t.Start();
                }
                else
                {
                    // Go to admin form
                    Thread t = new Thread(new ThreadStart(AdminForm));
                    t.Start();
                }
               
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Credintials");
            }
           
        }
        public static void AdminForm()
        {
            Application.Run(new AdminForm());
        }

        public static void MediaForm()
        {
            Application.Run(new MediaForm());

        }

        public static void form2()
        {
            Application.Run(new MediaForm());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMy1stApp_Click(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

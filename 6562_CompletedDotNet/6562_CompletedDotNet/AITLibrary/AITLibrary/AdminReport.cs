using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BusinessLogic;

using AITLibrary.BorrowWebServices;

namespace AITLibrary
{
    public partial class AdminReport : Form

       
    {
        BorrowWebServices.BorrowWebServices bws = new BorrowWebServices.BorrowWebServices();


        //BorrowLogic borrowLogic;
        DataRow selectedMediaBorrow = null;
        public AdminReport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminReport_Load(object sender, EventArgs e)
        {
           // borrowLogic = new BorrowLogic();
            dataGridView1.DataSource = bws.showAllBorrow();
            
            
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row > -1)
            {
               DataTable borrows = (DataTable)dataGridView1.DataSource;

                // Get user from this list based on row
                selectedMediaBorrow = borrows.Rows[row];

                // Update label
                selectedMediaLabel.Text = selectedMediaBorrow["BorrowID"].ToString();
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                DateTime borrowDate = (DateTime)selectedMediaBorrow["BorrowDate"];
                DateTime actualReturn = (DateTime)selectedMediaBorrow["ActualReturnDate"];
                TimeSpan count = actualReturn - borrowDate;
            int fee = 0;
            int rowsAffected = bws.updateBorrow(DateTime.Now, fee, int.Parse(selectedMediaLabel.Text));
            dataGridView1.DataSource = bws.showAllBorrow();

        }
    }
}

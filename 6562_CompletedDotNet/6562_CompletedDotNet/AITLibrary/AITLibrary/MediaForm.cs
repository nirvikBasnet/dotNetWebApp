using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


using AITLibrary.userWebService;
using AITLibrary.BorrowWebServices;
using AITLibrary.mediaWebService;

namespace AITLibrary
{
    public partial class MediaForm : Form
    {

        mediaWebService.WebServiceMedia mws = new mediaWebService.WebServiceMedia();
        BorrowWebServices.BorrowWebServices bws = new BorrowWebServices.BorrowWebServices();

       // MediaLogic mediaLogic = new MediaLogic();
        DataRow selectedMedia = null;
       // BorrowLogic borrowLogic;
       

        public MediaForm()
        {
            InitializeComponent();
           // mediaLogic = new MediaLogic();
           // borrowLogic = new BorrowLogic();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showAll_Click(object sender, EventArgs e)
        {
            mediaDataGridView.DataSource = mws.showAllMedia();

        }

        private void ByPublishYear_Click(object sender, EventArgs e)
        {
            int publishYear = int.Parse(publishYearText.Text);
            mediaDataGridView.DataSource = mws.listMediaByYear(publishYear);
           

        }

        private void ByGenre_Click(object sender, EventArgs e)
        {
            string GenreName = genreText.Text;
            mediaDataGridView.DataSource = mws.listMediaByGenre(GenreName);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       /* private void mediaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tracks selected media in data grid view
            int rowIndex = e.RowIndex;
            //If rowIndex = -1, then user clicked on header row of table
            //so only set selected if greater than -1
            if (rowIndex >= 0)
            {
                //get the list of medias from data grid view
                List<MediaModel> medias = (List<MediaModel>)mediaDataGridView.DataSource;
                selectedMedia = medias.ElementAt(rowIndex);

                //update label
                selectedMediaLabel.Text = "Selected Media: " + selectedMedia.Title; // Display selected media label
            }
        }*/

        private void MediaForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome To The Prototype " + UserDetail.UserName;
            
        }

        private void genreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void burrowButton_Click(object sender, EventArgs e)
        {
            if (selectedMedia != null) 
            {
                if (bws.addNewToBorrow(UserDetail.UserID,(int)selectedMedia["MediaID"], borrowDateTimePicker.Value,DateTime.Now) > 0)
                {
                    MessageBox.Show("Success Borrow");
                }
                else
                {
                    MessageBox.Show("Something went Wrong with Borrow");
                }
            }
            else
            {
                MessageBox.Show("Please select a media");
            }
        }

        private void mediaDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            int rowIndex = e.RowIndex;
            
            if (rowIndex >= 0)
            {
               
                DataTable medias = (DataTable)mediaDataGridView.DataSource;
                selectedMedia = medias.Rows[rowIndex];

              
                selectedMediaLabel.Text = "Selected Media: " + selectedMedia["Title"].ToString(); 
            }

        }

        private void reserveButton_Click(object sender, EventArgs e)
        {

              //  bws.AddNewReserve(UserDetail.UserID, selectedMedia.MediaID);
            //MessageBox.Show("Media Reserved");
                   
                
            
        }


        private void selectedMediaLabel_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(LoginForm));
            t.Start();
            Close();
        }

        private void LoginForm()
        {
            Application.Run(new Form1());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String Title = searchByTitle.Text;
            mediaDataGridView.DataSource = mws.listMediaByTitle(Title);

        }
    }
}

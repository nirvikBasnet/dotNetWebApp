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

using AITLibrary.mediaWebService;


namespace AITLibrary
{
    public partial class AdminMediaForm : Form
    {
       // MediaLogic mediaLogic;

            mediaWebService.WebServiceMedia mws= new mediaWebService.WebServiceMedia();

        DataRow selectedMedia = null;

        public AdminMediaForm()
        {
            InitializeComponent();

          //  mediaLogic = new MediaLogic();
        }

        private void AdminMediaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mws.showAllMedia();
            


            genreCB.DataSource = mws.GetAllGenre();
            genreCB.DisplayMember = "Name";
            genreCB.ValueMember = "ID";

            languageCB.DataSource = mws.GetAllLanguage();
            languageCB.DisplayMember = "Name";
            languageCB.ValueMember = "ID";

            directorCB.DataSource = mws.GetAllDirector();
            directorCB.DisplayMember = "Name";
            directorCB.ValueMember = "ID";
        }

        private void addMediaButton_Click(object sender, EventArgs e)
        {
            int rowsAffected = mws.addNewMedia(titleBox.Text, (int)genreCB.SelectedValue, (int)directorCB.SelectedValue, (int)languageCB.SelectedValue, Int32.Parse(publishYearTextBox.Text), Decimal.Parse(BudgetTextBox.Text));

            dataGridView1.DataSource = mws.showAllMedia();

            clearFields();

        }

        private void clearFields()
        {
            titleBox.Text = String.Empty;
            BudgetTextBox.Text = String.Empty;
            genreCB.SelectedIndex = -1;
            languageCB.SelectedIndex = -1;
            directorCB.SelectedIndex = -1;


        }

        private void deleteMedia_Click(object sender, EventArgs e)
        {
            if (selectedMedia != null)
            {
                int rowsAffected = mws.DeleteMedia((int)selectedMedia["MediaID"]);
                if (rowsAffected > 0)
                    MessageBox.Show(selectedMedia["Title"] + " deleted!!!");
                else if (rowsAffected == 0)
                    MessageBox.Show(selectedMedia["Title"] + " not deleted!!!");

                dataGridView1.DataSource =mws.showAllMedia();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            
            if (rowIndex >= 0)
            {
                
                DataTable medias = (DataTable)dataGridView1.DataSource;
                selectedMedia = medias.Rows[rowIndex];

                
                selectedMediaLabel.Text = "Selected Media: " + selectedMedia["Title"];
            }
        }

        private void showAll_Click(object sender, EventArgs e)
        {

        }

        private void languageCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void genreCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            if (selectedMedia != null)
            {
                int rowsAffected = mws.updateMedia((int)selectedMedia["MediaID"], titleBox.Text, (int)genreCB.SelectedValue, (int)directorCB.SelectedValue,
               (int)languageCB.SelectedValue, int.Parse(publishYearTextBox.Text), decimal.Parse(BudgetTextBox.Text));

                // Let user know what happen
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Media has been updated");
                    dataGridView1.DataSource = mws.showAllMedia();
                    selectedMediaLabel.Text = "";
                }
                else if (rowsAffected == 0)
                    MessageBox.Show("Media not updated!");
                else if (rowsAffected <= -1)
                    MessageBox.Show("Need higher level of Authority");
            }
        }
    }
}

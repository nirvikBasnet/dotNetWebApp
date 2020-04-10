using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AITLibrary.mediaWebService;

namespace AITLibrary
{
    public partial class MasterMaintainanceForm : Form
    {
        //MediaLogic mediaLogic;

        mediaWebService.WebServiceMedia mws = new mediaWebService.WebServiceMedia();

        PairModel selectedTitle = null;


        public MasterMaintainanceForm()
        {
            InitializeComponent();
           // mediaLogic = new MediaLogic();
            
        }

        private void MasterMaintainanceForm_Load(object sender, EventArgs e)
        {
            // genreGridView.DataSource = mediaLogic.GetGenres();

            // languageMaintainanceView.DataSource = mediaLogic.GetLanguages();
            // directorMaintainanceView.DataSource = mediaLogic.GetDirectors();

            genreGridView.DataSource = mws.GetAllGenre().ToList();
            directorMaintainanceView.DataSource = mws.GetAllDirector().ToList();
            languageMaintainanceView.DataSource = mws.GetAllLanguage().ToList();

        }

        private void genreAdd_Click(object sender, EventArgs e)
        {
            if (selectedTitle != null)
            {
                
                    int rowsAffected = mws.addGenre(newGenre.Text);
                    if (rowsAffected > 0)

                        MessageBox.Show(newGenre.Text + " added As New Genre !");
                    else if (rowsAffected == 0)

                        MessageBox.Show("Error Occured !!");

                    genreGridView.DataSource = mws.GetAllGenre();
                
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (selectedTitle != null)
            {
                if (newGenre.Text != "")
                {
                    int rowsAffected = mws.deleteGenre(selectedTitle.ID);
                    if (rowsAffected > 0)
                        MessageBox.Show(" Deleted!!!");
                    else if (rowsAffected == 0)
                        MessageBox.Show("Error !!");

                    genreGridView.DataSource = mws.GetAllGenre();
                }
            }

        }

        private void UpdateGen_Click(object sender, EventArgs e)
        {
            if (selectedTitle != null)
            {
                if (updateGenre.Text != "")
                {
                    int rowsAffected = mws.updateGenre(updateGenre.Text, selectedTitle.ID);
                    if (rowsAffected > 0)
                        MessageBox.Show("Update Sucessfull !");
                    else if (rowsAffected == 0)
                        MessageBox.Show("Error Occured !!");

                    genreGridView.DataSource = mws.GetAllGenre();

                }
            }

        }

        private void GenreGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            
            if (rowIndex >= 0)
            {
                
                List<PairModel> genres = (List<PairModel>)genreGridView.DataSource;
                selectedTitle = genres.ElementAt(rowIndex);

               

                selectedView.Text = "Selected Genre: " + selectedTitle.Name;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (selectedLanguage != null)
            {
                if (newLanguage.Text != "")
                {
                    int rowsAffected = mws.addLanguage(newLanguage.Text);
                    if (rowsAffected > 0)
                        MessageBox.Show(newLanguage.Text + " as language added Sucessfully!");
                    else if (rowsAffected == 0)
                        MessageBox.Show("Error Occured");

                    languageMaintainanceView.DataSource = mws.GetAllLanguage();

                }
            }
        }

        private void DeleteLanguage_Click(object sender, EventArgs e)
        {
            if (selectedTitle != null)
            {
                int rowsAffected = mws.deleteLanguage(selectedTitle.ID);
                if (rowsAffected > 0)
                    MessageBox.Show(" Language Deleted!!!");
                else if (rowsAffected == 0)
                    MessageBox.Show("Error !!");

                languageMaintainanceView.DataSource =mws.GetAllLanguage();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (selectedTitle != null)
            {
                if (updateLanguageTB.Text != "")
                {
                    int rowsAffected = mws.updateLanguage(updateLanguageTB.Text, selectedTitle.ID);
                    if (rowsAffected > 0)
                        MessageBox.Show("Updated Sucessfully!!");
                    else if (rowsAffected == 0)
                        MessageBox.Show("Error Occured !");

                    languageMaintainanceView.DataSource = mws.GetAllLanguage();

                }
            }
        }

        private void LanguageMaintainanceView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
           
            if (rowIndex >= 0)
            {
                
                List<PairModel> languages = (List<PairModel>)languageMaintainanceView.DataSource;
                selectedTitle = languages.ElementAt(rowIndex);

                

                selectedView.Text = "Selected Language: " + selectedTitle.Name;
            }
        }

        private void AddDirector_Click(object sender, EventArgs e)
        {

            if (selectedTitle != null)
            {
                if (newDirector.Text != "")
                {
                    int rowsAffected = mws.addDirector(newDirector.Text);
                    if (rowsAffected > 0)
                        MessageBox.Show( " Sucessfully Added !!");
                    else if (rowsAffected == 0)
                        MessageBox.Show("Error Occured !!");

                    directorMaintainanceView.DataSource = mws.GetAllDirector();

                }
            }

        }

        private void DeleteDirector_Click(object sender, EventArgs e)
        {
            if (selectedTitle != null)
            {
                int rowsAffected = mws.deleteDirector(selectedTitle.ID);
                if (rowsAffected > 0)
                    MessageBox.Show(" Sucessfully deleted !");
                else if (rowsAffected == 0)
                    MessageBox.Show(" Error Occured !!");

                directorMaintainanceView.DataSource = mws.GetAllDirector();
            }
        }

        private void UpdateDirectorButton_Click(object sender, EventArgs e)
        {
            if (selectedTitle != null)
            {
                if (updateDirector.Text != "")
                {
                    int rowsAffected = mws.updateDirector(updateDirector.Text, selectedTitle.ID);
                    if (rowsAffected > 0)
                        MessageBox.Show("Update Was SucessFull !!");
                    else if (rowsAffected == 0)
                        MessageBox.Show("Error Occured");

                    directorMaintainanceView.DataSource = mws.GetAllDirector();

                }
            }
        }

        private void DirectorMaintainanceView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            
            if (rowIndex >= 0)
            {
                
                List<PairModel> directors = (List<PairModel>)directorMaintainanceView.DataSource;
                selectedTitle = directors.ElementAt(rowIndex);

                

                selectedView.Text = "Selected Director: " + selectedTitle.Name;
            }
        }
    }
}

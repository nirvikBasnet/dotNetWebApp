using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DataAccessLayer.MediaDataSetTableAdapters;

namespace DataAccessLayer
{
   public class MediaDAO
    {
        ViewMediaTableAdapter viewMediaAdapter;
        TabGenreTableAdapter genreTableAdapter;
        TabLanguageTableAdapter languageTableAdapter;
        TabDirectorTableAdapter directorTableAdapter;
        TabMediaTableAdapter tabMediaTableAdapter;
        TabBorrowTableAdapter tabBorrowTableAdapter;
        TabReservedTableAdapter tabReserveTableAdapter;

        public MediaDAO()
        {
            viewMediaAdapter = new ViewMediaTableAdapter();
            genreTableAdapter = new TabGenreTableAdapter();
            tabMediaTableAdapter = new TabMediaTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            directorTableAdapter = new TabDirectorTableAdapter();
            tabReserveTableAdapter = new TabReservedTableAdapter();
            tabBorrowTableAdapter = new TabBorrowTableAdapter();
        }

        public MediaDataSet.ViewMediaDataTable GetAllMedia()
        {
            return viewMediaAdapter.GetData();
        }

        public MediaDataSet.ViewMediaDataTable GetMediaPublishYear(int PublishYear)
        {
            return viewMediaAdapter.GetDataByYear(PublishYear);
        }

        public MediaDataSet.ViewMediaDataTable GetMediaByBudget(int Budget)
        {
            return viewMediaAdapter.GetDataByBudget(Budget);

        }
        public MediaDataSet.ViewMediaDataTable GetDataByGenre(String GenreName)
        {
            return viewMediaAdapter.GetDataByGenre(GenreName);
        }
        public MediaDataSet.ViewMediaDataTable GetDataByDirector(String DirectorName)
        {
            return viewMediaAdapter.GetDataByDirector(DirectorName);
        }
        public MediaDataSet.ViewMediaDataTable GetDataByLanguage(String LanguageName)
        {
            return viewMediaAdapter.GetDataByLanguage(LanguageName);
        }

        public MediaDataSet.ViewMediaDataTable GetDataByTitle (String Title)
        {
            return viewMediaAdapter.GetDataByTitle(Title);
        }

        public MediaDataSet.TabGenreDataTable GetGenres()
        {

            try
            {
                return genreTableAdapter.GetData();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public MediaDataSet.TabLanguageDataTable GetLanguages()
        {

            try
            {
                return languageTableAdapter.GetData();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public MediaDataSet.TabDirectorDataTable GetDirectors()
        {

            try
            {
                return directorTableAdapter.GetData();
            }
            catch (Exception)
            {

                return null;
            }

        }

        public int UpdateMedia(int mediaID, string title, int genre, int director, int language, int publishYear, decimal budget)
        {
            int rowsAffected = tabMediaTableAdapter.UpdateMedia(title, genre, director, language, publishYear, decimal.ToInt32(budget), mediaID);
            return rowsAffected;
        }
        public int InsertMedia(string title, int genre, int director, int language, int publishYear, decimal budget)
        {
            try
            {
                int rowsAffected = tabMediaTableAdapter.InsertMedia(title, genre, director, language, publishYear, budget);
                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int DeleteMediaByID(int mediaID)
        {
            try
            {
                int rowsAffected = tabMediaTableAdapter.DeleteMedia(mediaID);
                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public int AddNewBorrow(int UID, int mediaID, DateTime borrowDate, DateTime returnDate)
        {
            int rowsAffected = tabBorrowTableAdapter.AddBorrow(UID, mediaID, borrowDate.ToString(), returnDate.ToString());
            return rowsAffected;
        }

        public int UpdateBorrow(DateTime actualReturn, int fee, int BorrowID)
        {
            int rowsAffected = tabBorrowTableAdapter.UpdateBorrow(actualReturn.ToString(), fee, BorrowID);

            return rowsAffected;
        }

        public MediaDataSet.TabBorrowDataTable GetAllBorrow()
        {
            return tabBorrowTableAdapter.GetData();
        }
        public MediaDataSet.TabBorrowDataTable GetBorrowedMedias()
        {
            try
            {
                
                MediaDataSet.TabBorrowDataTable borrowTable = tabBorrowTableAdapter.GetData();
                return borrowTable;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public int InsertReserve(int userID, int mediaID)
        {
            DateTime myDateTime = DateTime.Now;
            

            try
            {
                int rowsAffected;

                if (tabBorrowTableAdapter.GetCurrentBorrowedByMediaID(mediaID).Count() > 0) // teste if borrowed
                    rowsAffected = 0;
                else
                {
                    if (tabReserveTableAdapter.GetDataByMediaID(mediaID).Count() > 0)
                    {
                        rowsAffected = 0;
                    }
                    else
                        rowsAffected = tabReserveTableAdapter.Insert(userID, mediaID, myDateTime);
                }
                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int InsertBorrow(int userID, int mediaID, DateTime returnDate)
        {
            DateTime borrowDate = DateTime.Now;

            int rowsAffected;

            if (tabBorrowTableAdapter.GetCurrentBorrowedByMediaID(mediaID).Count() > 0) // Chech if someone already borrowed that same media
                return 0; 
            else
            {
                
                MediaDataSet.TabReservedDataTable reserveResult = tabReserveTableAdapter.GetDataByMediaID(mediaID);
                if (reserveResult.Count() > 0)
                {
                    
                    if (reserveResult.ElementAt(0).UID == userID)
                        if (tabReserveTableAdapter.DeleteReserve(mediaID) > 0) //Tries to delete the reservation, if successfull, it will then insert the borrow operation for the user
                            rowsAffected = tabBorrowTableAdapter.AddBorrow(userID, mediaID, borrowDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), returnDate.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                        else
                            return 0; 
                    else
                        return 0; 
                }
                else
                { // Not reserved by anyone -> success, user can borrow
                    rowsAffected = tabBorrowTableAdapter.AddBorrow(userID, mediaID, borrowDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), returnDate.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                }
            }
            return rowsAffected;
        }

        public int ReturnBorrow(int userID, int mediaID)
        {
            DateTime actualReturn = DateTime.Now; // Gets the current date
            int rowsAffected = 0;

            MediaDataSet.TabBorrowDataTable currentBorrowResult = tabBorrowTableAdapter.GetCurrentBorrowedByMediaID(mediaID);
            if (currentBorrowResult.Count() > 0)
            { //If someone has borrowed..
                if (userID == currentBorrowResult.ElementAt(0).UID) //If the user has borrowed, success...
                {
                    decimal lateFee = (decimal)(DateTime.Now.Date - currentBorrowResult.ElementAt(0).ReturnDate.Date).TotalDays; // Calculates latefee
                    if (lateFee < 0) // Any negative values means that the user delivered the media before the due date, so the fee should be zero
                        lateFee = 0; // assign zero to fee

                    rowsAffected = tabBorrowTableAdapter.UpdateBorrow(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), lateFee, mediaID); // Return media
                    return rowsAffected;
                }
                else
                {
                    return 0; // If user didnt borrow, it cannot return
                }
            }

            return 0; // If anyone borrow, cannot return
        }


        public int InsertGenre(string genreName)
        {
            try
            {
                int rowsAffected = genreTableAdapter.Insert(genreName);
                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int UpdateGenreByID(string genreName, int genreID)
        {
            try
            {
                int rowsAffected = genreTableAdapter.UpdateGenre(genreName, genreID);
                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int DeleteGenreByID(int genreID)
        {
            try
            {
                int rowsAffected = genreTableAdapter.DeleteGenre(genreID);
                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //End Genre Logic
        //Start 
        public int InsertLanguage(string languageName)
        {
            try
            {
                int rowsAffected = languageTableAdapter.Insert(languageName);
                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int UpdateLanguageByID(string languageName, int languageID)
        {
            try
            {
                int rowsAffected = languageTableAdapter.UpdateLanguage(languageName, languageID);
                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int DeleteLanguageByID(int languageID)
        {
            try
            {
                int rowsAffected = languageTableAdapter.DeleteLanguage(languageID);
                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //End Language
        //Start Director Logic
        public int InsertDirector(string directorName)
        {
            try
            {
                int rowsAffected = directorTableAdapter.Insert(directorName);

                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int UpdateDirectorByID(string directorName, int directorID)
        {
            try
            {
                int rowsAffected = directorTableAdapter.UpdateDirector(directorName, directorID);

                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int DeleteDirectorByID(int directorID)
        {
            try
            {
                int rowsAffected = directorTableAdapter.DeleteDirector(directorID);

                return rowsAffected;
            }
            catch (Exception)
            {
                return 0;
            }
        }



    }
}

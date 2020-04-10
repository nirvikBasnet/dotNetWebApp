using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaLogic
    {
        MediaDAO mediaDAO = new MediaDAO();

        
        public List<MediaModel> GetAllMedia()
        {

          
            MediaDataSet.ViewMediaDataTable mediaTable = mediaDAO.GetAllMedia();

            return ConvertMediaTableToList(mediaTable);
        }

        public List<MediaModel> ConvertMediaTableToList(MediaDataSet.ViewMediaDataTable mediaTable)
        {
          
            List<MediaModel> models = new List<MediaModel>();
            
            foreach (MediaDataSet.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel model = MediaModel.Parse(row);
                models.Add(model);
            }
            return models;
        }

        
        public List<MediaModel> GetMediaByPublishYear(int publishYear)
        {
            
            MediaDataSet.ViewMediaDataTable mediaTable = mediaDAO.GetMediaPublishYear(publishYear);
            return ConvertMediaTableToList(mediaTable);
        }

        public List<MediaModel> GetMediaByBudget(int Budget)
        {
            MediaDataSet.ViewMediaDataTable mediaTable = mediaDAO.GetMediaByBudget(Budget);
            return ConvertMediaTableToList(mediaTable);
        }

        public List<MediaModel> GetMediaByGenreName(string GenreName)
        {
            MediaDataSet.ViewMediaDataTable mediaTable = mediaDAO.GetDataByGenre(GenreName);
            return ConvertMediaTableToList(mediaTable);
        }

        public List<PairModel> GetGenres()
        {
            List<PairModel> pairList = new List<PairModel>();
            
            MediaDataSet.TabGenreDataTable genreTable = mediaDAO.GetGenres();


            if (genreTable != null) 
            {
                foreach (MediaDataSet.TabGenreRow row in genreTable.Rows)
                {
                    PairModel pair = PairModel.Parse(row);
                    pairList.Add(pair);

                }
                return pairList;
            }
            else
                return null;

        }
       
        public List<PairModel> GetLanguages()
        {
            List<PairModel> pairList = new List<PairModel>();
            


            MediaDataSet.TabLanguageDataTable languageTable = mediaDAO.GetLanguages();
            if (languageTable != null)
            {
                foreach (MediaDataSet.TabLanguageRow row in languageTable.Rows)
                {
                    PairModel pair = PairModel.Parse(row);
                    pairList.Add(pair);

                }
                return pairList;
            }
            else
                return null;
        }
        
        public List<PairModel> GetDirectors()
        {
            List<PairModel> pairList = new List<PairModel>();
           

            MediaDataSet.TabDirectorDataTable directorTable = mediaDAO.GetDirectors();
            if (directorTable != null)
            {
                foreach (MediaDataSet.TabDirectorRow row in directorTable.Rows)
                {
                    PairModel pair = PairModel.Parse(row);
                    pairList.Add(pair);

                }
                return pairList;
            }
            else
                return null;

        }
        public List<MediaModel> GetDataByTitle(string title)
        {
            MediaDataSet.ViewMediaDataTable mediaTable = mediaDAO.GetDataByTitle(title);
            return ConvertMediaTableToList(mediaTable);
        }


        public int AddNewMedia(string title, int genre, int director, int language, int publishYear, decimal budget)
        {
            return mediaDAO.InsertMedia(title, genre, director, language, publishYear, budget);
        }

        public int UpdateMedia(int mediaID, string title, int genre, int director, int language, int publishYear, decimal budget)
        {
            return mediaDAO.UpdateMedia(mediaID, title, genre, director, language, publishYear, budget);
        }

        public int DeleteMediaByID(int mediaID)
        {
            return mediaDAO.DeleteMediaByID(mediaID);
        }

        //for genre operation
        public int AddGenre(string genreName)
        {
            return mediaDAO.InsertGenre(genreName);
        }
        public int UpdateGenreByID(string genreName, int genreID)
        {
            return mediaDAO.UpdateGenreByID(genreName, genreID);
        }

        public int DeleteGenreByID(int genreID)
        {
            return mediaDAO.DeleteGenreByID(genreID);
        }
        //------------------------------------------------

        // Language Operations:
        public int AddNewLanguage(string languageName)
        {
            return mediaDAO.InsertLanguage(languageName);
        }

        public int UpdateLanguageByID(string languageName, int languageID)
        {
            return mediaDAO.UpdateLanguageByID(languageName, languageID);
        }

        public int DeleteLanguageByID(int languageID)
        {
            return mediaDAO.DeleteLanguageByID(languageID);
        }
        //-------------------------------------------------

        // Director Operations:
        public int AddNewDirector(string directorName)
        {
            return mediaDAO.InsertDirector(directorName);
        }

        public int UpdateDirectorByID(string directorName, int directorID)
        {
            return mediaDAO.UpdateDirectorByID(directorName, directorID);
        }

        public int DeleteDirectorByID(int directorID)
        {
            return mediaDAO.DeleteDirectorByID(directorID);
        }

    }
}

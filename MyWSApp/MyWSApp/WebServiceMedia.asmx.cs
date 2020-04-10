using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

using BusinessLogic;

namespace MyWSApp
{
    /// <summary>
    /// Summary description for WebServiceMedia
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMedia : System.Web.Services.WebService
    {

        MediaLogic ml = new MediaLogic();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        //web method to show all the media

       [WebMethod]
       public DataTable showAllMedia()
        {
            return AppUtil.ToDataTable(ml.GetAllMedia());
        }


        //web method to filter media by published year
        [WebMethod]
        public DataTable listMediaByYear(int year)
        {
            return AppUtil.ToDataTable(ml.GetMediaByPublishYear(year));
        }

        //web method to filter media by genre name
        [WebMethod]
        public DataTable listMediaByGenre(string genre)
        {
            return AppUtil.ToDataTable(ml.GetMediaByGenreName(genre));
        }

        //web method to filter media by title
        [WebMethod]
        public DataTable listMediaByTitle (string title)
        {
            return AppUtil.ToDataTable(ml.GetDataByTitle(title));
        }

        //web method to add media
        [WebMethod]
        public int addNewMedia(string title,int genre,int director,int language,int publishYear,decimal budget)
        {
            return ml.AddNewMedia(title, genre, director, language, publishYear, budget);
        }

        [WebMethod]
        public int updateMedia(int mediaID,string title,int genre,int director,int language,int publishYear,decimal budget)
        {
            return ml.UpdateMedia(mediaID, title, genre, director, language, publishYear, budget);
        }

        [WebMethod]
        public int DeleteMedia(int mediaID)
        {
            return ml.DeleteMediaByID(mediaID);
        }

        //getting genres using pair model
        [WebMethod]
        public List<PairModel> GetAllGenre()
        {
            return ml.GetGenres();
        }

        [WebMethod]
        public List<PairModel> GetAllDirector()
        {
            return ml.GetDirectors();
        }

        [WebMethod]
        public List<PairModel> GetAllLanguage()
        {
            return ml.GetLanguages();
        }



    

        //for genre maintainance form

        [WebMethod]
        public int addGenre(string genreName)
        {
            return ml.AddGenre(genreName);
        }

        [WebMethod]
        public int updateGenre(string genreName,int genreID)
        {
            return ml.UpdateGenreByID(genreName,genreID);
        }

        [WebMethod]
        public int deleteGenre(int genreID)
        {
            return ml.DeleteGenreByID(genreID);
        }

        //for language Maintainance form
        [WebMethod]
        public int addLanguage(string languageName)
        {
            return ml.AddNewLanguage(languageName);
        }

        [WebMethod]
        public int updateLanguage(string languageName, int languageID)
        {
            return ml.UpdateLanguageByID(languageName, languageID);
        }

        [WebMethod]
        public int deleteLanguage(int languageID)
        {
            return ml.DeleteLanguageByID(languageID);
        }

        //for director maintainance form
        [WebMethod]
        public int addDirector(string directorName)
        {
            return ml.AddNewDirector(directorName);
        }

        [WebMethod]
        public int updateDirector(string directorName, int directorID)
        {
            return ml.UpdateDirectorByID(directorName, directorID);
        }

        [WebMethod]
        public int deleteDirector(int directorID)
        {
            return ml.DeleteDirectorByID(directorID);
        }

    }
}

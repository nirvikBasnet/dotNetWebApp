using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaModel
    {
        
        private int mediaID; 
        public int MediaID 
        {
            get
            {
                return mediaID;
            }
            set
            {
                mediaID = value;
            }
        }
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private int publishYear;
        public int PublishYear
        {
            get
            {
                return publishYear;
            }
            set
            {
                publishYear = value;
            }
        }



        private string genreName;
        public string GenreName
        {
            get
            {
                return genreName;
            }
            set
            {
                genreName = value;
            }
        }

        private string directorName;
        public string DirectorName
        {
            get
            {
                return directorName;
            }
            set
            {
                directorName = value;
            }
        }
        private string languageName;
        public string LanguageName
        {
            get
            {
                return languageName;
            }
            set
            {
                languageName = value;
            }
        }
        private decimal budget;
        public decimal Budget
        {
            get
            {
                return budget;
            }
            set
            {
                budget = value;
            }
        }

        public static MediaModel Parse(MediaDataSet.ViewMediaRow row)
        {
            MediaModel model = new MediaModel();
            model.MediaID = row.MediaID;
            model.Title = row.Title;
            model.PublishYear = row.PublishYear;
            model.GenreName = row.GenreName;
            model.DirectorName = row.DirectorName;
            model.LanguageName = row.LanguageName;
            model.Budget = row.Budget;

            return model;

        }
    }
}


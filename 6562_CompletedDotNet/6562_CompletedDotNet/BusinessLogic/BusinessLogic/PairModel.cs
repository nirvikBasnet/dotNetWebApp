using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;

namespace BusinessLogic
{
    public class PairModel
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public static PairModel Parse(MediaDataSet.TabGenreRow row)
        {
            PairModel pair = new PairModel();
            pair.ID = row.GID;
            pair.Name = row.GenreName;

            return pair;

        } 
        public static PairModel Parse(MediaDataSet.TabDirectorRow row)
        {
            PairModel pair = new PairModel();
            pair.ID = row.DID;
            pair.Name = row.DirectorName;

            return pair;

        }
        public static PairModel Parse(MediaDataSet.TabLanguageRow row)
        {
            PairModel pair = new PairModel();
            pair.ID = row.LID;
            pair.Name = row.LanguageName;

            return pair;

        }

    }
}

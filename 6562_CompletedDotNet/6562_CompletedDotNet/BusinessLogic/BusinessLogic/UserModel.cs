using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;

namespace BusinessLogic
{
    public class UserModel
    {
        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int userLevel;

        public int UserLevel
        {
            get { return userLevel; }
            set { userLevel = value; }
        }

        public static UserModel Parse(UserDataSet.TabUserRow row)
        {
            UserModel userModel = new UserModel();
            userModel.UserID = row.UID;
            userModel.Username = row.UserName;
            userModel.UserLevel = row.UserLevel;

            return userModel;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class TabUserModel
    {
     

        private int _uid;
        private string _userName;
        private string _password;
        private int _userLevel;

        

        

        public int Uid
        {
            get { return _uid; }
            set { _uid = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int UserLevel
        {
            get { return _userLevel; }
            set { _userLevel = value; }
        }

        

        public static TabUserModel Parse(UserDataSet.TabUserRow row)
        {
            if (row == null)
            {
                return null;
            }

            TabUserModel modelData = new TabUserModel();
            modelData.Uid = row.UID;
            modelData.UserName = row.UserName;
            modelData.Password = row.Password;

            switch (row.UserLevel)
            {
                case 1:
                    modelData.UserLevel = 1;
                    break;
                case 2:
                    modelData.UserLevel = 2;
                    break;
                case 3:
                    modelData.UserLevel = 3;
                    break;
                default:
                    modelData.UserLevel = 1;
                    break;
            }

            return modelData;
        }
    }
}

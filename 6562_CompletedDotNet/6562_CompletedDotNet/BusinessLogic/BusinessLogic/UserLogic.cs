using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class UserLogic
    {
        UserDataAccessObject userDAO = new UserDataAccessObject();

        public List<UserModel> GetAllUsers()
        {
            
            List<UserModel> users = new List<UserModel>();

            UserDataSet.TabUserDataTable userTable = userDAO.GetAllUsers();
            AddUserModelsToListFromTable(users, userTable);

            return users;
        }

        public List<UserModel> GetUsersByUsernameAndPassword(string username, string password)
        {
          
            List<UserModel> users = new List<UserModel>();

            
            UserDataSet.TabUserDataTable userTable = userDAO.GetUsersByUsernameAndPassword(username, password);
            AddUserModelsToListFromTable(users, userTable);

            return users;
        }

        private static void AddUserModelsToListFromTable(List<UserModel> users, UserDataSet.TabUserDataTable userTable)
        {
            
            foreach (UserDataSet.TabUserRow row in userTable.Rows)
            {
                UserModel user = UserModel.Parse(row);
                users.Add(user);
            }
        }

        
        public int AddNewUser(string username, string password, int userLevel, string email, int adminLevel)
        {
            if (adminLevel >= 3)
                 return userDAO.AddNewUser(username, password, userLevel, email);
            else
                return -1;
        }

        public int UpdatePassword(string newPassword, int userID, int adminLevel)
        {
            if (adminLevel >= 3)
                return userDAO.UpdatePassword(newPassword, userID);
            else
                return -1;
        }

        public int DeleteUser(int userID, int adminLevel)
        {
            if (adminLevel >= 3)
                return userDAO.DeleteUser(userID);
            else
                return -1;
        }
    }
}

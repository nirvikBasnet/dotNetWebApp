using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.UserDataSetTableAdapters;

namespace DataAccessLayer
{
    public class UserDataAccessObject
    {
        TabUserTableAdapter userTableAdapter;

        public UserDataAccessObject()
        {
            userTableAdapter = new TabUserTableAdapter();
        }

        // Get all users
        public UserDataSet.TabUserDataTable GetAllUsers()
        {
            try
            {
                return userTableAdapter.GetDataAll();
            }
            catch (Exception ex)
            {
                
                return null;
            }
        }

        // Get all users 
        public UserDataSet.TabUserDataTable GetUsersByUsernameAndPassword(string username, string password)
        {
            return userTableAdapter.GetDataByUserNameAndPassword(username, password);
        }

        // Insert new user
        public int AddNewUser(string username, string password, int userLevel, string email)
        {
            
            int rowsAffected = userTableAdapter.AddUser(username, password, userLevel, email);
            return rowsAffected;
        }

        public int UpdatePassword(string newPassword, int userID)
        {
            int rowsAffected = userTableAdapter.UpdatePassword(newPassword, userID);
            return rowsAffected;
        }

        public int DeleteUser(int userID)
        {
            int rowsAffected = userTableAdapter.DeleteUser(userID);
            return rowsAffected;
        }
    }
}

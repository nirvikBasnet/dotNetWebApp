using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;   //DataTable
using BusinessLogic;

namespace MyWSApp
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {
        UserLogic ul = new UserLogic();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        [WebMethod]
        public DataTable GetAllUserViaWS()
        {
           

            return AppUtil.ToDataTable(ul.GetAllUsers());
        }

        [WebMethod]
        public DataTable GetUsersByCredintials(string username,string password)
        {
            return ul.GetUsersByUsernameAndPassword(username,password).ToDataTable();
        }

        [WebMethod]
        public int addNewUsers(string username,string password,int userLevel,string email,int adminLevel)
        {
            return ul.AddNewUser(username, password, userLevel, email, adminLevel);
        }

        [WebMethod]
        public int deleteUser(int userID,int adminLevel)
        {
            return ul.DeleteUser(userID, adminLevel);
        }

    }
}

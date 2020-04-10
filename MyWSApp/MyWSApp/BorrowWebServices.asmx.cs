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
    /// Summary description for BorrowWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BorrowWebServices : System.Web.Services.WebService
    {
        BorrowLogic bl = new BorrowLogic();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataTable showAllBorrow()
        {
            return AppUtil.ToDataTable(bl.GetAllBorrow());

        }

        [WebMethod]
        public int addNewToBorrow(int UID, int mediaID, DateTime borrowDate, DateTime returnDate)
        {
            return bl.AddNewBorrow(UID, mediaID, borrowDate, returnDate);
        }

        [WebMethod]
        public int updateBorrow(DateTime actualReturn,int fee,int BorrowID)
        {
            return bl.UpdateBorrow(actualReturn, fee, BorrowID);
        }
    }
}

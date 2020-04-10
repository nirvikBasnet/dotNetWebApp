using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BorrowLogic
    {

        
        
        MediaDAO mediaDAO;

        public BorrowLogic()
        {
            mediaDAO = new MediaDAO();

        }

        public List<BorrowModel> GetAllBorrow()
        {

            MediaDataSet.TabBorrowDataTable borrowTable = mediaDAO.GetBorrowedMedias(); 

            if (borrowTable != null) 
            {
                return ConvertBorrowTableToBorrowList(borrowTable);
            }
            else
            {
                return null;
            }
        }

        private static List<BorrowModel> ConvertBorrowTableToBorrowList(MediaDataSet.TabBorrowDataTable borrowTable)
        {

            
            List<BorrowModel> borrowList = new List<BorrowModel>();


            foreach (MediaDataSet.TabBorrowRow row in borrowTable.Rows)
            {
                BorrowModel model = BorrowModel.Parse(row);
                borrowList.Add(model);
            }
            return borrowList;
        }

   

       
        public int AddNewReserve(int userID, int mediaID)
        {
            
            return mediaDAO.InsertReserve(userID, mediaID);
        }

       
        public int AddNewBorrow(int userID, int mediaID,DateTime borrowDate, DateTime returnDate)
        {
            
            return mediaDAO.AddNewBorrow(userID, mediaID,borrowDate, returnDate);

        }

        public int UpdateBorrow(DateTime actualReturn, int fee, int BorrowID)
        {
            return mediaDAO.UpdateBorrow(actualReturn, fee, BorrowID);
        }

        public int ReturnBorrowedMedia(int userID, int mediaID)
        {
           
            return mediaDAO.ReturnBorrow(userID, mediaID);
        }

        




    }
}

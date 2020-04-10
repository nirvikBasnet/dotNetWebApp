using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BorrowModel
    {
        private int borrowID;

        public int BorrowID
        {
            get { return borrowID; }
            set { borrowID = value; }
        }

        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private int mediaID;

        public int MediaID
        {
            get { return mediaID; }
            set { mediaID = value; }
        }

        private DateTime borrowDate;

        public DateTime BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }
        }


        private DateTime expectedReturnDate;

        public DateTime ExpectedReturnDate
        {
            get { return expectedReturnDate; }
            set { expectedReturnDate = value; }
        }

        private DateTime actualReturnDate;

        public DateTime ActualReturnDate
        {
            get { return actualReturnDate; }
            set { actualReturnDate = value; }
        }

        private decimal lateFee;

        public decimal LateFee
        {
            get { return lateFee; }
            set { lateFee = value; }
        }

        public static BorrowModel Parse(MediaDataSet.TabBorrowRow row)
        {
            BorrowModel model = new BorrowModel();
            model.BorrowID = row.BID;
            model.UserID = row.UID;
            model.MediaID = row.MediaID;
            model.BorrowDate = row.BorrowDate;
            model.ExpectedReturnDate = row.ReturnDate;
            model.ActualReturnDate = row.ActualReturnDate;
            model.LateFee = row.LateFee;

            return model;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITLibrary
{
    public class UserLevel
    {
        private int userLevelValue;

        public int UserLevelValue
        {
            get { return userLevelValue; }
            set { userLevelValue = value; }
        }

        private string userLevelDisplay;

        public string UserLevelDisplay
        {
            get { return userLevelDisplay; }
            set { userLevelDisplay = value; }
        }

        public UserLevel(int userLevelValue, string userLevelDisplay)
        {
            this.userLevelValue = userLevelValue;
            this.userLevelDisplay = userLevelDisplay;
        }
    }
}

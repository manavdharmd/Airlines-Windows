using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class User
    {
        private int age;
        private int ccExpiryMonth;
        private int ccExpiryYear;
        private string creditcardNo;
        private string creditcardType;
        private string name;
        private string password;
        private string userID;
       
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                
                 age = value;
            }
        }
        public int CcExpiryMonth
        {
            get
            {
                return ccExpiryMonth;
            }
            set
            {

                ccExpiryMonth = value;
            }
        }
        public int CcExpiryYear
        {
            get
            {
                return ccExpiryYear;
            }
            set
            {

                ccExpiryYear = value;
            }
        }
        public string CreditcardNo
        {
            get
            {
                return creditcardNo;
            }
            set
            {

                creditcardNo = value;
            }
        }
        public string CreditcardType
        {
            get
            {
                return creditcardType;
            }
            set
            {

                creditcardType = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {

                name = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {

                password = value;
            }
        }
        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {

                userID = value;
            }
        }
        public User(string userID, string name, string password, int age, string creditcardNo, string creditcardType, int ccExpiryMonth, int ccExpiryYear)
        {
            UserID =userID;
            Name = name;
            Password = password;
            Age = age;
            CreditcardNo = creditcardNo;
            CreditcardType = creditcardType;
            CcExpiryMonth = ccExpiryMonth;
            CcExpiryYear = ccExpiryYear;
        }       
    }
}

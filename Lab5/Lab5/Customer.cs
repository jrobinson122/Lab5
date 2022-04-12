using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Customer
    {
        private string name;
        private int phoneNumber;
        private string email;
        private int paymentInformation;



        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }

        }
        public int PaymentInformation
        {
            get { return paymentInformation; }
            set { paymentInformation = value; }
        }





    }
}

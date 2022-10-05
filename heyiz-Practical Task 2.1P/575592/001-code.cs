using System;
using System.Collections.Generic;
using System.Text;


namespace MobileProgram
{   
    /// <summary>
    /// The mobile class defines attributes and methods on mobile
    /// phone account
    /// </summary>
    class Mobile
    {   
        //Instance variables
        private String accType, device, number;
        private double balance;

        //Variables
        private const double CALL_COST = 0.245;
        private const double TEXT_COST = 0.078;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="accType">the account type</param>
        /// <param name="device">the mobile phone make and model</param>
        /// <param name="number">the mobile phone number</param>
        public Mobile(String accType, String device, String number)
        {
            this.accType = accType;
            this.device = device;
            this.number = number;
            this.balance = 0.0;
        }
        public String getAccType()
        {
            return this.accType;
        }
        public String getDevice()
        {
            return this.device;
        }

        public String getNumber()
        {
            return this.number;
        }
        public String getBalance()
        {
            //return the balance as acurrency through the
            //To String method and the parameter "c"
            return this.balance.ToString("C");
        }

        //Mutator Methods
        public void setAccType(String accType)
        {
            this.accType = accType;
        }
        public void setDevice(String device)
        {
            this.device = device;
        }
        public void setNumber(String number)
        {
            this.number = number;
        }
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
        // Method
        public void addCredit(double amout)
        {
            this.balance += amout;
            Console.WriteLine("Credit added succesfully. New balance " + getBalance());
        }
        public void makeCall(int minutes)
        {
            double cost = minutes * CALL_COST;
            this.balance -= cost;
            Console.WriteLine("Call made. New balance " + getBalance());
        }
        public void sendText(int numTexts)
        {
            double cost = numTexts * TEXT_COST;
            this.balance -= cost;
            Console.WriteLine("Text sent .New balace " + getBalance());
        }
    }
}

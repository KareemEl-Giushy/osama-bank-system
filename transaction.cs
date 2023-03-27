using System;
namespace BankSystem
{
    class Transaction
    {
        public DateTime time;
        float amount;
        string type = "";

        /*
        * From whom transaction (User)
        * To Whom (User <= Partner)
        *
        */


        Transaction()
        {
            time = DateTime.Now;
        }

        public Transaction(float aAmount)
        {
            amount = aAmount;
        }

        public Transaction(string atype)
        {
            type = atype;
        }
    }



}
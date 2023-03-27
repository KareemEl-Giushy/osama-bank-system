using System;

namespace BankSystem
{
    class Partner
    {
        private float bankBalance = 0;
        private DateTime timeOfTransaction;

        public Partner()
        {
            timeOfTransaction = DateTime.Now;
        }


        // Takes the transaction instead of just the amount
        public float CashGained(float amount)
        {
            bankBalance += amount;
            return bankBalance;
        }

        public float BankBalance
        {
            get { return bankBalance; }
            set { bankBalance = value; }
        }

        public DateTime TimeOfTransaction
        {
            get { return timeOfTransaction; }
            set { timeOfTransaction = value; }
        }
    }
}
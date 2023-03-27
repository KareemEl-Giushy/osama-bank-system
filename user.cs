using System;
namespace BankSystem
{
    class User
    {
        string Name = "";
        string cardNum = "";
        Wallet UserWallet;



        public void Register(Wallet w)
        {
            UserWallet.Balance = w.Balance;
            UserWallet.cardNum = w.cardNum;
            UserWallet.Name = w.Name;
        }

        public User()
        {
            Name = "Osama";
            UserWallet = new Wallet();
        }
        public User(Wallet w)
        {
            UserWallet = new Wallet();
            Register(w);

        }


        public float Deposit(float amount)
        {
            UserWallet.Balance += amount;
            return UserWallet.Balance;
        }

        public float Withdraw(float amount)
        {
            UserWallet.Balance -= amount;

            return UserWallet.Balance;
        }

        public float BalanceInquiry()
        {
            return UserWallet.Balance;
        }


        /*
        * Return (Transaction object containing Transaction Details)
        * Params (time, amount, type)
        */


    }

}
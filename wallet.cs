namespace BankSystem
{

    internal class Wallet
    {
        public float Balance;
        public string cardNum = "0000";
        public string Name = "Osama";



        public Wallet() { }
        public Wallet(float InitialBalance)
        {
            Balance = InitialBalance;
        }

        public Wallet(string aName, string acardNum)
        {
            Name = aName;
            cardNum = acardNum;

        }






    }

}
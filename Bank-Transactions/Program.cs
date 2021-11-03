using System;
using Transactions;

namespace Bank_Transactions
{
    class Program
    {
        static void Main()
        {
            Account myAccount = new Account();
            myAccount.Notify += Print;
            myAccount.PutMoney(100);
            myAccount.TakeMoney(500);
            myAccount.PutDeposit(350000, 4.7, 273);
            myAccount.Accruals();
        }

        public static void Print(string massage)
        {
            Console.WriteLine(massage);
        }
    }
}
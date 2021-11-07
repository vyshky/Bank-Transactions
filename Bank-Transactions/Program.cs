using System;
using Transactions;

namespace Bank_Transactions
{
    class Program
    {
        static void Main()
        {
            Account myAccount = new Account();
            myAccount.Notify += Print; //тоже самое
            myAccount.Notify += Print2(); //тоже самое
            myAccount.PutMoney(100);
            Console.WriteLine($"Сумма на счете : {myAccount.Sum}");
            myAccount.TakeMoney(10);
            Console.WriteLine($"Сумма на счете : {myAccount.Sum}");
            myAccount.PutDeposit(350000, 4.7, 273);
            myAccount.Accruals();
        }

        public static AccountHandler Print2() // Анонимная функция
        {
            AccountHandler temp = delegate(string message) { Console.WriteLine(message); };
            return temp;
        }

        public static void Print(string massage) // Простая функция
        {
            Console.WriteLine(massage);
        }
    }
}
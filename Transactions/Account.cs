using System;

namespace Transactions
{
    public sealed class Account
    {
        public delegate void Message(string message);

        public event Message Notify;
        public decimal Sum { get; private set; }
        private Deposit Deposit { get; set; }

        public Account()
        {
            Sum = 0;
        }

        public void PutMoney(decimal money)
        {
            if (money >= 0) Sum += money;
            Notify?.Invoke($"На счет поступило: {money}");
        }

        public void TakeMoney(decimal money)
        {
            if (Sum >= money && money >= 0)
            {
                Sum -= money;
                Notify?.Invoke($"Со счета снято: {money}");
            }
        }

        public void PutDeposit(double deposit, double interestRate, int countDay)
        {
            Deposit = new Deposit(deposit, interestRate, countDay);
            Notify?.Invoke($"На депозит поступило: {deposit}");
            Notify?.Invoke($"Под : {interestRate}%");
            Notify?.Invoke($"На : {countDay} дней");
        }

        public double Accruals()
        {
            if (Deposit == null) throw new NullReferenceException("Ваш депозит пуст");
            var temp = Deposit.Accruals();
            Notify?.Invoke($"Общая прибыл прибыль депозита : {temp}");
            return temp;
        }
    }
}
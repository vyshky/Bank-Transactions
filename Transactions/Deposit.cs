namespace Transactions
{
    public sealed class Deposit
    {
        private int _countDay;
        private double _deposit;
        private double _interestRate;

        public Deposit(double deposit, double interestRate, int countDay)
        {
            _deposit = deposit;
            _interestRate = interestRate;
            _countDay = countDay;
        }

        public double Accruals()
        {
            return (_deposit * _interestRate * _countDay / 365) / 100;
        }
    }
}
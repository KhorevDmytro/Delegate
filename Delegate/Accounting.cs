namespace Delegate
{
    public class Accounting
    {
        public delegate void SalarySize(int day);

        public delegate void WaitingTime();

        public event SalarySize onPay;

        public event WaitingTime wait;

        public void Work(int payDay)
        {
            for (var i = 1; i < 31; i++) {
                if (i == 4) {
                    onPay(4);
                }
                wait();
            }
        }
    }
}
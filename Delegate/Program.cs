namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            SalaryTime salaryTime = new SalaryTime();
            WaitingTime waitingTime = new WaitingTime();

            Accounting accounting = new Accounting();
            accounting.onPay += salaryTime.Earn;
            accounting.wait += waitingTime.Wait;

            accounting.Work(31);
        }
    }
}
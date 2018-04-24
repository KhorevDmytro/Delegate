using System.Diagnostics;

namespace Delegate
{
    public class SalaryTime
    {
        public void Earn(int payDay)
        {
            Debug.WriteLine($" Today is {payDay.ToString()}. I've earned a lot of money, let's go Shopping");
        }
    }
}
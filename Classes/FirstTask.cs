using System;
namespace Olympiad.Classes
{
    public class FirstTask
    {
        public void ProductPurchase(
                int costingRub,
                int costingCop,
                int returnedRub,
                int returnedCop
            )
        {
            int[] args = { costingRub, costingCop, returnedCop, returnedRub };
            foreach (int c in args)
            {
                if (c < 0 || c > 100)
                {
                    throw new Exception("Number must have non negative value and < 100");
                }
            }

            if (returnedCop - costingCop < 0)
            {
                returnedRub--;
                returnedCop = 100;
            }

            Console.WriteLine($"{returnedRub - costingRub} {returnedCop - costingCop}");
        }

        public FirstTask()
        {
        }
    }
}

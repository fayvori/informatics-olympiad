using System;
using Olympiad.Classes.Util;

namespace Olympiad.Classes
{
    public class ThirdTask
    {

        public void SwapInts(int[] numbers, int toSwap)
        {

            if (toSwap > numbers.Length)
            {
                throw new IndexOutOfRangeException("Number > numbers.Lenght");
            } else if (toSwap < numbers.Length)
            {
                throw new IndexOutOfRangeException("Number < numbers.Lenght");
            }

            Comparison comp = new Comparison();
            Finding find = new Finding();

            int minNumber = comp.Min(numbers);
            int maxNumber = comp.Max(numbers);
            int minNumberIndex = find.FindArrayIndex(numbers, minNumber);
            int maxNumberIndex = find.FindArrayIndex(numbers, maxNumber);

            numbers[minNumberIndex] = maxNumber;
            numbers[maxNumberIndex] = minNumber;

            foreach (int c in numbers)
            {
                Console.Write($"{c} ");
            }
        }

        public ThirdTask()
        {
        }
    }
}

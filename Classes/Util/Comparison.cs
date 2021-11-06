using System;
namespace Olympiad.Classes.Util
{
    public class Comparison
    {
        public int Min(int[] arr)
        {
            int Min = arr[0];

            foreach (int c in arr)
            {
                if (c < Min)
                {
                    Min = c;
                }
            }

            return Min;
        }

        public int Max(int[] arr)
        {
            int Max = arr[0];

            foreach (int c in arr)
            {
                if (c > Max)
                {
                    Max = c;
                }
            }

            return Max;
        }

        public Comparison()
        {
        }
    }
}

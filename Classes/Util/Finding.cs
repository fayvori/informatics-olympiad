using System;
namespace Olympiad.Classes.Util
{
    public class Finding
    {
        public int FindArrayIndex(int[] arr, int item)
        {
            int position = 0;

            for (int c = 0; c < arr.Length; c++)
            {
                if (arr[c] == item)
                {
                    position = c;
                    break;
                }

            }

            return position;

        }

        public Finding()
        {
        }
    }
}

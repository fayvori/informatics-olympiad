using System;

namespace Olympiad.Classes
{
    public class SecondTask
    {

        public void RemoveNumber(int number, int numberToDelete)
        {
            string numberString = number.ToString();
            string temp = "";

            if (number < 0)
            {
                throw new Exception("number < 0");
            }

            foreach (char c in numberString)
            {

                if (int.Parse(c.ToString()) == numberToDelete)
                {
                    continue;
                }

                temp += c;
                
            }

            Console.WriteLine(int.Parse(temp));
        }

        public SecondTask()
        {
        }
    }
}

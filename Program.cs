using System;
using Olympiad.Classes;
using Olympiad.Classes.Util;

namespace Olympiad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test first Programm
            // ft.ProductPurchase(2, 1, 3, 2) = "1 1" passed
            // ft.ProductPurchase(2, 1, 4, 0) = "1 99" passed

            FirstTask ft = new FirstTask();
            ft.ProductPurchase(2, 1, 4, 0);


            // Test second Programm
            // st.RemoveNumber(1048576, 1); = "48576" passed
            // st.RemoveNumber(173, 2); = "13" ?
            SecondTask st = new SecondTask();
            st.RemoveNumber(1048576, 1);


            // Test third Programm
            // tt.SwapInts(temp, 5) = "3 273 13 2 99" passed
            ThirdTask tt = new ThirdTask();

            // support array
            int[] temp = { 3, 2, 13, 273, 99 };
            tt.SwapInts(temp, 5);

            Console.ReadKey();
        }
    }
}

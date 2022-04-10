using System;
using System.Collections.Generic;

namespace _8_queens
{
    class Program
    {
        private static CheckerService checker = CheckerService.GetInstance();
        private static VisualizeService visualize = VisualizeService.GetInstance();
        private static int count = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            GetCombinations(arr, 0, arr.Length-1);
            Console.WriteLine("Solutions: "+count.ToString());
            
        }

        public static void swapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void GetCombinations(int[] list, int k, int m)
        {
            Layout layout = new Layout(new List<Queen>());
            int i;
            if (k == m)
            {
                
                for (i = 0; i <= m; i++)
                {
                    layout.queens.Add(new Queen(new int[] { i + 1, list[i] }));
                }
                    
                if (checker.IsAllGood(layout))
                {
                    //foreach (var item in layout.queens)
                    //{
                    //    Console.Write(item.place[1].ToString() + " ");
                    //}
                    //Console.Write("\n");
                    visualize.PrintToConsole(layout);
                    count++;
                }
            }
            
            
            else
                for (i = k; i <= m; i++)
                {
                    swapTwoNumber(ref list[k], ref list[i]);
                    GetCombinations(list, k + 1, m);
                    swapTwoNumber(ref list[k], ref list[i]);
                }
        }
    }
}

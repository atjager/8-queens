using System;
using System.Collections.Generic;

namespace _8_queens
{
    public sealed class CombinationService
    {
        private static CheckerService checker = CheckerService.GetInstance();
        private static VisualizeService visualize = VisualizeService.GetInstance();
        public  int count { get; set; }
        public  string tablesContent { get; set; }

        public CombinationService()
        {
            count = 0;
            tablesContent = "";

        }

        public static CombinationService _instance;

        public static CombinationService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CombinationService();
            }
            return _instance;
        }

        //segéd methódus a getCombinations-hez
        public void swapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //megkeresi és összeállítja az összes lehetséges layout-ot a sakktáblán
        public void GetCombinations(int[] list, int k, int m)
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

                    Console.WriteLine("There is a solution: ");
                    visualize.PrintToConsole(layout);
                    tablesContent += visualize.CreateHtml(layout);
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


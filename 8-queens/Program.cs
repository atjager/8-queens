using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_queens
{
    class Program
    {
        private static VisualizeService visualize = VisualizeService.GetInstance();
        private static CombinationService combination = CombinationService.GetInstance();
     
        static void Main(string[] args)
        {
            //tömb generálás 1 és 8 közötti értékekkel
            int[] arr = Enumerable.Range(1, 8).Select(i => i).ToArray();

            combination.GetCombinations(arr, 0, arr.Length - 1);

            Console.WriteLine("This problem has {0} individual solutions.", combination.count.ToString());

            //megoldások vizualizációja, futás közben a GetCombinations elvégzi, itt a fájlba íratás történik
            visualize.TemplateHandler(combination.tablesContent);

        }

    }
}

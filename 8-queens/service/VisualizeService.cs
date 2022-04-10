using System;
using System.Linq;

namespace _8_queens
{
    public sealed class VisualizeService
    {
        public static VisualizeService _instance;

        public static VisualizeService GetInstance()
        {
            if(_instance == null)
            {
                _instance = new VisualizeService();
            }
            return _instance;
        }

        public void PrintToConsole(Layout layout)
        {
            int i = 0;
            foreach (var item in layout.queens)
            {
                Console.Write((Enumerable.Range('A', 8).Select(x => (char)x).ToArray())[i] +item.place[1].ToString()+" ");
                i++;
            }
            Console.Write("\n");
        }

       
    }
}

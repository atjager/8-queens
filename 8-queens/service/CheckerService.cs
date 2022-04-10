using System;
using System.Linq;

namespace _8_queens
{
    public sealed class CheckerService
    {

        public CheckerService()
        {

        }
        private static CheckerService _instace;

        public static CheckerService GetInstance()
        {
            if(_instace == null)
            {
                _instace = new CheckerService();
            }
            return _instace;
        }

        public bool IsAllGood(Layout layout)
        {
            for (int i =0; i<layout.queens.Count; i++)
            {
                for (int j = i+1; j < layout.queens.Count; j++)
                {
                    if (!Check2(layout.queens.ElementAt(i).place, layout.queens.ElementAt(j).place))
                        return false;
                }
            }
            return true;
        }

        public bool Check2(int[] n1, int[] n2)
        {
            if (Math.Abs(n2[0] - n1[0]) == Math.Abs(n2[1] - n1[1]))
                return false;
            return true;
        }

    }
}

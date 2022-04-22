using System;
using System.Linq;

namespace _8_queens
{
    //singleton osztály, minden példányosításkor ugyanazzal a példányal tér vissza, adatot nem tárol, csak a methdóusok a lényeg
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

        /*megnézi, hogy nem ütik-e egymást a királynők
         végigiterál a layouton és megvizsgálja balról jobbra (A->B) hogy az aktuális és az utána lévő királynők ütik-e egymást, ha igen, akkor viszatér false-al
         */
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

        //2 királynő poziciójából megmondja, hogy ütik-e egymást
        public bool Check2(int[] n1, int[] n2)
        {
            if (Math.Abs(n2[0] - n1[0]) == Math.Abs(n2[1] - n1[1]))
                return false;
            return true;
        }

    }
}

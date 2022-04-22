using System;
namespace _8_queens
{
    public class Queen
    {
        //királynő helye: 0:A-B, 1:1-8 -> pl.: [2,5] = B5-ös pozíció
        public int[] place { get; set; }

        public Queen(int[] place)
        {
            this.place = place;
        }

    }
}

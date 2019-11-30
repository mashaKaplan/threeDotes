using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeDotes
{
    class StraightLine {
        public void CheckStraightLine(Dote[] dotes)
        {
            double square = Math.Abs(((dotes[0].x - dotes[2].x) * (dotes[1].y - dotes[2].y) - 
                (dotes[1].x - dotes[2].x) * (dotes[0].y - dotes[2].y)) / 2);
            string isLine = square > 0 ? "not " : "";
            Console.WriteLine("The entered dotes are " + isLine + "a stright line");
            Console.ReadKey();
        }
    }
}

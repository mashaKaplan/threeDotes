using System;

namespace ThreeDotes
{
    class Program
    {
        static void Main(string[] args)
        {
            StraightLine straightLine = new StraightLine();
            Dote[] dotesArray = new Dote[3];
            dotesArray[0] = new Dote(10, 1);    
            dotesArray[1] = new Dote(4, 2);    
            dotesArray[2] = new Dote(7, 1);    
            straightLine.CheckStraightLine(dotesArray);
        }
    }
}

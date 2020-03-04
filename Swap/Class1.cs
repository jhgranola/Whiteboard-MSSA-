using System;

        //      Make X equal to Y and Y equal to X without declaring any new variables.

namespace Swap
{
    public class Class1
    {
        public static void SwapXY(ref int x,ref int y)
        {
            y = x + y;
            x = y - x;
            y = y - x;
        }
    }
}

using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation.Media;

namespace SimpleCalculator
{
    public class Program
    {
        public static int AgentSize = 128;

        public static void Main()
        {
            var screen = new Bitmap(Bitmap.MaxWidth, Bitmap.MaxHeight);

            //new up our calculator
            var calc = new Calculator();

            //let it render itself
            calc.Render(screen);


            Debug.Print("Sleeping...");
            Thread.Sleep(Timeout.Infinite);
        }

    }
}
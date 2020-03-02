using System;

namespace VotingSys
{
    class Program
    {
        static void Main(string[] args)
        {
            int yesCounter = 4;
            int noCounter = 3;
            int maybeCounter = 2;
            int total = yesCounter + noCounter;

            var yesPercent = Math.Round(yesCounter * 100.0 / total, 2);
            var noPercent = Math.Round(noCounter * 100.0 / total, 2);
            var maybePercent = Math.Round(maybeCounter * 100.0 / total, 2);
            var excess = Math.Round(100 - yesPercent - noPercent - maybePercent, 2);
           
            Console.WriteLine($"Excess:{excess}");


            if (yesCounter > noCounter)
            {
                if (yesCounter > maybeCounter) {
                    Console.WriteLine($"Yes Won");
                    yesPercent += excess;
                }
                else if (maybeCounter > yesCounter)
                {
                    Console.WriteLine($"Maybe Won");
                    maybePercent += excess;

                }
                else
                {
                    Console.WriteLine($"Draw");
                    noPercent += excess;
                }
            }
            else if (noCounter > yesCounter)
            {
                if (noCounter > maybeCounter)
                {
                    Console.WriteLine($"No Won");
                    noPercent += excess;
                }
                else if (maybeCounter > noCounter)
                {
                    Console.WriteLine($"Maybe Won");
                    maybePercent += excess;
                }
                else
                {
                    Console.WriteLine($"Draw");
                    yesPercent += excess;
                }
            }
            else if (maybeCounter > yesCounter)
            {
                Console.WriteLine($"Maybe Won");
                maybePercent += excess;
            }
            else {
                Console.WriteLine($"DRAW");
                

            }
            Console.WriteLine($"Yes counts:{yesCounter},Percentage:{yesPercent}%");
            Console.WriteLine($"No counts:{noCounter},Percentage:{noPercent}%");
            Console.WriteLine($"Maybe counts:{maybeCounter},Percentage:{maybePercent}%");
            Console.WriteLine($"Total Percentage:{maybePercent + yesPercent + noPercent}");


        }
    }
}

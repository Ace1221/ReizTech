using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech
{
    class AnalougeClock
    {
        private static void Main(string[] args)
        {


            char exitChar;
            do
            {
                int hoursHand, minutesHand;
                bool successHours, successMinutes;
                do
                {
                    Console.WriteLine("Please enter the value that corresponds to the hours hand on an analouge clock (0-12)");
                    successHours = int.TryParse(Console.ReadLine(), out hoursHand);
                    if (!successHours)
                        Console.WriteLine("Invalid input, please write a number that correlates to the hours hand on a clock");
                    if (hoursHand < 0 || hoursHand > 12)
                        Console.WriteLine("Invalid input, please write a number between 0 and 12");
                    Console.WriteLine();
                }
                while (!successHours || hoursHand < 0 || hoursHand > 12);
                do
                {
                    Console.WriteLine("Please enter the value that corresponds to the minutes hand on an analouge clock (0-59)");
                    successMinutes = int.TryParse(Console.ReadLine(), out minutesHand);
                    if (!successMinutes)
                        Console.WriteLine("Invalid input, please write a number that correlates to the minutes hand on a clock");
                    if (minutesHand < 0 || minutesHand > 59)
                        Console.WriteLine("Invalid input, please write a number between 0 and 59");
                    Console.WriteLine();
                }
                while (!successMinutes || minutesHand < 0 || minutesHand > 59);

                double hourAngle = (hoursHand % 12 + minutesHand / 60.0) * 30;  // Hour hand moves 30 degrees per hour (360/12 hours)
                double minuteAngle = minutesHand * 6;  // Minute hand moves 6 degrees per minute (360/60 minutes)

                double angle = Math.Abs(hourAngle - minuteAngle);

                if (angle > 180)
                {
                    angle = 360 - angle;
                }

                Console.WriteLine("The lesser angle between the hour and minute hands is: " + angle + " degrees");
                Console.WriteLine();
                Console.WriteLine("Press 'x' to exit.");
                exitChar = Console.ReadKey().KeyChar;
            }
            while (exitChar != 'x' && exitChar != 'X');

        }
    }
}

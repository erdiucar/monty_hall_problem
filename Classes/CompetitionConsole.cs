using System;

namespace monty_hall_problem
{
    public class CompetitionConsole
    {
        public Competition Competition { get; set; }

        public CompetitionConsole(Competition competition)
        {
            Competition = competition;
        }

        public void Write()
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.Write("When the competitor doesn't change the picked door, wins the car ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Competition.Statistics.WinningCountWhenStayOnThePickedDoor);
                }
                else
                {
                    Console.Write("When the competitor change the picked door, wins the car ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Competition.Statistics.WinningCountWhenChangeThePickedDoor);
                }

                Console.ResetColor();
                Console.Write(" times.");
                Console.WriteLine();
            }
        }
    }
}
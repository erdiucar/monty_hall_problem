using System;

namespace monty_hall_problem
{
    public class CompetitionConsole
    {
        public Statistics Statistics { get; set; }

        public CompetitionConsole(Statistics statistics)
        {
            Statistics = statistics;
        }

        public void WriteStatistics()
        {
            WriteLine("When the competitor doesn't change the picked door, wins the car", ConsoleColor.Red, Statistics.WinningCountWhenStayOnThePickedDoor);
            WriteLine("When the competitor change the picked door, wins the car", ConsoleColor.Green, Statistics.WinningCountWhenChangeThePickedDoor);
        }

        private void WriteLine(string sentence, ConsoleColor counterColor, int winningStatistics)
        {
            Console.Write(sentence + " ");
            Console.ForegroundColor = counterColor;
            Console.Write(winningStatistics);
            Console.ResetColor();
            Console.WriteLine(" times.");
        }
    }
}
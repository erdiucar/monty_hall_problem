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

        public void WriteStatistics()
        {
            WriteLine("When the competitor doesn't change the picked door, wins the car", ConsoleColor.Red, Competition.Statistics.WinningCountWhenStayOnThePickedDoor);
            WriteLine("When the competitor change the picked door, wins the car", ConsoleColor.Green, Competition.Statistics.WinningCountWhenChangeThePickedDoor);
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
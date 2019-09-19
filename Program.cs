using System;

namespace monty_hall_problem
{
    class Program
    {
        static void Main()
        {
            try
            {
                Competition competition = new Competition(100, 3);
                competition.Start();

                CompetitionConsole competitionConsole = new CompetitionConsole(competition);
                competitionConsole.WriteStatistics();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}

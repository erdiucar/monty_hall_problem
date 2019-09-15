using System;

namespace monty_hall_problem
{
    class Program
    {
        static void Main()
        {
            try
            {
                Competition competition = new Competition(1000, 3);
                competition.Start();

                CompetitionConsole competitionConsole = new CompetitionConsole(competition);
                competitionConsole.Write();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

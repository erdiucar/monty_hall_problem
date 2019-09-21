using System;

namespace monty_hall_problem
{
    class Program
    {
        private const int COMPETITION_REPEAT = 1000;
        private const int DOORS_COUNT = 3;

        static void Main()
        {
            try
            {
                Statistics statistics = new Statistics();

                for (int i = 0; i < COMPETITION_REPEAT; i++)
                {
                    // Start a new competition
                    Competition competition = new Competition(DOORS_COUNT);

                    // If the car is behind the picked door, increase staying wins, else increase changing wins
                    if (competition.Competitor.PickedDoor.Number == competition.Stage.CarDoorNumber)
                        statistics.WinningCountWhenStayOnThePickedDoor++;
                    else
                        statistics.WinningCountWhenChangeThePickedDoor++;
                }

                MontyHallProblemConsole montyHallProblemConsole = new MontyHallProblemConsole(statistics);
                montyHallProblemConsole.WriteStatistics();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}

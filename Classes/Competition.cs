using System;

namespace monty_hall_problem
{
    public class Competition
    {
        public Stage Stage { get; private set; }
        public Competitor Competitor { get; private set; }

        public Competition(int doorsCount)
        {
            if (doorsCount < 3)
            {
                throw new ArgumentOutOfRangeException("The number of doors must be at least 3.");
            }
            else if (doorsCount > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Start a competition
            Stage = new Stage(doorsCount);
            Competitor = new Competitor();

            // Competitor picks a door
            Competitor.PickADoor(Stage);
        }
    }
}
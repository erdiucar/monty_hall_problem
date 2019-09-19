using System;

namespace monty_hall_problem
{
    public class Competition
    {
        public int Count { get; private set; }
        public int DoorsCount { get; private set; }
        public Statistics Statistics { get; private set; }

        public Competition(int count, int doorsCount)
        {
            if (count < 1 || doorsCount < 3)
            {
                throw new Exception("Count number must be over 1 and doors count number must be over 3.");
            }

            Count = count;
            DoorsCount = doorsCount;
            Statistics = new Statistics();
        }

        public void Start()
        {
            // Competition repeat
            for (int i = 0; i < Count; i++)
            {
                Stage stage = new Stage(DoorsCount);
                Competitor competitor = new Competitor();

                competitor.PickADoor(stage);

                // If the car is behind the picked door, increase staying wins, else increase changing wins
                if (competitor.PickedDoor.Number == stage.CarDoorNumber)
                    Statistics.WinningCountWhenStayOnThePickedDoor++;
                else
                    Statistics.WinningCountWhenChangeThePickedDoor++;
            }
        }
    }
}
using System;

namespace monty_hall_problem
{
    public class Stage
    {
        public Door[] Doors { get; private set; }
        public int CarDoorNumber { get; private set; }
        public int DoorsCount { get; private set; }

        public Stage(int doorsCount)
        {
            Doors = new Door[doorsCount];
            DoorsCount = doorsCount;

            for (int i = 0; i < doorsCount; i++)
            {
                Doors[i] = new Door(i, Behind.Goat);
            }

            Random random = new Random();
            var carDoorNumber = random.Next(doorsCount);

            // Put the car behind a random door
            CarDoorNumber = carDoorNumber;
            Doors[carDoorNumber].Behind = Behind.Car;
        }
    }
}

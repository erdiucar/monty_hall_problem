using System;
using System.Collections.Generic;

namespace monty_hall_problem
{
    public class Doors
    {
        public Door[] States { get; private set; }
        public int CarDoorNumber { get; private set; }
        public int Count { get; private set; }

        public Doors(int count)
        {
            States = new Door[count];
            Count = count;

            for (int i = 0; i < Count; i++)
            {
                States[i] = new Door(i, Behind.Goat);
            }

            Random random = new Random();
            var carDoorNumber = random.Next(Count);

            // Put the car behind a random door
            CarDoorNumber = carDoorNumber;
            States[carDoorNumber].Behind = Behind.Car;
        }
    }
}

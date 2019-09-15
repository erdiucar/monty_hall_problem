using System;

namespace monty_hall_problem
{
    public class Competitor
    {
        public Door PickedDoor { get; private set; }

        // Pick a random door
        public void PickADoor(Doors doors)
        {
            Random random = new Random();
            int pickedDoorNumber = random.Next(doors.Count);

            PickedDoor = doors.States[pickedDoorNumber];
        }
    }
}
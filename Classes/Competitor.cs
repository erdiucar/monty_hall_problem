using System;

namespace monty_hall_problem
{
    public class Competitor
    {
        public Door PickedDoor { get; private set; }

        // Pick a random door
        public void PickADoor(Stage stage)
        {
            Random random = new Random();
            int pickedDoorNumber = random.Next(stage.DoorsCount);

            PickedDoor = stage.Doors[pickedDoorNumber];
        }
    }
}

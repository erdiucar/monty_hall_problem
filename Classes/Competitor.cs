using System;

namespace monty_hall_problem
{
    public class Competitor
    {
        public Door PickedDoor { get; private set; }
        private Random random = new Random();
        // Pick a random door
        public void PickADoor(Stage stage)
        {
            int pickedDoorNumber = random.Next(stage.DoorsCount);

            PickedDoor = stage.Doors[pickedDoorNumber];
        }
    }
}

using System;

namespace monty_hall_problem
{
    public class Competitor
    {
        public Door PickedDoor { get; private set; }

        // Pick a random door
        public void PickADoor(Stage stage)
        {
            int pickedDoorNumber = Randomize.GetNumber(stage.DoorsCount);

            PickedDoor = stage.Doors[pickedDoorNumber];
        }
    }
}

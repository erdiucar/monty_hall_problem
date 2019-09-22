namespace monty_hall_problem
{
    public class Statistics
    {
        public int WinningCountWhenStayOnThePickedDoor { get; set; }
        public int WinningCountWhenChangeThePickedDoor { get; set; }

        public Statistics()
        {
            WinningCountWhenStayOnThePickedDoor = 0;
            WinningCountWhenChangeThePickedDoor = 0;
        }
    }
}

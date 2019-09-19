namespace monty_hall_problem
{
    public class Door
    {
        public int Number { get; private set; }
        public Behind Behind { get; set; }

        public Door(int number, Behind behind)
        {
            Number = number;
            Behind = behind;
        }
    }
}

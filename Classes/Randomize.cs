using System;

namespace monty_hall_problem
{
    public static class Randomize
    {
        private static readonly Random random = new Random();

        public static int GetNumber(int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}

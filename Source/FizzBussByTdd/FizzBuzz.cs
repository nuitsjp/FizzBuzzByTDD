using System;

namespace FizzBussByTdd
{
    public class FizzBuzz
    {
        public string Convert(int value)
        {
            if (value % 3 == 0) return "Fizz";
            if (value % 5 == 0) return "Buzz";

            return value.ToString();
        }
    }
}

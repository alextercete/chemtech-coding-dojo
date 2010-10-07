namespace CodingDojo
{
    public class FizzBuzzCalculator
    {
        internal string Calculate(int number)
        {
            string r2d2 = number.ToString();

            if (number % 3 == 0 && number % 5 == 0)
            {
                r2d2 = "FIZZBUZZ";
            }
            else if (number % 3 == 0)
            {
                r2d2 = "FIZZ";
            }
            else if (number % 5 == 0)
            {
                r2d2 = "BUZZ";
            }

            return r2d2;
        }
    }
}

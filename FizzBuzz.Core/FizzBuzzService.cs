namespace FizzBuzz.Core;
public class FizzBuzzService
{
    public string Print(int number)
    {
        if (IsDivisibleByThree(number) && IsDivisibleByFive(number))  //number % 15 == 0
        {
            return "FizzBuzz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else if (number % 3 == 0)
        {
            return "Fizz";
        }
        return number.ToString();

    }
    
    private static bool IsDivisibleByFive(int number) {
        return number % 5 == 0;
    }
    private bool IsDivisibleByThree(int number)
    {
        return number % 3 == 0;
    }


}

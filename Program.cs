namespace ProblemSolving;

internal class Program
{
    static void Main(string[] args)
    {
        //problemSolvingCodewarse
    }
    //==This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.
    public static int Multiply(int x)
    {
        if (x % 2 == 0)
        {
            return x * 8;
        }
        else
        {
            return x * 9;
        }
    }
    //The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc
    public static int СenturyFromYear(int year)
    {
        if (year % 100 == 0)
        {
            return year / 100;
        }
        else
        {
            return year / 100 + 1;

        }
    }
    //Create a function that checks if a number n is divisible by two numbers x AND y. All inputs are positive, non-zero numbers.
    public static bool IsDivisible(int n, int x, int y)
    {
        if (n % x == 0 && n % y == 0)
        {
            return true;

        }
        return false;
    }
}

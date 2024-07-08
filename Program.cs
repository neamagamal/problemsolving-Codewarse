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

    //Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
    public static string EvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            return "Even";
        }
        else return "Odd";
    }
    /*Complete the solution so that it reverses the string passed into it.
  'world'  =>  'dlrow'
  'word'   =>  'drow'*/
    public static string Solution(string str)
    {
        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed += str[i];
        }
        return reversed;
    }
    //Implement a function which convert the given boolean value into its string representation.
    public static string BooleanToString(bool b)
    {
        return b == true ? "True" : "False";
    }
    // There's a "3 for 2" (or "2+1" if you like) offer on mangoes. For a given quantity and price (per mango), calculate the total cost of the mangoes.
    public static int Mango(int quantity, int price)
    {
        return (quantity - quantity / 3) * price;
    }
    //Given a month as an integer from 1 to 12, return to which quarter of the year it belongs as an integer number.
    int quarter_of(int month)
    {
        if (month < 4)
        {
            return 1;
        }
        else if (month < 7)
        {
            return 2;
        }
        else if (month < 10)
        {
            return 3;
        }
        else return 4;
    }










}



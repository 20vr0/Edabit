//Create a function that takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.

public class Program
{
    public static int Factorial(int num)
    {
		if (num == 1)
		{
			return 1;
		}
    else
		{
			return num * Factorial(num - 1);
		}
    }
}

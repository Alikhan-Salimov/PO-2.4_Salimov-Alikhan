int number = 5;
int factorial = CalculateFactorial(number);

Console.WriteLine("Task 9: Factorial Method");
Console.WriteLine($"{number}! = {factorial}");

static int CalculateFactorial(int number)
{
    int result = 1;

    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }

    return result;
}

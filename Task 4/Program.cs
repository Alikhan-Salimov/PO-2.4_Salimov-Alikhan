int[] numbers = { 12, 45, 7, 89, 23, 56 };
int[] mixedNumbers = { -5, 12, 0, 7, -3, 18, 24 };

Console.WriteLine("Task 4 - Loops, Methods, Arrays");
Console.WriteLine();

Console.WriteLine($"1. Maximum: {FindMaximum(numbers)}");
Console.WriteLine($"2. Sum: {CalculateSum(numbers)}");
Console.WriteLine($"3. Even numbers: {string.Join(", ", GetEvenNumbers(numbers))}");
Console.WriteLine($"4. Positive numbers count: {CountPositiveNumbers(mixedNumbers)}");
Console.WriteLine($"5. Reversed array: {string.Join(", ", ReverseArray(numbers))}");
Console.WriteLine($"6. Average: {CalculateAverage(numbers):F2}");
Console.WriteLine($"7. Search 23: {(ContainsNumber(numbers, 23) ? "found" : "not found")}");
Console.WriteLine("8. Multiplication table for 7:");
PrintMultiplicationTable(7);
Console.WriteLine($"9. Factorial of 5: {CalculateFactorial(5)}");
Console.WriteLine($"10. Minimum: {FindMinimum(numbers)}, Maximum: {FindMaximum(numbers)}");

static int FindMaximum(int[] values)
{
    int maximum = values[0];

    foreach (int value in values)
    {
        if (value > maximum)
        {
            maximum = value;
        }
    }

    return maximum;
}

static int FindMinimum(int[] values)
{
    int minimum = values[0];

    foreach (int value in values)
    {
        if (value < minimum)
        {
            minimum = value;
        }
    }

    return minimum;
}

static int CalculateSum(int[] values)
{
    int sum = 0;

    foreach (int value in values)
    {
        sum += value;
    }

    return sum;
}

static double CalculateAverage(int[] values)
{
    return (double)CalculateSum(values) / values.Length;
}

static int[] GetEvenNumbers(int[] values)
{
    List<int> result = new();

    foreach (int value in values)
    {
        if (value % 2 == 0)
        {
            result.Add(value);
        }
    }

    return result.ToArray();
}

static int CountPositiveNumbers(int[] values)
{
    int count = 0;

    foreach (int value in values)
    {
        if (value > 0)
        {
            count++;
        }
    }

    return count;
}

static int[] ReverseArray(int[] values)
{
    int[] result = new int[values.Length];

    for (int i = 0; i < values.Length; i++)
    {
        result[i] = values[values.Length - 1 - i];
    }

    return result;
}

static bool ContainsNumber(int[] values, int searchValue)
{
    foreach (int value in values)
    {
        if (value == searchValue)
        {
            return true;
        }
    }

    return false;
}

static void PrintMultiplicationTable(int number)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"   {number} x {i} = {number * i}");
    }
}

static int CalculateFactorial(int number)
{
    int result = 1;

    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }

    return result;
}

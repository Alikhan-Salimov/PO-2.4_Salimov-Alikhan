int[] numbers = { 31, 8, 64, 15, 42, 3 };

Console.WriteLine("Task 10: Min and Max Methods");
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
Console.WriteLine($"Minimum: {FindMinimum(numbers)}");
Console.WriteLine($"Maximum: {FindMaximum(numbers)}");

static int FindMinimum(int[] numbers)
{
    int minimum = numbers[0];

    foreach (int number in numbers)
    {
        if (number < minimum)
        {
            minimum = number;
        }
    }

    return minimum;
}

static int FindMaximum(int[] numbers)
{
    int maximum = numbers[0];

    foreach (int number in numbers)
    {
        if (number > maximum)
        {
            maximum = number;
        }
    }

    return maximum;
}

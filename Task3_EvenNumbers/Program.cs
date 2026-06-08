int[] numbers = { 3, 10, 17, 24, 35, 48, 51 };

Console.WriteLine("Task 3: Even Numbers");
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
Console.Write("Even numbers: ");

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        Console.Write($"{number} ");
    }
}

Console.WriteLine();

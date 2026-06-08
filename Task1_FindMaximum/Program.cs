int[] numbers = { 12, 45, 7, 89, 23, 56 };

int maximum = numbers[0];
foreach (int number in numbers)
{
    if (number > maximum)
    {
        maximum = number;
    }
}

Console.WriteLine("Task 1: Find Maximum");
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
Console.WriteLine($"Maximum number: {maximum}");

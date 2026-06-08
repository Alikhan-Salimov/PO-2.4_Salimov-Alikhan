int[] numbers = { -5, 12, 0, 7, -3, 18, 24 };

int positiveCount = 0;
foreach (int number in numbers)
{
    if (number > 0)
    {
        positiveCount++;
    }
}

Console.WriteLine("Task 4: Count Positive Numbers");
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
Console.WriteLine($"Positive numbers count: {positiveCount}");

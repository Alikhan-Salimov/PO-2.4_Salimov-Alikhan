int[] numbers = { 4, 8, 15, 16, 23, 42 };

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine("Task 2: Sum Array");
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
Console.WriteLine($"Sum: {sum}");

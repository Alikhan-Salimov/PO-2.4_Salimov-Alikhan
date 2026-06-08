int[] numbers = { 9, 12, 15, 18, 21 };

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

double average = (double)sum / numbers.Length;

Console.WriteLine("Task 6: Average Value");
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
Console.WriteLine($"Average: {average}");

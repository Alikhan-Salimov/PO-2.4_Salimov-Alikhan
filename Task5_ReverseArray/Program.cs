int[] numbers = { 1, 2, 3, 4, 5, 6 };

Console.WriteLine("Task 5: Reverse Array");
Console.WriteLine($"Original array: {string.Join(", ", numbers)}");
Console.Write("Reversed array: ");

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine();

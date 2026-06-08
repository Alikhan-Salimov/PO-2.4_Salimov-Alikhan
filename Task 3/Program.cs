int[] numbers = { 1, 2, 3, 4, 5 };
string[] people = { "Tom", "Sam", "Bob" };
int[,] table =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

Console.WriteLine("Task 3 - Arrays");

Console.WriteLine("One-dimensional array:");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}

Console.WriteLine("\n\nString array:");
foreach (string person in people)
{
    Console.WriteLine(person);
}

Console.WriteLine("\nTwo-dimensional array:");
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write($"{table[i, j]} ");
    }

    Console.WriteLine();
}

Console.WriteLine("\nArray after changing value:");
numbers[0] = 10;
Console.WriteLine(string.Join(", ", numbers));

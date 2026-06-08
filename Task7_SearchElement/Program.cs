int[] numbers = { 6, 13, 20, 27, 34, 41 };
int searchValue = 27;
bool found = false;

foreach (int number in numbers)
{
    if (number == searchValue)
    {
        found = true;
        break;
    }
}

Console.WriteLine("Task 7: Search Element");
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
Console.WriteLine(found
    ? $"Element {searchValue} was found."
    : $"Element {searchValue} was not found.");

Console.WriteLine("Exercise 1:");
CompareTwoNumbers(15, 10);

Console.WriteLine("\nExercise 2:");
CheckNumberBetweenFiveAndTen(7);

Console.WriteLine("\nExercise 3:");
CheckNumberIsFiveOrTen(10);

Console.WriteLine("\nExercise 4:");
CalculateDepositWithInterest(150);

Console.WriteLine("\nExercise 5:");
CalculateDepositWithInterestAndBonus(150);

Console.WriteLine("\nExercise 6:");
ShowOperationName(2);

Console.WriteLine("\nExercise 7:");
CalculateSelectedOperation(3, 8, 4);

static void CompareTwoNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber)
    {
        Console.WriteLine("The numbers are equal.");
    }
    else if (firstNumber > secondNumber)
    {
        Console.WriteLine("The first number is greater than the second.");
    }
    else
    {
        Console.WriteLine("The first number is less than the second.");
    }
}

static void CheckNumberBetweenFiveAndTen(int number)
{
    if (number > 5 && number < 10)
    {
        Console.WriteLine("The number is greater than 5 and less than 10.");
    }
    else
    {
        Console.WriteLine("Unknown number.");
    }
}

static void CheckNumberIsFiveOrTen(int number)
{
    if (number == 5 || number == 10)
    {
        Console.WriteLine("The number is either 5 or 10.");
    }
    else
    {
        Console.WriteLine("Unknown number.");
    }
}

static void CalculateDepositWithInterest(double amount)
{
    double percent;

    if (amount < 100)
    {
        percent = 5;
    }
    else if (amount <= 200)
    {
        percent = 7;
    }
    else
    {
        percent = 10;
    }

    double result = amount + amount * percent / 100;
    Console.WriteLine($"Deposit with interest: {result}");
}

static void CalculateDepositWithInterestAndBonus(double amount)
{
    double percent;

    if (amount < 100)
    {
        percent = 5;
    }
    else if (amount <= 200)
    {
        percent = 7;
    }
    else
    {
        percent = 10;
    }

    double result = amount + amount * percent / 100 + 15;
    Console.WriteLine($"Deposit with interest and bonus: {result}");
}

static void ShowOperationName(int operation)
{
    switch (operation)
    {
        case 1:
            Console.WriteLine("Addition");
            break;
        case 2:
            Console.WriteLine("Subtraction");
            break;
        case 3:
            Console.WriteLine("Multiplication");
            break;
        default:
            Console.WriteLine("The operation is undefined.");
            break;
    }
}

static void CalculateSelectedOperation(int operation, double firstNumber, double secondNumber)
{
    switch (operation)
    {
        case 1:
            Console.WriteLine(firstNumber + secondNumber);
            break;
        case 2:
            Console.WriteLine(firstNumber - secondNumber);
            break;
        case 3:
            Console.WriteLine(firstNumber * secondNumber);
            break;
        default:
            Console.WriteLine("The operation is undefined.");
            break;
    }
}

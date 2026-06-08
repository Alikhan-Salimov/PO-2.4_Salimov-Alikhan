Console.WriteLine("Task 1 - C# Data Types Practice");
Console.WriteLine("Choose one mini system:");
Console.WriteLine("1 - Online Store Order");
Console.WriteLine("2 - Cinema Ticket");
Console.WriteLine("3 - Gym Membership");
Console.Write("Choose: ");

int choice = int.Parse(Console.ReadLine() ?? "1");

switch (choice)
{
    case 1:
        RunOnlineStoreOrder();
        break;
    case 2:
        RunCinemaTicket();
        break;
    case 3:
        RunGymMembership();
        break;
    default:
        Console.WriteLine("Unknown option.");
        break;
}

static void RunOnlineStoreOrder()
{
    Console.Write("Product name: ");
    string productName = Console.ReadLine() ?? "";

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("Price per item: ");
    double pricePerItem = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Discount percentage: ");
    double discountPercentage = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Delivery distance in km: ");
    double deliveryDistance = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("First letter of payment method: ");
    char paymentMethod = char.Parse(Console.ReadLine() ?? "C");

    Console.Write("Is express delivery true/false: ");
    bool isExpressDelivery = bool.Parse(Console.ReadLine() ?? "false");

    double totalPrice = quantity * pricePerItem;
    double discountAmount = totalPrice * discountPercentage / 100;
    double finalPrice = totalPrice - discountAmount;

    Console.WriteLine($"Product: {productName}");
    Console.WriteLine($"Quantity: {quantity}");
    Console.WriteLine($"Price per item: {pricePerItem}");
    Console.WriteLine($"Discount: {discountPercentage}%");
    Console.WriteLine($"Delivery distance: {deliveryDistance} km");
    Console.WriteLine($"Payment method letter: {paymentMethod}");
    Console.WriteLine($"Express delivery: {isExpressDelivery}");
    Console.WriteLine($"Total price: {totalPrice}");
    Console.WriteLine($"Discount amount: {discountAmount}");
    Console.WriteLine($"Final price: {finalPrice}");
    Console.WriteLine($"Type examples: {productName.GetType()}, {quantity.GetType()}, {isExpressDelivery.GetType()}");
}

static void RunCinemaTicket()
{
    Console.Write("Movie title: ");
    string movieTitle = Console.ReadLine() ?? "";

    Console.Write("Number of tickets: ");
    int numberOfTickets = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("Price per ticket: ");
    double pricePerTicket = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Duration in hours: ");
    double durationHours = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Screen number: ");
    int screenNumber = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("First letter of seat row: ");
    char seatRow = char.Parse(Console.ReadLine() ?? "A");

    Console.Write("Is 3D movie true/false: ");
    bool is3D = bool.Parse(Console.ReadLine() ?? "false");

    double totalCost = numberOfTickets * pricePerTicket;
    double costPerHour = totalCost / durationHours;

    Console.WriteLine($"Movie: {movieTitle}");
    Console.WriteLine($"Tickets: {numberOfTickets}");
    Console.WriteLine($"Price per ticket: {pricePerTicket}");
    Console.WriteLine($"Duration: {durationHours}");
    Console.WriteLine($"Screen: {screenNumber}");
    Console.WriteLine($"Seat row: {seatRow}");
    Console.WriteLine($"3D: {is3D}");
    Console.WriteLine($"Total ticket cost: {totalCost}");
    Console.WriteLine($"Cost per hour: {costPerHour}");
    Console.WriteLine($"Type examples: {movieTitle.GetType()}, {numberOfTickets.GetType()}, {is3D.GetType()}");
}

static void RunGymMembership()
{
    Console.Write("Membership type: ");
    string membershipType = Console.ReadLine() ?? "";

    Console.Write("Number of months: ");
    int numberOfMonths = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("Monthly fee: ");
    double monthlyFee = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Personal trainer fee: ");
    double trainerFee = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Height in meters: ");
    double height = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("First letter of trainer name: ");
    char trainerLetter = char.Parse(Console.ReadLine() ?? "A");

    Console.Write("Is premium access true/false: ");
    bool isPremiumAccess = bool.Parse(Console.ReadLine() ?? "false");

    double totalMembershipCost = numberOfMonths * monthlyFee;
    double totalWithTrainer = totalMembershipCost + trainerFee;

    Console.WriteLine($"Membership type: {membershipType}");
    Console.WriteLine($"Months: {numberOfMonths}");
    Console.WriteLine($"Monthly fee: {monthlyFee}");
    Console.WriteLine($"Trainer fee: {trainerFee}");
    Console.WriteLine($"Height: {height}");
    Console.WriteLine($"Trainer letter: {trainerLetter}");
    Console.WriteLine($"Premium access: {isPremiumAccess}");
    Console.WriteLine($"Total membership cost: {totalMembershipCost}");
    Console.WriteLine($"Total including trainer: {totalWithTrainer}");
    Console.WriteLine($"Type examples: {membershipType.GetType()}, {numberOfMonths.GetType()}, {isPremiumAccess.GetType()}");
}

Registry registry = new();

registry.Add(new Student("Aisha Bekova", 3.9, "Computer Science"));
registry.Add(new Student("Daniyar Seitkali", 3.4, "Mathematics"));
registry.Add(new Student("Zarina Mukhanova", 3.7, "Physics"));

while (true)
{
    PrintMenu();

    switch (Console.ReadLine())
    {
        case "1":
            AddStudent();
            break;
        case "2":
            FindById();
            break;
        case "3":
            FindByName();
            break;
        case "4":
            ShowTopStudents();
            break;
        case "5":
            registry.PrintAll();
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
}

void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("Task 5 - Student Registry System");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Find by ID");
    Console.WriteLine("3. Find by Name");
    Console.WriteLine("4. Top N Students");
    Console.WriteLine("5. Print All");
    Console.WriteLine("6. Exit");
    Console.Write("Choose: ");
}

void AddStudent()
{
    Console.Write("Name: ");
    string name = Console.ReadLine() ?? "";

    Console.Write("GPA: ");
    double.TryParse(Console.ReadLine(), out double gpa);

    Console.Write("Faculty: ");
    string faculty = Console.ReadLine() ?? "";

    try
    {
        Student student = new(name, gpa, faculty);

        if (registry.Add(student))
        {
            Console.WriteLine($"Added: {student}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

void FindById()
{
    Console.Write("ID: ");
    int.TryParse(Console.ReadLine(), out int id);

    Student? student = registry.FindById(id);
    Console.WriteLine(student != null ? student : "Not found.");
}

void FindByName()
{
    Console.Write("Name: ");
    string name = Console.ReadLine() ?? "";

    Student[] students = registry.FindByName(name);

    if (students.Length == 0)
    {
        Console.WriteLine("Not found.");
        return;
    }

    foreach (Student student in students)
    {
        Console.WriteLine(student);
    }
}

void ShowTopStudents()
{
    Console.Write("How many students: ");
    int.TryParse(Console.ReadLine(), out int count);

    foreach (Student student in registry.GetTopStudents(count))
    {
        Console.WriteLine(student);
    }
}

class Student
{
    private static int nextId = 1;
    private double gpa;

    public Student(string name, double gpa, string faculty)
    {
        StudentId = nextId++;
        Name = name;
        GPA = gpa;
        Faculty = faculty;
    }

    public int StudentId { get; }

    public string Name { get; set; }

    public string Faculty { get; set; }

    public double GPA
    {
        get => gpa;
        set
        {
            if (value < 0.0 || value > 4.0)
            {
                throw new ArgumentOutOfRangeException(nameof(GPA), "GPA must be between 0.0 and 4.0.");
            }

            gpa = value;
        }
    }

    public override string ToString()
    {
        return $"[{StudentId}] {Name} | GPA: {GPA:F2} | Faculty: {Faculty}";
    }
}

class Registry
{
    private const int MaxStudents = 100;
    private readonly Student[] students = new Student[MaxStudents];
    private int count;

    public bool Add(Student student)
    {
        if (count >= MaxStudents)
        {
            Console.WriteLine("Registry is full.");
            return false;
        }

        students[count] = student;
        count++;
        return true;
    }

    public Student? FindById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
            {
                return students[i];
            }
        }

        return null;
    }

    public Student[] FindByName(string name)
    {
        List<Student> result = new();

        for (int i = 0; i < count; i++)
        {
            if (students[i].Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(students[i]);
            }
        }

        return result.ToArray();
    }

    public Student[] GetTopStudents(int topCount)
    {
        Student[] result = new Student[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = students[i];
        }

        Array.Sort(result, (first, second) => second.GPA.CompareTo(first.GPA));

        if (topCount > result.Length)
        {
            topCount = result.Length;
        }

        Student[] topStudents = new Student[topCount];
        Array.Copy(result, topStudents, topCount);
        return topStudents;
    }

    public void PrintAll()
    {
        if (count == 0)
        {
            Console.WriteLine("No students in the registry.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(students[i]);
        }
    }
}

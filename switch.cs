using System.Diagnostics;

Console.Write("Enter your marks:");

int marks = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your marks are: " + marks);

switch (marks)
{
    case >= 95:
        Console.WriteLine("You have an A+");
        break;
    
    case >= 70:
        Console.WriteLine("You have an A");
        break;

    case >= 60:
        Console.WriteLine("You have a B");
        break;

    case >= 50:
        Console.WriteLine("You have a C");
        break;

    case >= 40:
        Console.WriteLine("You have a D");
        break;

    default:
        Console.WriteLine("You have an E");
        break;
}
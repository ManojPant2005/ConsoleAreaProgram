
class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a structure:");
        Console.WriteLine("1. Square");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Triangle");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice (1-4): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SquareArea();
                break;
            case "2":
                RectangleArea();
                break;
            case "3":
                TriangleArea();
                break;
            case "4":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                break;

        }
    }
    static void SquareArea()
    {
        Console.Write("Enter the side length of the square: ");
        if (double.TryParse(Console.ReadLine(), out double sideLength))
        {
            double area = sideLength * sideLength;
            Console.WriteLine($"The area of the square is: {area}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    static void RectangleArea()
    {
        Console.Write("Enter the length of the rectangle: ");
        if (double.TryParse(Console.ReadLine(), out double length))
        {
            Console.Write("Enter the width of the rectangle: ");
            if (double.TryParse(Console.ReadLine(), out double width))
            {
                double area = length * width;
                Console.WriteLine($"The area of the rectangle is: {area}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for width.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for length.");
        }
    }

    static void TriangleArea()
    {
        Console.Write("Enter the base length of the triangle: ");
        if (double.TryParse(Console.ReadLine(), out double baseLength))
        {
            Console.Write("Enter the height of the triangle: ");
            if (double.TryParse(Console.ReadLine(), out double height))
            {
                double area = 0.5 * baseLength * height;
                Console.WriteLine($"The area of the triangle is: {area}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for height.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for base length.");
        }
    }
}

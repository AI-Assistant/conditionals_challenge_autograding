// YOUR NAME
// YOUR CLASS
// 



/// <summary>
/// What do you need to Know
/// </summary>


Task_4.Task4();

public static class Task_4
{
    public static void Task4()
    {
        Console.WriteLine("Calculator\n");

        Console.WriteLine("Enter the first value:");
        double value_1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second value:");
        double value_2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1 Addition");
        Console.WriteLine("2 Subtraction");
        Console.WriteLine("3 Multiplication");
        Console.WriteLine("4 Divison");
        Console.WriteLine("5 Potency");
        Console.WriteLine("Your choice:");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine($"Your result is: {value_1+value_2}");
                break;
            case "2":
                Console.WriteLine($"Your result is: {value_1 - value_2}");
                break;
            case "3":
                Console.WriteLine($"Your result is: {value_1 * value_2}");
                break;
            case "4":
                Console.WriteLine($"Your result is: {value_1 / value_2}");
                break;
            case "5":
                Console.WriteLine($"Your result is: {Math.Pow(value_1,value_2)}");
                break;
            default:
                Console.WriteLine("Wrong selection!");
                break;


        }


    }
}


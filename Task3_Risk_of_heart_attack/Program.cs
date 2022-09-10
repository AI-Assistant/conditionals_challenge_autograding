// YOUR NAME
// YOUR CLASS
// 



/// <summary>
/// What do you need to Know
/// </summary>


Task_3.Task3();

public static class Task_3
{
    public static void Task3()
    {
        Console.WriteLine("Risk Of Heart Attack\n");

        Console.WriteLine("Are you overweight?(true/false):");

        bool value_1 = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Do you have stress?(true/false):");
        bool value_2 = Convert.ToBoolean(Console.ReadLine());

        if (value_1 & value_2)
            Console.WriteLine($"Your risk of heart attack is about: 62%");
        else if (value_1 & !value_2)
            Console.WriteLine($"Your risk of heart attack is about: 18%");
        else if (!value_1 & value_2)
            Console.WriteLine($"Your risk of heart attack is about: 15%");
        else if (!value_1 & !value_2)
            Console.WriteLine($"Your risk of heart attack is about: 5%");


    }
}


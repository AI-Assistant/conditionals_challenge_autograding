// YOUR NAME
// YOUR CLASS
// 



/// <summary>
/// 
/// </summary>


Task_2.Task2();

public static class Task_2
{
    public static void Task2()
    {
        Console.WriteLine("Get Minimum Number\n");

        Console.WriteLine("Enter the first value:");

        double value_1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the second value:");
        double value_2 = Convert.ToDouble(Console.ReadLine());

        if (value_1 < value_2)
            Console.WriteLine($"The smaler value is: {value_1}");
        else if (value_1 == value_2)
            Console.WriteLine("The smaler value is: Same value");
        else
            Console.WriteLine($"The smaler value is: {value_2}");

    }
}


// YOUR NAME
// YOUR CLASS
// 



/// <summary>
/// 
/// </summary>


Task_1.Task1();

public static class Task_1
{
    public static void Task1()
    {

        Console.WriteLine("Calculate Trip Duration\n");

        Console.WriteLine("Enter the starting location: ");
        string starting_location = Console.ReadLine();

        Console.WriteLine("Enter the ending location: ");
        string ending_location = Console.ReadLine();

        Console.WriteLine("Enter the distance between the location: ");
        double distance = Convert.ToDouble(Console.ReadLine());

        double duration = distance / 60;


        Console.WriteLine("\nDetails");
        Console.WriteLine("{0,-10}{1}", "Start:", starting_location);
        Console.WriteLine("{0,-10}{1}", "End:", ending_location);
        Console.WriteLine("{0,-10}{1:F2} [km]", "Distance:", distance);
        Console.WriteLine("{0,-10}{1:F2} [h]", "Duration:", duration);

    }
}


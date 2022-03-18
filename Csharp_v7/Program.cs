public class Program
{
    public static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        //Console.WriteLine("Hello, World!");


        (string, string) str = ("text 01", "text 02");
        Console.WriteLine(string.Format("{0},{1}", str.Item1, str.Item2));
        Console.WriteLine(str.Item1.GetType()); //str 

        Console.WriteLine("----------------------------------------------");

        (int No, string Name) student = (1, str.Item1);
        Console.WriteLine($"{student.No}_{student.Name}");

        Console.WriteLine("----------------------------------------------");

        var student2 = (No: "2", Name: "Zhangsan");
        var student3 = new { No = "3", Name = "Lisi" };
        Console.WriteLine(string.Format("{0}", student2));

        Console.WriteLine("----------------------------------------------");

        int count = 5;
        string label = "Colors used in the map";
        var pair = (count, label);
        Console.WriteLine(pair);

        Console.WriteLine("----------------------------------------------");

        var fields = student2.GetType().GetFields();
        foreach (var field in fields)
            Console.Write($"{field.Name} ");
        Console.WriteLine("");

        Console.WriteLine("----------------------------------------------");

        var xs = new[] { 4, 7, 9 };
        var limits = FindMinMax(xs);
        Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("-----------------------析构-----------------------");

        var t = ("post office", 3.6);
        (string destination, double distance) = t;
        Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

        Console.WriteLine("----------------------------------------------");
        var (destination1, distance1) = t;
        Console.WriteLine($"Distance to {destination1} is {distance1} kilometers.");

        Console.WriteLine("----------------------------------------------");
        var (min, _) = FindMinMax(new[] {1,2,3});
        Console.WriteLine($"min is {min}");

    }

    static (int min, int max) FindMinMax(int[] input)
    {
        if (input is null || input.Length == 0)
        {
            throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
        }

        var min = int.MaxValue;
        var max = int.MinValue;
        foreach (var i in input)
        {
            if (i < min)
            {
                min = i;
            }
            if (i > max)
            {
                max = i;
            }
        }
        return (min, max);
    }


}
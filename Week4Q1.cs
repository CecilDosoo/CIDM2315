namespace week4homework;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two integers: ");
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"a = {a}; b = {b}");

        if (a > b)
        {
            Console.WriteLine($"The Largest number is: {a}");
        }
        else
        {
            Console.WriteLine($"The Largest number is: {b}");
        }

    }


}

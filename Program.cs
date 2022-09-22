namespace week4homework2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        int n = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter a shape: ");
        string shape = Console.ReadLine();

        Console.WriteLine($"N is: {n}; shape is {shape}");


        if(shape == "left")
        {
            for(int row = 0; row<n; row++)
            {
                for(int col = 0; col<n; col++)
                {
                if(row>=col)
                Console.Write('*');
                }
                Console.WriteLine("");
            }
        }
        if(shape == "right")
        {
    
        int a, b, c;
        for (a = 1; a <= n; a++)
        {
            for (b = 1; b <= n - a; b++)
            {
                Console.Write(" ");
            }
            for (c = 1; c <= a; c++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        } 
        }
    }
}



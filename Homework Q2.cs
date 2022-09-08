namespace Homework3;
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Please input the first num: ");
        int n1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num: ");
        int n2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num: ");
        int n3 = Convert.ToInt16(Console.ReadLine());

        if (n1 < n2){
            if (n1 < n3){
                Console.WriteLine($"The smallest number is {n1}");
                }
            else{
                Console.WriteLine($"The smallest number is {n3}");
                }}
        else{
            if (n2 < n3){
                Console.WriteLine($"The smallest number is {n2}");
            }
        else{
            Console.WriteLine($"The smallest number is {n3}");
        }
        }
}
}


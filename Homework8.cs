namespace Homework8;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {   
        int [] int_array = {11,23,31,42,53};
        MaxMinSum(int_array);

        int [,] array_2d = {
            {1,2,3}, 
            {4,5,6}, 
            {7,8,9}
            };
        
        PrintAllOddNumber(array_2d);
        Console.WriteLine("Q2: The sum of array elements:");
        ElementSum(array_2d);
        DoubleArray(array_2d);
    }

    static void MaxMinSum(int [] int_arr){
        Console.WriteLine($"The sum of int_array is: {int_arr.Sum()}");
    }
    static void PrintAllOddNumber(int [,]array_2d){
        Console.WriteLine("Q1: Print all odd numbers:");
        foreach(int n in array_2d){
            if(n%2!=0){
                Console.Write(n + " ");
            }
        }
    }
    static void ElementSum(int[,] array_2d){
        int total = 0;
        foreach(int n in array_2d){
            total += n;
        Console.WriteLine(total);
        }
        
    }
    static void DoubleArray(int[,] array_2d){
        Console.WriteLine("Q3: The new 2d array: ");
        foreach(int n in array_2d){
            Console.Write(n*2 + " ");
        }
    }
}

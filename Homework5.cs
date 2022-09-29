namespace Homework5Q1;
class Program
{

// Q1
//  static void Main(string[] args)
//     {
//         Console.WriteLine("Type two integers: ");
//         int a = Convert.ToInt16(Console.ReadLine());
//         int b = Convert.ToInt16(Console.ReadLine());
//         Console.WriteLine($"a = {a}; b = {b}");
//         Largest(a,b);
//     }

//     static void Largest(int a, int b){
//         if(a > b){
//             Console.WriteLine($"The largest number is: {a}");
//         }

//         else{
//             Console.WriteLine($"The largest number is: {b}");
//         }
//     }

// Q2
// static void Main(string[] args)
//     {
//         Console.WriteLine("Type four integers: ");
//         int a = Convert.ToInt16(Console.ReadLine());
//         int b = Convert.ToInt16(Console.ReadLine());
//         int c = Convert.ToInt16(Console.ReadLine());
//         int d = Convert.ToInt16(Console.ReadLine());
//         Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}");
        
//         int max1 = Largest(a,b);
//         int max2 = Largest(c,d);

//         if(max1>max2){
//             Console.WriteLine($"The largest number is: {max1}");
//         }
//         else{
//             Console.WriteLine($"The largest number is: {max2}");
//         }

//     }

//     static int Largest(int a, int b){
//         if(a > b){
//             return a;
//         }
//         else{
//             return b;
//         }

//     }


    // Q3
    static void Main(string[] args)
    {
        CreateAccount();
    }

    static bool checkAge(int birth_year){
        int age = 2022-birth_year;
        if (age >= 18){
            return true;
        }
        else{
            return false;
        }
    }
    static void CreateAccount(){
        Console.WriteLine("Enter Your Username: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Your Password: ");
        string password1 = Console.ReadLine();
        Console.WriteLine("Enter Your Password again: ");
        string password2 = Console.ReadLine();
        Console.WriteLine("Enter Your Birth Year: ");
        int byear = Convert.ToInt16(Console.ReadLine());

        bool age = checkAge(byear);

        if(age == true){
            if(password1 == password2){
                Console.WriteLine("Account is created successfully");
            }

            else{
                Console.WriteLine("Wrong Password");
            }
        }
        else{
            Console.WriteLine("Could not create account");
        }
    }   

    
}


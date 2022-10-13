namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Professor Alice = new Professor();
        Alice.profName = "Alice";
        Alice.classTeach = "Java";
        Alice.SetSalary(9000);
        Console.WriteLine("Professor " + Alice.profName + " teaches " + Alice.classTeach + ", and the salary is: " + Alice.GetSalary());

        Professor Bob = new Professor();
        Bob.profName = "Bob";
        Bob.classTeach = "Math";
        Bob.SetSalary(8000);
        Console.WriteLine("Professor " + Bob.profName + " teaches " + Bob.classTeach + ", and the salary is: " + Bob.GetSalary());

        double salary_diff = Alice.GetSalary() - Bob.GetSalary();

        Student Lisa = new Student();
        Lisa.StudentName = "Lisa";
        Lisa.classEnroll = "Java";
        Lisa.SetGrade(90);
        Console.WriteLine("Student " + Lisa.StudentName + " enrolls " + Lisa.classEnroll + ", and the grade is: " + Lisa.GetGrade());

        Student Tom = new Student();
        Tom.StudentName = "Tom";
        Tom.classEnroll = "Math";
        Tom.SetGrade(80);
        Console.WriteLine("Student " + Tom.StudentName + " enrolls " + Tom.classEnroll + ", and the grade is: " + Tom.GetGrade());
        
        double total_grade = Lisa.GetGrade() + Tom.GetGrade();

        Console.WriteLine("The salary difference between " + Alice.profName + " and " + Bob.profName + " is: " + salary_diff);
        Console.WriteLine("The total grade of " + Lisa.StudentName + " and " + Tom.StudentName + " is: " + total_grade);

    }
}

// class Professor{
//     public string profName;
//     public string classTeach;
//     private double salary;
//     public void SetSalary(double salary_amount){
//         salary = salary_amount;
//     }
//     public double GetSalary(){
//         return salary;
//     }
// }

// class Student{
//     public string StudentName;
//     public string classEnroll;
//     private double studentGrade;
//     public void SetGrade(double newGrade){
//         studentGrade = newGrade;
//     }
//     public double GetGrade(){
//         return studentGrade;
//     }
// }
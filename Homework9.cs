namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        Student stu1 = new Student(111,"Alice");
        Student stu2 = new Student(222,"Bob");
        Student stu3 = new Student(333,"Cathy");
        Student stu4 = new Student(444,"David");

        Dictionary<string,double> gradebook = new Dictionary<string,double>();
        gradebook.Add("Alice",4.0);
        gradebook.Add("Bob",3.6);
        gradebook.Add("Cathy",2.5);
        gradebook.Add("David",1.8);

        foreach(var stu in gradebook){
            if(stu.Key != "Tom"){
                gradebook.Add("Tom",3.3);
            }
        }
        int total_students = gradebook.Count();
        double total = 0;
        foreach(var stu in gradebook){
            total += stu.Value;
        }
        double average = total/total_students;
        Console.WriteLine(average);

        foreach(var stu in gradebook){
            if(stu.Value > average){
                stu.PrintInfo();
            }
        }
    }
}


// class Student{
//     private int StudentID;
//     private string StudentName;
//     public void PrintInfo(){
//         Console.WriteLine($"Student ID: {StudentID}, Name: {StudentName}");
//     }
//     public static List<Student> student_list = new List<Student>();
//     public Student(int id, string name){
//         StudentID = id;
//         StudentName = name;
//         student_list.Add(this);
//     }
// }
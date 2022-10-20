namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        Customer cust1 = new Customer(cus_id:110, cus_name: "Alice", cus_age: 28);
        Customer cust2 = new Customer(cus_id:111, cus_name: "Bob", cus_age: 30);

        cust1.PrintCusInfo();
        cust2.PrintCusInfo();

        cust1.ChangeID(220);
        cust2.ChangeID(221);

        cust1.PrintCusInfo();
        cust2.PrintCusInfo();

        cust1.CompareAge(cust2);


    }
}

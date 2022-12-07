namespace FinalProject;
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("----- CIDM2315 Final Project: Cecil Dosoo -----");
        Console.WriteLine("----- Welcome to Buff Kitchen -----");

        string username = "Cecil";
        int password = 123;

        Console.WriteLine("Please input username: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please input password: ");
        int pass = Convert.ToInt32(Console.ReadLine());
        
        Dictionary <string, double> foods = new Dictionary<string, double>();
        foods.Add("Chicken Sandwhich",5.99);
        foods.Add("Chicken Nuggets",8.99);
        foods.Add("Chicken Strips",9.99);
        foods.Add("Beef Burger",6.99);

        Dictionary <string, double> drinks = new Dictionary<string, double>();
        drinks.Add("Iced Tea", 2.99);
        drinks.Add("Soda", 1.99);
        drinks.Add("Lemonade", 2.99);
        drinks.Add("Coffee", 3.99);

        Dictionary <string, double> sides = new Dictionary<string, double>();
        sides.Add("Potato Fries", 3.99);
        sides.Add("Salad", 4.99);
        sides.Add("Fruit Cup", 9.99);
        sides.Add("Potato Chips", 2.99);

        Dictionary <string, int> orders = new Dictionary<string, int>();
        Dictionary <string, double> food_total = new Dictionary<string, double>();

        bool game = true;
        while(game){
            if((username == name)&&(password == pass)){
            Console.WriteLine("Login Successfully.");
            Console.WriteLine($"** Hello Cashier: {username} **");
            Menu();
            int option = Convert.ToInt16(Console.ReadLine());
            if(option == 1){
                Console.WriteLine("--> Customer Name: ");
                string orderName = Console.ReadLine();
                orders.Add(orderName,1);
                Console.WriteLine("--> Select Entree:");
                int num = 0;
                foreach(var food in foods){
                    Console.WriteLine($"{num} - Food: {food.Key}    Price: {food.Value} ");
                    num++;
                }
                int entree_option = Convert.ToInt32(Console.ReadLine());
                string entree_name = foods.ElementAt(entree_option).Key;
                double entree_price = foods.ElementAt(entree_option).Value;

                Console.WriteLine("--> Select Drink:");
                int num1 = 0;
                foreach(var drink in drinks){
                    Console.WriteLine($"{num1} - Drink: {drink.Key}    Price: {drink.Value} ");
                    num1++;
                }
                int drink_option = Convert.ToInt32(Console.ReadLine());
                string drink_name = drinks.ElementAt(drink_option).Key;
                double drink_price = drinks.ElementAt(drink_option).Value;

                Console.WriteLine("--> Select Side:");
                int num2 = 0;
                foreach(var side in sides){
                    Console.WriteLine($"{num2} - Side: {side.Key}    Price: {side.Value} ");
                    num2++;
                }
                int side_option = Convert.ToInt32(Console.ReadLine());
                string side_name = sides.ElementAt(side_option).Key;
                double side_price = sides.ElementAt(side_option).Value;

                // order summary with total
                double total = (entree_price + drink_price + side_price);
                food_total.Add(orderName, total);
                Console.WriteLine("----- Order Summary -----");
                Console.WriteLine($"Food: {entree_name}    Price: {entree_price}");
                Console.WriteLine($"Drink: {drink_name}    Price: {drink_price}");
                Console.WriteLine($"Side: {side_name}      Price: {side_price}");
                Console.WriteLine($"----- Total: {food_total[orderName]} -----");
            }
            if(option == 2){
                int num3 = 0;
                Console.WriteLine($"----- Number of orders: {orders.Count()} -----");
                foreach(var order in orders){
                    Console.WriteLine($" -> {num3} - Customer: {order.Key}    Total: {food_total[order.Key]} ");
                    num3++;
                }
            }

            if(option == 3){
                int num4 = 0;
                Console.WriteLine($"----- Number of orders: {orders.Count()} -----");
                foreach(var order in orders){
                    Console.WriteLine($" -> {num4} - Customer: {order.Key}    Total: {food_total[order.Key]} ");
                    num4++;
                }
                Console.WriteLine("-------------------------");
                Console.WriteLine("----- Input order ID to remove a finished order: ------");
                int order_num = Convert.ToInt32(Console.ReadLine());

                // Code to remove order number chosen
                string chosen_order = orders.ElementAt(order_num).Key;
                orders.Remove(chosen_order);

                int num5 = 0;
                Console.WriteLine($"----- Number of orders: {orders.Count()} -----");
                foreach(var order in orders){
                    Console.WriteLine($" -> {num5} - Customer: {order.Key}    Total: {food_total[order.Key]} ");
                    num5++;
                }
                Console.WriteLine("-------------------------");
            } 

            if(option == 4){
                Console.WriteLine("-> Log out system");
                game = false;
            }
            }   
        else if((username == name)&&(password != pass)){
            Console.WriteLine("Wrong Password.");
            game = false;
        }
        else{
            Console.WriteLine("Wrong Username.");
            game = false;
        }
        }     
    }

    static void Menu(){
        Console.WriteLine("**********************");
        Console.WriteLine("Please select: ");
        Console.WriteLine("1. Start new order");
        Console.WriteLine("2. Check submitted orders");
        Console.WriteLine("3. Remove Finished orders");
        Console.WriteLine("4. Log out System");
        Console.WriteLine("**********************");
    }

    static void newOrder(){
        Console.WriteLine("--> Customer Name: ");
        string name = Console.ReadLine();
    }
}

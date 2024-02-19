using System;

namespace Assignment2
{
    class Program
    {
        static List<(string itemName, double price)> orders = new List<(string, double)>();

        static void Main(string[] args)
        {
            Console.WriteLine("Ordering Application");

            bool exit = false;

            while (!exit)
            {
                
                Console.WriteLine("\n1. Add Item to Order");
                Console.WriteLine("2. View Order Summary");
                Console.WriteLine("3. Place Order");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItemToOrder();
                        break;
                    case "2":
                        ViewOrderSummary();
                        break;
                    case "3":
                        PlaceOrder();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddItemToOrder()
        {
            Console.Write("\nEnter item name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            orders.Add((itemName, price));

            Console.WriteLine("Item added to order.");
        }

        static void ViewOrderSummary()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("\nNo items in the order.");
                return;
            }

            Console.WriteLine("\nOrder Summary:");
            foreach (var order in orders)
            {
                Console.WriteLine($"\nItem: {order.itemName}");
                Console.WriteLine($"Price: {order.price}"); 
            }
        }

        static void PlaceOrder()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("\nNo items to place order.");
                return;
            }

            double totalPrice = 0;
            foreach (var order in orders)
            {
                totalPrice += order.price;
            }

            Console.WriteLine($"\nTotal Price of Order: {totalPrice}");

            orders.Clear();

            Console.WriteLine("Order placed successfully!");
        }
    }
}

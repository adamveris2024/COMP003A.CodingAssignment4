// Author: Adam Verissimo
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = new string[10];
            int[] amounts = new int[10];
            int choice = 0;
            int count = 0;
            string productName = "";
            int productAmount = 0;

            // Menu
            while (true)
            {
                Console.WriteLine("Inventory Management System Menu:");
                Console.WriteLine("1. Add a Product:");
                Console.WriteLine("2. Update Product Quantity:");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    // 1. Add a product:
                    case 1:
                        if (count < products.Length)
                        {
                            Console.Write("Enter product name: ");
                            productName = Console.ReadLine();
                            Console.Write("Enter product quantity: ");
                            productAmount = int.Parse(Console.ReadLine());
                            Console.WriteLine("Product added successfully!\n");
                            products[count] = productName;
                            amounts[count] = productAmount;
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("All slots are full.");
                        }
                        break;
                    // 2. Update product quantity:
                    case 2:
                        Console.WriteLine("Enter product name of quantity you want to change: ");
                        productName = Console.ReadLine();
                        int productIndex = Array.IndexOf(products, productName);

                        if (productIndex != -1)
                        {
                            Console.WriteLine("Enter new quantity: ");
                            amounts[productIndex] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Quantity updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Product could not be found. Please try again.");
                        }
                        break;
                    // 3. View inventory summary:
                    case 3:
                        Console.WriteLine("\nInventory Summary:");
                        int quantity = 0;

                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"- {products[i]}: {amounts[i]}");
                            quantity += amounts[i];
                        }

                        Console.WriteLine($"Total Products: {count}");
                        Console.WriteLine($"Total Quantity: {quantity}");
                        Console.WriteLine($"Average Quantity: {(count > 0 ? (double)quantity / count : 0):F2}\n");
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                }
                // 4. Exit
                if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}

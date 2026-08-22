using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_POS
{
    internal class Program
    {
        static string[] items =
        {
            "Burger",
            "Fries",
            "Soda",
            "Salad",
            "Pizza",
            "Ice Cream",
            "Coffee",
            "Tea",
            "Water",
            "Juice "
        };

        static decimal[] prices =
        {
            59,
            60,
            25,
            70,
            15,
            20,
            40,
            40,
            7,
            25
        };


        // Cart to hold selected items
        static string[] cartItems = new string[100];
        static decimal[] cartQuantities = new decimal[100];


        static void Main(string[] args)
        {
            while (true)
            {
                int option = DisplayMenu();

                switch (option)
                {
                    case 1:
                        // Add Item
                        AddItemToCart();
                        break;

                    case 2:
                        // Remove Item
                        RemoveItemFromCart();
                        break;

                    case 3:
                        // View Cart
                        ViewCart();
                        break;

                    case 4:
                        // Checkout
                        Checkout();
                        break;

                    case 5:
                        // Exit
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }


            }
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("    Welcome to the POS System  ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("[1] Add Item");
            Console.WriteLine("[2] Remove Item");
            Console.WriteLine("[3] View Cart");
            Console.WriteLine("[4] Checkout");
            Console.WriteLine("[5] Exit");
            Console.WriteLine("==============================");
            Console.Write("Please select an option: ");

            int option;
            int.TryParse(Console.ReadLine(), out option);
            return option;
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("            MENU");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($" [{i + 1}] {items[i],-15} P{prices[i]}");

            Console.WriteLine("-------------------------------");
        }
    }
}
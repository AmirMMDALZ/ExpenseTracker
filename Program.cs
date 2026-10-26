using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    class Program
    {
        static bool AddExpense(List<Expense> expenses)
        {
            Console.WriteLine("Please enter a description:");
            string desc = Console.ReadLine();
            Console.WriteLine("please enter a price:");
            decimal price;
            bool ok = decimal.TryParse(Console.ReadLine(), out price);
            if (!ok)
            {
                Console.WriteLine("Price must be a number");
                return false;
            }
            expenses.Add(new Expense { Description = desc, Price = price });
            return true;
        }
        static void ShowExpenses(List<Expense> expenses)
        {
            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses yet!");
                return;
            }
            foreach (Expense ex in expenses)
            {
                Console.WriteLine(ex.Description);
                Console.WriteLine(ex.Price);
                Console.WriteLine("--------------");
            }
        }
        static decimal CalculateTotal(List<Expense> expenses)
        {
            decimal total = 0;
            foreach (Expense ex in expenses)
            {
                total += ex.Price;
            }
            return total;
        }
        static void Main()
        {
            List<Expense> expenses = new List<Expense>();
            
            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Add expense");
                Console.WriteLine("2. Show expense");
                Console.WriteLine("3. Show Total");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        bool added = AddExpense(expenses);
                        if (added)
                            Console.WriteLine(expenses.Count);
                        break;
                    case "2":
                        ShowExpenses(expenses);
                        break;
                    case "3":
                        Console.WriteLine("The Total expenses:" + CalculateTotal(expenses));
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("BYE!");
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
        }
    }
}

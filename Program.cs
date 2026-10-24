using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    class Program
    {
        static void AddExpense(List<Expense> expenses)
        {
            Console.WriteLine("Please enter a description:");
            string desc = Console.ReadLine();
            Console.WriteLine("please enter a price:");
            decimal price;
            bool ok = decimal.TryParse(Console.ReadLine(), out price);
            if (!ok)
            {
                Console.WriteLine("Price must be a number");
                return;
            }
            expenses.Add(new Expense { Description = desc, Price = price });
        }
        static void Main()
        {
            List<Expense> expenses = new List<Expense>();
            AddExpense(expenses);
            Console.Write(expenses.Count);
        }
    }
}

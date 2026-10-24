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
        static void Main()
        {
            List<Expense> expenses = new List<Expense>();
            bool Added = AddExpense(expenses);
            if (Added == true)
                Console.WriteLine(expenses.Count);
        }
    }
}

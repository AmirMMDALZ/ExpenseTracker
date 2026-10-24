using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Expense> expenses = new List<Expense>();
            Console.WriteLine("Please enter a description:");
            string desc = Console.ReadLine();
            Console.WriteLine("please enter a price:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            expenses.Add(new Expense { Description = desc, Price = price });
            Console.Write(expenses.Count);
        }
    }
}

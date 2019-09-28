using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions2.Entities;
using Exceptions2.Entities.Exceptions;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Will you deposit any money? (y/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine();
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Depoist value: ");
                    double deposit = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    acc.Deposit(deposit);

                }




                Console.Write("Will you withdraw any money? (y/n): ");
                ch = char.Parse(Console.ReadLine());
                Console.WriteLine();
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Enter the amount for withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    acc.Withdraw(withdraw);
                    Console.Write("New balance: " + acc.Balance.ToString("F2"));
                    Console.WriteLine();

                }


                else
                {
                    Console.WriteLine("We appreciate your visit. Your account balance is: $" + acc.Balance.ToString("F2"));
                }

            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
                Console.WriteLine();

            }
            catch (FormatException e)
            {
                Console.WriteLine("Format exception: " + e.Message);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
                Console.WriteLine();
            }


        }
    }
}

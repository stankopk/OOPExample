using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPExample
{
    internal class Program
    {
        static List<BankAccount> bankAccounts = new List<BankAccount>();

        static void Main(string[] args)
        {
            Create(1);
            Create(1);
            Deposit(1, 20);
            Withdraw(1,30);
            Withdraw(1,10);
            Print(1);
        }

        public static void Create(int id)
        {
            var exsitingAcc = bankAccounts.Any(b => b.Id == id);

            if (exsitingAcc)
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount bankAccount = new BankAccount();
                bankAccount.Id = id;
                bankAccounts.Add(bankAccount);
            }
        }

        public static void Deposit(int id, double amount)
        {
            var existingAcc = bankAccounts.Where(b => b.Id == id).FirstOrDefault();
            if(existingAcc == null)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                existingAcc.Balance = existingAcc.Balance + amount;
            }
        }

        public static void Withdraw(int id, double amount)
        {
            var existingAcc = bankAccounts.Where(b => b.Id == id).FirstOrDefault();
            if (existingAcc == null)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                if(existingAcc.Balance >= amount)
                {
                    existingAcc.Balance = existingAcc.Balance - amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
        }

        public static void Print(int id)
        {
            var existingAcc = bankAccounts.Where(b => b.Id == id).FirstOrDefault();
            if (existingAcc == null)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine("Account ID" + existingAcc.Id + ", balance " +
                    existingAcc.Balance.ToString("0.##"));
            }
        }
    }
}
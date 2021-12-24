using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
        void SetBankAccount <T> (BankAccount<T> account, T num, decimal chek, string[] name)
        {
            account.Num = num;

        }
    }

    
    class BankAccount<T>
    {
        private T Num { get; set; }
        private decimal Chek { get; set; }
        private string[] Name { get; set; } = new string[3];
    }
}

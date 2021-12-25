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
            Console.WriteLine("Номер счета типа int");
            BankAccount<int> account = new BankAccount<int> ();
            account.Num = 117;
            account.Chek = 100000025;
            account.Name[0] = "Иванов";
            account.Name[1] = "Сергей";
            account.Name[2] = "Иванович";
            BankAccountPrint<int>(account);
            Console.WriteLine();

            Console.WriteLine("Номер счета типа string");
            BankAccount<string> account1 = new BankAccount<string> ();
            account1.Num = "е342то799";
            account1.Chek = 100000025;
            account1.Name[0] = "Не Иванов";
            account1.Name[1] = "Не Сергей";
            account1.Name[2] = "И не Ианович";
            BankAccountPrint<string>(account1);

            Console.ReadKey();
        }
        static void BankAccountPrint<T> (BankAccount<T> account)
        {
            Console.WriteLine("Номер банковского счета : {0}", account.Num);
            Console.WriteLine("Состояние счета :  {0}", account.Chek);
            Console.WriteLine("Владелец счета : {0} {1} {2}", account.Name[0], account.Name[1], account.Name[2]);
        }

    }

    
    class BankAccount<T>
    {
        private T num;
        private decimal chek;
        private string[] name = new string[3];
        
        public T Num 
        { 
            get { return num; }
            set { num = value; } 
        }
        public decimal Chek 
        { 
            get { return chek; }
            set { chek = value; }
        }
        public string[] Name 
        { 
            get { return name; }
            set { name = value; } 
        } 

    }
}

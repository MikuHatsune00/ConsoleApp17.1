using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bankAccount<string> account1 = new bankAccount<string>("TK777", 9999998, "Tim Cook");
            account1.printAccount<string>();
            bankAccount<int> account2 = new bankAccount<int>(10011,99899988, "Elon Mask");
            account2.printAccount<int>();

            Console.ReadKey();
        }
    }
    class bankAccount<T>
    {
        private T Num { get; set; }
        private int balance { get; set; }
        private string nameLastname { get; set; }

        public bankAccount(T Num, int balance, string nameLastname)
        {
            this.Num = Num;
            this.balance = balance;
            this.nameLastname = nameLastname;
        }


        public void printAccount<T>()
        { Console.WriteLine("Номер счета: {0} Баланс: {1} Имя Фамилия: {2}", Num, balance, nameLastname); }


    }
}
    


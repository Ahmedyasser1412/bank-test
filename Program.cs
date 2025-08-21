using System.Collections.Specialized;

namespace bank
{
    internal class Program
    {
        static void Main(string[] args) {
            int x;
            BankAccount account=new BankAccount();

            Console.WriteLine("enter 1 for Deposit ");
            Console.WriteLine("enter 2 for Withdraw  ");
            x=int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine(" enter deposit number = ");
                x=int.Parse(Console.ReadLine());
                account.Deposit(x);

            }

        }    
    }



        public class BankAccount()
    {
        private int AccountNumber;
        public string OwnerName;
        public int Balance = 0;
        public int accountNumber
        {
            set
            {
                AccountNumber = value;
            }
        }
        public void Deposit(int Number)
        {
         Balance += Number;
          Console.WriteLine($"Balance: {Balance}");

        }
        public void withraw(int Number)
        {

            Balance -= Number;
            Console.WriteLine($"Balance: {Balance}");

        }


    }
}


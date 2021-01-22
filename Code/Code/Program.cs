using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {


            int total = 0, n = 0;
            Console.WriteLine("Choosing a number");
            total = Console.Read();
            while (true)
            {
                if (total % 3 == 2)
                {
                    total = total - 2;
                    Console.WriteLine(" I subtract 2");

                }

                else
                {
                    total--;
                    Console.WriteLine("I subtract 1");
                }

                Console.WriteLine("Now the number is" + total);

                if (total <= 0)
                {
                    Console.WriteLine("I win");
                    break;

                }




                Console.WriteLine("subtract 1 or 2");
                n = Console.Read();

                while (n < 1 || n > 2)
                {
                    Console.WriteLine("Only 1 or 2");
                    Console.WriteLine("Rewrite please");

                    n = Console.Read();

                }

                total = total - n;
                Console.WriteLine("Now the number is" + total);
                if (total <= 0)
                {
                    Console.WriteLine("you win");
                    break;
                }




            }

            //int x;
            //x = Console.Read();
            //Console.WriteLine("d" + x);
            //int n = 0;
            //n = Console.Read();
            //Console.WriteLine("b" + n);
        }
    }
}

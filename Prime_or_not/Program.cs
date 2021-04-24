using System;

namespace Prime_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int a;
            int Flag = 0;
            Console.WriteLine("enter the no");
            a =int.Parse( Console.ReadLine());
            int m = a / 2;
            for (i=2; i<=m; i++)
            {
                if (a%i == 0)
                {
                    Console.WriteLine("the no is not prime");
                    Flag = 1;
                    break;
                }
                
            }
            if(Flag==0)
            {
                Console.WriteLine("the no is prime");
            }
            Console.ReadKey();

        }
    }
}

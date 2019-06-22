using System;

namespace DP_NumOfPossibleCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            var t = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var input = Int32.Parse(Console.ReadLine());
                int[] count = new int[input + 1];
                count[0] = 1;
                for (int j = 3; j <= input; j++)
                {
                    count[j] += count[j - 3];
                }
                for (int j = 5; j <= input; j++)
                {
                    count[j] += count[j - 5];
                }
                for (int j = 10; j <= input; j++)
                {
                    count[j] += count[j - 10];
                }
                Console.WriteLine(count[input]);
            }
            Console.Read();
        }
    }
    abstract class A
    {
        public int MyProperty { get; set; }
        public A()
        {
            MyProperty = 0;
        }
    }

    internal class B : A
    {
       public B()
        {

        }
        
    }

}

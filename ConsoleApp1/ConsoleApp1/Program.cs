using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            //a++;  a를 1 증가시키는 증감 연산자
            int b = 6;
            int c = a + b;
            Console.WriteLine("c : " + c);

            Console.WriteLine("100 - 10 = " + (100 - 10));

            int d = a / b;
            Console.WriteLine("d : " + d);

            int e = a * (b + c);
            Console.WriteLine("e : " + e);

            int f = (a + b) % 2;
            Console.WriteLine("f : " + f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursjon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://www.w3resource.com/csharp-exercises/recursion/index.php
            //PrintNaturalAsc(1,10);
            //Console.WriteLine(SumNatural(10));//oppg. 3
            //IndividualDigits(1234);//oppg 4
            //SumNatural(10);
            Console.WriteLine(CountDigits(1, 1));
            
            
            Console.ReadLine();

        }
        /// <summary>
        /// Printer ut n tall, fra n og synkende. Write a program in C# Sharp to print numbers from n to 1 using recursion
        /// </summary>
        /// <param name="n"></param>
        static int PrintNatural(int n)
        {
            if (n < 1)
                return 1;
            Console.WriteLine(n);
            return PrintNatural(n - 1);
            
        }

        /// <summary>
        ///  Write a program in C# Sharp to print the first n natural number using recursion. Printer stigende. value starter med 1
        /// </summary>
        /// <param name="value"></param>
        /// <param name="howMany"></param>
        /// <returns></returns>
        static int PrintNaturalAsc(int value,int howMany)
        {
            if (howMany < 1)
                return 1;
            Console.WriteLine(value);
            howMany--;//brukes til exit i if
            return PrintNaturalAsc(value+1,howMany);//her økes value
        }

        /// <summary>
        /// 3. Write a program in C# Sharp to find the sum of first n natural numbers using recursio
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int SumNatural(int n)
        {
            if (n < 1)
                return n;
            return n + SumNatural(n-1);
        }

        /// <summary>
        /// 4. Write a program in C# Sharp to display the individual digits of a given number using recursion. 1234 blir til 1 2 3 4
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static void IndividualDigits(int n)
        {
            if (n < 10)
            {
                Console.WriteLine(n);
                return;
            }
            
            IndividualDigits(n/10);
            Console.WriteLine(n%10);
        }

        static int CountDigits(int n,int counter)
        {
            if (n < 10)
                return counter;
            return CountDigits(n/10,counter+1);   
        }
    }
}

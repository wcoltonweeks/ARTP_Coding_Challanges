using System;
using System.Collections.Generic;
using System.Linq;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------Problem--------------------------------------------------

            //The Fibonacci sequence is defined by the recurrence relation:
            //Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144.F12 is the first term to contain three digits.
            //What is the index of the first term in the Fibonacci sequence to contain 10 digits?


            //------------------------------------------------------Solution----------------------------------------------------

            List<long> fibo = new List<long>() { 1, 1 };                     //Instantiated a new list to store the fibonacci seq

            int num = 1;                                                     //num refers to the index of 2 in the fibo list
            long result = 0;                                                 //this is the result that will become the next number in the sequence

            while (result < 9999999999)
            {
                result = fibo[num] + fibo[num - 1];                          //adds the value at the index of num to the value stored at the previous index and stores result
                fibo.Add(result);                                            //adds number to the list and increments num
                num++;
            }

            //foreach (var item in fibo)
            //{
            //    Console.WriteLine(item);                                   //testing the values
            //}

            long firstTen = fibo.Where(x => x.ToString().Length == 10).FirstOrDefault();           //Linq statement converts to string and checks for string length. grabs the first number
            Console.WriteLine(firstTen);

        }
    }
}

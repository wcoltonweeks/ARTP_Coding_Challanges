using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------Problem--------------------------------------

            //// If we list all the natural numbers below 10
            //// that are multiples of 3 or 5, we get 3, 5,
            //// 6 and 9.The sum of these multiples is 23.

            //// Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.


            //-----------------------------------Solution--------------------------------------

            List<int> Mult3and5 = new List<int>(); //Create a List to store all the multiples

            for (int i = 0; i < 1000; i = i + 3)
            {
                Mult3and5.Add(i);                  //Iterated through all the multiples of 3 below 1000 and adds the values to the List
            }
            for (int i = 0; i < 1000; i = i + 5)
            {
                if (!Mult3and5.Contains(i))
                {
                    Mult3and5.Add(i);              //Iterated through all the multiples of 5 below 1000. Only added values the List did not already contain
                }
            }
            
            //foreach (int item in Mult3and5)
            //{
            //    Console.WriteLine(item);         //Code for testing the list values
            //}

            Console.WriteLine(Mult3and5.Sum());    //Print the sum of all values in the List (using System.Linq)

        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------Problem---------------------------------------------------

            //Each new term in the Fibonacci sequence is generated
            //by adding the previous two terms.By starting with
            //1 and 2, the first 10 terms will be:

            //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
            //find the sum of the even-valued terms.


            //------------------------------------------Solution----------------------------------------------------

            List<int> fibo = new List<int>() { 1, 2 };                         //Instantiated a new list to store the fibonacci seq

            int num = 1;                                                       //num refers to the index of 2 in the fibo list
            int result = 0;                                                    //this is the result that will become the next number in the sequence

            do
            {
                result = fibo[num] + fibo[num - 1 ];                           //adds the value at the index of num to the value stored at the previous index and stores result
                fibo.Add(result);                                              //adds number to the list and increments num
                num++;
            } while (result < 4000000);

            //foreach (int item in fibo)
            //{
            //    System.Console.WriteLine(item);                              //testing the values in the seqience
            //}

            List<int> fiboEven = new List<int>();                              //instantiated a new list to store the even values

            foreach (var item in fibo)
            {
                if (item % 2 == 0)
                {
                    fiboEven.Add(item);                                        //this loop uses a % to determine whether a number in fibo is even. if it is, add it to the new list
                }
                
            }
            System.Console.WriteLine(fiboEven.Sum());                          //print the sum of even numbers
        }
    }
}

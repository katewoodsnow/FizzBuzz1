using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz3
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            for (int i = 1; i <= 100; i++) 
            { 
                bool Fizz = i % 3 == 0; bool Buzz = i % 5 == 0;

                if ((Fizz) && (Buzz))
                {
                    Console.WriteLine("FizzBuzz");
                }

                if (Fizz)
                {
                    Console.WriteLine("Fizz");
                }

                else if (Buzz)
                {
                    Console.WriteLine("Buzz");
                }

                else
            
                {
                    Console.WriteLine(i);
                }
            }       
        }
    }
}
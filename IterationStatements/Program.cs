﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0
            int x = 0;


            // Create a do-while loop
            do
            {
                x++;
                numbers.Add(x);
                // Increment your variable by 1
                // Then add your variable to "numbers"
            } while (x < 100);
            // While your variable is less than 100



            // Create a while loop
            // While your variable is less than 200
            while (x < 200)
            {
                x++;
                numbers.Add(x);
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach (var num in numbers)
            { 
                Console.WriteLine(num);
            }
                Console.WriteLine("Decrease:");
            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i-- )
            {
                // Write to the console "numbers" at index i
                Console.WriteLine(numbers[i]);
            }

        }


    }
}

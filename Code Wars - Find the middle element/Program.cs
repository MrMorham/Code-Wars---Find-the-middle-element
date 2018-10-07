using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*As a part of this Kata, you need to create a function that when provided with a triplet, returns the index of the numerical element that lies between the other two elements.
The input to the function will be an array of three distinct numbers (Haskell: a tuple). For example: gimme([2, 3, 1]) => 0 2 is the number that fits between 1 and 3 and the 
index of 2 in the input array is 0. Another example (just to make sure it is clear): gimme([5, 10, 14]) => 1 10 is the number that fits between 5 and 14 and the index of 10 in 
the input array is 1.*/

namespace Code_Wars___Find_the_middle_element
{
    class Program
    {
        static void Main (string[] args)
        {
            double[] test1 = { 2, 1, 3 };
            double[] test2 = { 10, 15, 14 };

            double Position = 0;

            double FindMiddle (double[] input)
            {
                foreach(double a in input)
                {
                    if(a != input.Min() && a != input.Max())
                    {
                       return Position;
                    }

                    Position++;
                }

                return Position;
            }

            Console.WriteLine($"The middle value is held in position {FindMiddle(test1)}");
            Console.WriteLine($"The middle value is held in position {FindMiddle(test2)}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> nums = new Stack<string>(input.Reverse());

            while (nums.Count > 1)
            {

            
            
                int n1 = int.Parse(nums.First());
                nums.Pop();
                char op = char.Parse(nums.First());
                nums.Pop();
                int n2 = int.Parse(nums.First());
                nums.Pop();

                if (op == '-')
                {
                    nums.Push((n1 - n2).ToString());
                  
                }
                else if (op == '+')
                {
                    nums.Push((n1 + n2).ToString());
                   
                }
            }

            Console.WriteLine(nums.Pop());
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] rawCommand = command.Split(" ");
                string cmd = rawCommand[0].ToLower();
                

                 if (cmd == "add")
                {
                    int n1 = int.Parse(rawCommand[1]);
                    int n2 = int.Parse(rawCommand[2]);

                    numbers.Push(n1);
                    numbers.Push(n2);
                }
                else if (cmd == "remove")
                {
                    int num = int.Parse(rawCommand[1]);

                    for (int i = 0; i < num; i++)
                    {
                        if (numbers.Count < num)
                        {
                            break;
                        }
                        else
                        {
                            numbers.Pop();
                        }
                        
                    }
                }
                command = Console.ReadLine().ToLower();
            }


           
                Console.WriteLine($"Sum: {numbers.Sum()}");
               
           
        }
    }
}

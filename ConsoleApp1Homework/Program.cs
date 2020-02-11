using System;

namespace ConsoleApp1Homework {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            //var sum = 0;
            //for (var index = 0; index <= 1000; index++) { 
            //Used for dealing with numbers 'for loop' cycles through until B not/T
            // sum += index;
            // }
            //Console.WriteLine($"Sum is {sum}");
            var sum = 1;
            for (var index = 1; index <= 10; index++) { //best option of the 2 
                sum = sum * index;
                }
             Console.WriteLine($"Sum is {sum}");

            // alternate solution
            sum = 1;
            var idx = 1;
            while(idx <= 10) {
                sum *= idx;
                idx++;
                }
            Console.WriteLine($" Sum is {sum}");
            }
        }
    }

    
        
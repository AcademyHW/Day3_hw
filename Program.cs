using System;
using System.Collections.Generic;

namespace Day3_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers Array: ");
            Task1.GeneratePrimeNumbersArray();

            Console.WriteLine("Input your word: ");
            Task2.ProcentLetterInWord(Console.ReadLine());

            Console.WriteLine("Input mail: ");
            Console.WriteLine(Task3.CheckEmail(Console.ReadLine()));

            Console.WriteLine("Input IP: ");
            Console.WriteLine(Task3.CheckIP(Console.ReadLine()));

            var Workers = new List<Worker>();
            var Randomer = new Random();
            for (int i = 0; i < 7; i++)
            {
                Workers.Add(new Worker("Worker "+i,Randomer.Next(10000,50000),25));
                Console.WriteLine("In workers added worker {0} with salary {1}", i, Workers[i].Salary);
            }
            Console.WriteLine("Out Workers with salary > 30000");
            foreach (var Person in Workers)
            {
                if (Person.Salary > 30000) Console.WriteLine("{0} have {1} salary",Person.FIO, Person.Salary);
            }
        }
    }
}

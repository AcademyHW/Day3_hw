using System;
using System.Collections.Generic;

namespace Day3_HW
{
    class Task1
    {
        public static void GeneratePrimeNumbersArray()
        {
            var PrimeNumbersArray = new List<int>() { 2 }; //2 is start prime number 
            var CurrentNumber = PrimeNumbersArray[0] + 1;  //Start at 3
            while (Math.Sqrt(CurrentNumber)<10) 
            {
                var Counter = 0; //Number is prime if divide only 1 and this number
                for (int i = 1; i < CurrentNumber+1; i++) //Check all numbers
                {
                    if (CurrentNumber % i == 0) Counter++;
                    if (Counter > 2) break;
                }
                if (Counter == 2) PrimeNumbersArray.Add(CurrentNumber);
                CurrentNumber++;
            }
            foreach (var item in PrimeNumbersArray)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine();
        }
    }
}

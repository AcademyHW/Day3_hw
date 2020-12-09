using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_HW
{
    class Task2
    {
        public static void ProcentLetterInWord(string Word)
        {
            char LastLetterInWord = Word[Word.Length-1]; //Last Letter
            var Counter = 0;
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == LastLetterInWord) Counter++;
            }
            Console.WriteLine("{0}% of {1} in {2}", 100 / Word.Length * Counter, LastLetterInWord, Word);
        }
    }
}

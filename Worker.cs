using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_HW
{
    class Worker
    {
        public string FIO { get; private set; }
        public int Salary { get; private set; }
        public int Age { get; private set; }

        public Worker(string FIO, int Salary, int Age)
        {
            this.FIO = FIO;
            this.Salary = Salary;
            this.Age = Age;
        }
    }
}

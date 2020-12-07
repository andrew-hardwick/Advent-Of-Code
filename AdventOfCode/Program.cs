using AdventOfCode.Solutions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new DayFactory();

            var day = factory.GetDay("20-02");

            Console.WriteLine(day.PartOne);
            Console.WriteLine(day.PartTwo);
            Console.Read();
        }
    }
}

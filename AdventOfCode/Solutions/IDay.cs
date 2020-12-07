using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Solutions
{
    public interface IDay
    {
        string Identifier { get; }
        string PartOne { get; }
        string PartTwo { get; }
    }
}

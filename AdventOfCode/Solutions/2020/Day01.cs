using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Solutions._2020
{
    public class Day01 : IDay
    {
        public string Identifier => "20-01";

        public string PartOne => CalculatePartOne();

        public string PartTwo => CalculatePartTwo();


        private int[] _expenses = null;

        private string CalculatePartOne()
        {
            LoadExpenses();

            for (int i = 0; i < _expenses.Length; i++)
            {
                for(int j = i + 1; j < _expenses.Length; j++)
                {
                    if (2020 == _expenses[i] + _expenses[j])
                    {
                        return (_expenses[i] * _expenses[j]).ToString();
                    }
                }
            }

            // Default value if no answer is found
            return 0.ToString();
        }

        private string CalculatePartTwo()
        {
            LoadExpenses();

            for (int i = 0; i < _expenses.Length; i++)
            {
                for (int j = i + 1; j < _expenses.Length; j++)
                {
                    for (int k = j + 1; k < _expenses.Length; k++)
                    {
                        if (2020 == _expenses[i] + _expenses[j] + _expenses[k])
                        {
                            return (_expenses[i] * _expenses[j] * _expenses[k]).ToString();
                        }
                    }
                }
            }

            // Default value if no answer is found
            return 0.ToString();
        }

        private void LoadExpenses()
        {
            if (_expenses is null)
            {
                _expenses = File.ReadAllLines("Input\\2020\\01.txt")
                                .Select(l => int.Parse(l))
                                .ToArray();
            }
        }
    }
}

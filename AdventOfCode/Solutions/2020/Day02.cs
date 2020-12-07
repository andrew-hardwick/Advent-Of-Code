using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Solutions._2020
{
    public class Day02 : IDay
    {
        public string Identifier => "20-02";

        public string PartOne => CalculatePartOne();

        public string PartTwo => CalculatePartTwo();

        private ((int a, int b) locations, char character, string password)[] _data = null;

        private string CalculatePartOne()
        {
            LoadData();

            var validCount = 0;

            foreach (var datum in _data)
            {
                var charCount = datum.password.Count(c => c.Equals(datum.character));

                if (datum.locations.a <= charCount && charCount <= datum.locations.b)
                {
                    validCount++;
                }

            }

            return validCount.ToString();
        }

        private string CalculatePartTwo()
        {
            LoadData();

            var validCount = 0;

            foreach (var datum in _data)
            {
                var charCount = datum.password.Count(c => c.Equals(datum.character));

                var existantA = datum.password[datum.locations.a - 1] == datum.character;
                var existantB = datum.password.Length >= datum.locations.b &&  datum.password[datum.locations.b - 1] == datum.character;

                if (existantA ^ existantB)
                {
                    validCount++;
                }

            }

            return validCount.ToString();
        }

        private void LoadData()
        {
            if (_data is null)
            {
                _data = File.ReadAllLines("Input\\2020\\02.txt")
                            .Select(l => l.Replace(":", string.Empty))
                            .Select(l => l.Replace('-', ' '))
                            .Select(l => l.Split(' '))
                            .Select(s => ((int.Parse(s[0]), int.Parse(s[1])), s[2][0], s[3]))
                            .ToArray();
            }
        }
    }
}

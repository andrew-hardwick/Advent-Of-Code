using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solutions
{
    public class DayFactory
    {
        private Dictionary<string, IDay> _days = new Dictionary<string, IDay>();

        public DayFactory()
        {
            var dayTypes = AppDomain.CurrentDomain.GetAssemblies()
                                              .SelectMany(s => s.GetTypes())
                                              .Where(p => typeof(IDay).IsAssignableFrom(p))
                                              .Where(p => !p.Equals(typeof(IDay)));

            /***************************************************************
             * I'm already doing reflection, so I'm not worried about the  *
             * cost of just instantiating all of these now instead of lazy *
             * loading.                                                    *
             ***************************************************************/
            foreach (var dayType in dayTypes)
            {
                var day = (IDay)Activator.CreateInstance(dayType);

                _days[day.Identifier] = day;
            }
        }

        public IDay GetDay(string identifier) => _days[identifier];
    }
}
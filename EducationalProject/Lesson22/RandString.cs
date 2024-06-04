using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson22
{
	public static class RandString
	{
        public static void ProcessStringArray()
        {
            var myDict = new Dictionary<int, string>()
            {
                {1, "abcrr" },
                {2, "fgth" },
                {3, "tu" },
                {4, "m" },
                {5, "a" },
                {6, "fh" },
                {7, "tueeeq" }
            };

            var sortedDict = myDict.OrderByDescending(x => x.Value.Length);

           // myDict = myDict.OrderByDescending(x => x.Value.Length).ToDictionary();

            Console.WriteLine(string.Join("\n", sortedDict));

            int center = (int)Math.Ceiling((decimal)sortedDict.Count() / 2);

            Console.WriteLine(center);

            var secondHalf = sortedDict.Skip(center)
                .Where(x => x.Value.Length <= 3)
                .OrderBy(x => x.Value)
                .Select(x => x.Value.ToUpper());

            Console.WriteLine(string.Join("\n", secondHalf));

        }
    }
}



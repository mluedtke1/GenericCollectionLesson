using System;
using System.Collections.Generic;

namespace GenericCollectionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> scores = new List<int>();
            var total = 0;
            for (var i = 1; i < 31; i++){
                scores.Add(rng.Next(0, 31));
            }

            foreach(var j in scores)
            {
                total += j;
            }
            Console.WriteLine(total);
        }
    }
}

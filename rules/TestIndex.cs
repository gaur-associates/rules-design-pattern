using System;
using System.Linq;

namespace rules
{
    public class TestIndex
    {
        public static void testIndex()
        {
            int[] orig = { 0, 1, 2, 3, 4, 5 };
            var range = 0..^0;
            var oldPortion = orig[range];

            var portion = new Span<int>(orig, 1, 3);

            portion[^1] = 100;

            orig.ToList().ForEach(s => Console.Write($"{s} "));
            Console.WriteLine();
            //portion.ToList().ForEach(s => Console.Write($"{s} "));
            Console.WriteLine();
        }
    }

}

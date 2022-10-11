using System;
namespace FindMaximumOf3Int
{
    internal class MaxOf3Int
    {
        public static int findmaxint(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
               first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
               first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && first.CompareTo(first) > 0 ||
                third.CompareTo(second) >= 0 && first.CompareTo(first) > 0 ||
                third.CompareTo(second) > 0 && first.CompareTo(first) >= 0)
            {
                return third;
            }
            return first;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Integer Number Is:"+ findmaxint(7,8,3));
        }
    }
}

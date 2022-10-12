using System;

namespace FindMaxOf3String
{
    internal class MaxOf3String
    {
        public static String findmaxstring(String first, String second, String third)
        {
            //If first-second>0 && first-third>0
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
               first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
               first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            //If second-first>0 && second-third>0
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            //If third-first>0 && third-second>0
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
            Console.WriteLine("Maximum String Is:" + findmaxstring("CCC","AAA","BBB"));
        }
    }
}

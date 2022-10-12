using System;

namespace FindMaxOf3Values
{
    internal class MaxOf3Values
    {
        public static T findmax<T>(T first, T second, T third) where T : IComparable<T>
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
            Console.WriteLine("Maximum Integer Value:" + MaxOf3Values.findmax<int>(3, 4, 2));
            Console.WriteLine("Maximum Float Value:" + MaxOf3Values.findmax<float>(2.14f, 4.63f, 1.22f));
            Console.WriteLine("Maximum String Value:" + MaxOf3Values.findmax<string>("aaa", "ccc", "bbb"));
        }
    }
}

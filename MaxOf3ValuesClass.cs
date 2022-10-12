using System;

namespace FindMaxOf3ValuesClass
{
    class MaxOfValues<T> where T : IComparable<T>
    {
        public T first, second, third;

        public MaxOfValues(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static T findmax(T first, T second, T third)
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
    }
    internal class MaxOf3ValuesClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maximum Integer Is:" + MaxOfValues<int>.findmax(4, 5, 3));
            Console.WriteLine("Maximum Float Is:" + MaxOfValues<float>.findmax(4.32f, 2.47f, 1.55f));
            Console.WriteLine("Maximum String Is:" + MaxOfValues<string>.findmax("yyy", "xxx", "zzz"));
        }
    }
}

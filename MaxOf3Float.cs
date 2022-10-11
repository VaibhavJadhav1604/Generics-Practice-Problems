﻿using System;

namespace FindMaxOf3Float
{
    internal class MaxOf3Float
    {
            public static float findmaxfloat(float first, float second, float third)
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
                Console.WriteLine("Maximum Float Number Is:" + findmaxfloat(12.5f,8.34f,15.74f));
            }
    }
}
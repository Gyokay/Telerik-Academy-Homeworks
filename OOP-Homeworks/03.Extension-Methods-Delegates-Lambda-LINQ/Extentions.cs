namespace _03.Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Extentions
    {

        //Problem 1. StringBuilder.Substring
        //Implement an extension method  Substring(int index, int length)
        //for the class  StringBuilder  that returns new  StringBuilder  
        //and has the same functionality as  Substring  in the class  String .
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
            var strBuilder = new StringBuilder();

            for (int i = index; i < length; i++)
            {
                strBuilder.Append(stringBuilder[i]);
            }

            return strBuilder;
        }

        //Problem 2. IEnumerable extensions
        //Implement a set of extension methods for  IEnumerable<T> that implement 
        //the following group functions: sum, product, min, max, average.
        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            dynamic sum = default(T);

            foreach (T item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic prod = 1;

            foreach (T item in collection)
            {
                prod *= item;
            }

            return prod;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            T min = collection.First();

            foreach (T item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            T max = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}

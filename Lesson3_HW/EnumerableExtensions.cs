using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HW
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> sourceList, Func<T, bool> condition)
        {
            foreach (T item in sourceList)
            {
                if (condition(item))
                {
                    yield return item;
                }
            }
        }
    }
}

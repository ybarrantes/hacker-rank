using System.Collections.Generic;
using System.Linq;

namespace Arrays.ArrayLeftRotation
{
    public class ArrayLeftRotation : IArrayLeftRotation
    {
        public List<int> Rotate(List<int> a, int d)
        {
            var steps = d % a.Count;
            if (steps == 0)
                return a;

            return a.Select((t, i) =>
            {
                var index = i + steps;
                index -= (index > a.Count - 1) ? a.Count : 0;
                return a[index];
            }).ToList();
        }
    }
}
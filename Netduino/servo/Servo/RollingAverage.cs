using System;
using Microsoft.SPOT;
using System.Collections;

namespace Servo
{
    public class RollingAverage : ArrayList
    {
        protected readonly int MaxCount;

        public RollingAverage(int maxCount)
        {
            MaxCount = maxCount;
        }

        public override int Add(object value)
        {
            var count = base.Add(value);

            while (Count > MaxCount)
            {
                RemoveAt(0);
            }

            return count;
        }

        public double Average()
        {
            int count = 0;
            double total = 0;

            foreach(int item in this)
            {
                count++;
                total += item;
            }

            return total / count;
        }
    }
}

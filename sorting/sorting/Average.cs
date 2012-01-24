using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sorting
{
    class Average
    {
        // Get the average # in an array. warmup

        public Average()
        {
        }

        public int AverageArray(int[] array)
        {
            int answer = 0;

            for (int i = 0; i < array.Count(); i++)
            {
                answer = answer + array[i];
            }
            answer = answer / array.Count();

            return answer;
        }
    }
}

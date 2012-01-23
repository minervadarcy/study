using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sorting
{
    public class BubbleSort
    {
        //algorithm is O(N^2)
        public BubbleSort()
        {
        }

        public List<int> Sort(List<int> unsortedList)
        {
            List<int> sortedList = new List<int>();
           // write code stuff here.
            return sortedList;
        }

        public int[] Sort(int[] sortList)
        {
            int count = 0;
            if (sortList != null) count = sortList.Count();
            int tempSwap = 0;
            bool isSorted = false;

            while (isSorted)
            {
                isSorted = true;
                for (int i = 0; i < count - 1; i++)
                {

                    if (sortList[i] > sortList[i + 1])
                    {
                        isSorted = false;
                        tempSwap = sortList[i + 1];
                        sortList[i + 1] = sortList[i];
                        sortList[i] = tempSwap;
                    }
                }
            }


            return sortList;
        }

    }
}

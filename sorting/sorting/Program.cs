using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bubble Sort
            // Quick Sort
            // Insertion Sort
            // Selection Sort
            // Merge Sort
            // Heap Sort
            // Shell Sort
            //http://www.squidoo.com/sorting-algorithms

            // Test out average
            int[] testAvgArray = new int[] { 10, 20, 30};

            Average a = new Average();
            int answer = a.AverageArray(testAvgArray);
            Console.WriteLine("answer Average is 20 =>{0}", answer.ToString());

        }
    }
}

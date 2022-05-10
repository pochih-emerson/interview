using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewExam
{
    public class Questions
    {
        /// <summary>
        /// Write a function to print numbers that are not duplicated in an Integer array.
        /// Input: [1, 5, 11, 2, 4, 9, 4, 1]
        /// Output: [5, 11, 2, 9]
        /// </summary>
        public void Item_3_1(int[] input = null)
        {
            if (input == null)
            {
                input = new int[] { 1, 5, 11, 2, 4, 9, 4, 1 };
            }

            Console.WriteLine("Answer: ");
        }

        /// <summary>
        /// Write a function to find missing numbers in a continuous numerical series.
        /// Input: [3, 6, 9, 7, 4]
        /// Output: [5, 8]
        /// </summary>
        public void Item_3_2(int[] input = null)
        {
            if (input == null)
            {
                input = new int[] { 3, 6, 9, 7, 4 };
            }
            Console.WriteLine("Answer: ");
        }
    }
}

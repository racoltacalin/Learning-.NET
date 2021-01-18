using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep_Example
{
    public class JaggedArrayClass
    {
        public void ShowJaggedArray()
        {
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[3] { 1, 2, 3 };
            jaggedArray[1] = new int[2] { 0, 1 };
        }
    }
}

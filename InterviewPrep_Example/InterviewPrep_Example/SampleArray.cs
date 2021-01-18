using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep_Example
{
    public class SampleArray
    {
        // Array and Arraylist
        public void ArratFunction()
        {
            string[] country = new string[3];
            // only string value can be added
            country[0] = "USA";
            country[1] = "Romania";
            country[2] = "Russia";

            ArrayList arrayList = new ArrayList();
            // can store different data types
            arrayList.Add(3);
            arrayList.Add("USA");
            arrayList.Add(false);
        }
    }
}

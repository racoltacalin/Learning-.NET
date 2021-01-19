using System;

namespace InterviewPrep_Example
{
    class Program
    {
        static void Main()
        {
            TestRefType();
        }

        public static void TestRefType()
        {
            SampleRefType rt = new SampleRefType();
            rt.value = 44;
            ModifyObject(rt);
            Console.WriteLine(rt.value);

        }

        static void ModifyObject(SampleRefType obj)
        {
            obj.value = 33;
        }
    }
}

using System;

namespace MoreAboutGenerics
{
    class TestGenericList
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            // Declare a list of type int
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);
            Console.WriteLine(list1);

            // Declare a list of type string
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("");
            Console.WriteLine(list2);

            // Declarea a list of type ExampleClass
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());
            Console.WriteLine(list3);
        }
    }
}

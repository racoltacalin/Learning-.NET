using System;
using System.Collections.Generic;

namespace MoreAboutGenerics
{
    class TestGenericList
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            Generic<string> g = new Generic<string>();
            g.Field = "A string";
            Console.WriteLine("Generic.Field           = \"{0}\"", g.Field);
            Console.WriteLine("Generic.Field.GetType() = {0}", g.Field.GetType().FullName);

            

            /*
            T Generic<T>(T arg)
            {
                T temp = arg;
                //
                return temp;
            }
            */

            /* 
            // int is the type argument

            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AddHead(i);
            }

            foreach (int  i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n Done");
            */

            /* 
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
            */


        }
    }
}

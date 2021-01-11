using System;
using System.Collections.Generic;
using System.Text;

namespace InnerClassesExample
{
    public class OuterClass
    {
        private string name;

        private OuterClass(string name)
        {
            this.name = name;
        }

        private class NestedClass
        {
            private string name;
            private OuterClass parent;

            public NestedClass(OuterClass parent, string name)
            {
                this.parent = parent;
                this.name = name;
            }

            public void PrintNames()
            {
                Console.WriteLine("Nested name: " + this.name);
                Console.WriteLine("Outer name: " + this.parent.name);
            }
        }


        static void Main()
        {
            OuterClass outerClass = new OuterClass("outer");
            NestedClass nestedClass = new OuterClass.NestedClass(outerClass, "nested");
            nestedClass.PrintNames();
        }
    }
}

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

    public class Dog
    {
        public string Name { get; set; }
        public Dog(string name)
        {
            this.Name = name;
        }
        public void Bark()
        {
            Console.WriteLine("Dog barks...");
        }
    }

    public class Beagle : Dog
    {
        public string Breed { get; set; }

        public Beagle(string name, string breed) : base(name)
        {
            this.Breed = breed;
        }

        public void Hung()
        {
            Console.WriteLine("Beagle is a good hunter.");
        }
    }

}

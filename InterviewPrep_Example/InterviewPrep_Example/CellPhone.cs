using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep_Example
{
    // What is virtual method, and how is it diffrenet from the abstract method?
    // A virtual method must have a default implementation, and We can override
    // this virtual method using the override keyword in the derived class.
    // The abstract method is without implementation, and it is created inside
    // the abstract class only. In the case of an abstract class, the class derived
    // from the abstract class must have an implementation of that abstract method.


    /// <summary>
    /// Example of a virtual method.
    /// </summary>
    public class CellPhone
    {
        public virtual void Typing()
        {
            Console.WriteLine("Using old keypad.");
        }
    }

    public class SmartPhone : CellPhone
    {
        public override void Typing()
        {
            Console.WriteLine("Using qwerty keyboard");
        }
    }

    /// <summary>
    /// Example of an abstract method.
    /// </summary>
    public abstract class CellPhones
    {
        // no default implementation
        public abstract void Typing();
    }

    public class OldPhones : CellPhones
    {
        // function override
        public override void Typing()
        {
            Console.WriteLine("Using keypad");
        }
    }

    public class SmartPhones : CellPhones
    {
        // function override
        public override void Typing()
        {
            Console.WriteLine("Using touch screen!");
        }
    }
}

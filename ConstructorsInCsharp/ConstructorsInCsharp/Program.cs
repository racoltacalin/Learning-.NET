using System;

namespace ConstructorsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Age = -2;
            Console.WriteLine("Age: " + myDog.age);


            /*
            Rectangle myRectangle = new Rectangle(100, 200);
            Console.WriteLine("The area of rectangle is : " + myRectangle.Area);
            */

            /*
            Point myPoint = new Point(2, 3);

            double myPointXCoord = myPoint.X; // Access a property
            double myPointYCoord = myPoint.Y; // Acces a property

            Console.WriteLine("The X coordinate is: " + myPointXCoord);
            Console.WriteLine("The Y coordinate is: " + myPointYCoord);
            */

            //Collar collar = new Collar();
            //Dog myDog = new Dog();

        }
    }
}
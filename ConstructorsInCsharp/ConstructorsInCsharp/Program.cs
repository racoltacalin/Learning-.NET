using System;

namespace ConstructorsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int mondayValue = (int)Days.Mon;
            Console.WriteLine("mondayValue = " + mondayValue);

            //Console.WriteLine(Days.Mon is Days);
            
            //Point2D point = new Point2D(3, -2);

            //Console.WriteLine(SqrtPrecalculated.GetSqrt(254));

            /*
            //SystemInfo sysInfoInstance = new SystemInfo();
            //Console.WriteLine("System version: " + sysInfoInstance.Version);
            
            // Invocation of static property setter
            SystemInfo.Vendor = "Microsoft Corporation";
            
            // Invocation of static property getters
            Console.WriteLine("System version: " + SystemInfo.Version);
            Console.WriteLine("System vendor: " + SystemInfo.Vendor);
             */

            /*
            Circle circle = new Circle(3);
            circle.PrintSurface();
            */


            /*
            Cat myCat = new Cat("Catty", 2);
            myCat.PrintInfo();
            */

            /*
            Dog dog1 = new Dog("Jackie", 1);
            Dog dog2 = new Dog("Lassy", 2);
            Dog dog3 = new Dog("Rex", 3);

            Console.WriteLine("The number of objects of type dog are: " + Dog.dogCount);
            */

            /*
            Circle myCircle = new Circle(2, 3);
            Console.WriteLine("The X coordinate is: " + myCircle.X);
            Console.WriteLine("The Y coordinate is: " + myCircle.Y);
            */

            /*
            Dog myDog = new Dog();
            myDog.Age = -2;
            Console.WriteLine("Age: " + myDog.age);
            */

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
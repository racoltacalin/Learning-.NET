using System;
using System.Collections.Generic;
using System.Text;

namespace InnerClassesExample
{
    public class Car
    {
        Engine engine;

        public Car()
        {
            engine = new Engine();
            engine.horsePower = 2000;
        }

        public class Engine
        {
            public int horsePower;
        }
    }
}

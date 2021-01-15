using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public interface Reproducible<T> where T : Felidae
    {
        T[] Reproduce(T mate);
    }
}

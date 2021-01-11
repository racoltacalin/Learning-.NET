using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace EnumerationsInCsharp
{
    public class Coffee
    {
        public CoffeeSize size;
        public Coffee(CoffeeSize size)
        {
            this.size = size;
        
        }

        public CoffeeSize Size
        {
            get { return size; }
        }
    }
}

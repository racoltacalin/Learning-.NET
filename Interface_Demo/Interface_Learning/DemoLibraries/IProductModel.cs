using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibraries
{
    public interface IProductModel
    {
        string Title { get; set; }

        bool HasOrderBennCompleted { get; }

        void ShipItem(CustomerModel customer); //signature line
    }
}

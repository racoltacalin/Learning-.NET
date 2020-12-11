using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibraries
{
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBennCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBennCompleted == false)
            {
                Console.WriteLine($"Added the { Title } course to { customer.FirstName }'s account.");
                HasOrderBennCompleted = true;
            }
        }
    }
}

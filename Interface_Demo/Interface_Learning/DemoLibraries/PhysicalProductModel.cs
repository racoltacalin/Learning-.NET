using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibraries
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBennCompleted { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBennCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City}");
                HasOrderBennCompleted = true;
            }
        }
    }
}

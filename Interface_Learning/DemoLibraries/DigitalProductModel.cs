using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibraries
{
    public class DigitalProductModel : IProductModel, IDigitalProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBennCompleted { get; private set; }
        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBennCompleted == false)
            {
                Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress}!");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBennCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}

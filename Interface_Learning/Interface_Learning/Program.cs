using System;
using System.Collections.Generic;
using System.Globalization;
using DemoLibraries;

namespace Interface_Learning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } download left!");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Calin",
                LastName = "Racolta",
                City = "Cluj-Napoca",
                StreetAddress = "Eugen Ionesco 67",
                EmailAddress = "racolta.xclain@hotmail.com",
                PhoneNumber = "0747633357"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            var output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "T-shirt with Clain.py" });
            output.Add(new PhysicalProductModel { Title = "Hard Driver" });
            output.Add(new DigitalProductModel { Title = "Leasson Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Core Start to Finish." });

            return output;
        }
    }
}
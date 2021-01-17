using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ.QUERIES
{
    public class JoiningDataWithLINQ
    {
        static void Main()
        {
            List<Category> categories = new List<Category>()
            {
                new Category {ID = 1, Name = "Fruit"},
                new Category {ID = 2, Name = "Food"},
                new Category {ID = 3, Name = "Shoe"},
                new Category {ID = 4, Name = "Juice"}
            };

            List<Product> products = new List<Product>()
            {
                new Product() {Name = "Strawberry", CategoryID = 1},
                new Product() { Name = "Banana", CategoryID = 1 },
                new Product() { Name = "Chicken meat", CategoryID = 2 },
                new Product() { Name = "Apple Juice", CategoryID = 4 },
                new Product() { Name = "Fish", CategoryID = 2 },
                new Product() { Name = "Orange Juice", CategoryID = 4 },
                new Product() { Name = "Sandal", CategoryID = 3 },
            };

            var productsWithCategories =
                from product in products
                join category in categories
                    on product.CategoryID equals category.ID
                select new
                {
                    Name = product.Name,
                    Category = category.Name
                };


            foreach (var item in productsWithCategories)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();


            var productsWithCategoriesNested =
                from product in products
                select new
                {
                    Name = product.Name,
                    Category =
                        (from category in categories
                         where category.ID == product.CategoryID
                         select category.Name).First()
                };

            foreach (var item in productsWithCategoriesNested)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine();

            List<int> l1 = new List<int>();
            DateTime startTime = DateTime.Now;
            l1.AddRange(Enumerable.Range(1, 50000000));
            Console.WriteLine("Ext.method:\t{0}", DateTime.Now - startTime);

            startTime = DateTime.Now;
            List<int> l2 = new List<int>();
            for (int i = 0; i < 50000000; i++)
            {
                l2.Add(i);
            }
            Console.WriteLine("For-loop:\t{0}", DateTime.Now - startTime);

            Console.WriteLine();
            Console.WriteLine();

            List<int> list = new List<int>();
            list.AddRange(Enumerable.Range(1, 100000));

            DateTime start = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                var elements = list.Where(e => e > 20000);
            }
            Console.WriteLine("No execution:\t{0}", DateTime.Now - start);

            start = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                var element = list.Where(e => e > 20000).First();
            }
            Console.WriteLine("Execution:\t{0}", DateTime.Now - start);
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal); // look like an interface

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public decimal GenerateTotal(MentionDiscount mentionSubtotal,
            Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal,
            Action<string> tellUserWeAreDiscounting)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionSubtotal(subTotal);

            tellUserWeAreDiscounting("We are applying your discount!");

            return calculateDiscountedTotal(Items, subTotal);
        }
    }
}

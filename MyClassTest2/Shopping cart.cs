using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassTest2
{
    public class Shopping_cart
    {
        private List<Product> Products;

        public Shopping_cart()
        {
            Products = new List<Product>();
        }

        public void ListProduct(Product product)
        {
            Products.Add(product);
        }

        public string viewShopping_cartWithAmount()
        {
            StringBuilder builder = new StringBuilder();

            decimal SubTotal = Calculations.CalculateSubTotal(Products);
            decimal SubTotalWithVat = Calculations.CalculateWithVat(Products);

            foreach (Product product in Products)
            {
                builder.AppendLine(product.ProductName + "  " + product.ProductPrice);
            }
           

            builder.AppendLine("Sub Total:   " + SubTotal);
            builder.AppendLine("With Vat:    " + SubTotalWithVat);
            

            return builder.ToString();
            // push or return out everything that is on string builder as a whole string
         }
    }
}
    


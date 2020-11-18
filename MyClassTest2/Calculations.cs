using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassTest2
{
    public class Calculations
    {
        public static decimal CalculateSubTotal(List<Product> calculationsProducts)
        {
            decimal amount = 0;
            foreach (Product product in calculationsProducts)
            {
                amount += product.ProductPrice;
            }

            return amount;

        }

        public static decimal CalculateWithVat(List<Product> calculationsProducts)
        {
            decimal subTotal = CalculateSubTotal(calculationsProducts);
            
            return subTotal * (100 + VAT.VatAmount) / 100;
            //calculating the subtotal with Vat
        }
    }
}



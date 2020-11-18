using System;

namespace MyClassTest2
{
    class Program
    {
        static void Main(string[] args)
        {
;           Shopping_cart data = new Shopping_cart();

            Product tvgame = new Product();
            tvgame.ProductName = "tvgame";
            tvgame.ProductPrice = 899.99M;
            data.ListProduct(tvgame);

            Product WifiRouter = new Product();
            WifiRouter.ProductName = "Huawei WifiRouter";
            WifiRouter.ProductPrice = 1299.99M;
            data.ListProduct(WifiRouter);

           
            Product Cellphone = new Product();
            Cellphone.ProductName = "Samsung Galaxy A8";
            Cellphone.ProductPrice = 1999.99M;
            data.ListProduct(Cellphone);


            string display = data.viewShopping_cartWithAmount();

            Console.WriteLine(display);
        }
    }
}

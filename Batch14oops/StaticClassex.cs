using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{

    //static class

    static class Product
    {

        //static member
        public static int Productid;
        public static string productname;
        public static int productPrice;

        //static constructor

        static Product()
        {
            Productid = 100;
            productname = "test";
            productPrice = 200;
        }
        //static method

        public static void GetProductdetails()
        {
            Console.WriteLine("Product id :{0}", Productid);

            Console.WriteLine("Product name :{0}", productname);

            Console.WriteLine("Product price :{0}", productPrice);
        }

        public static void GetDiscount()
        {
            int d_amount = productPrice/10;
            Console.WriteLine("Your discount amount is {0}", d_amount);
            Console.WriteLine("Total amount of product :{0}", (productPrice-d_amount));

        }
    

    }

    internal class StaticClassex
    {
        static void Main()
        {


            Product.GetProductdetails();
            Product.GetDiscount();
            Console.ReadLine();


        }
    }
}

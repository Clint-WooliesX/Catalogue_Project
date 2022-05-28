using System;
using System.Collections.Generic;

namespace CatalogueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Meat chops = new Meat("Pork CHops", 14.99, "Australian premium lean pork chops");

            Clothing tShirt = new Clothing("Tshirt", 15.00, "Cotton uni-sex T-Shirt");

            chops.PrintProduct();

            Tax.AdjustGST(.5);

            Console.WriteLine(chops.Gst);

            chops.PrintProduct();

            List<Product> Catalogue = new List<Product>();

            Catalogue.Add(chops);
            Catalogue.Add(tShirt);

            Console.WriteLine(Catalogue.ToString());
        }
    }
}

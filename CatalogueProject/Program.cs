using System;
using System.Collections.Generic;

namespace CatalogueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Meat chops = new Meat("Pork CHops", 14.99, "Australian premium lean pork chops");

            Clothing tShirt = new Clothing("Tshirt", 15.00, "Cotton uni-sex T-Shirt",14);

            Console.WriteLine(chops);

            Catalogue<Product> myCatalogue = new Catalogue<Product>();

            myCatalogue.Add(chops);
            myCatalogue.Add(tShirt);

            Console.WriteLine(myCatalogue[0]);
            Console.WriteLine(myCatalogue[1]);

            Clothing.NewProduct("Board Shorts", 10.00, "Mens cotton Board shorts blue and black", 36);

           myCatalogue.Add(Clothing.NewProduct("Board Shorts", 10.00, "Mens cotton Board shorts blue and black", 36));

            Console.WriteLine(myCatalogue[2]);

            Console.WriteLine(myCatalogue.ToArray()[1]);
        }
    }
}

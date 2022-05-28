using System;
namespace CatalogueProject
{
    public class Meat : Product
    {
        private double _storageTemp;
        public double Storagetemp { get { return _storageTemp; } }

        public Meat(string name, double price, string description, double temp=4, bool taxed =true)
        {
            ProductName = name;
            ProductPrice = price;
            ProductDescription = description;
            _storageTemp = temp;
            AttractsGST = taxed;
        }

        public override void PrintProduct()
        {
            {
                Console.WriteLine($" Product Name: {ProductName}");
                Console.WriteLine($"  Description: {ProductDescription}");
                Console.WriteLine($"        Price: {ProductPrice}");
                Console.WriteLine($"Total inc.Gst: {CalculateGST()}");
            }
        }
    }
}

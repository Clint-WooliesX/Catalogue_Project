using System;
namespace CatalogueProject
{
    public class Clothing : Product
    {
        private double _size;
        public double Storagetemp { get { return _size; } }

        public Clothing(string name, double price, string description, double size, bool taxed =true)
        {
            ProductName = name;
            ProductPrice = price;
            ProductDescription = description;
            _size = size;
            AttractsGST = taxed;
        }

    }
}

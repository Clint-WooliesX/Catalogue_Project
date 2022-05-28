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

        public override string ToString()
        {
            return $"Name:{ProductName}\n" +
                   $"Desc:{ProductDescription}\n" +
                   $"degC:{_storageTemp}\n" +
                   $"$/kg:{ProductPrice}\n"+
                   $"$gst:{CalculateGST()}\n";
        }

    }
}

using System;

namespace CatalogueProject
{
    public abstract class Product
    {
        private string _productName;
        public string ProductName { get { return _productName; } set { _productName = value; } }

        private string _productDescription;
        public string ProductDescription { get { return _productDescription; } set { _productDescription = value; } }

        private double _productPrice;
        public double ProductPrice { get { return _productPrice; } set { _productPrice = value; } }

        private bool _attractsGST;
        public bool AttractsGST { get { return _attractsGST; } set { _attractsGST = value; } }

        private Tax _gst = Tax.GST;
        public string Gst { get { return _gst.ToString(); } }

        public double CalculateGST()
        {
            return Math.Round(_productPrice *(1+Tax.ProductTax),2);
        }

        public virtual void PrintProduct()
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

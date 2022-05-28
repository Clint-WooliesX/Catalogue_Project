using System;
namespace CatalogueProject
{
    public class Tax
    {
        private static double _productTax = 0.1;
        public static double ProductTax { get { return _productTax; } set { _productTax = value; } }

        public static Tax GST = new Tax();

        public override string ToString()
        {
            return $"{_productTax*100}%";
        }

        public static void AdjustGST(double rate)
        {
            ProductTax = rate;
        }

    }
}

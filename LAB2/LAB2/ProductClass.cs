using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2
{
    class ProductClass
    {
        public string Name;
        public string BrandName;
        public double Price;
        public ProductClass(string xxx)
        {
            Name = xxx;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} \nBrandName: {BrandName} \nPrice: {Price}");
            

        }
    }
       

}

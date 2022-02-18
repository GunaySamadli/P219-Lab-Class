using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2
{
    class Vehicle
    {
        public string Color;
        public int Year;
        public virtual void ShowInfo() 
        {
            Console.WriteLine($"Reng: {Color}\n IL: {Year}");
        }
    }
}

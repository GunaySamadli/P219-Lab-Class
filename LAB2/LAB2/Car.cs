using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2
{
    class Car :Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
        public override void ShowInfo()
        {
            Console.WriteLine($"Reng: {Color}\n Il: {Year}\n Brand: {Brand} ");
        }
        public Car(string brand , string model) 
        {
            Brand = brand;
            Model = model;
        }
        public void ShowFuelinfo()
        {
            Console.WriteLine($"Capacity:{FuelCapacity} \n Current:{CurrentFuel} \n Range:{CurrentFuel/FuelFor1Km}km");
        }

        public void Drive(double km)
        {
            if ((CurrentFuel / FuelFor1Km) > km)
                Console.WriteLine("Gede bilersiniz");
            else
                Console.WriteLine("cendeki benzin kifayyet geder deyildir");
        }

        public bool AddFuel(double litr)
        {
            if (FuelCapacity >= (litr + CurrentFuel))
            {
                Console.WriteLine("elave ede bilersiniz");
                return true;
            }
            else
            {
                Console.WriteLine($"Cen dasacaq max elave ede bilersiniz {FuelCapacity - CurrentFuel} litr");
                return false;
            }
        }


    }
}

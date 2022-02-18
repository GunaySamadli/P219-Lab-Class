using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2
{
    class Doctor : Human
    {
        public int No;
        public string Speciality;
        public string Expierence;


        public Doctor(string gender) : base( gender)
        {

        }
        public override void  ShowInfo()
        {
            Console.WriteLine($"Name {Name}\n Surname {Surname} \n Gender {Gender} \n No {No} \n Speciality {Speciality} \n" +
                $"Epierence {Expierence}");

        }
        
    }
}

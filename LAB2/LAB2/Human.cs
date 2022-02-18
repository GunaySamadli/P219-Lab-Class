using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2
{
    class Human
    {
        public string Name;
        public string Surname;
        public string Gender;
        public Human(string gender)
        {
            Gender = gender;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name {Name}\n Surname {Surname} \n Gender {Gender}");
        }
    }
}

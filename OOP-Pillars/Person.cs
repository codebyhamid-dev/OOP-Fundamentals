using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pillars
{
    //------------------------------------encapsulation--------------------------------------//
    class Person
    {
        //Properties
        private string name;
        private int age;
        //getter and setter
        public string Name
        {
            get { return name; }
            set
                {
                    
                if (!string.IsNullOrEmpty(value) && !value.Any(char.IsDigit))
                {
                    name = value;
                }
                else
                {
                    name = "invalid";
                    Console.WriteLine("Name cant be empty not be integers");
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                    Console.WriteLine("Age cant be zer0 or negative");
                }
            }
        }
        //constructor
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        //method
        public virtual string Introduce()
        {
            return $"Hello my name is:{Name} and i am {age} years old";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pillars
{
    //---------------------------------------Inheritence----------------------------------//

    class Student:Person
    {
        protected int Id { get; set; }
        protected string School {  get; set; }
        protected string Grade {  get; set; }

        public Student(int id, string name, int age, string school, string grade):base(name,age)
        {
            Id = id;
            School = school;
            Grade = grade;
        }
        public override string Introduce()
        {
            return $"Student ID:{Id},student name:{Name},student age:{Age},student school:{School} and garde is:{Grade}";
        }
    }
}

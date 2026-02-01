using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pillars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------encapsulation-------------------------------------------//

            //Person person1 = new Person("", 12);
            //Console.WriteLine(person1.Introduce());
            //Person person2 = new Person("Fadi", 0);
            //Console.WriteLine(person2.Introduce());

            //-------------------------inheritence------------------------------------------------//
            //Student student1 = new Student(12, "Hamid", 22, "MUST", "B");
            //Console.WriteLine(student1.Introduce());
            //Student student2 = new Student(67, "Fahad", 22, "MUST", "F");
            //Console.WriteLine(student2.Introduce());

            //-------------------------Abstraction___________________________________________//
            //OnlineCourse onlineCourse = new OnlineCourse("Couseera", "Introduction To AI", 5);
            //OnCampusCourse onCampusCourse = new OnCampusCourse("12", "Introduction to C#", 2);
            //onlineCourse.DisplayCourseDetails();
            //onCampusCourse.DisplayCourseDetails();

            //OnsiteEmployee onsiteEmployee = new OnsiteEmployee("Onsite", 67, "John");
            //RemoteEmployee remoteEmployee = new RemoteEmployee("New Zealand", 45, "MArk");
            //onsiteEmployee.EmployeeDetails();
            //remoteEmployee.EmployeeDetails();

            //----------------------------PolyMorphism----------------------------------------//
            //Shape circle = new Circle(5);
            //Shape triangle = new Triangle(3, 6, 7);
            //Shape rectangle = new Rectangle(12, 10);
            //Console.WriteLine($"AREA of Cicle:{circle.CalculateArea()}");
            //Console.WriteLine($"AREA of TRiangle:{triangle.CalculateArea()}");
            //Console.WriteLine($"AREA of Reactangle:{rectangle.CalculateArea()}");

            //-----------------------------Interfaces-----------------------------------------//
            GraduateStudent gradStudent = new GraduateStudent(1, "John Doe", 25, "MIT", "A", "Basketball", "MIT Tigers", "AI Research");
            Console.WriteLine(gradStudent.Introduce());
            Console.WriteLine(gradStudent.GetAthleteInfo());

            Console.ReadKey();
        }
    }
}

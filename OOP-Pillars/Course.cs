using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pillars
{
    //------------------------------------Abstraction-----------------------------//
    abstract class Course
    {
        public string CourseName {  get; set; }
        public int Credits { get; set; }

        public Course(string courseName,int credits) { 
            CourseName = courseName;
            Credits = credits;
        }
        public abstract void DisplayCourseDetails(); 
    }
    class OnlineCourse : Course
    {
        public string Platform { get; set; }

        public OnlineCourse(string platform, string courseName, int credits) : base(courseName, credits)
        {
            Platform = platform;
        }
        public override void DisplayCourseDetails()
        {
            Console.WriteLine("For Online Courses");
            Console.WriteLine($"Course Name: {CourseName}, Credits: {Credits}, Platform: {Platform}");
        }
    }
    class OnCampusCourse : Course
    {
        public string RoomNumber { get; set; }

        public OnCampusCourse(string roomNumber,string courseName,int credits):base(courseName,credits)
        {
            RoomNumber = roomNumber;
        }
        public override void DisplayCourseDetails()
        {
            Console.WriteLine("For Offline Courses");
            Console.WriteLine($"Course Name: {CourseName}, Credits: {Credits}, Room Number: {RoomNumber}");
        }
    }
}

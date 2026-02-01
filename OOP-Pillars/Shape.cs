using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pillars
{
    //--------------------------------Polymorphism-----------------------------------//

    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) {
            Radius = radius;
        }
        public override double CalculateArea() { 
            return Math.PI * Radius*Radius;
        }
    }
    class Triangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Triangle(double width, double height, double length)
        {
            Width = width;
            Height = height;
            Length = length;
        }
        public override double CalculateArea() {
            return Length*Width*Height;
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateArea() { 
            return Width*Height;
        }
    }
}

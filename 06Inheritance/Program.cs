using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
    
    public abstract class ThreeDimensionFigure
    {
        protected string name;
        protected int  numberOfSides;
        protected int numberOfEdges;

        protected void DoSomething()
        {
            Console.WriteLine("");
        }
    }

    public abstract class TwoDimensionFigure
    {
        protected string name;
        protected int numberOfSides;
    }

    public interface ITwoDimension
    {
        double Area();
        double Perimeter();
    }

    public interface IThreeDimension
    {
        double Volume();
        double SurfaceArea();
    }

    public class Triangle : TwoDimensionFigure, ITwoDimension
    {
        public string Name
        {
            get { return this.name; }
        }

        public int NumberOfSides
        {
            get { return this.numberOfSides; }
        }

        public double SideA {get;set;}
        public double SideB { get; set; }
        public double SideC { get; set; }


        public Triangle(double sideA, double sideB, double sideC)
        {
            this.name = "Triangle";
            this.numberOfSides = 3;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        
        public double Area()
        {
            return 100; 
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }


    public class Rectangle : TwoDimensionFigure, ITwoDimension
    {
        public string Name
        {
            get { return this.name; }
        }

        public int NumberOfSides
        {
            get { return this.numberOfSides; }
        }

        public double Width { get; set; }
        public double Length { get; set; }


        public Rectangle(double width, double length)
        {
            this.name = "Rectangle";
            this.numberOfSides = 2;
            Width = width;
            Length = length;
        }

        public double Area()
        {
            return Width * Length;
        }

        public double Perimeter()
        {
            return Width + Length;
        }
    }
    


}

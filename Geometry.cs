using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_Polymorphism
{
    internal class Geometry
    {
        public virtual double Area() // Måste returnera något. Men jag vill inte att den ska returnera något.
        {                           // Men den måste ändå returna double eftersom arv-klasserna vill returna double
            return 1;         
        }
    }
    class Rectangle : Geometry
    {
        private double _side1; // Sätter till private för jag vill inte att användaren ska inputta nåt tokigt i Main
        private double _side2;
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        public double Side1 // Det här är en "Property"
        {
            get { return _side1; } // Vad gör denna rad?
            set
            { 
                if(value < 0) // Om användaren sätter en sida till mindre än 0 så ändras värdet till 0
                {
                    _side1 = 0;
                }
                else
                {
                    _side1 = value;
                }
            }
        }
        public double Side2
        {
            get { return _side2; }
            set
            {
                if (value < 0)
                {
                    _side2 = 0;
                }
                else
                {
                    _side2 = value;
                }
            }
        }
        public override double Area()
        {
            return _side1 * _side2;
        }
    }
    class Square : Geometry
    {
        private double _side;
        public Square(double side)
        {
            Side = side;
        }
        public double Side
        {
            get { return _side; }
            set
            {
                if (value < 0)
                {
                    _side = 0;
                }
                else
                {
                    _side = value;
                }
            }
        }
        public override double Area()
        {
            return _side * _side;
        }
    }
    class Circle : Geometry
    {
        private double _radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                {
                    _radius = 0;
                }
                else
                {
                    _radius = value;
                }
            }
        }
        public override double Area()
        {
            return _radius * _radius * Math.PI;
        }
    }
}

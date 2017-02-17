using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {

        public readonly Edge side1;
        public readonly Edge side2;
        public readonly Edge side3;
        double perimeter;
        double area;


        public Triangle(Point pointfirst, Point pointsecond, Point pointthird)
        {

            if (!Check(pointfirst, pointsecond, pointthird))
            {
                throw new TriangleNotExistException();
            }

            side1 = new Edge(pointfirst, pointsecond);
            side2 = new Edge(pointfirst, pointthird);
            side3 = new Edge(pointsecond, pointthird);

            perimeter = Perimeter;
            area = Area;
            CheckIsosceles();
            CheckRight();
        }



        private static bool Check(Point pointfirst, Point pointsecond, Point pointthird)
        {
            Edge edge1 = new Edge(pointfirst, pointsecond);
            Edge edge2 = new Edge(pointfirst, pointthird);
            Edge edge3 = new Edge(pointsecond, pointthird);

            if ((edge1.Lenght + edge2.Lenght > edge3.Lenght) || (edge2.Lenght + edge3.Lenght > edge1.Lenght) || (edge1.Lenght + edge3.Lenght > edge2.Lenght))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private class TriangleNotExistException : Exception
        {
            public void Messege
            {
                get
                {
                    Console.WriteLine("Такой треугольник не может существовать!");
                }
            }
        }

        public double Perimeter
        {
           get
           {
             perimeter = side1.Lenght + side2.Lenght + side3.Lenght;
             return perimeter;
           }
        }     
        
              
        public double Area
        {
            get
            {
                double halfofperimeter = perimeter / 2;
                area = Math.Sqrt(halfofperimeter * (halfofperimeter - side1.Lenght) * (halfofperimeter - side2.Lenght) * (halfofperimeter * side3.Lenght));
                return area;
            }
        }

        public bool CheckIsosceles()
        {
            return ((side1.Lenght == side2.Lenght) || (side1.Lenght == side3.Lenght) || (side2.Lenght == side3.Lenght));
        }


        public bool CheckRight()
        {

            return ((side1.Lenght * side1.Lenght == side2.Lenght * side2.Lenght + side3.Lenght * side3.Lenght) || (side2.Lenght * side2.Lenght == side1.Lenght * side1.Lenght + side2.Lenght * side2.Lenght)
                || (side3.Lenght * side3.Lenght == side2.Lenght * side2.Lenght + side1.Lenght * side1.Lenght));

        }
       
        public static bool operator == (Triangle a, Triangle b)
        {
            return a.side1.Lenght == b.side1.Lenght && a.side2.Lenght == b.side2.Lenght ||
                   a.side1.Lenght == b.side2.Lenght && a.side2.Lenght == b.side1.Lenght ||
                   a.side3.Lenght == b.side3.Lenght && a.side2.Lenght == b.side2.Lenght ||
                   a.side3.Lenght == b.side2.Lenght && a.side2.Lenght == b.side3.Lenght ||
                   a.side1.Lenght == b.side1.Lenght && a.side3.Lenght == b.side3.Lenght ||
                   a.side1.Lenght == b.side3.Lenght && a.side3.Lenght == b.side1.Lenght;
        }

        public static bool operator != (Triangle a, Triangle b)
        {
            return !(a == b);
        }     
    }
}

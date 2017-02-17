using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Averagevalue
    {
        double totalarea = 0, totalperimeter = 0, averagearea = 0, averageperimeter = 0;
        int areacount = 0;
        int perimetercount = 0;

        public void Average()
        {
            Triangle[] triangles = Reader.Read("Points.txt");
            for (int i = 0; i < triangles.Length; i++)
            {
                if (triangles[i].CheckIsosceles())
                {
                    totalarea = totalarea + triangles[i].Area;
                    areacount++;
                }

                if (triangles[i].CheckRight())
                {
                    totalperimeter = totalperimeter + triangles[i].Perimeter;
                    perimetercount++;
                }
            }

            averagearea = totalarea / areacount;
            Console.WriteLine("Средняя площадь равнобедренных треугольников: " + averagearea);

            averageperimeter = totalperimeter / perimetercount;
            Console.WriteLine("Средний периметр прямоугольных треугольников: " + averageperimeter);          
        }            
    }
}

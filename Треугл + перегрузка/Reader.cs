using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Triangle
{
    class Reader
    {
        public static Triangle[] Read(string filename)
        {

            double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0;
            Char delimiter = ' ';

            string[] Lines = File.ReadAllLines(filename);
            Triangle[] trianglemass = new Triangle[Lines.Length];

            for (int i = 0; i < Lines.Length; i++)
            {
                string s = Lines[i];
                string[] substrings = s.Split(delimiter);
                x1 = Convert.ToDouble(substrings[0]);
                y1 = Convert.ToDouble(substrings[1]);
                x2 = Convert.ToDouble(substrings[2]);
                y2 = Convert.ToDouble(substrings[3]);
                x3 = Convert.ToDouble(substrings[4]);
                y3 = Convert.ToDouble(substrings[5]);

                Point point1 = new Point(x1, y1);
                Point point2 = new Point(x2, y2);
                Point point3 = new Point(x3, y3);

                Triangle temp = new Triangle(point1, point2, point3);
                trianglemass[i] = temp;
            }
            return trianglemass;
        }

    } 
}

    
    

       
    
   


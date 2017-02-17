using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        public readonly Point First;
        public readonly Point Second;
        public double lenght;

        public Edge(Point pointfirst, Point pointsecond) 
        {
            First = pointfirst;
            Second = pointsecond;
            lenght = GetEdgeLenght();
        }

        public static bool operator ==(Edge a, Edge b)
        {
            return a.First == b.First && a.Second == b.Second ||
                   a.First == b.Second && a.Second == b.First;
        }

        public static bool operator !=(Edge a, Edge b)
        {
            return !(a.First == b.First && a.Second == b.Second ||
                     a.First == b.Second && a.Second == b.First);
        }


        private double GetEdgeLenght() 
        {
            return lenght = Math.Sqrt(Math.Pow((Second.X - First.X), 2) + Math.Pow((Second.Y - First.Y), 2));
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
        }
    }
}

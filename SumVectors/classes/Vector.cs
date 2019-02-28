using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumVectors.classes
{
    public class Vector : Point
    {
        public Point Origin { get; set; }

        public Vector(int x,int y)
        {
            Origin = new Point();
            Origin.X = 0;
            Origin.Y = 0;
            this.X = x;
            this.Y = y;
        }
        public static Vector operator + (Vector obj1,Vector obj2)
        {
            return new Vector(obj1.X + obj2.X,obj1.Y + obj2.Y);
        }
        public static int operator * (Vector obj1, Vector obj2)
        {
            return obj1.X * obj1.Y + obj2.X * obj2.Y;
        }
        public Vector Add(Vector vector)
        {
            return this + vector;
        }
        public int Prop(Vector vector)
        {
            return this * vector;
        }
        public double Length()
        {
            double resultPropX = Math.Pow(this.X,2);
            double resultPropY = Math.Pow(this.Y, 2);
            double resultAddXY = resultPropX + resultPropY;
            double resultLength = Math.Sqrt(resultAddXY);
            return resultLength;
        }
        public override string ToString()
        {
            return $"[{this.X},{this.Y}]";
        }
    }
}

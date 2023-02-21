using System.Security.Cryptography;

namespace bai2
{
    class TPoint
    {
        private float x, y;
        public float X
        {
            get { return x; }
            set { x = value;}
        }
        public float Y
        {
            get { return y; }
            set { y = value;}
        }
        public TPoint()
        {
            x = 0;
            y = 0;
        }
        public TPoint(float tx, float ty)
        {
            x = tx; 
            y = ty;
        }
        public void display()
        {
            Console.WriteLine("({0}),({1})", x, y);
        }
    }
    class Tractangel : TPoint
    {
        private float w, h;
        public float W
        {
            get { return w; }
            set { w = value; }
        }
        public float H
        {
            get { return h; }
            set { h = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tractangel h1 = new Tractangel();
            h1.X = 1;
            h1.Y = 2;
            h1.W = 3;
            h1.H = 4;
            h1.display();
        }
        
    }
}
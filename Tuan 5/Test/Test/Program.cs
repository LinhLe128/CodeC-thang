namespace Test
{
    class Point
    {
        private int x = 0;
        private int y = 0;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1,2);
            Point p1 = new Point(1, 2);
        }
    }
}
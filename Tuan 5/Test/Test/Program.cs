namespace Test
{
    class A
    {
        public int x = 10;
        public void display() 
        { 
            Console.WriteLine(this.x);
        }
    }
    class B : A{
        public int x = 20;
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A b = new B();
            b.display();
        }
    }
}
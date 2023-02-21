namespace test
{
    class Franction
    {
        private int ts, ms;
        public int TS
        {
            get { return ts; }
            set { ts = value; }
        }
        public int MS {
            get { return ms; }
            set { ms = (value == 0) ? 1 : value; }
        }
        public Franction()
        {
            ts = 0;
            ms = 1;
        }
        public Franction(int tts, int tms)
        {
            ts = tts;
            ms = tms;
        }
        public void display()
        {
            Console.WriteLine("{0}/{1}", ts, ms);
        }
        public static Franction operator +(Franction ta, Franction tb)
        {
            Franction kq = new Franction();
            kq.ts = ta.ts * tb.ms + ta.ms * tb.ms;
            kq.ms = ta.ms + tb.ms;
            return kq;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Franction ps1 = new Franction();
            Franction ps2 = new Franction(2, 3);
            Franction ps3 = new Franction();
            
            ps1.display();
            ps2.display();

            ps3 = ps1 + ps2;
            ps3.display();
        }
    }
}
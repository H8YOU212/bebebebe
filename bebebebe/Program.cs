using System.Security.Cryptography.X509Certificates;

namespace bebebebe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.MainM();
        }

        public void MainM()
        {
            Console.WriteLine("Введите значение x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(F(x, y));
        }

        public int F(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        public void MainM2()
        {
            double a = Convert.ToDouble(Console.ReadLine()); 
            double b = Convert.ToDouble(Console.ReadLine()); 
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(D(a, b, c));
        }
        public double D(double a, double b, double c)
        {
            double dis = Math.Pow(b, 2) - 4 * a * c;
            return dis;
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уравнение вида kx+b=0");
            bool endApp;

            do
            {
                try
                {
                    Console.Write("\nВведите k: ");
                    double k = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите b: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Linear linear = new Linear(k, b);
                    Console.WriteLine(linear.Root());
                    endApp = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    endApp = false;
                }
            } while (!endApp);
            Console.ReadKey();
        }
    }
}

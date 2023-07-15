using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926;
            double  dRadyan = 0;

            Console.WriteLine("Dereceyi Giriniz:");
            double dDerece = Convert.ToDouble(Console.ReadLine());
            dRadyan = PI / 180 * dDerece;
            System.Console.WriteLine("{0} derece = {1} radyandır.", dDerece, dRadyan);
            System.Console.ReadLine();

        }
    }
}

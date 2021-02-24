using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            EcuatieSiDistanta();
        }

        private static void EcuatieSiDistanta()
        {
            int xa, ya, xb, yb, a, b, c;

            Console.WriteLine("Introduceti xa si ya");
            xa = int.Parse(Console.ReadLine());
            ya = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti xb si yb");
            xb = int.Parse(Console.ReadLine());
            yb = int.Parse(Console.ReadLine());

            a = ya - yb;
            b = xa - xb;
            c = (xa * yb) - (xb * ya);

            float a1 = (xb - xa) * (xb - xa);
            float b1 = (yb - ya) * (yb - ya);
            float c1 = a1 + b1;
            double lung = Math.Sqrt(c1);

            if (b < 0 && c > 0)
            {
                Console.WriteLine($"AB:{a}x + {-b}y + {c} = 0");
            }
            if (b > 0 && c < 0)
            {
                Console.WriteLine($"AB:{a}x - {b}y {c} = 0");
            }
            if (b > 0 && c > 0)
            {
                Console.WriteLine($"AB:{a}x - {b}y + {c} = 0");
            }
            if (b < 0 && c < 0)
            {
                Console.WriteLine($"AB:{a}x + {-b}y {c} = 0");
            }
            Console.WriteLine($"|AB|:{lung}");
        }
    }
}

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
            //EcuatieSiDistanta();
            //Coliniare();
            //Concurenta();
        }

        private static void Concurenta()
        {
            double a1, b1, c1, a2, b2, c2, a3, b3, c3, rez;

            Console.WriteLine("Introduceti a1, b1, c1");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            c1 = double.Parse(Console.ReadLine());

            if (b1 < 0 && c1 > 0)
            {
                Console.WriteLine($"d1:{a1}x {b1}y + {c1} = 0");
            }
            if (b1 > 0 && c1 < 0)
            {
                Console.WriteLine($"d1:{a1}x + {b1}y {c1} = 0");
            }
            if (b1 > 0 && c1 > 0)
            {
                Console.WriteLine($"d1:{a1}x + {b1}y + {c1} = 0");
            }
            if (b1 < 0 && c1 < 0)
            {
                Console.WriteLine($"d1:{a1}x {b1}y {c1} = 0");
            }
            Console.WriteLine();

            Console.WriteLine("Introduceti a2, b2, c2");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            c2 = double.Parse(Console.ReadLine());

            if (b2 < 0 && c2 > 0)
            {
                Console.WriteLine($"d2:{a2}x {b2}y + {c2} = 0");
            }
            if (b2 > 0 && c2 < 0)
            {
                Console.WriteLine($"d2:{a2}x + {b2}y {c2} = 0");
            }
            if (b2 > 0 && c2 > 0)
            {
                Console.WriteLine($"d2:{a2}x + {b2}y + {c2} = 0");
            }
            if (b2 < 0 && c2 < 0)
            {
                Console.WriteLine($"d2:{a2}x {b2}y {c2} = 0");
            }
            Console.WriteLine();

            Console.WriteLine("Introduceti a3, b3, c3");
            a3 = double.Parse(Console.ReadLine());
            b3 = double.Parse(Console.ReadLine());
            c3 = double.Parse(Console.ReadLine());

            if (b3 < 0 && c3 > 0)
            {
                Console.WriteLine($"d3:{a3}x {b3}y + {c3} = 0");
            }
            if (b3 > 0 && c3 < 0)
            {
                Console.WriteLine($"d3:{a3}x + {b3}y {c3} = 0");
            }
            if (b3 > 0 && c3 > 0)
            {
                Console.WriteLine($"d3:{a3}x + {b3}y + {c3} = 0");
            }
            if (b3 < 0 && c3 < 0)
            {
                Console.WriteLine($"d3:{a3}x {b3}y {c3} = 0");
            }
            Console.WriteLine();

            rez = a1 * b2 * c3 + a2 * b3 * c1 + b1 * c2 * a3 - (c1 * b2 * a3) - (c2 * b3 * a1) - (a2 * b1 * c3);

            if (rez == 0)
            {
                Console.WriteLine("Sunt concurente");
            }
            else
            {
                Console.WriteLine("Nu sunt concurente");
            }
        }

        private static void Coliniare()
        {
            int xa, ya, xb, yb, xc, yc, rez;

            Console.WriteLine("Introduceti xa si ya");
            xa = int.Parse(Console.ReadLine());
            ya = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti xb si yb");
            xb = int.Parse(Console.ReadLine());
            yb = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti xc si yc");
            xc = int.Parse(Console.ReadLine());
            yc = int.Parse(Console.ReadLine());

            rez = xa * yb + xb * yc + ya * xc - xc * yb - yc * xa - xb * ya;

            if (rez == 0)
            {
                Console.WriteLine("Sunt coliniare");
            }
            else
            {
                Console.WriteLine("Nu sunt coliniare");
            }
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

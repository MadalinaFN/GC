using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProdusScalar();
            //ProdusVectorial();
            //ProdusMixt();
        }

        private static void ProdusMixt()
        {
            double produs, volum, x1, x2, y1, y2, z1, z2, x3, y3, z3;

            Console.WriteLine("Introduceti x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z1");
            z1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (y1 < 0 && z1 > 0)
            {
                Console.WriteLine($"v1 = {x1}i {y1}j + {z1}k");
            }
            if (y1 > 0 && z1 < 0)
            {
                Console.WriteLine($"v1 = {x1}i + {y1}j {z1}k");
            }
            if (y1 > 0 && z1 > 0)
            {
                Console.WriteLine($"v1 = {x1}i + {y1}j + {z1}k");
            }
            if (y1 < 0 && z1 < 0)
            {
                Console.WriteLine($"v1 = {x1}i {y1}j {z1}k");
            }
            Console.WriteLine();

            Console.WriteLine("Introduceti x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y2");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z2");
            z2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (y2 < 0 && z2 > 0)
            {
                Console.WriteLine($"v2 = {x2}i {y2}j + {z2}k");
            }
            if (y2 > 0 && z2 < 0)
            {
                Console.WriteLine($"v2 = {x2}i + {y2}j {z2}k");
            }
            if (y2 > 0 && z2 > 0)
            {
                Console.WriteLine($"v2 = {x2}i + {y2}j + {z2}k");
            }
            if (y2 < 0 && z2 < 0)
            {
                Console.WriteLine($"v2 = {x2}i {y2}j {z2}k");
            }
            Console.WriteLine();

            Console.WriteLine("Introduceti x3");
            x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y3");
            y3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z3");
            z3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (y3 < 0 && z3 > 0)
            {
                Console.WriteLine($"v3 = {x3}i {y3}j + {z3}k");
            }
            if (y3 > 0 && z3 < 0)
            {
                Console.WriteLine($"v3 = {x3}i + {y3}j {z3}k");
            }
            if (y3 > 0 && z3 > 0)
            {
                Console.WriteLine($"v3 = {x3}i + {y3}j + {z3}k");
            }
            if (y3 < 0 && z3 < 0)
            {
                Console.WriteLine($"v3 = {x3}i {y3}j {z3}k");
            }
            if (y3 > 0 && z3 == 0)
            {
                Console.WriteLine($"v3 = {x3}i + {y3}j");
            }
            Console.WriteLine();

            produs = x1 * y2 * z3 + x2 * y3 * z1 + y1 * z2 * x3 - z1 * y2 * x3 - y1 * x2 * z3 - z2 * y3 * x1;
            Console.WriteLine($"Produs = {produs}");
            Console.WriteLine();

            volum = produs;
            if (volum > 0)
            {
                Console.WriteLine($"Volum = {volum}");
            }
            if (volum < 0)
            {
                Console.WriteLine($"Volum = {-volum}");
            }
            if (volum == 0)
            {
                Console.WriteLine($"Volum = {volum}");
            }
            Console.WriteLine();

            if (produs == 0)
            {
                Console.WriteLine("Sunt coplanari");
            }
            else
            {
                Console.WriteLine("Nu sunt coplanari");
            }
            Console.WriteLine();
        }

        private static void ProdusVectorial()
        {
            double produs, x1, x2, y1, y2, z1, z2, i, j, k, j1;

            Console.WriteLine("Introduceti x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z1");
            z1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Introduceti x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y2");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z2");
            z2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            i = y1 * z2 - z1 * y2;
            j1 = x1 * z2 - z1 * x2;
            j = -j1;
            k = x1 * y2 - y1 * x2;

            if (j < 0 && k > 0)
            {
                Console.WriteLine($"produs = {i}i {j}j + {k}k");
            }
            if (j > 0 && k < 0)
            {
                Console.WriteLine($"produs = {i}i + {j}j {k}k");
            }
            if (j > 0 && k > 0)
            {
                Console.WriteLine($"produs = {i}i + {j}j + {k}k");
            }
            if (j < 0 && k < 0)
            {
                Console.WriteLine($"produs = {i}i {j}j {k}k");
            }
            Console.WriteLine();

            if (i == 0 && j == 0 && k == 0)
            {
                produs = 0;
                Console.WriteLine($"produs = {produs} ");
            }
            else
            {
                produs = 1;
            }

            if (produs == 0)
            {
                Console.WriteLine("Sunt coliniari");
            }
            else
            {
                Console.WriteLine("Nu sunt coliniari");
            }
            Console.WriteLine();

            Console.WriteLine($"Aria: {Math.Sqrt(i * i + j * j + k * k)}");
        }

        private static void ProdusScalar()
        {
            double produs, x1, x2, y1, y2, z1, z2;

            Console.WriteLine("Introduceti x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z1");
            z1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (y1 < 0 && z1 > 0)
            {
                Console.WriteLine($"v1 = {x1}i {y1}j + {z1}k");
            }
            if (y1 > 0 && z1 < 0)
            {
                Console.WriteLine($"v1 = {x1}i + {y1}j {z1}k");
            }
            if (y1 > 0 && z1 > 0)
            {
                Console.WriteLine($"v1 = {x1}i + {y1}j + {z1}k");
            }
            if (y1 < 0 && z1 < 0)
            {
                Console.WriteLine($"v1 = {x1}i {y1}j {z1}k");
            }
            Console.WriteLine();

            Console.WriteLine("Introduceti x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y2");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z2");
            z2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (y2 < 0 && z2 > 0)
            {
                Console.WriteLine($"v2 = {x2}x {y2}y + {z2}");
            }
            if (y2 > 0 && z2 < 0)
            {
                Console.WriteLine($"v2 = {x2}x + {y2}y {z2}");
            }
            if (y2 > 0 && z2 > 0)
            {
                Console.WriteLine($"v2 = {x2}x + {y2}y + {z2}");
            }
            if (y2 < 0 && z2 < 0)
            {
                Console.WriteLine($"v2 = {x2}x {y2}y {z2}");
            }
            Console.WriteLine();

            produs = x1 * x2 + y1 * y2 + z1 * z2;
            Console.WriteLine($"Produsul este: {produs}");
            Console.WriteLine();

            if (produs == 0)
            {
                Console.WriteLine("Sunt perpendiculari");
            }
            else
            {
                Console.WriteLine("Nu sunt perpendiculari");
            }
            Console.WriteLine();

            Console.WriteLine($"Marimea v1: {Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1)}");
            Console.WriteLine($"Marimea v2: {Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2)}");
        }
    }
}

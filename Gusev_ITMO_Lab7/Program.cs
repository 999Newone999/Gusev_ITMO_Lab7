using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, s1, s2;
            InputTreangleSizes("первого", out x, out y, out z);
            s1 = SquareTriangular(x,y,z);

            InputTreangleSizes("второго", out x, out y, out z);
            s2 = SquareTriangular(x, y, z);

            if (s1 > s2)
            { 
                Console.WriteLine("Площадь первого треугольника больше площади второго");
            }
            else if (s1 < s2)
            {
                Console.WriteLine("Площадь первого треугольника меньше площади второго");
            }
            else
            {
                Console.WriteLine("Площадь первого треугольника равна площади второго");
            }
            Console.ReadKey();
        }

        static double SquareTriangular(double x, double y, double z)
        {
            double p, S;
            p = (x + y + z) / 2;
            S = Math.Sqrt((p*(p-x)*(p-y)*(p-z)));
            return S;
        }

        static void InputTreangleSizes(string numberOfTriangle, out double x, out double y, out double z)
        {
            bool inputNotOk = true;
            do
            {
                Console.WriteLine("Введите стороны {0} треугольника:", numberOfTriangle);
                Console.Write("x = ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y = ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("z = ");
                z = Convert.ToDouble(Console.ReadLine());
                if ((x < y + z) && (y < x + z) && (z < x + y))
                {
                    inputNotOk = false;
                }
                else
                {
                    Console.WriteLine("Каждая сторона треугольника должна быть меньше суммы двух других сторон");
                }
            } while (inputNotOk == true);
        
        }
    }
}

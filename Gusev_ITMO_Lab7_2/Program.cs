using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeEdge;
            Console.Write("Введите длину ребра куба: ");
            cubeEdge= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь поверхности куба: {0}", CubeSquare(cubeEdge));
            Console.WriteLine("Объем куба: {0}", CubeVolume(cubeEdge));
            Console.ReadKey();
        }
        static double CubeSquare(double cubeEdge)
        {
            return cubeEdge * cubeEdge * 6;
        }
        static double CubeVolume(double cubeEdge)
        {
            return cubeEdge * cubeEdge * cubeEdge;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы
{ 
    class Program //Расчет площадей треугольников и сравнение их
    {
        public struct Triangle
        {
            public double a, b, c;
            public double Square()
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
        }
        static void Main()
        {
            Triangle[] triagles = new Triangle[2];
            for (int i = 0; i < triagles.Length; i++)
            {
                Console.WriteLine("Введите длины (a,b,c) сторон треугольника {0}", i + 1);
                Console.WriteLine("Введите a");
                triagles[i].a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
                triagles[i].b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите c");
                triagles[i].c = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < triagles.Length; i++)
            {
                Console.WriteLine("Площадь {0}-го треугольника = {1}", i + 1, triagles[i].Square());
            }
            int maxS = 0;
            for (int i = 1; i < triagles.Length; i++)
            {
                if (triagles[i].Square() > triagles[maxS].Square())
                    maxS = i;
            }
            Console.WriteLine("Макс площадь у {0}-го треугольника", maxS + 1);

            Console.ReadKey();
        }
    }
}
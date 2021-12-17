using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы_7._2 // Расчет объема и площади поверхности куба по длине его ребра.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну ребра куба:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Обьем куба:" + Math.Pow(a, 3)); //объем куба
            Console.WriteLine("Площадь поверхности:" + Math.Pow(a, 2) * 6);//площать стороны куба
            Console.ReadLine();
        }
    }
}

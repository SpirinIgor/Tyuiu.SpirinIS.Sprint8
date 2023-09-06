using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SpirinIS.Sprint0.Task0.V0.Lib;

namespace Tyuiu.SpirinIS.Sprint0.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите значение переменной Х:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            int y = Convert.ToInt32(Console.ReadLine());


            var result = ds.Culc(x, y);

            Console.WriteLine("Результат X+Y = " + result);
            Console.WriteLine("Результат X+Y = " + result);
            Console.WriteLine("Результат X+Y = " + result);

            Console.ReadKey();

        }
    }
}

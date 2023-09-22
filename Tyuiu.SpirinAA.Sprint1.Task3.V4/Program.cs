using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SpirinAA.Sprint1.Task3.V4.Lib; 

namespace Tyuiu.SpirinAA.Sprint1.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Спирин А. А. | АСОиУб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Спирин Александр Алексеевич | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости покупки, состоящей              *");
            Console.WriteLine("* из нескольких тетрадей и такого же количества обложек к ним.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;

            Console.WriteLine("Цена тетради (руб.) ->");
            x = Convert.ToDouble(Console.ReadLine());

            double y;

            Console.WriteLine("Цена обложки (руб.) ->");
            y = Convert.ToDouble(Console.ReadLine());

            int z;

            Console.WriteLine("Количество комплектов (шт.) ->");
            z = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Стоимость покупки:" + ds.PurchaseAmount(x, y, z));
            Console.ReadLine();
        }
    }
}

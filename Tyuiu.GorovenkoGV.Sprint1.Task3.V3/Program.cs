using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorovenkoGV.Sprint1.Task3.V3.Lib;

namespace Tyuiu.GorovenkoGV.Sprint1.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Горовенко Г.В. | ПКТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Горовенко Глеб Васильевич | ПКТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            double length = 9;
            double width = 7.5;
            double height = 5;

            Console.WriteLine("Длина параллелепипеда (см) ->" + length);
            Console.WriteLine("Длина параллелепипеда (см) ->" + width);
            Console.WriteLine("Длина параллелепипеда (см) ->" + height);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Объема параллелепипеда = " + ds.ParallelepipedVolume(length, width, height));

            Console.ReadKey();
        }
    }
}

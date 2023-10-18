using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorovenkoGV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.GorovenkoGV.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Горовенко Г.В. | ПКТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Горовенко Глеб Васильевич | ПКТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h) прошло     *");
            Console.WriteLine("* к этому моменту                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int time;

            Console.WriteLine("Ввести значения time :");
            time = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = Convert.ToDouble(ds.SecondsToHours(time));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

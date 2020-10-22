using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RipeCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double radius;
            List<double> radiusList = new List<double>();//Колличество окружностей определяем по количеству различных радиусов

            Console.Write("Enter the number of points: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the coordinates of {count} points: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}'st Point: ");
                
                Console.Write($"x = ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write($"y = ");
                y = Convert.ToInt32(Console.ReadLine());

                radius = Math.Sqrt(x * x + y * y);//Ищем радиус окружности для данной точки
                double ExistRadius = radiusList.FirstOrDefault(x => Math.Abs(x - radius) < 0.01);

                if (ExistRadius == 0)//если Радиуса такой длинны нет в списке то добавляем его
                    radiusList.Add(radius);
            }
            Console.WriteLine(radiusList.Count);// выводим колличество различных радиусов

        }
    }
}

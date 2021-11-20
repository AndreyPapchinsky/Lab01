using System;

namespace ExerciseNumber5
{
    class Lab01
    {
        static void Main(string[] args)
        {

            try
            {
                double p2;
                Console.WriteLine("Введите значение периметра равностороннего треугольника: ");
                p2 = double.Parse(Console.ReadLine());

                double a = p2 / 3;
                Console.WriteLine("Сторона треугольника: ");
                Console.WriteLine("{0:F2}", a);

                double p = p2 / 2;
                double S = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
                Console.WriteLine("Площадь равностороннего треугольника: ");
                Console.WriteLine("{0:F2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
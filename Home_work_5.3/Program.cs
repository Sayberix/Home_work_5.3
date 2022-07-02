using System;

namespace Home_work_5._3
{
    class Program
    {   // Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
        static void Main(string[] args)
        {
            int [] x = new int[2];
            int [] y = new int[2];
            int [] z = new int[2];
            for(int i=0; i<=1; i++)
            { 
                Console.Write($"Введите координату точки X{i}: ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Введите координату точки Y{i}: ");
                y[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Введите координату точки Z{i}: ");
                z[i] = Convert.ToInt32(Console.ReadLine());
            }
            double distance = Math.Round(Math.Sqrt(Math.Pow(x[1]-x[0],2) + Math.Pow(y[1]-y[0],2) + Math.Pow(z[1]-z[0],2)),2);
            Console.WriteLine($"Расстояние между точками: {distance}");
        }
    }
}

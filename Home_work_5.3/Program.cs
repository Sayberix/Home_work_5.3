using System;

namespace Home_work_5._3
{
    class Program
    {   // Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для количества элементов в таблице кубов: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                if (i != N)     // Условие для красивого вывода значений через запятую )
                    Console.Write(Math.Pow(i,3) + ", ");
                else
                    Console.Write(Math.Pow(i,3));

            }
        }
    }
}

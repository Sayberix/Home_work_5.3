using System;

namespace Home_work_5._3
{
    class Program
    {   // Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
        static void Main(string[] args)
        {
            int [] arr = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Введите элемент массива под номером: {i} ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}

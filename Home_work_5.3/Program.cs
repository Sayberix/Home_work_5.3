using System;

namespace Home_work_5._3
{
    class Program
    {   // Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
        static void Main(string[] args)
        {
            Console.Write("Введите пятизначное число: ");
            string number = Console.ReadLine();
            //Console.WriteLine($"Массив из string равен: {number[1]}");
            if(number[0] == number[4] && number[1] == number[3])
                Console.WriteLine($"Введенное число {number} - являеся палиндромом!");
            else
                Console.WriteLine($"Введенное число {number} - НЕ являеся палиндромом!");
        }
    }
}

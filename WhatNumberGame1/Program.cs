using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatNumberGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            //задаем переменную для генерации случайного числа и для числа пользователя
            int number;
            int userNumber;
            Random random = new Random();

            //процесс загадывания числа от 1 до 10
            number = random.Next(1, 10 + 1); //открытый интервал, 10 не вернет, добавим +1
            do
            {
                //выводим сообщение для пользователя
                Console.WriteLine("Введите число");
                //преобразовываем строку в число и записываем ее в переменную
                userNumber = int.Parse(Console.ReadLine());

                //проверяем равенство
                if (userNumber == number)
                {
                    Console.WriteLine("Верно");
                }
                //если не равны
                else
                {
                    //проверяем больше/меньше
                    if (number > userNumber)
                    {
                        Console.WriteLine("Загаданное число больше!");
                    }
                    else
                    {
                        Console.WriteLine("Загаданное число меньше!");
                    }

                }
            } while (userNumber != number); 
            
            Console.ReadLine();
        }
    }
}



using Tyuiu.BurdovKS.Sprint4.Task0.V15.Lib;

using System;


    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10                               *");
        Console.WriteLine("* элементов заполненный статическими значениями в диапазоне от 0 до 9     *");
        Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");





        int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            
            int product = 1;
            foreach (int number in array)
            {
                if (number % 2 != 0) 
                {
                    product *= number; 
                }
            }

            Console.WriteLine("Произведение нечетных элементов массива: " + product);
            Console.ReadKey();
        }
    }


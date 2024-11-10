

using Tyuiu.BurdovKS.Sprint4.Task1.V24.Lib;

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
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов                     *");
        Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до 5               *");
        Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int size = 16;


        int[] array = new int[size];


        int product = 1;

        foreach (int i in array)
        {
            if  (i % 2 != 0)
            {
                product *= i;

            }
        }


   
  




        Console.WriteLine("Произведение нечетных элементов массива: " + product);
        Console.ReadKey();
    }
}


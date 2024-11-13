﻿

using Tyuiu.BurdovKS.Sprint4.Task7.V11.Lib;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();



        Console.Title = "Спринт #4 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр 56789012 Преобразуйте ее в            *");
        Console.WriteLine("* матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int n = 4;
        int m = 2;
        int[,] mtrx = new int[n, m];

        string str = "56789012";



        int index = 0;

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;

            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int res = ds.Calculate(n, m, str);

        Console.WriteLine("Количество нечетных элементов = " + res);
        Console.ReadKey();










    }
}




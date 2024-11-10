


using Tyuiu.BurdovKS.Sprint4.Task3.V20.Lib;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        

        Console.Title = "Спринт #4 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
        Console.WriteLine("* заполненный статическими значениями в диапазоне от 3 до 8.              *");
        Console.WriteLine("* Найдите минимальный элемент в первом столбце массива.                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = new int[5, 5] {
                {8,7,7,8,5 },
                {4,3,5,3,6 },
                {5,3,8,6,3 },
                {6,3,8,5,4,},
                {3,6,8,3,4 }};

        int res = ds.Calculate(array);


        int rows = array.GetUpperBound(0) + 1;

        int colum = array.Length / rows;




        int minElement = array[0, 0];

        for (int i = 1; i < array.GetLength(0); i++)
        {
            if (array[i, 0] < minElement)
            {
                minElement = array[i, 0];
            }
        }


        Console.WriteLine("Минимальное число в столбце: " + minElement);
        Console.ReadKey();
    }
}
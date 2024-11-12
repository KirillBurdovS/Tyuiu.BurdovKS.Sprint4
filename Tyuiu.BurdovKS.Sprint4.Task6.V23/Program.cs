


using Tyuiu.BurdovKS.Sprint4.Task6.V23.Lib;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();



        Console.Title = "Спринт #4 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных: Microsoft, Google, Apple, Amazon, Facebook *");
        Console.WriteLine("* Tesla,Netflix                                                           *");
        Console.WriteLine("* Подсчитайте количество элементов, длина которых равна 6.                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string[] array = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

        
        int res = Calculate(array);

        
        Console.WriteLine($"Количество элементов длиной 6: {res}");

        
        Console.Write("Массив: ");
        foreach (string element in array)
        {
            Console.Write($"{element} ");
        }
    }

   
    static int Calculate(string[] array)
    {
        int count = 0;
        foreach (string element in array)
        {
            if (element.Length == 6)
            {
                count++;
            }
        }
        return count;
    }
}


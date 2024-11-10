


using Tyuiu.BurdovKS.Sprint4.Task2.V30.Lib;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Random rnd = new Random();

        Console.Title = "Спринт #4 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов                     *");
        Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до 8               *");
        Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите длинну массива:");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] NumsArray = new int[len];

        for (int i = 0; i < len; i++)
        {
            NumsArray[i] = rnd.Next(2, 8);
        }

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(NumsArray[i] + "\t");
        }

        int product = ds.Calculate(NumsArray);


        Console.WriteLine("Произведение нечетных элементов массива: " + product);
        Console.ReadKey();
    }
}




using Tyuiu.BurdovKS.Sprint4.Task4.V17.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();



        Console.Title = "Спринт #4 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
        Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до 7.              *");
        Console.WriteLine("* Найдите сумму четных элементов массива.                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        int rows = 5;
        int cols = 5;

        
        int[,] matrix = new int[rows, cols];

        
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                while (true)
                {
                    Console.Write($"Введите элемент [{i}][{j}] (от 2 до 7): ");
                    if (int.TryParse(Console.ReadLine(), out int value) && 2 <= value && value <= 7)
                    {
                        matrix[i, j] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод. Введите число от 2 до 7.");
                    }
                }
            }
        }

        
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        
        int sumEven = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    sumEven += matrix[i, j];
                }
            }
        }

        
        Console.WriteLine("\nСумма четных элементов: " + sumEven);
        Console.ReadKey(); 
    }
}






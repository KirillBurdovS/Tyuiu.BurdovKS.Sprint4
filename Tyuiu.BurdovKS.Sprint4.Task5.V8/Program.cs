

using Tyuiu.BurdovKS.Sprint4.Task5.V8.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();



        Console.Title = "Спринт #4 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
        Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от -3 до 4.             *");
        Console.WriteLine("* Заменить отрицательные элементы на 0.                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

       

        int[,] matrix = new int[5, 5];

        
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = random.Next(-3, 5); 
            }
        }

        
        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] < 0)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        
        Console.WriteLine("\nИзмененный массив:");
        PrintMatrix(matrix);

        Console.ReadKey();
    }

    
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
        
    
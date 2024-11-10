



using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.BurdovKS.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {

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

            return minElement;
        }
    }
}

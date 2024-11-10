

using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.BurdovKS.Sprint4.Task2.V30.Lib
{
    public class DataService : ISprint4Task2V30
    {
        public int Calculate(int[] array)
        {

            if (array == null || array.Length == 0)
            {
                return 0;
            }

            int product = 1;
            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    product *= number;
                }
            }
            return product;
        }
    }
}
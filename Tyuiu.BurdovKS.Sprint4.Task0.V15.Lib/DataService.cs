

using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.BurdovKS.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15

    {
        public int GetMultOddArrEl(int[] array)
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

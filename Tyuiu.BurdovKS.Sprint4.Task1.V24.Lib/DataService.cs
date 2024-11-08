


using tyuiu.cources.programming.interfaces.Sprint4;



namespace Tyuiu.BurdovKS.Sprint4.Task1.V24.Lib
{
    public class DataService : ISprint4Task1V24
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

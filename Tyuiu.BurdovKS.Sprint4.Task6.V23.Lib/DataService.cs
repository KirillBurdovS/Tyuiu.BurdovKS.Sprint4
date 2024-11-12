



using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BurdovKS.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {

            {
                if (array == null || array.Length == 0)
                {
                    return 0;
                }

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






    }
}


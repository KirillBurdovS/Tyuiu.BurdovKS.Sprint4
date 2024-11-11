


using tyuiu.cources.programming.interfaces.Sprint4;



namespace Tyuiu.BurdovKS.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task4V17
    {
        public int Calculate(int[,] matrix)
        {
            if(matrix == null || matrix.Length == 0)
            {
                return 0;
            }


            int sumEven = 0;

            foreach(int number  in matrix)
            {
                if(number % 2 == 0)
                {
                    sumEven += number;
                }
            }

            return sumEven;
        }
        
    }
}

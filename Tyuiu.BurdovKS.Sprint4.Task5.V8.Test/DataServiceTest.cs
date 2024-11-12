


using Tyuiu.BurdovKS.Sprint4.Task5.V8.Lib;


namespace Tyuiu.BurdovKS.Sprint4.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();


            int[,] matrix = new int[5, 5]
        {
            { 2, -1, 4, -3, 0 },
            { -1, 1, 2, 0, 1 },
            { 1, 0, 3, 2, 1 },
            { -3, 0, 1, -2, 3 },
            { -1, 2, 1, -2, 4 }
        };




            int[,] res = ds.Calculate(matrix);


            int[,] wait = new int[5, 5]
        {
            { 2, 0, 4, 0, 0 },
            { 0, 1, 2, 0, 1 },
            { 1, 0, 3, 2, 1 },
            { 0, 0, 1, 0, 3 },
            { 0, 2, 1, 0, 4 }
        };

            CollectionAssert.AreEqual(wait, res);






        }
    }
}


            

            


      
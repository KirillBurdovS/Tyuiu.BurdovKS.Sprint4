


using Tyuiu.BurdovKS.Sprint4.Task1.V24.Lib;


namespace Tyuiu.BurdovKS.Sprint4.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();



            int[] array = { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 };


            int res = ds.Calculate(array);

            Assert.AreEqual(84375, res);
            



        }
    }
}
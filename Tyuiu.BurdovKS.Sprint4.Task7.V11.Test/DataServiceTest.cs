



using Newtonsoft.Json.Linq;
using Tyuiu.BurdovKS.Sprint4.Task7.V11.Lib;


namespace Tyuiu.BurdovKS.Sprint4.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 4;

            int m = 2;

            string value = "56789012";

            int[,] matrix = new int[n, m];


            int res = ds.Calculate(n, m, value);


            Assert.AreEqual(4, res);

        }
    }
}
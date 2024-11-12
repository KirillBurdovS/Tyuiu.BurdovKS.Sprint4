



using Tyuiu.BurdovKS.Sprint4.Task6.V23.Lib;


namespace Tyuiu.burdovKS.Sprint4.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            string[] array = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            int res = ds.Calculate(array);

            Assert.AreEqual(2, res);




        }
    }
}
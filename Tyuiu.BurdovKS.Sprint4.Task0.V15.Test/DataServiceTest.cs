

using Tyuiu.BurdovKS.Sprint4.Task0.V15.Lib;


namespace Tyuiu.BurdovKS.Sprint4.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();


            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            int res = ds.GetMultOddArrEl(numsArray);  

            Assert.AreEqual(138915, res); 




        }
    }
}
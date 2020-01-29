using NUnit.Framework;

namespace dataservice.tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService srv = new DataService();
            var actualResult = srv.GetDisplayText("US");
            var expectedResult = "Hello from US";
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Test2()
        {
            DataService srv = new DataService();
            var actualResult = srv.GetDisplayText("UK");
            var expectedResult = "Hello from UK";
            Assert.AreEqual(actualResult, expectedResult);
        }        

        [Test]
        public void Test3()
        {
            DataService srv = new DataService();
            var actualResult = srv.GetDisplayText("US");
            var expectedResult = "Hello from UK";
            Assert.AreNotEqual(actualResult, expectedResult);
        }  

        [Test]
        public void Test4()
        {
            DataService srv = new DataService();
            var actualResult = srv.GetDisplayText("");
            var expectedResult = "Hello from UK";
            Assert.AreNotEqual(actualResult, expectedResult);
        }     

        [Test]
        public void Test5()
        {
            DataService srv = new DataService();
            var actualResult = srv.GetDisplayText("test");
            var expectedResult = "Hello from ";
            Assert.AreEqual(actualResult, expectedResult);
        }                       
    }
}
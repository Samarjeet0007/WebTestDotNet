using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            int a = 5, b;
            b = a;
            Assert.AreEqual(a, b);
        }
    }
}
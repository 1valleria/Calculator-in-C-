using Calculator_Program;

namespace Unit_test_for_Calculator_in_C
{
    public class Tests
    {
        Calculator myCalculator;
        [SetUp]
        public void Setup()
        {
            myCalculator = new Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.That(myCalculator.add(2,2).Equals(4));
        }
        [Test]
        public void Test2()
        {
            Assert.That(myCalculator.substract(2, 2).Equals(0));
        }
        [Test]
        public void Test3()
        {
            Assert.That(myCalculator.multiply(2, 2).Equals(4));
        }
        [Test]
        public void Test4()
        {
            Assert.That(myCalculator.divide(2, 2).Equals(1));
        }
    }
}
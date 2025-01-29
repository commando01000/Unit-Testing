using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestAuthorizeRegisteration
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Max_WhenFirstArgumentIsGreater_ReturnsFirstArgument()
        {
            var math = new Math();
            var result = math.Max(20, 10);
            Assert.That(result, Is.EqualTo(20));
        }
       
        [Test]
        public void Max_WhenSecondArgumentIsGreater_ReturnsSecondArgument()
        {
            var math = new Math();
            var result = math.Max(10, 30);
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Max_WhenArgumentsAreEqual_ReturnsTheSameArgument()
        {
            var math = new Math();
            var result = math.Max(10, 10);
            Assert.That(result, Is.EqualTo(10));
        }
    }
}

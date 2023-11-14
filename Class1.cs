using NUnit.Framework;

namespace TDDLeapYears
{
    [TestFixture]
    public class LeapYearTests
    {
        private LeapYearCalculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new LeapYearCalculator();
        }

        [Test]
        public void When_The_Year_Is_Not_Divisible_By_4_Returns_False()
        {
            
            bool result = _calculator.Calculate(1997);
            Assert.That(result, Is.False);
        }

        [Test]
        public void When_The_Year_Is_Divisible_By_4_Returns_True()
        {
            bool result = _calculator.Calculate(1996);
            Assert.That(result, Is.True);
        }

        [Test]
        public void When_The_Year_Is_Divisble_By_400_Return_True()
        {
            bool result = _calculator.Calculate(1600);
            Assert.That(result, Is.True);
        }

        [Test]
        public void When_The_Year_Is_Divisble_By_100_But_Not_400_Return_False()
        {
            bool result = _calculator.Calculate(1800);
            Assert.That(result, Is.False);
        }
    }

    public class LeapYearCalculator
    {
        public bool Calculate(int i)
        {
            if (i % 100 == 0 && i % 400 != 0)
            {
                return false;
            }

            if (i % 400 == 0)
            {
                return true;
            }

            return i % 4 == 0;
        }
    }
}

using NUnit.Framework;

namespace Unit_Testing_and_Nunit
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });
            long expected = 12;
            Assert.That(expected == actual);

        }

        [Test]
        public void Test_Sum_ThreePositiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7, 3 });
            Assert.That(actual == 15);

        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -5, -2 });
            Assert.That(actual == -7);

        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] { });
            Assert.That(actual == 0);

        }

        [Test]
        public void Test_Sum_BigNumbers()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });
            Assert.That(actual == 6000000000);

        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            long actual = Summator.Average(new int[] { 5, 7 });
            long expected = 6;
            Assert.That(expected == actual);

        }


    }
}

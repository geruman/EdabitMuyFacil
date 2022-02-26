using NUnit.Framework;
using EdabitMuyFacil;

namespace EdabitMuyFacilTests
{
    [TestFixture]
    public class EdabitMuyFacilTests
    {
        [Test]
        [TestCase(21, ExpectedResult = 3420)]
        [TestCase(22, ExpectedResult = 3600)]
        [TestCase(3, ExpectedResult = 180)]
        [TestCase(4, ExpectedResult = 360)]
        [TestCase(5, ExpectedResult = 540)]
        [TestCase(6, ExpectedResult = 720)]
        [TestCase(7, ExpectedResult = 900)]
        [TestCase(8, ExpectedResult = 1080)]
        [TestCase(9, ExpectedResult = 1260)]
        [TestCase(10, ExpectedResult = 1440)]
        [TestCase(11, ExpectedResult = 1620)]
        [TestCase(12, ExpectedResult = 1800)]
        [TestCase(13, ExpectedResult = 1980)]
        [TestCase(14, ExpectedResult = 2160)]
        [TestCase(15, ExpectedResult = 2340)]
        [TestCase(16, ExpectedResult = 2520)]
        [TestCase(17, ExpectedResult = 2700)]
        [TestCase(18, ExpectedResult = 2880)]
        [TestCase(19, ExpectedResult = 3060)]
        [TestCase(20, ExpectedResult = 3240)]
        public int SumOfPolygonAnglesTests(int number)
        {
            var result = MuyFacil.SumOfPolygonAngles(number);
            return result;
        }

        [Test]
        [TestCase(true, true, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(false, false, ExpectedResult = false)]
        public bool AndOperatorTest(bool a, bool b)
        {
            return MuyFacil.AndOperator(a, b);
        }
        [Test]
        [TestCase(6, 7, ExpectedResult = 26)]
        [TestCase(20, 10, ExpectedResult = 60)]
        [TestCase(2, 9, ExpectedResult = 22)]
        public int FindPerimeterOfRectangle(int length, int width)
        {
            return MuyFacil.FindPerimeterOfRectanble(length, width);
        }
        [Test]
        [TestCase("Gerald", ExpectedResult = "Hello Gerald!")]
        [TestCase("Fatima", ExpectedResult = "Hello Fatima!")]
        [TestCase("Ed", ExpectedResult = "Hello Ed!")]
        [TestCase("Tiffany", ExpectedResult = "Hello Tiffany!")]
        public string NameGreetingTest(string name)
        {
            return MuyFacil.NameGreeting(name);
        }
        [Test]
        [TestCase(1, 1, ExpectedResult = 5)]
        [TestCase(1, 2, ExpectedResult = 8)]
        [TestCase(2, 1, ExpectedResult = 7)]
        [TestCase(2, 2, ExpectedResult = 10)]
        [TestCase(69, 420, ExpectedResult = 1398)]
        public int BasketballPointsTest(int doblepunto, int triplepunto)
        {
            return MuyFacil.BasketballPoints(doblepunto, triplepunto);
        }
        [Test]
        [TestCase(5, 2, 8, ExpectedResult = 50)]
        [TestCase(3, 4, 7, ExpectedResult = 50)]
        [TestCase(1, 2, 3, ExpectedResult = 22)]
        [TestCase(3, 5, 2, ExpectedResult = 34)]
        public int FarmProblemTest(int chickens, int cows, int pigs)
        {
            return MuyFacil.FarmProblem(chickens, cows, pigs);
        }
    }

}
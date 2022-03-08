using NUnit.Framework;
using EdabitMuyFacil;
using System.Collections.Generic;

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

        [Test]
        [TestCase(1, 2, 3, ExpectedResult = 5)]
        [TestCase(5, 5, 5, ExpectedResult = 20)]
        [TestCase(1, 0, 0, ExpectedResult = 3)]
        [TestCase(0, 7, 0, ExpectedResult = 7)]
        [TestCase(0, 0, 15, ExpectedResult = 0)]
        public int FootballPointsTests(int wins, int draws, int looses)
        {
            return MuyFacil.FootbalPoints(wins, draws, looses);
        }
        [Test]
        [TestCase(new object[] { 5, 6, 7 }, ExpectedResult = 5)]
        [TestCase(new object[] { "Semiramis", "Gaia", "Hypatia" }, ExpectedResult = "Semiramis")]
        [TestCase(new object[] { -500, 0, 500 }, ExpectedResult = -500)]
        [TestCase(new object[] { 'n', 'm', 'v' }, ExpectedResult = 'n')]
        [TestCase(new object[] { 3.3, 4.4, 5.5 }, ExpectedResult = 3.3)]
        [TestCase(new object[] { true, false, true }, ExpectedResult = true)]
        public object GetFirstValueTest(object[] array)
        {
            return MuyFacil.GetFirstValue(array);
        }
        [Test]
        [TestCase("Matt", ExpectedResult = "Hello, Matt!")]
        [TestCase("Helen", ExpectedResult = "Hello, Helen!")]
        [TestCase("Mubashir", ExpectedResult = "Hello, my Love!")]

        public string GreetingTest(string name)
        {
            return MuyFacil.Greeting(name);
        }
        [Test]
        [TestCase(1, 0, ExpectedResult = 3600)]
        [TestCase(1, 3, ExpectedResult = 3780)]
        [TestCase(0, 30, ExpectedResult = 1800)]
        public int ConvertTest(int hours, int minutes)
        {
            return MuyFacil.Convert(hours, minutes);
        }
        [Test]
        [TestCase(5, 4, ExpectedResult = 8)]
        [TestCase(8, 3, ExpectedResult = 10)]
        [TestCase(7, 9, ExpectedResult = 15)]
        [TestCase(10, 4, ExpectedResult = 13)]
        [TestCase(7, 2, ExpectedResult = 8)]
        public int NextEdgeTest(int side1, int side2)
        {
            return MuyFacil.NextEdge(side1, side2);
        }
        [Test]
        [TestCase(12, ExpectedResult = 1)]
        [TestCase(360, ExpectedResult = 30)]
        [TestCase(3612, ExpectedResult = 301)]
        [TestCase(324, ExpectedResult = 27)]
        [TestCase(3012, ExpectedResult = 251)]
        [TestCase(11, ExpectedResult = 0)]

        public int InchesToFeetTest(int inches)
        {
            return MuyFacil.InchesToFeet(inches);
        }
        [Test]
        [TestCase(7, ExpectedResult = false)]
        [TestCase(5, ExpectedResult = true)]
        [TestCase(15, ExpectedResult = true)]
        [TestCase(33, ExpectedResult = false)]
        [TestCase(-18, ExpectedResult = false)]
        [TestCase(999, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = false)]
        public bool DivisibleByFiveTest(int value)
        {
            return MuyFacil.DivisibleByFive(value);
        }
        [Test]
        [TestCase(10, ExpectedResult = 100)]
        [TestCase(69, ExpectedResult = 4761)]
        [TestCase(666, ExpectedResult = 443556)]
        [TestCase(-21, ExpectedResult = 441)]
        [TestCase(21, ExpectedResult = 441)]
        public int SquaredTest(int value)
        {
            return MuyFacil.Squared(value);
        }
        [Test]
        [TestCase(98, 7, ExpectedResult = true)]
        [TestCase(87, 49, ExpectedResult = false)]
        [TestCase(34, 14, ExpectedResult = false)]
        [TestCase(78, 6, ExpectedResult = true)]
        [TestCase(30, 4, ExpectedResult = false)]
        [TestCase(87, 73, ExpectedResult = false)]
        [TestCase(74, 7, ExpectedResult = false)]
        [TestCase(87, 29, ExpectedResult = true)]
        [TestCase(48, 24, ExpectedResult = true)]
        [TestCase(99, 20, ExpectedResult = false)]
        [TestCase(98, 49, ExpectedResult = true)]
        [TestCase(100, 6, ExpectedResult = false)]
        [TestCase(64, 4, ExpectedResult = true)]
        [TestCase(70, 35, ExpectedResult = true)]
        [TestCase(38, 38, ExpectedResult = true)]
        [TestCase(29, 3, ExpectedResult = false)]
        [TestCase(20, 8, ExpectedResult = false)]
        [TestCase(66, 50, ExpectedResult = false)]
        [TestCase(95, 1, ExpectedResult = true)]
        [TestCase(58, 2, ExpectedResult = true)]
        public bool DividesEvenlyTest(int value, int divisor)
        {
            return MuyFacil.DividesEvenly(value, divisor);
        }
        [Test]
        [TestCase(1, 1, ExpectedResult = 60)]
        [TestCase(10, 1, ExpectedResult = 600)]
        [TestCase(10, 25, ExpectedResult = 15000)]
        [TestCase(500, 60, ExpectedResult = 1800000)]
        [TestCase(0, 60, ExpectedResult = 0)]
        [TestCase(99, 1, ExpectedResult = 5940)]
        [TestCase(419, 70, ExpectedResult = 1759800)]
        [TestCase(52, 33, ExpectedResult = 102960)]
        public int FramesTest(int minutes, int frames)
        {
            return MuyFacil.Frames(minutes, frames);
        }
        [Test]
        [TestCase(0.2, 50, 9, ExpectedResult = true)]
        [TestCase(0.9, 1, 2, ExpectedResult = false)]
        [TestCase(0.9, 3, 2, ExpectedResult = true)]
        [TestCase(0.33, 10, 3.30, ExpectedResult = true)]
        [TestCase(0, 1000, 0.01, ExpectedResult = false)]
        [TestCase(0.1, 1000, 7, ExpectedResult = true)]
        [TestCase(0, 0, 0, ExpectedResult = false)]
        public bool ProfitableGambleTest(double prob, int prize, double pay)
        {
            return MuyFacil.ProfitableGamble(prob, prize, pay);
        }

        [Test]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(0, ExpectedResult = 1)]
        public int FlipIntBoolTest(int ib)
        {
            return MuyFacil.FlipIntBool(ib);
        }

        [Test]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(100, ExpectedResult = true)]
        [TestCase(1000, ExpectedResult = true)]
        [TestCase(111000, ExpectedResult = true)]
        [TestCase(-1, ExpectedResult = false)]
        [TestCase(0, ExpectedResult = true)]
        [TestCase(-100, ExpectedResult = true)]
        public bool DivisibleByOneHundredTest(int num)
        {
            return MuyFacil.DivisibleByOneHundred(num);
        }

        [Test]
        [TestCase(2013, 12, 24, ExpectedResult = true)]
        [TestCase(2013, 0, 23, ExpectedResult = false)]
        [TestCase(3000, 12, 24, ExpectedResult = true)]
        public bool IsItChristmasEveTest(int year, int month, int day)
        {
            return MuyFacil.IsItChristmasEve(month, day);
        }

        [Test]
        [TestCase(1, ExpectedResult = 6)]
        [TestCase(2, ExpectedResult = 24)]
        [TestCase(3, ExpectedResult = 54)]
        [TestCase(4, ExpectedResult = 96)]
        [TestCase(5, ExpectedResult = 150)]
        [TestCase(6, ExpectedResult = 216)]
        [TestCase(7, ExpectedResult = 294)]
        [TestCase(8, ExpectedResult = 384)]
        [TestCase(9, ExpectedResult = 486)]
        [TestCase(10, ExpectedResult = 600)]
        [TestCase(11, ExpectedResult = 726)]
        [TestCase(12, ExpectedResult = 864)]
        [TestCase(13, ExpectedResult = 1014)]
        [TestCase(14, ExpectedResult = 1176)]
        [TestCase(15, ExpectedResult = 1350)]

        public int HowManyStickersTest(int sideLength)
        {
            return MuyFacil.HowManyStickers(sideLength);
        }

        [Test]
        public void PrintArrayTest()
        {
            List<int> myValues = new List<int>(new int[] { 1 });
            Assert.AreEqual(myValues, MuyFacil.PrintArray(1));

            myValues = new List<int>(new int[] { 1, 2 });
            Assert.AreEqual(myValues, MuyFacil.PrintArray(2));

            myValues = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.AreEqual(myValues, MuyFacil.PrintArray(6));
        }

        [Test]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = 4)]
        [TestCase(100, ExpectedResult = 198)]
        [TestCase(1298734, ExpectedResult = 2597466)]
        public int NthEvenTest(int num)
        {
            return MuyFacil.NthEven(num);
        }

        [Test]
        [TestCase(-4, ExpectedResult = -4)]
        [TestCase(212, ExpectedResult = -212)]
        [TestCase(-125, ExpectedResult = -125)]
        [TestCase(932123, ExpectedResult = -932123)]
        public int ReturnNegativeTest(int num)
        {
            return MuyFacil.ReturnNegative(num);
        }

        [Test]
        [TestCase("John", "Doe", ExpectedResult = "Doe, John")]
        [TestCase("First", "Last", ExpectedResult = "Last, First")]
        [TestCase("A", "B", ExpectedResult = "B, A")]
        [TestCase(",", ",", ExpectedResult = ",, ,")]
        public string ConcatNameTest(string firstName, string lastName)
        {
            return MuyFacil.ConcatName(firstName, lastName);
        }

        [Test]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 4)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(5, ExpectedResult = 25)]
        [TestCase(27, ExpectedResult = 729)]
        [TestCase(196, ExpectedResult = 38416)]
        [TestCase(512, ExpectedResult = 262144)]
        public int StackBoxesTest(int num)
        {
            return MuyFacil.StackBoxes(num);
        }


        [Test]
        [TestCase(5, 3, ExpectedResult = 15)]
        [TestCase(8, 5, ExpectedResult = 40)]
        [TestCase(5, 4, ExpectedResult = 20)]
        [TestCase(2, 3, ExpectedResult = 6)]
        [TestCase(10000, 10000, ExpectedResult = 100000000)]
        [TestCase(-2, -5, ExpectedResult = -1)]
        [TestCase(0, 3, ExpectedResult = -1)]
        [TestCase(5, -3, ExpectedResult = -1)]
        [TestCase(0, 1, ExpectedResult = -1)]
        [TestCase(-1, 0, ExpectedResult = -1)]
        public int RectangleAreaTest(int h, int w)
        {
            return MuyFacil.RectangleArea(h, w);
        }

        [Test]
        [TestCase("", ExpectedResult = true)]
        [TestCase(" ", ExpectedResult = false)]
        [TestCase("            ", ExpectedResult = false)]
        [TestCase("38215", ExpectedResult = false)]
        [TestCase("afjabsdf", ExpectedResult = false)]
        [TestCase("!?@&", ExpectedResult = false)]
        public bool IsEmptyTest(string s)
        {
            return MuyFacil.IsEmpty(s);
        }

        [Test]
        [TestCase("AB", "CD", ExpectedResult = true)]
        [TestCase("ABC", "DE", ExpectedResult = false)]
        [TestCase("hello", "edabit", ExpectedResult = false)]
        [TestCase("meow", "woof", ExpectedResult = true)]
        [TestCase("jrnvjrnnt", "cvjknfjvmfvnfjn", ExpectedResult = false)]
        [TestCase("jkvnjrt", "krnf", ExpectedResult = false)]
        [TestCase("Facebook", "Snapchat", ExpectedResult = true)]

        public bool CompareStringsByLengthTest(string str1, string str2)
        {
            return MuyFacil.CompareStringsByLength(str1, str2);
        }

        [Test]
        [TestCase(-5, ExpectedResult = true)]
        [TestCase(-50, ExpectedResult = false)]
        [TestCase(0, ExpectedResult = false)]
        [TestCase(25, ExpectedResult = true)]
        [TestCase(-19, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = false)]
        [TestCase(23, ExpectedResult = true)]
        [TestCase(-71, ExpectedResult = true)]
        public bool IsOddTest(int num)
        {
            return MuyFacil.IsOdd(num);
        }

    }


}
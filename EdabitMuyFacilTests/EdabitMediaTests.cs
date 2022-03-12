using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdabitMuyFacil;

namespace EdabitMuyFacilTests
{
    [TestFixture]
    public class EdabitMediaTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        [TestCase(7, 5, ExpectedResult = new int[] { 7, 14, 21, 28, 35 })]
        [TestCase(12, 10, ExpectedResult = new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 })]
        [TestCase(17, 7, ExpectedResult = new int[] { 17, 34, 51, 68, 85, 102, 119 })]
        [TestCase(630, 14, ExpectedResult = new int[] { 630, 1260, 1890, 2520, 3150, 3780, 4410, 5040, 5670, 6300, 6930, 7560, 8190, 8820 })]
        [TestCase(140, 3, ExpectedResult = new int[] { 140, 280, 420 })]
        [TestCase(7, 8, ExpectedResult = new int[] { 7, 14, 21, 28, 35, 42, 49, 56 })]
        [TestCase(11, 21, ExpectedResult = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110, 121, 132, 143, 154, 165, 176, 187, 198, 209, 220, 231 })]
        public static int[] ArrayOfMultiplesTest(int num, int len)
        {
            return Media.ArrayOfMultiples(num, len);
        }

        [Test]
        [TestCase("eDaBiT", ExpectedResult = new int[] { 1, 3, 5 })]
        [TestCase("eQuINoX", ExpectedResult = new int[] { 1, 3, 4, 6 })]
        [TestCase("determine", ExpectedResult = new int[] { })]
        [TestCase("STRIKE", ExpectedResult = new int[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase("sUn", ExpectedResult = new int[] { 1 })]
        [TestCase("SpiDer", ExpectedResult = new int[] { 0, 3 })]
        [TestCase("accOmpAnY", ExpectedResult = new int[] { 3, 6, 8 })]
        [TestCase("@xCE#8S#i*$en", ExpectedResult = new int[] { 2, 3, 6 })]
        [TestCase("1854036297", ExpectedResult = new int[] { })]
        [TestCase("Fo?.arg~{86tUx=|OqZ!", ExpectedResult = new int[] { 0, 12, 16, 18 })]
        public static int[] IndexOfCapitalsTest(string str)
        {
            return Media.IndexOfCapitals(str);
        }


        [Test]
        [TestCase("Happy Birthday", ExpectedResult = "hAPPY bIRTHDAY")]
        [TestCase("MANY THANKS", ExpectedResult = "many thanks")]
        [TestCase("sPoNtAnEoUs", ExpectedResult = "SpOnTaNeOuS")]
        [TestCase("eXCELLENT, yOuR mAJESTY", ExpectedResult = "Excellent, YoUr Majesty")]
        public static string ReverseCaseTest(string str)
        {
            Console.WriteLine($"Input: {str}");
            return Media.ReverseCase(str);
        }

        [Test]
        [TestCase("There is a bomb.", ExpectedResult = "Duck!!!")]
        [TestCase("Hey, did you find it?", ExpectedResult = "There is no bomb, relax.")]
        [TestCase("Hey, did you think there is a bomb?", ExpectedResult = "Duck!!!")]
        [TestCase("This goes boom!!!", ExpectedResult = "There is no bomb, relax.")]
        [TestCase("Hey, did you find the BoMb?", ExpectedResult = "Duck!!!")]
        [TestCase("Commotion in the third, a bomb is found!", ExpectedResult = "Duck!!!")]
        public static string BombTest(string a)
        {
            return Media.Bomb(a);
        }


        [Test]
        public void ParseArrayTest()
        {
            object[] testArr_1 = new object[] { 1, 2, "a", "b" };
            object[] testArr_2 = new object[] { "a", "b", 10, 115 };
            object[] testArr_3 = new object[] { };
            object[] testArr_4 = new object[] { -4, "k", 0 };
            object[] testArr_5 = new object[] { "Hell000!", 5 };

            Assert.AreEqual(new string[] { "1", "2", "a", "b" }, Media.ParseArray(testArr_1));
            Assert.AreEqual(new string[] { "a", "b", "10", "115" }, Media.ParseArray(testArr_2));
            Assert.AreEqual(new string[] { }, Media.ParseArray(testArr_3));
            Assert.AreEqual(new string[] { "-4", "k", "0" }, Media.ParseArray(testArr_4));
            Assert.AreEqual(new string[] { "Hell000!", "5" }, Media.ParseArray(testArr_5));
        }


        [Test]
        [TestCase(1, true, ExpectedResult = false)]
        [TestCase(0, "0", ExpectedResult = false)]
        [TestCase(1, 1, ExpectedResult = true)]
        [TestCase(true, true, ExpectedResult = true)]
        [TestCase("nmv", "nmv", ExpectedResult = true)]
        [TestCase(0, "", ExpectedResult = false)]
        [TestCase(1, "1", ExpectedResult = false)]
        [TestCase('h', 'm', ExpectedResult = false)]
        [TestCase('a', 'a', ExpectedResult = true)]
        [TestCase(0, false, ExpectedResult = false)]
        [TestCase(1.0, 1.0, ExpectedResult = true)]
        [TestCase("str", "rts", ExpectedResult = false)]
        [TestCase('c', "test", ExpectedResult = false)]
        [TestCase(true, "true", ExpectedResult = false)]
        [TestCase(true, false, ExpectedResult = false)]
        public static bool FixedTest(object a, object b)
        {
            return Media.CheckEquality(a, b);
        }

        [Test]
        public static void MaxText()
        {
            Assert.AreEqual(new double[] { 7, 90, 2 }, Media.FindLargest(new double[][] { new double[] { 4, 2, 7, 1 }, new double[] { 20, 70, 40, 90 }, new double[] { 1, 2, 0 } }));
            Assert.AreEqual(new double[] { 0.7634, 9.32, 9 }, Media.FindLargest(new double[][] { new double[] { 0.4321, 0.7634, 0.652 }, new double[] { 1.324, 9.32, 2.5423 }, new double[] { 9, 3, 6, 3 } }));
            Assert.AreEqual(new double[] { -34, -2, 7 }, Media.FindLargest(new double[][] { new double[] { -34, -54, -74 }, new double[] { -32, -2, -65 }, new double[] { -54, 7, -43 } }));
            Assert.AreEqual(new double[] { 1.34, -1.762, 65 }, Media.FindLargest(new double[][] { new double[] { 0.34, -5, 1.34 }, new double[] { -6.432, -1.762, -1.99 }, new double[] { 32, 65, -6 } }));
            Assert.AreEqual(new double[] { 0, 3, -2 }, Media.FindLargest(new double[][] { new double[] { 0, 0, 0, 0 }, new double[] { 3, 3, 3, 3 }, new double[] { -2, -2 } }));
        }
        
        [Test]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 7)]
        [TestCase(10, ExpectedResult = 6)]
        [TestCase(6, ExpectedResult = 8)]
        [TestCase(345, ExpectedResult = 125)]
        [TestCase(72, ExpectedResult = 22)]
        public static int CollatzTest(int num)
        {
            Console.WriteLine($"Input: {num}");
            return Media.collatz(num);
        }
        [Test]
        // Normal letters
        [TestCase('a', ExpectedResult = 65)]
        [TestCase('A', ExpectedResult = 97)]
        [TestCase('l', ExpectedResult = 76)]
        [TestCase('L', ExpectedResult = 108)]
        [TestCase('z', ExpectedResult = 90)]
        [TestCase('Z', ExpectedResult = 122)]

        // Accented / weird letters
        [TestCase('è', ExpectedResult = 200)]
        [TestCase('È', ExpectedResult = 232)]
        [TestCase('Œ', ExpectedResult = 339)]
        [TestCase('œ', ExpectedResult = 338)]
        [TestCase('Ⱥ', ExpectedResult = 11365)]
        [TestCase('ⱥ', ExpectedResult = 570)]

        // These don't have a counterpart, you should return the input's char code
        [TestCase('5', ExpectedResult = 53)]
        [TestCase('$', ExpectedResult = 36)]
        public static int CounterpartCharCodeTest(char symbol)
        {
            Console.WriteLine($"Input: {symbol}");
            return Media.CounterpartCharCode(symbol);
        }

        [Test]
        [TestCase("1/2", ExpectedResult = false)]
        [TestCase("7/4", ExpectedResult = true)]
        [TestCase("10/10", ExpectedResult = false)]
        [TestCase("12/30", ExpectedResult = false)]
        [TestCase("28/3", ExpectedResult = true)]
        [TestCase("35/31", ExpectedResult = true)]
        [TestCase("11/27", ExpectedResult = false)]
        [TestCase("42/32", ExpectedResult = true)]
        [TestCase("34/15", ExpectedResult = true)]
        [TestCase("16/16", ExpectedResult = false)]
        [TestCase("38/41", ExpectedResult = false)]
        [TestCase("45/43", ExpectedResult = true)]
        [TestCase("13/38", ExpectedResult = false)]
        [TestCase("43/2", ExpectedResult = true)]
        [TestCase("16/31", ExpectedResult = false)]
        [TestCase("41/15", ExpectedResult = true)]
        [TestCase("2/38", ExpectedResult = false)]
        [TestCase("37/21", ExpectedResult = true)]
        public static bool GreaterThanOneTest(string a)
        {
            return Media.GreaterThanOne(a);
        }
    }
}

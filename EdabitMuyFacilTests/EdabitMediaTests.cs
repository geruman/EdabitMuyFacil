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

        [Test]
        [TestCase(12, ExpectedResult = 2)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(100, ExpectedResult = 3)]
        [TestCase(101, ExpectedResult = 4)]
        [TestCase(999, ExpectedResult = 8)]
        [TestCase(123456789, ExpectedResult = 16)]
        [TestCase(1234567890, ExpectedResult = 12)]
        public static int CountOnesTest(int i)
        {
            return Media.CountOnes(i);
        }

        [Test]
        public void CountPosSumNegTest()
        {
            int[] haystack_1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] haystack_2 = new int[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            int[] haystack_3 = new int[] { 91, -4, 80, -73, -28 };
            int[] haystack_4 = new int[] { };
            int[] haystack_5 = new int[] { 69, 100, 28, 47, 53, -61, -24 };
            int[] haystack_6 = new int[] { 5, 7, 9, -3, -7, 61, -24 };
            int[] haystack_7 = new int[] { 0 };
            int[] haystack_8 = new int[] { 98, 51, -19, -97 };
            int[] haystack_9 = new int[] { -42, 3, -51, -64, 69, 77, -20, -5, 68, -76 };
            int[] haystack_10 = new int[] { 0, 0, 0 };

            Assert.AreEqual(new int[] { 10, -65 }, Media.CountPosSumNeg(haystack_1));
            Assert.AreEqual(new int[] { 7, -252 }, Media.CountPosSumNeg(haystack_2));
            Assert.AreEqual(new int[] { 2, -105 }, Media.CountPosSumNeg(haystack_3));
            Assert.AreEqual(new int[] { }, Media.CountPosSumNeg(haystack_4));
            Assert.AreEqual(new int[] { 5, -85 }, Media.CountPosSumNeg(haystack_5));
            Assert.AreEqual(new int[] { 4, -34 }, Media.CountPosSumNeg(haystack_6));
            Assert.AreEqual(new int[] { 0, 0 }, Media.CountPosSumNeg(haystack_7));
            Assert.AreEqual(new int[] { 2, -116 }, Media.CountPosSumNeg(haystack_8));
            Assert.AreEqual(new int[] { 4, -258 }, Media.CountPosSumNeg(haystack_9));
            Assert.AreEqual(new int[] { 0, 0 }, Media.CountPosSumNeg(haystack_10));
        }

        [Test]
        public static void IsogramTests()
        {
            Console.WriteLine("Algorism");
            Assert.True(Media.IsIsogram("Algorism"));
            Console.WriteLine("PasSword");
            Assert.False(Media.IsIsogram("PasSword"));
            Console.WriteLine("Dermatoglyphics");
            Assert.True(Media.IsIsogram("Dermatoglyphics"));
            Console.WriteLine("Cat");
            Assert.True(Media.IsIsogram("Cat"));
            Console.WriteLine("Filmography");
            Assert.True(Media.IsIsogram("Filmography"));
            Console.WriteLine("Consecutive");
            Assert.False(Media.IsIsogram("Consecutive"));
            Console.WriteLine("Bankruptcies");
            Assert.True(Media.IsIsogram("Bankruptcies"));
            Console.WriteLine("Unforgivable");
            Assert.True(Media.IsIsogram("Unforgivable"));
            Console.WriteLine("Unpredictably");
            Assert.True(Media.IsIsogram("Unpredictably"));
            Console.WriteLine("Moose");
            Assert.False(Media.IsIsogram("Moose"));
        }

        [Test]
        [TestCase("ratio", "orator", ExpectedResult = true)]
        [TestCase("sparkling", "groups", ExpectedResult = true)]
        [TestCase("mentee", "eminem", ExpectedResult = true)]
        [TestCase("yahtzee", "easy", ExpectedResult = true)]
        [TestCase("bush", "hubris", ExpectedResult = false)]
        [TestCase("edit", "cheese", ExpectedResult = false)]
        [TestCase("false", "true", ExpectedResult = false)]
        [TestCase("cupid", "dionysus", ExpectedResult = false)]
        [TestCase("futile", "elephant", ExpectedResult = false)]
        [TestCase("", "", ExpectedResult = true)]
        [TestCase("", "abc", ExpectedResult = false)]
        [TestCase("a", "a", ExpectedResult = true)]
        [TestCase("a", "b", ExpectedResult = false)]
        [TestCase("&!", "!&", ExpectedResult = true)]
        [TestCase("5556", "65", ExpectedResult = true)]
        public static bool IsStrangePairTest(string str1, string str2)
        {
            return Media.IsStrangePair(str1, str2);
        }


        [Test]
        [TestCase(new int[] { 19, 5, 42, 2, 77 }, ExpectedResult = 7)]
        [TestCase(new int[] { 10, 343445353, 3453445, 345354534 }, ExpectedResult = 3453455)]
        [TestCase(new int[] { 2, 9, 6, -1 }, ExpectedResult = 8)]
        [TestCase(new int[] { 879, 953, 694, -847, 342, 221, -91, -723, 791, -587 }, ExpectedResult = 563)]
        [TestCase(new int[] { 3683, 2902, 3951, -475, 1617, -2385 }, ExpectedResult = 4519)]
        [TestCase(new int[] { 280, 134, 108 }, ExpectedResult = 242)]
        [TestCase(new int[] { 280, 134, 108, 1 }, ExpectedResult = 109)]
        [TestCase(new int[] { 321, 406, -176 }, ExpectedResult = 727)]
        [TestCase(new int[] { 1, 1, 1, 1 }, ExpectedResult = 2)]
        [TestCase(new int[] { -1, -1, 1, 1 }, ExpectedResult = 2)]

        public static int SumTest(int[] values)
        {
            return Media.SumSmallest(values);
        }

        [Test]
        public void FilterArrayTest()
        {
            object[] haystack_1 = new object[] { 1, 2, "a", "b" };
            object[] haystack_2 = new object[] { 1, "a", "b", 0, 15 };
            object[] haystack_3 = new object[] { 1, 2, "aasf", "1", "123", 123 };
            object[] haystack_4 = new object[] { "jsyt", 4, "yt", 6 };
            object[] haystack_5 = new object[] { "r", 5, "y", "e", 8, 9 };
            object[] haystack_6 = new object[] { "a", "e", "i", "o", "u" };
            object[] haystack_7 = new object[] { 4, "z", "f", 5 };
            object[] haystack_8 = new object[] { "abc", 123 };
            object[] haystack_9 = new object[] { "$%^", 567, "&&&" };
            object[] haystack_10 = new object[] { "w", "r", "u", 43, "s", "a", 76, "d", 88 };

            Assert.AreEqual(new int[] { 1, 2 }, Media.FilterArray(haystack_1));
            Assert.AreEqual(new int[] { 1, 0, 15 }, Media.FilterArray(haystack_2));
            Assert.AreEqual(new int[] { 1, 2, 123 }, Media.FilterArray(haystack_3));
            Assert.AreEqual(new int[] { 4, 6 }, Media.FilterArray(haystack_4));
            Assert.AreEqual(new int[] { 5, 8, 9 }, Media.FilterArray(haystack_5));
            Assert.AreEqual(new int[] { }, Media.FilterArray(haystack_6));
            Assert.AreEqual(new int[] { 4, 5 }, Media.FilterArray(haystack_7));
            Assert.AreEqual(new int[] { 123 }, Media.FilterArray(haystack_8));
            Assert.AreEqual(new int[] { 567 }, Media.FilterArray(haystack_9));
            Assert.AreEqual(new int[] { 43, 76, 88 }, Media.FilterArray(haystack_10));
        }

        [Test]
        [TestCase("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6", ExpectedResult = "542 -214")]
        [TestCase("1 -1", ExpectedResult = "1 -1")]
        [TestCase("-1 -1", ExpectedResult = "-1 -1")]
        [TestCase("1 -1 0", ExpectedResult = "1 -1")]
        [TestCase("1 1 0", ExpectedResult = "1 0")]
        [TestCase("-1 -1 0", ExpectedResult = "0 -1")]
        [TestCase("42", ExpectedResult = "42 42")]
        [TestCase("1 1", ExpectedResult = "1 1")]
        [TestCase("", ExpectedResult = "")]
        [TestCase("1", ExpectedResult = "1 1")]
        public static string HighLowTest(string str)
        {
            return Media.HighLow(str);
        }
        
        [Test]
        [TestCase(31, ExpectedResult = true)]
        [TestCase(18, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(3, ExpectedResult = true)]
        [TestCase(48, ExpectedResult = false)]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(5, ExpectedResult = true)]
        [TestCase(77, ExpectedResult = false)]
        [TestCase(7, ExpectedResult = true)]
        public static bool isPrimeTest(int x)
        {
            return Media.isPrime(x);
        }

        [Test]
        [TestCase("1234", ExpectedResult = true)]
        [TestCase("12345", ExpectedResult = false)]
        [TestCase("a234", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase("%234", ExpectedResult = false)]
        [TestCase("`234", ExpectedResult = false)]
        [TestCase("@234", ExpectedResult = false)]
        [TestCase("#234", ExpectedResult = false)]
        [TestCase("$234", ExpectedResult = false)]
        [TestCase("*234", ExpectedResult = false)]
        [TestCase("5678", ExpectedResult = true)]
        [TestCase("^234", ExpectedResult = false)]
        [TestCase("(234", ExpectedResult = false)]
        [TestCase(")234", ExpectedResult = false)]
        [TestCase("123456", ExpectedResult = true)]
        [TestCase("-234", ExpectedResult = false)]
        [TestCase("_234", ExpectedResult = false)]
        [TestCase("+234", ExpectedResult = false)]
        [TestCase("=234", ExpectedResult = false)]
        [TestCase("?234", ExpectedResult = false)]
        public static bool ValidatePINTest(string pin)
        {
            return Media.ValidatePIN(pin);
        }
    }
}

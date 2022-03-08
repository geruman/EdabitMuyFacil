using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdabitMuyFacil;
using NUnit.Framework;

namespace EdabitMuyFacilTests
{
    [TestFixture]
    public class EdabitFacilTests
    {
        [Test]
        [TestCase(1, ExpectedResult = "January")]
        [TestCase(2, ExpectedResult = "February")]
        [TestCase(3, ExpectedResult = "March")]
        [TestCase(4, ExpectedResult = "April")]
        [TestCase(5, ExpectedResult = "May")]
        [TestCase(6, ExpectedResult = "June")]
        [TestCase(7, ExpectedResult = "July")]
        [TestCase(8, ExpectedResult = "August")]
        [TestCase(9, ExpectedResult = "September")]
        [TestCase(10, ExpectedResult = "October")]
        [TestCase(11, ExpectedResult = "November")]
        [TestCase(12, ExpectedResult = "December")]
        public string MonthNameTest(int monthNumber)
        {
            return Facil.MonthName(monthNumber);
        }

        [Test]
        public void FindMinMaxTest()
        {
            Assert.AreEqual(new double[] { 1, 54 }, Facil.FindMinMax(new double[] { 14, 35, 6, 1, 34, 54 }));
            Assert.AreEqual(new double[] { 1.346, 1.8734 }, Facil.FindMinMax(new double[] { 1.346, 1.6532, 1.8734, 1.8723 }));
            Assert.AreEqual(new double[] { 0.2345, 0.984 }, Facil.FindMinMax(new double[] { 0.432, 0.874, 0.523, 0.984, 0.327, 0.2345 }));
            Assert.AreEqual(new double[] { 13, 98 }, Facil.FindMinMax(new double[] { 13, 72, 98, 43, 24, 65, 31 }));
            Assert.AreEqual(new double[] { -54, -21 }, Facil.FindMinMax(new double[] { -54, -23, -54, -21 }));
            Assert.AreEqual(new double[] { -0.6834, 0.5632 }, Facil.FindMinMax(new double[] { -0.473, -0.6834, -0.1287, 0.5632 }));
            Assert.AreEqual(new double[] { 0, 0 }, Facil.FindMinMax(new double[] { 0, 0, 0, 0 }));
        }

        [Test]
        [TestCase(new int[] { 2, -1, -3, 4, 8 }, ExpectedResult = 18)]
        [TestCase(new int[] { -1 }, ExpectedResult = 1)]
        [TestCase(new int[] { -1, -3, -5, -4, -10, 0 }, ExpectedResult = 23)]
        [TestCase(new int[] { 8, 9, 10, 32, 101, -10 }, ExpectedResult = 170)]
        [TestCase(new int[] { 500 }, ExpectedResult = 500)]
        public int GetAbsSumTest(int[] array)
        {
            return Facil.GetAbsSum(array);
        }

        [Test]
        [TestCase(5, 5, ExpectedResult = 3125)]
        [TestCase(3, 3, ExpectedResult = 27)]
        [TestCase(10, 10, ExpectedResult = 10000000000)]
        public long CalculateExponentTest(long number, long exponent)
        {
            return Facil.CalculateExponent(number, exponent);
        }

        [Test]
        public void MultiplyByLengthTest()
        {
            int[] i1 = { 2, 6, 4, 9 };
            int[] i2 = { 4, 1, 1 };
            int[] i3 = { 1, 0, 3, 3, 7, 2, 1 };
            int[] i4 = { 0 };

            int[] o1 = { 8, 24, 16, 36 };
            int[] o2 = { 12, 3, 3 };
            int[] o3 = { 7, 0, 21, 21, 49, 14, 7 };
            int[] o4 = { 0 };

            Assert.AreEqual(o1, Facil.MultiplyByLength(i1));
            Assert.AreEqual(o2, Facil.MultiplyByLength(i2));
            Assert.AreEqual(o3, Facil.MultiplyByLength(i3));
            Assert.AreEqual(o4, Facil.MultiplyByLength(i4));
        }

        [Test]
        [TestCase("abcde", "bcdef", ExpectedResult = 5)]
        [TestCase("abcde", "abcde", ExpectedResult = 0)]
        [TestCase("strong", "strung", ExpectedResult = 1)]

        public int HammingDistanceTest(string str1, string str2)
        {
            return Facil.HammingDistance(str1, str2);
        }

        [Test]
        [TestCase("Donald Trump", ExpectedResult = "Trump Donald")]
        [TestCase("Rosie O'Donnel", ExpectedResult = "O'Donnel Rosie")]
        [TestCase("Seymour Butts", ExpectedResult = "Butts Seymour")]
        [TestCase("Ebony Greene", ExpectedResult = "Greene Ebony")]
        [TestCase("Ken Kennedy", ExpectedResult = "Kennedy Ken")]
        [TestCase("Allison Gonzalez", ExpectedResult = "Gonzalez Allison")]
        [TestCase("Albert Frazier", ExpectedResult = "Frazier Albert")]
        [TestCase("Eloise Hopkins", ExpectedResult = "Hopkins Eloise")]
        [TestCase("Donnie Welch", ExpectedResult = "Welch Donnie")]
        [TestCase("Vernon Thomas", ExpectedResult = "Thomas Vernon")]

        public string NameShuffleTest(string name)
        {
            return Facil.NameShuffle(name);
        }


        [Test]
        [TestCase("21", "44", ExpectedResult = "21")]
        [TestCase("153", "367", ExpectedResult = "153")]
        [TestCase("1500", "16", ExpectedResult = "16")]
        [TestCase("100", "23", ExpectedResult = "23")]
        [TestCase("1500", "1", ExpectedResult = "1")]
        [TestCase("5", "5", ExpectedResult = "5")]
        public string SmallerNumTest(string num1, string num2)
        {
            return Facil.SmallerNum(num1, num2);
        }


        [Test]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(6, ExpectedResult = 720)]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(12, ExpectedResult = 479001600)]
        [TestCase(5, ExpectedResult = 120)]
        public static int FactorialTest(int num)
        {
            return Facil.Factorial(num);
        }

        [Test]
        [TestCase("Celebration", ExpectedResult = 5)]
        [TestCase("Palm", ExpectedResult = 1)]
        [TestCase("Prediction", ExpectedResult = 4)]
        [TestCase("Suite", ExpectedResult = 3)]
        [TestCase("Quote", ExpectedResult = 3)]
        [TestCase("Portrait", ExpectedResult = 3)]
        [TestCase("Steam", ExpectedResult = 2)]
        [TestCase("Tape", ExpectedResult = 2)]
        [TestCase("Nightmare", ExpectedResult = 3)]
        [TestCase("Convention", ExpectedResult = 4)]
        public static int CountVowelsTest(string str)
        {
            return Facil.CountVowels(str);
        }

        [Test]
        public void SortNumsAscendingTest()
        {
            int[] haystack_1 = new int[] { 1, 2, 10, 50, 5 };
            int[] haystack_2 = new int[] { 80, 29, 4, -95, -24, 85 };
            int[] haystack_4 = new int[] { };
            int[] haystack_5 = new int[] { 47, 51, -17, -16, 91, 47, -85, -8, -16, -27 };
            int[] haystack_6 = new int[] { -51, -73, 65, 69, -76, 74, -14 };
            int[] haystack_7 = new int[] { 45, 98, 35, 65, 97, 21, 33 };
            int[] haystack_8 = new int[] { -23, -69, -54, -2, -32 };
            int[] haystack_9 = new int[] { -21, -9, -96 };
            int[] haystack_10 = new int[] { 0 };

            Assert.AreEqual(new int[] { 1, 2, 5, 10, 50 }, Facil.SortNumsAscending(haystack_1));
            Assert.AreEqual(new int[] { -95, -24, 4, 29, 80, 85 }, Facil.SortNumsAscending(haystack_2));
            Assert.AreEqual(new int[] { }, Facil.SortNumsAscending(haystack_4));
            Assert.AreEqual(new int[] { -85, -27, -17, -16, -16, -8, 47, 47, 51, 91 }, Facil.SortNumsAscending(haystack_5));
            Assert.AreEqual(new int[] { -76, -73, -51, -14, 65, 69, 74 }, Facil.SortNumsAscending(haystack_6));
            Assert.AreEqual(new int[] { 21, 33, 35, 45, 65, 97, 98 }, Facil.SortNumsAscending(haystack_7));
            Assert.AreEqual(new int[] { -69, -54, -32, -23, -2 }, Facil.SortNumsAscending(haystack_8));
            Assert.AreEqual(new int[] { -96, -21, -9 }, Facil.SortNumsAscending(haystack_9));
            Assert.AreEqual(new int[] { 0 }, Facil.SortNumsAscending(haystack_10));
        }

        [Test]
        [TestCase("kkkkk", ExpectedResult = true)]
        [TestCase("ckkkk", ExpectedResult = false)]
        [TestCase("kkkkck", ExpectedResult = false)]
        [TestCase("aabc", ExpectedResult = false)]
        [TestCase("ccc", ExpectedResult = true)]
        [TestCase("aabbbb", ExpectedResult = false)]
        [TestCase("bbbbbb", ExpectedResult = true)]
        public static bool IsIdenticalTest(string str)
        {
            return Facil.IsIdentical(str);
        }
        [Test]
        [TestCase("javascript is cool", ExpectedResult = "j4v45cr1pt 15 c00l")]
        [TestCase("become a coder", ExpectedResult = "b3c0m3 4 c0d3r")]
        [TestCase("hi there", ExpectedResult = "h1 th3r3")]
        [TestCase("programming is fun", ExpectedResult = "pr0gr4mm1ng 15 fun")]
        [TestCase("keep on practicing", ExpectedResult = "k33p 0n pr4ct1c1ng")]
        public static string FixedTest(string str)
        {
            return Facil.HackerSpeak(str);
        }
        [Test]
        [TestCase("HELLO", ExpectedResult = true)]
        [TestCase("HEllo", ExpectedResult = false)]
        [TestCase("mArmALadE", ExpectedResult = false)]
        [TestCase("marmalade", ExpectedResult = true)]
        [TestCase("MARMALADE", ExpectedResult = true)]
        [TestCase("ketchUP", ExpectedResult = false)]
        [TestCase("pickle", ExpectedResult = true)]
        [TestCase("MUSTARD", ExpectedResult = true)]
        public static bool SameCase(string str)
        {
            return Facil.SameCase(str);
        }
        [Test]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(98, ExpectedResult = "98")]
        [TestCase(10, ExpectedResult = "Buzz")]
        [TestCase(4, ExpectedResult = "4")]
        public static string FizzBuzz(int n)
        {
            Console.WriteLine($"Input: {n}");
            return Facil.FizzBuzz(n);
        }
        [Test]
        [TestCase(1, ExpectedResult = "circle")]
        [TestCase(2, ExpectedResult = "semi-circle")]
        [TestCase(3, ExpectedResult = "triangle")]
        [TestCase(4, ExpectedResult = "square")]
        [TestCase(5, ExpectedResult = "pentagon")]
        [TestCase(6, ExpectedResult = "hexagon")]
        [TestCase(7, ExpectedResult = "heptagon")]
        [TestCase(8, ExpectedResult = "octagon")]
        [TestCase(9, ExpectedResult = "nonagon")]
        [TestCase(10, ExpectedResult = "decagon")]
        public string NSidedShapeTest(int n)
        {
            return Facil.NSidedShape(n);
        }

        [Test]
        [TestCase("My friend Dylan got distracted at school", ExpectedResult = 4)]
        [TestCase("Debris was scattered all over the place.", ExpectedResult = 2)]
        [TestCase("The rodents hibernated in their den.", ExpectedResult = 3)]
        public int CountDsTest(string str)
        {
            return Facil.CountDs(str);
        }
        [Test]
        [TestCase(3, ExpectedResult = "Burrrp")]
        [TestCase(5, ExpectedResult = "Burrrrrp")]
        [TestCase(9, ExpectedResult = "Burrrrrrrrrp")]
        [TestCase(10, ExpectedResult = "Burrrrrrrrrrp")]
        [TestCase(13, ExpectedResult = "Burrrrrrrrrrrrrp")]
        [TestCase(18, ExpectedResult = "Burrrrrrrrrrrrrrrrrrp")]
        [TestCase(1, ExpectedResult = "Burp")]
        public string LongBurpTest(int a)
        {
            return Facil.LongBurp(a);
        }
        [Test]
        [TestCase("ClaClaClaClap!", ExpectedResult = 4)]
        [TestCase("ClClClaClaClaClap!", ExpectedResult = 6)]
        [TestCase("CCClaClClap!Clap!ClClClap!", ExpectedResult = 9)]
        [TestCase("ClCCClaClaClaClCClap!CClaClap!Clap!ClClClClaClaClap!Clap!ClClCClap!Clap!ClClap!ClaCClClap!ClClap!Clap!CClClaClaClaCClaCClaClClaCCCClaClap!Clap!ClaClaClap!ClaClap!CClap!Clap!ClClap!", ExpectedResult = 61)]
        [TestCase("Clap!ClClaClap!ClaClap!CClap!ClClClap!CClaClap!CClap!ClClap!ClaClaClClap!ClaClap!ClClCClaClaCClaCCCCClClCClap!ClaCClaClCClap!Clap!ClaClaClaCClaClap!", ExpectedResult = 52)]
        [TestCase("Clap!CClaClClap!ClCClCCClaCClap!ClCCClCClClap!ClClClap!CClap!CClCClap!ClCClap!Clap!Clap!Clap!ClClap!Clap!CClaClClap!ClaClaClaClCClClaClClap!ClaClClaClap!ClaClap!CClClClap!ClClaClClap!Clap!ClaClaClaClaClClap!CClaClClaCClap!ClClClClClap!Clap!CClClap!ClClap!ClaClap!CClClaClaClap!Clap!", ExpectedResult = 97)]
        [TestCase("CClCClaCClap!Clap!ClaClap!ClCCClap!ClClClClap!ClaClCClClaClap!", ExpectedResult = 23)]
        [TestCase("Clap!Clap!ClClCClCClClaClaClaCClaClClaClClClClap!CClap!ClClap!ClClClaClaClClaClaClaClaCClClaClap!", ExpectedResult = 36)]
        [TestCase("ClaCCClClCClClaCClCClap!ClaClClaClap!Clap!ClClClClap!Clap!CClap!CClaClClaClCClaClap!ClaClaClaClap!Clap!ClClap!CCClap!ClClaClap!CClClClap!CClaClaClClaClap!ClClap!ClaCClaClap!Clap!Clap!Clap!CClaCCCClap!ClaClap!ClClap!Clap!CClaClaClaClap!CClaCClap!Clap!CClaCClaClaCClaCClap!", ExpectedResult = 94)]
        [TestCase("CClClap!Clap!CClCClClaCClaClaClap!ClaClaClaCCCClap!CCClClap!Clap!ClaClaClap!ClClClap!ClCCClap!ClaClaClap!CClap!ClaClap!CClClClap!CClap!CClClaCClClap!ClaClap!ClaClClClCClap!ClaClClap!ClaClaCClap!CClClaClClap!ClaClaClClaClClaClaClap!", ExpectedResult = 82)]
        [TestCase("ClaCCClCClaClClaClCClaClaClap!Clap!CClaClap!ClaClap!Clap!ClaClap!Clap!", ExpectedResult = 23)]
        [TestCase("CClClaClClaClClap!Clap!Clap!ClClaClap!ClClClClaClap!CClap!ClaClaCCClap!ClClap!CClap!Clap!Clap!ClaClaClap!ClaClClClaClaClap!ClaClaClap!ClClCClaClaCClClaClap!Clap!Clap!CClClaClaClaClaClCClClaClaCClaClap!ClCClClClap!Clap!Clap!Clap!Clap!CClaClap!Clap!CCClaClCClClaClClClaClaClaClaCClap!Clap!", ExpectedResult = 96)]
        [TestCase("Clap!ClaClCClaClap!ClCClap!ClClClaClap!ClaClaCClap!ClaClaClap!ClaCClap!Clap!CClClClap!ClClCClaCClCClaCClClClClaClap!ClClaCClap!CCCClap!Clap!ClClap!ClaCClaCClClap!ClClaClap!ClClaClaClaClaCCClClap!CClaClaClap!Clap!ClClap!", ExpectedResult = 78)]
        [TestCase("Clap!ClaClCClaClaClap!CClaClap!CCClCClap!Clap!Clap!Clap!ClClap!Clap!ClaClaClClap!Clap!ClaClaClap!CClaClap!CCClClap!ClaClaClap!ClClaClaClaClaClap!CClap!ClaClCClaClap!CClClCClaClap!Clap!CClaCClap!", ExpectedResult = 63)]
        [TestCase("Clap!CClaClap!ClClap!ClClClap!ClaCClap!ClaCClClap!CClap!CClClaClap!ClaClaClCCClap!Clap!CClClaClCClaClaClClap!Clap!CClaCClaCClap!ClaCClClCClap!CClap!CClap!ClaClaClaClaClap!ClClap!CClaClaClaClClaClClCClClCClClaClaCClClap!", ExpectedResult = 80)]
        [TestCase("CClaCClClap!Clap!Clap!Clap!Clap!Clap!Clap!ClClClap!CClap!CClap!CCClaClClClClClaCClaClap!ClClap!CClaClap!Clap!CCClaClap!Clap!CClClClaClaClaClap!ClaCClap!ClClaClaCClClap!CClap!ClaClap!", ExpectedResult = 60)]
        [TestCase("ClaCCClap!", ExpectedResult = 4)]
        [TestCase("ClaClap!ClaClaClap!Clap!", ExpectedResult = 6)]
        [TestCase("CClap!ClaClaClClap!Clap!ClaCCClap!ClClaClap!CClap!CClap!ClaClClaCClaClap!ClaClap!ClaClClaClaCCClClaClaClap!Clap!", ExpectedResult = 37)]
        [TestCase("ClClaCClap!ClaCClaClap!Clap!Clap!ClaClClap!ClClaClaClClaClaClaCCClClClClClap!", ExpectedResult = 27)]
        [TestCase("ClClClCClClap!Clap!CCCClap!ClCCClClap!CCClap!Clap!Clap!CClap!ClaClaCClaCClaClaClaClClap!ClaClCCClClaClap!ClClaClaCClCCClClClap!Clap!ClaClap!ClaClaCClap!ClCCClaClap!ClaClap!CClap!CClaClClaClCClaClap!CClClap!ClClap!Clap!CClap!CClaClaClClaClap!", ExpectedResult = 88)]
        [TestCase("ClClCClClClaClClCClap!ClCClap!ClaClaClClap!ClaCClClap!ClClaClap!ClaClaClaClap!Clap!Clap!CCCClaClaClaClaClaCClCClaClaClap!Clap!CCCClap!ClaClap!CCClaClaClaClap!ClClClap!CClCCCClap!Clap!CClClClaClap!ClClaCClClap!ClaClClap!ClaClap!ClCClaClaCClap!", ExpectedResult = 88)]
        [TestCase("ClClap!Clap!CCClClClaClClClClap!Clap!CClap!ClClap!ClClaCCClap!", ExpectedResult = 22)]
        [TestCase("ClaClaClClClaCClap!ClaClaCCClaClaClClap!CClCClCClClClClap!ClaClap!Clap!ClaCCClap!ClCCClaClClClaCCClaClCClClaClap!ClClaClClaClap!ClClap!Clap!ClaClaClClap!", ExpectedResult = 58)]
        [TestCase("ClaCClClClClaClClap!ClClap!CCClaCCClClCCClaClap!Clap!CClClClap!ClaCClClaCClaCClClap!ClClClClaCClaClap!Clap!", ExpectedResult = 43)]
        [TestCase("ClaClCClClCClCClaCCClap!ClaClaCClap!ClaClap!CClaClaClClaCClClaClaClCCClaClap!ClClap!Clap!Clap!ClaCCClap!ClClaClaClap!ClaClap!CCClap!CClap!CClClap!", ExpectedResult = 54)]
        [TestCase("Clap!ClaCCCCCClClaCCCClaClaClClap!CClaCClaCClap!CClap!CClCClClap!CCCCClaClap!", ExpectedResult = 35)]
        [TestCase("ClClaClap!Clap!ClCClaClaCClaCClaClap!CCClaCClaClClap!Clap!ClCCCClaClaClap!Clap!ClaClap!ClaClClap!ClCClCClaClClap!CClaClap!ClClClaCClaCClap!Clap!ClCClCClap!ClaCCClClap!Clap!Clap!CClaClaClap!ClaCClaCClap!", ExpectedResult = 73)]
        [TestCase("CClaClClaClap!ClClClaCClaClaCClCClCClaClaCClaClap!CCCCClap!ClaCClClaClClap!ClClClap!ClCClaClCClClClap!CClap!ClaClClap!ClCClap!", ExpectedResult = 51)]
        [TestCase("ClaClaClaCClClap!ClaClap!Clap!ClCCCClaClap!Clap!CCClClClaClaCClClap!CClClaClClap!ClCCClaClClap!Clap!CClaCCCClClap!", ExpectedResult = 44)]
        [TestCase("CClClap!ClClCClaClClaClaClap!ClaCClClaClaClaClaClap!ClClaClap!Clap!CClap!CClaClClap!ClClap!CClaClClap!ClaCCClap!CCClaClaClClClaClaClClap!CCClClaClClClClap!ClClap!ClaClClClap!Clap!CClaClaClaCClap!Clap!Clap!ClaClClClap!CClaClaClaClaClaCClClClaClap!ClClap!ClClaCClaClaCClClap!Clap!", ExpectedResult = 98)]
        [TestCase("ClaCClaClap!CClap!ClClaClClaClaClaClCClaCClap!", ExpectedResult = 17)]
        [TestCase("ClaClClap!", ExpectedResult = 3)]
        [TestCase("ClClaClap!CClaCClClap!", ExpectedResult = 8)]
        [TestCase("ClCClaClaClap!Clap!ClaCCClap!CClCClaClClap!CClClap!ClClCCCCClaCClClClaClClCClaClap!Clap!", ExpectedResult = 36)]
        [TestCase("Clap!CClaCCCClClaClaClaClap!ClClaClClap!", ExpectedResult = 15)]
        [TestCase("CClap!ClCCCCClClaClap!ClClClap!CClap!ClaClaClaClCCClCCClaClClap!Clap!CClaClClCClap!ClaClClap!ClCClaClaClap!", ExpectedResult = 42)]
        [TestCase("Clap!ClaCClap!CCCCClaClap!ClClaCClClap!ClaClClap!ClaClClaClaClaClCCCClaClaCClap!Clap!ClaCCClap!ClClap!ClClap!ClClap!CClClClClap!Clap!CClaCClClClap!ClaCClClaCCClClap!CCClap!", ExpectedResult = 65)]
        [TestCase("Clap!ClCClClap!CCClap!ClClap!ClClaClaClap!ClCClClClaClClap!ClCClap!Clap!Clap!ClCClap!ClCCClCClap!Clap!ClClCClCClap!ClCClaClaClCClap!", ExpectedResult = 49)]
        [TestCase("ClCClap!ClaClap!CCClClCCClaClClCClaClClap!CClap!CClaClCClClap!ClClap!", ExpectedResult = 28)]
        [TestCase("Clap!ClaClaCClap!", ExpectedResult = 5)]
        [TestCase("ClClap!ClClap!ClaCCClap!ClClCClaClaClCClap!Clap!Clap!ClClaCClClaClap!Clap!ClClClClap!ClCCCClaClClap!Clap!ClClClap!ClaCClap!CClaClap!Clap!ClClClaClClClClaClaClClaClaClClClaCCClap!ClaClap!Clap!ClClClap!Clap!Clap!", ExpectedResult = 72)]
        [TestCase("CClaCClCCClClClap!ClClaCCClap!Clap!Clap!ClClCClClClClaClaCClap!ClClClap!CClap!ClaClClaCCClClaClClap!CClCCCClaClaClCCClap!CClap!Clap!ClaClaClClaClClClaClaCClClap!Clap!CCClaClap!CClClaCClap!ClClClap!Clap!ClaClaClClClClap!Clap!ClaClap!", ExpectedResult = 88)]
        [TestCase("CClClaCClaClClClaClaClap!Clap!ClaClaCClClaClaCClCClap!", ExpectedResult = 21)]
        [TestCase("CClap!ClaClap!ClClap!CClaClClaClClap!CCClap!CClCCClap!CClap!Clap!ClClap!ClClap!Clap!ClClap!ClClClaClaCClaClaClCClap!ClaClap!CClap!ClaCClClap!Clap!Clap!Clap!ClClap!ClClClaCCClClap!ClaCCClaClCCClaClap!", ExpectedResult = 69)]
        [TestCase("CClClap!Clap!ClCCClaClClCClClap!ClClClaCCClClaClaCClap!ClClap!Clap!ClClaClClClaCClaClClClaClClClaCClaClCClap!ClCCClClCClap!CCClClap!CClaClClap!ClCClClaClaClaClap!Clap!CClClap!ClaCClaClClClCClap!ClaClClClaClaCClaClap!", ExpectedResult = 86)]
        [TestCase("Clap!Clap!ClClap!Clap!CClClaClaCClCClClap!ClClaCClClClCClaClClClaClClCClaCClClClap!ClaClap!ClClaClCCClaClaClaCCClaClap!", ExpectedResult = 47)]
        [TestCase("ClaClaClClClap!Clap!ClClClClap!", ExpectedResult = 10)]
        [TestCase("ClaClap!CClap!ClClClClap!CClaClClClap!CCClaClaClap!ClaClap!CClaCClClClaClap!ClClClClCClaCClap!ClClap!Clap!", ExpectedResult = 38)]
        [TestCase("CCClaClClClClap!Clap!ClCCClClClaClCClCCClClap!", ExpectedResult = 21)]
        [TestCase("ClClap!", ExpectedResult = 2)]
        [TestCase("Clap!CCClClClaClap!ClaCClClap!CClClaClClaClap!Clap!ClaClap!", ExpectedResult = 20)]
        [TestCase("ClaClap!CClaClaClap!CClClClap!ClCClap!Clap!Clap!", ExpectedResult = 15)]
        [TestCase("ClaCClap!ClClap!ClaCClClaClap!Clap!Clap!", ExpectedResult = 12)]
        [TestCase("ClClap!ClaClaCCClaClCClap!CClap!ClaClClaClap!CClClap!ClClap!ClaCClaCClaClaClCClaClaClaClClap!ClClap!CClaClap!Clap!CClap!ClCClap!ClaClaClap!ClaClap!ClClClCCClClaCCClaClClaClClClClaClClaClClap!ClaClap!CCClCClaCClClap!ClaClaClap!", ExpectedResult = 83)]
        [TestCase("ClCClCClap!Clap!ClaClaClap!ClaCClClClap!ClaClaClaClap!ClClaClap!ClCCCClaCCClaClap!CClap!ClClap!ClaClap!CCCCClaClap!Clap!", ExpectedResult = 43)]
        [TestCase("Clap!ClClClCClap!ClClap!ClClap!ClaClaClap!CClap!", ExpectedResult = 15)]
        [TestCase("ClaClClap!ClCClaCClap!ClClap!CClaClap!CClClaCClaClap!CClaClaClaCCCCClap!CClaClaClClaClClap!ClClap!ClCClap!Clap!ClClap!CClClaClClap!CClaCClap!CClClap!ClaCClap!Clap!ClaClap!Clap!Clap!ClaClClap!Clap!Clap!ClClaClaClap!CClaClCClap!ClClClClaClaCClaClClClClap!", ExpectedResult = 88)]
        [TestCase("ClClCClap!ClaClClaCCClaClaCClaClap!CClaClap!ClaCClClaClaClClap!ClaClaClClap!ClClCClaCClClap!", ExpectedResult = 35)]
        [TestCase("ClaClClClap!Clap!ClClaClClaClaCClClaClap!ClaClClClaClClaClClaClClClaClCClaClap!CCCClap!Clap!CClap!Clap!ClaClap!CClap!ClClap!CClClClaClap!ClClCClaClClap!ClaClClaClaClCClClClap!ClClaClap!Clap!ClaCClClClaCClap!Clap!ClClaClClClClaClClap!ClClap!", ExpectedResult = 85)]
        [TestCase("CClaClaClaClap!Clap!Clap!", ExpectedResult = 7)]
        [TestCase("Clap!ClClClaClaClCClap!", ExpectedResult = 8)]
        [TestCase("ClClap!Clap!Clap!CClCClap!Clap!Clap!CClClaCClap!ClaClap!Clap!ClClaClClCClap!", ExpectedResult = 24)]
        [TestCase("ClCClap!ClaClaClap!CClap!Clap!ClaClap!ClaClClap!Clap!ClClaClap!ClClClaClaClaClaClaClaClap!", ExpectedResult = 27)]
        [TestCase("CClap!ClaClClap!ClCClap!CClaCClClaClClap!CClap!CCCClClaClClap!CCClaClaClap!CCClap!Clap!Clap!Clap!ClClaCCCClaClClap!ClaClap!ClaClClaClap!Clap!ClaCClap!Clap!ClClClap!Clap!ClClaCClClaClap!Clap!Clap!ClCCClClap!Clap!ClCClCCClaClap!ClaCCClClClCCClClClaClaClap!Clap!ClaClaCClaClap!", ExpectedResult = 98)]
        [TestCase("Clap!ClClClaCClap!CClap!ClaCClaClCClap!Clap!CClaCClCCClClClap!ClaClaCCCClClaCClaClClap!CClCClClap!Clap!CCClaClaClClaClaClap!Clap!ClCClaClaClClClap!Clap!ClaClClap!ClClClap!ClaClap!CCClap!ClaClap!ClClap!Clap!ClaClap!ClClClap!Clap!Clap!ClaCCClap!CClap!ClClaCClaClaClap!ClaCClap!ClaClCCClap!", ExpectedResult = 101)]
        [TestCase("CCCCClClClap!ClaCClClClClaClClClaClClaClaClCCClap!ClClaCClap!CClap!Clap!ClaClap!Clap!Clap!", ExpectedResult = 34)]
        [TestCase("ClClap!ClCClap!CClaClap!ClCClaCCClap!ClClap!CClap!CCClaClap!Clap!CClaClap!Clap!ClaClaClap!ClaClClClClaClCCCClap!CClap!CClap!CClaClClClClaClaClClClCClCClap!ClaCCClClClCCClClap!CClClap!Clap!ClaCClap!ClaClaCClaClap!ClaClaClap!", ExpectedResult = 83)]
        [TestCase("Clap!Clap!Clap!ClClClCClClClap!Clap!Clap!ClClClClaClap!ClClClaClap!ClaClap!ClCClap!Clap!ClCClaCClClaClCCClClaCClCClCClaClap!Clap!CClaClap!ClClap!Clap!CCClap!CClaCClClClClap!ClClap!Clap!ClaClaClaCClap!ClClClap!Clap!Clap!", ExpectedResult = 75)]
        [TestCase("Clap!ClaCClaClClap!ClCClaClClClap!ClClap!Clap!Clap!CClap!ClaClCClaClCClap!Clap!ClaClaClaClaClaClClap!CClCCClaCClap!ClaCClClaCCClClap!CClClCClaClap!ClaClCClCClap!ClaClCClClClap!ClClaClap!ClClap!ClCClaClClaCClaClaClClCClap!Clap!CClap!", ExpectedResult = 86)]
        [TestCase("ClaCClap!ClClaCCClap!Clap!ClaClap!", ExpectedResult = 11)]
        [TestCase("Clap!ClaClap!ClaClap!ClCClaClap!Clap!CCClaClaClap!ClaClaClap!ClClaCClClaCClaClClap!ClClClap!ClCClClCClap!Clap!", ExpectedResult = 37)]
        [TestCase("ClClaClClaClaCClClap!ClaClaClaCClap!CCClClap!ClClaCClClaClaClaClap!ClaCCClaClaClap!ClaCClaClap!", ExpectedResult = 35)]
        [TestCase("ClClaClClap!ClClaClap!Clap!ClaClClClap!ClaClap!ClaCCClap!Clap!ClClap!ClClaCClClCClClClaClap!ClClClCClaClap!CClap!ClClClap!ClCCClap!Clap!CClClCClaCClCClaClClap!CClaCCClap!CCClaClClap!ClaClClap!Clap!ClaClClap!ClaClaClap!Clap!ClaClap!ClClCClaCClaClClap!", ExpectedResult = 89)]
        [TestCase("ClaClaClClap!ClaClCCClaClaCClap!CClCClap!Clap!", ExpectedResult = 17)]
        [TestCase("CCClaCClap!ClClaClaClaClaClaClaCClaClap!Clap!CClClap!CClClaClap!Clap!ClClClaClaCClaCClaClClap!ClClClap!CClaClaClaClap!Clap!ClClap!Clap!ClaCClClClap!ClaClaClap!CCClClap!Clap!ClCCClClaClClCClap!ClaClap!", ExpectedResult = 70)]
        [TestCase("ClCClaClap!ClClClClap!ClaClaCClaClClClap!CClCClCClClap!CClCClClClClaClCClap!CClaCCCCCClClap!ClaClaClaClClaClaClClaCClClap!Clap!CCClaClClaClap!ClCClap!CClClap!Clap!ClaClClap!CClaClaClap!CClClaClap!Clap!", ExpectedResult = 78)]
        [TestCase("Clap!ClaClClCClaClCClaClClaClap!Clap!", ExpectedResult = 13)]
        [TestCase("CClClap!Clap!CClaClap!ClaClap!ClCCClaClClap!ClaCClClaCClap!ClaClClClap!CClap!Clap!", ExpectedResult = 28)]
        [TestCase("ClClaClap!CCClClClaCCClCClClap!ClaClCClaClClap!ClaClap!ClClaCClClaClaClaCClClaClap!ClClaClap!Clap!CCClClaClap!Clap!CClClClClClaClClCClClaCClap!Clap!ClaClaClCClap!Clap!ClaClaClClap!CClaCClaCClaClClaClap!CClap!ClCClap!CClCClaClaClClaClaClap!Clap!Clap!ClClaClap!Clap!", ExpectedResult = 96)]
        [TestCase("ClaClap!ClaClCClClClClap!Clap!CClaClap!Clap!CCClaClaCClaCCCCClaClaClaCClClClaClap!ClClap!CClaCClClClap!ClaClCCCClap!ClClClaClClaClClap!", ExpectedResult = 53)]
        [TestCase("ClClap!CClap!Clap!CClaCClClaCClClCClap!", ExpectedResult = 15)]
        [TestCase("CClCClap!ClClap!ClCClaClap!Clap!CClaClaClaClClClap!", ExpectedResult = 18)]
        [TestCase("ClaClCClaCClaClaClClaClClaClap!ClaCCClClaClap!Clap!CClap!ClCClap!CClClClap!ClClap!CClClap!", ExpectedResult = 33)]
        [TestCase("ClaClap!ClClClap!ClClaClaCCCClaClClap!Clap!ClaClaClap!ClClap!Clap!CClap!Clap!CClClClap!ClaClCClap!Clap!ClClap!ClaCClap!Clap!", ExpectedResult = 39)]
        [TestCase("ClClap!CCClap!ClClaClaCClCCClap!ClCCCClaClClaClap!ClClClaClClClaCCClaClap!Clap!Clap!ClCClaClaClap!ClaClCCClClClaClClClap!Clap!Clap!ClaCClap!ClClCClaClap!Clap!CClaClap!Clap!", ExpectedResult = 63)]
        [TestCase("ClaClClCClClClap!ClaClaClap!Clap!ClClap!ClCClap!ClClap!ClaClap!ClaCClaClap!CClaClap!ClaClClaClaClap!ClClaClap!ClaCClap!CClClaCClap!Clap!CCClClCCCClClClClaCClClap!", ExpectedResult = 58)]
        [TestCase("ClaClap!ClaClClap!ClCClClClaCClap!ClCClaClaClaClaClaCClap!ClClap!Clap!ClClaClCClap!ClaCClaClap!Clap!Clap!CClaCClClap!Clap!CClaClap!ClClClClaClap!ClaClap!", ExpectedResult = 51)]
        [TestCase("ClCClCClCClClap!ClaClap!ClClaCCClCClaClaClap!CCClaClClap!ClClap!ClaClap!CClap!Clap!ClaClClaClap!Clap!ClClCClaClClClaClaClaClap!", ExpectedResult = 46)]
        [TestCase("CClClClap!CCClap!CClap!Clap!CClClap!CCClaClClaCClap!ClaCClClCClap!Clap!CClap!ClaCClaClaClaClap!", ExpectedResult = 35)]
        [TestCase("ClaCClaClap!CClCCClap!ClClap!CClap!Clap!ClCClCCCClCClap!ClaClClCCClaClap!", ExpectedResult = 30)]
        [TestCase("CClaClClap!CClClClap!ClaClap!CClClClClaClaCCClaClaClap!Clap!Clap!ClaCClap!ClClCClap!ClaClClCCCClap!ClaClap!Clap!CCCCClaClap!CClap!Clap!ClaClClap!ClaClClaClClClap!Clap!", ExpectedResult = 59)]
        [TestCase("ClClap!ClClaCClaCClap!CCCClap!Clap!ClClClap!Clap!Clap!ClCCClaClClCCClap!ClClap!CCClClap!ClaClap!ClaClap!ClCClap!Clap!ClaClCClClCClap!ClaCClCClap!Clap!Clap!ClClClClap!ClaCClaClaClCClClaClap!CClap!CCCCClaClap!ClaClap!", ExpectedResult = 78)]
        [TestCase("ClClaClap!ClaClaClap!Clap!Clap!Clap!ClaClaClap!ClaCClaClap!ClClClap!Clap!CClaClap!CClClaClClCClap!ClaClap!ClClaClap!ClCCClaClCClap!ClCClClaClap!ClClaClap!Clap!Clap!Clap!ClCClap!ClClClaClap!Clap!Clap!ClaCClaClClaClCClClap!ClClCCClCClaClCClCCClClaClaClaClap!CClClClap!", ExpectedResult = 92)]
        [TestCase("CClClap!ClClap!ClaClap!ClaCCCClaClaCClap!CClap!CClClaClap!CClap!ClClClaClClaClap!CClClaCClap!ClClaCClClaClap!CClap!CClClap!CClap!Clap!Clap!ClClClap!ClClaClap!CCClap!CCClCClCClCClaClaClClaClaClap!", ExpectedResult = 72)]
        [TestCase("CCClaClap!CClaClClaClaCClaClClap!ClaCClCClaCClClClaClaCClaCCCClClap!ClaClaClaCClap!ClaClClaClClap!Clap!CClaCClap!CClClap!Clap!ClaCCClCClClap!ClaClaClaCCClaClaClaClCCClaClCClClap!", ExpectedResult = 72)]
        [TestCase("ClCClap!ClaClaClCClap!CClap!Clap!ClClCCClClap!CCCClClClaClap!Clap!Clap!ClClaClClaClap!ClCCClaClap!CClClaCCClap!Clap!Clap!CClClaClap!Clap!ClaClCClap!ClCCClap!ClaClap!CCClaClap!CCClaClap!CClaClClaClaClaClap!Clap!CClap!Clap!Clap!Clap!ClClap!", ExpectedResult = 82)]
        [TestCase("CClCCCCClap!CClap!Clap!CClap!ClaClaCCCClaClap!Clap!Clap!ClClap!CClaClaClaClaCClap!CClap!ClaCCClClaClClCCClaClaClCClaCCClap!", ExpectedResult = 49)]
        [TestCase("ClClaClap!ClaCClaClaClap!Clap!CClClaClap!ClaClap!ClaClClaClaClap!ClaCClCCClaClaCClCClClap!ClCClap!ClClaClaClCClaClap!ClaClClaCCClap!ClaClap!ClClaClap!CClCClap!ClaClap!ClaClCClaClaCClap!ClClClap!Clap!CClClap!Clap!ClClaCClaCClaClap!Clap!CCClaClaClClap!Clap!ClCClClaClaClaClClClCClap!", ExpectedResult = 100)]
        [TestCase("ClClap!ClCClClClap!CCClaCCCClaClCClClaClClClaClap!ClaClap!ClCClClap!ClaClap!ClaClClClap!ClCClaCClClap!ClClClClap!ClaClClaClap!ClClClaCClaClClaCClap!CClClap!ClaClap!Clap!ClaCClap!ClaClClap!CClClClaClCClaClaClaCClap!ClaClap!CClap!", ExpectedResult = 84)]
        [TestCase("ClaClCClap!Clap!ClaClaClaClap!ClaClap!CClClap!ClaClCClaClClCCClClClClaClap!Clap!CClap!Clap!ClaCClaClClaCClap!ClClCCClaClClaClaCCClClap!Clap!CClaClap!CClap!ClClClap!ClaClaCClaCClClaClaClClaCClClap!ClCCClClap!ClCClap!CClaClaClap!Clap!ClaClap!ClCClaClap!Clap!", ExpectedResult = 92)]
        [TestCase("ClCClap!Clap!Clap!ClaCClap!Clap!ClaClaClaClap!Clap!ClaClClap!", ExpectedResult = 17)]
        [TestCase("ClClap!CClap!ClClaClaClClClClaClaClap!CCClaClaClaClap!ClClaClap!Clap!ClCClaCClap!ClClaCClaClap!Clap!ClaClaClap!ClaClap!CClap!ClCClap!ClClap!ClaClaClaClaClaClap!CClClClaCClap!CClaCCClaCClap!Clap!CCCClap!ClClClaCClap!Clap!ClaClClap!ClaClCClClap!", ExpectedResult = 84)]
        public int CountClapsTest(string a)
        {
            return Facil.CountClaps(a);
        }
        [Test]
        [TestCase("hello", ExpectedResult = "ell")]
        [TestCase("benefit", ExpectedResult = "enefi")]
        [TestCase("wordy", ExpectedResult = "ord")]
        [TestCase("maybe", ExpectedResult = "ayb")]
        [TestCase("to", ExpectedResult = "to")]
        [TestCase("a", ExpectedResult = "a")]
        [TestCase("", ExpectedResult = "")]
        public string RemoveFirstLastTest(string str)
        {
            return Facil.RemoveFirstLast(str);
        }
        [Test]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(5, ExpectedResult = 15)]
        [TestCase(7, ExpectedResult = 28)]
        [TestCase(10, ExpectedResult = 55)]
        [TestCase(12, ExpectedResult = 78)]
        [TestCase(15, ExpectedResult = 120)]
        [TestCase(20, ExpectedResult = 210)]
        [TestCase(100, ExpectedResult = 5050)]
        public int SumTest(int input)
        {
            return Facil.Sum(input);
        }

    }
}

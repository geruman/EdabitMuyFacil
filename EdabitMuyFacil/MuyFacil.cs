using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitMuyFacil
{
    public class MuyFacil
    {
        public static int SumOfPolygonAngles(int n)
        {
            return (n - 2) * 180;
        }
        public static bool AndOperator(bool a, bool b)
        {
            return a && b;
        }
        public static int FindPerimeterOfRectanble(int length, int width)
        {
            return (length * 2) + (width * 2);
        }
        public static string NameGreeting(string name)
        {
            return "Hello " + name + "!";
        }
        public static int BasketballPoints(int doblePunto, int triplePunto)
        {
            return doblePunto * 2 + triplePunto * 3;
        }
        public static int FarmProblem(int chickens, int cows, int pigs)
        {
            return chickens * 2 + cows * 4 + pigs * 4;
        }

        public static int FootbalPoints(int wins, int draws, int looses)
        {
            int puntos = 0;
            puntos = puntos + wins * 3;
            puntos = puntos + draws;
            return puntos;

        }
        public static object GetFirstValue(object[] array)
        {
            return array[0];
        }
        public static string Greeting(string name)
        {
            if (name == "Mubashir")
            {
                return "Hello, my Love!";
            }
            return "Hello, " + name + "!";
        }
        public static int Convert(int hours, int minutes)
        {
            int total = hours * 3600;
            total = total + minutes * 60;
            return total;
        }
        public static int NextEdge(int side1, int side2)
        {
            return side1 + side2 - 1;
        }
        public static int InchesToFeet(int inches)
        {
            return (int)(inches / 12);
        }
        public static bool DivisibleByFive(int value)
        {
            if (value % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Squared(int value)
        {
            return value * value;
        }
        public static bool DividesEvenly(int value, int divisor)
        {
            return value % divisor == 0;
        }
        public static int Frames(int minutes, int fps)
        {
            return (fps * 60) * minutes;
        }
        public static bool ProfitableGamble(double prob, int prize, double pay)
        {
            return ((prob * prize) > pay);
        }

        public static int FlipIntBool(int ib) => ib switch
        {
            0 => 1,
            1 => 0,
            _ => throw new ArgumentOutOfRangeException()
        };

        public static bool DivisibleByOneHundred(int num)
        {
            return num % 100 == 0;
        }

        public static bool IsItChristmasEve(int month, int day)
        {
            return month == 12 && day == 24;
        }

        public static int HowManyStickers(int sideLength)
        {
            return (sideLength * sideLength) * 6;
        }

        public static List<int> PrintArray(int values)
        {
            var result = new List<int>();
            for (int i = 1; i <= values; i++)
            {
                result.Add(i);
            }
            return result;
        }

        public static int NthEven(int positionAsked)
        {
            return (positionAsked - 1) * 2;
        }

        public static int ReturnNegative(int num)
        {
            int aux = 0;
            if (num > 0)
            {
                return aux - num;
            }
            return aux + num;
        }

        public static string ConcatName(string firstName, string lastName)
        {
            return $"{lastName}, {firstName}";
        }

        public static int StackBoxes(int num)
        {
            return num * num;
        }

        public static int RectangleArea(int h, int w)
        {
            if(h <= 0 || w <= 0)
            {
                return -1;
            }
            return h * w;
        }

        public static bool IsEmpty(string s)
        {
            return s == "";
        }

        public static bool CompareStringsByLength(string str1, string str2)
        {
            return str1.Length == str2.Length;
        }

        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitMuyFacil
{
    public class Media
    {
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] array = new int[length];
            for (int i = 1; i <= length; i++)
            {
                array[i - 1] = i * num;
            }
            return array;
        }

        public static int[] IndexOfCapitals(string str)
        {
            List<int> indexOfCapitals = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    indexOfCapitals.Add(i);
                }
            }
            return indexOfCapitals.ToArray();
        }

        public static string ReverseCase(string str)
        {
            string aux = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    aux += char.ToLower(str[i]);
                }
                else if (char.IsLower(str[i]))
                {
                    aux += char.ToUpper(str[i]);
                }
                else
                {
                    aux += str[i];
                }
            }
            return aux;
        }

        public static string Bomb(string a)
        {
            if (a.ToLower().Contains("bomb"))
            {
                return "Duck!!!";
            }
            return "There is no bomb, relax.";
        }

        public static string[] ParseArray(object[] array)
        {
            string[] outputArray = new string[array.Length];
            for (int i = 0; i < outputArray.Length; i++)
            {
                if (array[i] != null)
                {
                    outputArray[i] = array[i].ToString();
                }
            }
            return outputArray;
        }

        public static bool CheckEquality(object a, object b)
        {
            return a.GetType() == b.GetType() && a.Equals(b);
        }

        public static double[] FindLargest(double[][] arrayOfArray)
        {
            double[] result = new double[arrayOfArray.Length];
            for (int i = 0; i < result.Length; i++)
            {
                double largest = double.MinValue;
                foreach (var number in arrayOfArray[i])
                {
                    if (number > largest)
                    {
                        largest = number;
                    }
                }
                result[i] = largest;
            }
            return result;
        }

        public static int collatz(int num)
        {
            int steps = 0;
            while (num != 1)
            {
                steps++;
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num * 3 + 1;
                }
            }
            return steps;
        }

        public static int CounterpartCharCode(char symbol)
        {
            byte result;
            char[] chars = new char[1];

            if (char.IsUpper(symbol))
            {
                chars[0] = char.ToLower(symbol);
                result = Encoding.ASCII.GetBytes(chars)[0];
            }
            else
            {
                chars[0] = char.ToUpper(symbol);
                result = Encoding.ASCII.GetBytes(chars)[0];
            }
            return result;
        }

        public static bool GreaterThanOne(string a)
        {
            var numbers = a.Split('/').Select(x => Convert.ToDouble(x)).ToList();
            return (numbers[0] / numbers[1]) > 1;
        }
    }
}

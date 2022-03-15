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
            char counterpart = char.IsUpper(symbol) ? char.ToLower(symbol) : char.ToUpper(symbol);
            if (char.IsAscii(counterpart))
            {
                return (byte)counterpart;
            }
            return (short)counterpart;
        }

        public static bool GreaterThanOne(string a)
        {
            var numbers = a.Split('/').Select(x => Convert.ToDouble(x)).ToList();
            return (numbers[0] / numbers[1]) > 1;
        }

        public static int CountOnes(int value)
        {
            int result = 0;
            string binary = Convert.ToString(value, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    result++;
                }
            }
            return result;
        }

        public static int[] CountPosSumNeg(int[] numberArray)
        {
            int countPos = 0;
            int sumNeg = 0;
            if (numberArray.Length == 0)
            {
                return new int[] { };
            }
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] > 0)
                {
                    countPos++;
                }
                else
                {
                    sumNeg += numberArray[i];
                }
            }
            return new int[] { countPos, sumNeg };
        }

        public static bool IsIsogram(string word)
        {
            word = word.ToLower();
            for (int i = 0; i < word.Length - 1; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsStrangePair(string str1, string str2)
        {
            if (str1 == "" && str2 == "")
            {
                return true;
            }
            else if (str1 == "" || str2 == "")
            {
                return false;
            }
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            return str1[0] == str2[str2.Length - 1] && str1[str1.Length - 1] == str2[0];
        }

        public static int SumSmallest(int[] values)
        {
            int[] positives = Array.FindAll(values, x => x > 0);
            if (positives.Length == 0)
            {
                return 0;
            }
            else if (positives.Length == 1)
            {
                return positives[0];
            }
            else
            {
                Array.Sort(positives);
                return positives[0] + positives[1];
            }
        }

        public static int[] FilterArray(object[] haystack_1)
        {
            object[] filtered = Array.FindAll(haystack_1, x => x is int);
            int[] result = new int[filtered.Length];
            for (int i = 0; i < filtered.Length; i++)
            {
                result[i] = (int)filtered[i];
            }
            return result;
        }

        public static string HighLow(string str)
        {
            string[] letters = str.Split(' ');
            if (letters.Length == 1 && letters[0] == "")
            {
                return letters[0];
            }
            List<int> numbers = new List<int>();
            for (int i = 0; i < letters.Length; i++)
            {
                numbers.Add(Convert.ToInt32(letters[i]));
            }
            numbers.Sort();
            return $"{numbers[numbers.Count - 1]} {numbers[0]}";
        }

        public static bool isPrime(int x)
        {
            if(x <= 1)
            {
                return false;
            }
            for(int i = 2; i < x; i++)
            {
                if(x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidatePIN(string pin)
        {
            if(pin.Length != 4 && pin.Length != 6)
            {
                return false;
            }
            foreach(var letter in pin)
            {
                if(!char.IsDigit(letter))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

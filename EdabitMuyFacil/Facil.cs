using System.Text;
using System.Text.RegularExpressions;

namespace EdabitMuyFacil
{
    public class Facil
    {
        public static string MonthName(int monthNumber) => monthNumber switch
        {
            1 => "January",
            2 => "February",
            3 => "March",
            4 => "April",
            5 => "May",
            6 => "June",
            7 => "July",
            8 => "August",
            9 => "September",
            10 => "October",
            11 => "November",
            12 => "December",
            _ => throw new IndexOutOfRangeException()
        };

        public static double[] FindMinMax(double[] array)
        {
            double min = array[0];
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            return new double[]{min, max};
        }

        public static int GetAbsSum(int[] array)
        {
            int acum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                acum += GetAbs(array[i]);
            }
            return acum;
        }

        private static int GetAbs(int num)
        {
            if(num < 0) return - num;
            return num;
        }

        public static long CalculateExponent(long number, long exponent)
        {
            long result = number;
            for (int i = 1; i < exponent; i++)
            {
                result *= number;
            }
            return result;
        }

        public static int[] MultiplyByLength (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array.Length;
            }
            return array;
        }

        public static int HammingDistance(string str1, string str2)
        {
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if(str1[i] != str2[i])
                count ++;                
            }
            return count;
        }

        public static string NameShuffle(string name)
        {
            return  String.Join(" ", name.Split(" ").Reverse());
        }

        public static string SmallerNum(string num1, string num2)
        {   
            return StringASCIIValue(num1) < StringASCIIValue(num2)? num1 : num2;            
        }
        
        private static int StringASCIIValue(string s)
        {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(s);
            int acum = 0;
            int multiplier = 1;
            for (int i = bytes.Length - 1; i >= 0; i--)
            {
                acum += bytes[i] * multiplier;
                multiplier *= 10;
            }
            return acum;
        }

        public static int Factorial(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            return num * (Factorial(num - 1));
        }

        public static int CountVowels(string str)
        {
            return str.Count("aeiouAEIOU".Contains);
        }

        public static int[] SortNumsAscending(int[] array)
        {            
            int aux = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < (array.Length - i); j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        aux = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = aux;
                    }
                }
            }
            return array;            
        }

        public static bool IsIdentical(string input)
        {
            char[] arr = input.ToCharArray();
            if(arr.Length <= 1)
            {
                return true;
            }
            bool identical = true;
            char prev = arr[0];
            for (int i = 1; i < arr.Length; i++)   
            {
                if (arr[i] != prev)
                {
                    identical = false;
                }
            }
            return identical;
        }
        public static string HackerSpeak(string input)
        {
            input = input.Replace("A", "4");
            input = input.Replace("a", "4");
            input = input.Replace("E", "3");
            input = input.Replace("e", "3");
            input = input.Replace("I", "1");
            input = input.Replace("i", "1");
            input = input.Replace("O", "0");
            input = input.Replace("o", "0");
            input = input.Replace("S", "5");
            input = input.Replace("s", "5");
            return input;
        }
        public static bool SameCase(string input)
        {
            char[] letters = input.ToCharArray();
            for(int i = 0; i < letters.Length; i++)
            {
                for(int x = 1;x < letters.Length; x++)
                {
                    if (Char.IsUpper(letters[0]))
                    {
                        if (Char.IsLower(letters[x]))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (Char.IsUpper(letters[x]))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public static string FizzBuzz(int input)
        {
            string word = "";
            if(input % 3 != 0 && input % 5 != 0)
            {
                return input.ToString();
            }
            if(input % 3 == 0)
            {
                word = "Fizz";
            }
            if(input % 5 == 0)
            {
                word += "Buzz";
            }
            return word;
        }
        public static string NSidedShape(int input)
        {
            string[] shapes = { "circle", "semi-circle", "triangle", "square", "pentagon", "hexagon", "heptagon", "octagon", "nonagon", "decagon" };
            return shapes[input-1];
        }
        public static int CountDs(string input)
        {
            int totalDs = 0;
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input.ToCharArray()[i] == 'd')
                {
                    totalDs++;
                }
            }
            return totalDs;
        }
        public static string LongBurp(int ars)
        {
            string burp = "Bu";
            for(int i = 0; i < ars; i++)
            {
                burp+="r";
            }
            burp+="p";
            return burp;
        }
        public static int CountClaps(string input)
        {
            char[] clapsOverlaped = input.ToCharArray();
            int clapsCount = 0;
            for(int i = 0; i < clapsOverlaped.Length; i++)
            {
                if(clapsOverlaped[i] == 'C')
                {
                    clapsCount++;
                }
            }
            return clapsCount;
        }
        public static string RemoveFirstLast(string input)
        {
            if (input.Length<=2)
            {
                return input;
            }
            else
            {
                input = input.Substring(1, input.Length-1);
                return input.Substring(0, input.Length-1);
            }
        }
        public static int Sum(int recursion)
        {
            int sum = 0;
            for(int i = 1; i < recursion+1; i++)
            {
                sum  +=i;
            }
            return sum;
        }
    }
}
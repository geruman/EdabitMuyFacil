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
            int result = num;
            for (int i = 1; i < num; i++)
            {
                result *= i;
            }
            return result;
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
    }
}
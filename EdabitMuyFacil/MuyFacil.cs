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
            return (length*2)+(width*2);
        }
        public static string NameGreeting(string name)
        {
            return "Hello "+name+"!";
        }
        public static int BasketballPoints(int doblePunto, int triplePunto)
        {
            return doblePunto*2+triplePunto*3;
        }
        public static int FarmProblem(int chickens, int cows, int pigs)
        {
            return chickens*2+cows*4+pigs*4;
        }

        public static int FootbalPoints(int wins, int draws, int looses)
        {
            int puntos = 0;
            puntos = puntos+wins*3;
            puntos = puntos+draws;
            return puntos;

        }
        public static object GetFirstValue(object[] array)
        {
            return array[0];
        }
        public static string Greeting(string name)
        {
            if (name=="Mubashir")
            {
                return "Hello, my Love!";
            }
            return "Hello, "+name+"!";
        }
        public static int Convert(int hours, int minutes)
        {
            int total = hours * 3600;
            total = total + minutes * 60;
            return total;
        }
        public static int NextEdge(int side1, int side2)
        {
            return side1+side2-1;
        }
        public static int InchesToFeet(int inches)
        {
            return (int)(inches/12);
        }
        public static bool DivisibleByFive(int value)
        {
            if (value%5==0)
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
            return value*value;
        }
        public static bool DividesEvenly(int value, int divisor)
        {
            return value%divisor==0;
        }
        public static int Frames(int minutes, int fps)
        {
            return (fps*60)*minutes;
        }
        public static bool ProfitableGamble(double prob, int prize, double pay)
        {
            return ((prob*prize)>pay);
        }
    }
}

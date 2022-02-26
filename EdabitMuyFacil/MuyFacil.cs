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

        //Hacer hasta Profitable Gamble.
    }
}

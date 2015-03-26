using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            Console.Write(age);
            Console.ReadLine();
            const int MAX_SCORE = 100;
            int score = 36;
            float percent = (float)score / (float)MAX_SCORE;
            Console.Write(percent);
            Console.ReadLine();

        }
    }
}

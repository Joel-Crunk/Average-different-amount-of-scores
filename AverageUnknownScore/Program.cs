using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of scores to be averaged: ");
            int amount = int.Parse(Console.ReadLine());

           
            
            int sum = 0;

            for (int i = 0; i < amount; i++)
            {
              

                Console.Write($"\n Enter score number: ");
                int score = int.Parse(Console.ReadLine());
               
           

                sum = sum + score;


            }

            double ave = sum / amount;
            if (ave > 89)
            {
                Console.WriteLine($"\n\n{ave} is an \"A\" grade");
            }
            else if (ave > 79 && ave < 90)
            {
                Console.WriteLine($"\n\n{ave} is a \"B\" grade");
            }
            else if (ave > 69 && ave < 80)
            {
                Console.WriteLine($"\n\n{ave} is a \"C\" grade");
            }
            else if (ave > 59 && ave < 70)
            {
                Console.WriteLine($"\n\n{ave} is a \"D\" grade");
            }
            else
            {
                Console.WriteLine($"\n\n{ave} is a \"F\" grade");
            }

            Console.ReadLine();
            //Console.WriteLine(ave);

        }
    }
}
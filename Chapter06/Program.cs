using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Chapter06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise01();
            //Exercise02();
            //Exercise03();
            //Exercise04();
            //Exercise05();


            Console.Read();
        }

        public static void Exercise05()
        {
            double a = 0;
            double b;
            do
            {
                 a = CheckInputInt("Enter a positive number 1-50: ");
            }
            while (a < 1 || a > 50);

            Console.Write(a + " ");

            while (a != 1)
            {

                if (a % 2 == 0)
                {

                    b = Math.Floor(Math.Pow(a, 0.50));

                } 
                else
                {
                    b = Math.Floor(Math.Pow(a, 1.5));
                    
                }
                Console.Write(b + " ");
                a = b;
            }
        }

        private static void Exercise04()
        {

            int baseLow = CheckInputInt("Enter the beginning base number: ");
            int baseHigh = CheckInputInt("Enter the ending base number: ");

            for(int i = 1; i <= 25; i++)
            {
                string row =" "+ i+"|\t";
                
                for(int j = baseLow; j <= baseHigh; j++)
                {
                    row += "|" + j*i + "|\t";
                }
                Console.WriteLine(row);
            }
        }

        private static void Exercise03()
        {
            string input = "";
            double gradeCount = 0;
            double grades = 0;
            
            const string exitValue = "exit";

            do
            {
                Console.WriteLine("Enter a grade or type exit to quit: ");
                input = Console.ReadLine();
                double inputNum = 0;
                bool isNumber = Double.TryParse(input, out inputNum);

                if (input == exitValue)
                {
                    continue;
                }

                if (!isNumber)
                {
                    Console.WriteLine("Incorrect value!");
                    continue;

                }

                else if (inputNum < 0.00 || inputNum > 100.00)
                {
                    Console.WriteLine("Must be between 0 and 100");
                    continue;

                }
                else
                {
                    grades += inputNum;
                    gradeCount++;
                }
            }

            while (input != exitValue);

            Console.WriteLine("Grade Average: " + grades/gradeCount);
            double gradeAverage = grades / gradeCount;

            if (gradeAverage >= 90 && gradeAverage <= 100)
            {
                Console.WriteLine("The student got an A.");
            }
            else if(gradeAverage >= 80 && gradeAverage <= 89)
            {
                Console.WriteLine("The student got a B.");
            }
            else if (gradeAverage >= 70 && gradeAverage <= 79)
            {
                Console.WriteLine("The student got a C");
            }
            else if (gradeAverage >= 60 && gradeAverage <= 69)
            {
                Console.WriteLine("The student got a D.");
            }
            else 
            {
                Console.WriteLine("The student got a F.");
            }
        }

        private static void Exercise02()
        {
            string input = "";
            int rightCount = 0;
            int wrongCount = 0;
            string exitValue = "exit";
            string exitUpper = exitValue.ToUpper();
            do
            {
                Console.WriteLine("Enter a positive integer less than 100 or type exit to quit: ");
                input = Console.ReadLine();
                int inputNum = 0;
                bool isNumber = Int32.TryParse(input, out inputNum);

                if (input == exitUpper)
                {
                    continue;
                }
                else if (!isNumber)
                {
                    Console.WriteLine("Incorrect value!");
                    wrongCount++;

                }

                else if (inputNum < 0 || inputNum == 100)
                {
                    Console.WriteLine("Must be between 0 and 100");
                    wrongCount++;

                }
                else
                {
                    rightCount++;
                }
            }
            while (input != exitUpper);
            Console.WriteLine("Valid entries: " + rightCount);
            Console.WriteLine("Invalid entries: " + wrongCount);
        }

        private static void Exercise01()
        {
            Random numbers = new Random();
            int max = 0, min = 0, oddCount = 0;
            for (int i = 0; i < 1000; i++)
            {
                int randomNumber = numbers.Next(0, 100000);
                if(randomNumber %2 != 0)
                {
                    oddCount++;
                }

                if(randomNumber > max)
                {
                    max = randomNumber;
                }
                
                if(min == 0)
                {
                    min = randomNumber;
                }
                else if(randomNumber < min)
                {
                    min = randomNumber;
                }
            
            }

            Console.WriteLine("Odd count: "+ oddCount);
            Console.WriteLine("Min value: "+ min);
            Console.WriteLine("Max value: "+ max);
        }

        public static int CheckInputInt(string message)
        {
            int retVal = 0;
            string inputString = "";
            Console.WriteLine(message);
            inputString = Console.ReadLine();
            while (!int.TryParse(inputString, out retVal) == true)
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine(message);
                inputString = Console.ReadLine();
            }
            return retVal;
        }
    }
        
}

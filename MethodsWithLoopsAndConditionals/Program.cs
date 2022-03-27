using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {

        //Write a method that will print to the console all numbers 1000 through -1000   =  FOR LOOP**
        //Write a method that will print to the console numbers 3 through 999 by 3 each time = FOR LOOP**
        //Write a method to accept two integers as parameters and check whether they are equal or not = IF ELSE 
        //Write a method to check whether a given number is even or odd = IF ELSE 
        //Write a method to check whether a given number is positive or negative = IF ELSE 
        //Write a method to read the age of a candidate and determine whether they can vote. = IF ELSE 
        //HINT: Use Parse or the safer TryParse() for an extra challenge
         //Write a method to check if an integer(from the user) is in the range -10 to 10
          //Write a method to display the multiplication table(from 1 to 12) of a given integer



        public static void Print1000s()
        {
            Console.WriteLine("Print 1000s");
            for (int i = -1000; i <= 1000; i++)

                Console.WriteLine(i);
        }

        public static void PrintThrees()
        {
            Console.WriteLine("Print Threes");
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void TwoIntsEqual(int num1, int num2) 
        {
            Console.WriteLine("Equal To Or Not");
            if (num1 == num2)
            {
                Console.WriteLine(" The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers do not equal each other.");
            }

        }

        public static void EvenOrOdd(int number)
        {
            Console.WriteLine("Even or Odd");
            if (number % 2 == 0)
            {
                Console.WriteLine("It's even stevens");
            }
            else
            {
                Console.WriteLine("It's an odd ball");
            }

        }

        public static void PositiveOrNegative(int x)

        {
            Console.WriteLine("Positive or Negative");
            if ( x > 0) 
            {
                Console.WriteLine($"The number {x} is positive.");
            }
            else if (x < 0) 
            {
                Console.WriteLine($"The number {x} is negative.");

            }
          

        }

        public static void AgeCheckerToVote()
        {
            Console.WriteLine("How old is the voting candidate?");

            var votersAge = int.TryParse(Console.ReadLine(), out int result);


            if (result < 18)
            {
                Console.WriteLine("Unfortunately, you are not old enough to be a registered vote.");
            }
            else
            {
                Console.WriteLine("Yes! You can vote!");
            }
        }

        public static void InRange()
        {
            bool userAnswer;
            int result;

            do
            {

                Console.WriteLine("Please enter your number:");
                userAnswer = int.TryParse(Console.ReadLine(), out result);
                

            } while (!userAnswer);

            if (result >= -10 && result <= 10)
            {

                Console.WriteLine($"{result} is within the correct range.");
            }
            
            else
            {

                Console.WriteLine($"{result} is not within the range.");
            }
            

        }


        public static void MultiplyTable()
        {
            bool userInput;
            int result;

            do
            {
                Console.WriteLine("Enter a number");

                userInput = int.TryParse(Console.ReadLine(), out result);

            } while (!userInput);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {result} = {i * result}");
            }
        }

    
    static void Main(string[] args)
    
        { 
            Print1000s();

            PrintThrees();

            TwoIntsEqual(20,50);

            EvenOrOdd(7);
            EvenOrOdd(16);
            EvenOrOdd(-8);


            PositiveOrNegative(15);
            PositiveOrNegative(-88);

            AgeCheckerToVote();

            InRange();

            MultiplyTable();


        }  


    }
}


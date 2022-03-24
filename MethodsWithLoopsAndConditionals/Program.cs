using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PosORNeg();
            LegalAge();
            EqualOrNot();
            MultipleThrees();
            UpToOneHundred();
            EvenOrOdd();
        }

        public static void PosORNeg()
        {
            Console.WriteLine("Please enter a number");
            var usersInput = int.Parse(Console.ReadLine());
            var result = (usersInput >= 0) ? "that's positive bro" : "that's so negative";
            Console.WriteLine(result);

        }
        public static void LegalAge()
        {
            Console.WriteLine("Please enter your age.");
            int userAge = int.Parse(Console.ReadLine());
            var result = (userAge >= 21) ? "you are old enough" : "you are not old enough";
            Console.WriteLine(result);
        }


        public static void EqualOrNot()
        {
            Console.WriteLine("I can also tell you if two numbers are equal or not... please provide the first number");
            var inputOne = int.Parse(Console.ReadLine());
            Console.WriteLine("interesting pick....provide another number.... let's find out is it the same or not?");
            var inputTwo = int.Parse(Console.ReadLine());

            if (inputOne == inputTwo)
            {
                Console.WriteLine("thats the same!");
            }
            else
            {
                Console.WriteLine("those...totally aren't the same"); 
            }
            
        }
        public static void MultipleThrees()
        {
            for (var threeNum = 3; threeNum <= 999; threeNum += 3)
            {
                Console.WriteLine(threeNum);
            }
        }
        public static void UpToOneHundred()
        {
            for (var num = -1000; num <= 1000; num++)
            {
                Console.WriteLine(num);
            }

        }
        public static void EvenOrOdd ()

        {
            Console.WriteLine("Please add another number- i shall be mystical and tell you if its even..or....odd!!");
            var userNumber = int.Parse(Console.ReadLine());
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("eeeeeveeenn"); ;
            }
            else
            {
                Console.WriteLine("ooooddddd");
            }
        }
    }
}

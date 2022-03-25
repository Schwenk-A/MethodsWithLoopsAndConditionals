using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am your magic number box. I am pretty cool and like to show off");
           PosOrNeg();
           Console.WriteLine("Let us see if you are even old enough to vote.");
           LegalAge();
           EqualOrNot(50,6);
            EvenOrOdd();
            IntRange(5);
            Console.WriteLine("Look how high i can count! Press anything to see");
          Console.ReadKey();
           UpToOneHundred();
           Console.WriteLine("I can do it by three's too! Press anything to see");
            Console.ReadKey();
            MultipleThrees();

        }
        //#region name it
        
        public static void PosOrNeg() 
        {
            
            bool isNumber;
            int answer; 
            do
            {
                Console.WriteLine("Please enter a number, lets see if you are a positive or negative person.");
                isNumber = int.TryParse(Console.ReadLine(),out answer);

            } while (isNumber == false);

            var result = (answer >= 0) ? "that's positive bro" : "that's so negative";
            Console.WriteLine(result);
            Console.WriteLine("Do you wish to continue? Press any key");
            Console.ReadKey();
            Console.Clear();
            

        }
        public static void LegalAge()
        {
            bool ageInput;
            int answer;
            do
            {
                Console.WriteLine("Please enter your age.");
                ageInput = int.TryParse(Console.ReadLine(), out answer);

            } while (ageInput==false);

            var result = (answer >= 21) ? "you are old enough...choose wisely" : "you are not old enough...soooo bye";
            Console.WriteLine(result);
            Console.WriteLine("Do you wish to continue?Press any key...");
            Console.ReadKey();
            Console.Clear();
        }


        public static void EqualOrNot(int inputOne, int inputTwo)
        {

            Console.WriteLine("I will choose my own two numbers and just tell you if they are the same or not.. for fun");
            Console.WriteLine("if you are please press any key to continue.");
            Console.ReadKey();
            if (inputOne == inputTwo)
            {
                Console.WriteLine("thats the same!");
            }
            else
            {
                Console.WriteLine("those...totally aren't the same"); 
            }
            Console.WriteLine("Would you like to continue? Press any key");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MultipleThrees()
        {
            for (var threeNum = 3; threeNum <= 999; threeNum += 3)
            {
                Console.WriteLine(threeNum);
            }
            Console.WriteLine("Would you like to continue? Press any key");
            Console.ReadKey();
            Console.Clear();
        }
        public static void UpToOneHundred()
        {
            for (var num = -1000; num <= 1000; num++)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Would you like to continue? Press any key");
            Console.ReadKey();
            Console.Clear();
        }

        public static void EvenOrOdd ()

        {
            Console.WriteLine("i shall be mystical and tell your if its even..or....odd!!");
            var userNumber = int.Parse(Console.ReadLine());
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("eeeeeveeenn"); ;
            }
            else
            {
                Console.WriteLine("ooooddddd");
            }
            Console.WriteLine("Would you like to continue? Press any key");
            Console.ReadKey();
            Console.Clear();
        }
        //Heating up section 

        public static void IntRange(int numberone)
        {

            if(numberone>= -10 && numberone<= 10)
            {
                Console.WriteLine("Your number is within range.");

            }
            else
            {
                Console.WriteLine("your numbers out of bounds buddy.");
            }
        }
    }
}

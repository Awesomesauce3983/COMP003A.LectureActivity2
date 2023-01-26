/*    Author: Anastasia Clements
 *    Course: COMP-003A
 *   Purpose: Lecture Activity 2 (variables, type system, math, console prop)
 * Reference: The C# Player's Guide (4e) by RB Whitaker  */



namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Title = "Hi There!";
            string username;
            Console.WriteLine("Hello! What is your name?");
            username = Console.ReadLine();
            Console.WriteLine($"Hi there {username}!");

            string favoriteColor;
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine($"Your favorite color is {favoriteColor}");

            int score;
            score = 0;
            score = 4;
            score = 11;
            score = -1564;

            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine($"The current value of a: {a, 12}");
            Console.WriteLine($"The current value of b: {b, 12}");

            b = a;
            a = -3;
            Console.WriteLine($"The new value of a: {a, 16}");
            Console.WriteLine($"The new value of b: {a, 16}");

            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("------------------------------------------------------------");

            byte aTinyByte = 34;
            Console.WriteLine($"aTinyByte: {aTinyByte,25}");
            aTinyByte = 17;
            Console.WriteLine($"aTinyByte: {aTinyByte,25}");

            short aNumber = 5039;
            Console.WriteLine($"aNumber: {aNumber,27}");
            aNumber = -4354;
            Console.WriteLine($"aNumber: {aNumber,27}");

            long aHuuugeNumber = 1834092130948;
            Console.WriteLine($"aHuuugeNumber: {aHuuugeNumber,21}");
            aHuuugeNumber = 5;
            Console.WriteLine($"aHuuugeNumber: {aHuuugeNumber,21}");

            int anInteger = 123456789;

            char aLetter = 'A';
            string message = "Hello World!"; //not going to change this one :)

            Console.WriteLine($"Concatenation using + : " + aLetter + " " + message);
            Console.WriteLine($"Concatenation using string interpolation : {aLetter} {message}");

            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number1: {number1,23}");
            Console.WriteLine($"Value of number2: {number2,23}");
            Console.WriteLine($"Value of number3: {number3,23}");

            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogadrosNumber: {avogadrosNumber,18}");

            bool itWorked = true;
            Console.WriteLine($"Value of itWorked: {itWorked}");
            itWorked = false;
            Console.WriteLine($"New value of itWorked: {itWorked}");

            string inputAgeString;
            int inputAge;
            int currentYear = 2023;
            Console.WriteLine($"Enter age in {currentYear}: ");
            inputAgeString = Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgeString);
            Console.WriteLine($"Thank you, your age is {inputAge}");

            Console.WriteLine("------------------------------------------------------------");

            int addition = 2+3;
            int subtraction = 5 - 2;
            int multiplication = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition: {addition}");
            Console.WriteLine($"Value of subtraction: {subtraction}");
            Console.WriteLine($"Value of multiplication: {multiplication}");
            Console.WriteLine($"Value of division: {division}");
            Console.WriteLine($"Value of modulo: {modulo}");

            int arithmetic1;
            arithmetic1 = 9 - 2;
            Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
            arithmetic1 = 3 + 3;
            Console.WriteLine($"New value of arithmetic1: {arithmetic1}");
            int arithmetic2 = 3 + 1;
            Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
            arithmetic2 = 1 + 2;
            Console.WriteLine($"New value of arithmetic2: {arithmetic2}");

            int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"Value of result: {result}");

            int compoundAssignmentOperator = 0;
            compoundAssignmentOperator += 5;
            compoundAssignmentOperator -= 2;
            compoundAssignmentOperator *= 4;
            compoundAssignmentOperator /= 2;
            compoundAssignmentOperator %= 2;
            int incrementDecrementOperators = 0;
            incrementDecrementOperators++;
            incrementDecrementOperators--;

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine($"What is your name (im asking again I forgot)");
            string userName = Console.ReadLine();

            Console.WriteLine($"Press any key when you're ready to hear a C major scale!");
            Console.ReadKey();

            Console.Beep(262,500);
            Console.Beep(294, 500);
            Console.Beep(330, 500);
            Console.Beep(349, 500);
            Console.Beep(392, 500);
            Console.Beep(440, 500);
            Console.Beep(494, 500);
            Console.Beep(523, 500);

            Console.WriteLine($"Goodbye!");
            Console.ReadKey();

        }
    }
}


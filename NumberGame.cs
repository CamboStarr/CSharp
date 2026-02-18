using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This prints to the console!
            /*it's pretty ridiculous
            I know */
            Console.WriteLine("Hello World!");

            //dataType name;
            uint scoreTeamRed, scoreTeamBlue;
            scoreTeamRed = 15;
            scoreTeamBlue = 20;

            Console.Write("Red Score: ");
            Console.WriteLine(scoreTeamRed);

            Console.Write("Blue Score: ");
            Console.WriteLine(scoreTeamBlue);

            uint health = 100;
            Console.Write("Health: ");
            Console.WriteLine(health);

            //unsigned ints don't have permission to go below zero
            //signed ints have permission to go below xero

            //singed int range ~2 bill to ~2 bill
            //unsigned int range 0 to ~4 bill
            // signed is int, unsigned is uint


            Console.WriteLine("");
            Console.WriteLine("");


            // float uses decimals, and goes up to 9 digits, suffix is f
            // double uses decimals, and goes up to 17 digits, suffix is d
            // decimal uses decimals, and goes up to 29 digits, suffix is m

            float walkSpeed = 2.5f;
            double runSpeed;
            runSpeed = 10.2d;

            decimal money = 5.2004m;
            double bankBalance = 10_000d;

            Console.Write("Walk Speed: ");
            Console.WriteLine(walkSpeed);
            Console.Write("Run Speed: ");
            Console.WriteLine(runSpeed);
            Console.Write("$$$: ");
            Console.WriteLine(money);
            Console.Write("Bank $$$: ");
            Console.WriteLine(bankBalance);


            Console.WriteLine("");
            Console.WriteLine("");


            //Booleans, or On/Off switches
            bool gameOver = false;
            Console.WriteLine("Start");
            Console.WriteLine(gameOver);
            Console.WriteLine("You were shot...");
            gameOver = true;
            Console.WriteLine(gameOver);


            Console.WriteLine("");
            Console.WriteLine("");


            //Chars are single letters, with a numerical value. Case Sensitive, make sure to use single quotation
            char singleLetter = 'a';

            Console.WriteLine(singleLetter);


            Console.WriteLine("");
            Console.WriteLine("");


            //Strings are a data type for storing text. Used for Dialogue, or names of characters and items. Strings can also be blank, or can contain only one character.
            string name = "King Richard";

            Console.Write("Name: ");
            Console.WriteLine(name);


            Console.WriteLine("");
            Console.WriteLine("");



            //There are several ways to print variables.
            int age = 49;
            double height = 1.9d;

            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height + " meters");

            Console.WriteLine("");

            //Here's how you can do the same thing, but with only one line.
            Console.WriteLine("Age: " + age + "\n" + "Height: " + height + " meters");

            Console.WriteLine();

            //Here's printing variables using indexed variables
            Console.WriteLine("Name: {0}\nAge: {1}\nHeight: {2}", name, age, height);

            Console.WriteLine();

            //String quatation for the same above.
            Console.WriteLine($"Name: {name}\nAge: {age}\nHeight: {height}");



            Console.WriteLine();
            Console.WriteLine();


            //Constant's are numbers that don't change, unlike variables.
            const int maxHealth = 100;

            Console.WriteLine("Health: " + maxHealth);


            Console.WriteLine();
            Console.WriteLine();


            //ReadLine Retrieves the next line, where ReadKey takes the next one.  
            //Console.WriteLine("What is your name: ");

            //string playerName = Console.ReadLine();



            //Console.Write("What is your Last initial: ");

            //char playerLast = Console.ReadKey().KeyChar;

            //Console.WriteLine();

            //Console.WriteLine("Your name is " + playerName + " " + playerLast + "?");
            //Console.ReadKey();


            //Console.WriteLine();
            //Console.WriteLine();



            //Use this method to ask the player for numbers. Ask for, Save, then Print.
            //Convert.To can be used to switch many different variables and strings to other variable types.
            //Console.WriteLine("How old are you? ");

            //string numberTyped = Console.ReadLine();
            //int number = Convert.ToInt32(numberTyped);

            //Console.WriteLine("You are " + number + " years old?");

            //Parsing is a bit different. If nothing is Typed when converting in Convert.To (meaning it returns null) than it would return as 0. Parsing would return as an error
            //Console.WriteLine("How old are you? ");

            //string numberTyped = Console.ReadLine();
            //int number = Int32.Parse(numberTyped);

            //Console.WriteLine("You are " + number + " years old?");


            //Console.WriteLine();
            //Console.WriteLine();


            //Multiply, Add, Subtract, and Divide!

            Console.WriteLine("Math:");

            //Create 2 int Variables
            int math1 = 10;
            int math2 = 5;

            //Create a result variable
            int result = 0;

            //math
            result = math1 + math2;

            Console.WriteLine(result);

            math2 = math2 + 5;
            Console.WriteLine(math2);

            result = (math1 + math2) * 2;
            Console.WriteLine(result);


            //Increment ++, Decrement -- (These add 1, and subract 1 respectivly from variables)
            math1--;
            math2--;


            //++number will make result 1, then change result to number1. number++ will change result to the number, then add 1
            result = (--math1 + math2--) * 2;
            //this should make the result 6 less than last time
            Console.WriteLine(result);


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("MoreMath: ");
            //Modulus % (This divided by thing truly doesn't work it seems)

            //returns the remainder of dividing 2 numbers

            //Create 2 double variables
            double math3 = 20;
            double math4 = 2;
            double resultDouble = 0;
            //math 

            resultDouble = math4 % math3;

            Console.WriteLine(resultDouble);



            //number = number + 5 is the same as number+= 5



            Console.WriteLine();
            Console.WriteLine();



            string string1 = "Hello ";
            string string2 = "World";
            string combinedStrings;

            combinedStrings = string1 + string2;

            Console.WriteLine(combinedStrings + "!");


            //Here's another way of writing the same thing, using +=
            string2 = string2 + "!";
            string1 += string2;

            Console.WriteLine(string1);



            Console.WriteLine();
            Console.WriteLine();


            //Ints can be converted into a float, but not the other way around. Converting to less precision requires a byte
            int math5 = 5;
            int math6 = 4;


            float mathResult = math5 + math6;

            Console.Write(mathResult);


            byte newResult = (byte)(math5 + math6);
            Console.WriteLine(newResult + "!");

            //Trunicating means that if theres extra info on the end (like decimals) it will eliminate them, not rounding up.
            //This happens when mixing an int and a float, like so
            int math7 = 5;
            float math8 = 5.9f;

            int equals = (int)(math7 + math8);
            Console.WriteLine(equals);




            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("What is your name?");
            string momName = Console.ReadLine();

            Console.WriteLine("Your name is " + momName + "?");



            //This waits until a key is pressed before continuing.
            Console.ReadKey();
        }
    }
}

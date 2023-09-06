using System;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console : Found in "System" namespace
            //

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine(name);


            //Math**************
            // Math- found in System namespace
            //Console.WriteLine("Enter a number");
            //double number = double.Parse(Console.ReadLine());
            //double sqrt = Math.Sqrt(number);
            //Console.WriteLine(" The sqrt root of your number is: " + sqrt);

            //Random****************
            //Generate random numbers
            //Commonly used methods: Random.Next(), Random.NextDouble()
            //Random random = new Random();
            //int diceroll = random.(1, 7);
            //Console.WriteLine(diceroll);

            //DateTime************************

            //Console.WriteLine("Enter a date for an event: ");
            //string event1 = Console.ReadLine();
            //Console.WriteLine($"Remember: {event1} on {DateTime.Now}");

            //string **********************************************
            // found in system namespace, represents a sequences of characters, Contains many methods for string 
            // manipulation like: substring(), indexof(), replace(), ToLower(), ToUpper()

            //Console.WriteLine("Enter a sentence or a word");
            //string sentence = Console.ReadLine();
            //Char[] charArray = sentence.ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine($"The sentence revesed is: {new string (charArray)}");

            //string sentence = "Fuck you";
            //bool containsBadWords = sentence.Contains("Fuck");
            //if(containsBadWords)
            //{ 
            //    Console.WriteLine("Nejjjjjj dont say that");
            //}
            //else
            //{
            //    Console.WriteLine("You are free to go on");
            //}
            //Console.WriteLine("write something");



            //Array
            //Found in "System" namespace
            //Represents "List of elements"
            //Provides methods for creating, manipulating and searching Arrays.

            //double[] numbers = new double[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter number {i + 1}");
            //    numbers[i] = double.Parse( Console.ReadLine() );
            //}
            //Console.WriteLine("The number you enterd in reversed is the following: ");
            //for (int i = 4; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Exercise2
            //Console.WriteLine("Enter a number");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter another number");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);

            //Console.WriteLine("Write a word");
            //Console.WriteLine("Enter your input");
            //string word = Console.ReadLine();


            //while (word != "exit" && word != "quit")
            //{
            //    Console.WriteLine("Enter your input");
            //    word = Console.ReadLine();
            //}

            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter another number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            
             double diffrence = num1 - num2;

            if (num1 < num2)
            {
                Console.WriteLine(num1);
                
                
            }
            else
            {
                Console.WriteLine("The smallet number is " + num2);
            }

            



            Console.ReadLine();

        }
    }
}
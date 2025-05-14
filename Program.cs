using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
   {
      Console.Write("what is your grade percentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter = "";
        string sign ="";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)

        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grede is {letter}.");

        if (grade >= 70)
        {
           Console.WriteLine("you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
        // to determine the + or - sign 
        int lastDigit = grade % 10;
        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
        }
        else if ( letter == "A" && grade < 93)  
        {
            sign = "-";
        }
        Console.WriteLine($"your gade is: {letter}{sign}.");
        // Now is to conglatulate or encourage the student for their good work or to try harder next time
        if (grade >=70)
        {
            Console.WriteLine ("Congratulation! you passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! keep trying and you will get it next time.");
        }
   }
}      
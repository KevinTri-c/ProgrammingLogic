using System.ComponentModel;

namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        // Step 1 operator practice
          int a = 10;
          int b = 5;
          int c = 15;
          Console.WriteLine(a > b);
          Console.WriteLine(a < c);
          Console.WriteLine(a > b && a > c);
          
          //Step 2 boolean logic
          bool isRaining = true;
          bool haveUmbrella = false;

           if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }
        // Step 3 Conditional Logic – Movie Ticket Pricing

        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;

        if (int.TryParse(input, out age))
        {
            if (age < 5)
            {
                Console.WriteLine("Ticket is free!");
            }
            else if (age >= 5 && age <= 12)
            {
                Console.WriteLine("Child ticket: $5");
            }
            else if (age >= 13 && age <= 64)
            {
                Console.WriteLine("Standard ticket: $10");
            }
            else // age >= 65
            {
                Console.WriteLine("Senior ticket: $6");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        // step 4 Using a sqwitch statement

 Console.Write("Enter a day of the week (1-7): ");
        string userinput = Console.ReadLine();
        int dayNumber;

        if (int.TryParse(userinput, out dayNumber))
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid number. Please enter a number between 1 and 7.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        

          
           
          
    }
}      

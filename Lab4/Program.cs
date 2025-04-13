namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
         // Step 1: Simple For Loop
        Console.WriteLine("Numbers from 1 to 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        // Step 2: Even Numbers from 1 to 20
        Console.WriteLine("Even numbers from 1 to 20");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine();

        // Step 3: While Loop Countdown
        Console.WriteLine("Countdown from 5 to 1");
        int countdown = 5;
        while (countdown >= 1)
        {
            Console.WriteLine(countdown);
            countdown--;
        }

        Console.WriteLine();

        // Step 4: Do/While User Input
        Console.WriteLine("Enter a number greater than 100");
        int number;
        do
        {
            Console.Write("Enter a number greater than 100: ");
            number = Convert.ToInt32(Console.ReadLine());
        } while (number <= 100);

        Console.WriteLine();

        // Step 5: While Loop – Multiples of 10 from 10 to 1000
        Console.WriteLine("Multiples of 10 from 10 to 1000");
        int multiple = 10;
        while (multiple <= 1000)
        {
            Console.WriteLine(multiple);
            multiple += 10;
        }

        Console.WriteLine();

        // Step 6: Pattern Printer (Using Nested Loops)
        Console.WriteLine("Triangle Pattern");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

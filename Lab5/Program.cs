namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 Seasons of the Year
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

        foreach (string season in seasons)
        {
            Console.WriteLine("Season: " + season);
        }
        
        //Problem 2 Days of the Week
        
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Enter a number (1–7): ");
        string input = Console.ReadLine();
        int number;

      
        if (int.TryParse(input, out number) && number >= 1 && number <= 7)
        {

            Console.WriteLine("That day is: " + days[number - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
        }
        //Problem 3 Favorite Books and Authors

        string[] books = { "The Hobbit", "Charlotte’s Web", "1984" };
        string[] authors = { "J.R.R. Tolkien", "E.B. White", "George Orwell" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"Book {i + 1}: {books[i]} by {authors[i]}");
        }
        //Problem 4 Temperature Tracker 
    
        int[] temperatures = { 65, 72, 78, 70, 68 };

     
        Array.Sort(temperatures);

        
        Console.Write("Sorted Temperatures: ");
        foreach (int temp in temperatures)
        {
            Console.Write(temp + " ");
        }
        Console.WriteLine();

       
        int lowest = temperatures[0];
        int highest = temperatures[temperatures.Length - 1];

        Console.WriteLine("Highest Temperature: " + highest);
        Console.WriteLine("Lowest Temperature: " + lowest);

        //Problem 5 Reverse Countdown


        int[] countdown = { 5, 4, 3, 2, 1 };

    
        Array.Reverse(countdown);

         Console.Write("Countdown: ");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.Write(countdown[i] + " ");
        }
    }  

}

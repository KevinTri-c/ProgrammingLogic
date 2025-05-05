using System;

class Book
{
    private string title;
    private string author;

    // Default Constructor
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    // Constructor with title only
    public Book(string newTitle)
    {
        title = newTitle;
        author = "Unknown Author";
    }

    // Constructor with title and author
    public Book(string newTitle, string newAuthor)
    {
        title = newTitle;
        author = newAuthor;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals

        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle());  // Output: Advanced C#

        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Title: " + book3.GetTitle());   // Output: Title: Advanced C#
        Console.WriteLine("Author: " + book3.GetAuthor()); // Output: Author: John Doe

        //Create book4 and update fields using setters
        Book book4 = new Book(); // Using default constructor
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");

        Console.WriteLine("Title: " + book4.GetTitle());   // Output: Mastering C#
        Console.WriteLine("Author: " + book4.GetAuthor()); // Output: Jane Smith
    }
}
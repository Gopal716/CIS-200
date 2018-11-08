// Grading ID: D1924
// Program 1A
// Due Date: 2/15/2017
// Course Section: CIS-200-01-4172


// Description: This file creates a simple test application class that creates
// a List of LibraryBook objects, some LibraryPatron objects, a LibraryMovie and tests them.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
           2010, "ZZ25 3G", 30);  // 1st test book
            LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
                2000, "AG773 ZF",30); // 2nd test book
            LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
                1985, "JJ438 4T", 30); // 3rd test book
            LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
                2017, "ZZ24 4F", 30);  // 4th test book
            LibraryBook book5 = new LibraryBook("    The Big Book of Doughnuts   ", "   Homer Simpson   ", "   Doh Books   ",
                2001, "   AE842 7A   ", 30); // 5th test book - Trims?
        LibraryMovie movie1 = new LibraryMovie("Avengers", "Me", 2008, "SFG13", 30, 30, "Me", LibraryMediaItem.MediaType.CD, LibraryMovie.MPAARatings.PG13);
       
            LibraryPatron patron1 = new LibraryPatron("Ima Reader", "123456"); // 1st test patron
            LibraryPatron patron2 = new LibraryPatron("Jane Doe", "112233");  // 2nd test patron
            LibraryPatron patron3 = new LibraryPatron("   John Smith   ", "   654321   "); // 3rd test patron - Trims?


            List<LibraryBook> theBooks = new List<LibraryBook>(); // Test list of books
        List<LibraryMovie> theMovies = new List<LibraryMovie>(); // Test list of Movies

        // Add movies to the list
        theMovies.Add(movie1);
          
        
        
        // Add books to the list
            theBooks.Add(book1);
            theBooks.Add(book2);
            theBooks.Add(book3);
            theBooks.Add(book4);
            theBooks.Add(book5);


            Console.WriteLine("Original list of books");
            PrintBooks(theBooks); // prints all books


            PrintMovies(theMovies); // prints movies
           
        
        
        // Make changes
            book1.CheckOut(patron1);
            book2.Publisher = "Borrowed Books";
            book3.CheckOut(patron2);
            book4.CallNumber = "AB123 4A";
            book5.CheckOut(patron3);

            Console.WriteLine("After changes");
            PrintBooks(theBooks);



            // Return all the books
            for (int i = 0; i < theBooks.Count; ++i)
                theBooks[i].ReturnToShelf();

            Console.WriteLine("After returning the books");
            PrintBooks(theBooks);
        }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List<LibraryBook> books)
    {
        foreach (LibraryBook b in books)
        {
            Console.WriteLine(b);
            Console.WriteLine();
        }
    }


    // Precondition:  None
    // Postcondition: The movies have been printed to the console
    public static void PrintMovies(List<LibraryMovie> movies)
    {
        foreach (LibraryMovie b in movies)
        {
            Console.WriteLine(b);
            Console.WriteLine();
        }


    }
    }


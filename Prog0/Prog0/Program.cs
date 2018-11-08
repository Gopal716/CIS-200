// Grading ID: D1924
// Program 0
// Due Date: 1/30/2017
// Course Section: CIS-200-01-4172

// Starting Point

// File: Program.cs
// This file creates a simple test application class that creates
// an array of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {


        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2000, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            -1, "ZZ24 4F");    // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2001, "AE842 7A"); // 5th test book
        LibraryPatron patron1 = new LibraryPatron("James Hunt", "1947"); // 1st Patron name and ID
        LibraryPatron patron2 = new LibraryPatron("Lewis Hamilton", "1985"); // 2nd Patron name and ID
        LibraryPatron patron3 = new LibraryPatron("Ayrton Senna", "1960"); // 3rd Patron name and ID

        // create list for Librarybook and Add books to Librarybook list.
        List<LibraryBook> theBooks = new List<LibraryBook>();       
        theBooks.Add(book1);
        theBooks.Add(book2);
        theBooks.Add(book3);
        theBooks.Add(book4);
        theBooks.Add(book5);

        Console.WriteLine("Original list of books"); // Headline for the original list
        PrintBooks(theBooks); // the original list of books is printed under above headline

        // Make changes
        book1.CheckOut(patron1); // book1 is checked out by a patron
        book2.Publisher = "Borrowed Books"; // changes publisher for book2
        book3.CheckOut(patron2); // book3 is checked out by a patron
        book4.CallNumber = "AB123 4A"; // changes the call number for book4
        book5.CheckOut(patron3); // book5 is checked out by a patron

        Console.WriteLine("After changes"); // Headline for books after changes
        PrintBooks(theBooks); // book list after changes is printed

        // Return all the books
         for (int i = 0; i < theBooks.Count; ++i)
          theBooks[i].ReturnToShelf();

        Console.WriteLine("After returning the books"); // Headline for returned books
        PrintBooks(theBooks); // book list after getting returned is printed
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
}

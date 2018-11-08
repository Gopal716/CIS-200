// Grading ID: D1924
// CIS 200-01-4172
// Due: 2/22/2017
// Program 1B

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
    public static void Main(string[] args)
    {
        const int DAYSLATE = 14; // Number of days late to test each object's CalcLateFee method

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
            "AB73 ZF", "IP Thief"));
        items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));
        items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9B", 16, 8));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9C", 16, 9));
        items.Add(new LibraryMagazine("VB Magazine", "UofL Mags", 2017, 14,
            "MA21 5V", 1, 1));

        // Add patrons
        patrons.Add(new LibraryPatron("Ima Reader", "12345"));
        patrons.Add(new LibraryPatron("Jane Doe", "11223"));
        patrons.Add(new LibraryPatron("John Smith", "54321"));
        patrons.Add(new LibraryPatron("James T. Kirk", "98765"));
        patrons.Add(new LibraryPatron("Jean-Luc Picard", "33456"));

        // displays list of all items with details
        Console.WriteLine("List of items at start:\n");
        foreach (LibraryItem item in items)
        Console.WriteLine("{0}\n", item);
        Pause(); // pauses until you press enter then clears screen

        // Check out some items
        items[0].CheckOut(patrons[0]);
        items[2].CheckOut(patrons[2]);
        items[5].CheckOut(patrons[1]);
        items[1].CheckOut(patrons[3]);
        items[3].CheckOut(patrons[4]);

//----------------------------------------------------------------------------------------------------------------//

        // Displays list of all items with details after being checked out by patrons
        Console.WriteLine("List of items after checking some out:\n");
        foreach (LibraryItem item in items)
        Console.WriteLine("{0}\n", item);
        Pause();  // pauses until you press enter then clears screen

//----------------------------------------------------------------------------------------------------------------//

        // Uses LINQ to only select checked out items
        var chkdOutItems =     
            from list in items
            where list.IsCheckedOut()
            select list;

        // Displays checked out items only
        Console.WriteLine("List of Checked Out items only:\n");
        foreach (var i in chkdOutItems)
        Console.WriteLine("{0}\n",i);       
        Console.WriteLine("Total Items Checked Out: " + chkdOutItems.Count()); // keeps a count of total checked out items
        Console.WriteLine();
        Pause();    // pauses until you press enter then clears screen

//----------------------------------------------------------------------------------------------------------------//
  
        // Uses LINQ to only select library media items that have been checked out
        var chkdOutMedia =
             from list in chkdOutItems
             where  list.GetType() == typeof(LibraryMovie) || list.GetType() == typeof(LibraryMusic)
             select list;

        // displays checked out media items
        Console.WriteLine("List of Checked Out Media items only:\n");
        foreach (var i in chkdOutMedia)
        Console.WriteLine("{0}\n", i);
        Pause();  // pauses until you press enter then clears screen

//----------------------------------------------------------------------------------------------------------------//

        // Uses LINQ to select Titles of each unique Magazine
        var uniqueMagazineTitles =
           from list in items
           where list.GetType() == typeof(LibraryMagazine)
           select list.Title;
   
        // displays list of unique magazine titles
        Console.WriteLine("List of Unique Magazine Titles only:\n");
        foreach (var i in uniqueMagazineTitles)
        Console.WriteLine("{0}\n", i);
        Pause();  // pauses until you press enter then clears screen


//----------------------------------------------------------------------------------------------------------------//

        // create header
        Console.WriteLine("Calculated late fees after {0} days late:\n", DAYSLATE);
        Console.WriteLine("{0,42} {1,11} {2,8}", "Title", "Call Number", "Late Fee");   
        Console.WriteLine("------------------------------------------ ----------- --------");

        // Caluclate and display late fees for each item
        foreach (LibraryItem item in items)
        Console.WriteLine("{0,42} {1,11} {2,8:C}", item.Title, item.CallNumber,
                                                   item.CalcLateFee(DAYSLATE));
        Pause(); // pauses until you press enter then clears screen

//----------------------------------------------------------------------------------------------------------------//



        // Return each item that is checked out
        foreach (LibraryItem item in items)
        {
            if (item.IsCheckedOut())
                item.ReturnToShelf();
        }


//----------------------------------------------------------------------------------------------------------------//

        // Displays list after all items have been returned to the library
        Console.WriteLine("After returning all items:\n");
        foreach (LibraryItem item in items)
        Console.WriteLine("{0}\n", item);
        Console.WriteLine("Total Items Checked Out: " + chkdOutItems.Count()); // keeps count of total checked out items
        Console.WriteLine();
        Pause();  // pauses until you press enter then clears screen


//----------------------------------------------------------------------------------------------------------------//

        // Uses LINQ to select books from the items list
        var booksAndLoanPeriod =
            from list in items
            where list.GetType() == typeof(LibraryBook)
            select list;

        // Displays book titles and loan period for each
        Console.WriteLine("Books and their loan period:\n");
        Console.WriteLine();
        Console.WriteLine("{0,25} {1,11} ", "Title", "     Loan Period");  // create header
        Console.WriteLine("------------------------------ -----------");
        foreach (var item in booksAndLoanPeriod)
        Console.WriteLine("{0,30} {1,11} ", item.Title, item.LoanPeriod);
        Pause(); // pauses until you press enter then clears screen

//----------------------------------------------------------------------------------------------------------------//

        // Displays title and loan period of all books after adding 7 days to each
        Console.WriteLine("Add Loan Period by 7:\n");
        Console.WriteLine();
        Console.WriteLine("{0,25} {1,11} ", "Title", "     Loan Period");  // create header
        Console.WriteLine("------------------------------ -----------");
        foreach (var i in booksAndLoanPeriod)
        Console.WriteLine("{0,30} {1,11} ", i.Title, i.LoanPeriod + 7);
        Pause();  // pauses until you press enter then clears screen

//----------------------------------------------------------------------------------------------------------------//

        // Display whole list one more time
        foreach (LibraryItem i in items)         
        Console.WriteLine("{0}\n", i);

//----------------------------------------------------------------------------------------------------------------//

    }



    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();

        Console.Clear(); // Clear screen
    }

//----------------------------------------------------------------------------------------------------------------//
}








// Grading ID: D1924
// Program 0
// Due Date: 1/30/2017
// Course Section: CIS-200-01-4172

// Starting Point

// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public const int DEFAULT_YEAR = 2016; // Default copyright year

    private string _title;      // The book's title
    private string _author;     // The book's author
    private string _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private string _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status
    private LibraryPatron _patron; // sets a reference to LibraryPatron

    // Precondition:  theCopyrightYear >= 0
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(string theTitle, string theAuthor, string thePublisher,
        int theCopyrightYear, string theCallNumber)
    {
        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;

        ReturnToShelf(); // Make sure book is not checked out
    }
    // Precondition: none
    // Postcondition: value is set and returned based on condition
    public string Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition:  string is not empty
        // Postcondition: The title has been set to the specified value
        set
        {
            if (string.IsNullOrEmpty(value.Trim()))      // checks if title is not empty after being trimmed
                throw new ArgumentOutOfRangeException("Book Title Error"); // argumentOutOfRangeException if title is empty
            else
                _title = value;
        }
    }

    public string Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            _author = value;
        }
    }

    public string Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return _publisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            _publisher = value;
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return _copyrightYear;
        }

        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)           // checks if year value is equal or over 0
                _copyrightYear = value;
            else
              new ArgumentOutOfRangeException("CopyrightYear Error"); 
        }
    }

    public string CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return _callNumber;
        }

        // Precondition:  None
        // Postcondition: The call number has been set to the specified value
        set
        {
            if (string.IsNullOrEmpty(value.Trim()))
                throw new ArgumentOutOfRangeException("CallNumber Error");
            else
                _callNumber = value;
        }
    }

    // Precondition:  reference to LibraryPatron 
    // Postcondition: The book is checked out, and specify book is checked out by patron
    public void CheckOut(LibraryPatron patron )
   {
      _patron =  patron  ;
        _checkedOut = true;
    }

    // Precondition:  None
    // Postcondition: The book is not checked out
    public void ReturnToShelf()
    {
       _patron = null;
        _checkedOut = false;
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
    }
    // Precondition: book is checked out
    // Postcondition: Based on condition, either null or patron information is returned
    public string Patron
    {
        get
        {
            if (IsCheckedOut() == true)
                return _patron.ToString() ;
            else
                return null;
        }
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary book's data on
    //                separate lines
    public override string ToString()
    {
         string checkedOutOrNot; // variable to indicate whether book is checked out or check out patron information
        if (IsCheckedOut() == true) // checks if it's checked out
            checkedOutOrNot = Patron; // Patron information is stored if books is checked out
        else
           checkedOutOrNot = "Not Checked Out"; // this string is stored if book is not checked out

        return "Title: " + Title + System.Environment.NewLine +
            "Author: " + Author + System.Environment.NewLine +
            "Publisher: " + Publisher + System.Environment.NewLine +
            "Copyright: " + CopyrightYear.ToString("D4") + System.Environment.NewLine +
            "Checked Out By: " + System.Environment.NewLine
            + checkedOutOrNot; // returns status of checkout or patron information if checkedout
    }
}

// Grading ID: D1924
// Program 1A
// Due Date: 2/15/2017
// Course Section: CIS-200-01-4172
// Description: LibraryBook class extended from LibraryItem abstract base class


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class LibraryBook : LibraryItem
    {

    // instance variables
    private string author;
    private decimal latefee = .25m; // late fee
    private decimal totalFee;

    // parameter constructor
    public LibraryBook(string theTitle,string theAuthor, string thePublisher, int theCopyrightYear, string theCallNumber, int theLoanPeriod) : base(theTitle,thePublisher,theCopyrightYear,theCallNumber,theLoanPeriod)
    {
        // validate via property
        Author = theAuthor;
    }
    public string Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            // Since empty author is OK, just change null to empty string
            author = (value == null ? string.Empty : value.Trim());
        }
    }

    //    // override CalcLateFee() method for Library books
    public override decimal CalcLateFee(int daysLate)
    {
        totalFee = latefee * daysLate;

        return totalFee;
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the Library book data on
    //                separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // newline shortcut

        return $"Author: {Author}{NL}{base.ToString()}LATE FEE: {totalFee}";
    }


}
//}

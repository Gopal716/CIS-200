// Grading ID: D1924
// Program 1A
// Due Date: 2/15/2017
// Course Section: CIS-200-01-4172
// Description: LibraryMusic class extended from LibraryMediaItem class




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class LibraryMovie : LibraryMediaItem
    {

    // instance variables
        private string director;
        private MediaType _medium;
        private MPAARatings _rating;
        private decimal lateFeeBRAY = 1.50m; // late fee for bluray
        private decimal lateFeeDvdVHS = 1m; // late fee for vhs and dvd
        private decimal limit = 25m;        // late fee limit
        private decimal total;
        private decimal fee;

    // Parameter constructor
        public LibraryMovie(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber, int theLoanPeriod, double theDuration, string theDirector, MediaType medium, MPAARatings rating) : base(theTitle,thePublisher,theCopyrightYear,theCallNumber,theLoanPeriod,theDuration)
    {
        // validate via properties
            Director = theDirector;
            Medium = medium;
            Rating = rating;
        }

        // enum for movie MPAA ratings
        public enum MPAARatings {G, PG, PG13, R, NC17, U };

        public string Director
        {
            // Precondition:  None
            // Postcondition: The director has been returned
            get
            {
                return director;
            }

            // Precondition:  None
            // Postcondition: The director has been set to the specified value
            set
        {
            if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                director = value.Trim();
            else
                throw new ArgumentOutOfRangeException($"{nameof(Director)}", value,
                    $"{nameof(Director)} must not be null or empty");
        }
    }
    
    // not sure how to do this part
        public override MediaType Medium
        {
            get
            {
                return _medium;
            }

            set
            {
            _medium = value;
            }
        }

        public  MPAARatings Rating
        {
        // Precondition:  None
        // Postcondition: The rating has been returned
        get
        {
                return _rating;
            }
        // Precondition: none
        // Postcondition: The rating has been set to the specified value
        set
        {
                _rating = value;
            }
            
        }


    // override CalcLateFee() method to specifie late fee for movie items
    public override decimal CalcLateFee(int daysLate)
        {


        if (Medium == MediaType.VHS || Medium == MediaType.DVD)
        { total = daysLate * lateFeeDvdVHS; } // total for dvd/vhs
        else
        { total = daysLate * lateFeeBRAY; } // total for bluray

        if (total > limit)
            fee = limit;  // if total is over limit
        else
            fee = total;

        return fee;

        }

    // Precondition:  None
    // Postcondition: A string is returned presenting the Library Movie data on
    //                separate lines
    public override string ToString()
        {

        string NL = Environment.NewLine; // newline shortcut

        return $"{base.ToString()}{NL}Director: {Director}{NL}Medium: {Medium}{NL}Rating: {Rating}{NL}LATE FEE: {fee}";
        }

    }
    

// Grading ID: D1924
// Program 1A
// Due Date: 2/15/2017
// Course Section: CIS-200-01-4172
// Description: This file creates an abstract base LibraryBook class capable of tracking
// the title, loan period, publisher, copyright year, call number, and checked out status.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  public abstract class LibraryItem
    {

    // instance variables
        private string _title;
        private string _publisher;
        private int _copyrightYear;
        private int _loanPeriod;
        private string _callNumber;
        private bool _checkedOut;   // The item's checked out status


    // Parameter constructor
        public LibraryItem(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber, int theLoanPeriod)
        {
        // validates via properties
            Title = theTitle;
            Publisher = thePublisher;
            CopyrightYear = theCopyrightYear;
            CallNumber = theCallNumber;
            LoanPeriod = theLoanPeriod;

            ReturnToShelf(); // makes sure items are not checked out

        }

        public string Title
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get
            {
                return _title;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The title has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _title = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Title)}", value,
                        $"{nameof(Title)} must not be null or empty");
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
                // Since empty author is OK, just change null to empty string
                _publisher = (value == null ? string.Empty : value.Trim());
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
                if (value >= 0)
                    _copyrightYear = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                        $"{nameof(CopyrightYear)} must be >= 0");
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

            // Precondition:  value must not be null or empty
            // Postcondition: The call number has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _callNumber = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(CallNumber)}", value,
                        $"{nameof(CallNumber)} must not be null or empty");
            }
        }

        public int LoanPeriod
        {
            // Precondition:  None
            // Postcondition: The copyright year has been returned
            get
            {
                return _loanPeriod;
            }

            // Precondition:  value >= 0
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 0)
                    _loanPeriod = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                        $"{nameof(LoanPeriod)} must be >= 0");
            }
        }

        public  LibraryPatron Patron
        {
            // Precondition:  None
            // Postcondition: The item's patron has been returned
            get; // Auto-implement is fine

            // Helper
            // Precondition:  None
            // Postcondition: The item's patron has been set to the specified value
           private set; // Auto-implement is fine 
        }

        // Precondition:  thePatron != null
        // Postcondition: The item is checked out
        public void CheckOut(LibraryPatron thePatron)
        {
            _checkedOut = true;
            if (thePatron != null)
                Patron = thePatron;
            else
                throw new ArgumentNullException($"{nameof(thePatron)}", $"{nameof(thePatron)} must not be null");
        }

        // Precondition:  None
        // Postcondition: The item is not checked out
        public void ReturnToShelf()
        {
            _checkedOut = false;
            Patron = null; // Remove previously stored reference to patron
        }

        // Precondition:  None
        // Postcondition: true is returned if the item is checked out,
        //                otherwise false is returned
        public bool IsCheckedOut()
        {
            return _checkedOut;
        }

    // incomplete abstract method to calculate fee
    public abstract decimal CalcLateFee(int daysLate);
    
       
        

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            string checkedOutBy; // Holds checked out message

            if (IsCheckedOut())
                checkedOutBy = $"Checked Out By: {NL}{Patron}";
            else
                checkedOutBy = "Not Checked Out";

            return $"Title: {Title}{NL}Publisher: {Publisher}{NL}" +
                $"Copyright: {CopyrightYear:D4}{NL}Call Number: {CallNumber}{NL}" + 
                $"Loan Period: {LoanPeriod}{NL}{checkedOutBy}{NL}";
        }


    }
//}

// Grading ID: D1924
// Program 1A
// Due Date: 2/15/2017
// Course Section: CIS-200-01-4172
// Description: LibraryPeriodical class extended from LibraryItem class




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public abstract class LibraryPeriodical : LibraryItem
    {
        // instance variables
        private int volume;
        private int number;

        // parameter constructor
       public LibraryPeriodical(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber, int theLoanPeriod, int theVolume, int theNumber) : base(theTitle,thePublisher,theCopyrightYear,theCallNumber,theLoanPeriod)
       {
            // validate via properties
            Volume = theVolume;
            Number = theNumber;
            
        }

        public int Volume
        {
            // Precondition:  None
            // Postcondition: The volume has been returned
            get
            {
                return volume;
            }

            // Precondition:  value >= 0
            // Postcondition: The volume has been set to the specified value
            set
            {
                if (value >= 0)  // validation
                    volume = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Volume)}", value,
                        $"{nameof(Volume)} must be >= 0");
            }
        }

        public int Number
        {
            // Precondition:  None
            // Postcondition: The number has been returned
            get
            {
                return number;
            }

            // Precondition:  value >= 0
            // Postcondition: The number has been set to the specified value
            set
            {
                if (value >= 0)   // validation
                    number = value; 
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Number)}", value,
                        $"{nameof(Number)} must be >= 0");
            }
        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the Library Periodicals data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // newline shortcut

            return $"{base.ToString()}{NL}Volume: {Volume}{NL}Number: {Number}";

        }


    }


// Grading ID: D1924
// Program 1A
// Due Date: 2/15/2017
// Course Section: CIS-200-01-4172
// Description: Abstract class LibraryMediaItem extended from abstract base class LibraryItem



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class LibraryMediaItem : LibraryItem
    {
        // instance variables
        private double duration;

    // parameter constructor
        public LibraryMediaItem(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber, int theLoanPeriod, double theDuration) : base(theTitle,thePublisher,theCopyrightYear,theCallNumber,theLoanPeriod)
    {
        // validate via property
            Duration = theDuration;
        }
    // enum for Media Type
    public enum MediaType
        {
            DVD, BLURAY, VHS, CD, SACD, VINYL
        };

        public double Duration
        {
            // Precondition:  None
            // Postcondition: The Duration has been returned
            get
            {
                return duration;
            }

            // Precondition:  value > 0
            // Postcondition: The duration has been set to the specified value
            set
            {
                if (value > 0)
                    duration = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Duration)}", value,
                        $"{nameof(Duration)} must be >= 0");
            }
        }

    // incomplete abstract property for Medium 
       public abstract MediaType Medium { get; set; }


    // Precondition:  None
    // Postcondition: A string is returned presenting the Library Media Item data on
    //                separate lines
    public override string ToString()
        {
            return $"{base.ToString()}Duration: {Duration}";
        }










    }
//}

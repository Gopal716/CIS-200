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


  public  class LibraryMusic : LibraryMediaItem
    {
        // instance variables
        private string artist;
        private int _numOfTracks;
        private MediaType _medium;
        private decimal lateFee = .50m; // const for late fee
        private decimal total;
        private decimal limit = 20m; // const for fee limit
        private decimal fee;


        // parameter constructor
        public LibraryMusic(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber, int theLoanPeriod, double theDuration, string theArtist, MediaType medium, int numOfTracks) : base(theTitle,thePublisher,theCopyrightYear,theCallNumber,theLoanPeriod,theDuration)
    {
            // validates via properties
            Artist = theArtist;
            NumOfTracks = numOfTracks;
            Medium = medium;
        }

        public string Artist
        {
            // Precondition:  None
            // Postcondition: The artist has been returned
            get
            {
                return artist;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The artist has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    artist = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Artist)}", value,
                        $"{nameof(Artist)} must not be null or empty");
            }

        }

        // This part is inaccurate, not sure how to do this.
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

        public int NumOfTracks
        {
            // Precondition:  None
            // Postcondition: The number of tracks has been returned
            get
            {
                return _numOfTracks;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The number of tracks has been set to the specified value
            set
            {
                if (value >= 1)
                    _numOfTracks = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(NumOfTracks)}", value,
                        $"{nameof(NumOfTracks)} must be >= 0");
            }
        }

        // override CalcLateFee() method to specifie late fee for music items
        public override decimal CalcLateFee(int daysLate)
        {
            total = daysLate * lateFee;

            if (total > limit) // fee limit of 20

                fee = limit;
            else
                fee =  total;

            return fee;
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the Library Music data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return $"{base.ToString()}{NL}Artist: {Artist}{NL}Tracks: {NumOfTracks}{NL}Medium: {Medium}{NL}LATE FEE: {fee}";
        }
    }


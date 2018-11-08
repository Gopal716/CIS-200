// Grading ID: D1924
// Program 1A
// Due Date: 2/15/2017
// Course Section: CIS-200-01-4172
// Description: LibraryMagazine class extended from LibraryPeriodical class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    public class LibraryMagazine : LibraryPeriodical
    {
        // instance variables
        private decimal lateFee = .25m; // late fee
        private decimal total;
        private decimal limit = 20m; // fee limit
        private decimal fee;

        // parameter constructor
        public LibraryMagazine(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber, int theLoanPeriod, int theVolume, int theNumber) : base(theTitle,thePublisher,theCopyrightYear,theCallNumber,theLoanPeriod, theVolume, theNumber)
       {
            

        }

        // override CalcLateFee() method for Magazines
        public override decimal CalcLateFee(int daysLate)
        {
            total = lateFee * daysLate;

            if (total > limit) // if over limit
                fee = limit;
            else
                fee = total; // if within limit

            return fee;
            
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the Library Magazine data on
        //                separate lines
        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}LATE FEE: {fee}";
        }


    }
}

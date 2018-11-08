// Grading ID: D1924
// Program 1A
// Due Date: 2/15/2017
// Course Section: CIS-200-01-4172
// Description: LibraryJournal class extended from LibraryPeriodical class





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public  class LibraryJournal : LibraryPeriodical
    {
    // Instance variables
        private string discipline;
        private string editor;
        private decimal lateFee = .75m; // late fee
        private decimal totalFee;


    // parameter constructor 
        public LibraryJournal(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber, int theLoanPeriod, int theVolume, int theNumber, string theDiscipline, string theEditor) : base(theTitle,thePublisher,theCopyrightYear,theCallNumber,theLoanPeriod, theVolume, theNumber)
       {
            Discipline = theDiscipline;
            Editor = theEditor;

        }

        public string Discipline
        {
        // Precondition:  None
        // Postcondition: The discipline has been returned
        get
        {
                return discipline;
            }
        // Precondition:  None
        // Postcondition: The discipline has been set to the specified value
        set
        {
                discipline = value;
            }
        }

        public string Editor
        {
        // Precondition:  None
        // Postcondition: The editor has been returned
        get
        {
                return editor;
            }
        // Precondition:  None
        // Postcondition: The editor has been set to the specified value
        set
        {
                editor = value;
            }
        }

    // override CalcLateFee() method for Library Journals
    public override decimal CalcLateFee(int daysLate)
        {
            totalFee = lateFee * daysLate;

            return totalFee;
        }

    // Precondition:  None
    // Postcondition: A string is returned presenting the Library Journal data on
    //                separate lines
    public override string ToString()
        {

        string NL = Environment.NewLine; // newline shortcut

        return $"{base.ToString()}{NL}Discipline: {Discipline}{NL}Editor: {Editor}{NL}LATE FEE: {totalFee}";
        }




    }


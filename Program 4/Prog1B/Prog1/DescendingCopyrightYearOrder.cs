// Program 4
// CIS-200-01
// Due: 4/19/2017
// D1924


// This class provides an IComparer for the LibraryItem class
// that orders the objects in descending CopyrightYear order.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
   public class DescendingCopyrightYearOrder : Comparer<LibraryItem>
    {
        // Precondition:  None
        // Postcondition: Reverses natural LibraryItem order, descending by CopyrightYear
        public override int Compare(LibraryItem x, LibraryItem y)
        {
          

            return (-1) * x.CopyrightYear.CompareTo(y.CopyrightYear); // Reverses natural order, so descending


        }

    }
}

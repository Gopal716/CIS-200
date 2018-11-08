// Grading ID: D1924
// Program 0
// Due Date: 1/30/2017
// Course Section: CIS-200-01-4172

// Starting Point


// File: LibraryPatron.cs
// This file creates a simple LibraryPatron class capable of tracking
// the patron's name and ID.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryPatron 
{
    // Backing Fields
    private string _patronName; // Name of the patron
    private string _patronID;   // ID of the patron

    // Precondition:  None
    // Postcondition: The patron has been initialized with the specified name
    //                and ID
    public LibraryPatron(string name, string id)
    {
        PatronName = name;
        PatronID = id;
    }
    // Precondtion: none
    // Postcondition: sets and returns value based on condition
    public string PatronName
    {
        // Precondition:  None
        // Postcondition: The patron's name has been returned
        get
        {
            return _patronName;
        }

        // Precondition:  None
        // Postcondition: The patron name has been set to the specified value
        set
       { if (string.IsNullOrEmpty(value.Trim()))                              // trims the Patron name and checks if the string is empty
              throw new ArgumentOutOfRangeException("Check Patron Names!");   // argumentOutOfRangeException if invalid name
       else
                _patronName = value;
            
        }
    }
    // Precondition: None
    // Postcondition: sets and returns value based on condition
    public string PatronID
    {
        // Precondition:  None
        // Postcondition: The patron's ID has been returned
        get
        {
            return _patronID;
        }

        // Precondition:  None
        // Postcondition: The patron's ID has been set to the specified value
        set
        {
            if (string.IsNullOrEmpty(value.Trim()))                              // trims the Patron ID and checks if the string is empty
                throw new ArgumentOutOfRangeException("Check Patron IDs!");      // argumentOutOfRangeException if invalid ID
            else
                _patronID = value;
        }
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary patron's data on
    //                separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Name: {PatronName}{NL}ID: {PatronID}";
    }

}


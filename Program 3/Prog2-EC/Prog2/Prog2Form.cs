﻿// Program 3
// CIS 200-01
// Due: 4/5/2017
// By: D1924

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.

// Extra Credit - Check Out and Return only show relevant items

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;    // add attributes for serialization, binary formatting, and IO
using System.Runtime.Serialization;
using System.IO;      

namespace LibraryItems
{
    public partial class Prog2Form : Form
    {
        private Library _lib; // The library
       
        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog2Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library

        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 3{NL}By: D1924{NL}CIS 200-01{NL}Spring 2017",
                "About Program 2");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryPatron> patrons;                // List of patrons
            string NL = Environment.NewLine;            // NewLine shortcut

            patrons = _lib.GetPatronsList();

            result.Append($"Patron List - {patrons.Count} patrons{NL}{NL}");

            foreach (LibraryPatron p in patrons)
                result.Append($"{p}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            result.Append($"Item List - {items.Count} items{NL}{NL}");

            foreach (LibraryItem item in items)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            result.Append($"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}");

            foreach (LibraryItem item in checkedOutItems)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that aren't already checked out

            List<LibraryItem> notCheckedOutList; // List of items not checked out
            List<int> notCheckedOutIndices;      // List of index values of items not checked out
            List<LibraryItem> items;             // List of library items
            List<LibraryPatron> patrons;         // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();
            notCheckedOutList = new List<LibraryItem>();
            notCheckedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (!items[i].IsCheckedOut()) // Not checked out
                {
                    notCheckedOutList.Add(items[i]);
                    notCheckedOutIndices.Add(i);
                }

            if ((notCheckedOutList.Count() == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(notCheckedOutList, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = notCheckedOutIndices[checkoutForm.ItemIndex]; // Look up index from full list
                        _lib.CheckOut(itemIndex, checkoutForm.PatronIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Check Out Index!", "Check Out Error");
                    }
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that are already checked out

            List<LibraryItem> checkedOutList; // List of items checked out
            List<int> checkedOutIndices;      // List of index values of items checked out
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();
            checkedOutList = new List<LibraryItem>();
            checkedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (items[i].IsCheckedOut()) // Checked out
                {
                    checkedOutList.Add(items[i]);
                    checkedOutIndices.Add(i);
                }

            if ((checkedOutList.Count() == 0)) // Must have checked out items
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(checkedOutList); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = checkedOutIndices[returnForm.ItemIndex]; // Look up index from full list
                        _lib.ReturnToShelf(itemIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Return Index!", "Return Error");
                    }
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

     
        private BinaryFormatter formatter = new BinaryFormatter();   // object for serializing RecordSerializables in binary format 
        private BinaryFormatter reader = new BinaryFormatter();    // object for deserializing RecordSerializables in binary format 

        private FileStream OutputData; // stream for writing to a file
        private FileStream InputData; // stream for reading from a file

        // Precondition:  File, Open Library menu item activated
        // Postcondition: The File location for the program is displayed. If select data file is OK, file content is loaded to the form
        private void openLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
                // create and show dialog box enabling user to open file
              string fileName; // name of file containing data
              DialogResult result; // result of OpenFileDialog

              using (OpenFileDialog fileChooser = new OpenFileDialog())
              {
                  result = fileChooser.ShowDialog();
                  fileName = fileChooser.FileName;   // get specified name

              }


              // ensure that user clicked OK
              if (result == DialogResult.OK)
                 reportTxt.Clear();      // clear report displayed from any previous files

              // show error if user specified invalid file
              if (string.IsNullOrEmpty(fileName))
              {
                  MessageBox.Show("Invalid File Name!");
              }
              else
              {

                   
                
                  try
                 {
                    // create FileStream to obtain read access to file
                          InputData = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                       _lib = (Library)reader.Deserialize(InputData);

                  }
                catch (IOException)
                {
                    MessageBox.Show("Error: Try Application Restart."); // New saved files cannot be opened without restarting application
                }
                 catch (SerializationException)
                  {
                      MessageBox.Show("Cannot Open this File!");  // error if file cannot be read
                  }
              }

        }

        // Precondition:  File, Save Library menu item activated
        // Postcondition: The File location for the program is displayed. If file name is OK, form content is saved in a file.
        private void saveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to save file
            string fileName; // name of file to save data
            DialogResult result; // result of OpenFileDialog


            using (SaveFileDialog filePick = new SaveFileDialog())
            {
                filePick.CheckFileExists = false;  // let user create file

                // retrieve the result of the dialog box
                result = filePick.ShowDialog();
                fileName = filePick.FileName; // get specified file name
            }

            // ensure that user clicked Ok
            if (result == DialogResult.OK)
            {
                // show error if user specified invalid file
             
              if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("File Name is Invalid!");
                }
                else
                {
                    // save file via filestream if user specified valid file
                    try
                    {
                        // open file with write access
                        OutputData = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                    }
                    catch (IOException)
                    {
                        // notify user if file could not be opened
                        MessageBox.Show("Error!");
                    }
                }
            }
           try
            {
             formatter.Serialize(OutputData, _lib);
         
            }
          catch (IOException)
            {
               MessageBox.Show("Error!");
            } 
            catch (ArgumentNullException)
            {
                MessageBox.Show("Cannot Save in Existing File!"); 
            }

        }

        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                
            List<LibraryPatron> patrons;         // List of patrons

            
            patrons = _lib.GetPatronsList(); // gets list of patrons from library
          


            
                EditPatronForm editPatronForm = new EditPatronForm(patrons); // pass patrons to the form
            PatronForm editSelectedPatron = new PatronForm(); // create a new patron form

                DialogResult result = editPatronForm.ShowDialog(); // Show form as dialog and store result

            // ensure that user clicked Ok
            if (result == DialogResult.OK)
            {
                try
                {
                    LibraryPatron selectedPatron = patrons[editPatronForm.PatronIndex]; // stores selected patron
                    editSelectedPatron.PatronName = selectedPatron.PatronName; // name of the selected patron
                    editSelectedPatron.PatronID = selectedPatron.PatronID;   // ID of the selected patron

                    result = editSelectedPatron.ShowDialog();   // show form as dialog for selected patron

                    _lib._patrons.RemoveAt(editPatronForm.PatronIndex); // the patron being edited is removed

                    LibraryPatron editedPatron = new LibraryPatron(editSelectedPatron.PatronName, editSelectedPatron.PatronID);  
                    _lib._patrons.Insert(editPatronForm.PatronIndex, editedPatron); // patron with edited information is added
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Select Patron!");  // error is no patron is selected
                }
                }
                

                editPatronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;         // List of Items
        


            items = _lib.GetItemsList(); // gets list of items from library




            EditBookForm editBookForm = new EditBookForm(items); // pass items to the form
            BookForm editSelectedBook = new BookForm(); // create new book form

            DialogResult result = editBookForm.ShowDialog(); // Show form as dialog and store result       

            // ensure user clicked OK
            if (result == DialogResult.OK)
            {

             
              try
                {

                   int  bookCopyrightYear; // holds copyright year
                   int bookLoanPeriod; // holds load period

                           
                        LibraryBook selectedItem = (LibraryBook)items[editBookForm.ItemIndex];   // stores selected book
               
                        editSelectedBook.ItemTitle = selectedItem.Title;
                        editSelectedBook.ItemPublisher = selectedItem.Publisher;
                        editSelectedBook.ItemCopyrightYear = selectedItem.CopyrightYear.ToString();
                        editSelectedBook.ItemLoanPeriod = selectedItem.LoanPeriod.ToString();
                        editSelectedBook.ItemCallNumber = selectedItem.CallNumber;
                        editSelectedBook.BookAuthor = selectedItem.Author;

                    int.TryParse(editSelectedBook.ItemCopyrightYear, out bookCopyrightYear);
                    int.TryParse(editSelectedBook.ItemLoanPeriod, out bookLoanPeriod); 

                        result = editSelectedBook.ShowDialog();   // show form as dialog for selected book

                    _lib._items.RemoveAt(editBookForm.ItemIndex); // the book being edited is removed


                        LibraryBook editedBook = new LibraryBook(editSelectedBook.ItemTitle, editSelectedBook.ItemPublisher, bookCopyrightYear, bookLoanPeriod, editSelectedBook.ItemCallNumber, editSelectedBook.BookAuthor);

                    _lib._items.Insert(editBookForm.ItemIndex, editedBook); // the edited version of the book is added
                    
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Select a Book Item!"); // error if selected item is not a book
                    
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Select a Book!");  // error if no book selected
                }
            }


            editBookForm.Dispose(); // Good .NET practice - will get garbage collected anyway

        }
    }
}


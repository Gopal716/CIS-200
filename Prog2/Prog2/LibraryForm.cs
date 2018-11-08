// Description: Main Form, communicates with Library class and manipulates the library.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class LibraryForm : Form
    {


        Library LibraryData = new Library(); // gives access to Library class
        
        

        public LibraryForm()
        {
            InitializeComponent();


            // hard coded list of patrons and items

            LibraryData.AddPatron("James Hunt", "001");
            LibraryData.AddPatron("Jessica Jones", "002");
            LibraryData.AddPatron("James Bond", "003");



            LibraryData.AddLibraryBook("Sample B0ok", "Sample Publisher", 2017, 31, "Q111", "Sample Auth0r");
            LibraryData.AddLibraryBook("Samp1e Book", "Sample Publisher", 2017, 31, "Q121", "Samp1e Author");
            LibraryData.AddLibraryBook("2ample Book", "Sample Publisher", 2017, 31, "Q126", "2ample Author");
            LibraryData.AddLibraryBook("Sampl3 Book", "Sample Publisher", 2017, 31, "Q129", "Sampl3 Author");
            LibraryData.AddLibraryBook("S4mple Book", "Sample Publisher", 2017, 31, "Q122", "Sample 4uthor");
            LibraryData.AddLibraryBook("5ample Book", "Sample Publisher", 2017, 31, "Q023", "5ample Author");

        }


        //Precondition: about menu item click
        //Postcondition: display about information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading ID: D1924" + "\n" + "Program 2" + "\n" + "Due Date: 3/10/17" + "\n" + "Course Section: CIS-200-01-4172"  );

           
        }

        //Precondition: exit menu item click
        //Postcondition: closes form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        //Precondition: patron menu item click
        //Postcondition: show patron input form 
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPatronForm patronDialog = new InputPatronForm();
            DialogResult result;



            result = patronDialog.ShowDialog();
            if (result == DialogResult.OK)
            {


                LibraryData.AddPatron(patronDialog.patronName, patronDialog.patronId);
            }
        }

        //Precondition: patron list menu item click
        //Postcondition: display patrons information
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            reportRichTxtBox.Clear();
            
            reportRichTxtBox.Text += "Number of Patrons: " + LibraryData.GetPatronCount() + Environment.NewLine;

            foreach (LibraryPatron i in LibraryData.GetPatronsList())
                reportRichTxtBox.Text += Environment.NewLine + i + Environment.NewLine;
                


        }

        //Precondition: book menu item click
        //Postcondition: show book input form 
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm AddBookDialog = new AddBookForm();
            DialogResult result;



            result = AddBookDialog.ShowDialog();
            if (result == DialogResult.OK)
            {


                LibraryData.AddLibraryBook(AddBookDialog.title, AddBookDialog.publisher, AddBookDialog.copyRightYear,AddBookDialog.loanPeriod,AddBookDialog.callNumber,AddBookDialog.author);
            }
        }

        //Precondition: item list menu item click
        //Postcondition: display items list 
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            reportRichTxtBox.Clear();

            reportRichTxtBox.Text += "Number of Items: " + LibraryData.GetItemCount() + Environment.NewLine;

            foreach (LibraryBook i in LibraryData.GetItemsList())
                reportRichTxtBox.Text += Environment.NewLine + i + Environment.NewLine;




        }

        //Precondition: checkout menu item click
        //Postcondition: show checkout form and pass data to checkout form
        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutDialog = new CheckOutForm(LibraryData.GetItemsList(), LibraryData.GetPatronsList());
            DialogResult result;
            result = checkOutDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                LibraryData.CheckOut(checkOutDialog.items, checkOutDialog.patrons);
              
            }

        }

        //Precondition: return menu item click
        //Postcondition: show return form and pass data to checkout form
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReturnForm returnDialog = new ReturnForm(LibraryData.GetItemsList());
            DialogResult result;
            result = returnDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

               LibraryData.ReturnToShelf(returnDialog.items);

            }

        }

        //Precondition: checkedOutItems menu item click
        //Postcondition: display checkedOutItems 
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportRichTxtBox.Clear();

            reportRichTxtBox.Text += "Number of Items Checked Out: " + LibraryData.GetCheckedOutCount() + Environment.NewLine;
            


            foreach (LibraryItem i in LibraryData.GetItemsList())
                if (i.IsCheckedOut())                               // displays items if checked out
                    reportRichTxtBox.Text += Environment.NewLine + i + Environment.NewLine;

            


        }
    }
}


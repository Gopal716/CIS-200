
// This file creates a GUI for selecting a book item to be edited. It also displays list of books.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class EditBookForm : Form
    {
        private List<LibraryItem> _item;     // List of library items

        // Precondition:  List itemList is populated with the available
        //                LibraryItems to choose from
        // Postcondition: The form's GUI is prepared for display.
        public EditBookForm(List<LibraryItem> itemList)
        {
            InitializeComponent();

            _item = itemList;
           


        }


        // Precondition:  None
        // Postcondition: items are used to populate the
        //                listbox
        private void EditBookForm_Load(object sender, EventArgs e)
        {
            foreach(LibraryItem item in _item)
               
               selectBookListBox.Items.Add( item.Title + " , " + item.Publisher + " , " + item.CopyrightYear + " , " + item.LoanPeriod + " , " + item.CallNumber  );
        }

        internal int ItemIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected patron combo box has been returned
            get
            {
                return selectBookListBox.SelectedIndex;
            }
            set
            {
                selectBookListBox.SelectedIndex = value;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // If all controls validate
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result
        }

        // Precondition:  cancel button click
        // Postcondition: The form is closed
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

// This file creates a GUI for selecting a patron for editing patron information. It also displays list of patrons.


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
    public partial class EditPatronForm : Form
    {
        private List<LibraryPatron> _patrons; // List of patrons


        // Precondition:  List patronList is populated with the available
        //                LibraryPatrons to choose from
        // Postcondition: The form's GUI is prepared for display.
        public EditPatronForm(List<LibraryPatron> patronList)
        {
            InitializeComponent();

            _patrons = patronList;
        }

        // Precondition:  None
        // Postcondition: patrons are used to populate the
        //                listbox
        private void EditPatronForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in _patrons)
                selectPatronListBox.Items.Add(patron.PatronName + ", " + patron.PatronID);

        }


        internal int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected patron combo box has been returned
            get
            {
                return selectPatronListBox.SelectedIndex;
            }
            set
            {
                selectPatronListBox.SelectedIndex = value;
            }
        }


        private void editPatOKBtn_Click(object sender, EventArgs e)
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

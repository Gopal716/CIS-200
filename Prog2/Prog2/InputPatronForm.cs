// Description: code view for Input Patron Form, captures input data to be stored in Library

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
    public partial class InputPatronForm : Form
    {
        public InputPatronForm()
        {
            InitializeComponent();
        }
        //Precondition: none
        //Postcondition: a patron name is returned
        internal string patronName
        {
            get { return patNameTxtBox.Text; }
            set { patNameTxtBox.Text = value; }
        }

        //Precondition: none
        //Postcondition: a patron ID is returned
        internal string patronId
        {
            get { return patIdTxtBox.Text; }
            set { patIdTxtBox.Text = value; }
        }

        //Precondition: none
        //Postcondition: set error if invalid input
        private void patNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (patNameTxtBox.Text == string.Empty)
            { 
                e.Cancel = true;        
                patInputError.SetError(patNameTxtBox, "Enter Valid Name!");

            }
        }

        //Precondition: none
        //Postcondition: set error 
        private void patNameTxtBox_Validated(object sender, EventArgs e)
        {
            patInputError.SetError(patNameTxtBox, "");
        }


        //Precondition: none
        //Postcondition: set error if invalid input
        private void patIdTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (patIdTxtBox.Text == string.Empty)
            { 
                e.Cancel = true;        
                patInputError.SetError(patIdTxtBox, "Enter Valid Name!");

            }
        }

        //Precondition: none
        //Postcondition: set error 
        private void patIdTxtBox_Validated(object sender, EventArgs e)
        {
            patInputError.SetError(patIdTxtBox, "");
        }

        //Precondition: validation
        //Postcondition: ok to add patron
        private void addPatBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

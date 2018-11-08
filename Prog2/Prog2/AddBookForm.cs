// Description: code view for Add book form, responsible for adding books to library

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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }


        //Precondition: none
        //Postcondition: title is returned 
        internal string title
        {
            get { return titleTxBx.Text; }
            set { titleTxBx.Text = value; }
        }

        //Precondition: none
        //Postcondition: publisher is returned
        internal string publisher
        {
            get { return publisherTxBx.Text; }
            set { publisherTxBx.Text = value; }
        }

        //Precondition: int value
        //Postcondition: copyright year is returned
        internal int copyRightYear
        {  
             
            get {
                int year;
                int.TryParse(copyRtYrTxBx.Text, out year);

                return year ; }

            set {
              int year;
              int.TryParse(copyRtYrTxBx.Text, out year);
              
             

                year = value  ;
            }
        }

        //Precondition: int value
        //Postcondition: load period is returned
        internal int loanPeriod
        {
            get {
                int period;
                int.TryParse(loanPerTxBx.Text, out period);

                return period; }
            set {
                int period;
                int.TryParse(loanPerTxBx.Text, out period);

                period = value; }
        }

        //Precondition: none
        //Postcondition: call number is returned
        internal string callNumber
        {
            get { return callNumTxBx.Text; }
            set { callNumTxBx.Text = value; }
        }

        //Precondition: none
        //Postcondition: author is returned
        internal string author
        {
            get { return authorTxBx.Text; }
            set { authorTxBx.Text = value; }
        }

        //Precondition: none
        //Postcondition: set error if invalid input
        private void titleTxBx_Validating(object sender, CancelEventArgs e)
        {
            if (titleTxBx.Text == string.Empty)
            { 
                e.Cancel = true;       
                bookInputError.SetError(titleTxBx, "Enter Valid Title!");

            }
        }

        //Precondition: none
        //Postcondition: set error 
        private void titleTxBx_Validated(object sender, EventArgs e)
        {
            bookInputError.SetError(titleTxBx, "");
        }

        //Precondition: none
        //Postcondition: set error if invalid input
        private void publisherTxBx_Validating(object sender, CancelEventArgs e)
        {
            if (publisherTxBx.Text == string.Empty)
            { 
                e.Cancel = true;       
                bookInputError.SetError(publisherTxBx, "Enter Valid Publisher!");

            }
        }

        //Precondition: none
        //Postcondition: set error 
        private void publisherTxBx_Validated(object sender, EventArgs e)
        {
            bookInputError.SetError(publisherTxBx, "");
        }

        //Precondition: positive year   
        //Postcondition: set error if invalid input
        private void copyRtYrTxBx_Validating(object sender, CancelEventArgs e)
        {
           

            if (copyRtYrTxBx.Text == string.Empty)
                  
                e.Cancel = true;        
                bookInputError.SetError(copyRtYrTxBx, "Enter Valid Year!");

            
        }

        //Precondition: none
        //Postcondition: set error 
        private void copyRtYrTxBx_Validated(object sender, EventArgs e)
        {
            bookInputError.SetError(copyRtYrTxBx, "");
        }

        //Precondition: none
        //Postcondition: set error if invalid input
        private void loanPerTxBx_Validating(object sender, CancelEventArgs e)
        {
       
            if (loanPerTxBx.Text == string.Empty)
            {
                e.Cancel = true;
                bookInputError.SetError(loanPerTxBx, "Enter Valid Loan Period!");

            }
        }
        //Precondition: none
        //Postcondition: set error 
        private void loanPerTxBx_Validated(object sender, EventArgs e)
        {
            bookInputError.SetError(loanPerTxBx, "");
        }
        //Precondition: none
        //Postcondition: set error if invalid input
        private void callNumTxBx_Validating(object sender, CancelEventArgs e)
        {
            if (callNumTxBx.Text == string.Empty)
            {
                e.Cancel = true;
                bookInputError.SetError(callNumTxBx, "Enter Valid Call Number!");

            }
        }
        //Precondition: none
        //Postcondition: set error
        private void callNumTxBx_Validated(object sender, EventArgs e)
        {
            bookInputError.SetError(callNumTxBx, "");
        }
        //Precondition: none
        //Postcondition: set error if invalid input
        private void authorTxBx_Validating(object sender, CancelEventArgs e)
        {
            if (authorTxBx.Text == string.Empty)
            {
                e.Cancel = true;
                bookInputError.SetError(authorTxBx, "Enter Valid Author!");

            }
        }
        //Precondition: none
        //Postcondition: set error
        private void authorTxBx_Validated(object sender, EventArgs e)
        {
            bookInputError.SetError(authorTxBx, "");
        }

        //Precondition: validation
        //Postcondition: ok to add book
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

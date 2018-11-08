// Description: code view for checkout Dialogbox Form. Responsible for validation and Managing checkout list for items and patrons.

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
    public partial class CheckOutForm : Form
    {
        private List<LibraryItem> itemsList;     // List of items 
        private List<LibraryPatron> patronsList; // list of patrons 

        // parameterized constructor that accepts items and patrons
        public CheckOutForm(List<LibraryItem> items, List<LibraryPatron> patrons)
        {
            InitializeComponent();
            itemsList = items;
            patronsList = patrons;
           
        }

        //Precondition: none
        //Postcondition: items and patrons are loaded into combo boxes
        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem i in itemsList)
              //  if (i.IsCheckedOut() == false)               // attempt for extra credit
                selectItemComboBx.Items.Add(i.Title + ", " + i.CallNumber);

            foreach (LibraryPatron i in patronsList)
                selectPatronComboBx.Items.Add(i.PatronName + ", " + i.PatronID);
        }

        public int items
        {
            //Precondition: none
            //Postcondition: index for selected item is returned
            get
            {
                return selectItemComboBx.SelectedIndex;
            }
            //Precondition: none
            //Postcondition: value is set to the item
            set
            {
                selectItemComboBx.SelectedIndex = value;
            }
        }

        public int patrons
        {
            //Precondition: none
            //Postcondition: index for selected patron is returned
            get
            {
                return selectPatronComboBx.SelectedIndex;
            }

            //Precondition: none
            //Postcondition: value is set for the patron
            set
            {
                selectPatronComboBx.SelectedIndex = value;
            }
        }





        //Precondition: none
        //PostCondition: set error if no item is selected
        private void selectItemComboBx_Validating(object sender, CancelEventArgs e)
        {
            if (selectItemComboBx.SelectedIndex == -1)
            {
                e.Cancel = true;
                checkoutError.SetError(selectItemComboBx, "Select Item");

            }
        }
        //Precondition: none
        //PostCondition: set error
        private void selectItemComboBx_Validated(object sender, EventArgs e)
        {
            checkoutError.SetError(selectItemComboBx, "");

        }


        //Precondition: none
        //PostCondition: set error if no patron is selected
        private void selectPatronComboBx_Validating(object sender, CancelEventArgs e)
        {
            if (selectPatronComboBx.SelectedIndex == -1)
            {
                e.Cancel = true;
                checkoutError.SetError(selectPatronComboBx, "Select Patron");

            }

        }

        //Precondition: none
        //PostCondition: set error
        private void selectPatronComboBx_Validated(object sender, EventArgs e)
        {
            checkoutError.SetError(selectPatronComboBx, "");
        }

        //Precondition: validation
        //PostCondition: ok to checkout
        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}

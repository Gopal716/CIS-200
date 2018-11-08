// Description: code view for Return Dialogbox Form. Responsible for validation and Managing return list for items and patrons.

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
    public partial class ReturnForm : Form
    {

        private List<LibraryItem> theItems; // holds library items
       

        // parameterized constructor that accepts items
        public ReturnForm(List<LibraryItem> items)
        {
            InitializeComponent();

            theItems = items;
          
        }

       //Precondition: none
       //Postcondition: checked out items loaded into combo box
            private void ReturnForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem i in theItems)
                if (i.IsCheckedOut())                  // only displays items that have been checked out
                returnItemComboBx.Items.Add(i.Title + ", " + i.CallNumber);

        
        }


       
        public int items
        { 
        //Precondition: none
        //Postcondition: index for selected item is returned
            get
            {
                return returnItemComboBx.SelectedIndex;
            }
            //Precondition: none
            //Postcondition: value is set to the item
            set
            {
                returnItemComboBx.SelectedIndex = value;
            }
        }

      

        //Precondition: none
        //Postcondition: sets error if no item is selected
        private void returnItemComboBx_Validating(object sender, CancelEventArgs e)
        {
            if (returnItemComboBx.SelectedIndex == -1)
            {
                e.Cancel = true;
                returnError.SetError(returnItemComboBx, "Select Item");

            }
        }

        //Precondition: none
        //Postcondition: sets error 
        private void returnItemComboBx_Validated(object sender, EventArgs e)
        {
            returnError.SetError(returnItemComboBx, "");

        }
       
        //Precondition: validation
        //Postcondition: ok to return
        private void returnButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

     
    }
}

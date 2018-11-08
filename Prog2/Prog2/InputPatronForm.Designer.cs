namespace LibraryItems
{
    partial class InputPatronForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.patNameLbl = new System.Windows.Forms.Label();
            this.patIdLbl = new System.Windows.Forms.Label();
            this.patNameTxtBox = new System.Windows.Forms.TextBox();
            this.patIdTxtBox = new System.Windows.Forms.TextBox();
            this.addPatBtn = new System.Windows.Forms.Button();
            this.patInputError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patInputError)).BeginInit();
            this.SuspendLayout();
            // 
            // patNameLbl
            // 
            this.patNameLbl.AutoSize = true;
            this.patNameLbl.Location = new System.Drawing.Point(159, 127);
            this.patNameLbl.Name = "patNameLbl";
            this.patNameLbl.Size = new System.Drawing.Size(189, 32);
            this.patNameLbl.TabIndex = 0;
            this.patNameLbl.Text = "Patron Name:";
            // 
            // patIdLbl
            // 
            this.patIdLbl.AutoSize = true;
            this.patIdLbl.Location = new System.Drawing.Point(207, 182);
            this.patIdLbl.Name = "patIdLbl";
            this.patIdLbl.Size = new System.Drawing.Size(141, 32);
            this.patIdLbl.TabIndex = 1;
            this.patIdLbl.Text = "Patron ID:";
            // 
            // patNameTxtBox
            // 
            this.patNameTxtBox.Location = new System.Drawing.Point(354, 127);
            this.patNameTxtBox.Name = "patNameTxtBox";
            this.patNameTxtBox.Size = new System.Drawing.Size(243, 38);
            this.patNameTxtBox.TabIndex = 2;
            this.patNameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.patNameTxtBox_Validating);
            this.patNameTxtBox.Validated += new System.EventHandler(this.patNameTxtBox_Validated);
            // 
            // patIdTxtBox
            // 
            this.patIdTxtBox.Location = new System.Drawing.Point(354, 182);
            this.patIdTxtBox.Name = "patIdTxtBox";
            this.patIdTxtBox.Size = new System.Drawing.Size(243, 38);
            this.patIdTxtBox.TabIndex = 3;
            this.patIdTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.patIdTxtBox_Validating);
            this.patIdTxtBox.Validated += new System.EventHandler(this.patIdTxtBox_Validated);
            // 
            // addPatBtn
            // 
            this.addPatBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addPatBtn.Location = new System.Drawing.Point(291, 322);
            this.addPatBtn.Name = "addPatBtn";
            this.addPatBtn.Size = new System.Drawing.Size(306, 113);
            this.addPatBtn.TabIndex = 4;
            this.addPatBtn.Text = "Add Patron";
            this.addPatBtn.UseVisualStyleBackColor = true;
            this.addPatBtn.Click += new System.EventHandler(this.addPatBtn_Click);
            // 
            // patInputError
            // 
            this.patInputError.ContainerControl = this;
            // 
            // InputPatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 625);
            this.Controls.Add(this.addPatBtn);
            this.Controls.Add(this.patIdTxtBox);
            this.Controls.Add(this.patNameTxtBox);
            this.Controls.Add(this.patIdLbl);
            this.Controls.Add(this.patNameLbl);
            this.Name = "InputPatronForm";
            this.Text = "InputPatronForm";
            ((System.ComponentModel.ISupportInitialize)(this.patInputError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patNameLbl;
        private System.Windows.Forms.Label patIdLbl;
        private System.Windows.Forms.TextBox patNameTxtBox;
        private System.Windows.Forms.TextBox patIdTxtBox;
        private System.Windows.Forms.Button addPatBtn;
        private System.Windows.Forms.ErrorProvider patInputError;
    }
}
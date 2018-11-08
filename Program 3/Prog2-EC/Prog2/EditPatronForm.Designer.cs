namespace LibraryItems
{
    partial class EditPatronForm
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
            this.selPatronLbl = new System.Windows.Forms.Label();
            this.selectPatronListBox = new System.Windows.Forms.ListBox();
            this.editPatOKBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selPatronLbl
            // 
            this.selPatronLbl.AutoSize = true;
            this.selPatronLbl.Location = new System.Drawing.Point(43, 67);
            this.selPatronLbl.Name = "selPatronLbl";
            this.selPatronLbl.Size = new System.Drawing.Size(194, 32);
            this.selPatronLbl.TabIndex = 0;
            this.selPatronLbl.Text = "Select Patron:";
            // 
            // selectPatronListBox
            // 
            this.selectPatronListBox.FormattingEnabled = true;
            this.selectPatronListBox.ItemHeight = 31;
            this.selectPatronListBox.Location = new System.Drawing.Point(49, 103);
            this.selectPatronListBox.Name = "selectPatronListBox";
            this.selectPatronListBox.Size = new System.Drawing.Size(367, 376);
            this.selectPatronListBox.TabIndex = 1;
            // 
            // editPatOKBtn
            // 
            this.editPatOKBtn.Location = new System.Drawing.Point(49, 514);
            this.editPatOKBtn.Name = "editPatOKBtn";
            this.editPatOKBtn.Size = new System.Drawing.Size(172, 66);
            this.editPatOKBtn.TabIndex = 7;
            this.editPatOKBtn.Text = "OK";
            this.editPatOKBtn.UseVisualStyleBackColor = true;
            this.editPatOKBtn.Click += new System.EventHandler(this.editPatOKBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(247, 514);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(169, 66);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // EditPatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 654);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editPatOKBtn);
            this.Controls.Add(this.selectPatronListBox);
            this.Controls.Add(this.selPatronLbl);
            this.Name = "EditPatronForm";
            this.Text = "EditPatronForm";
            this.Load += new System.EventHandler(this.EditPatronForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selPatronLbl;
        private System.Windows.Forms.ListBox selectPatronListBox;
        private System.Windows.Forms.Button editPatOKBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
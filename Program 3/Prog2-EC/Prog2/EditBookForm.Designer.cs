namespace LibraryItems
{
    partial class EditBookForm
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
            this.selectBookLbl = new System.Windows.Forms.Label();
            this.selectBookListBox = new System.Windows.Forms.ListBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectBookLbl
            // 
            this.selectBookLbl.AutoSize = true;
            this.selectBookLbl.Location = new System.Drawing.Point(72, 53);
            this.selectBookLbl.Name = "selectBookLbl";
            this.selectBookLbl.Size = new System.Drawing.Size(175, 32);
            this.selectBookLbl.TabIndex = 0;
            this.selectBookLbl.Text = "Select Book:";
            // 
            // selectBookListBox
            // 
            this.selectBookListBox.FormattingEnabled = true;
            this.selectBookListBox.ItemHeight = 31;
            this.selectBookListBox.Location = new System.Drawing.Point(78, 101);
            this.selectBookListBox.Name = "selectBookListBox";
            this.selectBookListBox.Size = new System.Drawing.Size(1616, 407);
            this.selectBookListBox.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(78, 547);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(184, 83);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(369, 547);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(191, 83);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1935, 765);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.selectBookListBox);
            this.Controls.Add(this.selectBookLbl);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectBookLbl;
        private System.Windows.Forms.ListBox selectBookListBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
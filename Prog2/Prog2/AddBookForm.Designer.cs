namespace LibraryItems
{
    partial class AddBookForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.copyRtYrLbl = new System.Windows.Forms.Label();
            this.loanPerLbl = new System.Windows.Forms.Label();
            this.callNumLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.titleTxBx = new System.Windows.Forms.TextBox();
            this.publisherTxBx = new System.Windows.Forms.TextBox();
            this.copyRtYrTxBx = new System.Windows.Forms.TextBox();
            this.loanPerTxBx = new System.Windows.Forms.TextBox();
            this.callNumTxBx = new System.Windows.Forms.TextBox();
            this.authorTxBx = new System.Windows.Forms.TextBox();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.bookInputError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookInputError)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(185, 115);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(78, 32);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title:";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(120, 171);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(143, 32);
            this.publisherLbl.TabIndex = 1;
            this.publisherLbl.Text = "Publisher:";
            // 
            // copyRtYrLbl
            // 
            this.copyRtYrLbl.AutoSize = true;
            this.copyRtYrLbl.Location = new System.Drawing.Point(51, 229);
            this.copyRtYrLbl.Name = "copyRtYrLbl";
            this.copyRtYrLbl.Size = new System.Drawing.Size(212, 32);
            this.copyRtYrLbl.TabIndex = 2;
            this.copyRtYrLbl.Text = "Copyright Year:";
            // 
            // loanPerLbl
            // 
            this.loanPerLbl.AutoSize = true;
            this.loanPerLbl.Location = new System.Drawing.Point(86, 285);
            this.loanPerLbl.Name = "loanPerLbl";
            this.loanPerLbl.Size = new System.Drawing.Size(177, 32);
            this.loanPerLbl.TabIndex = 3;
            this.loanPerLbl.Text = "Loan Period:";
            // 
            // callNumLbl
            // 
            this.callNumLbl.AutoSize = true;
            this.callNumLbl.Location = new System.Drawing.Point(83, 340);
            this.callNumLbl.Name = "callNumLbl";
            this.callNumLbl.Size = new System.Drawing.Size(180, 32);
            this.callNumLbl.TabIndex = 4;
            this.callNumLbl.Text = "Call Number:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(156, 394);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(107, 32);
            this.authorLbl.TabIndex = 5;
            this.authorLbl.Text = "Author:";
            // 
            // titleTxBx
            // 
            this.titleTxBx.Location = new System.Drawing.Point(270, 115);
            this.titleTxBx.Name = "titleTxBx";
            this.titleTxBx.Size = new System.Drawing.Size(338, 38);
            this.titleTxBx.TabIndex = 6;
            this.titleTxBx.Validating += new System.ComponentModel.CancelEventHandler(this.titleTxBx_Validating);
            this.titleTxBx.Validated += new System.EventHandler(this.titleTxBx_Validated);
            // 
            // publisherTxBx
            // 
            this.publisherTxBx.Location = new System.Drawing.Point(269, 171);
            this.publisherTxBx.Name = "publisherTxBx";
            this.publisherTxBx.Size = new System.Drawing.Size(338, 38);
            this.publisherTxBx.TabIndex = 7;
            this.publisherTxBx.Validating += new System.ComponentModel.CancelEventHandler(this.publisherTxBx_Validating);
            this.publisherTxBx.Validated += new System.EventHandler(this.publisherTxBx_Validated);
            // 
            // copyRtYrTxBx
            // 
            this.copyRtYrTxBx.Location = new System.Drawing.Point(269, 229);
            this.copyRtYrTxBx.Name = "copyRtYrTxBx";
            this.copyRtYrTxBx.Size = new System.Drawing.Size(338, 38);
            this.copyRtYrTxBx.TabIndex = 8;
            this.copyRtYrTxBx.Validating += new System.ComponentModel.CancelEventHandler(this.copyRtYrTxBx_Validating);
            this.copyRtYrTxBx.Validated += new System.EventHandler(this.copyRtYrTxBx_Validated);
            // 
            // loanPerTxBx
            // 
            this.loanPerTxBx.Location = new System.Drawing.Point(269, 285);
            this.loanPerTxBx.Name = "loanPerTxBx";
            this.loanPerTxBx.Size = new System.Drawing.Size(338, 38);
            this.loanPerTxBx.TabIndex = 9;
            this.loanPerTxBx.Validating += new System.ComponentModel.CancelEventHandler(this.loanPerTxBx_Validating);
            this.loanPerTxBx.Validated += new System.EventHandler(this.loanPerTxBx_Validated);
            // 
            // callNumTxBx
            // 
            this.callNumTxBx.Location = new System.Drawing.Point(269, 340);
            this.callNumTxBx.Name = "callNumTxBx";
            this.callNumTxBx.Size = new System.Drawing.Size(338, 38);
            this.callNumTxBx.TabIndex = 10;
            this.callNumTxBx.Validating += new System.ComponentModel.CancelEventHandler(this.callNumTxBx_Validating);
            this.callNumTxBx.Validated += new System.EventHandler(this.callNumTxBx_Validated);
            // 
            // authorTxBx
            // 
            this.authorTxBx.Location = new System.Drawing.Point(269, 394);
            this.authorTxBx.Name = "authorTxBx";
            this.authorTxBx.Size = new System.Drawing.Size(338, 38);
            this.authorTxBx.TabIndex = 11;
            this.authorTxBx.Validating += new System.ComponentModel.CancelEventHandler(this.authorTxBx_Validating);
            this.authorTxBx.Validated += new System.EventHandler(this.authorTxBx_Validated);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(186, 487);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(421, 92);
            this.addBookBtn.TabIndex = 12;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // bookInputError
            // 
            this.bookInputError.ContainerControl = this;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 745);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.authorTxBx);
            this.Controls.Add(this.callNumTxBx);
            this.Controls.Add(this.loanPerTxBx);
            this.Controls.Add(this.copyRtYrTxBx);
            this.Controls.Add(this.publisherTxBx);
            this.Controls.Add(this.titleTxBx);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.callNumLbl);
            this.Controls.Add(this.loanPerLbl);
            this.Controls.Add(this.copyRtYrLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookInputError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label copyRtYrLbl;
        private System.Windows.Forms.Label loanPerLbl;
        private System.Windows.Forms.Label callNumLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox titleTxBx;
        private System.Windows.Forms.TextBox publisherTxBx;
        private System.Windows.Forms.TextBox copyRtYrTxBx;
        private System.Windows.Forms.TextBox loanPerTxBx;
        private System.Windows.Forms.TextBox callNumTxBx;
        private System.Windows.Forms.TextBox authorTxBx;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.ErrorProvider bookInputError;
    }
}
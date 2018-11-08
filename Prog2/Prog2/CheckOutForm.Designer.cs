namespace LibraryItems
{
    partial class CheckOutForm
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
            this.selectItemLbl = new System.Windows.Forms.Label();
            this.selectPatronLbl = new System.Windows.Forms.Label();
            this.selectItemComboBx = new System.Windows.Forms.ComboBox();
            this.selectPatronComboBx = new System.Windows.Forms.ComboBox();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.checkoutError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkoutError)).BeginInit();
            this.SuspendLayout();
            // 
            // selectItemLbl
            // 
            this.selectItemLbl.AutoSize = true;
            this.selectItemLbl.Location = new System.Drawing.Point(86, 60);
            this.selectItemLbl.Name = "selectItemLbl";
            this.selectItemLbl.Size = new System.Drawing.Size(164, 32);
            this.selectItemLbl.TabIndex = 0;
            this.selectItemLbl.Text = "Select Item:";
            // 
            // selectPatronLbl
            // 
            this.selectPatronLbl.AutoSize = true;
            this.selectPatronLbl.Location = new System.Drawing.Point(92, 266);
            this.selectPatronLbl.Name = "selectPatronLbl";
            this.selectPatronLbl.Size = new System.Drawing.Size(194, 32);
            this.selectPatronLbl.TabIndex = 1;
            this.selectPatronLbl.Text = "Select Patron:";
            // 
            // selectItemComboBx
            // 
            this.selectItemComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectItemComboBx.FormattingEnabled = true;
            this.selectItemComboBx.Location = new System.Drawing.Point(92, 109);
            this.selectItemComboBx.Name = "selectItemComboBx";
            this.selectItemComboBx.Size = new System.Drawing.Size(464, 39);
            this.selectItemComboBx.TabIndex = 2;
            this.selectItemComboBx.Validating += new System.ComponentModel.CancelEventHandler(this.selectItemComboBx_Validating);
            this.selectItemComboBx.Validated += new System.EventHandler(this.selectItemComboBx_Validated);
            // 
            // selectPatronComboBx
            // 
            this.selectPatronComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPatronComboBx.FormattingEnabled = true;
            this.selectPatronComboBx.Location = new System.Drawing.Point(92, 310);
            this.selectPatronComboBx.Name = "selectPatronComboBx";
            this.selectPatronComboBx.Size = new System.Drawing.Size(386, 39);
            this.selectPatronComboBx.TabIndex = 3;
            this.selectPatronComboBx.Validating += new System.ComponentModel.CancelEventHandler(this.selectPatronComboBx_Validating);
            this.selectPatronComboBx.Validated += new System.EventHandler(this.selectPatronComboBx_Validated);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(92, 482);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(369, 58);
            this.checkOutBtn.TabIndex = 4;
            this.checkOutBtn.Text = "CheckOut";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // checkoutError
            // 
            this.checkoutError.ContainerControl = this;
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 704);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.selectPatronComboBx);
            this.Controls.Add(this.selectItemComboBx);
            this.Controls.Add(this.selectPatronLbl);
            this.Controls.Add(this.selectItemLbl);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkoutError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectItemLbl;
        private System.Windows.Forms.Label selectPatronLbl;
        private System.Windows.Forms.ComboBox selectItemComboBx;
        private System.Windows.Forms.ComboBox selectPatronComboBx;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.ErrorProvider checkoutError;
    }
}
namespace LibraryItems
{
    partial class ReturnForm
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
            this.selectReturnItemLabel = new System.Windows.Forms.Label();
            this.returnItemComboBx = new System.Windows.Forms.ComboBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.returnError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.returnError)).BeginInit();
            this.SuspendLayout();
            // 
            // selectReturnItemLabel
            // 
            this.selectReturnItemLabel.AutoSize = true;
            this.selectReturnItemLabel.Location = new System.Drawing.Point(104, 92);
            this.selectReturnItemLabel.Name = "selectReturnItemLabel";
            this.selectReturnItemLabel.Size = new System.Drawing.Size(164, 32);
            this.selectReturnItemLabel.TabIndex = 0;
            this.selectReturnItemLabel.Text = "Select Item:";
            // 
            // returnItemComboBx
            // 
            this.returnItemComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.returnItemComboBx.FormattingEnabled = true;
            this.returnItemComboBx.Location = new System.Drawing.Point(110, 127);
            this.returnItemComboBx.Name = "returnItemComboBx";
            this.returnItemComboBx.Size = new System.Drawing.Size(501, 39);
            this.returnItemComboBx.TabIndex = 2;
            this.returnItemComboBx.Validating += new System.ComponentModel.CancelEventHandler(this.returnItemComboBx_Validating);
            this.returnItemComboBx.Validated += new System.EventHandler(this.returnItemComboBx_Validated);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(222, 410);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(389, 77);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // returnError
            // 
            this.returnError.ContainerControl = this;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 534);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.returnItemComboBx);
            this.Controls.Add(this.selectReturnItemLabel);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectReturnItemLabel;
        private System.Windows.Forms.ComboBox returnItemComboBx;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ErrorProvider returnError;
    }
}
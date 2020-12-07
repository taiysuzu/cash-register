namespace cash_register
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuLabel = new System.Windows.Forms.Label();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.menuLabel2 = new System.Windows.Forms.Label();
            this.fryInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.menuLabel3 = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.blackLineNonLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptLine1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(13, 13);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(95, 13);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Number of Burgers";
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(114, 10);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(36, 20);
            this.burgerInput.TabIndex = 1;
            this.burgerInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuLabel2
            // 
            this.menuLabel2.AutoSize = true;
            this.menuLabel2.Location = new System.Drawing.Point(13, 40);
            this.menuLabel2.Name = "menuLabel2";
            this.menuLabel2.Size = new System.Drawing.Size(81, 13);
            this.menuLabel2.TabIndex = 2;
            this.menuLabel2.Text = "Number of Fries";
            // 
            // fryInput
            // 
            this.fryInput.Location = new System.Drawing.Point(114, 37);
            this.fryInput.Name = "fryInput";
            this.fryInput.Size = new System.Drawing.Size(36, 20);
            this.fryInput.TabIndex = 3;
            this.fryInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(114, 64);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(36, 20);
            this.drinkInput.TabIndex = 4;
            this.drinkInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuLabel3
            // 
            this.menuLabel3.AutoSize = true;
            this.menuLabel3.Location = new System.Drawing.Point(13, 67);
            this.menuLabel3.Name = "menuLabel3";
            this.menuLabel3.Size = new System.Drawing.Size(89, 13);
            this.menuLabel3.TabIndex = 5;
            this.menuLabel3.Text = "Number of Drinks";
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(16, 90);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(134, 23);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Calculate Totals";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Location = new System.Drawing.Point(13, 122);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(55, 23);
            this.subTotalLabel.TabIndex = 7;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.Location = new System.Drawing.Point(13, 148);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(55, 23);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(13, 174);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(55, 23);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total";
            // 
            // blackLineNonLabel
            // 
            this.blackLineNonLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackLineNonLabel.Location = new System.Drawing.Point(16, 198);
            this.blackLineNonLabel.Name = "blackLineNonLabel";
            this.blackLineNonLabel.Size = new System.Drawing.Size(134, 10);
            this.blackLineNonLabel.TabIndex = 13;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Location = new System.Drawing.Point(13, 223);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(95, 23);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(16, 246);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(134, 23);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(16, 278);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(134, 23);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(16, 301);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(134, 23);
            this.printButton.TabIndex = 18;
            this.printButton.Text = "Print Reciept";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(114, 220);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(36, 20);
            this.tenderedInput.TabIndex = 14;
            this.tenderedInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(159, 301);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(231, 23);
            this.newOrderButton.TabIndex = 20;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(159, 10);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(231, 285);
            this.receiptLabel.TabIndex = 21;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receiptLabel.Click += new System.EventHandler(this.ReceiptLabel_Click);
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.Location = new System.Drawing.Point(74, 122);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(76, 23);
            this.subTotalOutput.TabIndex = 22;
            this.subTotalOutput.Text = "$0.00";
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(74, 148);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(76, 23);
            this.taxOutput.TabIndex = 23;
            this.taxOutput.Text = "$0.00";
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(74, 174);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(76, 23);
            this.totalOutput.TabIndex = 24;
            this.totalOutput.Text = "$0.00";
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // changeOutput
            // 
            this.changeOutput.Location = new System.Drawing.Point(74, 278);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(76, 23);
            this.changeOutput.TabIndex = 25;
            this.changeOutput.Text = "$0.00";
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLine1
            // 
            this.receiptLine1.AutoSize = true;
            this.receiptLine1.BackColor = System.Drawing.Color.White;
            this.receiptLine1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLine1.Location = new System.Drawing.Point(174, 51);
            this.receiptLine1.Name = "receiptLine1";
            this.receiptLine1.Size = new System.Drawing.Size(0, 14);
            this.receiptLine1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 343);
            this.Controls.Add(this.receiptLine1);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.blackLineNonLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.menuLabel3);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.fryInput);
            this.Controls.Add(this.menuLabel2);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.menuLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.Label menuLabel2;
        private System.Windows.Forms.TextBox fryInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.Label menuLabel3;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label blackLineNonLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label receiptLine1;
    }
}


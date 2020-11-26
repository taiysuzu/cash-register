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
            this.receiptLine2 = new System.Windows.Forms.Label();
            this.receiptLine3 = new System.Windows.Forms.Label();
            this.receiptLine3Right = new System.Windows.Forms.Label();
            this.receiptLine4Right = new System.Windows.Forms.Label();
            this.receiptLine5Right = new System.Windows.Forms.Label();
            this.receiptLine5 = new System.Windows.Forms.Label();
            this.receiptLine4 = new System.Windows.Forms.Label();
            this.receiptLine6 = new System.Windows.Forms.Label();
            this.receiptLine7 = new System.Windows.Forms.Label();
            this.receiptLine8 = new System.Windows.Forms.Label();
            this.receiptLine10 = new System.Windows.Forms.Label();
            this.receiptLine9 = new System.Windows.Forms.Label();
            this.receiptLine6Right = new System.Windows.Forms.Label();
            this.receiptLine7Right = new System.Windows.Forms.Label();
            this.receiptLine8Right = new System.Windows.Forms.Label();
            this.receiptLine9Right = new System.Windows.Forms.Label();
            this.receiptLine10Right = new System.Windows.Forms.Label();
            this.receiptLine11 = new System.Windows.Forms.Label();
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
            this.newOrderButton.Size = new System.Drawing.Size(180, 23);
            this.newOrderButton.TabIndex = 20;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Location = new System.Drawing.Point(159, 10);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(180, 285);
            this.receiptLabel.TabIndex = 21;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.receiptLine1.Location = new System.Drawing.Point(174, 51);
            this.receiptLine1.Name = "receiptLine1";
            this.receiptLine1.Size = new System.Drawing.Size(0, 13);
            this.receiptLine1.TabIndex = 26;
            // 
            // receiptLine2
            // 
            this.receiptLine2.AutoSize = true;
            this.receiptLine2.BackColor = System.Drawing.Color.White;
            this.receiptLine2.Location = new System.Drawing.Point(174, 64);
            this.receiptLine2.Name = "receiptLine2";
            this.receiptLine2.Size = new System.Drawing.Size(0, 13);
            this.receiptLine2.TabIndex = 27;
            // 
            // receiptLine3
            // 
            this.receiptLine3.AutoSize = true;
            this.receiptLine3.BackColor = System.Drawing.Color.White;
            this.receiptLine3.Location = new System.Drawing.Point(174, 90);
            this.receiptLine3.Name = "receiptLine3";
            this.receiptLine3.Size = new System.Drawing.Size(0, 13);
            this.receiptLine3.TabIndex = 28;
            // 
            // receiptLine3Right
            // 
            this.receiptLine3Right.BackColor = System.Drawing.Color.White;
            this.receiptLine3Right.Location = new System.Drawing.Point(225, 90);
            this.receiptLine3Right.Name = "receiptLine3Right";
            this.receiptLine3Right.Size = new System.Drawing.Size(70, 13);
            this.receiptLine3Right.TabIndex = 31;
            this.receiptLine3Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLine4Right
            // 
            this.receiptLine4Right.BackColor = System.Drawing.Color.White;
            this.receiptLine4Right.Location = new System.Drawing.Point(225, 103);
            this.receiptLine4Right.Name = "receiptLine4Right";
            this.receiptLine4Right.Size = new System.Drawing.Size(70, 13);
            this.receiptLine4Right.TabIndex = 32;
            this.receiptLine4Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLine5Right
            // 
            this.receiptLine5Right.BackColor = System.Drawing.Color.White;
            this.receiptLine5Right.Location = new System.Drawing.Point(225, 116);
            this.receiptLine5Right.Name = "receiptLine5Right";
            this.receiptLine5Right.Size = new System.Drawing.Size(70, 13);
            this.receiptLine5Right.TabIndex = 33;
            this.receiptLine5Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLine5
            // 
            this.receiptLine5.AutoSize = true;
            this.receiptLine5.BackColor = System.Drawing.Color.White;
            this.receiptLine5.Location = new System.Drawing.Point(174, 116);
            this.receiptLine5.Name = "receiptLine5";
            this.receiptLine5.Size = new System.Drawing.Size(0, 13);
            this.receiptLine5.TabIndex = 34;
            // 
            // receiptLine4
            // 
            this.receiptLine4.AutoSize = true;
            this.receiptLine4.BackColor = System.Drawing.Color.White;
            this.receiptLine4.Location = new System.Drawing.Point(174, 103);
            this.receiptLine4.Name = "receiptLine4";
            this.receiptLine4.Size = new System.Drawing.Size(0, 13);
            this.receiptLine4.TabIndex = 35;
            // 
            // receiptLine6
            // 
            this.receiptLine6.AutoSize = true;
            this.receiptLine6.BackColor = System.Drawing.Color.White;
            this.receiptLine6.Location = new System.Drawing.Point(174, 148);
            this.receiptLine6.Name = "receiptLine6";
            this.receiptLine6.Size = new System.Drawing.Size(0, 13);
            this.receiptLine6.TabIndex = 36;
            // 
            // receiptLine7
            // 
            this.receiptLine7.AutoSize = true;
            this.receiptLine7.BackColor = System.Drawing.Color.White;
            this.receiptLine7.Location = new System.Drawing.Point(174, 161);
            this.receiptLine7.Name = "receiptLine7";
            this.receiptLine7.Size = new System.Drawing.Size(0, 13);
            this.receiptLine7.TabIndex = 37;
            // 
            // receiptLine8
            // 
            this.receiptLine8.AutoSize = true;
            this.receiptLine8.BackColor = System.Drawing.Color.White;
            this.receiptLine8.Location = new System.Drawing.Point(174, 174);
            this.receiptLine8.Name = "receiptLine8";
            this.receiptLine8.Size = new System.Drawing.Size(0, 13);
            this.receiptLine8.TabIndex = 38;
            // 
            // receiptLine10
            // 
            this.receiptLine10.AutoSize = true;
            this.receiptLine10.BackColor = System.Drawing.Color.White;
            this.receiptLine10.Location = new System.Drawing.Point(174, 220);
            this.receiptLine10.Name = "receiptLine10";
            this.receiptLine10.Size = new System.Drawing.Size(0, 13);
            this.receiptLine10.TabIndex = 39;
            // 
            // receiptLine9
            // 
            this.receiptLine9.AutoSize = true;
            this.receiptLine9.BackColor = System.Drawing.Color.White;
            this.receiptLine9.Location = new System.Drawing.Point(174, 207);
            this.receiptLine9.Name = "receiptLine9";
            this.receiptLine9.Size = new System.Drawing.Size(0, 13);
            this.receiptLine9.TabIndex = 40;
            // 
            // receiptLine6Right
            // 
            this.receiptLine6Right.BackColor = System.Drawing.Color.White;
            this.receiptLine6Right.Location = new System.Drawing.Point(225, 148);
            this.receiptLine6Right.Name = "receiptLine6Right";
            this.receiptLine6Right.Size = new System.Drawing.Size(70, 13);
            this.receiptLine6Right.TabIndex = 41;
            this.receiptLine6Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLine7Right
            // 
            this.receiptLine7Right.BackColor = System.Drawing.Color.White;
            this.receiptLine7Right.Location = new System.Drawing.Point(225, 161);
            this.receiptLine7Right.Name = "receiptLine7Right";
            this.receiptLine7Right.Size = new System.Drawing.Size(70, 13);
            this.receiptLine7Right.TabIndex = 42;
            this.receiptLine7Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLine8Right
            // 
            this.receiptLine8Right.BackColor = System.Drawing.Color.White;
            this.receiptLine8Right.Location = new System.Drawing.Point(225, 174);
            this.receiptLine8Right.Name = "receiptLine8Right";
            this.receiptLine8Right.Size = new System.Drawing.Size(70, 13);
            this.receiptLine8Right.TabIndex = 43;
            this.receiptLine8Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLine9Right
            // 
            this.receiptLine9Right.BackColor = System.Drawing.Color.White;
            this.receiptLine9Right.Location = new System.Drawing.Point(225, 207);
            this.receiptLine9Right.Name = "receiptLine9Right";
            this.receiptLine9Right.Size = new System.Drawing.Size(70, 13);
            this.receiptLine9Right.TabIndex = 44;
            this.receiptLine9Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLine10Right
            // 
            this.receiptLine10Right.BackColor = System.Drawing.Color.White;
            this.receiptLine10Right.Location = new System.Drawing.Point(225, 220);
            this.receiptLine10Right.Name = "receiptLine10Right";
            this.receiptLine10Right.Size = new System.Drawing.Size(70, 13);
            this.receiptLine10Right.TabIndex = 45;
            this.receiptLine10Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLine11
            // 
            this.receiptLine11.AutoSize = true;
            this.receiptLine11.BackColor = System.Drawing.Color.White;
            this.receiptLine11.Location = new System.Drawing.Point(174, 256);
            this.receiptLine11.Name = "receiptLine11";
            this.receiptLine11.Size = new System.Drawing.Size(0, 13);
            this.receiptLine11.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 343);
            this.Controls.Add(this.receiptLine11);
            this.Controls.Add(this.receiptLine10Right);
            this.Controls.Add(this.receiptLine9Right);
            this.Controls.Add(this.receiptLine8Right);
            this.Controls.Add(this.receiptLine7Right);
            this.Controls.Add(this.receiptLine6Right);
            this.Controls.Add(this.receiptLine9);
            this.Controls.Add(this.receiptLine10);
            this.Controls.Add(this.receiptLine8);
            this.Controls.Add(this.receiptLine7);
            this.Controls.Add(this.receiptLine6);
            this.Controls.Add(this.receiptLine4);
            this.Controls.Add(this.receiptLine5);
            this.Controls.Add(this.receiptLine5Right);
            this.Controls.Add(this.receiptLine4Right);
            this.Controls.Add(this.receiptLine3Right);
            this.Controls.Add(this.receiptLine3);
            this.Controls.Add(this.receiptLine2);
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
        private System.Windows.Forms.Label receiptLine2;
        private System.Windows.Forms.Label receiptLine3;
        private System.Windows.Forms.Label receiptLine3Right;
        private System.Windows.Forms.Label receiptLine4Right;
        private System.Windows.Forms.Label receiptLine5Right;
        private System.Windows.Forms.Label receiptLine5;
        private System.Windows.Forms.Label receiptLine4;
        private System.Windows.Forms.Label receiptLine6;
        private System.Windows.Forms.Label receiptLine7;
        private System.Windows.Forms.Label receiptLine8;
        private System.Windows.Forms.Label receiptLine10;
        private System.Windows.Forms.Label receiptLine9;
        private System.Windows.Forms.Label receiptLine6Right;
        private System.Windows.Forms.Label receiptLine7Right;
        private System.Windows.Forms.Label receiptLine8Right;
        private System.Windows.Forms.Label receiptLine9Right;
        private System.Windows.Forms.Label receiptLine10Right;
        private System.Windows.Forms.Label receiptLine11;
    }
}


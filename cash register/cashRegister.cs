/*Taiyo Suzuki
 * Nov. 26, 2020
 * Cash register program to correctly calculate prices and create a receipt.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace cash_register
{
    public partial class Form1 : Form
    {
        double taxRate = 0.13;//constants
        double burgerPrice = 4.99;
        double fryPrice = 2.25;
        double drinkPrice = 1.50;

        double burgerNum = 0;//variables
        double fryNum = 0;
        double drinkNum = 0;
        double burgerCost = 0;
        double fryCost = 0;
        double drinkCost = 0;
        double cost = 0;
        double taxAmount = 0;
        double totalCost = 0;
        double tendered = 0;
        double change = 0; 

        SoundPlayer printSound = new SoundPlayer(Properties.Resources._16942__cognito_perceptu__receipt_printer);//sound player for receipt sound


        public Form1()
        {
            InitializeComponent();
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                burgerNum = Convert.ToDouble(burgerInput.Text);//grab the number of each item
                fryNum = Convert.ToDouble(fryInput.Text);
                drinkNum = Convert.ToDouble(drinkInput.Text); 

                burgerCost = burgerPrice * burgerNum;// math to calculate prices
                fryCost = fryPrice * fryNum;
                drinkCost = drinkPrice * drinkNum;
                cost = burgerCost + fryCost + drinkCost;
                taxAmount = cost * taxRate;
                totalCost = taxAmount + cost;

                subTotalOutput.Text = $"{cost.ToString("$.00")}";//dollar amount outputs
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalCost.ToString("C")}";
            }
            catch
            {
                receiptLabel.Text = "\nPlease enter real numbers.";//for if people give a bad input
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text); //grab amount tendered
                change = tendered - totalCost;
                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch
            {
                receiptLabel.Text = "\nPlease enter real numbers.";
            }
        }

        private void PrintButton_Click(object sender, EventArgs e) //print receipt
        {
            try
            {
              
                receiptLabel.Text = "\nWelcome to The Burger Joint"; //print text
                printSound.Play();                                  //play print sound
                this.Refresh();                                     //update screen
                Thread.Sleep(800);                                  //wait 1sec

                receiptLine1.Text = "Order 1";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += "\nNovember 25, 2020";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += "\n\nBurgers";
                receiptLine1.Text += $"    x{burgerNum} @ {burgerPrice.ToString("$.00")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += "\nFries";
                receiptLine1.Text += $"      x{fryNum} @ {fryPrice.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += "\nDrinks";
                receiptLine1.Text += $"     x{drinkNum} @ {drinkPrice.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += "\n\nSubtotal";
                receiptLine1.Text += $"        {cost.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += "\nTax";
                receiptLine1.Text += $"             {taxAmount.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += "\nTotal";
                receiptLine1.Text += $"           {totalCost.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += "\n\nTendered";
                receiptLine1.Text += $"        {tendered.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += "\nChange";
                receiptLine1.Text += $"          {change.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine1.Text += $"\n\nHave a Burger-iffic Day!";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

            }
            catch
            {
                receiptLabel.Text = "\nPlease enter real numbers.";
            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            burgerNum = 0;//set all variables to zero
            fryNum = 0;
            drinkNum = 0;
            burgerCost = 0;
            fryCost = 0;
            drinkCost = 0;
            cost = 0;
            taxAmount = 0;
            totalCost = 0;
            tendered = 0;
            change = 0;

            receiptLabel.Text = "";//set all receipt lines blank
            receiptLine1.Text = "";

            subTotalOutput.Text = "$0.00";//reset UI values
            taxOutput.Text = "$0.00";
            totalOutput.Text = "$0.00";
            changeOutput.Text = "$0.00"; 
            burgerInput.Text = "";
            fryInput.Text = "";
            drinkInput.Text = "";
            tenderedInput.Text = ""; 
        }

    }
}

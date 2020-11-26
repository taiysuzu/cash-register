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
        double taxRate = 0.13;
        double burgerPrice = 4.99;
        double fryPrice = 2.25;
        double drinkPrice = 1.50;//constants

        double burgerNum = 0;
        double fryNum = 0;
        double drinkNum = 0;
        double burgerCost = 0;
        double fryCost = 0;
        double drinkCost = 0;
        double cost = 0;
        double taxAmount = 0;
        double totalCost = 0;
        double tendered = 0;
        double change = 0; //variables

        SoundPlayer printSound = new SoundPlayer(Properties.Resources._16942__cognito_perceptu__receipt_printer);//sound player for receipt sound


        public Form1()
        {
            InitializeComponent();
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                burgerNum = Convert.ToDouble(burgerInput.Text);
                fryNum = Convert.ToDouble(fryInput.Text);
                drinkNum = Convert.ToDouble(drinkInput.Text); //grab the number of each item

                burgerCost = burgerPrice * burgerNum;
                fryCost = fryPrice * fryNum;
                drinkCost = drinkPrice * drinkNum;
                cost = burgerCost + fryCost + drinkCost;
                taxAmount = cost * taxRate;
                totalCost = taxAmount + cost;// math to calculate prices

                subTotalOutput.Text = $"{cost.ToString("$.00")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalCost.ToString("C")}";//dollar amount outputs
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

                receiptLine2.Text = "November 25, 2020";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine3.Text = "Burgers";
                receiptLine3Right.Text = $"x{burgerNum} @ {burgerPrice.ToString("$.00")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine4.Text = "Fries";
                receiptLine4Right.Text = $"x{fryNum} @ {fryPrice.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine5.Text = "Drinks";
                receiptLine5Right.Text = $"x{drinkNum} @ {drinkPrice.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine6.Text = "Subtotal";
                receiptLine6Right.Text = $"{cost.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine7.Text = "Tax";
                receiptLine7Right.Text = $"{taxAmount.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine8.Text = "Total";
                receiptLine8Right.Text = $"{totalCost.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine9.Text = "Tendered";
                receiptLine9Right.Text = $"{tendered.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine10.Text = "Change";
                receiptLine10Right.Text = $"{change.ToString("C")}";
                printSound.Play();
                this.Refresh();
                Thread.Sleep(800);

                receiptLine11.Text = "Have a Burger-iffic Day!";
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
            receiptLine2.Text = "";
            receiptLine3.Text = "";
            receiptLine3Right.Text = "";
            receiptLine4.Text = "";
            receiptLine4Right.Text = "";
            receiptLine5.Text = "";
            receiptLine5Right.Text = "";
            receiptLine6.Text = "";
            receiptLine6Right.Text = "";
            receiptLine7.Text = "";
            receiptLine7Right.Text = "";
            receiptLine8.Text = "";
            receiptLine8Right.Text = "";
            receiptLine9.Text = "";
            receiptLine9Right.Text = "";
            receiptLine10.Text = "";
            receiptLine10Right.Text = "";
            receiptLine11.Text = "";

            subTotalOutput.Text = "$0.00";
            taxOutput.Text = "$0.00";
            totalOutput.Text = "$0.00";
            changeOutput.Text = "$0.00"; 
            burgerInput.Text = "";
            fryInput.Text = "";
            drinkInput.Text = "";
            tenderedInput.Text = ""; //reset UI values
        }

    }
}

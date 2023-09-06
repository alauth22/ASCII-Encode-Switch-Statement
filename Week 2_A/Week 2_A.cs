using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_2_A
{
    public partial class frmDecimal_ASCII_Calc : Form
    {
        public frmDecimal_ASCII_Calc()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Declare and initialize the variable that will hold the user's input in txtNumber. 
            int number; 

            //TryParse will check if the value of txtNumber (user input) can be converted to an int. If it can be
            //converted, TryParse will send the int value to the variable number which we initialized in line 23. 
            if (int.TryParse(txtNumber.Text, out number))
            {
                //Line 30 will check if the value of number is within the correct range, ensuring data integrity. 
                if (number >= 65 && number <= 90)
                {
                    //once value of number has been confirmed as an int and within the range, 
                    //same value wil be converted to a string for the switch statement. 
                    string asc_num;
                    asc_num = txtNumber.Text.ToString();

                    //beginning of switch statement to correlate the number with the respective capital letter. 
                    switch (asc_num)
                    {
                        case "65":
                            lblActualAnswer.Text = "A";
                            break;
                        case "66":
                            lblActualAnswer.Text = "B";
                            break;
                        case "67":
                            lblActualAnswer.Text = "C";
                            break;
                        case "68":
                            lblActualAnswer.Text = "D";
                            break;
                        case "69":
                            lblActualAnswer.Text = "E";
                            break;
                        case "70":
                            lblActualAnswer.Text = "F";
                            break;
                        case "71":
                            lblActualAnswer.Text = "G";
                            break;
                        case "72":
                            lblActualAnswer.Text = "H";
                            break;
                        case "73":
                            lblActualAnswer.Text = "I";
                            break;
                        case "74":
                            lblActualAnswer.Text = "J";
                            break;
                        case "75":
                            lblActualAnswer.Text = "K";
                            break;
                        case "76":
                            lblActualAnswer.Text = "L";
                            break;
                        case "77":
                            lblActualAnswer.Text = "M";
                            break;
                        case "78":
                            lblActualAnswer.Text = "N";
                            break;
                        case "79":
                            lblActualAnswer.Text = "O";
                            break;
                        case "80":
                            lblActualAnswer.Text = "P";
                            break;
                        case "81":
                            lblActualAnswer.Text = "Q";
                            break;
                        case "82":
                            lblActualAnswer.Text = "R";
                            break;
                        case "83":
                            lblActualAnswer.Text = "S";
                            break;
                        case "84":
                            lblActualAnswer.Text = "T";
                            break;
                        case "85":
                            lblActualAnswer.Text = "U";
                            break;
                        case "86":
                            lblActualAnswer.Text = "V";
                            break;
                        case "87":
                            lblActualAnswer.Text = "W";
                            break;
                        case "88":
                            lblActualAnswer.Text = "X";
                            break;
                        case "89":
                            lblActualAnswer.Text = "Y";
                            break;
                        case "90":
                            lblActualAnswer.Text = "Z";
                            break;
                    }

                }
                else
                    //Error Message to User if integer is not within the required range. 
                    MessageBox.Show("Please type an integer value that is within the range of 65 - 90.");
                txtNumber.Clear();
                txtNumber.Focus();
            }
            else
                //Error Message to User if invalid data is typed in the textbox on the form. This includes a blank textbox.  
                MessageBox.Show("Please type ONLY an integer value within the range of 65-90. A non-integer value(s), letter(s), " +
                                "or a blank are examples of invalid values.");
            txtNumber.Clear();
            txtNumber.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets both textboxes. 
            txtNumber.Text = "";
            lblActualAnswer.Text = "";
            txtNumber.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the form entirely. 
            this.Close();
        }
    }
}

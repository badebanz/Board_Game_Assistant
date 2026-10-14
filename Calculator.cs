using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Board_Game_Assistant
{
    public partial class Calculator : Form
    {
        public int theme = 1;//creates the theme int, storing which color theme its set to
        public double num3 = 0; //creates our answer number
        public string op = "+"; //creates the operator string and sets it to plus
        public bool numDecide = true; //creates our boolean for deciding which textbox are we editing
       
        public Calculator()
        {
            InitializeComponent();  
        }
        public void SetTheme(int Theme)
        {
            //gets the int theme from the main menu and matches the theme here based on what it is set to.
            if (Theme == 1) 
            {
                BackColor = Color.Empty;
                ForeColor = Color.Empty;
                theme = 1;//sets this forms theme int accordingly
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.Empty;
                }
                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.BackColor = Color.Empty;
                    textbox.ForeColor = Color.Empty;
                }
                lbl_op.BackColor = Color.Empty;
                lbl_heading.ForeColor = Color.Teal;
            }
            else if (Theme == 2)
            {
                BackColor = Color.LightSkyBlue;
                ForeColor = Color.White;
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.LightSkyBlue;
                }
                lbl_op.BackColor = Color.LightSkyBlue;
                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.BackColor = Color.LightSkyBlue;
                    textbox.ForeColor = Color.White;
                }
                lbl_heading.ForeColor = Color.Magenta;
                theme = 2;//sets this forms theme int accordingly
            }
            else if (Theme == 0)
            {
                BackColor = Color.Thistle;
                ForeColor = Color.FromArgb(85, 35, 89);
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.Thistle;
                }
                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.BackColor = Color.Thistle;
                    textbox.ForeColor = Color.FromArgb(85, 35, 89);
                }
                lbl_op.BackColor = Color.Thistle;
                lbl_heading.ForeColor = Color.FromArgb(118, 49, 187);
                theme = 0;//sets this forms theme int accordingly
            }
        
        }
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtbx_num_1.Text);
                double num2 = Convert.ToDouble(txtbx_num_2.Text);
                //attempts to convert the users input into doubles
                if (op == "/" && num2 == 0)
                {
                    MessageBox.Show("Can't Divide By Zero, Please Enter A New Equation");
                }//if the operator is a slash but the second number is a 0 breaks the code as you can't divide by 0 communicates as much to user.
                else
                {
                    if (op == "+") { Add(num1, num2); }//if operator is plus, runs the Add method with the doubles
                    else if (op == "-") { Subtract(num1, num2); }//if operator is minus, runs the Subtract method with the doubles
                    else if (op == "*") { Multiply(num1, num2); }//if operator is an asterisk, runs the Multiply method with the doubles
                    else if (op == "/") { Divide(num1, num2); }//if operator is divide, runs the Divide method with the doubles
                    int listTotal = lst_bx_1.Items.Count;//creates an int and sets it to amount of items in the list
                    if (listTotal == 10)
                    {
                        lst_bx_1.Items.RemoveAt(0);
                        lst_bx_1.Items.Add($"{num1} {op} {num2} = {num3}");
                    }// if its more than 10 than removes the oldest entry before adding the problem
                    else
                    {
                    lst_bx_1.Items.Add($"{num1} {op} {num2} = {num3}");
                    }//if the total number of items in the list is list then 10 adds the problem to the list box

            }
            }
            catch (FormatException) //catches format exceptions when the user inputs something that isn't a number and therefore can't be converted to a double
            {
                MessageBox.Show("Please Only Enter Numbers Then Try Again", "Input Error"); //shows the message box to communicate this to the user
            }

         }

        private void btn_1_Click(object sender, EventArgs e)
        {
            //adds a 1 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "1";//if the textbox text is 0 replaces the 0 with a 1 instead of adding it to the end
                }
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "1";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "1";//if the textbox text is 0 replaces the 0 with a 1 instead of adding it to the end
                }
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "1";
                }
            }
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            //adds a 2 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "2";
                }//if the textbox text is 0 replaces the 0 with a 2 instead of adding it to the end
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "2";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "2";
                }//if the textbox text is 0 replaces the 0 with a 2 instead of adding it to the end
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "3";
                }
            }
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            //adds a 3 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "3";
                }//if the textbox text is 0 replaces the 0 with a 3 instead of adding it to the end
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "3";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "3";
                }//if the textbox text is 0 replaces the 0 with a 3 instead of adding it to the end
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "3";
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //adds a 4 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "4";
                }//if the textbox text is 0 replaces the 0 with a 4 instead of adding it to the end
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "4";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "4";
                }//if the textbox text is 0 replaces the 0 with a 4 instead of adding it to the end
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "4";
                }
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            //adds a 5 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "5";
                }//if the textbox text is 0 replaces the 0 with a 5 instead of adding it to the end
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "5";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "5";
                }//if the textbox text is 0 replaces the 0 with a 5 instead of adding it to the end
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "5";
                }
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            //adds a 6 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "6";
                }//if the textbox text is 0 replaces the 0 with a 6 instead of adding it to the end
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "6";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "6";
                }//if the textbox text is 0 replaces the 0 with a 6 instead of adding it to the end
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "6";
                }
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            //adds a 7 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "7";
                }//if the textbox text is 0 replaces the 0 with a 7 instead of adding it to the end
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "7";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "7";
                }//if the textbox text is 0 replaces the 0 with a 7 instead of adding it to the end
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "7";
                }
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            //adds a 8 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "8";
                }//if the textbox text is 0 replaces the 0 with a 8 instead of adding it to the end
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "8";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "8";
                }//if the textbox text is 0 replaces the 0 with a 8 instead of adding it to the end
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "8";
                }
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            //adds a 9 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "9";
                }//if the textbox text is 0 replaces the 0 with a 9 instead of adding it to the end
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "9";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "9";
                }//if the textbox text is 0 replaces the 0 with a 9 instead of adding it to the end
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "9";
                }
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            //adds a 0 to the end of the text box, which textbox is decided by whether num decide is true or false
            if (numDecide == true)
            {
                if (txtbx_num_1.Text == "0")
                {
                    txtbx_num_1.Text = "0";
                }//if the textbox text is 0 replaces the 0 with a 0 instead of adding it to the end
                else
                {
                    txtbx_num_1.Text = txtbx_num_1.Text + "0";
                }
            }
            else
            {
                if (txtbx_num_2.Text == "0")
                {
                    txtbx_num_2.Text = "0";
                }//if the textbox text is 0 replaces the 0 with a 0 instead of adding it to the end
                else
                {
                    txtbx_num_2.Text = txtbx_num_2.Text + "0";
                }
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            op = "*";
            lbl_op.Text = op;
            numDecide ^= true;
            //sets the operator to multiplication, then changes the label so there is visual confirmation, then sets numDecide to its opposite.

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            op = "+";
            lbl_op.Text = op;
            numDecide ^= true;
            //sets the operator to addition, then changes the label so there is visual confirmation, then sets numDecide to its opposite.
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            op = "-";
            lbl_op.Text = op;
            numDecide ^= true;
            //sets the operator to subtraction, then changes the label so there is visual confirmation, then sets numDecide to its opposite.
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            op = "/";
            lbl_op.Text = op;
            numDecide ^= true;
            //sets the operator to division, then changes the label so there is visual confirmation, then sets numDecide to its opposite.
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            //adds a dot/decimal point to the end of the number 
            if (numDecide == true)
            {
                txtbx_num_1.Text = txtbx_num_1.Text + ".";
            }
            else
            {
                txtbx_num_2.Text = txtbx_num_2.Text + ".";
            }

        }
        private void Add(double num1, double num2)
        {
            num3 = num1 + num2;
            lbl_result.Text = Convert.ToString($"= {Math.Round(num3, 2)}");
            //adds the numbers then updates the result label with the answer
        }
        private void Subtract(double num1, double num2)
        {
            num3 = num1 - num2;
            lbl_result.Text = Convert.ToString($"= {Math.Round(num3, 2)}");
            //subtracts number 1 by number 2 then updates the result label with the answer
        }
        private void Multiply(double num1, double num2)
        {
            num3 = num1 * num2;
            lbl_result.Text = Convert.ToString($"= {Math.Round(num3, 2)}");
            //multiplies the numbers then updates the result label with the answer
        }
        private void Divide(double num1, double num2)
        {
            num3 = num1 / num2;
            lbl_result.Text = Convert.ToString($"= {Math.Round(num3, 2)}");
            //divides number 1 by number 2 then updates the result label with the answer
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbx_num_1.Text = "0";
            txtbx_num_2.Text = "0";
            lbl_result.Text = "= 0";
            op = "+";
            lbl_op.Text = op;
            numDecide = true;
            //clears all the text, sets num decide to true, resets the operator back to addition
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {           
            DialogResult result;
            result = MessageBox.Show("Are You Sure You Want To Exit? You Will Lose Your Saved Answers", "Attempting To Close Form", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            //opens a message box that checks the user means to exit the form, if yes is clicked closes the form otherwise stays on the form
        }

        private void btn_theme_Click(object sender, EventArgs e)
        {
            //checks what number theme is and changes the color theme accordingly, then sets theme to the next number in preperation for the next click.
            if (theme == 0)
            {
                BackColor = Color.Empty;
                ForeColor = Color.Empty;
                theme = 1;
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.Empty;
                }
                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.BackColor = Color.Empty;
                    textbox.ForeColor = Color.Empty;
                }
                lbl_op.BackColor = Color.Empty;
                lbl_heading.ForeColor = Color.Teal;
            }
            else if (theme == 1)
            {
                BackColor = Color.LightSkyBlue;
                ForeColor = Color.White;
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.LightSkyBlue;
                }
                lbl_op.BackColor = Color.LightSkyBlue;
                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.BackColor = Color.LightSkyBlue;
                    textbox.ForeColor = Color.White;
                }
                lbl_heading.ForeColor = Color.Magenta;
                theme = 2;
            }
            else
            {
                BackColor = Color.Thistle;
                ForeColor = Color.FromArgb(85, 35, 89);
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.Thistle;
                }
                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.BackColor = Color.Thistle;
                    textbox.ForeColor = Color.FromArgb(85, 35, 89);
                }
                lbl_op.BackColor = Color.Thistle;
                lbl_heading.ForeColor = Color.FromArgb(118, 49, 187);
                theme = 0;
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("-Enter First Number Using Number Pad." + "\n"+
                "-Then Select You're Operator." + "\n" +
                "-Then Enter Your Second Number Using Number Pad." + "\n" +
                "-Before Then Pressing The Equals Button" + "\n" +
                "-This Should Give You Your Answer" + "\n" +
                "-Press Clear To Clear All Number Slots" + "\n" +
                "-Then Repeat If Necessary, Your Last 10 Answers Are Saved In The List Until You Click Exit" + "\n" +
                "-Theme Button Changes The Theme, Also You Can Edit The Number Manually By Clicking On The Text Box"+ "\n" +
                "-When Finished With Calculator Press Exit To Return To Main Menu", "Help");
        }// when help button clicked opens message box offering this "helpful" information
    }
}


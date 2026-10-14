using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game_Assistant
{
    public partial class DiceForm : Form
    {
        public int sides = 6;//creates the sides int, storing the rngs max
        public int theme = 1;//creates the theme int, storing which color theme its set to
        private int  result;//creates the result int, storing the result of our random number generator
        public DiceForm()
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
                lbl_title.ForeColor = Color.Teal;
            }
            else if (Theme == 2)
            {
                BackColor = Color.LightSkyBlue;
                ForeColor = Color.White;
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.LightSkyBlue;
                }

                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.BackColor = Color.LightSkyBlue;
                    textbox.ForeColor = Color.White;
                }
                lbl_title.ForeColor = Color.Magenta;
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
                lbl_title.ForeColor = Color.FromArgb(118, 49, 187);
                theme = 0;//sets this forms theme int accordingly
            }
            
        }

        private void btn_roll_Click(object sender, EventArgs e)
        {

            try
            {
                sides = Convert.ToInt32(txt_box_num.Text);
                Random rnd = new Random();//creates a new random number generator
                if (sides <= 0)
                {
                    MessageBox.Show("Please Only Enter Positive Whole Numbers ", "Input Error");
                }//if input is negative number outputs message box telling them to only input positive whole numbers 
                else
                {
                    result = rnd.Next(1, sides + 1);

                    if (sides == 2)
                    {
                        CoinFlip(result);
                    }//if the user inputs two runs the coinflip method
                    else if (sides == 6)
                    {
                        DiceRoll(result);
                    }//if the user inputs 6 runs the diceroll method
                    else
                    {
                        lbl_result.Text = Convert.ToString(result);
                        pictureBox1.Image = null;

                    }//converts result to a string then changes the result label to it
                    int listTotal = listBox1.Items.Count;//creates an int and sets it to amount of items in the list
                    if (listTotal == 10)
                    {
                        listBox1.Items.RemoveAt(0);
                        listBox1.Items.Add($" Max: {sides} Result: {result}");
                    }//if the amount of items in the list is more then 10, removes the oldest entry then adds the result of the random number generator
                    else
                    {
                        listBox1.Items.Add($" Max: {sides} Result: {result}");
                    }//if the amount of items in the list is less then 10 adds the result of the random number generator
            }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Only Enter Positive Whole Numbers ", "Input Error");
            }//if unable to convert users text into an int, outputs a message box asking them to only input whole numbers

        }

        private void btn_die_6_Click(object sender, EventArgs e)
        {
            sides = 6;
            txt_box_num.Text =  Convert.ToString(sides);
            //sets sides to 6 and changes the textbox text to 6
        }

        private void btn_die_12_Click(object sender, EventArgs e)
        {
            sides = 12;
            txt_box_num.Text = Convert.ToString(sides);
            //sets sides to 12 and changes the textbox text to 12
        }

        private void btn_coin_flip_Click(object sender, EventArgs e)
        {
            sides = 2;
            txt_box_num.Text = Convert.ToString(sides);
            //sets sides to 2 and changes the textbox text to 2
        }

        private void btn_die_20_Click(object sender, EventArgs e)
        {
            sides = 20;
            txt_box_num.Text = Convert.ToString(sides);
            //sets sides to 20 and changes the textbox text to 20
        }
        private void CoinFlip(int result)
        {
            pictureBox1.Enabled = true;
            if (result == 1)
            {
                pictureBox1.Image = Image.FromFile("coin_flip_heads.gif");
            }
            else { pictureBox1.Image = Image.FromFile("coin_flip_tails.gif"); }
            lbl_result.Text = Convert.ToString(result);
            //changes the picture to a gif displaying the result then changes the label to the result
            LetGifPlay(5000);//lets the gif run for 5 seconds before pausing it


        }
        public async void LetGifPlay(int time)
        {
            await Task.Delay(time);
            pictureBox1.Enabled = false;
            //lets the gif run for a set amount of time before pausing it
        }
        private void DiceRoll(int result)
        {
            pictureBox1.Enabled = true;
            if (result == 1) 
            {
                pictureBox1.Image = Image.FromFile("roll-1.gif");
            }
            else if (result == 2) 
            {
                pictureBox1.Image = Image.FromFile("roll-2.gif");
            }
            else if (result == 3)
            {
                pictureBox1.Image = Image.FromFile("roll-3.gif");
            }
            else if (result == 4)
            {
                pictureBox1.Image = Image.FromFile("roll-4.gif");
            }
            else if (result == 5)
            {
                pictureBox1.Image = Image.FromFile("roll-5.gif");
            }
            else if (result == 6)
            {
                pictureBox1.Image = Image.FromFile("roll-6.gif");
            }
            lbl_result.Text = Convert.ToString(result);
            //changes the picture to a gif displaying the result then changes the label to the result
            LetGifPlay(8500);//lets the gif run for 8.5 seconds before pausing it

        }
       
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are You Sure You Want To Exit? You Will Lose Your Saved Rolls", "Attempting To Close Form", MessageBoxButtons.YesNo);
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
                lbl_title.ForeColor = Color.Teal;

            }
            else if (theme == 1)
            {
                BackColor = Color.LightSkyBlue;
                ForeColor = Color.White;
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.LightSkyBlue;
                }

                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.BackColor = Color.LightSkyBlue;
                    textbox.ForeColor = Color.White;
                }
                lbl_title.ForeColor = Color.Magenta;
                theme = 2;
            }
            else if (theme == 2)
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
                theme = 0;
                lbl_title.ForeColor = Color.FromArgb(118, 49, 187);
            }
            
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("-Either Enter A Number In The Text Box Or Click One Of The 4 Buttons Bellow" + "\n" +
                "-Then Click Roll And Let A Random Number Be Generated Between 1 And Your Number" + "\n" +
                "-If You Do Either A Coin Flip Or A 6-Sided Die Roll A Gif Will Play" + "\n" +
                "-Then Repeat If Necessary, Your Last 10 Rolls/ Random Numbers Are Saved In The List Until You Click Exit" + "\n" +
                "-Theme Button Changes The Theme, Also You Can Edit The Number Manually By Clicking On The Text Box" + "\n" +
                "-When Finished With Dice Roller/ Random Number Generator Press Exit To Return To Main Menu", "Help"
                );// when help button clicked opens message box offering this "helpful" information
        }
    }
}

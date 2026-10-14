using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game_Assistant
{
    public partial class Form1 : Form
    {
        public int theme = 1; //creates the theme int, storing which color theme its set to

        public Form1()
        {
            InitializeComponent();
        }
        private void dice_btn_Click_1(object sender, EventArgs e)
        {
            DiceForm dice = new DiceForm();
            dice.Show();
            //when dice button is clicked opens dice form 
            dice.SetTheme(theme);
            //sends the current theme number to the dice form so it can match its theme to the main menu 
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
                label1.ForeColor = Color.Teal;
            }
            else if(theme == 1)
            { BackColor = Color.LightSkyBlue;
                ForeColor = Color.White;
                foreach(Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.LightSkyBlue;
                }
                label1.ForeColor = Color.Magenta;
                
                theme = 2;
            }
            else {
                BackColor = Color.Thistle;
                ForeColor = Color.FromArgb(85,35,89);
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.Thistle;
                }
                label1.ForeColor = Color.FromArgb(118, 49, 187);

                theme = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Calculator calculator = new Calculator();
            calculator.Show();
            //when calculator button is clicked opens calculator form 
            calculator.SetTheme(theme);
            //sends the current theme number to the calculator form so it can match its theme to the main menu
        }

        private void btn_timer_Click(object sender, EventArgs e)
        {
            
            Timer timer = new Timer();
            timer.Show();
            //when timer button is clicked opens timer form
            timer.SetTheme(theme);
            //sends the current theme number to the timer form so it can match its theme to the main menu
        }
            

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            DialogResult result;
            result = MessageBox.Show("Are You Sure You Want To Exit?", "Attempting To Close Form", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            //opens a message box that checks the user means to end the program, if yes is clicked ends the program otherwise leaves the program running
        }

        private void btn_stpwtch_Click(object sender, EventArgs e)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Show();
            //when stopwatch button is clicked opens stopwatch form
            stopWatch.SetTheme(theme);
            //sends the current theme number to the stopwatch form so it can match its theme to the main menu 

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Press The Dice Button To Open The Dice Form" + "\n"+
                "-Press The Calculator Button To Open The Calculator Form" + "\n"+
                "-Press The Stopwatch Button To Open The Stopwatch Form" + "\n"+
                "-Press The Timer Button To Open The Timer Form" + "\n"+
                "-Theme Button Changes The Theme," + "\n" +
                "-When Finished With The Program Press Exit To Return To Main Menu", "Help");
        }// when help button clicked opens message box offering this "helpful" information
    }
}

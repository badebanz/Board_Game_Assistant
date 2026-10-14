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
    public partial class Timer : Form
    {
        private int theme = 1;//creates the theme int, storing which color theme its set to
        private int total;//creates our total time int, recorded in seconds
        private int min;//creats our min int storing the amount of minutes the user inputs
        private int secs;//creates our secs int storing the amount of seconds the user inputs
        private int stopStart = 0;//creates our int which decide whether the button is set to stop or start
        public Timer()
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

                lbl_title.ForeColor = Color.FromArgb(118, 49, 187);
                theme = 0;//sets this forms theme int accordingly
            }

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (stopStart == 0)
                {
                    min = Convert.ToInt32(txt_box_min.Text);
                    secs = Convert.ToInt32(txt_box_secs.Text);//gets the users input from both text boxes and stores them in their respective ints
                    if(min > 59 || secs > 59 )
                    {
                        MessageBox.Show("Minutes And Seconds Must Be Less Than 60");
                    }//checks if either mins or secs is larger than 60 if so communicate this to user and don't start timer
                    else if(secs < 0 || min < 0)
                    {
                        MessageBox.Show("Both Minutes and Seconds Must Be Equal To Or More Than 0");
                    }//checks if either mins or secs is less than 0 if so communicate this to user and don't start timer
                    else
                    {
                        min *= 60;//times mins by 60 as the total is recorded on seconds
                        total = min + secs;//adds mins and seconds together
                        min /= 60; //divides mins by 60 so we can use it again later
                        timer1.Enabled = true;//starts the timer
                        btn_start.Text = "Stop";//switches button text to stop
                        stopStart = 1;//switches stopStart to 1
                    }
                    
                    
                }
                else if (stopStart == 1)
                {
                    btn_start.Text = "Start";//switches button text to stop
                    timer1.Enabled = false;//stops the timer
                    stopStart = 2;//switches stopStart to 2
                }
                else if (stopStart == 2)
                {
                    btn_start.Text = "Stop";//switches button text to stop
                    timer1.Enabled = true;//starts the timer again
                    stopStart = 1;//switches stopStart to 1
                }
            }
            catch (FormatException) //catches format exceptions when the user inputs something that isn't a whole number and therefore can't be converted to a int
            {
                MessageBox.Show("Please Only Enter Whole Numbers Then Try Again", "Input Error"); //shows the message box to communicate this to the user
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (total == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Timer Over");//if total = to 0 stops timer1, outputs message box to user saying timer is over
            }
            else
            {
                total -= 1;
                UpdateTime();//takes 1 from the total, then runs the update time method
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled =false;//stops the timer
            txt_box_min.Text = "0";
            txt_box_secs.Text = "0";
            lbl_time.Text = "00 : 00";
            stopStart = 0;
            secs = 0;
            min = 0;//resets all the data to 0
        }
        private void UpdateTime()
        { if (secs == 0)
            {
                min -= 1;
                secs = 59;
            }//if secs equals zero minuses one from mins and sets secs to 59
            else { 
                secs -= 1; 
            }//if secs > 0 minuses 1 from secs
            if (min < 10 && secs < 10)
            {
                lbl_time.Text = $"0{min} : 0{secs}";
            }//if both min and secs is under 10 change the label text to time left with 0s infront of both mins and secs
            else if (secs < 10)
            {
                lbl_time.Text = $"{min} : 0{secs}";
            }//if only secs is under 10 change the label text to the time left with a 0 infront of secs
            else if (min < 10)
            {
                lbl_time.Text = $"0{min} : {secs}";
            }//if only min is under 10 change the label text to the time left with a 0 infront of min
            else
            {
                lbl_time.Text = $"{min} : {secs}";
            }//if neither are under 10 change the label text to the time left
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
                lbl_title.ForeColor = Color.Magenta;
                theme = 2;
            }
            else if (theme == 2)
            {
                {
                    BackColor = Color.Thistle;
                    ForeColor = Color.FromArgb(85, 35, 89);
                    foreach (Button button in this.Controls.OfType<Button>())
                    {
                        button.BackColor = Color.Thistle;
                    }

                    lbl_title.ForeColor = Color.FromArgb(118, 49, 187);
                    theme = 0;
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are You Sure You Want To Exit? ", "Attempting To Close Form", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            //opens a message box that checks the user means to exit the form, if yes is clicked closes the form otherwise stays on the form
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Input The Number Of Minutes And Seconds You Want In The Respective Boxes" + "\n" +
                "-When Entered And Ready Press Start To Start The Timer, After A Second The Timer Should Update" + "\n" +
                "-When Wanting To Pause The Timer Press Stop, This Is The Same Button As Start They Switch" + "\n" +
                "-When Wanting To Start A New Timer Press Reset, This Resets Everything To Zero" + "\n" +
                "-A Message Box Will Pop-Up When The Timer Is Done" + "\n" +
                "-Theme Button Changes The Theme," + "\n" +
                "-When Finished With Timer Press Exit To Return To Main Menu", "Help"); 
                // when help button clicked opens message box offering this "helpful" information
        }
    }
}

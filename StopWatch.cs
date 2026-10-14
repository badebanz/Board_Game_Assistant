using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game_Assistant
{
    public partial class StopWatch : Form
    {
        public int theme = 1;//creates the theme int, storing which color theme its set to
        private Stopwatch stopWatch = new Stopwatch();//creates our stopwatch
        public bool startStop = true;//creates our bool which decide whether the button is set to stop or start
        public int totalStops = 0;//creates the int which stores the total amount of stops
        public StopWatch()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = string.Format("{0:mm\\:ss\\:ff}", stopWatch.Elapsed);
            //eerytime the timer ticks (every 10th of a second) updates the label to the stopwacth elapsed time

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (startStop == true)
            {
                btn_start.Text = "Stop";
                stopWatch.Start();
                startStop = false;//if set to true starts the stopwatch, switches the text on the button to swap and sets startStop to false
            }
            else
            {
                btn_start.Text = "Start";
                stopWatch.Stop();
                totalStops += 1;
                startStop = true;//if set to false changes text to start, stops the stopwatchs, adds 1 to the stopwatch counter, and sets startStop to true
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();//resets the stopwatch to 0
            int listTotal = lst_bx_1.Items.Count; //creates an int and sets it to amount of items in the list
            if (listTotal == 10)
            {
                lst_bx_1.Items.RemoveAt(0);
                lst_bx_1.Items.Add($"Total Time: {lbl_time.Text}  Stops : {totalStops}");
            }// if its more than 10 than removes the oldest entry before adding the elapsed time
            else
            {
                lst_bx_1.Items.Add($"Total Time: {lbl_time.Text}  Stops : {totalStops}");
            }//if the total number of items in the list is less then 10 adds the elapsed time to the list box   
        totalStops = 0;//resets totalStops to 0
            startStop = true; //sets startStop to true
            btn_start.Text = "Start";//sets start buttons text back to start
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are You Sure You Want To Exit? You Will Lose Your Saved Times", "Attempting To Close Form", MessageBoxButtons.YesNo);
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

        private void btn_help_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("-Press Start To Start The Stopwatch" + "\n" +
                "-Press Stop To Pause The Timer And Press Start Again To Continue It" + "\n" +
                "-Press Reset To Reset The Timer To 0 So You Can Start It Again" + "\n" +
                "-Up To 10 Times Can Be Saved In The List Box, They Are Saved After You Press Reset" + "\n" +
                "-Theme Button Changes The Theme," + "\n" +
                "-When Finished With StopWatch Press Exit To Return To Main Menu", "Help");
        }// when help button clicked opens message box offering this "helpful" information
    }
}

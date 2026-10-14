namespace Board_Game_Assistant
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
            this.dice_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_theme = new System.Windows.Forms.Button();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_timer = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_stpwtch = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dice_btn
            // 
            this.dice_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice_btn.Location = new System.Drawing.Point(332, 86);
            this.dice_btn.Name = "dice_btn";
            this.dice_btn.Size = new System.Drawing.Size(203, 56);
            this.dice_btn.TabIndex = 0;
            this.dice_btn.Text = "Dice";
            this.dice_btn.UseVisualStyleBackColor = true;
            this.dice_btn.Click += new System.EventHandler(this.dice_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(258, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Board Game Assistant";
            // 
            // btn_theme
            // 
            this.btn_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_theme.Location = new System.Drawing.Point(684, 1);
            this.btn_theme.Name = "btn_theme";
            this.btn_theme.Size = new System.Drawing.Size(115, 37);
            this.btn_theme.TabIndex = 4;
            this.btn_theme.Text = "Theme";
            this.btn_theme.UseVisualStyleBackColor = true;
            this.btn_theme.Click += new System.EventHandler(this.btn_theme_Click);
            // 
            // btn_Calc
            // 
            this.btn_Calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calc.Location = new System.Drawing.Point(332, 174);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(203, 56);
            this.btn_Calc.TabIndex = 5;
            this.btn_Calc.Text = "Calculator";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_timer
            // 
            this.btn_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timer.Location = new System.Drawing.Point(332, 325);
            this.btn_timer.Name = "btn_timer";
            this.btn_timer.Size = new System.Drawing.Size(203, 51);
            this.btn_timer.TabIndex = 6;
            this.btn_timer.Text = "Timer";
            this.btn_timer.UseVisualStyleBackColor = true;
            this.btn_timer.Click += new System.EventHandler(this.btn_timer_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(-1, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 37);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_stpwtch
            // 
            this.btn_stpwtch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stpwtch.Location = new System.Drawing.Point(332, 254);
            this.btn_stpwtch.Name = "btn_stpwtch";
            this.btn_stpwtch.Size = new System.Drawing.Size(203, 47);
            this.btn_stpwtch.TabIndex = 8;
            this.btn_stpwtch.Text = "Stopwatch";
            this.btn_stpwtch.UseVisualStyleBackColor = true;
            this.btn_stpwtch.Click += new System.EventHandler(this.btn_stpwtch_Click);
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(-1, 182);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(86, 40);
            this.btn_help.TabIndex = 28;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_stpwtch);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_timer);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.btn_theme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dice_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dice_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_theme;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_timer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_stpwtch;
        private System.Windows.Forms.Button btn_help;
    }
}


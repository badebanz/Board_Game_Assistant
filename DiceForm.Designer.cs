namespace Board_Game_Assistant
{
    partial class DiceForm
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
            this.btn_roll = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_die_6 = new System.Windows.Forms.Button();
            this.btn_die_12 = new System.Windows.Forms.Button();
            this.btn_coin_flip = new System.Windows.Forms.Button();
            this.txt_box_num = new System.Windows.Forms.TextBox();
            this.btn_die_20 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_theme = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_roll
            // 
            this.btn_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_roll.Location = new System.Drawing.Point(369, 350);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(87, 34);
            this.btn_roll.TabIndex = 0;
            this.btn_roll.Text = "Roll";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(395, 244);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(35, 37);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "0";
            // 
            // btn_die_6
            // 
            this.btn_die_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_die_6.Location = new System.Drawing.Point(295, 402);
            this.btn_die_6.Name = "btn_die_6";
            this.btn_die_6.Size = new System.Drawing.Size(88, 36);
            this.btn_die_6.TabIndex = 2;
            this.btn_die_6.Text = "D6";
            this.btn_die_6.UseVisualStyleBackColor = true;
            this.btn_die_6.Click += new System.EventHandler(this.btn_die_6_Click);
            // 
            // btn_die_12
            // 
            this.btn_die_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_die_12.Location = new System.Drawing.Point(447, 402);
            this.btn_die_12.Name = "btn_die_12";
            this.btn_die_12.Size = new System.Drawing.Size(88, 36);
            this.btn_die_12.TabIndex = 3;
            this.btn_die_12.Text = "D12";
            this.btn_die_12.UseVisualStyleBackColor = true;
            this.btn_die_12.Click += new System.EventHandler(this.btn_die_12_Click);
            // 
            // btn_coin_flip
            // 
            this.btn_coin_flip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_coin_flip.Location = new System.Drawing.Point(146, 402);
            this.btn_coin_flip.Name = "btn_coin_flip";
            this.btn_coin_flip.Size = new System.Drawing.Size(128, 36);
            this.btn_coin_flip.TabIndex = 4;
            this.btn_coin_flip.Text = "CoinFlip";
            this.btn_coin_flip.UseVisualStyleBackColor = true;
            this.btn_coin_flip.Click += new System.EventHandler(this.btn_coin_flip_Click);
            // 
            // txt_box_num
            // 
            this.txt_box_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_num.Location = new System.Drawing.Point(383, 293);
            this.txt_box_num.Name = "txt_box_num";
            this.txt_box_num.Size = new System.Drawing.Size(59, 44);
            this.txt_box_num.TabIndex = 5;
            this.txt_box_num.Text = "6";
            this.txt_box_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_die_20
            // 
            this.btn_die_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_die_20.Location = new System.Drawing.Point(559, 402);
            this.btn_die_20.Name = "btn_die_20";
            this.btn_die_20.Size = new System.Drawing.Size(86, 36);
            this.btn_die_20.TabIndex = 6;
            this.btn_die_20.Text = "D20";
            this.btn_die_20.UseVisualStyleBackColor = true;
            this.btn_die_20.Click += new System.EventHandler(this.btn_die_20_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(321, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(2, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(89, 37);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_theme
            // 
            this.btn_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_theme.Location = new System.Drawing.Point(698, 1);
            this.btn_theme.Name = "btn_theme";
            this.btn_theme.Size = new System.Drawing.Size(101, 37);
            this.btn_theme.TabIndex = 25;
            this.btn_theme.Text = "Theme";
            this.btn_theme.UseVisualStyleBackColor = true;
            this.btn_theme.Click += new System.EventHandler(this.btn_theme_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(636, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 184);
            this.listBox1.TabIndex = 26;
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(1, 183);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(90, 38);
            this.btn_help.TabIndex = 27;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Teal;
            this.lbl_title.Location = new System.Drawing.Point(376, 1);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(80, 37);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "Dice";
            // 
            // DiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_theme);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_die_20);
            this.Controls.Add(this.txt_box_num);
            this.Controls.Add(this.btn_coin_flip);
            this.Controls.Add(this.btn_die_12);
            this.Controls.Add(this.btn_die_6);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_roll);
            this.Name = "DiceForm";
            this.Text = "DiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_die_6;
        private System.Windows.Forms.Button btn_die_12;
        private System.Windows.Forms.Button btn_coin_flip;
        private System.Windows.Forms.TextBox txt_box_num;
        private System.Windows.Forms.Button btn_die_20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_theme;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label lbl_title;
    }
}
namespace TicTacToe1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            player_text = new Label();
            player2_label = new Label();
            one = new Button();
            two = new Button();
            five = new Button();
            four = new Button();
            seven = new Button();
            eight = new Button();
            three = new Button();
            six = new Button();
            nine = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Gray;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(315, 388);
            button1.Name = "button1";
            button1.Size = new Size(196, 71);
            button1.TabIndex = 0;
            button1.Text = "Начать игру";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Start_game;
            // 
            // player_text
            // 
            player_text.AutoSize = true;
            player_text.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player_text.ForeColor = SystemColors.ButtonFace;
            player_text.Location = new Point(21, 9);
            player_text.Name = "player_text";
            player_text.Size = new Size(98, 32);
            player_text.TabIndex = 1;
            player_text.Text = "Player1 0";
            player_text.TextAlign = ContentAlignment.MiddleRight;
            player_text.UseCompatibleTextRendering = true;
            // 
            // player2_label
            // 
            player2_label.AutoSize = true;
            player2_label.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player2_label.ForeColor = SystemColors.ButtonFace;
            player2_label.Location = new Point(730, 9);
            player2_label.Name = "player2_label";
            player2_label.Size = new Size(98, 32);
            player2_label.TabIndex = 2;
            player2_label.Text = "Player2 0";
            player2_label.TextAlign = ContentAlignment.MiddleRight;
            player2_label.UseCompatibleTextRendering = true;
            // 
            // one
            // 
            one.Enabled = false;
            one.FlatStyle = FlatStyle.System;
            one.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            one.Location = new Point(265, 30);
            one.Name = "one";
            one.Size = new Size(102, 102);
            one.TabIndex = 3;
            one.TextAlign = ContentAlignment.BottomCenter;
            one.UseVisualStyleBackColor = true;
            one.Click += one_click;
            // 
            // two
            // 
            two.Enabled = false;
            two.FlatStyle = FlatStyle.System;
            two.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            two.Location = new Point(373, 30);
            two.Name = "two";
            two.Size = new Size(102, 102);
            two.TabIndex = 4;
            two.TextAlign = ContentAlignment.BottomCenter;
            two.UseVisualStyleBackColor = true;
            two.Click += two_click;
            // 
            // five
            // 
            five.Enabled = false;
            five.FlatStyle = FlatStyle.System;
            five.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            five.Location = new Point(373, 138);
            five.Name = "five";
            five.Size = new Size(102, 102);
            five.TabIndex = 5;
            five.TextAlign = ContentAlignment.BottomCenter;
            five.UseVisualStyleBackColor = true;
            five.Click += five_click;
            // 
            // four
            // 
            four.Enabled = false;
            four.FlatStyle = FlatStyle.System;
            four.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            four.Location = new Point(265, 138);
            four.Name = "four";
            four.Size = new Size(102, 102);
            four.TabIndex = 6;
            four.TextAlign = ContentAlignment.BottomCenter;
            four.UseVisualStyleBackColor = true;
            four.Click += four_click;
            // 
            // seven
            // 
            seven.Enabled = false;
            seven.FlatStyle = FlatStyle.System;
            seven.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            seven.Location = new Point(265, 246);
            seven.Name = "seven";
            seven.Size = new Size(102, 102);
            seven.TabIndex = 7;
            seven.TextAlign = ContentAlignment.BottomCenter;
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_click;
            // 
            // eight
            // 
            eight.Enabled = false;
            eight.FlatStyle = FlatStyle.System;
            eight.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            eight.Location = new Point(373, 246);
            eight.Name = "eight";
            eight.Size = new Size(102, 102);
            eight.TabIndex = 8;
            eight.TextAlign = ContentAlignment.BottomCenter;
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_click;
            // 
            // three
            // 
            three.Enabled = false;
            three.FlatStyle = FlatStyle.System;
            three.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            three.Location = new Point(481, 30);
            three.Name = "three";
            three.Size = new Size(102, 102);
            three.TabIndex = 9;
            three.TextAlign = ContentAlignment.BottomCenter;
            three.UseVisualStyleBackColor = true;
            three.Click += three_click;
            // 
            // six
            // 
            six.Enabled = false;
            six.FlatStyle = FlatStyle.System;
            six.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            six.Location = new Point(481, 138);
            six.Name = "six";
            six.Size = new Size(102, 102);
            six.TabIndex = 10;
            six.TextAlign = ContentAlignment.BottomCenter;
            six.UseVisualStyleBackColor = true;
            six.Click += six_click;
            // 
            // nine
            // 
            nine.Enabled = false;
            nine.FlatStyle = FlatStyle.System;
            nine.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nine.Location = new Point(481, 246);
            nine.Name = "nine";
            nine.Size = new Size(102, 102);
            nine.TabIndex = 11;
            nine.TextAlign = ContentAlignment.BottomCenter;
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(53, 146);
            label1.Name = "label1";
            label1.Size = new Size(0, 46);
            label1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 33, 47);
            ClientSize = new Size(865, 507);
            Controls.Add(label1);
            Controls.Add(nine);
            Controls.Add(six);
            Controls.Add(three);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(four);
            Controls.Add(five);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(player2_label);
            Controls.Add(player_text);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label player_text;
        private Label player2_label;
        private Button one;
        private Button two;
        private Button five;
        private Button four;
        private Button seven;
        private Button eight;
        private Button three;
        private Button six;
        private Button nine;
        private Label label1;
    }
}

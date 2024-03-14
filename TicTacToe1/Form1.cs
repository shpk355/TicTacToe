namespace TicTacToe1
{
    public partial class Form1 : Form
    {
        int q;
        int count1 = 0, count2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Start_game(object sender, EventArgs e)
        {
            q = 1;
            one.Enabled = true;
            two.Enabled = true;
            three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            seven.Enabled = true;
            eight.Enabled = true;
            nine.Enabled = true;
            one.Text = "";
            two.Text = "";
            three.Text = "";
            four.Text = "";
            five.Text = "";
            six.Text = "";
            seven.Text = "";
            eight.Text = "";
            nine.Text = "";
            label1.Text = "";
        }
        private void two_click(object sender, EventArgs e)
        {
            if (q % 2 == 0)
            {
                two.Text = "O";
                if(one.Text==three.Text && three.Text == "O"){
                    Gameover(false);
                }
                if (five.Text == eight.Text && eight.Text == "O")
                {
                    Gameover(false);
                }
            }
            else
            {
                two.Text = "X";
                if (one.Text == three.Text && three.Text == "X")
                {
                    Gameover(true);
                }
                if(five.Text == eight.Text && eight.Text == "X")
                {
                    Gameover(true);
                }
            }

            two.Enabled = false;
            q++;
            if (q == 10)
            {
                Draw();
            }
        }

        private void one_click(object sender, EventArgs e)
        {
            if (q % 2 == 0)
            {
                one.Text = "O";
                one.ForeColor = Color.Blue;
                if (two.Text == three.Text && three.Text == "O")
                {
                    Gameover(false);
                }
                if (five.Text == nine.Text && nine.Text == "O")
                {
                    Gameover(false);
                }
                if (seven.Text == seven.Text && seven.Text == "O")
                {
                    Gameover(false);
                }
            }
            else
            {
                one.Text = "X";
                one.ForeColor = Color.Red;
                if (two.Text == three.Text && three.Text == "X")
                {
                    Gameover(true);
                }
                if (five.Text == nine.Text && nine.Text == "X")
                {
                    Gameover(true);
                }
                if (seven.Text == seven.Text && seven.Text == "X")
                {
                    Gameover(true);
                }
            }
            one.Enabled = false;
            q++;
            if (q == 10)
            {
                Draw();
            }
        }

        private void three_click(object sender, EventArgs e)
        {
            if (q % 2 == 0)
            {
                three.Text = "O";
                three.ForeColor = Color.Blue;
                if (two.Text == one.Text && two.Text == "O")
                {
                    Gameover(false);
                }
                if (five.Text == seven.Text && seven.Text == "O")
                {
                    Gameover(false);
                }
                if (six.Text == nine.Text && nine.Text == "O")
                {
                    Gameover(false);
                }
            }
            else
            {
                three.Text = "X";
                three.ForeColor = Color.Red;
                if (two.Text == one.Text && two.Text == "X")
                {
                    Gameover(true);
                }
                if (five.Text == seven.Text && seven.Text == "X")
                {
                    Gameover(true);
                }
                if (six.Text == nine.Text && nine.Text == "X")
                {
                    Gameover(true);
                }
            }
            three.Enabled = false;
            q++;
            if (q == 10)
            {
                Draw();
            }
        }

        private void four_click(object sender, EventArgs e)
        {
            if (q % 2 == 0)
            {
                four.Text = "O";
                four.ForeColor = Color.Blue;
                if (seven.Text == one.Text && one.Text == "O")
                {
                    Gameover(false);
                }
                if (five.Text == six.Text && six.Text == "O")
                {
                    Gameover(false);
                }
            }
            else
            {
                four.Text = "X";
                four.ForeColor = Color.Red;
                if (seven.Text == one.Text && one.Text == "X")
                {
                    Gameover(true);
                }
                if (five.Text == six.Text && six.Text == "X")
                {
                    Gameover(true);
                }
            }
            four.Enabled = false;
            q++;
            if (q == 10)
            {
                Draw();
            }
        }

        private void five_click(object sender, EventArgs e)
        {
            if (q % 2 == 0)
            {
                five.Text = "O";
                five.ForeColor = Color.Blue;
                if (nine.Text == one.Text && nine.Text == "O")
                {
                    Gameover(false);
                }
                if (two.Text == eight.Text && eight.Text == "O")
                {
                    Gameover(false);
                }
                if (six.Text == four.Text && four.Text == "O")
                {
                    Gameover(false);
                }
                if (three.Text == seven.Text && seven.Text == "O")
                {
                    Gameover(false);
                }
            }
            else
            {
                five.Text = "X";
                five.ForeColor = Color.Red;
                if (nine.Text == one.Text && nine.Text == "X")
                {
                    Gameover(true);
                }
                if (two.Text == eight.Text && eight.Text == "X")
                {
                    Gameover(true);
                }
                if (six.Text == four.Text && four.Text == "X")
                {
                    Gameover(true);
                }
                if (three.Text == seven.Text && seven.Text == "X")
                {
                    Gameover(true);
                }
            }
            five.Enabled = false;
            q++;
            if (q == 10)
            {
                Draw();
            }
        }

        private void six_click(object sender, EventArgs e)
        {
            if (q % 2 == 0)
            {
                six.Text = "O";
                six.ForeColor = Color.Blue;
                if (nine.Text == three.Text && three.Text == "O")
                {
                    Gameover(false);
                }
                if (five.Text == four.Text && four.Text == "O")
                {
                    Gameover(false);
                }
            }
            else
            {
                six.Text = "X";
                six.ForeColor = Color.Red;
                if (nine.Text == three.Text && three.Text == "X")
                {
                    Gameover(true);
                }
                if (five.Text == four.Text && four.Text == "X")
                {
                    Gameover(true);
                }
            }
            six.Enabled = false;
            q++;
            if (q == 10)
            {
                Draw();
            }
        }

        private void seven_click(object sender, EventArgs e)
        {
            if (q % 2 == 0)
            {
                seven.Text = "O";
                seven.ForeColor = Color.Blue;
                if (five.Text == three.Text && three.Text == "O")
                {
                    Gameover(false);
                }
                if (eight.Text == nine.Text && nine.Text == "O")
                {
                    Gameover(false);
                }
                if (one.Text == four.Text && four.Text == "O")
                {
                    Gameover(false);
                }
            }
            else
            {
                seven.Text = "X";
                seven.ForeColor = Color.Red;
                if (five.Text == three.Text && three.Text == "X")
                {
                    Gameover(true);
                }
                if (eight.Text == nine.Text && nine.Text == "X")
                {
                    Gameover(true);
                }
                if (one.Text == four.Text && four.Text == "X")
                {
                    Gameover(true);
                }
            }
            seven.Enabled = false;
            q++;
            if (q == 10)
            {
                Draw();
            }
        }

        private void eight_click(object sender, EventArgs e)
        {
            if (q % 2 == 0)
            {
                eight.Text = "O";
                eight.ForeColor = Color.Blue;
                if (seven.Text == nine.Text && nine.Text == "O")
                {
                    Gameover(false);
                }
                if (two.Text == five.Text && two.Text == "O")
                {
                    Gameover(false);
                }
            }
            else
            {
                eight.Text = "X";
                eight.ForeColor = Color.Red;
                if (seven.Text == nine.Text && nine.Text == "X")
                {
                    Gameover(true);
                }
                if (two.Text == five.Text && two.Text == "X")
                {
                    Gameover(true);
                }
            }
            eight.Enabled = false;
            q++;
            if (q == 10)
            {
                Draw();
            }
        }

        private void nine_click(object sender, EventArgs e)
        {
            if (q % 2 == 0)
            {
                nine.Text = "O";
                nine.ForeColor = Color.Blue;
                if (one.Text == five.Text && five.Text == "O")
                {
                    Gameover(false);
                }
                if (three.Text == six.Text && three.Text == "O")
                {
                    Gameover(false);
                }
                if (seven.Text == eight.Text && seven.Text == "O")
                {
                    Gameover(false);
                }

            }
            else
            {
                nine.Text = "X";
                nine.ForeColor = Color.Red;
                if (one.Text == five.Text && five.Text == "X")
                {
                    Gameover(true);
                }
                if (three.Text == six.Text && three.Text == "X")
                {
                    Gameover(true);
                }
                if (seven.Text == eight.Text && seven.Text == "X")
                {
                    Gameover(true);
                }
            }
            nine.Enabled = false;
            q++;
            if (q == 10)
            {
                Draw();
            }
        }
        private void Draw()
        {
            label1.Text = "Draw";

            one.Enabled = false;
            two.Enabled = false;
            three.Enabled = false;
            four.Enabled = false;
            five.Enabled = false;
            six.Enabled = false;
            seven.Enabled = false;
            eight.Enabled = false;
            nine.Enabled = false;
        }
        private void Gameover(bool player)
        {
            if (player)
            {
                label1.Text = "Player2 Ëîõ";
                count1++;
                player_text.Text = "Player1 " + count1;
            }
            else
            {
                label1.Text = "Player1 Ëîõ";
                count2++;
                player2_label.Text = "Player2 " + count2;
            }

            one.Enabled = false;
            two.Enabled = false;
            three.Enabled = false;
            four.Enabled = false;
            five.Enabled = false;
            six.Enabled = false;
            seven.Enabled = false;
            eight.Enabled = false;
            nine.Enabled = false;
        }
    }
}

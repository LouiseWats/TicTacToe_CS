using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe_CS
{
    public partial class Form1 : Form
    {
        Boolean Checker;
        int PlusOne;

        void EnabledFalse()
        {
            TicTacBtn1.Enabled = false;
            TicTacBtn2.Enabled = false;
            TicTacBtn3.Enabled = false;
            TicTacBtn4.Enabled = false;
            TicTacBtn5.Enabled = false;
            TicTacBtn6.Enabled = false;
            TicTacBtn7.Enabled = false;
            TicTacBtn8.Enabled = false;
            TicTacBtn9.Enabled = false;
        }

        void Score()
        {
            /******************************************* Player X ******************************************/

            if (TicTacBtn1.Text == "X" && TicTacBtn2.Text == "X" && TicTacBtn3.Text == "X")
            {
                TicTacBtn1.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn2.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn3.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player X");
                PlusOne = int.Parse(playerX.Text);
                playerX.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn1.Text == "X" && TicTacBtn4.Text == "X" && TicTacBtn7.Text == "X")
            {
                TicTacBtn1.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn4.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn7.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player X");
                PlusOne = int.Parse(playerX.Text);
                playerX.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn1.Text == "X" && TicTacBtn5.Text == "X" && TicTacBtn9.Text == "X")
            {
                TicTacBtn1.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn5.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn9.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player X");
                PlusOne = int.Parse(playerX.Text);
                playerX.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn3.Text == "X" && TicTacBtn5.Text == "X" && TicTacBtn7.Text == "X")
            {
                TicTacBtn3.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn5.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn7.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player X");
                PlusOne = int.Parse(playerX.Text);
                playerX.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn3.Text == "X" && TicTacBtn6.Text == "X" && TicTacBtn9.Text == "X")
            {
                TicTacBtn3.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn6.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn9.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player X");
                PlusOne = int.Parse(playerX.Text);
                playerX.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn2.Text == "X" && TicTacBtn5.Text == "X" && TicTacBtn8.Text == "X")
            {
                TicTacBtn2.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn5.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn8.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player X");
                PlusOne = int.Parse(playerX.Text);
                playerX.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn4.Text == "X" && TicTacBtn5.Text == "X" && TicTacBtn6.Text == "X")
            {
                TicTacBtn4.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn5.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn6.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player X");
                PlusOne = int.Parse(playerX.Text);
                playerX.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn7.Text == "X" && TicTacBtn8.Text == "X" && TicTacBtn9.Text == "X")
            {
                TicTacBtn7.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn8.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn9.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player X");
                PlusOne = int.Parse(playerX.Text);
                playerX.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }


            /******************************************* Player O ******************************************/

            if (TicTacBtn1.Text == "O" && TicTacBtn2.Text == "O" && TicTacBtn3.Text == "O")
            {
                TicTacBtn1.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn2.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn3.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player O");
                PlusOne = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn1.Text == "O" && TicTacBtn4.Text == "O" && TicTacBtn7.Text == "O")
            {
                TicTacBtn1.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn4.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn7.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player O");
                PlusOne = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn1.Text == "O" && TicTacBtn5.Text == "O" && TicTacBtn9.Text == "O")
            {
                TicTacBtn1.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn5.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn9.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player O");
                PlusOne = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn3.Text == "O" && TicTacBtn5.Text == "O" && TicTacBtn7.Text == "O")
            {
                TicTacBtn3.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn5.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn7.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player O");
                PlusOne = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn3.Text == "O" && TicTacBtn6.Text == "O" && TicTacBtn9.Text == "O")
            {
                TicTacBtn3.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn6.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn9.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player O");
                PlusOne = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn2.Text == "O" && TicTacBtn5.Text == "O" && TicTacBtn8.Text == "O")
            {
                TicTacBtn2.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn5.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn8.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player O");
                PlusOne = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn4.Text == "O" && TicTacBtn5.Text == "O" && TicTacBtn6.Text == "O")
            {
                TicTacBtn4.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn5.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn6.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player O");
                PlusOne = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

            if (TicTacBtn7.Text == "O" && TicTacBtn8.Text == "O" && TicTacBtn9.Text == "O")
            {
                TicTacBtn7.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn8.BackColor = System.Drawing.Color.RosyBrown;
                TicTacBtn9.BackColor = System.Drawing.Color.RosyBrown;

                MessageBox.Show("The winner is player O");
                PlusOne = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(PlusOne + 1);
                EnabledFalse();
            }

        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TicTacBtn1_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                TicTacBtn1.Text = "X";
                Checker = true;
            } 
            else
            {
                TicTacBtn1.Text = "O";
                Checker = false;
            }
            Score();
            TicTacBtn1.Enabled = false;
        }

        private void TicTacBtn2_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                TicTacBtn2.Text = "X";
                Checker = true;
            }
            else
            {
                TicTacBtn2.Text = "O";
                Checker = false;
            }
            Score();
            TicTacBtn2.Enabled = false;
        }

        private void TicTacBtn3_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                TicTacBtn3.Text = "X";
                Checker = true;
            }
            else
            {
                TicTacBtn3.Text = "O";
                Checker = false;
            }
            Score();
            TicTacBtn3.Enabled = false;
        }

        private void TicTacBtn4_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                TicTacBtn4.Text = "X";
                Checker = true;
            }
            else
            {
                TicTacBtn4.Text = "O";
                Checker = false;
            }
            Score();
            TicTacBtn4.Enabled = false;
        }

        private void TicTacBtn5_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                TicTacBtn5.Text = "X";
                Checker = true;
            }
            else
            {
                TicTacBtn5.Text = "O";
                Checker = false;
            }
            Score();
            TicTacBtn5.Enabled = false;
        }

        private void TicTacBtn6_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                TicTacBtn6.Text = "X";
                Checker = true;
            }
            else
            {
                TicTacBtn6.Text = "O";
                Checker = false;
            }
            Score();
            TicTacBtn6.Enabled = false;
        }

        private void TicTacBtn7_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                TicTacBtn7.Text = "X";
                Checker = true;
            }
            else
            {
                TicTacBtn7.Text = "O";
                Checker = false;
            }
            Score();
            TicTacBtn7.Enabled = false;
        }

        private void TicTacBtn8_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                TicTacBtn8.Text = "X";
                Checker = true;
            }
            else
            {
                TicTacBtn8.Text = "O";
                Checker = false;
            }
            Score();
            TicTacBtn8.Enabled = false;
        }

        private void TicTacBtn9_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                TicTacBtn9.Text = "X";
                Checker = true;
            }
            else
            {
                TicTacBtn9.Text = "O";
                Checker = false;
            }
            Score();
            TicTacBtn9.Enabled = false;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            TicTacBtn1.Enabled = true;
            TicTacBtn2.Enabled = true;
            TicTacBtn3.Enabled = true;
            TicTacBtn4.Enabled = true;
            TicTacBtn5.Enabled = true;
            TicTacBtn6.Enabled = true;
            TicTacBtn7.Enabled = true;
            TicTacBtn8.Enabled = true;
            TicTacBtn9.Enabled = true;

            TicTacBtn1.Text = "";
            TicTacBtn2.Text = "";
            TicTacBtn3.Text = "";
            TicTacBtn4.Text = "";
            TicTacBtn5.Text = "";
            TicTacBtn6.Text = "";
            TicTacBtn7.Text = "";
            TicTacBtn8.Text = "";
            TicTacBtn9.Text = "";

            playerX.Text = "0";
            playerO.Text = "0";


            TicTacBtn1.BackColor = Color.WhiteSmoke;
            TicTacBtn2.BackColor = Color.WhiteSmoke;
            TicTacBtn3.BackColor = Color.WhiteSmoke;
            TicTacBtn4.BackColor = Color.WhiteSmoke;
            TicTacBtn5.BackColor = Color.WhiteSmoke;
            TicTacBtn6.BackColor = Color.WhiteSmoke;
            TicTacBtn7.BackColor = Color.WhiteSmoke;
            TicTacBtn8.BackColor = Color.WhiteSmoke;
            TicTacBtn9.BackColor = Color.WhiteSmoke;


        }

        private void Reset_Click(object sender, EventArgs e)
        {
            TicTacBtn1.Enabled = true;
            TicTacBtn2.Enabled = true;
            TicTacBtn3.Enabled = true;
            TicTacBtn4.Enabled = true;
            TicTacBtn5.Enabled = true;
            TicTacBtn6.Enabled = true;
            TicTacBtn7.Enabled = true;
            TicTacBtn8.Enabled = true;
            TicTacBtn9.Enabled = true;

            TicTacBtn1.Text = "";
            TicTacBtn2.Text = "";
            TicTacBtn3.Text = "";
            TicTacBtn4.Text = "";
            TicTacBtn5.Text = "";
            TicTacBtn6.Text = "";
            TicTacBtn7.Text = "";
            TicTacBtn8.Text = "";
            TicTacBtn9.Text = "";


            TicTacBtn1.BackColor = Color.WhiteSmoke;
            TicTacBtn2.BackColor = Color.WhiteSmoke;
            TicTacBtn3.BackColor = Color.WhiteSmoke;
            TicTacBtn4.BackColor = Color.WhiteSmoke;
            TicTacBtn5.BackColor = Color.WhiteSmoke;
            TicTacBtn6.BackColor = Color.WhiteSmoke;
            TicTacBtn7.BackColor = Color.WhiteSmoke;
            TicTacBtn8.BackColor = Color.WhiteSmoke;
            TicTacBtn9.BackColor = Color.WhiteSmoke;

            NewGame.Enabled = true;


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

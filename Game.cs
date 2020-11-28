using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Nov2020
{
    public partial class Game : Form
    {
        private string turn = "X";
        private int turnCounter = 0;
        private bool gameOver = false;

        public Game()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            
            var picture = (PictureBox)sender;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            
            if((string)picture.Tag == "X" || (string)picture.Tag == "O")
            {
                return;
            }

            if (turn == "X")
            {
                picture.Image = Properties.Resources.x;
                picture.Tag = turn;
                turnCounter += 1;
                CheckWinner();
                turn = "O";
            }
            else
            {
                picture.Image = Properties.Resources.o;
                picture.Tag = turn;
                turnCounter += 1;
                CheckWinner();
                turn = "X";
            }
        }

        private void CheckWinner()
        {
            if (pictureBox1.Tag == pictureBox2.Tag && pictureBox2.Tag == pictureBox3.Tag && pictureBox1.Tag != null)
            {
                HighlightCells(pictureBox1, pictureBox2, pictureBox3);
                GameOver("win");
            }
            else if (pictureBox4.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox6.Tag && pictureBox5.Tag != null)
            {
                HighlightCells(pictureBox4, pictureBox5, pictureBox6);
                GameOver("win");
            }
            else if (pictureBox7.Tag == pictureBox8.Tag && pictureBox8.Tag == pictureBox9.Tag && pictureBox8.Tag != null)
            {
                HighlightCells(pictureBox7, pictureBox8, pictureBox9);
                GameOver("win");
            }
            else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox4.Tag == pictureBox7.Tag && pictureBox4.Tag != null)
            {
                HighlightCells(pictureBox1, pictureBox4, pictureBox7);
                GameOver("win");
            }
            else if (pictureBox2.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox8.Tag && pictureBox5.Tag != null)
            {
                HighlightCells(pictureBox2, pictureBox5, pictureBox8);
                GameOver("win");
            }
            else if (pictureBox3.Tag == pictureBox6.Tag && pictureBox6.Tag == pictureBox9.Tag && pictureBox6.Tag != null)
            {
                HighlightCells(pictureBox3, pictureBox6, pictureBox9);
                GameOver("win");
            }
            else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox9.Tag && pictureBox5.Tag != null)
            {
                HighlightCells(pictureBox1, pictureBox5, pictureBox9);
                GameOver("win");
            }
            else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox7.Tag && pictureBox3.Tag != null)
            {
                HighlightCells(pictureBox3, pictureBox5, pictureBox7);
                GameOver("win");
            }
            else if (turnCounter > 8)
            {
                GameOver("tie");
            }
        }

        private void GameOver(string endType)
        {
            if(endType == "win")
            {
                MessageBox.Show("The winner is " + turn);
            }
            else if (endType == "tie")
            {
                MessageBox.Show("No one wins, it is a tie");
            }           
            
            buttonReset.Visible = true;
            gameOver = true;
        }

        private void HighlightCells(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            pb1.BackColor = pb2.BackColor = pb3.BackColor = Color.Blue;
        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            PictureBox picture;
            for (int counter = 1; counter < 10; counter += 1)
            {
                picture = (PictureBox)Grid.Controls["pictureBox" + counter];
                picture.Image = null;
                picture.Tag = null;
                picture.BackColor = Color.Transparent;
                picture.Enabled = true;
            }
            turnCounter = 0;
            gameOver = false;
            buttonReset.Visible = false;
        }
    }
}

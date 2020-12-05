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
        private string turn = "x";
        private int turnCount = 0;

        public Game()
        {
            InitializeComponent();
            ChangeCellColors();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var picture = (PictureBox)sender;

            if((string)picture.Tag == "x" || (string)picture.Tag == "o")
            {
                return;
            }

            if (turn == "x")
            {
                picture.Image = Properties.Resources.x;
                picture.Tag = "x";
                turnCount += 1;
                CheckForWinner();
                turn = "o";
            }
            else
            {
                picture.Image = Properties.Resources.o;
                picture.Tag = "o";
                turnCount += 1;
                CheckForWinner();
                turn = "x";
            }            
        }

        private void ChangeCellColors()
        {
            foreach(var something in Grid.Controls)
            {
                PictureBox picture = (PictureBox)something;
                picture.BackColor = Color.LightSteelBlue;
            }
        }

        private void CheckForWinner()
        {
            if (pictureBox1.Tag == pictureBox2.Tag && pictureBox2.Tag == pictureBox3.Tag && pictureBox1.Tag != null)
            {
                ChangeCellColor(pictureBox1, pictureBox2, pictureBox3);
                GameOver("win");
            }
            else if (pictureBox4.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox6.Tag && pictureBox4.Tag != null)
            {
                ChangeCellColor(pictureBox4, pictureBox5, pictureBox6);
                GameOver("win");
            }
            else if (pictureBox7.Tag == pictureBox8.Tag && pictureBox8.Tag == pictureBox9.Tag && pictureBox7.Tag != null)
            {
                ChangeCellColor(pictureBox7, pictureBox8, pictureBox9);
                GameOver("win");
            }
            else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox4.Tag == pictureBox7.Tag && pictureBox1.Tag != null)
            {
                ChangeCellColor(pictureBox1, pictureBox4, pictureBox7);
                GameOver("win");
            }
            else if (pictureBox2.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox8.Tag && pictureBox2.Tag != null)
            {
                ChangeCellColor(pictureBox2, pictureBox5, pictureBox8);
                GameOver("win");
            }
            else if (pictureBox3.Tag == pictureBox6.Tag && pictureBox6.Tag == pictureBox9.Tag && pictureBox3.Tag != null)
            {
                ChangeCellColor(pictureBox3, pictureBox6, pictureBox9);
                GameOver("win");
            }
            else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox9.Tag && pictureBox1.Tag != null)
            {
                ChangeCellColor(pictureBox1, pictureBox5, pictureBox9);
                GameOver("win");
            }
            else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox7.Tag && pictureBox3.Tag != null)
            {
                ChangeCellColor(pictureBox3, pictureBox5, pictureBox7);
                GameOver("win");
            }
            else if (turnCount == 9)
            {
                GameOver("tie");
            }
        }

        private void ChangeCellColor(PictureBox p1, PictureBox p2, PictureBox p3)
        {
            p1.BackColor = Color.LightSalmon;
            p2.BackColor = Color.LightSalmon;
            p3.BackColor = Color.LightSalmon;
        }

        private void GameOver(string gameState)
        {
            if(gameState == "win")
            {
                MessageBox.Show(turn + " wins!");
            }
            else if(gameState == "tie")
            {
                MessageBox.Show("It is a tie, no one wins");
            }
            
            buttonReset.Visible = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            PictureBox picture;
            for(int i = 1; i < 10; i++)
            {
                picture = (PictureBox)Grid.Controls["pictureBox" + i];
                picture.BackColor = Color.LightSteelBlue;
                picture.Tag = null;
                picture.Image = null;
            }
            
            foreach (var item in Grid.Controls)
            {
                picture = (PictureBox)item;
                picture.BackColor = Color.LightSteelBlue;
                picture.Tag = null;
                picture.Image = null;
            }
            turnCount = 0;
            buttonReset.Visible = false;
        }
    }
}

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
    public partial class Form1 : Form
    {
        private string turn = "X";

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
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
                CheckWinner();
                turn = "O";
            }
            else
            {
                picture.Image = Properties.Resources.o;
                picture.Tag = turn;
                CheckWinner();
                turn = "X";
            }
        }

        private void CheckWinner()
        {
            if(pictureBox1.Tag == pictureBox2.Tag && pictureBox2.Tag == pictureBox3.Tag)
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            MessageBox.Show("The winner is " + turn);
        }
    }
}

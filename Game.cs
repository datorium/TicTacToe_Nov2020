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

        public Game()
        {
            InitializeComponent();
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
                turn = "o";
            }
            else
            {
                picture.Image = Properties.Resources.o;
                picture.Tag = "o";
                turn = "x";
            }
        }
    }
}

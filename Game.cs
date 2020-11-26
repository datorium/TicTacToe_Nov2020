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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(turn == "x")
            {
                pictureBox1.Image = Properties.Resources.x;
                turn = "o";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.o;
                turn = "x";
            }            
        }
    }
}

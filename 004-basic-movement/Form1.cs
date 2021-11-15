using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_rpg
{
    public partial class Form1 : Form

    {
        int gravity = 30;
        int playerX = 100;
        int playerY = 100;

        int time = 0;

        bool jumping = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Location = new Point(playerX, playerY);
            timer1.Start();
        }

        private void Player_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!jumping && playerY >= 500)
                {
                    jumping = true;
                }
            }

            if (e.KeyCode == Keys.D)
            {
                playerX += 10;
                player.Location = new Point(playerX, playerY);
            }

            if (e.KeyCode == Keys.A)
            {
                playerX -= 10;
                player.Location = new Point(playerX, playerY);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (jumping)
            {
                if (time == 10)
                {
                    jumping = false;
                    time = 0;
                }
                else
                {
                    time += 1;
                    playerY -= 2 * gravity;
                    player.Location = new Point(playerX, playerY);
                }
            }

            if (playerY < 500)
            {
                playerY += gravity;
                player.Location = new Point(playerX, playerY);
            }
        }
    }
}

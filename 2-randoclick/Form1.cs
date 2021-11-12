using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randoclick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool gameStarted = false;
        public int playTime = 0;
        public int time = 0;
        public bool clicked = false;
        public bool gameOver = false;
        int desc = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            gameStarted = true;

            Random random = new Random();
            
            var viewRange = Size - sprite.Size;
            var left = random.Next(0, viewRange.Width);
            var top = random.Next(0, viewRange.Height);

            sprite.Location = new Point(left, top);
        }

        private void sprite_Click(object sender, EventArgs e)
        {
            clicked = true;
            time = 0;

            Random random = new Random();

            var viewRange = this.Size - sprite.Size;
            var left = random.Next(0, viewRange.Width);
            var top = random.Next(0, viewRange.Height);

            sprite.Location = new Point(left, top);
            clicked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(desc == 10)
            {
                time += 1;
                playTime += 1;
                desc = 0;
            }

            if(time == 4 && clicked == false)
            {
                gameOver = true;
                gameStarted = false;
                sprite.Visible = false;
            }
        }
    }
}

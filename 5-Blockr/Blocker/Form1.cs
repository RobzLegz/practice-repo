using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int blockNum = 0;

        int gameTime = 0;
        int desc = 0;
        int clickTime = 5;

        bool hovered = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            BlockButton.Visible = false;
            PlayAgain.Visible = false;
            TimerDisplay.Visible = false;
        }

        public void StartGame()
        {
            StartButton.Visible = false;
            this.BackgroundImage = Properties.Resources.level1background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            BlockButton.Visible = true;
            PlayAgain.Visible = false;
            clickTime = 5;

            Random rand = new Random();

            blockNum = rand.Next(1, 7);
            BlockButton.Text = blockNum.ToString();

            var viewRange = Size - BlockButton.Size;
            var left = rand.Next(0, viewRange.Width);
            var top = rand.Next(0, viewRange.Height);

            BlockButton.Location = new Point(left, top);

            TimerDisplay.Visible = true;
            TimerDisplay.Text = clickTime.ToString();

            timer1.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        public void click()
        {
            blockNum -= 1;
            BlockButton.Text = blockNum.ToString();
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            click();
        }

        private void BlockButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (hovered)
            {
                if (e.KeyCode == Keys.Z)
                {
                    click();
                }

                if (e.KeyCode == Keys.X)
                {
                    click();
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if((clickTime == 0 && blockNum != 0) || blockNum < 0)
            {
                PlayAgain.Visible = true;
                BlockButton.Visible = false;
                this.BackgroundImage = Properties.Resources.background;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                TimerDisplay.Visible = false;
            }

            if(blockNum == 0)
            {
                Random rand = new Random();

                blockNum = rand.Next(1, 7);
                BlockButton.Text = blockNum.ToString();

                var viewRange = Size - BlockButton.Size;
                var left = rand.Next(0, viewRange.Width);
                var top = rand.Next(0, viewRange.Height);

                BlockButton.Location = new Point(left, top);

                clickTime = 5;
            }

            if(desc == 10)
            {
                gameTime += 1;
                clickTime -= 1;
                desc = 0;
            }
            else
            {
                desc += 1;
            }

            TimerDisplay.Text = clickTime.ToString();
        }

        private void BlockButton_MouseHover(object sender, EventArgs e)
        {
            hovered = true;
        }

        private void BlockButton_MouseLeave(object sender, EventArgs e)
        {
            hovered = false;
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}

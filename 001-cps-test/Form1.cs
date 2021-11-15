using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickchamp
{
    public partial class Form1 : Form
    {

        int score = 0;
        int sec = 0;
        int dsec = 0;
        bool gameStarted = false;
        bool gameOver = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonTarget_Click(object sender, EventArgs e)
        {
            score += 1;
            labelScore.Text = "Score: " + score.ToString();

            if (gameStarted == false)
            {
                timer1.Start();
                gameStarted = true;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelScore.Text = "Score: 0";
            buttonTarget.Text = "CLICK";
            buttonRestart.Visible = false;
            avg_cps.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            dsec += 1;
            if(dsec == 10)
            {
                sec += 1;
                dsec = 0;
            }

            labelTimer.Text = sec.ToString() + "." + dsec.ToString();

            if(sec == 10)
            {
                int average = score / 10;

                gameStarted = false;
                gameOver = true;
                buttonTarget.Enabled = false;
                buttonTarget.BackColor = Color.Red;
                buttonTarget.Text = "Time is UP!";
                avg_cps.Text = "Average CPS: " + average.ToString();
                timer1.Stop();
                buttonRestart.Visible = true;
                avg_cps.Visible = true;
            }
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            sec = 0;
            dsec = 0;
            score = 0;
            labelScore.Text = "Score: 0";
            labelTimer.Text = "0.0";
            buttonTarget.BackColor = Color.LightGray;
            buttonTarget.Enabled = true;
            buttonTarget.Text = "CLICK";
            buttonRestart.Visible = false;
            avg_cps.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_stock_market_simulator
{
    public partial class form1 : Form

    {
        Random rand = new Random();
        int time = 0;
        int price = 0;
        int userTotal = 5000;
        int userShares = 0;

        bool paused = false;

        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            price = rand.Next(1, 5000);
            pps.Text = price.ToString();

            shareamount.Text = "Shares: " + userShares.ToString();
            total.Text = "Total: " + userTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(userTotal >= price)
            {
                userTotal -= price;
                userShares += 1;

                shareamount.Text = "Shares: " + userShares.ToString();
                total.Text = "Total: " + userTotal.ToString();
            }
        }

        private void sell_Click(object sender, EventArgs e)
        {
            if(userShares > 0)
            {
                userTotal = userShares * price;
                userShares = 0;

                shareamount.Text = "Shares: " + userShares.ToString();
                total.Text = "Total: " + userTotal.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!paused)
            {
                if (time == 15)
                {
                    price = rand.Next(1, 5000);
                    pps.Text = price.ToString();
                    shareamount.Text = "Shares: " + userShares.ToString();
                    total.Text = "Total: " + userTotal.ToString();
                    time = 0;
                }
                else
                {
                    time += 1;
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            paused = false;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            paused = true;
        }
    }
}

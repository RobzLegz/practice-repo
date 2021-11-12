
namespace _3_stock_market_simulator
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pause = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.pps = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.sell = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shareamount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pause
            // 
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.pause.Location = new System.Drawing.Point(1030, 12);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(221, 74);
            this.pause.TabIndex = 0;
            this.pause.Text = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.start.Location = new System.Drawing.Point(1257, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(126, 74);
            this.start.TabIndex = 1;
            this.start.Text = "play";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pps
            // 
            this.pps.AutoSize = true;
            this.pps.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.pps.Location = new System.Drawing.Point(610, 145);
            this.pps.Name = "pps";
            this.pps.Size = new System.Drawing.Size(132, 48);
            this.pps.TabIndex = 2;
            this.pps.Text = "label1";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.total.Location = new System.Drawing.Point(12, 9);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(132, 48);
            this.total.TabIndex = 3;
            this.total.Text = "label1";
            // 
            // buy
            // 
            this.buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.buy.Location = new System.Drawing.Point(794, 412);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(145, 55);
            this.buy.TabIndex = 4;
            this.buy.Text = "BUY";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.button1_Click);
            // 
            // sell
            // 
            this.sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.sell.Location = new System.Drawing.Point(439, 412);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(145, 55);
            this.sell.TabIndex = 5;
            this.sell.Text = "SELL";
            this.sell.UseVisualStyleBackColor = true;
            this.sell.Click += new System.EventHandler(this.sell_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shareamount
            // 
            this.shareamount.AutoSize = true;
            this.shareamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.shareamount.Location = new System.Drawing.Point(12, 83);
            this.shareamount.Name = "shareamount";
            this.shareamount.Size = new System.Drawing.Size(132, 48);
            this.shareamount.TabIndex = 6;
            this.shareamount.Text = "label1";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 820);
            this.Controls.Add(this.shareamount);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.total);
            this.Controls.Add(this.pps);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pause);
            this.Name = "form1";
            this.Text = "Stock trader";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label pps;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label shareamount;
    }
}


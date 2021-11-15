
namespace Blocker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayAgain = new System.Windows.Forms.Button();
            this.TimerDisplay = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StartButton.Location = new System.Drawing.Point(58, 319);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(300, 100);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Play";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.BackColor = System.Drawing.Color.MediumPurple;
            this.BlockButton.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BlockButton.Location = new System.Drawing.Point(574, 219);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(100, 100);
            this.BlockButton.TabIndex = 1;
            this.BlockButton.UseVisualStyleBackColor = false;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            this.BlockButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlockButton_KeyDown);
            this.BlockButton.MouseLeave += new System.EventHandler(this.BlockButton_MouseLeave);
            this.BlockButton.MouseHover += new System.EventHandler(this.BlockButton_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.DarkOrchid;
            this.PlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgain.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayAgain.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PlayAgain.Location = new System.Drawing.Point(58, 319);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(300, 100);
            this.PlayAgain.TabIndex = 2;
            this.PlayAgain.Text = "Play again";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // TimerDisplay
            // 
            this.TimerDisplay.AutoSize = true;
            this.TimerDisplay.BackColor = System.Drawing.Color.Transparent;
            this.TimerDisplay.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimerDisplay.ForeColor = System.Drawing.Color.White;
            this.TimerDisplay.Location = new System.Drawing.Point(12, 9);
            this.TimerDisplay.Name = "TimerDisplay";
            this.TimerDisplay.Size = new System.Drawing.Size(171, 52);
            this.TimerDisplay.TabIndex = 3;
            this.TimerDisplay.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 671);
            this.Controls.Add(this.TimerDisplay);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Label TimerDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


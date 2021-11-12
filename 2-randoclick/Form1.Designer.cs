
namespace randoclick
{
    partial class Form1
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
            this.sprite = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // sprite
            // 
            this.sprite.BackColor = System.Drawing.Color.DarkOrange;
            this.sprite.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.sprite.Location = new System.Drawing.Point(356, 254);
            this.sprite.Name = "sprite";
            this.sprite.Size = new System.Drawing.Size(100, 100);
            this.sprite.TabIndex = 0;
            this.sprite.UseVisualStyleBackColor = false;
            this.sprite.Click += new System.EventHandler(this.sprite_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.sprite);
            this.Name = "Form1";
            this.Text = "randoclick";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sprite;
        private System.Windows.Forms.Timer timer1;
    }
}


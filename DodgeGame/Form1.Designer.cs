namespace DodgeGame
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.ForeColor = System.Drawing.Color.Transparent;
            this.p1.Location = new System.Drawing.Point(12, 9);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 23);
            this.p1.TabIndex = 1;
            this.p1.Text = "p1Score";
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.ForeColor = System.Drawing.Color.Transparent;
            this.p2.Location = new System.Drawing.Point(472, 9);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 23);
            this.p2.TabIndex = 2;
            this.p2.Text = "p2Score";
            this.p2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timelabel
            // 
            this.timelabel.BackColor = System.Drawing.Color.Transparent;
            this.timelabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.ForeColor = System.Drawing.Color.Transparent;
            this.timelabel.Location = new System.Drawing.Point(219, 7);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(100, 23);
            this.timelabel.TabIndex = 4;
            this.timelabel.Text = "time";
            this.timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label timelabel;
    }
}


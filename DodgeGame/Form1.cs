using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DodgeGame
{
    public partial class Form1 : Form
    {
        SoundPlayer deathplayer = new SoundPlayer(Properties.Resources._417486__mentoslat__8_bit_death_sound);
        SoundPlayer pointplayer = new SoundPlayer(Properties.Resources._450614__breviceps__8_bit_collect_sound_timer_countdown);
        
        Rectangle player1 = new Rectangle(0, 300, 40, 10);
        Rectangle player2 = new Rectangle(545, 300, 40, 10);
        Rectangle point = new Rectangle(270, 280, 50, 50);
       
        int heroSpeed = 10;

        List<Rectangle> balls = new List<Rectangle>();
        List<int> ballSpeeds = new List<int>();
        List<string> ballColours = new List<string>();
        int ballSize = 10;

        int p1score = 0;
        int p2score = 0;
        int time = 500;
       
        bool leftDown = false;
        bool rightDown = false;
        bool aDown = false;
        bool dDown = false;

        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        Random randGen = new Random();
        int randValue = 0;



        int groundHeight = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
           
            if (dDown == true)
            {
                player1.X += heroSpeed;
            }
            if (aDown == true)
            {
                player1.X -= heroSpeed;
            }

            
            if (rightDown == true)
            {
                player2.X += heroSpeed;
            }
            if (leftDown == true)
            {
                player2.X -= heroSpeed;
            }

          
            for (int i = 0; i < balls.Count(); i++)
            {
               
                int y = balls[i].Y + ballSpeeds[i];

               
                balls[i] = new Rectangle(balls[i].X, y, ballSize, ballSize);
            }

           
            randValue = randGen.Next(0, 101);

           
            
            if (randValue < 25) 
            {
                int x = randGen.Next(10, this.Width - ballSize * 2);
                balls.Add(new Rectangle(x, 10, ballSize, ballSize));

                ballSpeeds.Add(randGen.Next(2, 10));

                ballColours.Add("ball");
            }

            for (int i = 0; i < balls.Count(); i++)
            {

                if (balls[i].Y > this.Height - ballSize - groundHeight)
                {
                    balls.RemoveAt(i);
                    ballSpeeds.RemoveAt(i);
                    ballColours.RemoveAt(i);
                }
            }
            for (int i = 0; i < balls.Count(); i++)
            {
                if (player1.IntersectsWith(balls[i]))
                {
                    deathplayer.Play();
                    player1.X = 0;
                    player1.Y = 300;
                    balls.RemoveAt(i);
                    ballSpeeds.RemoveAt(i);
                    ballColours.RemoveAt(i);
                }
                else if (balls[i].IntersectsWith(point))
                {
                    balls.RemoveAt(i);
                    ballSpeeds.RemoveAt(i);
                    ballColours.RemoveAt(i);
                }
                else if (player2.IntersectsWith(balls[i]))
                {
                    deathplayer.Play();
                    player2.X = 545;
                    player2.Y = 300;
                    balls.RemoveAt(i);
                    ballSpeeds.RemoveAt(i);
                    ballColours.RemoveAt(i);
                }
                else if (player1.IntersectsWith(point))
                {
                    pointplayer.Play();
                    p1score++;
                    player1.X = 0;
                    player1.Y = 300;
                }
                else if (player2.IntersectsWith(point))
                {
                    pointplayer.Play();
                    p2score++;
                    player2.X = 545;
                    player2.Y = 300;
                }
                
               
            }

            time--;

            if (time == 0)
            {
                gameTimer.Enabled = false;
            }

            
            
            





            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

            

            p1.Text = $"Score: {p1score}";
            p2.Text = $"Score: {p2score}";
            timelabel.Text = $"Time: {time}";
            

            
            e.Graphics.FillRectangle(blackBrush, 0, this.Height - groundHeight,

                this.Width, groundHeight);

            
            e.Graphics.FillRectangle(whiteBrush, player1);
            e.Graphics.FillRectangle(whiteBrush, player2);
            e.Graphics.FillRectangle(redBrush, point);

       

            for (int i = 0; i < balls.Count(); i++)
            {
                if (ballColours[i] == "ball")
                {
                    e.Graphics.FillRectangle(whiteBrush, balls[i]);
                }
                
            }

            


        }


    }
}

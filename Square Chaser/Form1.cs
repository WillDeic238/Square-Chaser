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

namespace Square_Chaser
{
    public partial class squarechaser : Form
    {
        //All the parts of the border
        Rectangle border1 = new Rectangle(50, 50, 400, 5);
        Rectangle border2 = new Rectangle(50, 50, 5, 400);
        Rectangle border3 = new Rectangle(450, 50, 5, 405);
        Rectangle border4 = new Rectangle(50, 450, 400, 5);

        //Both players, ball and boost
        Rectangle player1 = new Rectangle(75, 75, 15, 15);
        Rectangle player2 = new Rectangle(425, 75, 15, 15);
        Rectangle ball = new Rectangle(250, 250, 10, 10);
        Rectangle boost = new Rectangle(250, 350, 10, 10);
       
        //Brushes to draw all the parts of the game
        SolidBrush borderBrush = new SolidBrush(Color.LimeGreen);
        SolidBrush player1Brush = new SolidBrush(Color.DodgerBlue);
        SolidBrush player2Brush = new SolidBrush (Color.Orange);
        SolidBrush ballBrush = new SolidBrush(Color.White);
        SolidBrush boostBrush = new SolidBrush(Color.Yellow);


        int player1score = 0;
        int player2score = 0;
        int player1speed = 6;
        int player2speed = 6;

        bool wpressed = false;
        bool spressed = false;
        bool uppressed = false;
        bool downPressed = false;
        bool aPressed = false;
        bool dPressed = false;
        bool leftPressed = false;
        bool rightPressed = false;

        Random random = new Random();

        public squarechaser()
        {
            InitializeComponent();
            ball.X = random.Next(80, 446);
            ball.Y = random.Next(80, 446);
            boost.X = random.Next(80, 446);
            boost.Y = random.Next(80, 446);
        }
        private void squarechaser_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //game controls work when key is pressed down
                case Keys.W:
                    wpressed = true;
                    break;
                case Keys.S:
                    spressed = true;
                    break;
                case Keys.Up:
                    uppressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
                case Keys.Left:
                    leftPressed = true;
                    break;
                case Keys.Right:
                    rightPressed = true;
                    break;

            }
        }
        private void squarechaser_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //keys dont work when not pressed down
                case Keys.W:
                    wpressed = false;
                    break;
                case Keys.S:
                    spressed = false;
                    break;
                case Keys.Up:
                    uppressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
                case Keys.Left:
                    leftPressed = false;
                    break;
                case Keys.Right:
                    rightPressed = false;
                    break;

            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //when game starts do this
            MovePlayer();
            GameContact();
            PlayerWin();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {   
            //draws the game
            e.Graphics.FillRectangle(borderBrush, border1);
            e.Graphics.FillRectangle(borderBrush, border2);
            e.Graphics.FillRectangle(borderBrush, border3);
            e.Graphics.FillRectangle(borderBrush, border4);

            e.Graphics.FillRectangle(player1Brush, player1);
            e.Graphics.FillRectangle(player2Brush, player2);
            e.Graphics.FillRectangle(ballBrush, ball);
            e.Graphics.FillEllipse(boostBrush, boost);
        }

        private void p2boostTimer_Tick(object sender, EventArgs e)
        {
            // players new speed with boost
            player2speed = 6;
            p2boostTimer.Enabled = false;
        }

        private void p1boostTimer_Tick(object sender, EventArgs e)
        {
            player1speed = 6;
            p1boostTimer.Enabled = false;
        }

        public void MovePlayer()
        {
            //move player 1
            if (wpressed == true && player1.Y >= 50 && player1.Y <= 450)
            {
                player1.Y = player1.Y - player1speed;
            }
            if (spressed == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y = player1.Y + player1speed;
            }
            if (aPressed == true && player1.X >= 50 && player1.X <= 450)
            {
                player1.X = player1.X - player1speed;
            }
            if (dPressed == true && player1.X >= 50 && player1.X <= 450)
            {
                player1.X = player1.X + player1speed;
            }

            //move player 2
            if (uppressed == true && player2.Y >= 50 && player2.Y <= 450)
            {
                player2.Y = player2.Y - player2speed;
            }
            if (downPressed == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y = player2.Y + player2speed;
            }
            if (rightPressed == true && player2.X >= 50 && player2.X <= 450)
            {
                player2.X = player2.X + player2speed;
            }
            if (leftPressed == true && player2.X >= 50 && player2.X <= 450)
            {
                player2.X = player2.X - player2speed;
            }
        }
        public void GameContact()
        {
            //When the player hits the walls they move to a different position
            if (player1.IntersectsWith(border1))
            {
                player1.Y = 430;
                SoundPlayer player3 = new SoundPlayer(Properties.Resources.jump);
                player3.Play();
            }
            if (player1.IntersectsWith(border2))
            {
                player1.X = 430;
                SoundPlayer player3 = new SoundPlayer(Properties.Resources.jump);
                player3.Play();
            }
            if (player1.IntersectsWith(border3))
            {
                player1.X = 75;
                SoundPlayer player3 = new SoundPlayer(Properties.Resources.jump);
                player3.Play();
            }
            if (player1.IntersectsWith(border4))
            {
                player1.Y = 75;
                SoundPlayer player3 = new SoundPlayer(Properties.Resources.jump);
                player3.Play();

            }
            if (player2.IntersectsWith(border1))
            {
                player2.Y = 430;
                SoundPlayer player3 = new SoundPlayer(Properties.Resources.jump);
                player3.Play();
            }
            if (player2.IntersectsWith(border2))
            {
                player2.X = 430;
                SoundPlayer player3 = new SoundPlayer(Properties.Resources.jump);
                player3.Play();
            }
            if (player2.IntersectsWith(border3))
            {
                player2.X = 75;
                SoundPlayer player3 = new SoundPlayer(Properties.Resources.jump);
                player3.Play();
            }
            if (player2.IntersectsWith(border4))
            {
                player2.Y = 75;
                SoundPlayer player3 = new SoundPlayer(Properties.Resources.jump);
                player3.Play();
            }
            //When player 1 hits the ball they get a point and the ball resets
            if (player1.IntersectsWith(ball))
            {
                player1score = player1score + 1;
                p1scoreLabel.Text = $"{player1score}";
                ball.X = random.Next(80, 446);
                ball.Y = random.Next(80, 446);
                SoundPlayer player4 = new SoundPlayer(Properties.Resources.point);
                player4.Play();
            }
            //WHen player 2 hits the ball they get a point and the ball resets
            if (player2.IntersectsWith(ball))
            {
                player2score = player2score + 1;
                p2scoreLabel.Text = $"{player2score}";
                ball.X = random.Next(80, 446);
                ball.Y = random.Next(80, 446);
                SoundPlayer player4 = new SoundPlayer(Properties.Resources.point);
                player4.Play();
            }
            //WHen player hits yellow square their speed increases
            if (player1.IntersectsWith(boost))
            {
                boost.X = random.Next(80, 446);
                boost.Y = random.Next(80, 446);
                SoundPlayer player5 = new SoundPlayer(Properties.Resources.speed);
                player5.Play();

                p1boostTimer.Enabled = true;
                player1speed = 12;
            }
            if (player2.IntersectsWith(boost))
            {
                boost.X = random.Next(80, 446);
                boost.Y = random.Next(80, 446);
                SoundPlayer player5 = new SoundPlayer(Properties.Resources.speed);
                player5.Play();

                p2boostTimer.Enabled = true;
                player2speed = 12;
            }       
        }
            public void PlayerWin()
            {
            //player wins if their score is 5 and the game resets
            if (player1score == 5)
            {
                winLabel.Text = "Blue Wins";
                ball.X = random.Next(80, 446);
                ball.Y = random.Next(80, 446);
                boost.X = random.Next(80, 446);
                boost.Y = random.Next(80, 446);
                player1.X = 75;
                player1.Y = 75;
                player2.X = 425;
                player2.Y = 75;
                SoundPlayer player5 = new SoundPlayer(Properties.Resources.win);
                player5.Play();

                Refresh();
                System.Threading.Thread.Sleep(5000);

                player1score = 0;
                player2score = 0;
                p2scoreLabel.Text = "0";
                p1scoreLabel.Text = "0";
                winLabel.Text = "...";

            }
            if (player2score == 5)
            {
                winLabel.Text = "Orange Wins";
                ball.X = random.Next(80, 446);
                ball.Y = random.Next(80, 446);
                boost.X = random.Next(80, 446);
                boost.Y = random.Next(80, 446);
                player1.X = 75;
                player1.Y = 75;
                player2.X = 425;
                player2.Y = 75;
                SoundPlayer player5 = new SoundPlayer(Properties.Resources.win);
                player5.Play();

                Refresh();
                System.Threading.Thread.Sleep(5000);

                player1score = 0;
                player2score = 0;
                p2scoreLabel.Text = "0";
                p1scoreLabel.Text = "0";
                winLabel.Text = "...";
            }


            Refresh();
        }
    }
    }

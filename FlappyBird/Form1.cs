using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        // Player physics
        private int velocity = 0;
        private const int gravity = 1;
        private const int jumpPower = -11;
        private const int maxVelocity = 1;

        // Pipe settings
        private const int pipeWidth = 75;
        private int pipeSlidingSpeed = 3;
        private int pipeSpawnInterval = 200;
        private const int minGap = 150;
        private const int maxGap = 250;
        private float minTopPipeHeight;
        private float maxTopPipeHeight;
        private int pipeSpawnCounter = 350;
        private readonly List<PictureBox> pipes = new List<PictureBox>();

        // Form settings
        private const int formWidth = 1280;
        private const int formHeight = 720;

        // Stats
        private int score;


        public Form1()
        {
            InitializeComponent();
            gameTimer.Tick += gameTimer_Tick;
            Form form = this;
            form.Width = formWidth;
            form.Height = formHeight;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;

            lblScore.Font = new Font(lblScore.Font.FontFamily, 24, lblScore.Font.Style);
            lblScore.Left = 25;
            lblScore.Top = 25;

            minTopPipeHeight = (form.ClientSize.Height - pictureGround.Height) * 0.3f;
            maxTopPipeHeight = (form.ClientSize.Height - pictureGround.Height) * 0.7f;

            SetTextPositions();

            lblDeathText.Visible = false;
            lblRestartText.Visible = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            velocity += gravity;
            pictureBird.Top += velocity;

            if (pictureBird.Top < 0) pictureBird.Top = 0;
            if (pictureBird.Bottom > this.Height) pictureBird.Top = this.Height - pictureBird.Height;

            if (velocity > maxVelocity) velocity = maxVelocity;
            if (velocity < jumpPower) velocity = jumpPower;


            if (score >= 20)
            {
                pipeSlidingSpeed = 4;
                pipeSpawnInterval = 175;
            }

            else if (score >= 10)
            {
                pipeSlidingSpeed = 3;
                pipeSpawnInterval = 233;
            }

            else
            {
                pipeSlidingSpeed = 2;
                pipeSpawnInterval = 350;
            }

            //pipe kodları

            //pipe Spawn
            pipeSpawnCounter++;
            if (pipeSpawnCounter >= pipeSpawnInterval)
            {
                CreatePipe();
                pipeSpawnCounter = 0;
            }

            //pipe hareketi
            foreach (var pipe in pipes)
            {
                pipe.Left -= pipeSlidingSpeed;

                if (pipe.Tag?.ToString() == "pipe" && pipe.Right < pictureBird.Left)
                {
                    score++;
                    lblScore.Text = "Score: " + score;
                    pipe.Tag = "scored";
                }

                if (pipe.Right < 0)
                {
                    this.Controls.Remove(pipe);
                    pipes.Remove(pipe);
                    break;
                }
            }

            //Collider kodları
            foreach (var pipe in pipes)
            {
                if (pictureBird.Bounds.IntersectsWith(pipe.Bounds))
                {
                    gameTimer.Stop();
                    lblDeathText.Visible = true;
                    lblRestartText.Visible = true;
                }
            }

            if (pictureBird.Top < 0 || pictureBird.Bottom > this.Height)
            {
                gameTimer.Stop();
                lblDeathText.Visible = true;
                lblRestartText.Visible = true;
            }

            if (pictureBird.Bounds.IntersectsWith(pictureGround.Bounds))
            {
                gameTimer.Stop();
                lblDeathText.Visible = true;
                lblRestartText.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!lblDeathText.Visible)
                {
                    gameTimer.Start();
                    lblStartText.Visible = false;
                    velocity = jumpPower;
                }
            }

            if (e.KeyCode == Keys.R)
            {
                if (lblDeathText.Visible)
                {
                    RestartGame();
                }
            }
        }

        private void CreatePipe()
        {
            Random rnd = new Random();
            int gap = rnd.Next(minGap, maxGap);
            float pipeHeight = rnd.Next((int)minTopPipeHeight, (int)maxTopPipeHeight);

            PictureBox topPipe = new PictureBox();
            topPipe.Image = Properties.Resources.pipe_green1;
            topPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            topPipe.Width = pipeWidth;
            topPipe.Height = (int)pipeHeight;
            topPipe.Top = 0;
            topPipe.Left = this.Width;
            this.Controls.Add(topPipe);
            pipes.Add(topPipe);

            PictureBox bottomPipe = new PictureBox();
            bottomPipe.Image = Properties.Resources.pipe_green;
            bottomPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            bottomPipe.Width = pipeWidth;
            bottomPipe.Height = this.Height - (int)pipeHeight - gap;
            bottomPipe.Top = (int)pipeHeight + gap;
            bottomPipe.Left = this.Width;
            bottomPipe.Tag = "pipe";
            this.Controls.Add(bottomPipe);
            pipes.Add(bottomPipe);
        }

        private void RestartGame()
        {
            gameTimer.Stop();

            pictureBird.Top = this.ClientSize.Height / 2 - pictureBird.Height / 2;
            velocity = 0;

            foreach (var pipe in pipes)
            {
                this.Controls.Remove(pipe);
            }
            pipes.Clear();

            score = 0;
            lblScore.Text = "Score: 0";

            lblDeathText.Visible = false;
            lblRestartText.Visible = false;
            lblStartText.Visible = true;

            pipeSlidingSpeed = 3;
            pipeSpawnInterval = 200;
        }

        private void SetTextPositions()
        {
            lblStartText.Left = ((this.ClientSize.Width - lblStartText.Width) / 2);
            lblStartText.Top = ((this.ClientSize.Height - lblStartText.Height - pictureGround.Height) / 2);
            lblStartText.Font = new Font(lblStartText.Font.FontFamily, 32, lblStartText.Font.Style);

            lblDeathText.Left = ((this.ClientSize.Width - lblDeathText.Width) / 2);
            lblDeathText.Top = ((this.ClientSize.Height - lblDeathText.Height - pictureGround.Height) / 2) - lblRestartText.Height;
            lblDeathText.Font = new Font(lblDeathText.Font.FontFamily, 32, lblDeathText.Font.Style);

            lblRestartText.Left = ((this.ClientSize.Width - lblRestartText.Width) / 2);
            lblRestartText.Top = ((this.ClientSize.Height - lblRestartText.Height - pictureGround.Height) / 2);
            lblRestartText.Font = new Font(lblRestartText.Font.FontFamily, 32, lblRestartText.Font.Style);
        }
    }
}

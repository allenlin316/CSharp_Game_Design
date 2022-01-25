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
using WMPLib;

namespace H005
{
    public partial class Form1 : Form
    {
        SoundPlayer bumpSound = new SoundPlayer("bumpSound.wav");
        WMPLib.WindowsMediaPlayer bgm = new WMPLib.WindowsMediaPlayer(); 
        Random rnd = new Random();
        int playerSpeed = 15;
        int ball_x_speed = 15, ball_y_speed = 15;
        int lifeCnt = 3, score=0, cnt;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            gameStart();
            bgm.URL = "bgm.mp3";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(player.Left > 0 && e.KeyCode == Keys.Left) {
                player.Left -= playerSpeed;
            }
            if(player.Left + player.Width < this.Width && e.KeyCode == Keys.Right) {
                player.Left += playerSpeed;
            }
            if(e.KeyCode == Keys.Escape) { Application.Exit(); }
        }

        void gameStart()
        {
            bgm.controls.play();
            for (int i = 0; i < 300; i += 50) {
                cnt = 0;
                for(int j=0; j < 938; j += 130) {
                    if (cnt >= 6) break;
                    PictureBox pic = new PictureBox();
                    pic.Image = H005.Properties.Resources._0215;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Size = new System.Drawing.Size(100, 25);
                    pic.BringToFront();
                    pic.BackColor = System.Drawing.Color.Transparent;
                    pic.Location = new Point(62 + j, 107 + i);
                    pic.Tag = "enemy";
                    this.Controls.Add(pic);
                    cnt++;
                }
            }
            foreach (Control x in this.Controls) {
                if(x.Tag == "life" && x is Label) {
                    x.Show();
                }
            }
            player.Location = new Point(420, 540);
            ball.Location = new Point(415, 400);
            gameMsg.Hide();
            ball_x_speed = 15;  ball_y_speed = 15;
            score = 0;
            lblScore.Text = "分數: 0";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ball.Top += ball_y_speed;
            ball.Left += ball_x_speed;
            if (ball.Top < 0 || ball.Bounds.IntersectsWith(player.Bounds)) {
                bumpSound.Play();
                ball_y_speed = -ball_y_speed;
            }
            if(ball.Left + ball.Width > this.ClientSize.Width || ball.Left < 0) {
                check.Text = "ball.Left:" + ball.Left + " ball.Width:" + ball.Width + " clientSize:" + this.ClientSize.Width;
                ball_x_speed = -ball_x_speed;
            }
            if (ball.Top + ball.Height > this.ClientSize.Height)
                gameOver();
            foreach (Control x in Controls) {
                if (x.Tag == "enemy" && ball.Bounds.IntersectsWith(x.Bounds)) {
                    //check.Text = ball_y_speed.ToString();
                    bumpSound.Play();
                    ball_y_speed = -ball_y_speed;
                    this.Controls.Remove(x);
                    score++;
                    lblScore.Text = "分數: " + score.ToString();
                }
            }
            if (score >= 36) {
                gameMsg.Text = "You Win!";
                gameMsg.Show();
                timer.Stop();
            }
        }

        void gameOver()
        {
            foreach(Control x in this.Controls) {
                if(x.Visible && x.Tag == "life") {
                    this.Controls.Remove(x);
                    lifeCnt--;
                    break;
                }
            }
            timer.Stop();
            bgm.controls.pause();
            MessageBox.Show("你還剩 " + lifeCnt.ToString() + " 條血","注意",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            if (lifeCnt > 0)
                gameStart();
            else {
                gameMsg.Text = "GameOver";
                gameMsg.Show();
            }   
        }
    }
}

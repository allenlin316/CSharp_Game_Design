using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace H007
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        WindowsMediaPlayer bgm = new WindowsMediaPlayer();
        SoundPlayer shootSound = new SoundPlayer("crash.wav");
        SoundPlayer hitSound = new SoundPlayer("hit.wav");
        SoundPlayer gunSound = new SoundPlayer("gun.wav");
        List<PictureBox> blocks = new List<PictureBox>();
        List<PictureBox> enemies = new List<PictureBox>();
        const int gravity = 10;
        const int jump = 15;
        const int bulletSpeed = 20;
        const int tankSpeed = 15;
        const int alienSpeed = 20;
        int score = 0, timeCnt=0, min=0, sec=0;
        bool goUp = false;
        void gameSetup()
        {
            bgm.URL = "bgm.mp3";
            bgm.controls.play();
            gameSign.Hide();
            player.Top = 215;
            player.Left = 50;
            tank.Left = 1000;
            alien.Left = 900;
            foreach (Control x in this.Controls) {
                if (x is PictureBox && x.Tag == "block")
                {
                    blocks.Add((PictureBox)x);
                }
            }
            enemies.Add(tank);
            enemies.Add(alien);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gameSetup();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            calTimeAndShow();
            // give player gravity
            player.Top += gravity;
            tank.Left -= tankSpeed;
            alien.Left -= alienSpeed;
            foreach(PictureBox enemy in enemies) {
                if (enemy.Left < -100)
                    enemy.Left = 900;
                if (player.Bounds.IntersectsWith(enemy.Bounds)) {
                    gameOver();
                }
            }
            foreach (PictureBox pic in blocks)
            {
                // move blocks
                pic.Left -= 15;
                if (pic.Left <= -150)
                    pic.Left = 750;
                if (player.Top > 250 && !player.Bounds.IntersectsWith(pic.Bounds)) { 
                    gameOver();
                    break;
                }
                if(player.Top > 215 && player.Bounds.IntersectsWith(pic.Bounds)) {
                    player.Top = 215;
                    goUp = false;
                }   
                    
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "fireBullet") {
                    x.Left += bulletSpeed;
                    if(x.Left > 950) {
                        this.Controls.Remove(x);
                        x.Dispose();
                    }
                    foreach(PictureBox enemy in enemies) {
                        if (enemy.Bounds.IntersectsWith(x.Bounds)) {
                            shootSound.Play();
                            enemy.Left = 900;
                            this.Controls.Remove(x);
                            x.Dispose();
                            score++;
                            gamePoint.Text = "得分: " + score.ToString();
                        }
                    }
                }
            }  
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // goUp 用來確保還沒回到地板又再跳一次
            if(e.KeyCode == Keys.Up && !goUp) {
                goUp = true;
                for (int i=0; i<5; i++) {
                   player.Top -= jump;
                }
            }
            if (e.KeyCode == Keys.Space) {
                shotBullet();
            }
        }

        void shotBullet()
        {
            gunSound.Play();
            // make the bullet
            PictureBox bullet = new PictureBox();
            bullet.BackColor = System.Drawing.Color.DarkOrange;
            bullet.Height = 5;
            bullet.Width = 10;
            bullet.Left = 110;
            bullet.Top = this.player.Top+35;
            bullet.Tag = "fireBullet";
            this.Controls.Add(bullet);
        }
        void gameOver()
        {
            hitSound.Play();
            timer1.Stop();
            bgm.controls.stop();
            gameSign.Show();
        }

        void calTimeAndShow()
        {
            timeCnt++;
            int tmpTime;
            tmpTime = timeCnt;
            while (tmpTime / 60 > 0) {
                min = tmpTime / 60;
                sec = tmpTime % 60;
                tmpTime %= 60;
            }
            if (min > 0)
                timerCnt.Text = "時間: " + min + "分 " + sec + "秒";
            else
                timerCnt.Text = "時間: " + timeCnt + "秒";
        }
    }
}

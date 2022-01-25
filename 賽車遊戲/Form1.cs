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

namespace H003
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        const int carMove = 15;
        int enemySpeed = 15;
        int coinSpeed = 10;
        int lineSpeed = 20;
        int x, coinCnt;
        WMPLib.WindowsMediaPlayer bgm = new WMPLib.WindowsMediaPlayer();
        SoundPlayer coinSound = new SoundPlayer("Coin Sound.wav");
        SoundPlayer crashSound = new SoundPlayer("crash.wav");

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgm.URL = "bgm.mp3";
            bgm.controls.play();
            coinCnt = 0;
            timer1.Start();
            gameSign.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameStart();  
            checkCarStatus();
        }

        void gameStart()
        {
            moveLine(lineSpeed);
            moveEnemyCar(enemySpeed);
            moveCoin(coinSpeed);
            coinCollection();
        }

        void moveLine(int lineSpeed)
        {
            if (yellowLine1.Top > 800) yellowLine1.Top = -150;
            else yellowLine1.Top += lineSpeed;
            if (yellowLine2.Top > 800) yellowLine2.Top = -150;
            else yellowLine2.Top += lineSpeed;
            if (yellowLine3.Top > 800) yellowLine3.Top = -150;
            else yellowLine3.Top += lineSpeed;
            if (yellowLine4.Top > 800) yellowLine4.Top = -150;
            else yellowLine4.Top += lineSpeed;
            if (yellowLine6.Top > 800) yellowLine6.Top = -150;
            else yellowLine6.Top += lineSpeed;
        }

        void moveEnemyCar(int speed)
        {
            if (carLeft.Top >= 850) { x = random.Next(20, 360); carLeft.Location = new Point(x, -95); }
            else { carLeft.Top += speed + random.Next(0, 2); }
            if (carMid.Top >= 850) { x = random.Next(20, 360); carMid.Location = new Point(x, -95); }
            else { carMid.Top += speed + random.Next(0, 6); }
            if (carRight.Top >= 850) { x = random.Next(20, 360); carRight.Location = new Point(x, -95); }
            else { carRight.Top += speed + random.Next(0, 10); }
        }

        void moveCoin(int coinSpeed)
        {
            if(coin1.Top >= 850) { x = random.Next(40, 100); coin1.Location = new Point(x, -42); }
            else { coin1.Top += coinSpeed + random.Next(0,2); }
            if (coin2.Top >= 850) { x = random.Next(100, 150); coin2.Location = new Point(x, -42); }
            else { coin2.Top += coinSpeed + random.Next(0, 3); }
            if (coin3.Top >= 850) { x = random.Next(150, 200); coin3.Location = new Point(x, -42); }
            else { coin3.Top += coinSpeed + random.Next(0, 2); }
            if (coin4.Top >= 850) { x = random.Next(200, 330); coin4.Location = new Point(x, -42); }
            else { coin4.Top += coinSpeed + random.Next(0, 3); }
        }
        void coinCollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                coinCnt++;
                score.Text = "得分 : " + coinCnt.ToString();
                coinSound.Play();
                coin1.Location = new Point(random.Next(40, 100));
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                coinCnt++;
                score.Text = "得分 : " + coinCnt;
                coinSound.Play();
                coin2.Location = new Point(random.Next(100, 150));
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                coinCnt++;
                score.Text = "得分 : " + coinCnt;
                coinSound.Play();
                coin3.Location = new Point(random.Next(150, 200));
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                coinCnt++;
                score.Text = "得分 : " + coinCnt;
                coinSound.Play();
                coin4.Location = new Point(random.Next(150, 200));
            }
        }
        void checkCarStatus()
        {
            if (car.Left > 300 || car.Left <= 20) { gameOver(); }
            if (car.Bounds.IntersectsWith(carLeft.Bounds)) { gameOver(); }
            if (car.Bounds.IntersectsWith(carMid.Bounds)) { gameOver(); }
            if (car.Bounds.IntersectsWith(carRight.Bounds)) { gameOver(); }
        }

        void gameOver()
        {
            // crash edge of the road
            car.Image = H003.Properties.Resources.exp; crashSound.Play();
            gameSign.Text = "GameOver";
            gameSign.Show();
            timer1.Stop();
            bgm.controls.stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();
            if (e.KeyCode == Keys.Up)
            {
                lineSpeed += 10; //speed up
                coinSpeed += 10;
                enemySpeed += 10;
            }
            if (e.KeyCode == Keys.Left) car.Left -= carMove;
            if (e.KeyCode == Keys.Right) car.Left += carMove;
        }
    }
}

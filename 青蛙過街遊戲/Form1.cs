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

namespace H002
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer bgm = new WMPLib.WindowsMediaPlayer();
        SoundPlayer scream = new SoundPlayer("frog scream.wav");
        SoundPlayer win = new SoundPlayer("win.wav");
        WMPLib.WindowsMediaPlayer carSound = new WMPLib.WindowsMediaPlayer();
        Random rnd = new Random();
        const int frogMove = 10;
        const int topCarInit = -142;
        const int midCarInit = -300;
        const int lowCarInit = 800;
        int cnt = 3;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void gameStart()
        {
            gameInfo.Hide();
            timer.Start();
            topCar.Left = topCarInit;
            midCar.Left = midCarInit;
            lowCar.Left = lowCarInit;
            carSound.controls.play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bgm.URL = "bgm.mp3";
            carSound.URL = "car1.mp3";
            bgm.controls.play();
            gameStart();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int random = rnd.Next(5, 20);
            int rndIndex = rnd.Next(0, 3);
            topCar.Left += (random + 3);
            midCar.Left += random;
            lowCar.Left -= (random + 10);
            if (topCar.Left >= 945) topCar.Left = topCarInit;
            if (midCar.Left >= 953) midCar.Left = midCarInit;
            if (lowCar.Left <= -160) lowCar.Left = lowCarInit;
            timerDetect.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit(); //end the game
            switch(e.KeyCode)   // frog move control
            {
                case Keys.W:
                case Keys.Up:
                    frog.Top -= frogMove;
                    break;
                case Keys.S:
                case Keys.Down:
                    frog.Top += frogMove;
                    break;
                case Keys.A:
                case Keys.Left:
                    frog.Left -= frogMove;
                    break;
                case Keys.D:
                case Keys.Right:
                    frog.Left += frogMove;
                    break;
                case Keys.Space:
                    gameStart();
                    //carSound.controls.play();
                    break;
            }      
        }

        private void timerDetect_Tick(object sender, EventArgs e)
        {
            if(cnt == 0)
            {
                timer.Stop();
                gameInfo.Text = "GameOver!";
                gameInfo.Show();
                bgm.controls.stop();
                carSound.controls.stop();
                timerDetect.Stop();
            }
            if (frog.Bounds.IntersectsWith(lowCar.Bounds) || frog.Bounds.IntersectsWith(midCar.Bounds) || frog.Bounds.IntersectsWith(topCar.Bounds))
            {
                timer.Stop();
                scream.Play();
                carSound.controls.stop();
                switch (cnt)
                {
                    case 3:
                        life3.Hide();
                        break;
                    case 2:
                        life2.Hide();
                        break;
                    case 1:
                        life1.Hide();
                        break;
                }
                cnt--;
                gameInfo.Text = "按下空白鑑繼續";
                gameInfo.Show();
                timerDetect.Stop();
            }
            if(frog.Top <= 205)
            {
                timer.Stop();
                gameInfo.Text = "Win!";
                gameInfo.Show();
                bgm.controls.stop();
                win.Play();
                carSound.controls.stop();
                timerDetect.Stop();
            }
        }
    }
}

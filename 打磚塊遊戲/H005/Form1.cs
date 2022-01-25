using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H005
{
    public partial class Form1 : Form
    {
        int xx, yy;
        int dx, dy;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.SetBounds(0, 0, 1080, 750);  //設定邊界 0, 0, 1080, 750
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //去除畫面邊界
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xx = 540;  yy = 650;
            dx = -20;   dy = -20;
            pictureBox1.Left = xx;  pictureBox1.Top = yy;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += dx;
            pictureBox1.Top += dy;
            if (pictureBox1.Left + dx > 1030 || pictureBox1.Left + dx < 0) {
                dx = -dx;
            }
            if (pictureBox1.Top + dy > 680 || pictureBox1.Top + dy < 0) {
                dy = -dy;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H006
{
    public partial class Form1 : Form
    {
        static int[,] map =
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,2,1,1,1,1,0,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,0},
            {0,1,1,1,0,1,1,1,1,1,1,1,1,0,0,0,1,1,1,0},
            {0,0,0,0,0,0,0,1,1,1,1,1,1,0,1,1,1,5,1,0},
            {0,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,0},
            {0,1,1,1,1,3,1,1,1,0,0,0,0,0,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
            {0,1,5,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,1,1,4,1,1,1,1,1,1,1,0},
            {0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,0,0,1,1,0},
            {0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,1,0},
            {0,1,1,1,1,0,0,0,1,1,1,1,1,1,1,0,1,1,1,0},
            {0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,1,0},
            {0,1,1,1,1,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0},
            {0,1,1,1,1,0,1,1,1,1,1,1,1,1,5,1,1,1,1,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        }; // 0:obstacle, 1:path, 2:box1Pos, 3:box2Pos, 4:box3Pos, 5:hole for box
        int last_step_y, last_step_x, x = 2, y = 2, winCnt = 0;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.SetBounds(0, 0, 656, 680);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Top = 64; player.Left = 64;
            box1.Top = 2 * 32; box1.Left = 8 * 32;
            box2.Top = 8 * 32; box2.Left = 5 * 32;
            box3.Top = 12 * 32; box3.Left = 11 * 32;
            lblResult.Hide();
            winCnt = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            last_step_x = x; last_step_y = y;
            if (e.KeyCode == Keys.Right) { x++; }
            if (e.KeyCode == Keys.Left) { x--; }
            if (e.KeyCode == Keys.Up) { y--; }
            if (e.KeyCode == Keys.Down) { y++; }

            if(map[y, x] == 0) { // 代表沒路可以走
                x = last_step_x;
                y = last_step_y;
            }
            if (map[y, x] == 2 || map[y, x] == 3 || map[y, x] == 4) // 代表 player 推到箱子
            {
          
                switch(map[y, x])
                {
                    case 2:
                        moveBox(box1, 2);
                        break;
                    case 3:
                        moveBox(box2, 3);
                        break;
                    case 4:
                        moveBox(box3, 4);
                        break;
                }             
            }
            player.Left = x*32;
            player.Top = y*32;
        }

        void moveBox(PictureBox target, int boxSign)
        {
            // 先判斷箱子走到的目的地可不可以走(有路、洞口、沒路)
            if (map[2 * y - last_step_y, 2 * x - last_step_x] == 1 || map[2 * y - last_step_y, 2 * x - last_step_x] == 5)
            {
                target.Left += (x - last_step_x) * 32;
                target.Top += (y - last_step_y) * 32;
                map[y, x] = 1;
                if (map[2 * y - last_step_y, 2 * x - last_step_x] == 5) // 走到其中一個洞了
                {
                    target.Dispose();
                    winCnt++;
                    if (winCnt >= 3) {
                        lblResult.Text = "You Win!";
                        lblResult.Show();
                    }
                }
                if(map[2 * y - last_step_y, 2 * x - last_step_x] != 5) // 讓同一個洞可以放超過一個箱子
                    map[2 * y - last_step_y, 2 * x - last_step_x] = boxSign;
            }
            else //沒路可以走
            {
                x = last_step_x;
                y = last_step_y;
            }
        }
    }
}

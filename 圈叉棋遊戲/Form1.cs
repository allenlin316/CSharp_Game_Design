using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H004
{
    public partial class Form1 : Form
    {
        bool turn, gameFinish; // true: O, false: X;
        int turnCnt, gameMode; // gameMode=1 is player first computer last and vice versa
        Button[] btnStatus = new Button[9];  // specificify an array with button status
        int[,] winGroups = new int[8, 3]{
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8},
            {2, 4, 6}
        };
        public Form1()
        {
            InitializeComponent();
            btnStatus = new Button[9] {button1, button2, button3, button4, button5, button6, button7, button8, button9};
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            turnCnt = 0;
            memo.Text = "";
            //DialogResult option = MessageBox.Show("選擇進攻順序", "提示", MessageBoxButtons.YesNo, new string[] {"先攻", "後攻"});
            Form2 menu = new Form2();
            menu.ShowDialog();
            gameMode = menu.getGameMode();
            //memo.Text = gameMode.ToString();
            gameStart();
        }

        void gameStart()
        {
            if (gameMode == 1)
                return;
            else if (gameMode == 2)
                timer.Start();
            else
                Application.Exit();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (turn) { 
                btn.Text = "O";
                btn.BackColor = Color.LightBlue;
                turn = false; 
            } 
            else {
                btn.Text = "X";
                btn.BackColor = Color.LightSalmon;
                turn = true; 
            }
            btn.Enabled = false;
            turnCnt++;
            checkForWinner(btnStatus, btn.Text);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (gameFinish) timer.Stop();
            computerMove();
        }
        void computerMove()
        {
            if (gameFinish) return;
            string current="";
            int rndIndex=0;
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                rndIndex = random.Next(0, 9);
                if (turn && btnStatus[rndIndex].Enabled)
                {
                    btnStatus[rndIndex].Text = "O";
                    btnStatus[rndIndex].BackColor = Color.LightBlue;
                    turn = false;
                    current = btnStatus[rndIndex].Text;
                    break;
                }
                else if (btnStatus[rndIndex].Enabled)
                {
                    btnStatus[rndIndex].Text = "X";
                    btnStatus[rndIndex].BackColor = Color.LightSalmon;
                    turn = true;
                    current = btnStatus[rndIndex].Text;
                    break;
                }
                i--; //如果是Enabled=true，這次就不算，反正就是要讓他random 9 次
            }
            btnStatus[rndIndex].Enabled = false;
            turnCnt++;
            checkForWinner(btnStatus, current);
            timer.Stop();
        }
        void checkForWinner(Button[] btnStatus, string current)
        {
            if (gameFinish) return;
            // run through the table to check whether there is a winner
            for (int i=0; i<8; i++)
            {
                int a = winGroups[i, 0];
                int b = winGroups[i, 1];
                int c = winGroups[i, 2];
                Button btnControl1 = btnStatus[a];
                Button btnControl2 = btnStatus[b];
                Button btnControl3 = btnStatus[c];

                if (btnControl1.Text == "" || btnControl2.Text == "" || btnControl3.Text == "")
                    continue;
                if (btnControl1.Text == btnControl2.Text && btnControl2.Text == btnControl3.Text)
                {
                    //MessageBox.Show(btnControl1.Text + " " + btnControl2.Text + " " + btnControl3.Text);
                    memo.Text = current + " win!";
                    gameFinish = true;
                    break;
                }
            }
            if (turnCnt == 9 && !gameFinish) { 
                memo.Text = "平手";
                gameFinish = true;
                return; 
            }
        }

        private void 開始遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turnCnt = 0;
            turn = false;
            gameFinish = false;
            memo.Text = "";      
            //Button[] btnStatus = new Button[9];
            btnStatus = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            for (int i = 0; i < 9; i++)
            {
                btnStatus[i].Text = "";
                btnStatus[i].BackColor = Control.DefaultBackColor;
                btnStatus[i].Enabled = true;
            }
            Form2 menu = new Form2();
            menu.ShowDialog();
            gameMode = menu.getGameMode();
            gameStart();
        }

        private void 離開遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 說明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memo.Text = "遊戲開發者: 林品安";
        }
    }
}

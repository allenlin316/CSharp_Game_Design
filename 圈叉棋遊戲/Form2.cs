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
    public partial class Form2 : Form
    {
        int gameMode;
        public Form2()
        {
            InitializeComponent();
        }

        private void playerFirst_Click(object sender, EventArgs e)
        {
            setGameMode(1);
            this.Close();
        }
        private void playerLast_Click(object sender, EventArgs e)
        {
            setGameMode(2);
            this.Close();
        }

        void setGameMode(int mode)
        {
            gameMode = mode;
        }
        public int getGameMode()
        {
            return gameMode;
        }

        
    }
}

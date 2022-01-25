namespace H005
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.gameMsg = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = global::H005.Properties.Resources.ball;
            this.ball.Location = new System.Drawing.Point(339, 434);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(38, 40);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::H005.Properties.Resources.brick;
            this.player.Location = new System.Drawing.Point(360, 537);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(166, 23);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScore.Location = new System.Drawing.Point(9, 7);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(57, 24);
            this.lblScore.TabIndex = 38;
            this.lblScore.Text = "分數: ";
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.BackColor = System.Drawing.Color.Transparent;
            this.lblLife.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLife.Location = new System.Drawing.Point(9, 34);
            this.lblLife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(76, 24);
            this.lblLife.TabIndex = 40;
            this.lblLife.Text = "生命值: ";
            // 
            // life1
            // 
            this.life1.BackColor = System.Drawing.Color.Transparent;
            this.life1.Image = global::H005.Properties.Resources.ball;
            this.life1.Location = new System.Drawing.Point(76, 34);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(21, 23);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 78;
            this.life1.TabStop = false;
            this.life1.Tag = "life";
            // 
            // life3
            // 
            this.life3.BackColor = System.Drawing.Color.Transparent;
            this.life3.Image = global::H005.Properties.Resources.ball;
            this.life3.Location = new System.Drawing.Point(103, 34);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(21, 23);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 79;
            this.life3.TabStop = false;
            this.life3.Tag = "life";
            // 
            // life2
            // 
            this.life2.BackColor = System.Drawing.Color.Transparent;
            this.life2.Image = global::H005.Properties.Resources.ball;
            this.life2.Location = new System.Drawing.Point(130, 35);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(21, 23);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 80;
            this.life2.TabStop = false;
            this.life2.Tag = "life";
            // 
            // gameMsg
            // 
            this.gameMsg.AutoSize = true;
            this.gameMsg.BackColor = System.Drawing.Color.White;
            this.gameMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameMsg.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameMsg.ForeColor = System.Drawing.Color.Red;
            this.gameMsg.Location = new System.Drawing.Point(321, 250);
            this.gameMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameMsg.Name = "gameMsg";
            this.gameMsg.Size = new System.Drawing.Size(265, 63);
            this.gameMsg.TabIndex = 81;
            this.gameMsg.Text = "GameFinal";
            this.gameMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(52, 502);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(33, 12);
            this.check.TabIndex = 82;
            this.check.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::H005.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 570);
            this.Controls.Add(this.check);
            this.Controls.Add(this.gameMsg);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.ball);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "1092923 林品安";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.Label gameMsg;
        private System.Windows.Forms.Label check;
    }
}


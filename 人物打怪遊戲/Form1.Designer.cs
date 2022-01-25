namespace H007
{
    partial class Form
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.block5 = new System.Windows.Forms.PictureBox();
            this.gamePoint = new System.Windows.Forms.Label();
            this.tank = new System.Windows.Forms.PictureBox();
            this.alien = new System.Windows.Forms.PictureBox();
            this.gameSign = new System.Windows.Forms.Label();
            this.timerCnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // block1
            // 
            this.block1.Image = global::H007.Properties.Resources.platform;
            this.block1.Location = new System.Drawing.Point(1, 397);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(206, 47);
            this.block1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block1.TabIndex = 0;
            this.block1.TabStop = false;
            this.block1.Tag = "block";
            // 
            // block2
            // 
            this.block2.Image = global::H007.Properties.Resources.platform;
            this.block2.Location = new System.Drawing.Point(201, 397);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(206, 47);
            this.block2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block2.TabIndex = 3;
            this.block2.TabStop = false;
            this.block2.Tag = "block";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::H007.Properties.Resources.越南大戰跑步;
            this.player.Location = new System.Drawing.Point(37, 273);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(131, 127);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::H007.Properties.Resources.platform;
            this.pictureBox1.Location = new System.Drawing.Point(401, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "block";
            // 
            // block5
            // 
            this.block5.Image = global::H007.Properties.Resources.platform;
            this.block5.Location = new System.Drawing.Point(805, 397);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(223, 47);
            this.block5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block5.TabIndex = 2;
            this.block5.TabStop = false;
            this.block5.Tag = "block";
            // 
            // gamePoint
            // 
            this.gamePoint.AutoSize = true;
            this.gamePoint.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gamePoint.Location = new System.Drawing.Point(12, 9);
            this.gamePoint.Name = "gamePoint";
            this.gamePoint.Size = new System.Drawing.Size(87, 30);
            this.gamePoint.TabIndex = 7;
            this.gamePoint.Text = "得分: 0";
            // 
            // tank
            // 
            this.tank.BackColor = System.Drawing.Color.Transparent;
            this.tank.Image = global::H007.Properties.Resources._59d08cc3334fce336a9bfae8504ec5a8;
            this.tank.Location = new System.Drawing.Point(837, 294);
            this.tank.Name = "tank";
            this.tank.Size = new System.Drawing.Size(152, 106);
            this.tank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tank.TabIndex = 8;
            this.tank.TabStop = false;
            // 
            // alien
            // 
            this.alien.BackColor = System.Drawing.Color.Transparent;
            this.alien.Image = global::H007.Properties.Resources.alien2;
            this.alien.Location = new System.Drawing.Point(778, 162);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(95, 99);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien.TabIndex = 9;
            this.alien.TabStop = false;
            // 
            // gameSign
            // 
            this.gameSign.BackColor = System.Drawing.Color.Red;
            this.gameSign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gameSign.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameSign.ForeColor = System.Drawing.Color.White;
            this.gameSign.Location = new System.Drawing.Point(0, 401);
            this.gameSign.Name = "gameSign";
            this.gameSign.Size = new System.Drawing.Size(1014, 43);
            this.gameSign.TabIndex = 10;
            this.gameSign.Text = "GameOver";
            this.gameSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCnt
            // 
            this.timerCnt.AutoSize = true;
            this.timerCnt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.timerCnt.Location = new System.Drawing.Point(12, 66);
            this.timerCnt.Name = "timerCnt";
            this.timerCnt.Size = new System.Drawing.Size(62, 25);
            this.timerCnt.TabIndex = 11;
            this.timerCnt.Text = "時間: ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::H007.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 444);
            this.Controls.Add(this.timerCnt);
            this.Controls.Add(this.gameSign);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.tank);
            this.Controls.Add(this.gamePoint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.block5);
            this.Controls.Add(this.block1);
            this.KeyPreview = true;
            this.Name = "Form";
            this.Tag = "block";
            this.Text = "1092923 林品安";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox block5;
        private System.Windows.Forms.Label gamePoint;
        private System.Windows.Forms.PictureBox tank;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.Label gameSign;
        private System.Windows.Forms.Label timerCnt;
    }
}


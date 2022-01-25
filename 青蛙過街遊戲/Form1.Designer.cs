namespace H002
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
            this.frog = new System.Windows.Forms.PictureBox();
            this.lowCar = new System.Windows.Forms.PictureBox();
            this.midCar = new System.Windows.Forms.PictureBox();
            this.topCar = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerDetect = new System.Windows.Forms.Timer(this.components);
            this.gameInfo = new System.Windows.Forms.Label();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            this.SuspendLayout();
            // 
            // frog
            // 
            this.frog.BackColor = System.Drawing.Color.Transparent;
            this.frog.Image = global::H002.Properties.Resources.frog;
            this.frog.Location = new System.Drawing.Point(158, 372);
            this.frog.Name = "frog";
            this.frog.Size = new System.Drawing.Size(64, 66);
            this.frog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frog.TabIndex = 0;
            this.frog.TabStop = false;
            // 
            // lowCar
            // 
            this.lowCar.BackColor = System.Drawing.Color.Transparent;
            this.lowCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lowCar.Image = global::H002.Properties.Resources.car021;
            this.lowCar.Location = new System.Drawing.Point(628, 358);
            this.lowCar.Name = "lowCar";
            this.lowCar.Size = new System.Drawing.Size(160, 53);
            this.lowCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowCar.TabIndex = 1;
            this.lowCar.TabStop = false;
            // 
            // midCar
            // 
            this.midCar.BackColor = System.Drawing.Color.Transparent;
            this.midCar.Image = global::H002.Properties.Resources.超世代新型跑車免疫空氣碰撞;
            this.midCar.Location = new System.Drawing.Point(12, 293);
            this.midCar.Name = "midCar";
            this.midCar.Size = new System.Drawing.Size(137, 59);
            this.midCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.midCar.TabIndex = 2;
            this.midCar.TabStop = false;
            // 
            // topCar
            // 
            this.topCar.BackColor = System.Drawing.Color.Transparent;
            this.topCar.Image = global::H002.Properties.Resources.黃色mini3;
            this.topCar.Location = new System.Drawing.Point(173, 260);
            this.topCar.Name = "topCar";
            this.topCar.Size = new System.Drawing.Size(128, 61);
            this.topCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topCar.TabIndex = 3;
            this.topCar.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerDetect
            // 
            this.timerDetect.Tick += new System.EventHandler(this.timerDetect_Tick);
            // 
            // gameInfo
            // 
            this.gameInfo.BackColor = System.Drawing.Color.White;
            this.gameInfo.CausesValidation = false;
            this.gameInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gameInfo.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameInfo.ForeColor = System.Drawing.Color.Red;
            this.gameInfo.Location = new System.Drawing.Point(229, 196);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(365, 61);
            this.gameInfo.TabIndex = 4;
            this.gameInfo.Text = "GameOver";
            this.gameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // life1
            // 
            this.life1.BackColor = System.Drawing.Color.Transparent;
            this.life1.Image = global::H002.Properties.Resources.frog;
            this.life1.Location = new System.Drawing.Point(670, 12);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(32, 34);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 5;
            this.life1.TabStop = false;
            // 
            // life2
            // 
            this.life2.BackColor = System.Drawing.Color.Transparent;
            this.life2.Image = global::H002.Properties.Resources.frog;
            this.life2.Location = new System.Drawing.Point(708, 12);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(32, 34);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 6;
            this.life2.TabStop = false;
            // 
            // life3
            // 
            this.life3.BackColor = System.Drawing.Color.Transparent;
            this.life3.Image = global::H002.Properties.Resources.frog;
            this.life3.Location = new System.Drawing.Point(746, 12);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(32, 34);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 7;
            this.life3.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(607, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "血量 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::H002.Properties.Resources.map01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.gameInfo);
            this.Controls.Add(this.topCar);
            this.Controls.Add(this.midCar);
            this.Controls.Add(this.lowCar);
            this.Controls.Add(this.frog);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "1092923 林品安";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.frog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox frog;
        private System.Windows.Forms.PictureBox lowCar;
        private System.Windows.Forms.PictureBox midCar;
        private System.Windows.Forms.PictureBox topCar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerDetect;
        private System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.Label label1;
    }
}


namespace H006
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
            this.player = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::H006.Properties.Resources.role;
            this.player.Location = new System.Drawing.Point(57, 44);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(41, 44);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.Transparent;
            this.box2.Image = global::H006.Properties.Resources._003;
            this.box2.Location = new System.Drawing.Point(146, 272);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(46, 46);
            this.box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box2.TabIndex = 1;
            this.box2.TabStop = false;
            this.box2.Tag = "box";
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(0, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(638, 76);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.Transparent;
            this.box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box1.Image = global::H006.Properties.Resources._003;
            this.box1.Location = new System.Drawing.Point(267, 63);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(46, 46);
            this.box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box1.TabIndex = 3;
            this.box1.TabStop = false;
            this.box1.Tag = "box";
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.Color.Transparent;
            this.box3.Image = global::H006.Properties.Resources._003;
            this.box3.Location = new System.Drawing.Point(370, 385);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(46, 46);
            this.box3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box3.TabIndex = 4;
            this.box3.TabStop = false;
            this.box3.Tag = "box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::H006.Properties.Resources.map1;
            this.ClientSize = new System.Drawing.Size(638, 638);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1092923 林品安";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box3;
    }
}


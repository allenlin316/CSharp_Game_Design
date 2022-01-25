namespace H004
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.playerFirst = new System.Windows.Forms.Button();
            this.playerLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.Location = new System.Drawing.Point(65, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(216, 42);
            this.title.TabIndex = 0;
            this.title.Text = "決定遊玩順序";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerFirst
            // 
            this.playerFirst.Location = new System.Drawing.Point(30, 77);
            this.playerFirst.Name = "playerFirst";
            this.playerFirst.Size = new System.Drawing.Size(140, 41);
            this.playerFirst.TabIndex = 1;
            this.playerFirst.Text = "先攻";
            this.playerFirst.UseVisualStyleBackColor = true;
            this.playerFirst.Click += new System.EventHandler(this.playerFirst_Click);
            // 
            // playerLast
            // 
            this.playerLast.Location = new System.Drawing.Point(195, 77);
            this.playerLast.Name = "playerLast";
            this.playerLast.Size = new System.Drawing.Size(140, 41);
            this.playerLast.TabIndex = 2;
            this.playerLast.Text = "後攻";
            this.playerLast.UseVisualStyleBackColor = true;
            this.playerLast.Click += new System.EventHandler(this.playerLast_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 138);
            this.Controls.Add(this.playerLast);
            this.Controls.Add(this.playerFirst);
            this.Controls.Add(this.title);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "遊玩順序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button playerFirst;
        private System.Windows.Forms.Button playerLast;
    }
}
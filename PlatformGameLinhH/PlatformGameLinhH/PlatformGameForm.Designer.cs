namespace PlatformGameLinhH
{
    partial class frmPlatformGame
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
            this.components = new System.ComponentModel.Container();
            this.picPlatform = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picPlatform3 = new System.Windows.Forms.PictureBox();
            this.picPlatform1 = new System.Windows.Forms.PictureBox();
            this.picPlatform2 = new System.Windows.Forms.PictureBox();
            this.picDoor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picPoints = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlatform
            // 
            this.picPlatform.BackColor = System.Drawing.Color.Brown;
            this.picPlatform.Location = new System.Drawing.Point(-3, 570);
            this.picPlatform.Name = "picPlatform";
            this.picPlatform.Size = new System.Drawing.Size(489, 50);
            this.picPlatform.TabIndex = 0;
            this.picPlatform.TabStop = false;
            this.picPlatform.Tag = "platform";
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Blue;
            this.picPlayer.Location = new System.Drawing.Point(55, 520);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(30, 50);
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 20;
            this.tmrTimer.Tick += new System.EventHandler(this.TmrTimer_Tick);
            // 
            // picPlatform3
            // 
            this.picPlatform3.BackColor = System.Drawing.Color.Brown;
            this.picPlatform3.Location = new System.Drawing.Point(73, 233);
            this.picPlatform3.Name = "picPlatform3";
            this.picPlatform3.Size = new System.Drawing.Size(132, 36);
            this.picPlatform3.TabIndex = 2;
            this.picPlatform3.TabStop = false;
            this.picPlatform3.Tag = "platform";
            // 
            // picPlatform1
            // 
            this.picPlatform1.BackColor = System.Drawing.Color.Brown;
            this.picPlatform1.Location = new System.Drawing.Point(259, 492);
            this.picPlatform1.Name = "picPlatform1";
            this.picPlatform1.Size = new System.Drawing.Size(146, 36);
            this.picPlatform1.TabIndex = 3;
            this.picPlatform1.TabStop = false;
            this.picPlatform1.Tag = "platform";
            // 
            // picPlatform2
            // 
            this.picPlatform2.BackColor = System.Drawing.Color.Brown;
            this.picPlatform2.Location = new System.Drawing.Point(55, 424);
            this.picPlatform2.Name = "picPlatform2";
            this.picPlatform2.Size = new System.Drawing.Size(150, 36);
            this.picPlatform2.TabIndex = 4;
            this.picPlatform2.TabStop = false;
            this.picPlatform2.Tag = "platform";
            // 
            // picDoor
            // 
            this.picDoor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.picDoor.Location = new System.Drawing.Point(39, 12);
            this.picDoor.Name = "picDoor";
            this.picDoor.Size = new System.Drawing.Size(46, 64);
            this.picDoor.TabIndex = 5;
            this.picDoor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Brown;
            this.pictureBox1.Location = new System.Drawing.Point(259, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 36);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Brown;
            this.pictureBox2.Location = new System.Drawing.Point(259, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 36);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Brown;
            this.pictureBox3.Location = new System.Drawing.Point(25, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 36);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // picPoints
            // 
            this.picPoints.BackColor = System.Drawing.Color.Yellow;
            this.picPoints.Location = new System.Drawing.Point(288, 466);
            this.picPoints.Name = "picPoints";
            this.picPoints.Size = new System.Drawing.Size(20, 20);
            this.picPoints.TabIndex = 9;
            this.picPoints.TabStop = false;
            this.picPoints.Tag = "coin";
            // 
            // frmPlatformGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.picPoints);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picDoor);
            this.Controls.Add(this.picPlatform2);
            this.Controls.Add(this.picPlatform1);
            this.Controls.Add(this.picPlatform3);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picPlatform);
            this.Name = "frmPlatformGame";
            this.Text = "Platform Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlatform;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picPlatform3;
        private System.Windows.Forms.PictureBox picPlatform1;
        private System.Windows.Forms.PictureBox picPlatform2;
        private System.Windows.Forms.PictureBox picDoor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picPoints;
    }
}


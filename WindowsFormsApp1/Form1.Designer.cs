
namespace WindowsFormsApp1
{
    partial class MagicBird
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
            this.bird = new System.Windows.Forms.PictureBox();
            this.downside = new System.Windows.Forms.PictureBox();
            this.upside = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = global::WindowsFormsApp1.Properties.Resources.flappyBird;
            this.bird.Location = new System.Drawing.Point(178, 248);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(107, 68);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // downside
            // 
            this.downside.Image = global::WindowsFormsApp1.Properties.Resources.pipeBottom;
            this.downside.Location = new System.Drawing.Point(331, 430);
            this.downside.Name = "downside";
            this.downside.Size = new System.Drawing.Size(100, 175);
            this.downside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downside.TabIndex = 1;
            this.downside.TabStop = false;
            // 
            // upside
            // 
            this.upside.Image = global::WindowsFormsApp1.Properties.Resources.pipeTop;
            this.upside.Location = new System.Drawing.Point(567, -45);
            this.upside.Name = "upside";
            this.upside.Size = new System.Drawing.Size(100, 261);
            this.upside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upside.TabIndex = 2;
            this.upside.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::WindowsFormsApp1.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(12, 570);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(805, 84);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(309, 590);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(172, 52);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score:0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // MagicBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(816, 651);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.upside);
            this.Controls.Add(this.downside);
            this.Controls.Add(this.bird);
            this.Name = "MagicBird";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MagicBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox downside;
        private System.Windows.Forms.PictureBox upside;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
    }
}


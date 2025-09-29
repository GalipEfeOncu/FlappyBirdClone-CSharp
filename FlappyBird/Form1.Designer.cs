namespace FlappyBird
{
    partial class Form1
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
            this.pictureBird = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureGround = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblStartText = new System.Windows.Forms.Label();
            this.lblDeathText = new System.Windows.Forms.Label();
            this.lblRestartText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBird
            // 
            this.pictureBird.BackColor = System.Drawing.Color.Transparent;
            this.pictureBird.Image = global::FlappyBird.Properties.Resources.yellowbird_midflap;
            this.pictureBird.Location = new System.Drawing.Point(236, 198);
            this.pictureBird.Name = "pictureBird";
            this.pictureBird.Size = new System.Drawing.Size(68, 48);
            this.pictureBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBird.TabIndex = 0;
            this.pictureBird.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pictureGround
            // 
            this.pictureGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureGround.Image = global::FlappyBird.Properties.Resources._base;
            this.pictureGround.Location = new System.Drawing.Point(0, 556);
            this.pictureGround.Name = "pictureGround";
            this.pictureGround.Size = new System.Drawing.Size(1264, 125);
            this.pictureGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGround.TabIndex = 1;
            this.pictureGround.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            // 
            // lblStartText
            // 
            this.lblStartText.AutoSize = true;
            this.lblStartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartText.Location = new System.Drawing.Point(421, 9);
            this.lblStartText.Name = "lblStartText";
            this.lblStartText.Size = new System.Drawing.Size(430, 51);
            this.lblStartText.TabIndex = 3;
            this.lblStartText.Text = "Press Space To Start";
            // 
            // lblDeathText
            // 
            this.lblDeathText.AutoSize = true;
            this.lblDeathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeathText.Location = new System.Drawing.Point(467, 198);
            this.lblDeathText.Name = "lblDeathText";
            this.lblDeathText.Size = new System.Drawing.Size(279, 51);
            this.lblDeathText.TabIndex = 4;
            this.lblDeathText.Text = "You are dead";
            // 
            // lblRestartText
            // 
            this.lblRestartText.AutoSize = true;
            this.lblRestartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestartText.Location = new System.Drawing.Point(421, 262);
            this.lblRestartText.Name = "lblRestartText";
            this.lblRestartText.Size = new System.Drawing.Size(386, 51);
            this.lblRestartText.TabIndex = 5;
            this.lblRestartText.Text = "Press R To Restart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblRestartText);
            this.Controls.Add(this.lblDeathText);
            this.Controls.Add(this.lblStartText);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureGround);
            this.Controls.Add(this.pictureBird);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Flappy Bird Clone";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBird;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureGround;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblStartText;
        private System.Windows.Forms.Label lblDeathText;
        private System.Windows.Forms.Label lblRestartText;
    }
}


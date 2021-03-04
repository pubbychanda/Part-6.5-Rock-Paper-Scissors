namespace Part_6._5_Rock_Paper_Scissors
{
    partial class frmMain
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblOpponentName = new System.Windows.Forms.Label();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.rdoRock = new System.Windows.Forms.RadioButton();
            this.rdoPaper = new System.Windows.Forms.RadioButton();
            this.rdoScissors = new System.Windows.Forms.RadioButton();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown = new System.Windows.Forms.Label();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(265, 108);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(41, 25);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Me";
            // 
            // lblOpponentName
            // 
            this.lblOpponentName.AutoSize = true;
            this.lblOpponentName.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentName.Location = new System.Drawing.Point(506, 108);
            this.lblOpponentName.Name = "lblOpponentName";
            this.lblOpponentName.Size = new System.Drawing.Size(38, 25);
            this.lblOpponentName.TabIndex = 3;
            this.lblOpponentName.Text = "PC";
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.rdoScissors);
            this.grpPlayerChoice.Controls.Add(this.rdoPaper);
            this.grpPlayerChoice.Controls.Add(this.rdoRock);
            this.grpPlayerChoice.Location = new System.Drawing.Point(48, 166);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(134, 91);
            this.grpPlayerChoice.TabIndex = 4;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice: ";
            // 
            // rdoRock
            // 
            this.rdoRock.AutoSize = true;
            this.rdoRock.Location = new System.Drawing.Point(37, 19);
            this.rdoRock.Name = "rdoRock";
            this.rdoRock.Size = new System.Drawing.Size(51, 17);
            this.rdoRock.TabIndex = 0;
            this.rdoRock.Text = "Rock";
            this.rdoRock.UseVisualStyleBackColor = true;
            this.rdoRock.CheckedChanged += new System.EventHandler(this.rdoRock_CheckedChanged);
            // 
            // rdoPaper
            // 
            this.rdoPaper.AutoSize = true;
            this.rdoPaper.Location = new System.Drawing.Point(37, 42);
            this.rdoPaper.Name = "rdoPaper";
            this.rdoPaper.Size = new System.Drawing.Size(53, 17);
            this.rdoPaper.TabIndex = 1;
            this.rdoPaper.Text = "Paper";
            this.rdoPaper.UseVisualStyleBackColor = true;
            this.rdoPaper.CheckedChanged += new System.EventHandler(this.rdoPaper_CheckedChanged);
            // 
            // rdoScissors
            // 
            this.rdoScissors.AutoSize = true;
            this.rdoScissors.Location = new System.Drawing.Point(37, 65);
            this.rdoScissors.Name = "rdoScissors";
            this.rdoScissors.Size = new System.Drawing.Size(64, 17);
            this.rdoScissors.TabIndex = 2;
            this.rdoScissors.Text = "Scissors";
            this.rdoScissors.UseVisualStyleBackColor = true;
            this.rdoScissors.CheckedChanged += new System.EventHandler(this.rdoScissors_CheckedChanged);
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Part_6._5_Rock_Paper_Scissors.Properties.Resources.between_rounds;
            this.imgOpponent.Location = new System.Drawing.Point(454, 136);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(150, 150);
            this.imgOpponent.TabIndex = 1;
            this.imgOpponent.TabStop = false;
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Part_6._5_Rock_Paper_Scissors.Properties.Resources.rock;
            this.imgPlayer.Location = new System.Drawing.Point(191, 136);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(150, 150);
            this.imgPlayer.TabIndex = 0;
            this.imgPlayer.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPlay.Location = new System.Drawing.Point(347, 214);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(101, 34);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play Round!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 600;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // lblCountdown
            // 
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(378, 169);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(35, 37);
            this.lblCountdown.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.lblOpponentName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.imgPlayer);
            this.Name = "frmMain";
            this.Text = "Rock Paper Scissors";
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblOpponentName;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.RadioButton rdoScissors;
        private System.Windows.Forms.RadioButton rdoPaper;
        private System.Windows.Forms.RadioButton rdoRock;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer tmrCountDown;
        private System.Windows.Forms.Label lblCountdown;
    }
}


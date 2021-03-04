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
            this.tmrPictureReset = new System.Windows.Forms.Timer(this.components);
            this.grpScoreBoard = new System.Windows.Forms.GroupBox();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.grpScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(7, 8);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(99, 25);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Player 1:";
            // 
            // lblOpponentName
            // 
            this.lblOpponentName.AutoSize = true;
            this.lblOpponentName.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentName.Location = new System.Drawing.Point(270, 8);
            this.lblOpponentName.Name = "lblOpponentName";
            this.lblOpponentName.Size = new System.Drawing.Size(114, 25);
            this.lblOpponentName.TabIndex = 3;
            this.lblOpponentName.Text = "Computer:";
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.rdoScissors);
            this.grpPlayerChoice.Controls.Add(this.rdoPaper);
            this.grpPlayerChoice.Controls.Add(this.rdoRock);
            this.grpPlayerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerChoice.Location = new System.Drawing.Point(12, 223);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(130, 69);
            this.grpPlayerChoice.TabIndex = 4;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice: ";
            // 
            // rdoRock
            // 
            this.rdoRock.AutoSize = true;
            this.rdoRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRock.Location = new System.Drawing.Point(6, 17);
            this.rdoRock.Name = "rdoRock";
            this.rdoRock.Size = new System.Drawing.Size(53, 19);
            this.rdoRock.TabIndex = 0;
            this.rdoRock.Text = "Rock";
            this.rdoRock.UseVisualStyleBackColor = true;
            this.rdoRock.CheckedChanged += new System.EventHandler(this.rdoRock_CheckedChanged);
            // 
            // rdoPaper
            // 
            this.rdoPaper.AutoSize = true;
            this.rdoPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPaper.Location = new System.Drawing.Point(6, 33);
            this.rdoPaper.Name = "rdoPaper";
            this.rdoPaper.Size = new System.Drawing.Size(58, 19);
            this.rdoPaper.TabIndex = 1;
            this.rdoPaper.Text = "Paper";
            this.rdoPaper.UseVisualStyleBackColor = true;
            this.rdoPaper.CheckedChanged += new System.EventHandler(this.rdoPaper_CheckedChanged);
            // 
            // rdoScissors
            // 
            this.rdoScissors.AutoSize = true;
            this.rdoScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoScissors.Location = new System.Drawing.Point(6, 49);
            this.rdoScissors.Name = "rdoScissors";
            this.rdoScissors.Size = new System.Drawing.Size(71, 19);
            this.rdoScissors.TabIndex = 2;
            this.rdoScissors.Text = "Scissors";
            this.rdoScissors.UseVisualStyleBackColor = true;
            this.rdoScissors.CheckedChanged += new System.EventHandler(this.rdoScissors_CheckedChanged);
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Part_6._5_Rock_Paper_Scissors.Properties.Resources.between_rounds;
            this.imgOpponent.Location = new System.Drawing.Point(275, 36);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(150, 150);
            this.imgOpponent.TabIndex = 1;
            this.imgOpponent.TabStop = false;
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Part_6._5_Rock_Paper_Scissors.Properties.Resources.between_rounds;
            this.imgPlayer.Location = new System.Drawing.Point(12, 36);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(150, 150);
            this.imgPlayer.TabIndex = 0;
            this.imgPlayer.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPlay.Location = new System.Drawing.Point(168, 97);
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
            this.lblCountdown.Location = new System.Drawing.Point(200, 48);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(35, 37);
            this.lblCountdown.TabIndex = 6;
            // 
            // tmrPictureReset
            // 
            this.tmrPictureReset.Interval = 600;
            this.tmrPictureReset.Tick += new System.EventHandler(this.tmrPictureReset_Tick);
            // 
            // grpScoreBoard
            // 
            this.grpScoreBoard.Controls.Add(this.lblTies);
            this.grpScoreBoard.Controls.Add(this.lblLoses);
            this.grpScoreBoard.Controls.Add(this.lblWins);
            this.grpScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScoreBoard.Location = new System.Drawing.Point(330, 227);
            this.grpScoreBoard.Name = "grpScoreBoard";
            this.grpScoreBoard.Size = new System.Drawing.Size(97, 65);
            this.grpScoreBoard.TabIndex = 7;
            this.grpScoreBoard.TabStop = false;
            this.grpScoreBoard.Text = "scoreboard";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(22, 22);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(40, 13);
            this.lblWins.TabIndex = 0;
            this.lblWins.Text = "wins: 0";
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoses.Location = new System.Drawing.Point(19, 35);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(43, 13);
            this.lblLoses.TabIndex = 1;
            this.lblLoses.Text = "loses: 0";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(27, 49);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(35, 13);
            this.lblTies.TabIndex = 2;
            this.lblTies.Text = "ties: 0";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(168, 137);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 34);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Score!";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(330, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Instructions!";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpScoreBoard);
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
            this.grpScoreBoard.ResumeLayout(false);
            this.grpScoreBoard.PerformLayout();
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
        private System.Windows.Forms.Timer tmrPictureReset;
        private System.Windows.Forms.GroupBox grpScoreBoard;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
    }
}


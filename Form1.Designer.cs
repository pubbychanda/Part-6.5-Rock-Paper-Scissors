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
            this.rdoScissors = new System.Windows.Forms.RadioButton();
            this.rdoPaper = new System.Windows.Forms.RadioButton();
            this.rdoRock = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown = new System.Windows.Forms.Label();
            this.tmrPictureReset = new System.Windows.Forms.Timer(this.components);
            this.grpScoreBoard = new System.Windows.Forms.GroupBox();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.numBettingAmount = new System.Windows.Forms.NumericUpDown();
            this.grpGambling = new System.Windows.Forms.GroupBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.grpPlayerChoice.SuspendLayout();
            this.grpScoreBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBettingAmount)).BeginInit();
            this.grpGambling.SuspendLayout();
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
            this.grpPlayerChoice.Location = new System.Drawing.Point(12, 197);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(130, 78);
            this.grpPlayerChoice.TabIndex = 4;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice: ";
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
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPlay.Location = new System.Drawing.Point(168, 164);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(101, 69);
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
            this.lblCountdown.Location = new System.Drawing.Point(199, 92);
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
            this.grpScoreBoard.Location = new System.Drawing.Point(324, 197);
            this.grpScoreBoard.Name = "grpScoreBoard";
            this.grpScoreBoard.Size = new System.Drawing.Size(97, 73);
            this.grpScoreBoard.TabIndex = 7;
            this.grpScoreBoard.TabStop = false;
            this.grpScoreBoard.Text = "scoreboard";
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(324, 347);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 29);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Score!";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInstructions.Location = new System.Drawing.Point(324, 305);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(101, 34);
            this.btnInstructions.TabIndex = 9;
            this.btnInstructions.Text = "Instructions!";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
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
            // numBettingAmount
            // 
            this.numBettingAmount.DecimalPlaces = 2;
            this.numBettingAmount.Location = new System.Drawing.Point(23, 21);
            this.numBettingAmount.Name = "numBettingAmount";
            this.numBettingAmount.Size = new System.Drawing.Size(107, 22);
            this.numBettingAmount.TabIndex = 10;
            this.numBettingAmount.ValueChanged += new System.EventHandler(this.numBettingAmount_ValueChanged);
            // 
            // grpGambling
            // 
            this.grpGambling.Controls.Add(this.lblMoney);
            this.grpGambling.Controls.Add(this.lblBalance);
            this.grpGambling.Controls.Add(this.numBettingAmount);
            this.grpGambling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGambling.Location = new System.Drawing.Point(18, 291);
            this.grpGambling.Name = "grpGambling";
            this.grpGambling.Size = new System.Drawing.Size(177, 80);
            this.grpGambling.TabIndex = 11;
            this.grpGambling.TabStop = false;
            this.grpGambling.Text = "Double \'r Nothin\' Deals";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(6, 23);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(15, 16);
            this.lblMoney.TabIndex = 12;
            this.lblMoney.Text = "$";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(3, 56);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(85, 16);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "Balance: $20";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 383);
            this.Controls.Add(this.grpGambling);
            this.Controls.Add(this.btnInstructions);
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
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            this.grpScoreBoard.ResumeLayout(false);
            this.grpScoreBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBettingAmount)).EndInit();
            this.grpGambling.ResumeLayout(false);
            this.grpGambling.PerformLayout();
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
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.NumericUpDown numBettingAmount;
        private System.Windows.Forms.GroupBox grpGambling;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblMoney;
    }
}


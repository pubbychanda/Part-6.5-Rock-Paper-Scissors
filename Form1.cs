using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6._5_Rock_Paper_Scissors
{
    public partial class frmMain : Form
    {
        Random rng = new Random();
        int OpponentDecision;
        int roundTimer, resetTimer;
        int wins, loses, ties;
        decimal playerBalance = 20;
        string playerDecision, pcDecision;
        int playerWins; 
        /// <summary>
        /// 1 = win, 2 = lose, 3 = tie (playerwins)
        /// </summary>

        public frmMain()
        {
            InitializeComponent();
        }

        public void win_Check(string playerchoice, string pcchoice)
        {
            switch (playerchoice)
            {
                ///player chose rock
                case "rock":
                    switch (pcchoice)
                    {
                        case "rock":
                            playerWins = 3;
                            break;
                        case "paper":
                            playerWins = 2;
                            break;
                        case "scissors":
                            playerWins = 1;
                            break;
                    }
                    break;
                ///player chose paper
                case "paper":
                    switch (pcchoice)
                    {
                        case "rock":
                            playerWins = 1;
                            break;
                        case "paper":
                            playerWins = 3;
                            break;
                        case "scissors":
                            playerWins = 2;
                            break;
                    }
                    break;
                ///player chose scissors
                case "scissors":
                    switch (pcchoice)
                    {
                        case "rock":
                            playerWins = 2;
                            break;
                        case "paper":
                            playerWins = 1;
                            break;
                        case "scissors":
                            playerWins = 3;
                            break;
                    }
                    break;  
            }

            
            ///what to do upon decision
            switch (playerWins)
            {
                ///player wins
                case 1: 
                    lblCountdown.Text = "";
                    imgPlayer.Image = Properties.Resources.you_win;
                    wins++;
                    playerBalance += numBettingAmount.Value;
                    break;
                ///player loses
                case 2:
                    lblCountdown.Text = "";
                    imgPlayer.Image = Properties.Resources.you_lose;
                    playerBalance -= numBettingAmount.Value;
                    loses++;
                    break;
                ///player ties
                case 3:
                    lblCountdown.Text = "";
                    imgPlayer.Image = Properties.Resources.you_tied;
                    ties++;
                    break;
            }
            ///update scoreboard
            lblWins.Text = "wins: " + wins;
            lblLoses.Text = "loses: " + loses;
            lblTies.Text = "ties: " + ties;
            lblBalance.Text = "Balance: $" + playerBalance;
        }

            
        private void rdoRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.rock;
            playerDecision = "rock";
            btnPlay.Enabled = true;
        }

        private void rdoPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
            playerDecision = "paper";
            btnPlay.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            wins = 0;
            loses = 0;
            ties = 0;
            playerBalance = 20;
            numBettingAmount.Value = 0;
            lblLoses.Text = "loses: " + loses;
            lblWins.Text = "wins: " + wins;
            lblTies.Text = "ties: " + ties;
            lblBalance.Text = "Balance: $" + playerBalance;
            rdoPaper.Checked = false;
            rdoRock.Checked = false;
            rdoScissors.Checked = false;
            imgOpponent.Image = Properties.Resources.between_rounds;
            imgPlayer.Image = Properties.Resources.between_rounds;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            FrmInstructions instructionsForm = new FrmInstructions();
            instructionsForm.Show();
        }

        private void lblCountdown_Click(object sender, EventArgs e)
        {

        }

        private void numBettingAmount_ValueChanged(object sender, EventArgs e)
        {
            numBettingAmount.Maximum = playerBalance;
        }

        private void rdoScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.scissors;
            playerDecision = "scissors";
            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if ((rdoPaper.Checked == true || rdoRock.Checked == true || rdoScissors.Checked == true) && numBettingAmount.Value <= playerBalance)
            {
                tmrCountDown.Enabled = true;
            }
            else
            {
                tmrCountDown.Enabled = false;
            }

            roundTimer = 4;
            resetTimer = 0;
            OpponentDecision = rng.Next(1, 4);
        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            roundTimer--;
            lblCountdown.Text = roundTimer + "";
            

            if (roundTimer == -1)
            {
                tmrCountDown.Enabled = false;

                switch (OpponentDecision)
                {
                    ///rock
                    case 1:
                        imgOpponent.Image = Properties.Resources.rock;
                        pcDecision = "rock";
                        break;
                    ///paper
                    case 2:
                        imgOpponent.Image = Properties.Resources.paper;
                        pcDecision = "paper";
                        break;
                    ///scissors
                    case 3:
                        imgOpponent.Image = Properties.Resources.scissors;
                        pcDecision = "scissors";
                        break;
                }
                win_Check(playerDecision, pcDecision);

                tmrPictureReset.Enabled = true;

            }

        }

        private void tmrPictureReset_Tick(object sender, EventArgs e)
        {
            resetTimer++;
            if (resetTimer == 2)
            {
                rdoPaper.Checked = false;
                rdoRock.Checked = false;
                rdoScissors.Checked = false;
                imgOpponent.Image = Properties.Resources.between_rounds;
                imgPlayer.Image = Properties.Resources.between_rounds;
                tmrPictureReset.Enabled = false;
            }
        }
    }
}

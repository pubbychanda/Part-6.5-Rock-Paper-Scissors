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
        int roundTimer = 0;
        int resetTimer;
        string playerDecision;
        string pcDecision;
        Boolean playerWins;

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
                            break;
                        case "paper":
                            playerWins = false;
                            break;
                        case "scissors":
                            playerWins = true;
                            break;
                    }
                    break;
                ///player chose paper
                case "paper":
                    switch (pcchoice)
                    {
                        case "rock":
                            playerWins = true;
                            break;
                        case "paper":
                            break;
                        case "scissors":
                            playerWins = false; 
                            break;
                    }
                    break;
                ///player chose scissors
                case "scissors":
                    switch (pcchoice)
                    {
                        case "rock":
                            playerWins = false;
                            break;
                        case "paper":
                            playerWins = true;
                            break;
                        case "scissors":
                            break;
                    }
                    break;  
            }

            ///what to do upon decision
            if (playerWins == true)
            {
                lblCountdown.Text = "";
            }
            else
            {
                lblCountdown.Text = "";
            }
        }

            
        private void rdoRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.rock;
            playerDecision = "rock";
        }

        private void rdoPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
            playerDecision = "paper";
        }

        private void rdoScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.scissors;
            playerDecision = "scissors";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            roundTimer = 4;
            resetTimer = 0;
            OpponentDecision = rng.Next(1, 4);
            tmrCountDown.Enabled = true;
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
            if (resetTimer == 3)
            {
                imgOpponent.Image = Properties.Resources.between_rounds;
                imgPlayer.Image = Properties.Resources.between_rounds;

                tmrPictureReset.Enabled = false;
            }
        }
    }
}

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
        string playerDecision;
        string pcDecision;

        public frmMain()
        {
            InitializeComponent();
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
            roundTimer = 0;
            OpponentDecision = rng.Next(1, 4);
            tmrCountDown.Enabled = true;
        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            lblCountdown.Text = roundTimer + "";
            roundTimer++;

            if (roundTimer == 3)
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
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Model;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequestercs, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }



        private void WireUpLists()
        {
            selectTeamDropdown.DataSource = null;
            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName";


            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void selectTeamDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tournamentTeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropdown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void deletedSelectedButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // Call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

        }

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form a PrizeModel
            // Take the PrizeModel and put it into our list of selected prizes

            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel Model)
        {
            selectedTeams.Add(Model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }


        private void removePrizeButton_click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
               
                WireUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate the data

            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid entry fee", 
                    "Invalid Fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // create our tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // Wire up our matchups
            // order our list randomly of teams
            // check if it big enough, if not add in byes.
            // Create our first round of matchups
            // Create every round after that 
            TournamentLogic.CreateRounds(tm);


            // Create tournament Entry
            // Create all of the prizes entries
            // create all of the team entries
            GlobalConfig.Connection.CreateTournament(tm);
 
            TournamentLogic.UpdateTournamentResults(tm);

            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();
        }
    }
}

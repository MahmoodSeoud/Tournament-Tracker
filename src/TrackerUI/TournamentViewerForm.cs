using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> Selectedmatchups = new BindingList<MatchupModel>();
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpList();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData() 
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpList()
        {
            roundDropDownLabel.DataSource = rounds;
            matchUpListBox.DataSource = Selectedmatchups;
            matchUpListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds = new BindingList<int>();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            WireUpList();
        }


        private void roundDropDownLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();     
        }

        private void LoadMatchups()
        {
            int rounds = (int)roundDropDownLabel.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == rounds)
                {
                    Selectedmatchups = new BindingList<MatchupModel>();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedOnlyLabel.Checked)
                        {
                            Selectedmatchups.Add(m);
                        }
                    }
                }
            }
            WireUpList();

            DisplayMatchupInfo();
            
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (Selectedmatchups.Count > 0);
            teamOneName.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreValueLabel.Visible = isVisible;
            teamTwoLabel.Visible = isVisible;
            teamTwoScoreValueLabel.Visible = isVisible; 
            scoreTeamTwo.Visible = isVisible;
            vsLabel.Visible = isVisible;
            scoreButtonLabel.Visible = isVisible;  
        }
        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)matchUpListBox.SelectedItem;
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValueLabel.Text = m.Entries[0].Score.ToString();

                        teamTwoLabel.Text = "<bye>";
                        teamTwoScoreValueLabel.Text = "0";
                    }
                    else 
                    {
                        teamOneName.Text = "Not Yet Set";
                        teamOneScoreValueLabel.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreValueLabel.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoLabel.Text = "Not Yet Set";
                        teamTwoScoreValueLabel.Text = "";
                    }
                }
            }
        }

        private void matchUpListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadMatchup();
        }

        private void unplayedOnlyLabel_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }


        private string ValidateData()
        {
            string output = "";

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(teamOneScoreValueLabel.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(teamTwoScoreValueLabel.Text, out teamTwoScore);


            if(!scoreOneValid)
            {
                output = "Score One Value is Not a Valid Number";
            }

            else if (!scoreTwoValid)
            {
                output = "Score Two Value is Not a Valid Number";
            }   

            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "You Did Not Enter a Score For Either Team";
            }

            else if (teamOneScore == teamTwoScore)
            {
                output = "We Do Not Allow Ties In This Application";
            }

            return output;

        }
        private void scoreButtonLabel_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();

            if (errorMessage.Length > 0 )
            {
                MessageBox.Show($"Input Error: {errorMessage}");
                return;
            }

            MatchupModel m = (MatchupModel)matchUpListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        bool scoreValid = double.TryParse(teamOneScoreValueLabel.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = double.Parse(teamOneScoreValueLabel.Text);
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Valid Score for Team One");
                            return;
                        }
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        bool scoreValid = double.TryParse(teamTwoScoreValueLabel.Text, out teamTwoScore);
                        if (scoreValid)
                        {
                            m.Entries[1].Score = double.Parse(teamTwoScoreValueLabel.Text);
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Valid Score for Team Two");
                            return;
                        }
                    }

                }
            }


            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application has the following error: {ex.Message}");
                return;
            }

            GlobalConfig.Connection.UpdateMatchup(m);
        }
    }
}

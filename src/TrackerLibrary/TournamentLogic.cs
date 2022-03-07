using MimeKit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;
using MailKit.Net.Smtp;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(createFirstRound(byes, randomizedTeams));

            CreateOtherRounds(model, rounds);

        }

        public static void UpdateTournamentResults(TournamentModel model)
        {
            int startingRound = model.CheckCurrentRound();

            List<MatchupModel> toScore = new List<MatchupModel>();

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    if (rm.Winner == null && (rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1))
                    {
                        toScore.Add(rm);
                    }
                }
            }

            MarkWinnerInMatchups(toScore);

            AdvanceWinners(toScore, model);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));

            int endingRound = model.CheckCurrentRound();

            if (endingRound > startingRound)
            {
                // Alert users
                AlertUsersToNewRound(model);
            }
        }

        private static void AlertUsersToNewRound(this TournamentModel model)
        {
            int currentRoundNumber = model.CheckCurrentRound();
            List<MatchupModel> curretRound = model.Rounds.Where(x => x.First().MatchupRound == currentRoundNumber).First();

            foreach (MatchupModel matchup in curretRound)
            {
                foreach (MatchupEntryModel me in matchup.Entries)
                {
                    foreach (PersonModel person in me.TeamCompeting.TeamMembers)
                    {
                        AlertPersonToNewRound(person, me.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        private static void AlertPersonToNewRound(PersonModel person, string teamName, MatchupEntryModel competitor)
        {
            if (person.EmailAdress.Length == 0)
            {
                return;
            }
            // person.EmailAdress.Contains("@") && person.EmailAdress.Contains(".")
            string to = "";
            string subject = "";
            TextPart body = new TextPart("plain")
            {Text = ""};
            if (competitor != null)
            {
                subject = $"You have a new matchup with {competitor.TeamCompeting.TeamName}";
                body = new TextPart("plain")
                {
                    Text = @"you have a new matchup 
                            Competitor:
                            MAKMUT
                            Have a Great Time!
                            ~Tournament Tracker",
                };
            }   //{ competitor.TeamCompeting.TeamName}
            else
            {
                subject = "You have a bye week this round";
                body = new TextPart("plain") { 
                    Text = @"Enjoy your round off! 
                            ~Tournament Tracker"
                };
            }

            to = person.EmailAdress;

            EmailLogic.SendEmail(to, subject, body) ;
        }




        private static int CheckCurrentRound(this TournamentModel model)
        {
            int output = 1;

            foreach (List<MatchupModel> round in model.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    output += 1;
                }
            }
            return output;
        }


        private static void AdvanceWinners(List<MatchupModel> models, TournamentModel tournament)
        {

            foreach (MatchupModel m in models)
            {
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel rm in round)
                    {
                        foreach (MatchupEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.Id == m.Id)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchup(rm);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void MarkWinnerInMatchups(List<MatchupModel> models)
        {

            // greater or lesser
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (MatchupModel m in models)
            {
                // For the Bye week entry 
                if (m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }

                // 0 means false, or lowscore wins
                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application");
                    }
                }
                else
                {
                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application");
                    }
                }
            } 
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0]; 
            List<MatchupModel> currentRound = new List<MatchupModel>(); 
            MatchupModel currentMatchUp = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currentMatchUp.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if (currentMatchUp.Entries.Count > 1)
                    {
                        currentMatchUp.MatchupRound = round;
                        currentRound.Add(currentMatchUp); 
                        currentMatchUp = new MatchupModel();   
                    }   
                }

                model.Rounds.Add(currentRound);
                previousRound = currentRound;
                currentMatchUp=new MatchupModel();
                round++;
            }
        }

        private static List<MatchupModel> createFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();
            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if(byes > 0)
                    {
                        byes--;
                    }
                }
            }
            return output;  
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeam = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeam *= 2;
            }

            output = totalTeam - numberOfTeams;
            return output;  
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;
            while (val < teamCount)
            {
                output++;
                val *= 2; 
            }
            return output;
        }
        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
           return teams.OrderBy(a =>Guid.NewGuid()).ToList();
        }
    }
}

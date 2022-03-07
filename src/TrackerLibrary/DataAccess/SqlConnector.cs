using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TrackerLibrary;
using TrackerLibrary.Model;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public void CreatePerson(PersonModel model)
        {
        using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@firstName", model.firstName);
            p.Add("@LastName", model.LastName);
            p.Add("@EmailAddress", model.EmailAdress);
            p.Add("@CellPhoneNumber", model.CellPhoneNumber);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@id");
            }
        }

        /// <summary>
        ///  Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the new Id</returns>
        public void CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
            }


        }

        public void CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeam_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");

                foreach (PersonModel tm in model.TeamMembers)
                {

                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", tm.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);    
                }
            }
        }

        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveTournament(connection, model);

                SaveTournamentPrize(connection, model);

                SaveTournamentEntries(connection, model);

                SaveTournamentRounds(connection, model);

                TournamentLogic.UpdateTournamentResults(model);
            }
        }
        private void SaveTournament(IDbConnection connection,TournamentModel model)
        {
            var tm = new DynamicParameters();
            tm.Add("@TournamentName", model.TournamentName);
            tm.Add("@EntryFee", model.EntryFee);
            tm.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.Tournaments_Insert", tm, commandType: CommandType.StoredProcedure);
            model.Id = tm.Get<int>("@id");
        }

        private void SaveTournamentPrize(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel pz in model.Prizes)
            {

                var tm = new DynamicParameters();
                tm.Add("@TournamentId", model.Id);
                tm.Add("@PrizeId", pz.Id);
                tm.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spTournamentPrizes_Insert", tm, commandType: CommandType.StoredProcedure);
            }
        } 

        private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel tms in model.EnteredTeams)
            {

                var tm = new DynamicParameters();
                tm.Add("@TournamentId", model.Id);
                tm.Add("@TeamId", tms.Id);
                tm.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spTournamentEntries_Insert", tm, commandType: CommandType.StoredProcedure);
            }
        }



        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var tm = new DynamicParameters();
                    tm.Add("@TournamentId", model.Id);
                    tm.Add("@MatchupRound", matchup.MatchupRound);
                    tm.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                    connection.Execute("dbo.spMatchups_Insert", tm, commandType: CommandType.StoredProcedure);

                    matchup.Id = tm.Get<int>("@id");

                    foreach (MatchupEntryModel Entry in matchup.Entries)
                    {
                        tm = new DynamicParameters();
                        tm.Add("@MatchupId", matchup.Id);

                        if (Entry.ParentMatchup == null)
                        {
                            tm.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            tm.Add("@ParentMatchupId", Entry.ParentMatchup.Id);
                        }

                        if (Entry.TeamCompeting == null)
                        {
                        tm.Add("@TeamCompetingId",null);
                        }
                        else
                        {
                            tm.Add("@TeamCompetingId", Entry.TeamCompeting.Id);
                        }
                        tm.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert", tm, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }



        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;  
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

                foreach(TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);

                    team.TeamMembers = connection.Query<PersonModel>("spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TournamentModel>("dbo.spTournament_GetAll").ToList();
                var p = new DynamicParameters();

                foreach (TournamentModel t in output)
                {
                    p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);
                    t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);
                    t.EnteredTeams = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (TeamModel team in t.EnteredTeams)
                    {
                        p = new DynamicParameters();
                        p.Add("@TeamId", team.Id);

                        team.TeamMembers = connection.Query<PersonModel>("spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                    }
                    p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);

                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (MatchupModel m in matchups)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", m.Id);

                        m.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();

                        List<TeamModel> allTeams = GetTeam_All();


                        if (m.WinnerId > 0)
                        {
                            m.Winner = allTeams.Where(x => x.Id == m.WinnerId).First();
                        }

                        foreach (var me in m.Entries)
                        {
                            if (me.TeamCompetingId > 0)
                            {
                                me.TeamCompeting = allTeams.Where(x => x.Id == me.TeamCompetingId).First();
                            }

                            if (me.ParentMatchupId > 0)
                            {
                                me.ParentMatchup = matchups.Where(x => x.Id == me.ParentMatchupId).First(); 
                            }
                        }
                    }

                    List<MatchupModel> currRow = new List<MatchupModel>();
                    int currRound = 1;
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.MatchupRound > currRound)
                        {
                            t.Rounds.Add(currRow);
                            currRow = new List<MatchupModel>();
                            currRound++;
                        }

                        currRow.Add(m);
                    }

                    t.Rounds.Add(currRow);
                }

            }
            return output;
        }

        public void UpdateMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
               
                var tm = new DynamicParameters();

                if (model.Winner != null)
                {
                    tm.Add("@id", model.Id);
                    tm.Add("@WinnerId", model.Winner.Id);

                    connection.Execute("dbo.spMatchups_Update", tm, commandType: CommandType.StoredProcedure);
                }

                //spMatchupEntries_Update

                foreach (MatchupEntryModel me in model.Entries)
                {

                    if (me.TeamCompeting != null)
                    {
                        tm = new DynamicParameters();
                        tm.Add("@id", me.Id);
                        tm.Add("@TeamCompetingId", me.TeamCompeting.Id);
                        tm.Add("@Score", me.Score);

                        connection.Execute("dbo.spMatchupEntries_Update", tm, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }
    } 
}

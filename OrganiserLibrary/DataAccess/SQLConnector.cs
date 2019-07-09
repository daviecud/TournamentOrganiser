using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
    public class SQLConnector : IDataConnection
    {
        public const string db = "TournamentOrganiser";

        /// <summary>
        /// SAves a new person to the database
        /// </summary>
        /// <param name="model">The person information</param>
        /// <returns>Person/Member information</returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            { 
                var p = new DynamicParameters(); //DynamicParameters is from dapper

            //below is the fields that are on form that are completed by user. These below are they inputted details getting sent to db
            p.Add("@Firstname", model.Firstname);
            p.Add("@Lastname", model.Lastname);
            p.Add("@Email", model.Email);
            p.Add("@TelNumber", model.TelNumber);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");

            return model;
            }
        }

        /// <summary>
        /// SAves a new prize to the database
        /// </summary>
        /// <param name="model">The prizes information</param>
        /// <returns>The prize information, including the unqiue indentifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                var p = new DynamicParameters(); //DynamicParameters is using dapper

                //below is the fields that are on form that are completed by user. These below are they inputted details getting sent to db
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("id");

                return model;
            }
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            //Todo - setup sql connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                var team = new DynamicParameters();
                 
                team.Add("@TeamName", model.TeamName);
                team.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", team, commandType: CommandType.StoredProcedure);

                model.Id = team.Get<int>("id");

                foreach (PersonModel member in model.TeamMembers)
                {
                    var p = new DynamicParameters();
                    p.Add("TeamId", model.Id);
                    p.Add("PersonId", member.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);

                }

                return model;
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPerson_GetAll").ToList();
            }
            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            //TODO - setup path to sql connection teams_GetAll 
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }
    }
}

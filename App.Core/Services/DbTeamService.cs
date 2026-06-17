using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class DbTeamService : ITeamService
    {


        private readonly string _connectionString;

        public DbTeamService(string connString)
        {
            _connectionString = connString;
        }

        public void Add(Team team)
        {
           

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"INSERT INTO Teams
                               (TeamId, Name, Captain, EntryFee)
                               VALUES
                               (@TeamId, @Name, @Captain, @EntryFee)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TeamId", team.TeamId);
                cmd.Parameters.AddWithValue("@Name", team.Name);
                cmd.Parameters.AddWithValue("@Captain", team.Captain);
                cmd.Parameters.AddWithValue("@EntryFee", team.EntryFee);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Team> GetAll()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"SELECT TeamId, Name, Captain, EntryFee
                               FROM Teams
                               ORDER BY Name";

                SqlCommand cmd = new SqlCommand(sql, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teams.Add(new Team
                        {
                            TeamId = reader["TeamId"].ToString(),
                            Name = reader["Name"].ToString(),
                            Captain = reader["Captain"].ToString(),
                            EntryFee = Convert.ToDecimal(reader["EntryFee"])
                        });
                    }
                }
            }

            return teams;
        }

        public Team GetById(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"SELECT TeamId, Name, Captain, EntryFee
                               FROM Teams
                               WHERE TeamId = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Team
                        {
                            TeamId = reader["TeamId"].ToString(),
                            Name = reader["Name"].ToString(),
                            Captain = reader["Captain"].ToString(),
                            EntryFee = Convert.ToDecimal(reader["EntryFee"])
                        };
                    }
                }
            }

            return null;
        }

        public void Update(Team team)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"UPDATE Teams
                               SET Name = @Name,
                                   Captain = @Captain,
                                   EntryFee = @EntryFee
                               WHERE TeamId = @TeamId";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", team.Name);
                cmd.Parameters.AddWithValue("@Captain", team.Captain);
                cmd.Parameters.AddWithValue("@EntryFee", team.EntryFee);
                cmd.Parameters.AddWithValue("@TeamId", team.TeamId);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = "DELETE FROM Teams WHERE TeamId = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Team> Search(string keyword)
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"SELECT TeamId, Name, Captain, EntryFee
                               FROM Teams
                               WHERE Name LIKE @keyword
                                  OR Captain LIKE @keyword
                               ORDER BY Name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teams.Add(new Team
                        {
                            TeamId = reader["TeamId"].ToString(),
                            Name = reader["Name"].ToString(),
                            Captain = reader["Captain"].ToString(),
                            EntryFee = Convert.ToDecimal(reader["EntryFee"])
                        });
                    }
                }
            }

            return teams;
        }
    }
}
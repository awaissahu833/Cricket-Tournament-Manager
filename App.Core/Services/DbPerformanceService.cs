using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Numerics;
namespace App.Core.Services
{
    public class DbPerformanceService : IPerformanceService
    {
        private readonly string _connectionString;

        public DbPerformanceService(string connString)
        {
            _connectionString = connString;
        }


        public void Add(Performance p)
        {
            if (string.IsNullOrWhiteSpace(p.PerformanceId))
                p.PerformanceId = "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);


            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            string sql = @"INSERT INTO Performances
                          (PerformanceId, PlayerId, PlayerName, TeamName, Runs, Fours, Sixes, Wickets, Overs)
                           VALUES
                          (@PerformanceId, @PlayerId, @PlayerName, @TeamName, @Runs, @Fours, @Sixes, @Wickets, @Overs)";

            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@PerformanceId", p.PerformanceId);
            cmd.Parameters.AddWithValue("@PlayerId", p.PlayerId ?? "");
            cmd.Parameters.AddWithValue("@PlayerName", p.PlayerName ?? "");
            cmd.Parameters.AddWithValue("@TeamName", p.TeamName ?? "");
            cmd.Parameters.AddWithValue("@Runs", p.Runs);
            cmd.Parameters.AddWithValue("@Fours", p.Fours);
            cmd.Parameters.AddWithValue("@Sixes", p.Sixes);
            cmd.Parameters.AddWithValue("@Wickets", p.Wickets);
            cmd.Parameters.AddWithValue("@Overs", p.Overs);

            cmd.ExecuteNonQuery();
        }

        public void Update(Performance p)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            string sql = @"UPDATE Performances
                           SET PlayerId=@PlayerId,
                               PlayerName=@PlayerName,
                               TeamName=@TeamName,
                               Runs=@Runs,
                               Fours=@Fours,
                               Sixes=@Sixes,
                               Wickets=@Wickets,
                               Overs=@Overs
                           WHERE PerformanceId=@PerformanceId";

            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@PerformanceId", p.PerformanceId);
            cmd.Parameters.AddWithValue("@PlayerId", p.PlayerId ?? "");
            cmd.Parameters.AddWithValue("@PlayerName", p.PlayerName ?? "");
            cmd.Parameters.AddWithValue("@TeamName", p.TeamName ?? "");
            cmd.Parameters.AddWithValue("@Runs", p.Runs);
            cmd.Parameters.AddWithValue("@Fours", p.Fours);
            cmd.Parameters.AddWithValue("@Sixes", p.Sixes);
            cmd.Parameters.AddWithValue("@Wickets", p.Wickets);
            cmd.Parameters.AddWithValue("@Overs", p.Overs);

            cmd.ExecuteNonQuery();
        }

        public void Delete(string performanceId)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            string sql = "DELETE FROM Performances WHERE PerformanceId = @id";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", performanceId);

            cmd.ExecuteNonQuery();
        }

        public Performance GetById(string id)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            string sql = @"SELECT PerformanceId, PlayerId, PlayerName, TeamName,
                                  Runs, Fours, Sixes, Wickets, Overs
                           FROM Performances
                           WHERE PerformanceId = @id";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Performance
                {
                    PerformanceId = reader["PerformanceId"].ToString(),
                    PlayerId = reader["PlayerId"].ToString(),
                    PlayerName = reader["PlayerName"].ToString(),
                    TeamName = reader["TeamName"].ToString(),
                    Runs = Convert.ToInt32(reader["Runs"]),
                    Fours = Convert.ToInt32(reader["Fours"]),
                    Sixes = Convert.ToInt32(reader["Sixes"]),
                    Wickets = Convert.ToInt32(reader["Wickets"]),
                    Overs = reader["Overs"].ToString()
                };
            }

            return null;
        }

        public List<Performance> GetAll()
        {
            var list = new List<Performance>();

            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            string sql = @"SELECT PerformanceId, PlayerId, PlayerName, TeamName,
                                  Runs, Fours, Sixes, Wickets, Overs
                           FROM Performances";

            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Performance
                {
                    PerformanceId = reader["PerformanceId"].ToString(),
                    PlayerId = reader["PlayerId"].ToString(),
                    PlayerName = reader["PlayerName"].ToString(),
                    TeamName = reader["TeamName"].ToString(),
                    Runs = Convert.ToInt32(reader["Runs"]),
                    Fours = Convert.ToInt32(reader["Fours"]),
                    Sixes = Convert.ToInt32(reader["Sixes"]),
                    Wickets = Convert.ToInt32(reader["Wickets"]),
                    Overs = reader["Overs"].ToString()
                });
            }

            return list;
        }

        public List<Performance> GetTopBatters(int topN = 5)
        {
            var list = new List<Performance>();

            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            string sql = @"SELECT TOP(@top)
                                  PlayerId,
                                  PlayerName,
                                  Runs AS Runs,
                                  Fours AS Fours,
                                  Sixes AS Sixes
                           FROM Performances
                            ORDER BY (Runs) DESC
                         
                           ";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@top", topN);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Performance
                {
                    PlayerId = reader["PlayerId"].ToString(),
                    PlayerName = reader["PlayerName"].ToString(),
                    Runs = Convert.ToInt32(reader["Runs"]),
                    Fours = Convert.ToInt32(reader["Fours"]),
                    Sixes = Convert.ToInt32(reader["Sixes"])
                });
            }

            return list;
        }

        public List<Performance> GetTopBowlers(int topN = 5)
        {
            var list = new List<Performance>();

            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            string sql = @"SELECT TOP(@top)
                                  PlayerId,
                                  PlayerName,
                                  Wickets AS Wickets,
                                  Overs AS Overs
                           FROM Performances
                           
                           ORDER BY (Wickets) DESC";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@top", topN);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Performance
                {
                    PlayerId = reader["PlayerId"].ToString(),
                    PlayerName = reader["PlayerName"].ToString(),
                    Wickets = Convert.ToInt32(reader["Wickets"]),
                    Overs = reader["Overs"].ToString()
                });
            }

            return list;
        }
    }
}
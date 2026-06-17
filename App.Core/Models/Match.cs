using App.Core.Utilities;
using System;

namespace App.Core.Models
{
    public class Match
    {
        public string MatchId { get; set; }
        public string Team1Id { get; set; }
        public string Team1Name { get; set; }
        public string Team2Id { get; set; }
        public string Team2Name { get; set; }
        public MatchStatusEnum Status { get; set; }
    }
}

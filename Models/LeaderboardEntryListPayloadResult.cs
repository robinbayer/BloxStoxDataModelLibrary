using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class LeaderboardEntryListPayloadResult
    {
        public int leaderboardEntryListType { get; set; }
        public List<LeaderboardEntry> leaderboardEntries { get; set; }

        public LeaderboardEntryListPayloadResult()
        {
            leaderboardEntries = new List<LeaderboardEntry>();
        }
    }
}

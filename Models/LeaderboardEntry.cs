using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class LeaderboardEntry
    {
        string entryId { get; set; }
        string inGameUserId { get; set; }
        string platform { get; set; }
        string leaderboardTextDetail { get; set; }
        decimal leaderboardNumericDetail { get; set; }

    }
}

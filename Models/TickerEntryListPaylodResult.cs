using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class TickerEntryListPaylodResult
    {
        public List<TickerEntry> tickerEntries { get; set; }
        public int tickerEntryListType { get; set; }


        public TickerEntryListPaylodResult()
        {
            tickerEntries = new List<TickerEntry>();
        }

    }
}

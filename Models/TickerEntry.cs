using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class TickerEntry
    {
        public string tickerSymbol { get; set; }
        public decimal priceTraded { get; set; }       // last bid price
        public string changeDirection { get; set; }        // I is increase from prior day close, D is decrease, U is unchanged
        public decimal changeAmount { get; set; }      // difference between last bid price and prior day close price
    }
}

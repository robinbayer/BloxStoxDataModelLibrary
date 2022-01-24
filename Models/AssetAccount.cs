using System;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class AssetAccount
    {
        public string externalId { get; set; }
        public string referenceName { get; set; }
        public decimal currentUsdValue { get; set; }
        public DateTime markToMarketDateTime { get; set; }
        public string sector { get; set; }
        public string industry { get; set; }
        public string tradingExchange { get; set; }

    }
}

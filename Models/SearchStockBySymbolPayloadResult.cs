using System;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class SearchStockBySymbolPayloadResult
    {
        public int callResultCode { get; set; }
        public string additionalInformation { get; set; }

        public AssetAccount assetAccount { get; set; }

        public SearchStockBySymbolPayloadResult()
        {
            assetAccount = new AssetAccount();
        }

    }
}

using System.Collections.Generic;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class SearchStockByKeywordPayloadResult
    {
        public int callResultCode { get; set; }
        public string additionalInformation { get; set; }
        
        public List<Models.AssetAccount> assetAccounts { get; set; }

        public SearchStockByKeywordPayloadResult()
        {
            assetAccounts = new List<AssetAccount>();
        }

    }
}

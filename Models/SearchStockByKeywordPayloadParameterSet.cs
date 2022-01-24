using System.Collections.Generic;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class SearchStockByKeywordPayloadParameterSet
    {
        public List<string> searchKeywords { get; set; }

        public SearchStockByKeywordPayloadParameterSet()
        {
            searchKeywords = new List<string>();
        }

    }
}

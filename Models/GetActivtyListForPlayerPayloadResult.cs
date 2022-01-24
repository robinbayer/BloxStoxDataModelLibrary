using System.Collections.Generic;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class GetActivtyListForPlayerPayloadResult
    {
        public int callResultCode { get; set; }
        public string additionalInformation { get; set; }

        public List<Transaction> transactions { get; set; }

        public GetActivtyListForPlayerPayloadResult()
        {
            transactions = new List<Transaction>();
        }

    }
}

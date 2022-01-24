using System;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class SearchGamePlayerPayloadResult
    {
        public int callResultCode { get; set; }
        public string additionalInformation { get; set; }
        public int playerStatusCode { get; set; }
        public DateTime joinedGameDateTime { get; set; }
    }
}

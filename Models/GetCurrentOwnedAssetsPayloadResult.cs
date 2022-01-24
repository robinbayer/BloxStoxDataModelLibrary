using System.Collections.Generic;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class GetCurrentOwnedAssetsPayloadResult
    {
        public int callResultCode { get; set; }
        public string additionalInformation { get; set; }

        public List<HeldPosition> heldPositions { get; set; }

        public GetCurrentOwnedAssetsPayloadResult()
        {
            heldPositions = new List<HeldPosition>();
        }

    }
}

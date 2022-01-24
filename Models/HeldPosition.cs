using System;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class HeldPosition : AssetAccount
    {
        public decimal unitsHeld { get; set; }
        public DateTime lastActivityDate { get; set; }
    }
}

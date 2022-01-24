using System;

namespace TequaCreek.BloxStoxDataModelLibrary.Models
{
    public class Transaction
    {

        public string referenceName { get; set; }
        public string transactionDescription { get; set; }
        public DateTime transactionDateTime { get; set; }
        public string debitOrCredit { get; set; }
        public decimal unitVolume { get; set; }
        public decimal basisPrice { get; set; }

    }
}
